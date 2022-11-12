using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using System.Collections.Generic;

using SKSL;
using SKSLC.Generators.Utils;
using System.Text;
using Microsoft.CodeAnalysis.Text;

namespace SKSLC.Generators;

[Generator]
public sealed partial class ShaderMethodSourceGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // Check whether [SkipLocalsInit] can be used
        // C# 9 - Improving performance using the SkipLocalsInit attribute
        IncrementalValueProvider<bool> canUseSkipLocalsInit =
            context.CompilationProvider
            .Select(static (compilation, _) =>
                compilation.Options is CSharpCompilationOptions { AllowUnsafe: true } &&
                compilation.HasAccessibleTypeWithMetadataName("System.Runtime.CompilerServices.SkipLocalsInitAttribute"));

        // Get all declared methods (including global function declarations) with the [ShaderMethod] attribute, and their info
        IncrementalValuesProvider<string> methodNames =
            context.SyntaxProvider
            .ForAttributeWithMetadataName(
                typeof(ShaderMethodAttribute).FullName,
                static (node, _) => node is MethodDeclarationSyntax { AttributeLists.Count: > 0 } or LocalFunctionStatementSyntax { Parent: GlobalStatementSyntax { Parent: CompilationUnitSyntax } },
                static (context, token) =>
                {
                    var methodSymbol = (IMethodSymbol)context.TargetSymbol;
                    return methodSymbol.Name;
                });

        // Get the LoadDispatchMetadata() info (hierarchy and dispatch metadata info)
        IncrementalValuesProvider<(string MethodName, bool CanUseSkipLocalsInit)> dispatchMetadataInfo =
            methodNames
            .Select(static (item, _) => item)
            .Combine(canUseSkipLocalsInit);

        // Generate the [ShaderMethodSource] attributes
        context.RegisterSourceOutput(dispatchMetadataInfo, static (context, data) =>
        {
            context.AddSource($"{data.MethodName}.g.cs", 
                $"// Support Skip Local Attrs: {data.CanUseSkipLocalsInit}\n" +
                $"// Name: {data.MethodName}");
        });
    }
}
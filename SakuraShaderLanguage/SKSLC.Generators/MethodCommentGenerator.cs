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
public sealed partial class ShaderMethodCommentGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
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

        // Generate the [ShaderMethodSource] attributes
        context.RegisterSourceOutput(methodNames, static (context, item) =>
        {
            context.AddSource($"{item}.g.cs", $"// Name: {item}");
        });
    }
}
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Runtime.InteropServices;

namespace SKSLC
{
    public partial class SKSLC
    {
        static public void WramUp()
        {
            var tree = CSharpSyntaxTree.ParseText(@"
                public class MyClass
                {
                    public void MyMethod()
                    {
                    }
                }");

            var syntaxRoot = tree.GetRoot();
            var MyClass = syntaxRoot.DescendantNodes().OfType<ClassDeclarationSyntax>().First();
            var MyMethod = syntaxRoot.DescendantNodes().OfType<MethodDeclarationSyntax>().First();

            Console.WriteLine(MyClass.Identifier.ToString());
            Console.WriteLine(MyMethod.Identifier.ToString());
        }

        [UnmanagedCallersOnly(EntryPoint = "SKSL_WarpUp")]
        static public void _WramUp() => WramUp();
    }
}
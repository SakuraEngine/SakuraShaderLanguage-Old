using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;
using System.Runtime.InteropServices;
using System.Diagnostics;
using SKSLC.Generators;

namespace SKSLC
{
    public partial class SKSLC
    {
        public static IEnumerable<MetadataReference> SLMetaReferences = null;
        static public void Initialize()
        {
            string[] assemblies = { "SKSL.dll", "SKSL.Core.dll" };
            SLMetaReferences = from assembly in assemblies
                let reference = MetadataReference.CreateFromFile(assembly)
                select reference;
        }

        static public void InitializeAndTest()
        {
            Initialize();
            TestWithSimpleComputeShader();
        }

        [UnmanagedCallersOnly(EntryPoint = "SKSLC_Initialize")]
        static public void _Initialize() => Initialize();
        [UnmanagedCallersOnly(EntryPoint = "SKSLC_Test")]
        static public void _Test() => TestWithSimpleComputeShader();
        [UnmanagedCallersOnly(EntryPoint = "SKSLC_InitializeAndTest")]
        static public void _InitializeAndTest() => InitializeAndTest();


        private static void VerifyGeneratedCode<TGenerator>(string source, params string[] diagnosticsIds)
            where TGenerator : class, IIncrementalGenerator, new()
        {
            SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(source);
            CSharpCompilation compilation = CSharpCompilation.Create("original", 
                new SyntaxTree[] { syntaxTree }, SLMetaReferences, new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, allowUnsafe: true));
            IIncrementalGenerator generator = new TGenerator();
            GeneratorDriver driver = CSharpGeneratorDriver.Create(generator);
            driver = driver.RunGeneratorsAndUpdateCompilation(compilation, out Compilation outputCompilation, out ImmutableArray<Diagnostic> diagnostics);
            // Or we can look at the results directly:
            GeneratorDriverRunResult runResult = driver.GetRunResult();
            Debug.Assert(runResult != null);
            GeneratorRunResult generatorResult = runResult.Results[0];
            Debug.Assert(generatorResult.GeneratedSources != null);

            Console.WriteLine(generatorResult.GeneratedSources[0].SourceText);
        }

        public static void TestWithSimpleComputeShader()
        {
            string source = """
            using System.Threading;

            namespace SKSL.Test
            {
                [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
                public class ComputeShader : IComputeShader
                {
                    private readonly ReadWriteBuffer<float4> output;

                    private const float WIDTH = 3200;
                    private const float HEIGHT = 2400;
                    private const float PI = 3.141592653589793238462643383279502f;

                    [ShaderMethod]
                    public void Execute()
                    {
                        if (ThreadID.x >= WIDTH || ThreadID.y >= HEIGHT)
                            return;
                        float x = (float)ThreadID.x / WIDTH;
                        float y = (float)ThreadID.y / HEIGHT;
                        float2 uv = new float2(x, y);
                        float n = 0.0f;
                        float2 c = new float2(-0.445f, 0.0f) + ((uv - new float2(0.5f, 0.5f)) * 2.34f);
                        float2 z = new float2(0.0f, 0.0f);
                        const int M = 128;
                        for (int i = 0; i < M; i++)
                        {
                            z = new float2((z.x * z.x) - (z.y * z.y), (2.0f * z.x) * z.y) + c;
                            if (BuiltIn.Dot(z, z) > 2.0f)
                            {
                                break;
                            }
                            n += 1.0f;
                        }

                        // we use a simple cosine palette to determine color:
                        // http://iquilezles.org/www/articles/palettes/palettes.htm
                        float t = n / (float)M;
                        float3 d = new float3(0.3f, 0.3f, 0.5f);
                        float3 e = new float3(-0.2f, -0.3f, -0.5f);
                        float3 f = new float3(2.1f, 2.0f, 3.0f);
                        float3 g = new float3(0.0f, 0.1f, 0.0f);
                        float4 color = new float4(d + (e * BuiltIn.Cos(((f * t) + g) * 2.0f * PI)), 1.0f);

                        output[((int)WIDTH * ThreadID.y) + ThreadID.x] = color;
                    }
                }
            }
            """;
            VerifyGeneratedCode<ShaderMethodSourceGenerator>(source, "CMPS0047", "CMPS0050");
        }
    }
}
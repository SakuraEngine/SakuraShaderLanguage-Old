namespace SKSL.Test
{
    public class ComputeShader : IComputeShader
    {
        public void Execute()
        {
            var f2 = new float2(1.0f, 2.0f);
            bool2 b2 = Hlsl.FloatToBool(f2);
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {

        }
    }
}
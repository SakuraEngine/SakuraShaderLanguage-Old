namespace SKSL.Test
{
    public class ComputeShader : IComputeShader
    {
        private readonly ReadWriteBuffer<float> y;

        public void Execute()
        {
            var f2 = new float2(1.0f, 2.0f);
            bool2 b2 = BuiltIn.FloatToBool(f2);
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
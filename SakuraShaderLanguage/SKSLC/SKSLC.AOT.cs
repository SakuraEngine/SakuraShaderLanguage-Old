using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SKSLC
{
    public partial class SKSLC
    {
        [UnmanagedCallersOnly(EntryPoint = "SKSLC_Initialize")]
        static public void _Initialize() => Initialize();

        [UnmanagedCallersOnly(EntryPoint = "SKSLC_Test")]
        static public void _Test() => TestWithSimpleComputeShader();

        [UnmanagedCallersOnly(EntryPoint = "SKSLC_InitializeAndTest")]
        static public void _InitializeAndTest() => InitializeAndTest();
    }
}

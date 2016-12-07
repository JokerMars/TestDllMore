using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace TestDllMore
{
    class Program
    {
        static void Main(string[] args)
        {
            hello();

        }

        [DllImport("HelloWorld.dll", EntryPoint = "hello", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public extern static void hello();

    }
}

using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Atk.Native.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AtkObjectPointer
    {
        public IntPtr pointer;

        public bool IsNullPointer
        {
            get { return pointer == IntPtr.Zero; }
        }
    }
}

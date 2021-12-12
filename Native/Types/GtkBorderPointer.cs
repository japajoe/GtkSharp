using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GtkBorderPointer
    {
        public IntPtr pointer;

        public bool IsNullPointer
        {
            get { return pointer == IntPtr.Zero; }
        }
    }
}

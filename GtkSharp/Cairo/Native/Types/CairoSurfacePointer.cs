using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Cairo.Native.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CairoSurfacePointer
    {
        public IntPtr pointer;

        public bool IsNullPointer
        {
            get { return pointer == IntPtr.Zero; }
        }
    }
}

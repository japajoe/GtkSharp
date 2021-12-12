using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GObjectClassPointer
    {
        public IntPtr pointer;

        public bool IsNullPointer
        {
            get { return pointer == IntPtr.Zero; }
        }
    }
}

using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PangoLanguagePointer
    {
        public IntPtr pointer;

        public bool IsNullPointer
        {
            get { return pointer == IntPtr.Zero; }
        }
    }
}
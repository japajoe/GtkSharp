using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Gtk.Native.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GtkSourceCompletionInfoPointer
    {
        public IntPtr pointer;

        public bool IsNullPointer
        {
            get { return pointer == IntPtr.Zero; }
        }
    }
}
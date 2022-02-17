using System;
using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.GLib.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GSList
    {
        public IntPtr data;
        public GSListPointer next;
    }
}
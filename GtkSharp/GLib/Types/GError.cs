using System;
using System.Runtime.InteropServices;

namespace GtkSharp.GLib.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GError
    {
        public uint domain;
        public int code;
        public IntPtr message;
    }
}
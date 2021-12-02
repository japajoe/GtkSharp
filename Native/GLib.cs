using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Native
{
    internal static class GLib
    {
        const string NATIVELIBNAME = "gtksharp";

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GLibSharpObjectUnref(out IntPtr obj);
    }
}

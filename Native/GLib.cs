using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Native
{
    internal static class GLib
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GLibSharpObjectUnref(out IntPtr obj);
    }
}

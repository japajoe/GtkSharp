using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gdk.Native
{
    internal static class NativeGdkWindow
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gdk_window_set_cursor(GObjectPointer window, GObjectPointer cursor);
    }
}
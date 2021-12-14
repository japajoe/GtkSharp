using System.Runtime.InteropServices;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeBin
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_bin_get_child(GtkWidgetPointer bin);
    }
}
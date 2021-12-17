using System.Runtime.InteropServices;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gtk.Native.CSS
{
    internal static class NativeStyleContext
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_style_context_new();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_style_context_add_provider_for_screen(GdkScreenPointer screen, GObjectPointer style_provider, uint priority);
    }
}
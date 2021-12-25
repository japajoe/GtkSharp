using System.Runtime.InteropServices;
using GtkSharp.Gdk.Types;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeColorChooser
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_color_chooser_get_type(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_color_chooser_get_rgba(GObjectPointer chooser, out GdkRGBA color);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_color_chooser_set_rgba(GObjectPointer chooser, ref GdkRGBA color);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_color_chooser_get_use_alpha(GObjectPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_color_chooser_set_use_alpha(GObjectPointer chooser, bool use_alpha); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_color_chooser_add_palette(GObjectPointer chooser, GtkOrientation orientation, int colors_per_line, int n_colors, ref GdkRGBA colors);
    }
}
using System.Runtime.InteropServices;
using GtkSharp.Gdk.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeColorChooser
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_color_chooser_get_type(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_color_chooser_get_rgba(GtkWidgetPointer chooser, out GdkRGBA color);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_color_chooser_set_rgba(GtkWidgetPointer chooser, ref GdkRGBA color);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_color_chooser_get_use_alpha(GtkWidgetPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_color_chooser_set_use_alpha(GtkWidgetPointer chooser, bool use_alpha); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_color_chooser_add_palette(GtkWidgetPointer chooser, GtkOrientation orientation, int colors_per_line, int n_colors, ref GdkRGBA colors);
    }
}
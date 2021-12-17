using System;
using System.Runtime.InteropServices;
using GtkSharp.Cairo.Native.Types;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gdk.Types;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gdk.Native
{
    internal static class NativeGdkScreen
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gdk_screen_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkVisualPointer gdk_screen_get_system_visual(GdkScreenPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkVisualPointer gdk_screen_get_rgba_visual(GdkScreenPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gdk_screen_is_composited(GdkScreenPointer screen); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkWindowPointer gdk_screen_get_root_window(GdkScreenPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkDisplayPointer gdk_screen_get_display(GdkScreenPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gdk_screen_get_number(GdkScreenPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gdk_screen_get_width(GdkScreenPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gdk_screen_get_height(GdkScreenPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gdk_screen_get_width_mm(GdkScreenPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gdk_screen_get_height_mm(GdkScreenPointer screen); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GListPointer gdk_screen_list_visuals(GdkScreenPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GListPointer gdk_screen_get_toplevel_windows(GdkScreenPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gdk_screen_make_display_name(GdkScreenPointer screen); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gdk_screen_get_n_monitors(GdkScreenPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gdk_screen_get_primary_monitor(GdkScreenPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gdk_screen_get_monitor_geometry(GdkScreenPointer screen, int monitor_num, ref GdkRectangle dest);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gdk_screen_get_monitor_workarea(GdkScreenPointer screen, int monitor_num, ref GdkRectangle dest); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gdk_screen_get_monitor_at_point(GdkScreenPointer screen, int x, int y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gdk_screen_get_monitor_at_window(GdkScreenPointer screen, GdkWindowPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gdk_screen_get_monitor_width_mm(GdkScreenPointer screen, int monitor_num);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gdk_screen_get_monitor_height_mm(GdkScreenPointer screen, int monitor_num);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gdk_screen_get_monitor_plug_name(GdkScreenPointer screen, int monitor_num);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gdk_screen_get_monitor_scale_factor(GdkScreenPointer screen, int monitor_num); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkScreenPointer gdk_screen_get_default(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gdk_screen_get_setting(GdkScreenPointer screen, string name, GValuePointer value); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gdk_screen_set_font_options(GdkScreenPointer screen, CairoFontOptionsPointer options);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CairoFontOptionsPointer gdk_screen_get_font_options(GdkScreenPointer screen); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gdk_screen_set_resolution(GdkScreenPointer screen, double dpi);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern double gdk_screen_get_resolution(GdkScreenPointer screen); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkWindowPointer gdk_screen_get_active_window(GdkScreenPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GListPointer gdk_screen_get_window_stack(GdkScreenPointer screen);
    }
}
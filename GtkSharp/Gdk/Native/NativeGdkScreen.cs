using System;
using System.Runtime.InteropServices;
using GtkSharp.Cairo.Native.Types;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gdk.Types;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gdk.Native
{
    public static class NativeGdkScreen
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gdk_screen_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkVisualPointer gdk_screen_get_system_visual(GObjectPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkVisualPointer gdk_screen_get_rgba_visual(GObjectPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_screen_is_composited(GObjectPointer screen); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkWindowPointer gdk_screen_get_root_window(GObjectPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkDisplayPointer gdk_screen_get_display(GObjectPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_screen_get_number(GObjectPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_screen_get_width(GObjectPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_screen_get_height(GObjectPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_screen_get_width_mm(GObjectPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_screen_get_height_mm(GObjectPointer screen); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GListPointer gdk_screen_list_visuals(GObjectPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GListPointer gdk_screen_get_toplevel_windows(GObjectPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gdk_screen_make_display_name(GObjectPointer screen); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_screen_get_n_monitors(GObjectPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_screen_get_primary_monitor(GObjectPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_screen_get_monitor_geometry(GObjectPointer screen, int monitor_num, ref GdkRectangle dest);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_screen_get_monitor_workarea(GObjectPointer screen, int monitor_num, ref GdkRectangle dest); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_screen_get_monitor_at_point(GObjectPointer screen, int x, int y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_screen_get_monitor_at_window(GObjectPointer screen, GdkWindowPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_screen_get_monitor_width_mm(GObjectPointer screen, int monitor_num);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_screen_get_monitor_height_mm(GObjectPointer screen, int monitor_num);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gdk_screen_get_monitor_plug_name(GObjectPointer screen, int monitor_num);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_screen_get_monitor_scale_factor(GObjectPointer screen, int monitor_num); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_screen_get_default(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_screen_get_setting(GObjectPointer screen, string name, GValuePointer value); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_screen_set_font_options(GObjectPointer screen, CairoFontOptionsPointer options);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern CairoFontOptionsPointer gdk_screen_get_font_options(GObjectPointer screen); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_screen_set_resolution(GObjectPointer screen, double dpi);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double gdk_screen_get_resolution(GObjectPointer screen); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkWindowPointer gdk_screen_get_active_window(GObjectPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GListPointer gdk_screen_get_window_stack(GObjectPointer screen);
    }
}
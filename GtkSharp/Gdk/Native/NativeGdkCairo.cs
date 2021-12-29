using System.Runtime.InteropServices;
using GtkSharp.Cairo.Native.Types;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gdk.Types;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gdk.Native
{
    public static class NativeGdkCairo
    {
        const string NATIVELIB_GDKCAIRO = "gtk-3";
        
        [DllImport(NATIVELIB_GDKCAIRO, CallingConvention = CallingConvention.Cdecl)]
        public static extern CairoPointer gdk_cairo_create(GdkWindowPointer window);
        
        [DllImport(NATIVELIB_GDKCAIRO, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_cairo_get_clip_rectangle(CairoPointer cr, out GdkRectangle rect); 
        
        [DllImport(NATIVELIB_GDKCAIRO, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_cairo_set_source_rgba(CairoPointer cr, ref GdkRGBA rgba);
        
        [DllImport(NATIVELIB_GDKCAIRO, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_cairo_set_source_pixbuf(CairoPointer cr, GObjectPointer pixbuf, double pixbuf_x, double pixbuf_y);
        
        [DllImport(NATIVELIB_GDKCAIRO, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_cairo_set_source_window(CairoPointer cr, GdkWindowPointer window, double x, double y); 
        
        [DllImport(NATIVELIB_GDKCAIRO, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_cairo_rectangle(CairoPointer cr, ref GdkRectangle rectangle);
        
        [DllImport(NATIVELIB_GDKCAIRO, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_cairo_region(CairoPointer cr, CairoRegionPointer region); 
        
        [DllImport(NATIVELIB_GDKCAIRO, CallingConvention = CallingConvention.Cdecl)]
        public static extern CairoRegionPointer gdk_cairo_region_create_from_surface(CairoSurfacePointer surface); 
        
        [DllImport(NATIVELIB_GDKCAIRO, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_cairo_set_source_color(CairoPointer cr, ref GdkColor color); 
        
        [DllImport(NATIVELIB_GDKCAIRO, CallingConvention = CallingConvention.Cdecl)]
        public static extern CairoRegionPointer gdk_cairo_surface_create_from_pixbuf(GObjectPointer pixbuf, int scale, GdkWindowPointer for_window);
        
        [DllImport(NATIVELIB_GDKCAIRO, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_cairo_draw_from_gl(CairoPointer cr, GdkWindowPointer window, int source, int source_type, int buffer_scale, int x, int y, int width, int height);
    }
}
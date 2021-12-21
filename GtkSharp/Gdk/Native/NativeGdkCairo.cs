using System.Runtime.InteropServices;
using GtkSharp.Cairo.Native.Types;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gdk.Types;

namespace GtkSharp.Gdk.Native
{
    internal static class NativeGdkCairo
    {
        const string NATIVELIB_GDKPIXBUF = "gdk_pixbuf-2.0";
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CairoPointer gdk_cairo_create(GdkWindowPointer window);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gdk_cairo_get_clip_rectangle(CairoPointer cr, out GdkRectangle rect); 
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gdk_cairo_set_source_rgba(CairoPointer cr, ref GdkRGBA rgba);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gdk_cairo_set_source_pixbuf(CairoPointer cr, GdkPixbufPointer pixbuf, double pixbuf_x, double pixbuf_y);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gdk_cairo_set_source_window(CairoPointer cr, GdkWindowPointer window, double x, double y); 
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gdk_cairo_rectangle(CairoPointer cr, ref GdkRectangle rectangle);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gdk_cairo_region(CairoPointer cr, CairoRegionPointer region); 
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CairoRegionPointer gdk_cairo_region_create_from_surface(CairoSurfacePointer surface); 
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gdk_cairo_set_source_color(CairoPointer cr, ref GdkColor color); 
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CairoRegionPointer gdk_cairo_surface_create_from_pixbuf(GdkPixbufPointer pixbuf, int scale, GdkWindowPointer for_window);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gdk_cairo_draw_from_gl(CairoPointer cr, GdkWindowPointer window, int source, int source_type, int buffer_scale, int x, int y, int width, int height);
    }
}
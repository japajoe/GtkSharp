using System;
using System.Runtime.InteropServices;
using GtkSharp.Cairo.Native.Types;
using GtkSharp.Cairo.Types;

namespace GtkSharp.Cairo.Native
{
    internal static class NativeCairoImageSurface
    {
        const string NATIVELIBNAME = "cairo";
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CairoSurfacePointer cairo_image_surface_create(CairoFormat format, int width, int height);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int cairo_format_stride_for_width(CairoFormat format, int width);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CairoSurfacePointer cairo_image_surface_create_for_data(IntPtr data, CairoFormat format, int width, int height, int stride);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cairo_image_surface_get_data(CairoSurfacePointer surface);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CairoFormat cairo_image_surface_get_format(CairoSurfacePointer surface);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int cairo_image_surface_get_width(CairoSurfacePointer surface);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int cairo_image_surface_get_height(CairoSurfacePointer surface);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int cairo_image_surface_get_stride(CairoSurfacePointer surface);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CairoSurfacePointer cairo_image_surface_create_from_png(string filename);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CairoSurfacePointer cairo_image_surface_create_from_png_stream(CairoReadFunc read_func, IntPtr closure);
    }
}
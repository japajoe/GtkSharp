using System.Runtime.InteropServices;
using GtkSharp.Cairo.Native.Types;

namespace GtkSharp.Cairo.Native
{
    internal static class NativeCairoSurface
    {
        const string NATIVELIBNAME = "cairo";
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void cairo_surface_get_device_offset(CairoSurfacePointer surface, out double x_offset, out double y_offset);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void cairo_surface_set_device_offset(CairoSurfacePointer surface, double x_offset, double y_offset);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void cairo_surface_mark_dirty_rectangle(CairoSurfacePointer surface, int x, int y, int width, int height);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void cairo_surface_destroy(CairoSurfacePointer surface);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint cairo_surface_get_reference_count(CairoSurfacePointer surface);
    }
}
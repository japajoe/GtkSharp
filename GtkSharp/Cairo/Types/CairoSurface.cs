using GtkSharp.Cairo.Native;
using GtkSharp.Cairo.Native.Types;

namespace GtkSharp.Cairo.Types
{
    public class CairoSurface
    {
        public CairoSurfacePointer handle;

        public CairoSurface(CairoSurface other, CairoContent content, int width, int height)
        {
            handle = NativeCairoSurface.cairo_surface_create_similar(other.handle, content, width, height);
        }

        public CairoSurface(CairoSurface other, CairoFormat format, int width, int height)
        {
            handle = NativeCairoSurface.cairo_surface_create_similar_image(other.handle, format, width, height);
        }

        public CairoSurface(CairoSurface target, double x, double y, double width, double height)
        {
            handle = NativeCairoSurface.cairo_surface_create_for_rectangle(target.handle, x, y, width, height);
        }

        public CairoSurface(string filepath)
        {
            handle = NativeCairoImageSurface.cairo_image_surface_create_from_png(filepath);
        }

        public void GetDeviceOffset(out double x, out double y)
        {
            if(handle.IsNullPointer)
            {
                x = 0;
                y = 0;
                return;
            }
            
            NativeCairoSurface.cairo_surface_get_device_offset(handle, out x, out y);
        }        

        public void SetDeviceOffset(double x, double y)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeCairoSurface.cairo_surface_set_device_offset(handle, x, y);
        }

        public void MarkDirtyRectangle(int x, int y, int width, int height)
        {
            if(handle.IsNullPointer)
                return;
            NativeCairoSurface.cairo_surface_mark_dirty_rectangle(handle, x, y, width, height);
        }

        public void Destroy()
        {
            if(handle.IsNullPointer)
                return;

            NativeCairoSurface.cairo_surface_destroy(handle);
        }

        public uint GetReferenceCount()
        {
            if(handle.IsNullPointer)
                return 0;
            
            return NativeCairoSurface.cairo_surface_get_reference_count(handle);
        }
    }
}
using GtkSharp.Cairo.Native;

namespace GtkSharp.Cairo.Types
{
    public class CairoImageSurface : CairoSurface
    {
        public int Width
        {
            get
            {
                return GetWidth();
            }
        }

        public int Height
        {
            get
            {
                return GetHeight();
            }
        }

        public int Stride
        {
            get
            {
                return GetStride();
            }
        }

        public CairoImageSurface(string filepath)
        {
            handle = NativeCairoImageSurface.cairo_image_surface_create_from_png(filepath);
        }

        private int GetWidth()
        {
            if(handle.IsNullPointer)
                return 0;
            return NativeCairoImageSurface.cairo_image_surface_get_width(handle);
        }

        private int GetHeight()
        {
            if(handle.IsNullPointer)
                return 0;
            return NativeCairoImageSurface.cairo_image_surface_get_height(handle);
        }

        private int GetStride()
        {
            if(handle.IsNullPointer)
                return 0;
            return NativeCairoImageSurface.cairo_image_surface_get_stride(handle);
        }
    }
}
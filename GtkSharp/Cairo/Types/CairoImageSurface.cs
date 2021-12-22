using GtkSharp.Cairo.Native;

namespace GtkSharp.Cairo.Types
{
    public class CairoImageSurface : CairoSurface
    {
        public CairoImageSurface(CairoSurface other, CairoContent content, int width, int height) : base(other, content, width, height)
        {
        }

        public CairoImageSurface(CairoSurface other, CairoFormat format, int width, int height) : base(other, format, width, height)
        {
        }

        public CairoImageSurface(CairoSurface target, double x, double y, double width, double height) : base(target, x, y, width, height)
        {
        }

        public CairoImageSurface(string filepath) : base(filepath)
        {
        }

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
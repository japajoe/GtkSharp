using System.Runtime.InteropServices;

namespace GtkSharp.Gdk.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GdkRGBA
    {
        public double red;
        public double green;
        public double blue;
        public double alpha;

        public GdkRGBA(double r, double g, double b, double a)
        {
            this.red = r;
            this.green = g;
            this.blue = b;
            this.alpha = a;
        }

        public GdkRGBA(byte r, byte g, byte b, byte a)
        {
            this.red = (double)(r / 255.0);
            this.green = (double)(g / 255.0);
            this.blue = (double)(b / 255.0);
            this.alpha = (double)(a / 255.0);
        }
    }    
}
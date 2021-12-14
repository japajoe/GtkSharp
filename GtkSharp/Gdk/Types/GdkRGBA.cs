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
    }    
}
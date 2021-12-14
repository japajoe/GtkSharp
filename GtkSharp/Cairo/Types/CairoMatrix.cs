using System.Runtime.InteropServices;

namespace GtkSharp.Cairo.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CairoMatrix
    {
        public double xx; 
        public double yx;
        public double xy; 
        public double yy;
        public double x0; 
        public double y0;
    }
}
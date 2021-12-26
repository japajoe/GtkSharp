using System.Runtime.InteropServices;

namespace GtkSharp.Gdk.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GdkGeometry
    {
        public int min_width;
        public int min_height;
        public int max_width;
        public int max_height;
        public int base_width;
        public int base_height;
        public int width_inc;
        public int height_inc;
        public double min_aspect;
        public double max_aspect;
        public GdkGravity win_gravity;
    }
}

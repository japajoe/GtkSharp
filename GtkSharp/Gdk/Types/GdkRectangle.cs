using System.Runtime.InteropServices;

namespace GtkSharp.Gdk.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GdkRectangle 
    {
        public int x;
        public int y;
        public int width;
        public int height;
    }
}
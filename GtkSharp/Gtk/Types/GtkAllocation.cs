using System.Runtime.InteropServices;

namespace GtkSharp.Gtk.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GtkAllocation 
    {
        public int x;
        public int y;
        public int width;
        public int height;
    }
}
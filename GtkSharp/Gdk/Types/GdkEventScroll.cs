using System.Runtime.InteropServices;
using GtkSharp.Gdk.Native.Types;

namespace GtkSharp.Gdk.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventScroll
    {
        public GdkEventType type;
        public GdkWindowPointer window;
        public sbyte send_event;
        public uint time;
        public double x;
        public double y;
        public uint state;
        public GdkScrollDirection direction;
        public GdkDevicePointer device;
        public double x_root;
        public double y_root;
        public double delta_x;
        public double delta_y;
    }
}
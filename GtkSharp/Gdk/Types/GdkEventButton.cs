using System;
using System.Runtime.InteropServices;
using GtkSharp.Gdk.Native.Types;

namespace GtkSharp.Gdk.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventButton
    {
        public GdkEventType type;
        public GdkWindowPointer window;
        public sbyte sendEvent;
        public uint time;
        public double x;
        public double y;
        public IntPtr axes;
        public uint state;
        public uint button;
        public GdkDevicePointer device;
        public double xRoot;
        public double yRoot;
    }
}

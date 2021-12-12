using System;
using GtkSharp.Native.Types;
using System.Runtime.InteropServices;

namespace GtkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public class GdkEventMotion
    {
        public GdkEventType type;
        public GdkWindowPointer window;
        public sbyte sendEvent;
        public uint time;
        public double x;
        public double y;
        public IntPtr axes;
        public uint state;
        public short isHint;
        public GdkDevicePointer device;
        public double xRoot;
        public double yRoot;
    }
}
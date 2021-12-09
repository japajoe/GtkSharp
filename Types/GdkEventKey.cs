using System;
using System.Runtime.InteropServices;
using GtkSharp.Native;

namespace GtkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventKey
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte sendEvent;
        public uint time;
        public uint state;
        public uint keyval;
        public int length;
        public IntPtr str;
        public ushort hardwareKeyCode;
        public byte group;
        public uint isModifier;
    }
}
using System.Runtime.InteropServices;

namespace GtkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GdkColor
    {
        public uint pixel;
        public ushort red;
        public ushort green;
        public ushort blue;
    }
}
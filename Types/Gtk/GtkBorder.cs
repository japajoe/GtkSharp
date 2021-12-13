using System.Runtime.InteropServices;

namespace GtkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GtkBorder
    {
        public short left;
        public short right;
        public short top;
        public short bottom;
    }
}

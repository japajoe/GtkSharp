using System.Runtime.InteropServices;

namespace GtkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GtkRequisition
    {
        public int width;
        public int height;
    }
}
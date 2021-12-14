using System.Runtime.InteropServices;

namespace GtkSharp.Gtk.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GtkRequisition
    {
        public int width;
        public int height;
    }
}
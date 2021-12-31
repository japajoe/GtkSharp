using System.Runtime.InteropServices;

namespace GtkSharp.Gdk.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GdkKeymapKey
    {
        public uint keycode;
        public int group;
        public int level;
    }
}
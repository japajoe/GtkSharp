using System;

namespace GtkSharp.Gtk.Types
{
    [Flags]
    public enum GtkAccelFlags : int
    {
        Visible        = 1 << 0,
        Locked         = 1 << 1,
        Mask           = 0x07
    }
}

using System;

namespace GtkSharp.Gtk.Types
{
    [Flags]
    public enum GtkStateFlags : int
    {
        Normal       = 0,
        Active       = 1 << 0,
        Prelight     = 1 << 1,
        Selected     = 1 << 2,
        Insensitive  = 1 << 3,
        Inconsistent = 1 << 4,
        Focused      = 1 << 5,
        Backdrop     = 1 << 6,
        DirLtr      = 1 << 7,
        DirRtl      = 1 << 8,
        Link         = 1 << 9,
        Visited      = 1 << 10,
        Checked      = 1 << 11
    }
}
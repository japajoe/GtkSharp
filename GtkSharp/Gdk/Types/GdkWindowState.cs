using System;

namespace GtkSharp.Gdk.Types
{
    [Flags]
    public enum GdkWindowState : int
    {
        Withdrawn  = 1 << 0,
        Iconified  = 1 << 1,
        Maximized  = 1 << 2,
        Sticky     = 1 << 3,
        Fullscreen = 1 << 4,
        Above      = 1 << 5,
        Below      = 1 << 6,
        Focused    = 1 << 7,
        Tiled      = 1 << 8
    }
}
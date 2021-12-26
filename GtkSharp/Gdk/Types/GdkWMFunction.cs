using System;

namespace GtkSharp.Gdk.Types
{
    [Flags]
    public enum GdkWMFunction : int
    {
        All	= 1 << 0,
        Resize = 1 << 1,
        Move = 1 << 2,
        Minimize = 1 << 3,
        Maximize = 1 << 4,
        Close = 1 << 5
    }
}
using System;

namespace GtkSharp.Gdk.Types
{
    [Flags]
    public enum GdkWMDecoration : int
    {
        All	= 1 << 0,
        Border = 1 << 1,
        ResizeH	= 1 << 2,
        Title = 1 << 3,
        Menu = 1 << 4,
        Minimize = 1 << 5,
        Maximize = 1 << 6
    }
}
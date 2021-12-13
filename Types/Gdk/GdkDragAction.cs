using System;

namespace GtkSharp
{
    [Flags]
    public enum GdkDragAction : int
    {
        Default = 1 << 0,
        Copy    = 1 << 1,
        Move    = 1 << 2,
        Link    = 1 << 3,
        Private = 1 << 4,
        Ask     = 1 << 5
    }
}

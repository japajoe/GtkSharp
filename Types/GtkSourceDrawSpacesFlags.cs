using System;

namespace GtkSharp
{
    [Flags]
    public enum GtkSourceDrawSpacesFlags : int
    {
        Space      = 1 << 0,
        Tab        = 1 << 1,
        NewLine    = 1 << 2,
        NBSP       = 1 << 3,
        Leading    = 1 << 4,
        Text       = 1 << 5,
        Trailing   = 1 << 6,
        All        = 0x7f
    }
}

using System;

namespace GtkSharp
{
    [Flags]
    public enum GtkDialogFlags : int
    {
        Modal             = 1 << 0,
        DestroyWithParent = 1 << 1,
        UseHeaderBar      = 1 << 2
    }
}
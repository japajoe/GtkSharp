using System;

namespace GtkSharp
{
    [Flags]
    public enum GtkTreeModelFlags : int
    {
        ItersPersist = 1 << 0,
        ListOnly = 1 << 1
    }
}
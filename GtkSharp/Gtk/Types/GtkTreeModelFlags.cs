using System;

namespace GtkSharp.Gtk.Types
{
    [Flags]
    public enum GtkTreeModelFlags : int
    {
        ItersPersist = 1 << 0,
        ListOnly = 1 << 1
    }
}
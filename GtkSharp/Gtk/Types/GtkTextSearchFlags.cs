using System;

namespace GtkSharp.Gtk.Types
{
    [Flags]
    public enum GtkTextSearchFlags : int
    {
        VisibleOnly     = 1 << 0,
        TextOnly        = 1 << 1,
        CaseInsensitive = 1 << 2
    }
}
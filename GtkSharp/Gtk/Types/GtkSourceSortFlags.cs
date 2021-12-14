using System;

namespace GtkSharp.Gtk.Types
{
    [Flags]
    public enum GtkSourceSortFlags : int
    {
	    None              = 0,
	    CaseSensitive    = 1 << 0,
	    ReverseOrder     = 1 << 1,
	    RemoveDuplicates = 1 << 2,
    }
}
using System;

namespace GtkSharp
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
using System;

namespace GtkSharp.GLib.Types
{
    [Flags]
    public enum GConnectFlags : int
    {
        After	= 1 << 0,
        Swapped	= 1 << 1
    }
}
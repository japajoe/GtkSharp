using System;

namespace GtkSharp
{
    [Flags]
    public enum GdkEventMask : int
    {
        Exposure            = 1 << 1,
        PointerMotion       = 1 << 2,
        PointerMotionHint   = 1 << 3,
        ButtonMotion        = 1 << 4,
        Button1Motion       = 1 << 5,
        Button2Motion       = 1 << 6,
        Button3Motion       = 1 << 7,
        ButtonPress         = 1 << 8,
        ButtonRelease       = 1 << 9,
        KeyPress            = 1 << 10,
        KeyRelease          = 1 << 11,
        EnterNotify         = 1 << 12,
        LeaveNotify         = 1 << 13,
        FocusChange         = 1 << 14,
        Structure           = 1 << 15,
        PropertyChange      = 1 << 16,
        VisibilityNotify    = 1 << 17,
        ProximityIn         = 1 << 18,
        ProximityOut        = 1 << 19,
        SubStructure        = 1 << 20,
        Scroll              = 1 << 21,
        Touch               = 1 << 22,
        SmoothScroll        = 1 << 23,
        TouchpadGesture     = 1 << 24,
        AllEvents           = 0xFFFFFE
    }
}
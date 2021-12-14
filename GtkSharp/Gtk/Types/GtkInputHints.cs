using System;

namespace GtkSharp.Gtk.Types
{
    [Flags]
    public enum GtkInputHints : int
    {
        None                = 0,
        SpellCheck          = 1 << 0,
        NoSpellCheck       = 1 << 1,
        WordCompletion     = 1 << 2,
        Lowercase           = 1 << 3,
        UppercaseChars     = 1 << 4,
        UppercaseWords     = 1 << 5,
        UppercaseSentences = 1 << 6,
        InhibitOSK         = 1 << 7,
        VerticalWriting    = 1 << 8
    }
}

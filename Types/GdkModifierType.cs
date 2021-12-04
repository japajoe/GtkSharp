using System;

namespace GtkSharp
{
    [Flags]
    public enum GdkModifierType : int
    {
        ShiftMask    = 1 << 0,
        LockMask     = 1 << 1,
        ControlMask  = 1 << 2,
        Mod1Mask     = 1 << 3,
        Mod2Mask     = 1 << 4,
        Mod3Mask     = 1 << 5,
        Mod4Mask     = 1 << 6,
        Mod5Mask     = 1 << 7,
        Button1Mask  = 1 << 8,
        Button2Mask  = 1 << 9,
        Button3Mask  = 1 << 10,
        Button4Mask  = 1 << 11,
        Button5Mask  = 1 << 12,

        ModifierReserved13Mask  = 1 << 13,
        ModifierReserved14Mask  = 1 << 14,
        ModifierReserved15Mask  = 1 << 15,
        ModifierReserved16Mask  = 1 << 16,
        ModifierReserved17Mask  = 1 << 17,
        ModifierReserved18Mask  = 1 << 18,
        ModifierReserved19Mask  = 1 << 19,
        ModifierReserved20Mask  = 1 << 20,
        ModifierReserved21Mask  = 1 << 21,
        ModifierReserved22Mask  = 1 << 22,
        ModifierReserved23Mask  = 1 << 23,
        ModifierReserved24Mask  = 1 << 24,
        ModifierReserved25Mask  = 1 << 25,

        /* The next few modifiers are used by XKB, so we skip to the end.
        * Bits 15 - 25 are currently unused. Bit 29 is used internally.
        */

        SuperMask    = 1 << 26,
        HyperMask    = 1 << 27,
        MetaMask     = 1 << 28,

        ModifierReserved29Mask  = 1 << 29,

        ReleaseMask  = 1 << 30,

        /* Combination of GDK_SHIFT_MASK..GDK_BUTTON5_MASK + GDK_SUPER_MASK
            + GDK_HYPER_MASK + GDK_META_MASK + GDK_RELEASE_MASK */
        ModifierMask = 0x5c001fff
    } 
}
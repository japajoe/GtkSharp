using System;

namespace GtkSharp.Cairo.Types
{
    public delegate CairoStatus CairoReadFunc(IntPtr closure, IntPtr data, uint	length);
}
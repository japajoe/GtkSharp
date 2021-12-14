using System;

namespace GtkSharp.Glib.Native.Types
{
    internal delegate bool GSourceFuncCallback(IntPtr data);
    internal delegate void GDestroyNotifyCallback(IntPtr data);
}
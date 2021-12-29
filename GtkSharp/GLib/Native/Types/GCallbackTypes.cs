using System;

namespace GtkSharp.Glib.Native.Types
{
    public delegate bool GSourceFuncCallback(IntPtr data);
    public delegate void GDestroyNotifyCallback(IntPtr data);
}
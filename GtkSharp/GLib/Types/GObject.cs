using System;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.GLib.Types
{
    public class GObject
    {
        internal GObjectPointer handle;

        public IntPtr Handle
        {
            get
            {
                return handle.pointer;
            }
        }

        public void Unreference()
        {
            if(handle.IsNullPointer)
                return;

            GLib.Native.GLibLib.g_object_unref(handle.pointer);
            handle.pointer = IntPtr.Zero;
        }
    }
}
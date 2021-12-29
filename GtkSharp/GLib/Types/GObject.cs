using System;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.GLib.Types
{
    public class GObject
    {
        protected GObjectPointer handle;

        public GObjectPointer Handle
        {
            get
            {
                return handle;
            }
            set
            {
                handle = value;
            }
        }

        public GObject()
        {
            
        }

        public GObject(IntPtr handle)
        {
            this.handle.pointer = handle;
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

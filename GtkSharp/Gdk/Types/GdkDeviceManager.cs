using System;
using GtkSharp.Gdk.Native;
using GtkSharp.Glib.Native.Types;
using GtkSharp.GLib.Types;

namespace GtkSharp.Gdk.Types
{
    public class GdkDeviceManager : GObject
    {
        public GdkDeviceManager(IntPtr handle) : base(handle)
        {

        }

        public GdkDevice GetClientPointer()
        {
            if(handle.IsNullPointer)
                return null;

            GObjectPointer obj = NativeGdkDeviceManager.gdk_device_manager_get_client_pointer(handle);
            return new GdkDevice(obj.pointer);
        }
    }
}
using System.Runtime.InteropServices;
using GtkSharp.Gdk.Types;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gdk.Native
{
    public static class NativeGdkDeviceManager
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gdk_device_manager_get_type();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_device_manager_get_display(GObjectPointer device_manager);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GListPointer gdk_device_manager_list_devices(GObjectPointer device_manager, GdkDeviceType type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_device_manager_get_client_pointer(GObjectPointer device_manager);
    }
}
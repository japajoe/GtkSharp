using System.Runtime.InteropServices;
using GtkSharp.Cairo.Native.Types;
using GtkSharp.Gdk.Types;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gdk.Native
{
    public static class NativeGdkDevice
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gdk_device_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern string gdk_device_get_name(GObjectPointer device);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_device_get_has_cursor(GObjectPointer device);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkInputSource gdk_device_get_source(GObjectPointer device); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkInputMode gdk_device_get_mode(GObjectPointer device);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_device_set_mode(GObjectPointer device, GdkInputMode mode); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_device_get_n_keys(GObjectPointer device);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_device_get_key(GObjectPointer device, uint index_, out uint keyval, GdkModifierType[] modifiers);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_device_set_key(GObjectPointer device, uint index_, uint keyval, GdkModifierType modifiers); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkAxisUse gdk_device_get_axis_use(GObjectPointer device, uint index_);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_device_set_axis_use(GObjectPointer device, uint index_, GdkAxisUse use); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_device_get_state(GObjectPointer device, GObjectPointer window, double[] axes, out GdkModifierType mask);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_device_get_position(GObjectPointer device, GObjectPointer[] screen, out int x, out int y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_device_get_window_at_position(GObjectPointer device, ref int win_x, ref int win_y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_device_get_position_double(GObjectPointer device, GObjectPointer[] screen, out double x, out double y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_device_get_window_at_position_double(GObjectPointer device, ref double win_x, ref double win_y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_device_get_n_axes(GObjectPointer device);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GListPointer gdk_device_list_axes(GObjectPointer device);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_device_get_axis(GObjectPointer device, double[] axes, GdkAxisUse use, out double value);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_device_get_display(GObjectPointer device); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_device_get_associated_device(GObjectPointer device);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GListPointer gdk_device_list_slave_devices(GObjectPointer device); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkDeviceType gdk_device_get_device_type(GObjectPointer device); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkGrabStatus gdk_device_grab(GObjectPointer device, GObjectPointer window, GdkGrabOwnership grab_ownership, bool owner_events, GdkEventMask event_mask, GObjectPointer cursor, uint time_);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_device_ungrab(GObjectPointer device, uint time_); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_device_warp(GObjectPointer device, GObjectPointer screen, int x, int y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_device_get_last_event_window(GObjectPointer device); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern string gdk_device_get_vendor_id(GObjectPointer device);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern string gdk_device_get_product_id(GObjectPointer device);
    }
}
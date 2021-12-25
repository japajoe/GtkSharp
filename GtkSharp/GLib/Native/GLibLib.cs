using System;
using System.Runtime.InteropServices;
using GtkSharp.GLib.Types;

namespace GtkSharp.GLib.Native
{
    internal static class GLibLib
    {        
        const string NATIVELIB_GLIB = "glib-2.0";
        const string NATIVELIB_GOBJECT = "gobject-2.0";

        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong g_signal_connect_data(IntPtr widget, string eventName, IntPtr callback, IntPtr data, IntPtr destroyData, GConnectFlags connectFlags);
        
        internal static ulong g_signal_connect(IntPtr widget, string eventName, IntPtr callback, IntPtr userdata)
        {
            return g_signal_connect_data(widget, eventName, callback, userdata, IntPtr.Zero, (GConnectFlags)0);
        }
        
        internal static ulong g_signal_connect_after(IntPtr widget, string eventName, IntPtr callback, IntPtr userdata)
        {
            return g_signal_connect_data(widget, eventName, callback, userdata, IntPtr.Zero, GConnectFlags.After);
        }
        
        internal static ulong g_signal_connect_swapped(IntPtr widget, string eventName, IntPtr callback, IntPtr userdata)
        {
            return g_signal_connect_data(widget, eventName, callback, userdata, IntPtr.Zero, GConnectFlags.Swapped);
        }

        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void g_free(IntPtr memory);

        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void g_object_unref(IntPtr obj);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint g_timeout_add(uint interval, IntPtr sourceFunc, IntPtr data);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint g_timeout_add_full(int priority, uint interval, IntPtr sourceFunc, IntPtr data, IntPtr destroyNotifyFunc);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint g_timeout_add_seconds(uint interval, IntPtr sourceFunc, IntPtr data);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint g_timeout_add_seconds_full(int priority, uint interval, IntPtr sourceFunc, IntPtr data, IntPtr destroyNotifyFunc);        
    }
}
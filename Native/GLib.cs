using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Native
{
    internal static class GLib
    {        
        const string NATIVELIBNAME = "glib-2.0";

        [DllImport("gobject-2.0", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong g_signal_connect_data(IntPtr widget, string eventName, IntPtr callback, IntPtr data, IntPtr destroyData, GConnectFlags connectFlags);

        [DllImport("gobject-2.0", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void g_free(IntPtr memory);
        
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
    }
}
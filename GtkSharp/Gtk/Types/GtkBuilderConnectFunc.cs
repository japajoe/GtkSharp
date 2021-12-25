using System;
using GtkSharp.Glib.Native.Types;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Types
{
    public delegate void GtkBuilderConnectFunc(GtkBuilderPointer builder, GObjectPointer obj, string signal_name, string handler_name, GObjectPointer connect_object, GConnectFlags flags, IntPtr user_data);
}
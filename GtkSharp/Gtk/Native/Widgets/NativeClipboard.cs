using System;
using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeClipboard
    {   
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]     
        internal static extern GObjectPointer gtk_clipboard_get_default(GObjectPointer display);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_clipboard_clear(GObjectPointer clipboard);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_clipboard_set_text(GObjectPointer clipboard, string text, int len);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_clipboard_request_text(GObjectPointer clipboard, IntPtr clipboardTextReceivedFunc, IntPtr user_data);        
    }
}
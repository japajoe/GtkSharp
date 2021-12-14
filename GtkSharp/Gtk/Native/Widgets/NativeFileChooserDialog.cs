using System;
using System.Runtime.InteropServices;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeFileChooserDialog
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_file_chooser_dialog_get_type();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_file_chooser_dialog_new(string title, GtkWidgetPointer parentWindow, GtkFileChooserAction action, string first_button_text, GtkResponseType first_button_reponse, string second_button_text, GtkResponseType second_button_reponse, IntPtr terminator);
    }
}
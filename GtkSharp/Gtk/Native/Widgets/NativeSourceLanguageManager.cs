using System;
using System.Runtime.InteropServices;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeSourceLanguageManager
    {
        const string NATIVELIBNAME = "gtksourceview-3.0";

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_source_language_manager_get_type();
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_source_language_manager_new();
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_source_language_manager_get_default();
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_source_language_manager_get_search_path(GtkWidgetPointer lm);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_language_manager_set_search_path(GtkWidgetPointer lm, IntPtr dirs);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_source_language_manager_get_language_ids(GtkWidgetPointer lm);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceLanguagePointer gtk_source_language_manager_get_language(GtkWidgetPointer lm, string id);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceLanguagePointer gtk_source_language_manager_guess_language(GtkWidgetPointer lm, string filename, string content_type); 
    }
}

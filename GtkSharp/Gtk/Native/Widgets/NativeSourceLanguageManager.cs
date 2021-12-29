using System;
using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    public static class NativeSourceLanguageManager
    {
        const string NATIVELIBNAME = "gtksourceview-3.0";

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gtk_source_language_manager_get_type();
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_source_language_manager_new();
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_source_language_manager_get_default();
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_source_language_manager_get_search_path(GObjectPointer lm);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_language_manager_set_search_path(GObjectPointer lm, IntPtr dirs);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_source_language_manager_get_language_ids(GObjectPointer lm);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkSourceLanguagePointer gtk_source_language_manager_get_language(GObjectPointer lm, string id);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkSourceLanguagePointer gtk_source_language_manager_guess_language(GObjectPointer lm, string filename, string content_type); 
    }
}

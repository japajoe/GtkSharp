using System.Runtime.InteropServices;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeSourceCompletionWords
    {
        const string NATIVELIBNAME = "gtksourceview-3.0";

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_source_completion_words_get_type();
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceCompletionWordsPointer gtk_source_completion_words_new(string name, GdkPixbufPointer icon);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_completion_words_register(GtkSourceCompletionWordsPointer words, GtkTextBufferPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_completion_words_unregister(GtkSourceCompletionWordsPointer words, GtkTextBufferPointer buffer);        
    }
}
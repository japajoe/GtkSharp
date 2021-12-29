using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    public static class NativeSourceCompletion
    {
        const string NATIVELIBNAME = "gtksourceview-3.0";

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gtk_source_completion_get_type();
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gtk_source_completion_error_quark();
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_source_completion_add_provider(GtkSourceCompletionPointer completion, GtkSourceCompletionProviderPointer provider, GErrorPointer error);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_source_completion_remove_provider(GtkSourceCompletionPointer completion, GtkSourceCompletionProviderPointer provider, GErrorPointer error);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GListPointer gtk_source_completion_get_providers(GtkSourceCompletionPointer completion);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_source_completion_show(GtkSourceCompletionPointer completion, GListPointer providers, GtkSourceCompletionContextPointer context);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_completion_hide(GtkSourceCompletionPointer completion);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkSourceCompletionInfoPointer gtk_source_completion_get_info_window(GtkSourceCompletionPointer completion);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_source_completion_get_view(GtkSourceCompletionPointer completion);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkSourceCompletionContextPointer gtk_source_completion_create_context(GtkSourceCompletionPointer completion, ref GtkTextIter position);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_completion_move_window(GtkSourceCompletionPointer completion, ref GtkTextIter iter);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void _gtk_source_completion_add_proposals(GtkSourceCompletionPointer completion, GtkSourceCompletionContextPointer context, GtkSourceCompletionProviderPointer provider, GListPointer proposals, bool finished);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_completion_block_interactive(GtkSourceCompletionPointer completion); 
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_completion_unblock_interactive(GtkSourceCompletionPointer completion);
    }
}
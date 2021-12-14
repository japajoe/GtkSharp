using System.Runtime.InteropServices;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeEntryBuffer
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_entry_buffer_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_entry_buffer_new(string initial_chars, int n_initial_chars); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_entry_buffer_get_bytes(GtkWidgetPointer buffer); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_entry_buffer_get_length(GtkWidgetPointer buffer); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_entry_buffer_get_text(GtkWidgetPointer buffer); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_buffer_set_text(GtkWidgetPointer buffer, string chars, int n_chars); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_buffer_set_max_length(GtkWidgetPointer buffer, int max_length); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_buffer_get_max_length(GtkWidgetPointer buffer); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_entry_buffer_insert_text(GtkWidgetPointer buffer, uint position, string chars, int n_chars); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_entry_buffer_delete_text(GtkWidgetPointer buffer, uint position, int n_chars); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_buffer_emit_inserted_text(GtkWidgetPointer buffer, uint position, string chars, uint n_chars); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_buffer_emit_deleted_text(GtkWidgetPointer buffer, uint position, uint n_chars);
    }
}
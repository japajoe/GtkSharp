using System;
using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeBuilder
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_builder_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_builder_new(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_builder_add_from_file(GObjectPointer builder, string filename, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_builder_add_from_resource(GObjectPointer builder, string resource_path, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_builder_add_from_string(GObjectPointer builder, string buffer, ulong length, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_builder_add_objects_from_file(GObjectPointer builder, string filename, IntPtr[] object_ids, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_builder_add_objects_from_resource(GObjectPointer builder, string resource_path, IntPtr[] object_ids, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_builder_add_objects_from_string(GObjectPointer builder, string buffer, ulong length, IntPtr[] object_ids, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_builder_get_object(GObjectPointer builder, string name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GSListPointer gtk_builder_get_objects(GObjectPointer builder);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_builder_expose_object(GObjectPointer builder, string name, GObjectPointer obj);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_builder_connect_signals(GObjectPointer builder, IntPtr user_data);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_builder_connect_signals_full(GObjectPointer builder, GtkBuilderConnectFunc func, IntPtr user_data);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_builder_set_translation_domain(GObjectPointer builder, string domain);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_builder_get_translation_domain(GObjectPointer builder);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_builder_get_type_from_name(GObjectPointer builder, string type_name); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_builder_value_from_string(GObjectPointer builder, GParamSpecPointer pspec, string str, GValuePointer value, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_builder_value_from_string_type(GObjectPointer builder, ulong type, string str, GValuePointer value, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_builder_new_from_file(string filename);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_builder_new_from_resource(string resource_path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_builder_new_from_string(string str, long length); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_builder_add_callback_symbol(GObjectPointer builder, string callback_name, IntPtr callback_symbol);
        
        //[DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        //internal static extern void gtk_builder_add_callback_symbols(GObjectPointer builder, string first_callback_name, IntPtr first_callback_symbol, ...);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_builder_lookup_callback_symbol(GObjectPointer builder, string callback_name); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_builder_set_application(GObjectPointer builder, GtkApplicationPointer application); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkApplicationPointer gtk_builder_get_application(GObjectPointer builder);
    }
}
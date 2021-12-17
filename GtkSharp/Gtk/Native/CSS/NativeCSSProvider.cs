using System;
using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gtk.Native.CSS
{
    internal static class NativeCSSProvider
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_css_provider_get_type(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_css_provider_new(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_css_provider_to_string(GObjectPointer css_provider); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_css_provider_load_from_data(GObjectPointer css_provider, string data, long length, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_css_provider_load_from_file(GObjectPointer css_provider, GFilePointer file, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_css_provider_load_from_path(GObjectPointer css_provider, string path, GErrorPointer error); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_css_provider_load_from_resource(GObjectPointer css_provider, string resource_path); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_css_provider_get_default(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_css_provider_get_named(string name, string variant);
    }
}
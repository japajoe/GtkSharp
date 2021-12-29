using System;
using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    public static class NativeFileChooser
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_set_action(GObjectPointer chooser, GtkFileChooserAction action);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkFileChooserAction gtk_file_chooser_get_action(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_set_local_only(GObjectPointer chooser, bool local_only);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_get_local_only(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_set_select_multiple(GObjectPointer chooser, bool select_multiple);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_get_select_multiple(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_set_show_hidden(GObjectPointer chooser, bool show_hidden);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_get_show_hidden(GObjectPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_set_do_overwrite_confirmation(GObjectPointer chooser, bool do_overwrite_confirmation);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_get_do_overwrite_confirmation(GObjectPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_set_create_folders(GObjectPointer chooser, bool create_folders);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_get_create_folders(GObjectPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_set_current_name(GObjectPointer chooser, string name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_file_chooser_get_current_name(GObjectPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_file_chooser_get_filename(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_set_filename(GObjectPointer chooser, string filename);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_select_filename(GObjectPointer chooser, string filename);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_unselect_filename(GObjectPointer chooser, string filename);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_select_all(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_unselect_all(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer gtk_file_chooser_get_filenames(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_set_current_folder(GObjectPointer chooser, string filename);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_file_chooser_get_current_folder(GObjectPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_file_chooser_get_uri(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_set_uri(GObjectPointer chooser, string uri);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_select_uri(GObjectPointer chooser, string uri);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_unselect_uri(GObjectPointer chooser, string uri);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer gtk_file_chooser_get_uris(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_set_current_folder_uri(GObjectPointer chooser, string uri);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_file_chooser_get_current_folder_uri(GObjectPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GFilePointer gtk_file_chooser_get_file(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_set_file(GObjectPointer chooser, GFilePointer file, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_select_file(GObjectPointer chooser, GFilePointer file, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_unselect_file(GObjectPointer chooser, GFilePointer file);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer gtk_file_chooser_get_files(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_set_current_folder_file(GObjectPointer chooser, GFilePointer file, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GFilePointer gtk_file_chooser_get_current_folder_file(GObjectPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_set_preview_widget(GObjectPointer chooser, GObjectPointer preview_widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_file_chooser_get_preview_widget(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_set_preview_widget_active(GObjectPointer chooser, bool active);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_get_preview_widget_active(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_set_use_preview_label(GObjectPointer chooser, bool use_label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_get_use_preview_label(GObjectPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_file_chooser_get_preview_filename(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_file_chooser_get_preview_uri(GObjectPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GFilePointer gtk_file_chooser_get_preview_file(GObjectPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_set_extra_widget(GObjectPointer chooser, GObjectPointer extra_widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_file_chooser_get_extra_widget(GObjectPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_add_filter(GObjectPointer chooser, GtkFileFilterPointer filter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_remove_filter(GObjectPointer chooser, GtkFileFilterPointer filter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer gtk_file_chooser_list_filters(GObjectPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_file_chooser_set_filter(GObjectPointer chooser, GtkFileFilterPointer filter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkFileFilterPointer gtk_file_chooser_get_filter(GObjectPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_add_shortcut_folder(GObjectPointer chooser, string folder, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_remove_shortcut_folder(GObjectPointer chooser, string folder, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer gtk_file_chooser_list_shortcut_folders(GObjectPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_add_shortcut_folder_uri(GObjectPointer chooser, string uri, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_file_chooser_remove_shortcut_folder_uri(GObjectPointer chooser, string uri, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer gtk_file_chooser_list_shortcut_folder_uris(GObjectPointer chooser);
    }
}
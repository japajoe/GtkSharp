using System;
using System.Runtime.InteropServices;
using GtkSharp.Native.Types;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeFileChooser
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_set_action(GtkWidgetPointer chooser, GtkFileChooserAction action);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkFileChooserAction gtk_file_chooser_get_action(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_set_local_only(GtkWidgetPointer chooser, bool local_only);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_get_local_only(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_set_select_multiple(GtkWidgetPointer chooser, bool select_multiple);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_get_select_multiple(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_set_show_hidden(GtkWidgetPointer chooser, bool show_hidden);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_get_show_hidden(GtkWidgetPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_set_do_overwrite_confirmation(GtkWidgetPointer chooser, bool do_overwrite_confirmation);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_get_do_overwrite_confirmation(GtkWidgetPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_set_create_folders(GtkWidgetPointer chooser, bool create_folders);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_get_create_folders(GtkWidgetPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_set_current_name(GtkWidgetPointer chooser, string name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_file_chooser_get_current_name(GtkWidgetPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_file_chooser_get_filename(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_set_filename(GtkWidgetPointer chooser, string filename);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_select_filename(GtkWidgetPointer chooser, string filename);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_unselect_filename(GtkWidgetPointer chooser, string filename);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_select_all(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_unselect_all(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GSListPointer gtk_file_chooser_get_filenames(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_set_current_folder(GtkWidgetPointer chooser, string filename);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_file_chooser_get_current_folder(GtkWidgetPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_file_chooser_get_uri(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_set_uri(GtkWidgetPointer chooser, string uri);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_select_uri(GtkWidgetPointer chooser, string uri);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_unselect_uri(GtkWidgetPointer chooser, string uri);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GSListPointer gtk_file_chooser_get_uris(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_set_current_folder_uri(GtkWidgetPointer chooser, string uri);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_file_chooser_get_current_folder_uri(GtkWidgetPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GFilePointer gtk_file_chooser_get_file(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_set_file(GtkWidgetPointer chooser, GFilePointer file, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_select_file(GtkWidgetPointer chooser, GFilePointer file, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_unselect_file(GtkWidgetPointer chooser, GFilePointer file);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GSListPointer gtk_file_chooser_get_files(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_set_current_folder_file(GtkWidgetPointer chooser, GFilePointer file, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GFilePointer gtk_file_chooser_get_current_folder_file(GtkWidgetPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_set_preview_widget(GtkWidgetPointer chooser, GtkWidgetPointer preview_widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_file_chooser_get_preview_widget(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_set_preview_widget_active(GtkWidgetPointer chooser, bool active);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_get_preview_widget_active(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_set_use_preview_label(GtkWidgetPointer chooser, bool use_label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_get_use_preview_label(GtkWidgetPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_file_chooser_get_preview_filename(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_file_chooser_get_preview_uri(GtkWidgetPointer chooser);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GFilePointer gtk_file_chooser_get_preview_file(GtkWidgetPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_set_extra_widget(GtkWidgetPointer chooser, GtkWidgetPointer extra_widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_file_chooser_get_extra_widget(GtkWidgetPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_add_filter(GtkWidgetPointer chooser, GtkFileFilterPointer filter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_remove_filter(GtkWidgetPointer chooser, GtkFileFilterPointer filter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GSListPointer gtk_file_chooser_list_filters(GtkWidgetPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_file_chooser_set_filter(GtkWidgetPointer chooser, GtkFileFilterPointer filter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkFileFilterPointer gtk_file_chooser_get_filter(GtkWidgetPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_add_shortcut_folder(GtkWidgetPointer chooser, string folder, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_remove_shortcut_folder(GtkWidgetPointer chooser, string folder, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GSListPointer gtk_file_chooser_list_shortcut_folders(GtkWidgetPointer chooser); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_add_shortcut_folder_uri(GtkWidgetPointer chooser, string uri, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_file_chooser_remove_shortcut_folder_uri(GtkWidgetPointer chooser, string uri, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GSListPointer gtk_file_chooser_list_shortcut_folder_uris(GtkWidgetPointer chooser);
    }
}
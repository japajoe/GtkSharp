using System;
using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.GLib.Types;

namespace GtkSharp.GLib.Native
{
    public static class NativeGSList
    {
        const string NATIVELIB_GOBJECT = "gobject-2.0";

        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer g_slist_alloc();
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern void g_slist_free(GSListPointer list);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern void g_slist_free_1(GSListPointer list);
        
        //[DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        //public static extern void g_slist_free_full(GSListPointer list, GDestroyNotify free_func);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer g_slist_append(GSListPointer list, IntPtr data);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer g_slist_prepend(GSListPointer list, IntPtr data);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer g_slist_insert(GSListPointer list, IntPtr data, int position);
        
        //[DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        //public static extern GSListPointer g_slist_insert_sorted(GSListPointer list, IntPtr data, GCompareFunc func);
        
        //[DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        //public static extern GSListPointer g_slist_insert_sorted_with_data(GSListPointer list, IntPtr data, GCompareDataFunc func, IntPtr user_data);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer g_slist_insert_before(GSListPointer slist, GSListPointer sibling, IntPtr data);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer g_slist_concat(GSListPointer list1, GSListPointer list2);
        
        //[DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        //public static extern GSListPointer g_slist_remove(GSListPointer list, gconstpointer data);
        
        //[DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        //public static extern GSListPointer g_slist_remove_all(GSListPointer list, gconstpointer data);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer g_slist_remove_link(GSListPointer list, GSListPointer link_);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer g_slist_delete_link(GSListPointer list, GSListPointer link_);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer g_slist_reverse(GSListPointer list);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer g_slist_copy(GSListPointer list);
        
        //[DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        //public static extern GSListPointer g_slist_copy_deep(GSListPointer list, GCopyFunc func, IntPtr user_data);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer g_slist_nth(GSListPointer list, uint n);
        
        //[DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        //public static extern GSListPointer g_slist_find(GSListPointer list, gconstpointer data);
        
        //[DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        //public static extern GSListPointer g_slist_find_custom(GSListPointer list, gconstpointer data, GCompareFunc func);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern int g_slist_position(GSListPointer list, GSListPointer llink);
        
        //[DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        //public static extern int g_slist_index(GSListPointer list, gconstpointer data);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer g_slist_last(GSListPointer list);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint g_slist_length(GSListPointer list);
        
        //[DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        //public static extern void g_slist_foreach(GSListPointer list, GFunc func, IntPtr user_data);
        
        //[DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        //public static extern GSListPointer g_slist_sort(GSListPointer list, GCompareFunc compare_func);
        
        //[DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        //public static extern GSListPointer g_slist_sort_with_data(GSListPointer list, GCompareDataFunc compare_func, IntPtr user_data);
        
        [DllImport(NATIVELIB_GOBJECT, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr g_slist_nth_data(GSListPointer list, uint n);
    }
}
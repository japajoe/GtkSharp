using System;
using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;
using GtkSharp.Utilities;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeTreeModel
    {        
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTreePathPointer gtk_tree_path_new();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTreePathPointer gtk_tree_path_new_from_string(string path);
        
        //[DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        //internal static extern GtkTreePathPointer gtk_tree_path_new_from_indices(int first_index, ...);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe GtkTreePathPointer gtk_tree_path_new_from_indicesv(int* indices, long length);

        internal static unsafe GtkTreePathPointer gtk_tree_path_new_from_indicesv(int[] indices)
        {
            GtkTreePathPointer path;
            fixed(int* ptr = &indices[0])
            {
                long length = (long)indices.Length;
                path = gtk_tree_path_new_from_indicesv(ptr, length);
            }
            return path;
        }
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_tree_path_to_string(GtkTreePathPointer path);

        internal static void gtk_tree_path_to_string(GtkTreePathPointer path, out string str)
        {
            IntPtr ptr = gtk_tree_path_to_string(path);
            str = MarshalHelper.MarshalPtrToString(ptr);
            GLib.Native.GLibLib.g_free(ptr);
        }
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTreePathPointer gtk_tree_path_new_first();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_path_append_index(GtkTreePathPointer path, int index_);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_path_prepend_index(GtkTreePathPointer path, int index_);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_tree_path_get_depth(GtkTreePathPointer path);
        


        //Returns the current indices of path.
        //This is an array of integers, each representing a node in a tree. This value should not be freed.
        //The length of the array can be obtained with gtk_tree_path_get_depth().
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe int* gtk_tree_path_get_indices(GtkTreePathPointer path); 

        internal static unsafe int[] gtk_tree_path_get_indices(GtkTreePathPointer path, out int length)
        {
            int* ptr = gtk_tree_path_get_indices(path);
            length = gtk_tree_path_get_depth(path);
            if(length > 0)
            {
                int[] indices = new int[length];
                
                for(int i = 0; i < indices.Length; i++)
                {
                    indices[i] = ptr[i];
                }

                return indices;
            }

            return null;
        }
        
        //Returns the current indices of path.
        //This is an array of integers, each representing a node in a tree. It also returns the number of elements in the array. The array should not be freed.
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe int* gtk_tree_path_get_indices_with_depth(GtkTreePathPointer path, out int depth); 

        internal static unsafe int[] gtk_tree_path_get_indices_with_depth(GtkTreePathPointer path)
        {
            int depth;
            int* ptr = gtk_tree_path_get_indices_with_depth(path, out depth);
            if(depth > 0)
            {
                int[] indices = new int[depth];

                for(int i = 0; i < indices.Length; i++)
                {
                    indices[i] = ptr[i];
                }
                return indices;
            }

            return null;
        }
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_path_free(GtkTreePathPointer path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTreePathPointer gtk_tree_path_copy(GtkTreePathPointer path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_tree_path_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_tree_path_compare(GtkTreePathPointer a, GtkTreePathPointer b);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_path_next(GtkTreePathPointer path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tree_path_prev(GtkTreePathPointer path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tree_path_up(GtkTreePathPointer path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_path_down(GtkTreePathPointer path); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tree_path_is_ancestor(GtkTreePathPointer path, GtkTreePathPointer descendant);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tree_path_is_descendant(GtkTreePathPointer path, GtkTreePathPointer ancestor);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_tree_row_reference_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTreeRowReferencePointer gtk_tree_row_reference_new(GtkTreeModelPointer model, GtkTreePathPointer path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTreeRowReferencePointer gtk_tree_row_reference_new_proxy(GObjectPointer proxy, GtkTreeModelPointer model, GtkTreePathPointer path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTreePathPointer gtk_tree_row_reference_get_path(GtkTreeRowReferencePointer reference);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTreeModelPointer gtk_tree_row_reference_get_model(GtkTreeRowReferencePointer reference);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tree_row_reference_valid(GtkTreeRowReferencePointer reference);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTreeRowReferencePointer gtk_tree_row_reference_copy(GtkTreeRowReferencePointer reference);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_row_reference_free(GtkTreeRowReferencePointer reference); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_row_reference_inserted(GObjectPointer proxy, GtkTreePathPointer path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_row_reference_deleted(GObjectPointer proxy, GtkTreePathPointer path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void gtk_tree_row_reference_reordered(GObjectPointer proxy, GtkTreePathPointer path, ref GtkTreeIter iter, int* new_order);

        internal static unsafe void gtk_tree_row_reference_reordered(GObjectPointer proxy, GtkTreePathPointer path, ref GtkTreeIter iter, int[] new_order)
        {
            fixed(int* ptr = &new_order[0])
            {
                gtk_tree_row_reference_reordered(proxy, path, ref iter, ptr);
            }
        }
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTreeIterPointer gtk_tree_iter_copy(ref GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_iter_free(ref GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_tree_iter_get_type(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_tree_model_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTreeModelFlags gtk_tree_model_get_flags(GtkTreeModelPointer tree_model);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_tree_model_get_n_columns(GtkTreeModelPointer tree_model);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_tree_model_get_column_type(GtkTreeModelPointer tree_model, int index_); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tree_model_get_iter(GtkTreeModelPointer tree_model, ref GtkTreeIter iter, GtkTreePathPointer path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tree_model_get_iter_from_string(GtkTreeModelPointer tree_model, ref GtkTreeIter iter, string path_string);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_tree_model_get_string_from_iter(GtkTreeModelPointer tree_model, ref GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tree_model_get_iter_first(GtkTreeModelPointer tree_model, ref GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTreePathPointer gtk_tree_model_get_path(GtkTreeModelPointer tree_model, ref GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_model_get_value(GtkTreeModelPointer tree_model, ref GtkTreeIter iter, int column, out GValuePointer value);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tree_model_iter_previous(GtkTreeModelPointer tree_model, ref GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tree_model_iter_next(GtkTreeModelPointer tree_model, ref GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tree_model_iter_children(GtkTreeModelPointer tree_model, ref GtkTreeIter iter, ref GtkTreeIter parent);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tree_model_iter_has_child(GtkTreeModelPointer tree_model, ref GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_tree_model_iter_n_children(GtkTreeModelPointer tree_model, ref GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tree_model_iter_nth_child(GtkTreeModelPointer tree_model, ref GtkTreeIter iter, ref GtkTreeIter parent, int n);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tree_model_iter_parent(GtkTreeModelPointer tree_model, ref GtkTreeIter iter, ref GtkTreeIter child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_model_ref_node(GtkTreeModelPointer tree_model, ref GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_model_unref_node(GtkTreeModelPointer tree_model, ref GtkTreeIter iter);
        
        //[DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        //internal static extern void gtk_tree_model_get(GtkTreeModelPointer tree_model, ref GtkTreeIter iter, ...);
        
        //[DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        //internal static extern void gtk_tree_model_get_valist(GtkTreeModelPointer tree_model, ref GtkTreeIter iter, va_list var_args);         
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_model_foreach(GtkTreeModelPointer model, IntPtr treeModelForeachFunc, IntPtr user_data); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_model_row_changed(GtkTreeModelPointer tree_model, GtkTreePathPointer path, ref GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_model_row_inserted(GtkTreeModelPointer tree_model, GtkTreePathPointer path, ref GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_model_row_has_child_toggled(GtkTreeModelPointer tree_model, GtkTreePathPointer path, ref GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tree_model_row_deleted(GtkTreeModelPointer tree_model, GtkTreePathPointer path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void gtk_tree_model_rows_reordered(GtkTreeModelPointer tree_model, GtkTreePathPointer path, ref GtkTreeIter iter, int* new_order);

        internal static unsafe void gtk_tree_model_rows_reordered(GtkTreeModelPointer tree_model, GtkTreePathPointer path, ref GtkTreeIter iter, int[] new_order)
        {
            fixed(int* ptr = &new_order[0])
            {
                gtk_tree_model_rows_reordered(tree_model, path, ref iter, ptr);
            }
        }
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void gtk_tree_model_rows_reordered_with_length(GtkTreeModelPointer tree_model, GtkTreePathPointer path, ref GtkTreeIter iter, int* new_order, int length);

        internal static unsafe void gtk_tree_model_rows_reordered_with_length(GtkTreeModelPointer tree_model, GtkTreePathPointer path, ref GtkTreeIter iter, int[] new_order, int length)
        {
            fixed(int* ptr = &new_order[0])
            {
                gtk_tree_model_rows_reordered_with_length(tree_model, path, ref iter, ptr, length);
            }
        }
    }
}
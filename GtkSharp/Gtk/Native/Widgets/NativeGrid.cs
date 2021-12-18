using System.Runtime.InteropServices;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeGrid
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_grid_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_grid_new();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_grid_attach(GtkWidgetPointer grid, GtkWidgetPointer child, int left, int top, int width, int height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_grid_attach_next_to(GtkWidgetPointer grid, GtkWidgetPointer child, GtkWidgetPointer sibling, GtkPositionType side, int width, int height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_grid_get_child_at(GtkWidgetPointer grid, int left, int top);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_grid_insert_row(GtkWidgetPointer grid, int position);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_grid_insert_column(GtkWidgetPointer grid, int position);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_grid_remove_row(GtkWidgetPointer grid, int position);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_grid_remove_column(GtkWidgetPointer grid, int position);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_grid_insert_next_to(GtkWidgetPointer grid, GtkWidgetPointer sibling, GtkPositionType side);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_grid_set_row_homogeneous(GtkWidgetPointer grid, bool homogeneous);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_grid_get_row_homogeneous(GtkWidgetPointer grid);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_grid_set_row_spacing(GtkWidgetPointer grid, uint spacing);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_grid_get_row_spacing(GtkWidgetPointer grid);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_grid_set_column_homogeneous(GtkWidgetPointer grid, bool homogeneous);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_grid_get_column_homogeneous(GtkWidgetPointer grid);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_grid_set_column_spacing(GtkWidgetPointer grid, uint spacing);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_grid_get_column_spacing(GtkWidgetPointer grid);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_grid_set_row_baseline_position(GtkWidgetPointer grid, int row, GtkBaselinePosition pos);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkBaselinePosition gtk_grid_get_row_baseline_position(GtkWidgetPointer grid, int row);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_grid_set_baseline_row(GtkWidgetPointer grid, int row);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_grid_get_baseline_row(GtkWidgetPointer grid);
    }
}
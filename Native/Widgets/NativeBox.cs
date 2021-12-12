using System.Runtime.InteropServices;
using GtkSharp.Native.Types;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeBox
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_box_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_box_new(GtkOrientation orientation, int spacing); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_box_pack_start(GtkWidgetPointer box, GtkWidgetPointer child, bool expand, bool fill, uint padding);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_box_pack_end(GtkWidgetPointer box, GtkWidgetPointer child, bool expand, bool fill, uint padding); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_box_set_homogeneous(GtkWidgetPointer box, bool homogeneous);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_box_get_homogeneous(GtkWidgetPointer box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_box_set_spacing(GtkWidgetPointer box, int spacing);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_box_get_spacing(GtkWidgetPointer box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_box_set_baseline_position(GtkWidgetPointer box, GtkBaselinePosition position);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkBaselinePosition gtk_box_get_baseline_position(GtkWidgetPointer box); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_box_reorder_child(GtkWidgetPointer box, GtkWidgetPointer child, int position); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_box_query_child_packing(GtkWidgetPointer box, GtkWidgetPointer child, out bool expand, out bool fill, out uint padding, out GtkPackType pack_type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_box_set_child_packing(GtkWidgetPointer box, GtkWidgetPointer child, bool expand, bool fill, uint padding, GtkPackType pack_type); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_box_set_center_widget(GtkWidgetPointer box, GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_box_get_center_widget(GtkWidgetPointer box);
    }
}
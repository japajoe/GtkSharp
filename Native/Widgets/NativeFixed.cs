using System.Runtime.InteropServices;
using GtkSharp.Native.Types;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeFixed
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_fixed_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_fixed_new();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_fixed_put(GtkWidgetPointer fixxed, GtkWidgetPointer widget, int x, int y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_fixed_move(GtkWidgetPointer fixxed, GtkWidgetPointer widget, int x, int y);
    }
}
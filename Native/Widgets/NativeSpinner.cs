using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeSpinner
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSpinnerGetType(out ulong type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSpinnerCreate(out GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSpinnerStart(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSpinnerStop(out GtkWidgetPointer widget);
    }
}
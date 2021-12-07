using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeLevelBar
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarGetType(out ulong type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarCreate(out GtkWidgetPointer widget, double minValue, double maxValue);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarAddOffsetValue(out GtkWidgetPointer widget, string name, double value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarGetValue(out GtkWidgetPointer widget, out double value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarSetValue(out GtkWidgetPointer widget, double value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarGetMinValue(out GtkWidgetPointer widget, out double value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarSetMinValue(out GtkWidgetPointer widget, double value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarGetMaxValue(out GtkWidgetPointer widget, out double value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarSetMaxValue(out GtkWidgetPointer widget, double value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarGetMode(out GtkWidgetPointer widget, out GtkLevelBarMode mode);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarSetMode(out GtkWidgetPointer widget, GtkLevelBarMode mode);
    }
}
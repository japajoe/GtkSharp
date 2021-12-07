using System.Text;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeProgressBar
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetType(out ulong type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarCreate(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarPulse(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarSetText(out GtkWidgetPointer widget, string text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarSetfraction(out GtkWidgetPointer widget, double value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarSetPulseStep(out GtkWidgetPointer widget, double value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarSetInverted(out GtkWidgetPointer widget, bool inverted);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetText(out GtkWidgetPointer widget, StringBuilder text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetTextLength(out GtkWidgetPointer widget, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetFraction(out GtkWidgetPointer widget, out double value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetPulsestep(out GtkWidgetPointer widget, out double value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetInverted(out GtkWidgetPointer widget, out bool value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarSetEllipsize(out GtkWidgetPointer widget, PangoEllipsizeMode mode);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetEllipsize(out GtkWidgetPointer widget, out PangoEllipsizeMode mode);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarSetShowText(out GtkWidgetPointer widget, bool show);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetShowText(out GtkWidgetPointer widget, out bool show);
    }
}
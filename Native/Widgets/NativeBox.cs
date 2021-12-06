using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeBox
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxGetType(out ulong type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxCreate(out GtkWidgetPointer box, GtkOrientation orientation, int spacing);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxPackStart(out GtkWidgetPointer box, out GtkWidgetPointer child, bool expand, bool fill, uint padding);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxPackEnd(out GtkWidgetPointer box, out GtkWidgetPointer child, bool expand, bool fill, uint padding);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxSetHomogeneous(out GtkWidgetPointer box, bool homogeneous);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxGetHomogeneous(out GtkWidgetPointer box, out bool homogeneous);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxSetSpacing(out GtkWidgetPointer box, int spacing);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxGetSpacing(out GtkWidgetPointer box, out int spacing);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxSetBaselinePosition(out GtkWidgetPointer box, GtkBaselinePosition position);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxGetBaselinePosition(out GtkWidgetPointer box, out GtkBaselinePosition baselinePosition);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxReorderChild(out GtkWidgetPointer box, out GtkWidgetPointer child, int position);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxQueryChildPacking(out GtkWidgetPointer box, out GtkWidgetPointer child, out bool expand, out bool fill, out uint padding, out GtkPackType packType);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxSetChildPacking(out GtkWidgetPointer box, out GtkWidgetPointer child, bool expand, bool fill, uint padding, GtkPackType packType);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxSetCenterWidget(out GtkWidgetPointer box, out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxGetCenterWidget(out GtkWidgetPointer box, out GtkWidgetPointer widget);

    }
}
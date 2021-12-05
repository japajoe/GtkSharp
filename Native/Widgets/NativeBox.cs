using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeBox
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxGetType(out ulong type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxCreate(out IntPtr box, GtkOrientation orientation, int spacing);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxPackStart(out IntPtr box, out IntPtr child, bool expand, bool fill, uint padding);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxPackEnd(out IntPtr box, out IntPtr child, bool expand, bool fill, uint padding);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxSetHomogeneous(out IntPtr box, bool homogeneous);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxGetHomogeneous(out IntPtr box, out bool homogeneous);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxSetSpacing(out IntPtr box, int spacing);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxGetSpacing(out IntPtr box, out int spacing);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxSetBaselinePosition(out IntPtr box, GtkBaselinePosition position);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxGetBaselinePosition(out IntPtr box, out GtkBaselinePosition baselinePosition);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxReorderChild(out IntPtr box, out IntPtr child, int position);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxQueryChildPacking(out IntPtr box, out IntPtr child, out bool expand, out bool fill, out uint padding, out GtkPackType packType);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxSetChildPacking(out IntPtr box, out IntPtr child, bool expand, bool fill, uint padding, GtkPackType packType);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxSetCenterWidget(out IntPtr box, out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxGetCenterWidget(out IntPtr box, out IntPtr widget);

    }
}
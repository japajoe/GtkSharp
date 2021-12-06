using System.Text;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeButton
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonGetType(out ulong type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonCreate(out GtkWidgetPointer button);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonCreateWithLabel(out GtkWidgetPointer button, string label);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonCreateFromIconName(out GtkWidgetPointer button, string iconName, GtkIconSize size);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonCreateFromStock(out GtkWidgetPointer button, string stockId);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonCreateWithMnemonic(out GtkWidgetPointer button, string label);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonClicked(out GtkWidgetPointer button);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonSetRelief(out GtkWidgetPointer button, GtkReliefStyle reliefStyle);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonGetRelief(out GtkWidgetPointer button, out GtkReliefStyle reliefStyle);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonSetLabel(out GtkWidgetPointer button, string label);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonGetLabel(out GtkWidgetPointer button, StringBuilder label);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonGetLabelLength(out GtkWidgetPointer button, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonSetUseUnderline(out GtkWidgetPointer button, bool useUnderline);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonGetUseUnderline(out GtkWidgetPointer button, out bool useUnderline);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonSetUseStock(out GtkWidgetPointer button, bool useStock);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonGetUseStock(out GtkWidgetPointer button, out bool useStock);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonSetFocusOnClick(out GtkWidgetPointer button, bool focusOnClick);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonGetFocusOnClick(out GtkWidgetPointer button, out bool focusOnClick);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonSetAlignment(out GtkWidgetPointer button, float xalign, float yalign);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonGetAlignment(out GtkWidgetPointer button, out float xalign, out float yalign);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonSetImage(out GtkWidgetPointer button, out GtkWidgetPointer image);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonGetImage(out GtkWidgetPointer button, out GtkWidgetPointer image);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonSetImagePosition(out GtkWidgetPointer button, GtkPositionType positionType);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonGetImagePosition(out GtkWidgetPointer button, out GtkPositionType positionType);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonSetAlwaysShowImage(out GtkWidgetPointer button, bool alwaysShow);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonGetAlwaysShowImage(out GtkWidgetPointer button, out bool alwaysShow);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonGetEventWindow(out GtkWidgetPointer button, out GdkWindowPointer window);        
    }
}
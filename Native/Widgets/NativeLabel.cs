using System.Text;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeLabel
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]        
        internal static extern void GtkSharpLabelGetType(out ulong type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelCreate(out GtkWidgetPointer label, string text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelCreateWithMnemonic(out GtkWidgetPointer label, string text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetText(out GtkWidgetPointer label, string text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetText(out GtkWidgetPointer label, StringBuilder text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetTextLength(out GtkWidgetPointer label, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetAttributes(out GtkWidgetPointer label, out PangoAttrListPointer attrs);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetAttributes(out GtkWidgetPointer label, out PangoAttrListPointer attrs);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetLabel(out GtkWidgetPointer label, string text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetLabel(out GtkWidgetPointer label, StringBuilder text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetLabelLength(out GtkWidgetPointer label, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetMarkup(out GtkWidgetPointer label, string markup);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetUseMarkup(out GtkWidgetPointer label, bool useMarkup);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetUseMarkup(out GtkWidgetPointer label, out bool useMarkup);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetUseUnderline(out GtkWidgetPointer label, bool useUnderline);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetUseUnderline(out GtkWidgetPointer label, out bool useUnderline);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetMarkupWithMnemonic(out GtkWidgetPointer label, string markup);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetMnemonicKeyval(out GtkWidgetPointer label, out uint keyVal);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetMnemonicWidget(out GtkWidgetPointer label, out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetMnemonicWidget(out GtkWidgetPointer label, out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetTextWithMnemonic(out GtkWidgetPointer label, string text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetJustify(out GtkWidgetPointer label, GtkJustification justification);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetJustify(out GtkWidgetPointer label, out GtkJustification justification);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetEllipsize(out GtkWidgetPointer label, PangoEllipsizeMode mode);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetEllipsize(out GtkWidgetPointer label, out PangoEllipsizeMode mode);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetWidthChars(out GtkWidgetPointer label, int numChars);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetWidthChars(out GtkWidgetPointer label, out int numChars);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetMaxWidthChars(out GtkWidgetPointer label, int numChars);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetMaxWidthChars(out GtkWidgetPointer label, out int numChars);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetLines(out GtkWidgetPointer label, int lines);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetLines(out GtkWidgetPointer label, out int lines);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetPattern(out GtkWidgetPointer label, string pattern);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetLineWrap(out GtkWidgetPointer label, bool wrap);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetLineWrap(out GtkWidgetPointer label, out bool wrap);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetLineWrapMode(out GtkWidgetPointer label, PangoWrapMode mode);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetLineWrapMode(out GtkWidgetPointer label, out PangoWrapMode mode);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetSelectable(out GtkWidgetPointer label, bool selectable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetSelectable(out GtkWidgetPointer label, out bool selectable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetAngle(out GtkWidgetPointer label, double angle);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetAngle(out GtkWidgetPointer label, out double angle);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSelectRegion(out GtkWidgetPointer label, int startOffset, int endOffset);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetSelectionBounds(out GtkWidgetPointer label, out int start, out int end, out bool success);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetLayout(out GtkWidgetPointer label, out PangoLayoutPointer layout);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetLayoutOffsets(out GtkWidgetPointer label, out int x, out int y);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetSingleLineMode(out GtkWidgetPointer label, bool singleLine);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetSingleLineMode(out GtkWidgetPointer label, out bool singleLine);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetCurrentUri(out GtkWidgetPointer label, StringBuilder text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetCurrentUriLength(out GtkWidgetPointer label, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetTrackVisitedLinks(out GtkWidgetPointer label, bool trackLinks);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetTrackVisitedLinks(out GtkWidgetPointer label, out bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetXalign(out GtkWidgetPointer label, float xalign);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetXalign(out GtkWidgetPointer label, out float xalign);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetYalign(out GtkWidgetPointer label, float yalign);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelGetYalign(out GtkWidgetPointer label, out float yalign);
    }
}
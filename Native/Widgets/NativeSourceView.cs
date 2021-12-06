using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeSourceView
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetType(out ulong type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewCreate(out GtkWidgetPointer sourceView);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewCreateWithBuffer(out GtkWidgetPointer sourceView, out GtkSourceBufferPointer sourceBuffer);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetShowLineNumbers(out GtkWidgetPointer sourceView, bool show);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetShowLineNumbers(out GtkWidgetPointer sourceView, out bool show);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetTabWidth(out GtkWidgetPointer sourceView, int width);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetTabWidth(out GtkWidgetPointer sourceView, out int width);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetIndentWidth(out GtkWidgetPointer sourceView, int width);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetIndentWidth(out GtkWidgetPointer sourceView, out int width);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetAutoIndent(out GtkWidgetPointer sourceView, bool enable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetAutoIndent(out GtkWidgetPointer sourceView, out bool enable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetInsertSpacesInsteadOfTabs(out GtkWidgetPointer sourceView, bool enable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetInsertSpacesInsteadOfTabs(out GtkWidgetPointer sourceView, out bool enable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetIndentOnTab(out GtkWidgetPointer sourceView, bool enable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetIndentOnTab(out GtkWidgetPointer sourceView, out bool enable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewIndentLines(out GtkWidgetPointer sourceView, out GtkTextIterPointer start, out GtkTextIterPointer end);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewUnindentLines(out GtkWidgetPointer sourceView, out GtkTextIterPointer start, out GtkTextIterPointer end);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetHighlightCurrentLine(out GtkWidgetPointer sourceView, bool highlight);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetHighlightCurrentLine(out GtkWidgetPointer sourceView, out bool highlight);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetShowRightMargin(out GtkWidgetPointer sourceView, bool show);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetShowRightMargin(out GtkWidgetPointer sourceView, out bool show);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetRightMarginPosition(out GtkWidgetPointer sourceView, uint pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetRightMarginPosition(out GtkWidgetPointer sourceView, out uint pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetShowLineMarks(out GtkWidgetPointer sourceView, bool show);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetShowLineMarks(out GtkWidgetPointer sourceView, out bool show);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetMarkAttributes(out GtkWidgetPointer sourceView, string category, out GtkSourceMarkAttributesPointer attributes, int priority);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetMarkAttributes(out GtkWidgetPointer sourceView, string category, out GtkSourceMarkAttributesPointer attributes, out int priority);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetSmartBackspace(out GtkWidgetPointer sourceView, bool smartBackspace);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetSmartBackspace(out GtkWidgetPointer sourceView, out bool smartBackspace);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetSmartHomeEnd(out GtkWidgetPointer sourceView, GtkSourceSmartHomeEndType smartHomeEnd);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetSmartHomeEnd(out GtkWidgetPointer sourceView, out GtkSourceSmartHomeEndType smartHomeEnd);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetDrawSpaces(out GtkWidgetPointer sourceView, GtkSourceDrawSpacesFlags flags);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetDrawSpaces(out GtkWidgetPointer sourceView, out GtkSourceDrawSpacesFlags flags);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetVisualColumn(out GtkWidgetPointer sourceView, out GtkTextIterPointer iter, out uint column);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetCompletion(out GtkWidgetPointer sourceView, out GtkSourceCompletionPointer sourceCompletion);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetGutter(out GtkWidgetPointer sourceView, GtkTextWindowType windowType, out GtkSourceGutterPointer sourceGutter);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetBackgroundPattern(out GtkWidgetPointer sourceView, GtkSourceBackgroundPatternType backgroundPattern);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetBackgroundPattern(out GtkWidgetPointer sourceView, out GtkSourceBackgroundPatternType backgroundPattern);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceLanguageManagerGetDefault(out GtkSourceLanguageManagerPointer languageManager);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceLanguageManagerGetLanguage(out GtkSourceLanguageManagerPointer languageManager, out GtkSourceLanguagePointer sourceLanguage, string language);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceBufferCreateWithLanguage(out GtkSourceBufferPointer sourceBuffer, out GtkSourceLanguagePointer language);
    }
}

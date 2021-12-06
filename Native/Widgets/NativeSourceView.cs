using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeSourceView
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetType(out ulong type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewCreate(out IntPtr sourceView);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewCreateWithBuffer(out IntPtr sourceView, out IntPtr sourceBuffer);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetShowLineNumbers(out IntPtr sourceView, bool show);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetShowLineNumbers(out IntPtr sourceView, out bool show);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetTabWidth(out IntPtr sourceView, int width);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetTabWidth(out IntPtr sourceView, out int width);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetIndentWidth(out IntPtr sourceView, int width);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetIndentWidth(out IntPtr sourceView, out int width);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetAutoIndent(out IntPtr sourceView, bool enable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetAutoIndent(out IntPtr sourceView, out bool enable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetInsertSpacesInsteadOfTabs(out IntPtr sourceView, bool enable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetInsertSpacesInsteadOfTabs(out IntPtr sourceView, out bool enable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetIndentOnTab(out IntPtr sourceView, bool enable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetIndentOnTab(out IntPtr sourceView, out bool enable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewIndentLines(out IntPtr sourceView, out IntPtr start, out IntPtr end);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewUnindentLines(out IntPtr sourceView, out IntPtr start, out IntPtr end);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetHighlightCurrentLine(out IntPtr sourceView, bool highlight);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetHighlightCurrentLine(out IntPtr sourceView, out bool highlight);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetShowRightMargin(out IntPtr sourceView, bool show);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetShowRightMargin(out IntPtr sourceView, out bool show);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetRightMarginPosition(out IntPtr sourceView, uint pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetRightMarginPosition(out IntPtr sourceView, out uint pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetShowLineMarks(out IntPtr sourceView, bool show);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetShowLineMarks(out IntPtr sourceView, out bool show);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetMarkAttributes(out IntPtr sourceView, string category, out IntPtr attributes, int priority);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetMarkAttributes(out IntPtr sourceView, string category, out IntPtr attributes, out int priority);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetSmartBackspace(out IntPtr sourceView, bool smartBackspace);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetSmartBackspace(out IntPtr sourceView, out bool smartBackspace);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetSmartHomeEnd(out IntPtr sourceView, GtkSourceSmartHomeEndType smartHomeEnd);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetSmartHomeEnd(out IntPtr sourceView, out GtkSourceSmartHomeEndType smartHomeEnd);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetDrawSpaces(out IntPtr sourceView, GtkSourceDrawSpacesFlags flags);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetDrawSpaces(out IntPtr sourceView, out GtkSourceDrawSpacesFlags flags);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetVisualColumn(out IntPtr sourceView, out IntPtr iter, out uint column);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetCompletion(out IntPtr sourceView, out IntPtr sourceCompletion);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetGutter(out IntPtr sourceView, GtkTextWindowType windowType, out IntPtr sourceGutter);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetBackgroundPattern(out IntPtr sourceView, GtkSourceBackgroundPatternType backgroundPattern);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetBackgroundPattern(out IntPtr sourceView, out GtkSourceBackgroundPatternType backgroundPattern);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceLanguageManagerGetDefault(out IntPtr languageManager);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceLanguageManagerGetLanguage(out IntPtr languageManager, out IntPtr sourceLanguage, string language);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceBufferCreateWithLanguage(out IntPtr sourceBuffer, out IntPtr language);
    }
}

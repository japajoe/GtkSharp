using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeTextView
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetType(out ulong type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewCreate(out GtkWidgetPointer textView);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewCreateWithBuffer(out GtkWidgetPointer textView, out GtkTextBufferPointer buffer);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetBuffer(out GtkWidgetPointer textView, out GtkTextBufferPointer buffer);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetBuffer(out GtkWidgetPointer textView, out GtkTextBufferPointer buffer);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewScrollToIter(out GtkWidgetPointer textView, out GtkTextIterPointer iter, double withinMargin, bool useAlign, double xalign, double yalign);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewScrollToMark(out GtkWidgetPointer textView, out GtkTextMarkPointer mark, double withinMargin, bool useAlign, double xalign, double yalign);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewScrollMarkOnscreen(out GtkWidgetPointer textView, out GtkTextMarkPointer mark);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewMoveMarkOnscreen(out GtkWidgetPointer textView, out GtkTextMarkPointer mark);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewPlaceCursorOnscreen(out GtkWidgetPointer textView);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetVisibleRect(out GtkWidgetPointer textView, out GdkRectangle visibleRect);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetCursorVisible(out GtkWidgetPointer textView, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetCursorVisible(out GtkWidgetPointer textView, out bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetCursorLocations(out GtkWidgetPointer textView, out GtkTextIterPointer iter, out GdkRectangle strongRectangle, out GdkRectangle weakRectangle);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetIterLocation(out GtkWidgetPointer textView, out GtkTextIterPointer iter, out GdkRectangle location);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetIterAtLocation(out GtkWidgetPointer textView, out GtkTextIterPointer iter, int x, int y);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetIterAtPosition(out GtkWidgetPointer textView, out GtkTextIterPointer iter, out int trailing, int x, int y);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetLineYrange(out GtkWidgetPointer textView, out GtkTextIterPointer iter, out int y, out int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetLineAtY(out GtkWidgetPointer textView, out GtkTextIterPointer targetIter, int y, out int lineTop);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewBufferToWindowCoords(out GtkWidgetPointer textView, GtkTextWindowType textWindowType, int bufferX, int bufferY, out int windowX, out int windowY);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewWindowToBufferCoords(out GtkWidgetPointer textView, GtkTextWindowType textWindowType, int windowX, int windowY, out int bufferX, out int bufferY);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetHadjustment(out GtkWidgetPointer textView, GtkAdjustmentPointer adjustment);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetVadjustment(out GtkWidgetPointer textView, GtkAdjustmentPointer adjustment);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetWindow(out GtkWidgetPointer textView, GtkTextWindowType textWindowType, out GdkWindowPointer gdkWindow);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetWindowType(out GtkWidgetPointer textView, out GdkWindowPointer window, out GtkTextWindowType textWindowType);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetBorderWindowSize(out GtkWidgetPointer textView, GtkTextWindowType type, int size);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetBorderWindowSize(out GtkWidgetPointer textView, GtkTextWindowType type, out int size);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewForwardDisplayLine(out GtkWidgetPointer textView, out GtkTextIterPointer iter);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewBackwardDisplayLine(out GtkWidgetPointer textView, out GtkTextIterPointer iter);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewForwardDisplayLineEnd(out GtkWidgetPointer textView, out GtkTextIterPointer iter);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewBackwardDisplayLineStart(out GtkWidgetPointer textView, out GtkTextIterPointer iter);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewStartsDisplayLine(out GtkWidgetPointer textView, out GtkTextIterPointer iter);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewMoveVisually(out GtkWidgetPointer textView, out GtkTextIterPointer iter, int count);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewImContextFilterKeypress(out GtkWidgetPointer textView, out GdkEventKeyPointer evnt);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewResetImContext(out GtkWidgetPointer textView);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewAddChildAtAnchor(out GtkWidgetPointer textView, out GtkWidgetPointer child, out GtkTextChildAnchorPointer anchor);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewAddChildInWindow(out GtkWidgetPointer textView, out GtkWidgetPointer child, GtkTextWindowType whichWindow, int xpos, int ypos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewMoveChild(out GtkWidgetPointer textView, out GtkWidgetPointer child, int xpos, int ypos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetWrapMode(out GtkWidgetPointer textView, GtkWrapMode wrapMode);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetWrapMode(out GtkWidgetPointer textView, out GtkWrapMode wrapMode);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetEditable(out GtkWidgetPointer textView, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetEditable(out GtkWidgetPointer textView, out bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetOverwrite(out GtkWidgetPointer textView, bool overwrite);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetOverwrite(out GtkWidgetPointer textView, out bool overwrite);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetAcceptsTab(out GtkWidgetPointer textView, bool acceptsTab);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetAcceptsTab(out GtkWidgetPointer textView, out bool acceptsTab);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetPixelsAboveLines(out GtkWidgetPointer textView, int pixelsAboveLines);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetPixelsAboveLines(out GtkWidgetPointer textView, out int pixelsAboveLines);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetPixelsBelowLines(out GtkWidgetPointer textView, int pixelsBelowLines);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetPixelsBelowLines(out GtkWidgetPointer textView, out int pixelsBelowLines);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetPixelsInsideWrap(out GtkWidgetPointer textView, int pixelsInsideWrap);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetPixelsInsideWrap(out GtkWidgetPointer textView, out int pixelsInsideWrap);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetJustification(out GtkWidgetPointer textView, GtkJustification justification);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetJustification(out GtkWidgetPointer textView, out GtkJustification justification);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetLeftMargin(out GtkWidgetPointer textView, int leftMargin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetLeftMargin(out GtkWidgetPointer textView, out int leftMargin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetRightMargin(out GtkWidgetPointer textView, int rightMargin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetRightMargin(out GtkWidgetPointer textView, out int rightMargin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetTopMargin(out GtkWidgetPointer textView, int topMargin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetTopMargin(out GtkWidgetPointer textView, out int topMargin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetBottomMargin(out GtkWidgetPointer textView, int bottomMargin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetBottomMargin(out GtkWidgetPointer textView, out int bottomMargin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetIndent(out GtkWidgetPointer textView, int indent);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetIndent(out GtkWidgetPointer textView, out int indent);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetTabs(out GtkWidgetPointer textView, out PangoTabArrayPointer pangoTabArray);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetTabs(out GtkWidgetPointer textView, out PangoTabArrayPointer pangoTabArray);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetDefaultAttributes(out GtkWidgetPointer textView, out GtkTextAttributesPointer textAttributes);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetInputPurpose(out GtkWidgetPointer textView, GtkInputPurpose purpose);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetInputPurpose(out GtkWidgetPointer textView, out GtkInputPurpose purpose);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetInputHints(out GtkWidgetPointer textView, GtkInputHints hints);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetInputHints(out GtkWidgetPointer textView, out GtkInputHints hints);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetMonospace(out GtkWidgetPointer textView, bool monospace);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetMonospace(out GtkWidgetPointer textView, out bool monospace);
    }
}
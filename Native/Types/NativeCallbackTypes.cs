using System;

namespace GtkSharp.Native
{
    internal delegate bool GtkWidgetKeyPressCallback(IntPtr widget, GdkEventKeyPointer eventKey, IntPtr userData);
    internal delegate bool GtkWidgetKeyReleaseCallback(IntPtr widget, GdkEventKeyPointer eventKey, IntPtr userData);
    internal delegate bool GtkWidgetButtonPressCallback(IntPtr widget, GdkEventButtonPointer eventKey, IntPtr userData);
    internal delegate bool GtkWidgetButtonReleaseCallback(IntPtr widget, GdkEventButtonPointer eventKey, IntPtr userData);
    
    internal delegate void GtkCallback(IntPtr widget, IntPtr data);

    internal delegate void GtkButtonActivateCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkButtonClickedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkButtonEnterCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkButtonLeaveCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkButtonPressedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkButtonReleasedCallback(IntPtr widget, IntPtr data);

    internal delegate void GtkEntryActivateCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkEntryBackspaceCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkEntryCopyClipboardCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkEntryCutClipboardCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkEntryDeleteFromCursorCallback(IntPtr widget, GtkDeleteType type, int count, IntPtr data);
    internal delegate void GtkEntryIconPressCallback(IntPtr widget, GtkEntryIconPosition position, IntPtr gdkEvent, IntPtr data);
    internal delegate void GtkEntryIconReleaseCallback(IntPtr widget, GtkEntryIconPosition position, IntPtr gdkEvent, IntPtr data);
    internal delegate void GtkEntryInsertAtCursorCallback(IntPtr widget, IntPtr text, IntPtr data);
    internal delegate void GtkEntryInsertEmojiCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkEntryMoveCursorCallback(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data);
    internal delegate void GtkEntryPasteClipboardCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkEntryPopulatePopupCallback(IntPtr widget, IntPtr data);

    internal delegate void GtkLabelActivateCurrentLinkCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkLabelActivateLinkCallback(IntPtr widget, IntPtr uri, IntPtr data);
    internal delegate void GtkLabelCopyClipboardCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkLabelMoveCursorCallback(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data);
    internal delegate void GtkLabelPopulatePopupCallback(IntPtr widget, IntPtr menu, IntPtr data);

    internal delegate void GtkTextBufferChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkSourceBufferChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkEntryBufferDeletedCallback(IntPtr textbuffer, uint position, uint n_chars, IntPtr data);
    internal delegate void GtkEntryBufferInsertedCallback(IntPtr textbuffer, uint position, IntPtr chars, uint n_chars, IntPtr data);
    internal delegate bool GtkDrawingAreaDrawCallback(IntPtr widget, IntPtr cr, IntPtr data);
    internal delegate bool GtkWidgetDrawCallback(IntPtr widget, IntPtr cr, IntPtr data);
    internal delegate void GtkSpinButtonValueChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkToggleButtonValueChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkNoteBookSelectedIndexChangedCallback(IntPtr notebook, IntPtr page, uint page_num, IntPtr data);
    internal delegate void GDestroyNotify(IntPtr data);
    internal delegate bool GtkTickCallback(IntPtr widget, IntPtr frame_clock,  IntPtr user_data);
    
    internal delegate GdkGLContextPointer GtkGLAreaCreateContextCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkGLAreaResizeCallback(IntPtr widget, int width, int height, IntPtr data);
    internal delegate void GtkGLAreaRealizeCallback(IntPtr widget);
    internal delegate void GtkGLAreaUnRealizeCallback(IntPtr widget);
    internal delegate bool GtkGLAreaRenderCallback(IntPtr widget, IntPtr context);

    internal delegate void GtkLevelBarOffsetChangedCallback(IntPtr widget, IntPtr name, IntPtr data);

    internal delegate void GtkMenuMoveScrollCallback(IntPtr widget, IntPtr scrollType, IntPtr data);
    internal delegate void GtkMenuPoppedUpCallback(IntPtr widget, IntPtr flippedRect, IntPtr finalRect, bool flippedX, bool flippedY, IntPtr data);
    
    internal delegate void GtkWindowSizeAllocateCallback(IntPtr widget, IntPtr allocation);
}

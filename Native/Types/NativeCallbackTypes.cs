using System;

namespace GtkSharp.Native
{
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
    internal delegate void GtkGLAreaRealizeCallback(IntPtr area);
    internal delegate void GtkGLAreaUnRealizeCallback(IntPtr area);
    internal delegate bool GtkGLAreaRenderCallback(IntPtr area, IntPtr context);
    internal delegate void GtkWindowSizeAllocateCallback(IntPtr widget, IntPtr allocation);
}

using System;

namespace GtkSharp.Native
{
    internal delegate void GtkWidgetDestroyCallback(IntPtr widget, IntPtr userData);
    internal delegate bool GtkWidgetDestroyedCallback(IntPtr widget, GdkEventPointer evnt, IntPtr userData);
    internal delegate void GtkWidgetSizeAllocateCallback(IntPtr widget, GtkAllocationPointer allocation);
    internal delegate bool GtkWidgetKeyPressCallback(IntPtr widget, GdkEventKeyPointer eventKey, IntPtr userData);
    internal delegate bool GtkWidgetKeyReleaseCallback(IntPtr widget, GdkEventKeyPointer eventKey, IntPtr userData);
    internal delegate bool GtkWidgetButtonPressCallback(IntPtr widget, GdkEventButtonPointer eventButton, IntPtr userData);
    internal delegate bool GtkWidgetButtonReleaseCallback(IntPtr widget, GdkEventButtonPointer eventButton, IntPtr userData);
    internal delegate bool GtkWidgetMotionNotifyCallback(IntPtr widget, GdkEventMotionPointer eventMotion, IntPtr userData);

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

    internal delegate GtkFileChooserConfirmation GtkFileChooserConfirmOverwriteCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkFileChooserCurrentFolderChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkFileChooserFileActivatedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkFileChooserSelectionChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkFileChooserUpdatePreviewCallback(IntPtr widget, IntPtr data);

    internal delegate void GtkLabelActivateCurrentLinkCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkLabelActivateLinkCallback(IntPtr widget, IntPtr uri, IntPtr data);
    internal delegate void GtkLabelCopyClipboardCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkLabelMoveCursorCallback(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data);
    internal delegate void GtkLabelPopulatePopupCallback(IntPtr widget, IntPtr menu, IntPtr data);
    
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

    internal delegate void GtkMenuItemActivateCallback(IntPtr widget, IntPtr data);

    internal delegate void GtkSourceBufferApplyTagCallback(GtkSourceBufferPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);
    internal delegate void GtkSourceBufferBeginUserActionCallback(GtkSourceBufferPointer buffer, IntPtr data);
    internal delegate void GtkSourceBufferChangedCallback(GtkSourceBufferPointer buffer, IntPtr data);
    internal delegate void GtkSourceBufferDeleteRangeCallback(GtkSourceBufferPointer buffer, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);
    internal delegate void GtkSourceBufferEndUserActionCallback(GtkSourceBufferPointer buffer, IntPtr data);
    internal delegate void GtkSourceBufferInsertChildAnchorCallback(GtkSourceBufferPointer buffer, GtkTextIterPointer location, GtkTextChildAnchorPointer anchor, IntPtr data);
    internal delegate void GtkSourceBufferInsertPixbufCallback(GtkSourceBufferPointer buffer, GtkTextIterPointer location, GdkPixbufPointer pixbuf, IntPtr data);
    internal delegate void GtkSourceBufferInsertTextCallback(GtkSourceBufferPointer buffer, GtkTextIterPointer location, IntPtr text, int length, IntPtr data);
    internal delegate void GtkSourceBufferMarkDeletedCallback(GtkSourceBufferPointer buffer, GtkTextMarkPointer mark, IntPtr data);
    internal delegate void GtkSourceBufferMarkSetCallback(GtkSourceBufferPointer buffer, GtkTextIterPointer location, GtkTextMarkPointer mark, IntPtr data);
    internal delegate void GtkSourceBufferModifiedChangedCallback(GtkSourceBufferPointer buffer, IntPtr data);
    internal delegate void GtkSourceBufferPasteDoneCallback(GtkSourceBufferPointer buffer, GtkClipboardPointer clipboard, IntPtr data);
    internal delegate void GtkSourceBufferRemoveTagCallback(GtkSourceBufferPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);    

    internal delegate void GtkTextBufferApplyTagCallback(GtkTextBufferPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);
    internal delegate void GtkTextBufferBeginUserActionCallback(GtkTextBufferPointer buffer, IntPtr data);
    internal delegate void GtkTextBufferChangedCallback(GtkTextBufferPointer buffer, IntPtr data);
    internal delegate void GtkTextBufferDeleteRangeCallback(GtkTextBufferPointer buffer, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);
    internal delegate void GtkTextBufferEndUserActionCallback(GtkTextBufferPointer buffer, IntPtr data);
    internal delegate void GtkTextBufferInsertChildAnchorCallback(GtkTextBufferPointer buffer, GtkTextIterPointer location, GtkTextChildAnchorPointer anchor, IntPtr data);
    internal delegate void GtkTextBufferInsertPixbufCallback(GtkTextBufferPointer buffer, GtkTextIterPointer location, GdkPixbufPointer pixbuf, IntPtr data);
    internal delegate void GtkTextBufferInsertTextCallback(GtkTextBufferPointer buffer, GtkTextIterPointer location, IntPtr text, int length, IntPtr data);
    internal delegate void GtkTextBufferMarkDeletedCallback(GtkTextBufferPointer buffer, GtkTextMarkPointer mark, IntPtr data);
    internal delegate void GtkTextBufferMarkSetCallback(GtkTextBufferPointer buffer, GtkTextIterPointer location, GtkTextMarkPointer mark, IntPtr data);
    internal delegate void GtkTextBufferModifiedChangedCallback(GtkTextBufferPointer buffer, IntPtr data);
    internal delegate void GtkTextBufferPasteDoneCallback(GtkTextBufferPointer buffer, GtkClipboardPointer clipboard, IntPtr data);
    internal delegate void GtkTextBufferRemoveTagCallback(GtkTextBufferPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);

    internal delegate void GtkTextViewBackspaceCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkTextViewCopyClipboardCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkTextViewCutClipboardCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkTextViewDeleteFromCursorCallback(IntPtr widget, GtkDeleteType type, int count, IntPtr data);
    internal delegate bool GtkTextViewExtendSelectionCallback(IntPtr widget, GtkTextExtendSelection granularity, GtkTextIterPointer location, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);
    internal delegate void GtkTextViewInsertAtCursorCallback(IntPtr widget, IntPtr str, IntPtr data);
    internal delegate void GtkTextViewInsertEmojiCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkTextViewMoveCursorCallback(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data);
    internal delegate void GtkTextViewMoveViewportCallback(IntPtr widget, IntPtr scrollStep, int count, IntPtr data);
    internal delegate void GtkTextViewPasteClipboardCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkTextViewPopulatePopupCallback(IntPtr widget, IntPtr popup, IntPtr data);
    internal delegate void GtkTextViewPreeditChangedCallback(IntPtr widget, IntPtr str, IntPtr data);    
}

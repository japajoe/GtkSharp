using System;
using GtkSharp.Native.Types;

namespace GtkSharp.Native.Callbacks
{
    internal delegate bool GtkTickCallback(GtkWidgetPointer widget, GdkFrameClockPointer frame_clock, IntPtr user_data);
    internal delegate void GDestroyNotify(IntPtr data);

    internal delegate void GtkButtonActivateCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkButtonClickedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkButtonEnterCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkButtonLeaveCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkButtonPressedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkButtonReleasedCallback(IntPtr widget, IntPtr data);

    internal delegate GtkFileChooserConfirmation GtkFileChooserConfirmOverwriteCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkFileChooserCurrentFolderChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkFileChooserFileActivatedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkFileChooserSelectionChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkFileChooserUpdatePreviewCallback(IntPtr widget, IntPtr data);

    internal delegate GdkGLContextPointer GtkGLAreaCreateContextCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkGLAreaResizeCallback(IntPtr widget, int width, int height, IntPtr data);
    internal delegate void GtkGLAreaRealizeCallback(IntPtr widget);
    internal delegate void GtkGLAreaUnRealizeCallback(IntPtr widget);
    internal delegate bool GtkGLAreaRenderCallback(IntPtr widget, IntPtr context);

    internal delegate void GtkLabelActivateCurrentLinkCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkLabelActivateLinkCallback(IntPtr widget, IntPtr uri, IntPtr data);
    internal delegate void GtkLabelCopyClipboardCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkLabelMoveCursorCallback(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data);
    internal delegate void GtkLabelPopulatePopupCallback(IntPtr widget, IntPtr menu, IntPtr data);

    internal delegate void GtkMenuItemActivateCallback(IntPtr widget, IntPtr data);

    internal delegate void GtkMenuMoveScrollCallback(IntPtr widget, IntPtr scrollType, IntPtr data);
    internal delegate void GtkMenuPoppedUpCallback(IntPtr widget, IntPtr flippedRect, IntPtr finalRect, bool flippedX, bool flippedY, IntPtr data);

    internal delegate bool GtkNoteBookChangeCurrentPageCallback(IntPtr widget, int obj, IntPtr data);
    internal delegate GtkNoteBookPointer GtkNoteBookCreateWindowCallback(IntPtr widget, GtkWidgetPointer page, int x, int y, IntPtr data);
    internal delegate bool GtkNoteBookFocusTabCallback(IntPtr widget, GtkNotebookTab tab, IntPtr data);
    internal delegate void GtkNoteBookMoveFocusOutCallback(IntPtr widget, GtkDirectionType directionType, IntPtr data);
    internal delegate void GtkNoteBookPageAddedCallback(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data);
    internal delegate void GtkNoteBookPageRemovedCallback(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data);
    internal delegate void GtkNoteBookPageReorderedCallback(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data);
    internal delegate bool GtkNoteBookReorderTabCallback(IntPtr widget, GtkDirectionType directionType, bool p0, IntPtr data);
    internal delegate bool GtkNoteBookSelectPageCallback(IntPtr widget, bool obj, IntPtr data);
    internal delegate void GtkNoteBookSwitchPageCallback(IntPtr widget, GtkWidgetPointer page, uint pageNum, IntPtr data);

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

    internal delegate void GtkWidgetDestroyCallback(IntPtr widget, IntPtr userData);
    internal delegate bool GtkWidgetDestroyedCallback(IntPtr widget, GdkEventPointer evnt, IntPtr userData);
    internal delegate void GtkWidgetSizeAllocateCallback(IntPtr widget, GtkAllocationPointer allocation);
    internal delegate bool GtkWidgetKeyPressCallback(IntPtr widget, GdkEventKeyPointer eventKey, IntPtr userData);
    internal delegate bool GtkWidgetKeyReleaseCallback(IntPtr widget, GdkEventKeyPointer eventKey, IntPtr userData);
    internal delegate bool GtkWidgetButtonPressCallback(IntPtr widget, GdkEventButtonPointer eventButton, IntPtr userData);
    internal delegate bool GtkWidgetButtonReleaseCallback(IntPtr widget, GdkEventButtonPointer eventButton, IntPtr userData);
    internal delegate bool GtkWidgetMotionNotifyCallback(IntPtr widget, GdkEventMotionPointer eventMotion, IntPtr userData);    
}
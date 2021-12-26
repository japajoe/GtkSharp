using System;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Types
{    
    internal delegate bool TickCallback(GtkWidgetPointer widget, GdkFrameClockPointer frame_clock, IntPtr data);
    internal delegate bool TreeModelForeachFunc(GtkTreeModelPointer model, GtkTreePathPointer path, ref GtkTreeIter iter, IntPtr data);

    internal delegate void ButtonActivateCallback(IntPtr widget, IntPtr data);
    internal delegate void ButtonClickedCallback(IntPtr widget, IntPtr data);
    internal delegate void ButtonEnterCallback(IntPtr widget, IntPtr data);
    internal delegate void ButtonLeaveCallback(IntPtr widget, IntPtr data);
    internal delegate void ButtonPressedCallback(IntPtr widget, IntPtr data);
    internal delegate void ButtonReleasedCallback(IntPtr widget, IntPtr data);

    internal delegate void ClipboardTextReceivedCallback(IntPtr clipboard,  string text, IntPtr data);

    internal delegate void ContainerAddCallback(IntPtr widget, IntPtr child, IntPtr data);
    internal delegate void ContainerCheckResizeCallback(IntPtr widget, IntPtr data);
    internal delegate void ContainerRemoveCallback(IntPtr widget, IntPtr child, IntPtr data);
    internal delegate void ContainerSetFocusChildCallback(IntPtr widget, IntPtr child, IntPtr data);

    internal delegate void DialogCloseCallback(IntPtr widget, IntPtr data);
    internal delegate void DialogResponseCallback(IntPtr widget, int responseId, IntPtr data);

    internal delegate void EditableChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void EditableDeleteTextCallback(IntPtr widget, int startPos, int endPos, IntPtr data);
    internal delegate void EditableInsertTextCallback(IntPtr widget, IntPtr newText, int textLength, ref int newPosition, IntPtr data);

    internal delegate void EntryActivateCallback(IntPtr widget, IntPtr data);
    internal delegate void EntryBufferDeletedTextCallback(IntPtr widget, uint position, uint n_chars, IntPtr data);
    internal delegate void EntryBufferInsertedTextCallback(IntPtr widget, uint position, IntPtr chars, uint n_chars, IntPtr data);

    internal delegate GtkFileChooserConfirmation FileChooserConfirmOverwriteCallback(IntPtr widget, IntPtr data);
    internal delegate void FileChooserCurrentFolderChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void FileChooserFileActivatedCallback(IntPtr widget, IntPtr data);
    internal delegate void FileChooserSelectionChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void FileChooserUpdatePreviewCallback(IntPtr widget, IntPtr data);

    internal delegate GdkGLContextPointer GLAreaCreateContextCallback(IntPtr widget, IntPtr data);
    internal delegate void GLAreaResizeCallback(IntPtr widget, int width, int height, IntPtr data);
    internal delegate bool GLAreaRenderCallback(IntPtr widget, IntPtr context);

    internal delegate void LabelActivateCurrentLinkCallback(IntPtr widget, IntPtr data);
    internal delegate void LabelActivateLinkCallback(IntPtr widget, IntPtr uri, IntPtr data);
    internal delegate void LabelCopyClipboardCallback(IntPtr widget, IntPtr data);
    internal delegate void LabelMoveCursorCallback(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data);
    internal delegate void LabelPopulatePopupCallback(IntPtr widget, IntPtr menu, IntPtr data);

    internal delegate void LevelBarOffsetChangedCallback(IntPtr widget, IntPtr name, IntPtr data);

    internal delegate void MenuItemActivateCallback(IntPtr widget, IntPtr data);

    internal delegate void MenuMoveScrollCallback(IntPtr widget, IntPtr scrollType, IntPtr data);
    internal delegate void MenuPoppedUpCallback(IntPtr widget, IntPtr flippedRect, IntPtr finalRect, bool flippedX, bool flippedY, IntPtr data);

    internal delegate bool NoteBookChangeCurrentPageCallback(IntPtr widget, int obj, IntPtr data);
    internal delegate GtkNoteBookPointer NoteBookCreateWindowCallback(IntPtr widget, GtkWidgetPointer page, int x, int y, IntPtr data);
    internal delegate bool NoteBookFocusTabCallback(IntPtr widget, GtkNotebookTab tab, IntPtr data);
    internal delegate void NoteBookMoveFocusOutCallback(IntPtr widget, GtkDirectionType directionType, IntPtr data);
    internal delegate void NoteBookPageAddedCallback(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data);
    internal delegate void NoteBookPageRemovedCallback(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data);
    internal delegate void NoteBookPageReorderedCallback(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data);
    internal delegate bool NoteBookReorderTabCallback(IntPtr widget, GtkDirectionType directionType, bool p0, IntPtr data);
    internal delegate bool NoteBookSelectPageCallback(IntPtr widget, bool obj, IntPtr data);
    internal delegate void NoteBookSwitchPageCallback(IntPtr widget, GtkWidgetPointer page, uint pageNum, IntPtr data);

    internal delegate void SpinButtonValueChangedCallback(IntPtr widget, IntPtr data);

    internal delegate void TextBufferApplyTagCallback(GtkTextBufferPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);
    internal delegate void TextBufferBeginUserActionCallback(GtkTextBufferPointer buffer, IntPtr data);
    internal delegate void TextBufferChangedCallback(GtkTextBufferPointer buffer, IntPtr data);
    internal delegate void TextBufferDeleteRangeCallback(GtkTextBufferPointer buffer, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);
    internal delegate void TextBufferEndUserActionCallback(GtkTextBufferPointer buffer, IntPtr data);
    internal delegate void TextBufferInsertChildAnchorCallback(GtkTextBufferPointer buffer, GtkTextIterPointer location, GtkTextChildAnchorPointer anchor, IntPtr data);
    internal delegate void TextBufferInsertPixbufCallback(GtkTextBufferPointer buffer, GtkTextIterPointer location, GdkPixbufPointer pixbuf, IntPtr data);
    internal delegate void TextBufferInsertTextCallback(GtkTextBufferPointer buffer, GtkTextIterPointer location, IntPtr text, int length, IntPtr data);
    internal delegate void TextBufferMarkDeletedCallback(GtkTextBufferPointer buffer, GtkTextMarkPointer mark, IntPtr data);
    internal delegate void TextBufferMarkSetCallback(GtkTextBufferPointer buffer, GtkTextIterPointer location, GtkTextMarkPointer mark, IntPtr data);
    internal delegate void TextBufferModifiedChangedCallback(GtkTextBufferPointer buffer, IntPtr data);
    internal delegate void TextBufferPasteDoneCallback(GtkTextBufferPointer buffer, GtkClipboardPointer clipboard, IntPtr data);
    internal delegate void TextBufferRemoveTagCallback(GtkTextBufferPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);

    internal delegate void TextViewBackspaceCallback(IntPtr widget, IntPtr data);
    internal delegate void TextViewCopyClipboardCallback(IntPtr widget, IntPtr data);
    internal delegate void TextViewCutClipboardCallback(IntPtr widget, IntPtr data);
    internal delegate void TextViewDeleteFromCursorCallback(IntPtr widget, GtkDeleteType type, int count, IntPtr data);
    internal delegate bool TextViewExtendSelectionCallback(IntPtr widget, GtkTextExtendSelection granularity, GtkTextIterPointer location, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);
    internal delegate void TextViewInsertAtCursorCallback(IntPtr widget, IntPtr str, IntPtr data);
    internal delegate void TextViewInsertEmojiCallback(IntPtr widget, IntPtr data);
    internal delegate void TextViewMoveCursorCallback(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data);
    internal delegate void TextViewMoveViewportCallback(IntPtr widget, IntPtr scrollStep, int count, IntPtr data);
    internal delegate void TextViewPasteClipboardCallback(IntPtr widget, IntPtr data);
    internal delegate void TextViewPopulatePopupCallback(IntPtr widget, IntPtr popup, IntPtr data);
    internal delegate void TextViewPreEditChangedCallback(IntPtr widget, IntPtr str, IntPtr data);

    internal delegate void ToggleButtonToggledCallback(IntPtr widget, IntPtr data);

    internal delegate void WidgetDestroyCallback(IntPtr widget, IntPtr data);
    internal delegate bool WidgetDestroyedCallback(IntPtr widget, GdkEventPointer evnt, IntPtr data);
    internal delegate void WidgetSizeAllocateCallback(IntPtr widget, GtkAllocationPointer allocation);
    internal delegate bool WidgetKeyPressCallback(IntPtr widget, GdkEventKeyPointer eventKey, IntPtr data);
    internal delegate bool WidgetKeyReleaseCallback(IntPtr widget, GdkEventKeyPointer eventKey, IntPtr data);
    internal delegate bool WidgetButtonPressCallback(IntPtr widget, GdkEventButtonPointer eventButton, IntPtr data);
    internal delegate bool WidgetButtonReleaseCallback(IntPtr widget, GdkEventButtonPointer eventButton, IntPtr data);
    internal delegate bool WidgetMotionNotifyCallback(IntPtr widget, GdkEventMotionPointer eventMotion, IntPtr data);
    internal delegate bool WidgetScrollCallback(IntPtr widget, GdkEventScrollPointer eventScroll, IntPtr user_data);
    internal delegate bool WidgetDrawCallback(IntPtr widget, IntPtr cr, IntPtr data);
    internal delegate void WidgetRealizeCallback(IntPtr widget, IntPtr data);
    internal delegate void WidgetUnrealizeCallback(IntPtr widget, IntPtr data);
}
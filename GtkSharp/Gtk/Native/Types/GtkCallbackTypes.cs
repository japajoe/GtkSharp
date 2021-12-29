using System;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Types
{    
    public delegate bool TickCallback(GtkWidgetPointer widget, GdkFrameClockPointer frame_clock, IntPtr data);
    public delegate bool TreeModelForeachFunc(GtkTreeModelPointer model, GtkTreePathPointer path, ref GtkTreeIter iter, IntPtr data);

    public delegate void ButtonActivateCallback(IntPtr widget, IntPtr data);
    public delegate void ButtonClickedCallback(IntPtr widget, IntPtr data);
    public delegate void ButtonEnterCallback(IntPtr widget, IntPtr data);
    public delegate void ButtonLeaveCallback(IntPtr widget, IntPtr data);
    public delegate void ButtonPressedCallback(IntPtr widget, IntPtr data);
    public delegate void ButtonReleasedCallback(IntPtr widget, IntPtr data);

    public delegate void ClipboardTextReceivedCallback(IntPtr clipboard,  string text, IntPtr data);

    public delegate void ContainerAddCallback(IntPtr widget, IntPtr child, IntPtr data);
    public delegate void ContainerCheckResizeCallback(IntPtr widget, IntPtr data);
    public delegate void ContainerRemoveCallback(IntPtr widget, IntPtr child, IntPtr data);
    public delegate void ContainerSetFocusChildCallback(IntPtr widget, IntPtr child, IntPtr data);

    public delegate void DialogCloseCallback(IntPtr widget, IntPtr data);
    public delegate void DialogResponseCallback(IntPtr widget, int responseId, IntPtr data);

    public delegate void EditableChangedCallback(IntPtr widget, IntPtr data);
    public delegate void EditableDeleteTextCallback(IntPtr widget, int startPos, int endPos, IntPtr data);
    public delegate void EditableInsertTextCallback(IntPtr widget, IntPtr newText, int textLength, ref int newPosition, IntPtr data);

    public delegate void EntryActivateCallback(IntPtr widget, IntPtr data);
    public delegate void EntryBufferDeletedTextCallback(IntPtr widget, uint position, uint n_chars, IntPtr data);
    public delegate void EntryBufferInsertedTextCallback(IntPtr widget, uint position, IntPtr chars, uint n_chars, IntPtr data);

    public delegate GtkFileChooserConfirmation FileChooserConfirmOverwriteCallback(IntPtr widget, IntPtr data);
    public delegate void FileChooserCurrentFolderChangedCallback(IntPtr widget, IntPtr data);
    public delegate void FileChooserFileActivatedCallback(IntPtr widget, IntPtr data);
    public delegate void FileChooserSelectionChangedCallback(IntPtr widget, IntPtr data);
    public delegate void FileChooserUpdatePreviewCallback(IntPtr widget, IntPtr data);

    public delegate GdkGLContextPointer GLAreaCreateContextCallback(IntPtr widget, IntPtr data);
    public delegate void GLAreaResizeCallback(IntPtr widget, int width, int height, IntPtr data);
    public delegate bool GLAreaRenderCallback(IntPtr widget, IntPtr context);

    public delegate void LabelActivateCurrentLinkCallback(IntPtr widget, IntPtr data);
    public delegate void LabelActivateLinkCallback(IntPtr widget, IntPtr uri, IntPtr data);
    public delegate void LabelCopyClipboardCallback(IntPtr widget, IntPtr data);
    public delegate void LabelMoveCursorCallback(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data);
    public delegate void LabelPopulatePopupCallback(IntPtr widget, IntPtr menu, IntPtr data);

    public delegate void LevelBarOffsetChangedCallback(IntPtr widget, IntPtr name, IntPtr data);

    public delegate void MenuItemActivateCallback(IntPtr widget, IntPtr data);

    public delegate void MenuMoveScrollCallback(IntPtr widget, IntPtr scrollType, IntPtr data);
    public delegate void MenuPoppedUpCallback(IntPtr widget, IntPtr flippedRect, IntPtr finalRect, bool flippedX, bool flippedY, IntPtr data);

    public delegate bool NoteBookChangeCurrentPageCallback(IntPtr widget, int obj, IntPtr data);
    public delegate GtkNoteBookPointer NoteBookCreateWindowCallback(IntPtr widget, GtkWidgetPointer page, int x, int y, IntPtr data);
    public delegate bool NoteBookFocusTabCallback(IntPtr widget, GtkNotebookTab tab, IntPtr data);
    public delegate void NoteBookMoveFocusOutCallback(IntPtr widget, GtkDirectionType directionType, IntPtr data);
    public delegate void NoteBookPageAddedCallback(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data);
    public delegate void NoteBookPageRemovedCallback(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data);
    public delegate void NoteBookPageReorderedCallback(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data);
    public delegate bool NoteBookReorderTabCallback(IntPtr widget, GtkDirectionType directionType, bool p0, IntPtr data);
    public delegate bool NoteBookSelectPageCallback(IntPtr widget, bool obj, IntPtr data);
    public delegate void NoteBookSwitchPageCallback(IntPtr widget, GtkWidgetPointer page, uint pageNum, IntPtr data);

    public delegate void SpinButtonValueChangedCallback(IntPtr widget, IntPtr data);

    public delegate void TextBufferApplyTagCallback(GtkTextBufferPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);
    public delegate void TextBufferBeginUserActionCallback(GtkTextBufferPointer buffer, IntPtr data);
    public delegate void TextBufferChangedCallback(GtkTextBufferPointer buffer, IntPtr data);
    public delegate void TextBufferDeleteRangeCallback(GtkTextBufferPointer buffer, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);
    public delegate void TextBufferEndUserActionCallback(GtkTextBufferPointer buffer, IntPtr data);
    public delegate void TextBufferInsertChildAnchorCallback(GtkTextBufferPointer buffer, GtkTextIterPointer location, GtkTextChildAnchorPointer anchor, IntPtr data);
    public delegate void TextBufferInsertPixbufCallback(GtkTextBufferPointer buffer, GtkTextIterPointer location, GdkPixbufPointer pixbuf, IntPtr data);
    public delegate void TextBufferInsertTextCallback(GtkTextBufferPointer buffer, GtkTextIterPointer location, IntPtr text, int length, IntPtr data);
    public delegate void TextBufferMarkDeletedCallback(GtkTextBufferPointer buffer, GtkTextMarkPointer mark, IntPtr data);
    public delegate void TextBufferMarkSetCallback(GtkTextBufferPointer buffer, GtkTextIterPointer location, GtkTextMarkPointer mark, IntPtr data);
    public delegate void TextBufferModifiedChangedCallback(GtkTextBufferPointer buffer, IntPtr data);
    public delegate void TextBufferPasteDoneCallback(GtkTextBufferPointer buffer, GtkClipboardPointer clipboard, IntPtr data);
    public delegate void TextBufferRemoveTagCallback(GtkTextBufferPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);

    public delegate void TextViewBackspaceCallback(IntPtr widget, IntPtr data);
    public delegate void TextViewCopyClipboardCallback(IntPtr widget, IntPtr data);
    public delegate void TextViewCutClipboardCallback(IntPtr widget, IntPtr data);
    public delegate void TextViewDeleteFromCursorCallback(IntPtr widget, GtkDeleteType type, int count, IntPtr data);
    public delegate bool TextViewExtendSelectionCallback(IntPtr widget, GtkTextExtendSelection granularity, GtkTextIterPointer location, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data);
    public delegate void TextViewInsertAtCursorCallback(IntPtr widget, IntPtr str, IntPtr data);
    public delegate void TextViewInsertEmojiCallback(IntPtr widget, IntPtr data);
    public delegate void TextViewMoveCursorCallback(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data);
    public delegate void TextViewMoveViewportCallback(IntPtr widget, IntPtr scrollStep, int count, IntPtr data);
    public delegate void TextViewPasteClipboardCallback(IntPtr widget, IntPtr data);
    public delegate void TextViewPopulatePopupCallback(IntPtr widget, IntPtr popup, IntPtr data);
    public delegate void TextViewPreEditChangedCallback(IntPtr widget, IntPtr str, IntPtr data);

    public delegate void ToggleButtonToggledCallback(IntPtr widget, IntPtr data);

    public delegate void WidgetDestroyCallback(IntPtr widget, IntPtr data);
    public delegate bool WidgetDestroyedCallback(IntPtr widget, GdkEventPointer evnt, IntPtr data);
    public delegate void WidgetSizeAllocateCallback(IntPtr widget, GtkAllocationPointer allocation);
    public delegate bool WidgetKeyPressCallback(IntPtr widget, GdkEventKeyPointer eventKey, IntPtr data);
    public delegate bool WidgetKeyReleaseCallback(IntPtr widget, GdkEventKeyPointer eventKey, IntPtr data);
    public delegate bool WidgetButtonPressCallback(IntPtr widget, GdkEventButtonPointer eventButton, IntPtr data);
    public delegate bool WidgetButtonReleaseCallback(IntPtr widget, GdkEventButtonPointer eventButton, IntPtr data);
    public delegate bool WidgetMotionNotifyCallback(IntPtr widget, GdkEventMotionPointer eventMotion, IntPtr data);
    public delegate bool WidgetScrollCallback(IntPtr widget, GdkEventScrollPointer eventScroll, IntPtr user_data);
    public delegate bool WidgetDrawCallback(IntPtr widget, IntPtr cr, IntPtr data);
    public delegate void WidgetRealizeCallback(IntPtr widget, IntPtr data);
    public delegate void WidgetUnrealizeCallback(IntPtr widget, IntPtr data);
}
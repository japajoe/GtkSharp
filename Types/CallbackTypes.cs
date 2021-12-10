using GtkSharp.Drawing;
using GtkSharp.Native;

namespace GtkSharp
{


    public delegate void ApplicationQuitEvent();

    public delegate void ButtonActivateEvent();
    public delegate void ButtonClickedEvent();
    public delegate void ButtonEnterEvent();
    public delegate void ButtonLeaveEvent();
    public delegate void ButtonPressedEvent();
    public delegate void ButtonReleasedEvent();

    public delegate void EntryActivateEvent();
    public delegate void EntryBackspaceEvent();
    public delegate void EntryCopyClipboardEvent();
    public delegate void EntryCutClipboardEvent();
    public delegate void EntryDeleteFromCursorEvent(GtkDeleteType type, int count);
    public delegate void EntryIconPressEvent(GtkEntryIconPosition position, GdkEventPointer gdkEvent);
    public delegate void EntryIconReleaseEvent(GtkEntryIconPosition position, GdkEventPointer gdkEvent);
    public delegate void EntryInsertAtCursorEvent(string text);
    public delegate void EntryInsertEmojiEvent();
    public delegate void EntryMoveCursorEvent(GtkMovementStep step, int count, bool extendSelection);
    public delegate void EntryPasteClipboardEvent();
    public delegate void EntryPopulatePopupEvent();

    public delegate void LabelActivateCurrentLinkEvent();
    public delegate void LabelActivateLinkEvent(string uri);
    public delegate void LabelCopyClipboardEvent();
    public delegate void LabelMoveCursorEvent(GtkMovementStep step, int count);
    public delegate void LabelPopulatePopupEvent(Menu menu);

    public delegate void EntryChangedEvent();
    public delegate void EntrySubmitEvent();
    public delegate void EntryBufferDeletedEvent(uint position, uint n_chars);
    public delegate void EntryBufferInsertedEvent(uint position, string chars, uint n_chars);

    public delegate GtkFileChooserConfirmation FileChooserConfirmOverwriteEvent();
    public delegate void FileChooserCurrentFolderChangedEvent();
    public delegate void FileChooserFileActivatedEvent();
    public delegate void FileChooserSelectionChangedEvent();
    public delegate void FileChooserUpdatePreviewEvent();

    public delegate bool NoteBookChangeCurrentPageEvent(int obj);
    public delegate GtkNoteBookPointer NoteBookCreateWindowEvent(GtkWidgetPointer page, int x, int y);
    public delegate bool NoteBookFocusTabEvent(GtkNotebookTab tab);
    public delegate void NoteBookMoveFocusOutEvent(GtkDirectionType directionType);
    public delegate void NoteBookPageAddedEvent(GtkWidgetPointer child, uint pageNum);
    public delegate void NoteBookPageRemovedEvent(GtkWidgetPointer child, uint pageNum);
    public delegate void NoteBookPageReorderedEvent(GtkWidgetPointer child, uint pageNum);
    public delegate bool NoteBookReorderTabEvent(GtkDirectionType directionType, bool p0);
    public delegate bool NoteBookSelectPageEvent(bool obj);
    public delegate void NoteBookSwitchPageEvent(GtkWidgetPointer page, uint pageNum);

    public delegate void TextViewChangedEvent();
    public delegate void SourceViewChangedEvent();    
    public delegate void SpinButtonValueChangedEvent();
    public delegate void ToggleButtonValueChangedEvent();
    public delegate void NoteBookSelectedIndexChanged(uint index);
    
    public delegate void GLAreaCreateContextEvent();
    public delegate void GLAreaResizeEvent(int width, int height);
    public delegate void GLAreaRenderEvent();
    public delegate void GLAreaRealizeEvent();
    public delegate void GLAreaUnRealizeEvent();

    public delegate void LevelBarOffsetChangedEvent(string name);

    public delegate void MenuMoveScrollEvent(GtkScrollType scrollType);
    public delegate void MenuPoppedUpEvent(bool flippedX, bool flippedY);

    public delegate void MenuItemActivateEvent();

    public delegate void WidgetDestroyEvent();
    public delegate bool WidgetDestroyedEvent();
    public delegate void WidgetSizeAllocateEvent(GtkAllocation allocation);
    public delegate bool WidgetKeyPressEvent(GdkEventKey eventKey);
    public delegate bool WidgetKeyReleaseEvent(GdkEventKey eventKey);
    public delegate bool WidgetButtonPressEvent(GdkEventButton eventButton);
    public delegate bool WidgetButtonReleaseEvent(GdkEventButton eventButton);
    public delegate bool WidgetMotionNotifyEvent(GdkEventMotion eventMotion);
    public delegate bool WidgetDrawEvent(Cairo cr);

    public delegate void SourceBufferApplyTagEvent(GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end);
    public delegate void SourceBufferBeginUserActionEvent();
    public delegate void SourceBufferChangedEvent();
    public delegate void SourceBufferDeleteRangeEvent(GtkTextIterPointer start, GtkTextIterPointer end);
    public delegate void SourceBufferEndUserActionEvent();
    public delegate void SourceBufferInsertChildAnchorEvent(GtkTextIterPointer location, GtkTextChildAnchorPointer anchor);
    public delegate void SourceBufferInsertPixbufEvent(GtkTextIterPointer location, GdkPixbufPointer pixbuf);
    public delegate void SourceBufferInsertTextEvent(GtkTextIterPointer location, string text, int length);
    public delegate void SourceBufferMarkDeletedEvent(GtkTextMarkPointer mark);
    public delegate void SourceBufferMarkSetEvent(GtkTextIterPointer location, GtkTextMarkPointer mark);
    public delegate void SourceBufferModifiedChangedEvent();
    public delegate void SourceBufferPasteDoneEvent(GtkClipboardPointer clipboard);
    public delegate void SourceBufferRemoveTagEvent(GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end);

    public delegate void TextBufferApplyTagEvent(GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end);
    public delegate void TextBufferBeginUserActionEvent();
    public delegate void TextBufferChangedEvent();
    public delegate void TextBufferDeleteRangeEvent(GtkTextIterPointer start, GtkTextIterPointer end);
    public delegate void TextBufferEndUserActionEvent();
    public delegate void TextBufferInsertChildAnchorEvent(GtkTextIterPointer location, GtkTextChildAnchorPointer anchor);
    public delegate void TextBufferInsertPixbufEvent(GtkTextIterPointer location, GdkPixbufPointer pixbuf);
    public delegate void TextBufferInsertTextEvent(GtkTextIterPointer location, string text, int length);
    public delegate void TextBufferMarkDeletedEvent(GtkTextMarkPointer mark);
    public delegate void TextBufferMarkSetEvent(GtkTextIterPointer location, GtkTextMarkPointer mark);
    public delegate void TextBufferModifiedChangedEvent();
    public delegate void TextBufferPasteDoneEvent(GtkClipboardPointer clipboard);
    public delegate void TextBufferRemoveTagEvent(GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end);

    public delegate void TextViewBackspaceEvent();
    public delegate void TextViewCopyClipboardEvent();
    public delegate void TextViewCutClipboardEvent();
    public delegate void TextViewDeleteFromCursorEvent(GtkDeleteType type, int count);
    public delegate bool TextViewExtendSelectionEvent(GtkTextExtendSelection granularity, GtkTextIterPointer location, GtkTextIterPointer start, GtkTextIterPointer end);
    public delegate void TextViewInsertAtCursorEvent(string str);
    public delegate void TextViewInsertEmojiEvent();
    public delegate void TextViewMoveCursorEvent(GtkMovementStep step, int count, bool extendSelection);
    public delegate void TextViewMoveViewportEvent(GtkScrollStep step, int count);
    public delegate void TextViewPasteClipboardEvent();
    public delegate void TextViewPopulatePopupEvent();
    public delegate void TextViewPreeditChangedEvent(string str);
}
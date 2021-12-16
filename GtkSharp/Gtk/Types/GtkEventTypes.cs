using GtkSharp.Cairo.Types;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gdk.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Widgets;

namespace GtkSharp.Gtk.Types
{
    public delegate void ApplicationQuitEvent();

    public delegate void ButtonActivateEvent();
    public delegate void ButtonClickedEvent();
    public delegate void ButtonEnterEvent();
    public delegate void ButtonLeaveEvent();
    public delegate void ButtonPressedEvent();
    public delegate void ButtonReleasedEvent();

    public delegate void ContainerAddEvent(Widget child);
    public delegate void ContainerCheckResizeEvent();
    public delegate void ContainerRemoveEvent(Widget child);
    public delegate void ContainerSetFocusChildEvent(Widget child);

    public delegate void DialogCloseEvent();
    public delegate void DialogResponseEvent(int responseId);

    public delegate GtkFileChooserConfirmation FileChooserConfirmOverwriteEvent();
    public delegate void FileChooserCurrentFolderChangedEvent();
    public delegate void FileChooserFileActivatedEvent();
    public delegate void FileChooserSelectionChangedEvent();
    public delegate void FileChooserUpdatePreviewEvent();

    public delegate void GLAreaCreateContextEvent();
    public delegate void GLAreaResizeEvent(int width, int height);
    public delegate void GLAreaRenderEvent();

    public delegate void MenuItemActivateEvent();

    public delegate void MenuMoveScrollEvent(GtkScrollType scrollType);
    public delegate void MenuPoppedUpEvent(bool flippedX, bool flippedY);    

    public delegate void LabelActivateCurrentLinkEvent();
    public delegate void LabelActivateLinkEvent(string uri);
    public delegate void LabelCopyClipboardEvent();
    public delegate void LabelMoveCursorEvent(GtkMovementStep step, int count);

    public delegate void LevelBarOffsetChangedEvent(string name);

    public delegate bool NoteBookChangeCurrentPageEvent(int obj);
    public delegate NoteBook NoteBookCreateWindowEvent(Widget page, int x, int y);
    public delegate bool NoteBookFocusTabEvent(GtkNotebookTab tab);
    public delegate void NoteBookMoveFocusOutEvent(GtkDirectionType directionType);
    public delegate void NoteBookPageAddedEvent(Widget child, uint pageNum);
    public delegate void NoteBookPageRemovedEvent(Widget child, uint pageNum);
    public delegate void NoteBookPageReorderedEvent(Widget child, uint pageNum);
    public delegate bool NoteBookReorderTabEvent(GtkDirectionType directionType, bool p0);
    public delegate bool NoteBookSelectPageEvent(bool obj);
    public delegate void NoteBookSwitchPageEvent(Widget page, uint pageNum);

    public delegate void SpinButtonValueChangedEvent();

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
    public delegate void TextViewPreEditChangedEvent(string str);

    public delegate void ToggleButtonToggledEvent();
    
    public delegate void WidgetDestroyEvent();
    public delegate bool WidgetDestroyedEvent();
    public delegate void WidgetSizeAllocateEvent(GtkAllocation allocation);
    public delegate bool WidgetKeyPressEvent(GdkEventKey eventKey);
    public delegate bool WidgetKeyReleaseEvent(GdkEventKey eventKey);
    public delegate bool WidgetButtonPressEvent(GdkEventButton eventButton);
    public delegate bool WidgetButtonReleaseEvent(GdkEventButton eventButton);
    public delegate bool WidgetMotionNotifyEvent(GdkEventMotion eventMotion);
    public delegate bool WidgetDrawEvent(CairoInstance cr);
    public delegate void WidgetRealizeEvent();
    public delegate void WidgetUnrealizeEvent();
}
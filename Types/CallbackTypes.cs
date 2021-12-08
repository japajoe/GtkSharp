using GtkSharp.Drawing;
using GtkSharp.Native;

namespace GtkSharp
{
    public delegate void WindowClosingEvent();
    public delegate void WindowClosedEvent();
    public delegate void WindowResizeEvent(int width, int height);
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


    public delegate void EntryChangedEvent();
    public delegate void EntrySubmitEvent();
    public delegate void TextViewChangedEvent();
    public delegate void SourceViewChangedEvent();
    public delegate bool DrawEvent(Cairo cr);
    public delegate void SpinButtonValueChangedEvent();
    public delegate void ToggleButtonValueChangedEvent();
    public delegate void NoteBookSelectedIndexChanged(uint index);
    public delegate void MenuItemClickedEvent();
    public delegate void GLAreaRenderEvent();
    public delegate void GLAreaRealizeEvent();
    public delegate void GLAreaUnRealizeEvent();
}
using GtkSharp.Drawing;
using GtkSharp.Native;

namespace GtkSharp
{
    public delegate void WidgetDestroyEvent();
    public delegate bool WidgetDestroyedEvent();
    public delegate void WidgetSizeAllocateEvent(GtkAllocation allocation);
    public delegate bool WidgetKeyPressEvent(GdkEventKey eventKey);
    public delegate bool WidgetKeyReleaseEvent(GdkEventKey eventKey);
    public delegate bool WidgetButtonPressEvent(GdkEventButton eventButton);
    public delegate bool WidgetButtonReleaseEvent(GdkEventButton eventButton);
    public delegate bool WidgetMotionNotifyEvent(GdkEventMotion eventMotion);
    public delegate bool WidgetDrawEvent(Cairo cr);

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
    public delegate void TextViewChangedEvent();
    public delegate void SourceViewChangedEvent();    
    public delegate void SpinButtonValueChangedEvent();
    public delegate void ToggleButtonValueChangedEvent();
    public delegate void NoteBookSelectedIndexChanged(uint index);
    public delegate void MenuItemClickedEvent();
    
    public delegate void GLAreaCreateContextEvent();
    public delegate void GLAreaResizeEvent(int width, int height);
    public delegate void GLAreaRenderEvent();
    public delegate void GLAreaRealizeEvent();
    public delegate void GLAreaUnRealizeEvent();

    public delegate void LevelBarOffsetChangedEvent(string name);

    public delegate void MenuMoveScrollEvent(GtkScrollType scrollType);
    public delegate void MenuPoppedUpEvent(bool flippedX, bool flippedY);

    public delegate void MenuItemActivateEvent();
}
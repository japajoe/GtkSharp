using GtkSharp.Drawing;

namespace GtkSharp
{
    public delegate void WindowClosingEvent();
    public delegate void WindowClosedEvent();
    public delegate void ApplicationQuitEvent();
    public delegate void ButtonClickedEvent();
    public delegate void EntryChangedEvent();
    public delegate void EntrySubmitEvent();
    public delegate void TextViewChangedEvent();
    public delegate void SourceViewChangedEvent();
    public delegate void DrawEvent(Cairo cr);
    public delegate void SpinButtonValueChanged();
    public delegate void ToggleButtonValueChanged();
}
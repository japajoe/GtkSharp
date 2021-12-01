using System;
using System.Text;
using GtkSharp.Native;

namespace GtkSharp
{
    public class SourceView : Widget
    {
        public event SourceViewChangedEvent onChanged;

        private GtkSourceBufferChangedCallback onChangedNative;
        private GtkSourceBufferPointer buffer;
        private StringBuilder stringBuilder;
        private string text;

        public string Text
        {
            get
            {
                return GetText();
            }
            set
            {
                SetText(value);            
            }
        }

        public SourceView(SourceLanguage language)
        {            
            this.text = string.Empty;
            this.stringBuilder = new StringBuilder(4096);
            string languageString = GetLanguageString(language);
            Gtk.GtkSharpSourceViewCreate(out handle.pointer, out buffer.pointer, languageString);

            onChangedNative = GtkSharpDelegate.Create<GtkSourceBufferChangedCallback>(this, "OnChanged");

            Gtk.GtkSharpSourceBufferChangedCallbackConnect(out buffer.pointer, onChangedNative);
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpSourceViewSetText(out handle.pointer, out buffer.pointer, text);
            this.text = text;
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return string.Empty;            

            stringBuilder.Clear();

            uint length = 0;
            Gtk.GtkSharpSourceBufferGetLength(out buffer.pointer, out length);

            if(length > stringBuilder.Capacity)
                stringBuilder.EnsureCapacity((int)length);

            Gtk.GtkSharpSourceViewGetText(out handle.pointer, out buffer.pointer, stringBuilder);            
            
            text = stringBuilder.ToString().Substring(0, (int)length);
            
            return text;
        }

        public void Clear()
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpSourceViewClearText(out handle.pointer, out buffer.pointer);
            this.text = string.Empty;
        }

        public void ToggleLineNumbers(bool visible)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpSourceViewToggleLineNumbers(out handle.pointer, visible);
        }

        public static string GetLanguageString(SourceLanguage language)
        {
            switch(language)
            {
                case SourceLanguage.C:
                    return "c";
                case SourceLanguage.CPP:
                    return "cpp";
                case SourceLanguage.CSharp:
                    return "c-sharp";
                case SourceLanguage.GLSL:
                    return "glsl";
                case SourceLanguage.Lua:
                    return "lua";
                default:
                    return "c";
            }
        }

        private void OnChanged(IntPtr widget, IntPtr data)
        {
            onChanged?.Invoke();
        }        
    }

    public enum SourceLanguage
    {
        C,
        CPP,
        CSharp,
        GLSL,
        Lua        
    }
}
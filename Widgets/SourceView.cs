using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class SourceView : Widget
    {
        public event SourceViewChangedEvent onChanged;

        private GtkSourceBufferChangedCallback onChangedNative;
        private GtkSourceBufferPointer buffer;
        private GtkSourceLanguageManagerPointer sourceLanguageManager;
        private GtkSourceLanguagePointer sourceLanguage;
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

            NativeSourceView.GtkSharpSourceLanguageManagerGetDefault(out sourceLanguageManager.pointer);
            NativeSourceView.GtkSharpSourceLanguageManagerGetLanguage(out sourceLanguageManager.pointer, out sourceLanguage.pointer, languageString);
            NativeSourceView.GtkSharpSourceBufferCreateWithLanguage(out buffer.pointer, out sourceLanguage.pointer);
            NativeSourceView.GtkSharpSourceViewCreateWithBuffer(out handle.pointer, out buffer.pointer);
            NativeSourceView.GtkSharpSourceViewSetTabWidth(out handle.pointer, 4);

            onChangedNative = GtkSharpDelegate.Create<GtkSourceBufferChangedCallback>(this, "OnChanged");

            Gtk.GtkSharpSourceBufferChangedCallbackConnect(out buffer.pointer, onChangedNative);
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            NativeTextBuffer.GtkSharpTextBufferSetText(out buffer.pointer, text, text.Length);
            
            this.text = text;
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return string.Empty;            

            stringBuilder.Clear();

            int length = 0;

            NativeTextBuffer.GtkSharpTextBufferGetCharCount(out buffer.pointer, out length);

            if(length > stringBuilder.Capacity)
            {
                stringBuilder.Capacity = length;
                stringBuilder.EnsureCapacity(length);
            }

            GtkTextIterPointer iterStart;
            GtkTextIterPointer iterEnd;
            
            NativeTextBuffer.GtkSharpTextBufferGetBounds(out buffer.pointer, out iterStart.pointer, out iterEnd.pointer);
            NativeTextBuffer.GtkSharpTextBufferGetText(out buffer.pointer, out iterStart.pointer, out iterEnd.pointer, true, stringBuilder);
            NativeTextBuffer.GtkSharpTextIterFree(out iterStart.pointer);
            NativeTextBuffer.GtkSharpTextIterFree(out iterEnd.pointer);            
            
            text = stringBuilder.ToString().Substring(0, (int)length);
            
            return text;
        }

        public void Clear()
        {
            if(handle.IsNullPointer)
                return;

            GtkTextIterPointer iterStart;
            GtkTextIterPointer iterEnd;

            NativeTextBuffer.GtkSharpTextBufferGetBounds(out buffer.pointer, out iterStart.pointer, out iterEnd.pointer);
            NativeTextBuffer.GtkSharpTextBufferDelete(out buffer.pointer, out iterStart.pointer, out iterEnd.pointer);
            NativeTextBuffer.GtkSharpTextIterFree(out iterStart.pointer);
            NativeTextBuffer.GtkSharpTextIterFree(out iterEnd.pointer);             

            this.text = string.Empty;
        }

        public void ToggleLineNumbers(bool visible)
        {
            if(handle.IsNullPointer)
                return;
                
            NativeSourceView.GtkSharpSourceViewSetShowLineNumbers(out handle.pointer, visible);
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

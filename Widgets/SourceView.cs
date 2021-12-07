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

        public bool LineNumbers
        {
            get
            {
                return GetShowLineNumbers();
            }
            set
            {
                SetShowLineNumbers(value);
            }
        }

        public int TabWidth
        {
            get
            {
                return GetTabWidth();
            }
            set
            {
                SetTabWidth(value);
            }
        }

        public SourceView(string languageString)
        {            
            this.text = string.Empty;
            this.stringBuilder = new StringBuilder(4096);

            NativeSourceView.GtkSharpSourceLanguageManagerGetDefault(out sourceLanguageManager);
            NativeSourceView.GtkSharpSourceLanguageManagerGetLanguage(out sourceLanguageManager, out sourceLanguage, languageString);
            NativeSourceView.GtkSharpSourceBufferCreateWithLanguage(out buffer, out sourceLanguage);
            NativeSourceView.GtkSharpSourceViewCreateWithBuffer(out handle, out buffer);
            NativeSourceView.GtkSharpSourceViewSetTabWidth(out handle, 4);

            onChangedNative = GtkSharpDelegate.Create<GtkSourceBufferChangedCallback>(this, "OnChanged");

            Gtk.GtkSharpSignalConnect(out buffer.pointer, "changed", onChangedNative.ToIntPtr(), out buffer.pointer);
        }

        public void SetText(string text)
        {
            if(buffer.IsNullPointer)
                return;

            NativeSourceBuffer.GtkSharpTextBufferSetText(out buffer, text, text.Length);
            
            this.text = text;
        }

        public string GetText()
        {
            if(buffer.IsNullPointer)
                return string.Empty;            

            stringBuilder.Clear();

            int length = 0;

            NativeSourceBuffer.GtkSharpTextBufferGetCharCount(out buffer, out length);

            if(length > stringBuilder.Capacity)
            {
                stringBuilder.Capacity = length;
                stringBuilder.EnsureCapacity(length);
            }

            GtkTextIterPointer iterStart;
            GtkTextIterPointer iterEnd;
            
            NativeSourceBuffer.GtkSharpTextBufferGetBounds(out buffer, out iterStart, out iterEnd);
            NativeSourceBuffer.GtkSharpTextBufferGetText(out buffer, out iterStart, out iterEnd, true, stringBuilder);
            NativeSourceBuffer.GtkSharpTextIterFree(out iterStart);
            NativeSourceBuffer.GtkSharpTextIterFree(out iterEnd);            
            
            text = stringBuilder.ToString().Substring(0, length);
            
            return text;
        }

        public void Clear()
        {
            if(buffer.IsNullPointer)
                return;

            GtkTextIterPointer iterStart;
            GtkTextIterPointer iterEnd;

            NativeSourceBuffer.GtkSharpTextBufferGetBounds(out buffer, out iterStart, out iterEnd);
            NativeSourceBuffer.GtkSharpTextBufferDelete(out buffer, out iterStart, out iterEnd);
            NativeSourceBuffer.GtkSharpTextIterFree(out iterStart);
            NativeSourceBuffer.GtkSharpTextIterFree(out iterEnd);             

            this.text = string.Empty;
        }

        public bool GetShowLineNumbers()
        {
            if(handle.IsNullPointer)
                return false;
            
            bool visible;
            NativeSourceView.GtkSharpSourceViewGetShowLineNumbers(out handle, out visible);
            return visible;
        }

       public void SetShowLineNumbers(bool visible)
        {
            if(handle.IsNullPointer)
                return;
                
            NativeSourceView.GtkSharpSourceViewSetShowLineNumbers(out handle, visible);
        }

        public void SetTabWidth(int width)
        {
            if(handle.IsNullPointer)
                return;

            if(width < 1)
                width = 1;

            NativeSourceView.GtkSharpSourceViewSetTabWidth(out handle, width);
        }

        public int GetTabWidth()
        {
            if(handle.IsNullPointer)
                return 1;
            
            int width;
            NativeSourceView.GtkSharpSourceViewGetTabWidth(out handle, out width);
            return width;
        }

        private void OnChanged(IntPtr widget, IntPtr data)
        {
            onChanged?.Invoke();
        }        
    }
}
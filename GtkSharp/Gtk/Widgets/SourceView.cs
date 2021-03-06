using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class SourceView : Widget
    {
        private GtkSourceLanguageManager languageManager;
        private GtkSourceLanguagePointer language;
        private GtkSourceBuffer buffer;
        private string text;

        public SourceView()
        {            
            buffer = new GtkSourceBuffer();
            handle = NativeSourceView.gtk_source_view_new_with_buffer(buffer.Handle);
        }

        public SourceView(string languageId)
        {            
            languageManager = new GtkSourceLanguageManager();
            language = languageManager.GetLanguage(languageId);
            buffer = new GtkSourceBuffer(language);
            handle = NativeSourceView.gtk_source_view_new_with_buffer(buffer.Handle);
            NativeSourceView.gtk_source_view_set_tab_width(handle, 4);
            NativeSourceView.gtk_source_view_set_show_line_numbers(handle, true);        
        }

        public string Text
        {
            get
            {
                text = buffer.Text;
                return text;
            }
            set
            {
                text = value;
                buffer.Text = text;
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

        public uint TabWidth
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

        public void Clear()
        {
            if(handle.IsNullPointer)
                return;

            buffer.Clear();
            text = string.Empty;
        }

        private bool GetShowLineNumbers()
        {
            if(handle.IsNullPointer)
                return false;
            
            return NativeSourceView.gtk_source_view_get_show_line_numbers(handle);
        }

        private void SetShowLineNumbers(bool visible)
        {
            if(handle.IsNullPointer)
                return;
                
            NativeSourceView.gtk_source_view_set_show_line_numbers(handle, visible);
        }

        private void SetTabWidth(uint width)
        {
            if(handle.IsNullPointer)
                return;

            if(width < 1)
                width = 1;

            NativeSourceView.gtk_source_view_set_tab_width(handle, width);
        }

        private uint GetTabWidth()
        {
            if(handle.IsNullPointer)
                return 1;
            
            return NativeSourceView.gtk_source_view_get_tab_width(handle);
        }
    }
}
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class SourceLanguageManager : Widget
    {
       public SourceLanguageManager()
       {
           handle = NativeSourceLanguageManager.gtk_source_language_manager_get_default();
       }

       public GtkSourceLanguagePointer GetLanguage(string languageId)
       {
           if(handle.IsNullPointer)
            return new GtkSourceLanguagePointer();

           return NativeSourceLanguageManager.gtk_source_language_manager_get_language(handle, languageId);
       }
    }
}
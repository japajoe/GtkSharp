

using GtkSharp.Native.Types;
using GtkSharp.Native.Widgets;

namespace GtkSharp
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
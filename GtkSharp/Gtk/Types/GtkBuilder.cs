using GtkSharp.Glib.Native.Types;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Types
{
    /// <summary>
    /// The GtkBuilder class implementation is experimental and some native features like automatic signal connecting might not be supported
    /// </summary>
    public class GtkBuilder : GObject
    {
        public GtkBuilder()
        {
            
        }

        public bool LoadFromFile(string filepath)
        {
            if(handle.IsNullPointer)
            {
                handle = NativeBuilder.gtk_builder_new_from_file(filepath);
                return true;
            }
            return false;
        }

        public bool LoadFromResource(string resourcePath)
        {
            if(handle.IsNullPointer)
            {
                handle = NativeBuilder.gtk_builder_new_from_resource(resourcePath);
                return true;
            }
            return false;
        }

        public bool LoadFromString(string text)
        {
            if(handle.IsNullPointer)
            {
                long length = (long)text.Length;
                handle = NativeBuilder.gtk_builder_new_from_string(text, length);
                return true;
            }
            return false;
        }

        public T GetObject<T>(string name) where T : GObject, new()
        {
            if(handle.IsNullPointer)
                return null;
            
            GObjectPointer ptr = NativeBuilder.gtk_builder_get_object(handle, name);

            if(ptr.IsNullPointer)
                return null;

            T instance = new T();
            instance.Handle = ptr;
            return instance;
        }
    }
}
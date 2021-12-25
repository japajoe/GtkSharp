using GtkSharp.Glib.Native.Types;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Types
{
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

        // public GObject GetObject(string name)
        // {
        //     NativeBuilder.gtk_builder_get_object(handle, name);
        // }
    }
}
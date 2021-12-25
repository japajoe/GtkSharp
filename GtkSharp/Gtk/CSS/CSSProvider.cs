using System;
using GtkSharp.Glib.Native.Types;
using GtkSharp.GLib.Native;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.CSS;
using GtkSharp.Utilities;

namespace GtkSharp.Gtk.CSS
{
    public class CSSProvider : GObject
    {
        public CSSProvider()
        {
            handle = NativeCSSProvider.gtk_css_provider_new();
        }

        public bool LoadFromData(string data)
        {
            if(handle.IsNullPointer)
                return false;

            GErrorPointer error;
            error.pointer = IntPtr.Zero;
            return NativeCSSProvider.gtk_css_provider_load_from_data(handle, data, data.Length, error);
        }

        public bool LoadFromPath(string filepath)
        {
            if(handle.IsNullPointer)
                return false;            

            GErrorPointer error;
            error.pointer = IntPtr.Zero;
            return NativeCSSProvider.gtk_css_provider_load_from_path(handle, filepath, error);
        }

        public override string ToString()
        {
            if(handle.IsNullPointer)
                return string.Empty;

            IntPtr ptr = NativeCSSProvider.gtk_css_provider_to_string(handle);
            string str = MarshalHelper.MarshalPtrToString(ptr);
            GLibLib.g_free(ptr);
            return str;
        }
    }
}
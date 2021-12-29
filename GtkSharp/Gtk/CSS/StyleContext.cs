using GtkSharp.Gdk.Types;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.CSS;

namespace GtkSharp.Gtk.CSS
{
    public class StyleContext : GObject
    {
        public StyleContext()
        {
            handle = NativeStyleContext.gtk_style_context_new();
        }

        public void AddProviderForScreen(GdkScreen screen, CSSProvider provider, GtkStyleProviderPriority priority)
        {
            if(handle.IsNullPointer)
                return;
            
            if(screen.Handle.IsNullPointer)
                return;

            NativeStyleContext.gtk_style_context_add_provider_for_screen(screen.Handle, provider.Handle, (uint)priority);
        }
    }
}
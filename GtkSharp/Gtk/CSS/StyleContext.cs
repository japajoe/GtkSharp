using GtkSharp.Gdk.Types;
using GtkSharp.Glib.Native.Types;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.CSS;

namespace GtkSharp.Gtk.CSS
{
    public class StyleContext : GObject
    {
        protected GObjectPointer handle;

        public StyleContext()
        {
            handle = NativeStyleContext.gtk_style_context_new();
        }

        public void AddProviderForScreen(GdkScreen screen, CSSProvider provider, GtkStyleProviderPriority priority)
        {
            if(handle.IsNullPointer)
                return;
            
            if(screen.handle.IsNullPointer)
                return;

            NativeStyleContext.gtk_style_context_add_provider_for_screen(screen.handle, provider.handle, (uint)priority);
        }
    }
}
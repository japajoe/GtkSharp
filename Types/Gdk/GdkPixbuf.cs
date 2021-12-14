using GtkSharp.Native.Types;

namespace GtkSharp
{
    public class GdkPixbuf : GObject
    {
        internal GdkPixbufPointer handle;

        internal GdkPixbuf(GdkPixbufPointer handle)
        {
            this.handle = handle;
        }
    }
}
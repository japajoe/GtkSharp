using GtkSharp.Native.Types;

namespace GtkSharp
{
    public class GIcon : GObject
    {
        internal GIconPointer handle;

        public GIcon()
        {
            handle = new GIconPointer();
        }
    }
}
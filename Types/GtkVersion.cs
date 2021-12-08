using GtkSharp.Native;

namespace GtkSharp
{
    public struct GtkVersion
    {
        public uint major;
        public uint minor;
        public uint micro;

        public static bool IsSupportedFeature(uint major, uint minor, uint micro)
        {
            if(GtkSharpBase.Version.major >= major)
            {
                if(GtkSharpBase.Version.minor >= minor)
                {
                    if(GtkSharpBase.Version.micro >= micro)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static GtkVersion Get()
        {
            uint major;
            uint minor;
            uint micro;
            Gtk.GtkSharpGetVersion(out major, out minor, out micro);
            GtkVersion version = new GtkVersion();
            version.major = major;
            version.minor = minor;
            version.micro = micro;
            return version;
        }
    }
}
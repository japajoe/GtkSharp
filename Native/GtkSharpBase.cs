namespace GtkSharp.Native
{
    public static class GtkSharpBase
    {
        public const string NATIVELIBNAME = "gtksharp";

        private static GtkVersion version;

        public static GtkVersion Version
        {
            get { return version; }
        }

        static GtkSharpBase()
        {
            version = GtkVersion.Get();
        }
    }
}
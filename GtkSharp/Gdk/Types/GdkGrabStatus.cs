namespace GtkSharp.Gdk.Types
{
    public enum GdkGrabStatus : int
    {
        Success         = 0,
        AlreadyGrabbed = 1,
        InvalidTime    = 2,
        NotViewable    = 3,
        Frozen          = 4,
        Failed          = 5
    }
}
namespace GtkSharp.GLib.Types
{
    public enum GPriority : int
    {

        //G_PRIORITY_HIGH:
        //Use this for high priority event sources
        //It is not used within GLib or GTK+
        High = -100,

        //G_PRIORITY_DEFAULT:
        //Use this for default priority event sources
        //In GLib this priority is used when adding timeout functions 
        //with g_timeout_add(). In GDK this priority is used for events 
        //from the X server
        Default = 0,

        //G_PRIORITY_HIGH_IDLE:
        //Use this for high priority idle functions.
        //GTK+ uses #G_PRIORITY_HIGH_IDLE + 10 for resizing operations,
        //and #G_PRIORITY_HIGH_IDLE + 20 for redrawing operations. (This is
        //done to ensure that any pending resizes are processed before any
        //pending redraws, so that widgets are not redrawn twice unnecessarily)
        Idle = 100,

        //G_PRIORITY_DEFAULT_IDLE:
        //Use this for default priority idle functions
        //In GLib this priority is used when adding idle functions with g_idle_add()
        DefaultIdle = 200,

        //G_PRIORITY_LOW:
        //Use this for very low priority background tasks
        //It is not used within GLib or GTK+.
        Low = 300
    }
}
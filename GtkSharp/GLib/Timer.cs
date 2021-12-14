using System;
using GtkSharp.Glib.Native.Types;
using GtkSharp.GLib.Native;
using GtkSharp.GLib.Types;
using GtkSharp.Utilities;

namespace GtkSharp.GLib
{
    public class Timer
    {
        private const bool G_SOURCE_CONTINUE = true;
        private const bool G_SOURCE_REMOVE = false;
        private uint interval;
        private GPriority priority;
        private GSourceFuncCallback sourceFuncCallback;
        private GDestroyNotifyCallback destroyNotifyCallback;
        private event GSourceFuncEvent onTickEvent;

        public GSourceFuncEvent onTick
        {
            get
            {
                return onTickEvent;
            }
            set
            {
                onTickEvent = value;
                if(sourceFuncCallback.IsNullPointer())
                {
                    sourceFuncCallback = OnTick;
                    destroyNotifyCallback = OnDestroy;
                    GLibLib.g_timeout_add_full((int)priority, interval, sourceFuncCallback.ToIntPtr(), IntPtr.Zero, destroyNotifyCallback.ToIntPtr());
                }
            }
        }

        public Timer(uint interval)
        {
            this.interval = interval;
            this.priority = GPriority.Default;
        }

        public Timer(uint interval, GPriority priority)
        {
            this.interval = interval;
            this.priority = priority;
        }        

        private bool OnTick(IntPtr data)
        {
            if(onTick != null)
            {
                return onTick();
            }
            return G_SOURCE_CONTINUE;
        }

        private void OnDestroy(IntPtr data)
        {
            
        }
    }
}
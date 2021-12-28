
using System;
using GtkSharp.GLib.Native;
using GtkSharp.Utilities;

namespace GtkSharp.GLib.Types
{
    public class GEventHandler<C,E> where C : Delegate where E : Delegate
    {
        private C callbackHandler;        
        private E eventHandler;

        public C Callback
        {
            get
            {
                return callbackHandler;
            }
            set
            {
                callbackHandler = value;
            }
        }        
        
        public E Event
        {
            get
            {
                return eventHandler;
            }
            set
            {
                eventHandler = value;
            }
        }

        public void SignalConnect(IntPtr objectHandle, string signalName, C callback, IntPtr data)
        {
            if(objectHandle != IntPtr.Zero)
            {
                if(callbackHandler.IsNullPointer())
                {
                    callbackHandler = callback;
                    GLibLib.g_signal_connect(objectHandle, signalName, callbackHandler.ToIntPtr(), data);
                }
            }
        }

        public void SignalConnectAfter(IntPtr objectHandle, string signalName, C callback, IntPtr data)
        {
            if(objectHandle != IntPtr.Zero)
            {
                if(callbackHandler.IsNullPointer())
                {
                    callbackHandler = callback;
                    GLibLib.g_signal_connect_after(objectHandle, signalName, callbackHandler.ToIntPtr(), data);
                }
            }
        }

        public void SignalConnectSwapped(IntPtr objectHandle, string signalName, C callback, IntPtr data)
        {
            if(objectHandle != IntPtr.Zero)
            {
                if(callbackHandler.IsNullPointer())
                {
                    callbackHandler = callback;
                    GLibLib.g_signal_connect_swapped(objectHandle, signalName, callbackHandler.ToIntPtr(), data);
                }
            }
        }
    }
}

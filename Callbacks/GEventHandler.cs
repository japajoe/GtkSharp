
using System;
using GtkSharp.Callbacks;
using GtkSharp.Native;
using GtkSharp.Native.Callbacks;

namespace GtkSharp
{
    public class GEventHandler<T,U> where T : Delegate where U : Delegate
    {
        private T callbackHandler;        
        private U eventHandler;

        public T Callback
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
        
        public U Event
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

        public void SignalConnect(IntPtr objectHandle, string signalName, T callback, IntPtr data)
        {
            if(objectHandle != IntPtr.Zero)
            {
                if(callbackHandler.IsNullPointer())
                {
                    callbackHandler = callback;
                    GLib.g_signal_connect(objectHandle, signalName, callbackHandler.ToIntPtr(), data);
                }
            }
        }

        public void SignalConnectAfter(IntPtr objectHandle, string signalName, T callback, IntPtr data)
        {
            if(objectHandle != IntPtr.Zero)
            {
                if(callbackHandler.IsNullPointer())
                {
                    callbackHandler = callback;
                    GLib.g_signal_connect_after(objectHandle, signalName, callbackHandler.ToIntPtr(), data);
                }
            }
        }        
    }
}
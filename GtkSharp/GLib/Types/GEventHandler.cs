
using System;
using GtkSharp.GLib.Native;
using GtkSharp.Utilities;

namespace GtkSharp.GLib.Types
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
                    GLibLib.g_signal_connect(objectHandle, signalName, callbackHandler.ToIntPtr(), data);
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
                    GLibLib.g_signal_connect_after(objectHandle, signalName, callbackHandler.ToIntPtr(), data);
                }
            }
        }        
    }
}
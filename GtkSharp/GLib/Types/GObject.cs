using System;
using System.Collections.Concurrent;
using System.Threading;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.GLib.Types
{
    public delegate void MethodInvoker();

    public class GObject
    {
        protected GObjectPointer handle;
        protected int threadId;

        public GObjectPointer Handle
        {
            get
            {
                return handle;
            }
            set
            {
                handle = value;
            }
        }

        public bool InvokeRequired
        {
            get
            {
                return threadId != System.Threading.Thread.CurrentThread.ManagedThreadId;
            }
        }

        public GObject()
        {
            threadId = System.Threading.Thread.CurrentThread.ManagedThreadId;
        }

        public GObject(IntPtr handle)
        {
            this.handle.pointer = handle;
            threadId = System.Threading.Thread.CurrentThread.ManagedThreadId;
        }

        public void Unreference()
        {
            if(handle.IsNullPointer)
                return;

            GLib.Native.GLibLib.g_object_unref(handle.pointer);
            handle.pointer = IntPtr.Zero;
        }

        public void Invoke(MethodInvoker method)
        {
            method();
        }
    }    
}
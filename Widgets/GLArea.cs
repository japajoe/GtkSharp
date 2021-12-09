using System;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class GLArea : Widget
    {
        public event GLAreaCreateContextEvent onCreateContext;
        public event GLAreaResizeEvent onResize;
        public event GLAreaRenderEvent onRender;
        public event GLAreaRealizeEvent onRealize;
        public event GLAreaUnRealizeEvent onUnRealize;

        private GtkGLAreaCreateContextCallback onGLAreaCreateContext;
        private GtkGLAreaResizeCallback onGLAreaResize;
        private GtkGLAreaRealizeCallback onGLAreaRealize;
        private GtkGLAreaUnRealizeCallback onGLAreaUnRealize;
        private GtkGLAreaRenderCallback onGLAreaRender;
        private GdkGLContextPointer context;

        public bool AutoRender
        {
            get
            {
                return GetAutoRender();
            }
            set
            {
                SetAutoRender(value);
            }
        }

        public GLArea()
        {
            NativeGLArea.GtkSharpGLAreaCreate(out handle);
            RegisterCallbacks();
        }

        protected override void RegisterCallbacks()
        {
            onGLAreaCreateContext = OnCreateContext;
            onGLAreaResize = OnResize;
            onGLAreaRealize = OnRealize;
            onGLAreaUnRealize = OnUnRealize;
            onGLAreaRender = OnRender;

            Gtk.GtkSharpSignalConnect(out handle.pointer, "create-context", onGLAreaCreateContext.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "resize", onGLAreaResize.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "realize", onGLAreaRealize.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "unrealize", onGLAreaUnRealize.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "render", onGLAreaRender.ToIntPtr(), out handle.pointer);
        }

        public void QueueRender()
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.GtkSharpGLAreaQueueRender(out handle);
        }

        public void MakeCurrent()
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.GtkSharpGLAreaMakeCurrent(out handle);
        }

        public bool GetContext()
        {
            if(handle.IsNullPointer)
                return false;

            NativeGLArea.GtkSharpGLAreaGetContext(out handle, out context);
            return true;
        }

        
        public void SetRequiredVersion(int major, int minor)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeGLArea.GtkSharpGLAreaSetRequiredVersion(out handle, major, minor);
        }

        
        public bool GetRequiredVersion(out int major, out int minor)
        {
            if(handle.IsNullPointer)
            {
                major = 0;
                minor = 0;
                return false;
            }

            NativeGLArea.GtkSharpGLAreaGetRequiredVersion(out handle, out major, out minor);
            return true;
        }
        
        public bool GetHasAlpha()
        {
            if(handle.IsNullPointer)
                return false;

            bool hasAlpha;
            NativeGLArea.GtkSharpGLAreaGetHasAlpha(out handle, out hasAlpha);
            return hasAlpha;
        }
        
        public void SetHasAlpha(bool hasAlpha)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.GtkSharpGLAreaSetHasAlpha(out handle, hasAlpha);
        }
        
        public bool GetHasDepthBuffer()
        {
            if(handle.IsNullPointer)
                return false;

            bool hasDepthBuffer;
            NativeGLArea.GtkSharpGLAreaGetHasDepthBuffer(out handle, out hasDepthBuffer);
            return hasDepthBuffer;                
        }
        
        public void SetHasDepthBuffer(bool hasDepthBuffer)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.GtkSharpGLAreaSetHasDepthBuffer(out handle, hasDepthBuffer);
        }
        
        public bool GetHasStencilBuffer()
        {
            if(handle.IsNullPointer)
                return false;

            bool hasStencilBuffer;
            NativeGLArea.GtkSharpGLAreaGetHasStencilBuffer(out handle, out hasStencilBuffer);
            return hasStencilBuffer;
        }
        
        public void SetHasStencilBuffer(bool hasStencilBuffer)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.GtkSharpGLAreaSetHasStencilBuffer(out handle, hasStencilBuffer);
        }

        public bool GetAutoRender()
        {
            if(handle.IsNullPointer)
                return false;

            bool auto;
            NativeGLArea.GtkSharpGLAreaGetAutoRender(out handle, out auto);
            return auto;
        }

        public void SetAutoRender(bool auto)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.GtkSharpGLAreaSetAutoRender(out handle, auto);
        }

        void OnCreateContext(IntPtr area, IntPtr data)
        {
            NativeGLArea.GtkSharpGLAreaGetContext(out handle, out context);
            onCreateContext?.Invoke();
        }

        void OnResize(IntPtr area, int width, int height, IntPtr data)
        {
            onResize?.Invoke(width, height);
        }        

        private void OnRealize(IntPtr area)
        {
            onRealize?.Invoke();
        }

        private void OnUnRealize(IntPtr area)
        {
            onUnRealize?.Invoke();
        }

        private bool OnRender(IntPtr area, IntPtr context)
        {
            onRender?.Invoke();
            return true;
        }
    }
}
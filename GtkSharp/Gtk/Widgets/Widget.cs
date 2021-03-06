using System;
using System.Runtime.InteropServices;
using GtkSharp.Gtk.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gdk.Types;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.GLib.Types;
using GtkSharp.Cairo.Types;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class Widget : GObject
    {
        private CairoInstance cairo = new CairoInstance();

        private GEventHandler<WidgetDestroyCallback,WidgetDestroyEvent> destroyHandler = new GEventHandler<WidgetDestroyCallback, WidgetDestroyEvent>();
        private GEventHandler<WidgetDestroyedCallback,WidgetDestroyedEvent> destroyedHandler = new GEventHandler<WidgetDestroyedCallback, WidgetDestroyedEvent>();
        private GEventHandler<WidgetSizeAllocateCallback,WidgetSizeAllocateEvent> sizeAllocateHandler = new GEventHandler<WidgetSizeAllocateCallback, WidgetSizeAllocateEvent>();
        private GEventHandler<WidgetKeyPressCallback,WidgetKeyPressEvent> keyPressHandler = new GEventHandler<WidgetKeyPressCallback, WidgetKeyPressEvent>();
        private GEventHandler<WidgetKeyReleaseCallback,WidgetKeyReleaseEvent> keyReleaseHandler = new GEventHandler<WidgetKeyReleaseCallback, WidgetKeyReleaseEvent>();
        private GEventHandler<WidgetButtonPressCallback,WidgetButtonPressEvent> buttonPressHandler = new GEventHandler<WidgetButtonPressCallback, WidgetButtonPressEvent>();
        private GEventHandler<WidgetButtonReleaseCallback,WidgetButtonReleaseEvent> buttonReleaseHandler = new GEventHandler<WidgetButtonReleaseCallback, WidgetButtonReleaseEvent>();
        private GEventHandler<WidgetMotionNotifyCallback,WidgetMotionNotifyEvent> motionNotifyHandler = new GEventHandler<WidgetMotionNotifyCallback, WidgetMotionNotifyEvent>();
        private GEventHandler<WidgetScrollCallback,WidgetScrollEvent> scrollHandler = new GEventHandler<WidgetScrollCallback, WidgetScrollEvent>();
        private GEventHandler<WidgetDrawCallback,WidgetDrawEvent> drawHandler = new GEventHandler<WidgetDrawCallback, WidgetDrawEvent>();
        private GEventHandler<WidgetRealizeCallback,WidgetRealizeEvent> realizeHandler = new GEventHandler<WidgetRealizeCallback, WidgetRealizeEvent>();
        private GEventHandler<WidgetUnrealizeCallback,WidgetUnrealizeEvent> unrealizeHandler = new GEventHandler<WidgetUnrealizeCallback, WidgetUnrealizeEvent>();
        private GEventHandler<WindowStateEventCallback,WindowStateEventEvent> windowStateEventHandler = new GEventHandler<WindowStateEventCallback, WindowStateEventEvent>();

        public GtkAlign VerticalAlignment
        {
            get
            {
                return GetVerticalAlignment();
            }
            set
            {
                SetVerticalAlignment(value);
            }
        }

        public GtkAlign HorizontalAlignment
        {
            get
            {
                return GetHorizontalAlignment();
            }
            set
            {
                SetHorizontalAlignment(value);
            }
        }

        public bool HorizontalExpand
        {
            get
            {
                return GetHorizontalExpand();
            }
            set
            {
                SetHorizontalExpand(value);
            }
        }

        public bool VerticalExpand
        {
            get
            {
                return GetVerticalExpand();
            }
            set
            {
                SetVerticalExpand(value);
            }
        }

        public WidgetDestroyEvent DestroyWidget
        {
            get
            {
                return destroyHandler.Event;
            }
            set
            {
                destroyHandler.Event = value;                
                destroyHandler.SignalConnect(handle.pointer, "destroy", OnDestroy, handle.pointer);
            }
        }

        public WidgetDestroyedEvent Destroyed
        {
            get
            {
                return destroyedHandler.Event;
            }
            set
            {
                destroyedHandler.Event = value;
                destroyedHandler.SignalConnect(handle.pointer, "destroy-event", OnDestroyed, handle.pointer);
            }
        }

        public WidgetSizeAllocateEvent SizeAllocate
        {
            get
            {
                return sizeAllocateHandler.Event;
            }
            set
            {
                sizeAllocateHandler.Event = value;
                sizeAllocateHandler.SignalConnect(handle.pointer, "size-allocate", OnSizeAllocate, handle.pointer);
            }
        }        

        public WidgetKeyPressEvent KeyPress
        {
            get
            {
                return keyPressHandler.Event;
            }
            set
            {
                keyPressHandler.Event = value;
                keyPressHandler.SignalConnect(handle.pointer, "key-press-event", OnKeyPress, handle.pointer);
            }
        }

        public WidgetKeyReleaseEvent KeyRelease
        {
            get
            {
                return keyReleaseHandler.Event;
            }
            set
            {
                keyReleaseHandler.Event = value;
                keyReleaseHandler.SignalConnect(handle.pointer, "key-release-event", OnKeyRelease, handle.pointer);
            }
        }    

        public WidgetButtonPressEvent ButtonPress
        {
            get
            {
                return buttonPressHandler.Event;
            }
            set
            {
                buttonPressHandler.Event = value;
                buttonPressHandler.SignalConnect(handle.pointer, "button-press-event", OnButtonPress, handle.pointer);
            }
        }

        public WidgetButtonReleaseEvent ButtonRelease
        {
            get
            {
                return buttonReleaseHandler.Event;
            }
            set
            {
                buttonReleaseHandler.Event = value;
                buttonReleaseHandler.SignalConnect(handle.pointer, "button-release-event", OnButtonRelease, handle.pointer);
            }
        }

        public WidgetMotionNotifyEvent MotionNotify
        {
            get
            {
                return motionNotifyHandler.Event;
            }
            set
            {
                motionNotifyHandler.Event = value;
                motionNotifyHandler.SignalConnect(handle.pointer, "motion-notify-event", OnMotionNotify, handle.pointer);
            }
        }

        public WidgetScrollEvent Scroll
        {
            get
            {
                return scrollHandler.Event;
            }
            set
            {
                scrollHandler.Event = value;
                scrollHandler.SignalConnect(handle.pointer, "scroll-event", OnScroll, handle.pointer);
            }
        }

        public WidgetDrawEvent Draw
        {
            get
            {
                return drawHandler.Event;
            }
            set
            {
                drawHandler.Event = value;
                drawHandler.SignalConnect(handle.pointer, "draw", OnDraw, handle.pointer);
            }
        }

        public WidgetRealizeEvent Realize
        {
            get
            {
                return realizeHandler.Event;
            }
            set
            {
                realizeHandler.Event = value;
                realizeHandler.SignalConnect(handle.pointer, "realize", OnRealize, handle.pointer);
            }
        }

        public WidgetUnrealizeEvent Unrealize
        {
            get
            {
                return unrealizeHandler.Event;
            }
            set
            {
                unrealizeHandler.Event = value;
                unrealizeHandler.SignalConnect(handle.pointer, "unrealize", OnUnrealize, handle.pointer);
            }
        }

        public WindowStateEventEvent WindowStateEvent
        {
            get
            {
                return windowStateEventHandler.Event;
            }
            set
            {
                windowStateEventHandler.Event = value;
                windowStateEventHandler.SignalConnect(handle.pointer, "window-state-event", OnWindowStateEvent, handle.pointer);
            }
        }

        public Widget() : base()
        {
            
        }

        public Widget(IntPtr handle) : base(handle)
        {
            
        }

        public void Show()
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.gtk_widget_show(handle);
        }

        public void ShowAll()
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.gtk_widget_show_all(handle);
        }

        public bool GetSizeRequest(out int width, out int height)
        {
            if(handle.IsNullPointer)
            {
                width = height = 0;
                return false;
            }

            GtkRequisition r;
            NativeWidget.gtk_widget_size_request(handle, out r);
            width = r.width;
            height = r.height;
            return true;
        }

        public void SetSizeRequest(int width, int height)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeWidget.gtk_widget_set_size_request(handle, width, height);
        }

        public void SetMargins(int top, int left, int bottom, int right)
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.gtk_widget_set_margin_bottom(handle, bottom);
            NativeWidget.gtk_widget_set_margin_top(handle, bottom);
            NativeWidget.gtk_widget_set_margin_left(handle, bottom);
            NativeWidget.gtk_widget_set_margin_right(handle, bottom);
        }

        private GtkAlign GetVerticalAlignment()
        {
            if(handle.IsNullPointer)
                return GtkAlign.Start;
            
            return NativeWidget.gtk_widget_get_valign(handle);
        }

        private void SetVerticalAlignment(GtkAlign alignment)
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.gtk_widget_set_valign(handle, alignment);
        }

        private GtkAlign GetHorizontalAlignment()
        {
            if(handle.IsNullPointer)
                return GtkAlign.Start;
            
            return NativeWidget.gtk_widget_get_halign(handle);
        }

        private void SetHorizontalAlignment(GtkAlign alignment)
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.gtk_widget_set_halign(handle, alignment);
        }

        public bool GetHorizontalExpand()
        {
            if(handle.IsNullPointer)
                return false;
            return NativeWidget.gtk_widget_get_hexpand(handle);
        }

        public void SetHorizontalExpand(bool expand)
        {
            if(handle.IsNullPointer)
                return;
            NativeWidget.gtk_widget_set_hexpand(handle, expand);
        }

        public bool GetVerticalExpand()
        {
            if(handle.IsNullPointer)
                return false;
            return NativeWidget.gtk_widget_get_vexpand(handle);
        }

        public void SetVerticalExpand(bool expand)
        {
            if(handle.IsNullPointer)
                return;
            NativeWidget.gtk_widget_get_vexpand(handle);
        }        

        public void AddEvents(GdkEventMask events)
        {
            if(handle.IsNullPointer)
                return;

            int e = (int)events;
            NativeWidget.gtk_widget_add_events(handle, e);
        }

        public void QueueDraw()
        {
            if(handle.IsNullPointer)
                return;
            
            NativeWidget.gtk_widget_queue_draw(handle);
        }

        public void QueueDrawArea(int x, int y, int width, int height)
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.gtk_widget_queue_draw_area(handle, x, y, width, height);
        }

        public bool TranslateCoordinates(Widget relativeWidget, int srcX, int srcY, out int destX, out int destY)
        {
            if(handle.IsNullPointer)
            {
                destX = 0;
                destY = 0;
                return false;
            }

            return NativeWidget.gtk_widget_translate_coordinates(handle, relativeWidget.handle, srcX, srcY, out destX, out destY);
        }

        public void SetToolTip(string text)
        {
            if(handle.IsNullPointer)
                return;
            NativeWidget.gtk_widget_set_tooltip_text(handle, text);
        }

        public Widget GetTopLevel()
        {
            if(handle.IsNullPointer)
                return null;

            var w = NativeWidget.gtk_widget_get_toplevel(handle);
            
            if(NativeWidget.gtk_widget_is_toplevel(w))
            {
                return new Widget(w.pointer);
            }
            return null;
        }

        public GdkWindow GetWindow()
        {
            if(handle.IsNullPointer)
                return null;

            GObjectPointer window = NativeWidget.gtk_widget_get_window(handle);
            return new GdkWindow(window.pointer);
        }

        public void Destroy()
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.gtk_widget_destroy(handle);
            handle.pointer = IntPtr.Zero;
        }

        bool OnKeyPress(IntPtr widget, GdkEventKeyPointer eventKey, IntPtr userData)
        {
            if(KeyPress != null)
            {
                GdkEventKey key = Marshal.PtrToStructure<GdkEventKey>(eventKey.pointer);
                return KeyPress(key);
            }
            return true;
        }

        bool OnKeyRelease(IntPtr widget, GdkEventKeyPointer eventKey, IntPtr userData)
        {
            if(KeyRelease != null)
            {
                GdkEventKey key = Marshal.PtrToStructure<GdkEventKey>(eventKey.pointer);
                return KeyRelease(key);
            }
            return true;
        }

        bool OnButtonPress(IntPtr widget, GdkEventButtonPointer eventButton, IntPtr userData)
        {
            if(ButtonPress != null)
            {
                GdkEventButton button = Marshal.PtrToStructure<GdkEventButton>(eventButton.pointer);
                return ButtonPress(button);
            }
            return true;
        }

        bool OnButtonRelease(IntPtr widget, GdkEventButtonPointer eventButton, IntPtr userData)
        {
            if(ButtonRelease != null)
            {
                GdkEventButton button = Marshal.PtrToStructure<GdkEventButton>(eventButton.pointer);
                return ButtonRelease(button);
            }
            return true;
        }

        bool OnMotionNotify(IntPtr widget, GdkEventMotionPointer eventMotion, IntPtr userData)
        {
            if(MotionNotify != null)
            {
                GdkEventMotion motion = Marshal.PtrToStructure<GdkEventMotion>(eventMotion.pointer);
                return MotionNotify(motion);
            }
            return true;
        }

        bool OnScroll(IntPtr widget, GdkEventScrollPointer eventScroll, IntPtr data)
        {
            if(Scroll != null)
            {
                GdkEventScroll scroll = Marshal.PtrToStructure<GdkEventScroll>(eventScroll.pointer);
                return Scroll(scroll);
            }
            return true;
        }

        void OnDestroy(IntPtr widget, IntPtr userData)
        {
            DestroyWidget?.Invoke();
        }

        bool OnDestroyed(IntPtr widget, GdkEventPointer evnt, IntPtr userData)
        {
            if(Destroyed != null)
                return Destroyed();
            return false;
        }

        void OnSizeAllocate(IntPtr widget, GtkAllocationPointer allocation)
        {
            if(SizeAllocate != null)
            {
                GtkAllocation a = Marshal.PtrToStructure<GtkAllocation>(allocation.pointer);
                SizeAllocate(a);
            }
        }

        bool OnDraw(IntPtr widget, IntPtr cr, IntPtr data)
        {
            cairo.cr.pointer = cr;
            
            if(Draw != null)
            {
                return Draw(cairo);
            }
            return false;
        }

        void OnRealize(IntPtr widget, IntPtr data)
        {
            Realize?.Invoke();
        }

        void OnUnrealize(IntPtr widget, IntPtr data)
        {
            Unrealize?.Invoke();
        }

        bool OnWindowStateEvent(IntPtr widget, GdkEventWindowStatePointer evnt, IntPtr data)
        {
            if(WindowStateEvent != null)
            {
                GdkEventWindowState e = Marshal.PtrToStructure<GdkEventWindowState>(evnt.pointer);
                return WindowStateEvent(e);
            }
            return false;
        }
    }
}
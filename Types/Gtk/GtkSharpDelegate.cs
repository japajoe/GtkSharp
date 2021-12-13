using System;
using System.Runtime.InteropServices;

namespace GtkSharp
{
    public static class GtkSharpDelegate
    {
        public static T Create<T>(object target, string functionName) where T : Delegate
        {
            return (T)Delegate.CreateDelegate(typeof(T), target, functionName, false);
        }

        public static IntPtr ToIntPtr(this Delegate del)
        {
            return Marshal.GetFunctionPointerForDelegate(del);
        }

        public static bool IsNullPointer(this Delegate del)
        {
            if(del == null)
                return true;

            return del.GetInvocationList() == null;
        }
    }
}
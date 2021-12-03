using System;

namespace GtkSharp
{
    public static class GtkSharpDelegate
    {
        public static T Create<T>(object target, string functionName) where T : Delegate
        {
            return (T)Delegate.CreateDelegate(typeof(T), target, functionName, false);
        }
    }
}
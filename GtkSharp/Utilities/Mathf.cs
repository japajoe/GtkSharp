using System;

namespace GtkSharp.Utilities
{
    public static class Mathf
    {
        public const float Rad2Deg = (float)(180.0 / Math.PI);
        public const float Deg2Rad = (float)(Math.PI / 180.0);
        public const float PI = (float)Math.PI;
        public const float PiOver2 = PI / 2.0f;
        public const float Infinity = float.PositiveInfinity;
        public const float NegativeInfinity = float.NegativeInfinity;

        public static float Atan2(float x, float y)
        {
            return (float)System.Math.Atan2(x, y);
        }

        public static float Asin(float x)
        {
            return (float)System.Math.Asin(x);
        }

        public static float Abs(float f)
        {
            if(f < 0.0f)
                return f *= -1.0f;
            return f;
        }

        public static float Ceil(float x)
        {
            return (float)System.Math.Ceiling(x);
        }

        public static float Clamp(float value, float min, float max)
        {
            if (value > max)
                value = max;
            if (value < min)
                value = min;
            return value;
        }

        public static int Clamp(int value, int min, int max)
        {
            if (value > max)
                value = max;
            if (value < min)
                value = min;
            return value;
        }

        /// <summary>
        ///   <para>Clamps value between 0 and 1 and returns value.</para>
        /// </summary>
        /// <param name="value"></param>
        public static float Clamp01(float value)
        {
            if ((double)value < 0.0)
                return 0.0f;
            if ((double)value > 1.0)
                return 1f;
            return value;
        }

        public static float Floor(float x)
        {
            return (float)System.Math.Floor(x);
        }

        public static float Lerp(float a, float b, float t)
        {
            t = Clamp(t, 0.0f, 1.0f);
            return a + ((b-a) * t);
        }

        /// <summary>
        ///   <para>Same as Lerp but makes sure the values interpolate correctly when they wrap around 360 degrees.</para>
        /// </summary>
        public static float LerpAngle(float a, float b, float t)
        {
            float num = Mathf.Repeat(b - a, 360f);
            if ((double)num > 180.0)
                num -= 360f;
            return a + num * Mathf.Clamp01(t);
        }

        public static float InverseLerp(float a, float b, float value)
        {
            return (value - a) / (b - a);
        }

        public static float Min(float a, float b)
        {
            if(a > b)
                return b;
            return a;
        }

        public static float Max(float a, float b)
        {
            if(a > b)
                return a;
            return b;
        }

        /// <summary>
        ///   <para>Loops the value t, so that it is never larger than length and never smaller than 0.</para>
        /// </summary>
        public static float Repeat(float t, float length)
        {
            return t - Mathf.Floor(t / length) * length;
        }

        public static float Sign(float f)
        {
            return (double)f >= 0.0 ? 1f : -1f;
        }

        public static float Sin(float x)
        {
            return (float)Math.Sin(x);
        }

        public static float Cos(float x)
        {
            return (float)Math.Cos(x);
        }

        public static float Acos(float x)
        {
            return (float)Math.Acos(x);
        }

        public static float Sqrt(float x)
        {
            return (float)Math.Sqrt(x);
        }

        public static float Pow(float x, float y)
        {
            return (float)Math.Pow(x, y);
        }
    }
}
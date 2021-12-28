using System;

namespace GtkSharp.Utilities
{
    public static class Random
    {
        private static double lehmer = 0.0;

        static Random()
        {
            System.Random random = new System.Random();
            UInt32 x = (UInt32)(random.NextDouble() * UInt32.MaxValue);
            UInt32 y = (UInt32)(random.NextDouble() * UInt32.MaxValue);
            SetSeed(x, y);
        }

        public static void SetSeed(UInt32 seedX, UInt32 seedY)
        {
            if (seedX > 0 || seedY > 0)
                lehmer = (seedX & 0xFFFF) << 16 | (seedY & 0xFFFF);
        }

        /// <summary>
        /// Return a random float number between min [inclusive] and max [inclusive] (Read Only).
        /// </summary>
        /// <returns>The range.</returns>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Max.</param>
        public static float Range(float min, float max)
        {
            float x = (float)(GetRandomDouble() * (max - min));
            return min + x;
        }

        /// <summary>
        /// Returns a random integer number between min [inclusive] and max [exclusive]
        /// </summary>
        /// <returns>The range.</returns>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Max.</param>
        public static int Range(int min, int max)
        {
            int x = (int)(GetRandomDouble() * (max - min));
            return min + x;
        }

        /// <summary>
        /// Return a random float number between 0 and 1
        /// </summary>
        /// <returns>The random double.</returns>
        public static double GetRandomDouble()
        {
            lehmer += 0xe120fc15;
            UInt64 tmp;
            tmp = (UInt64)lehmer * 0x4a39b70d;
            UInt32 m1 = (UInt32)((tmp >> 32) ^ tmp);
            tmp = (UInt64)m1 * 0x12fad5c9;
            UInt32 m2 = (UInt32)((tmp >> 32) ^ tmp);
            return (1.0 / UInt32.MaxValue) * m2;
        }
    }
}
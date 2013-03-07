using System;
using System.Collections.Generic;
using System.Text;

namespace S7.Types
{
    public static class Boolean
    {
        /// <summary>
        /// Returns the current value of the byte at a specific bit location
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="bit">The bit.</param>
        /// <returns></returns>
        public static bool GetBit(this byte value, int bit)
        {
            return (value & (int)Math.Pow(2, bit)) != 0;
        }

        /// <summary>
        /// Sets the value of a specific bit in the target byte
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="bit">The bit.</param>
        /// <returns></returns>
        public static byte SetBit(this byte value, int bit)
        {
            return (byte)(value | (byte)Math.Pow(2, bit));
        }

        /// <summary>
        /// Resets the value of a specific bit in the target byte
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="bit">The bit.</param>
        /// <returns></returns>
        public static byte ClearBit(this byte value, int bit)
        {
            return (byte)(value & (byte)(~(byte)Math.Pow(2, bit)));
        }

    }
}

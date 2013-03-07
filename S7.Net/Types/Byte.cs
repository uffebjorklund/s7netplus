namespace S7.Types
{
    public static class Byte
    {
        /// <summary>
        /// Converts the current byte to a byte array.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static byte[] ToByteArray(this byte value)
        {
            byte[] bytes = new byte[] { value};
            return bytes;
        }
    }
}

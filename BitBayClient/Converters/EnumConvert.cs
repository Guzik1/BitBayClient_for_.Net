using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.Converters
{
    /// <summary>
    /// Enum converter, add extension method to enum type.
    /// </summary>
    public static class EnumConverter
    {
        /// <summary>
        /// Parse string to enum.
        /// </summary>
        /// <param name="name">String name.</param>
        /// <returns>Enum value.</returns>
        public static EnumType Parse<EnumType>(string name)
        {
            return (EnumType)Enum.Parse(typeof(EnumType), name);
        }

        /// <summary>
        /// Try convert string to enum value.
        /// </summary>
        /// <param name="name">String name to convert.</param>
        /// <param name="message">Enum value.</param>
        /// <returns>True if try was successful or false for else.</returns>
        public static bool TryParse<EnumType>(string name, ref EnumType message)
        {
            try
            {
                message = (EnumType)Enum.Parse(typeof(EnumType), name);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

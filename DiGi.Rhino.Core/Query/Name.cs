using System;

namespace DiGi.Rhino.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the name of the specified type, removing the 'I' prefix if it is an interface 
        /// following standard naming conventions (where the second character is uppercase).
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to retrieve the name from.</param>
        /// <returns>The processed name of the type, or <see langword="null"/> if the provided type is null.</returns>
        public static string? Name(this Type? type)
        {
            string? result = type?.Name;
            if (string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            if (!result.StartsWith('I') || result.Length <= 2)
            {
                return result;
            }

            if (char.IsUpper(result[1]))
            {
                return result[1..];
            }

            return result;
        }
    }
}
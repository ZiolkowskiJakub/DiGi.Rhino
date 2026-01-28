using System;

namespace DiGi.Rhino.Core
{
    public static partial class Query
    {
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
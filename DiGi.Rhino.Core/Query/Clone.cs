using System;

namespace DiGi.Rhino.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts the subcategory name from the assembly of the provided type.
        /// If the assembly name is missing, it defaults to "DiGi".
        /// If the assembly name contains more than two segments separated by dots, only the first two are returned.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> for which the subcategory is being determined.</param>
        /// <returns>A string representing the subcategory of the type's assembly.</returns>
        public static string Subcategory(this Type type)
        {
            string? name = type?.Assembly?.GetName()?.Name;
            if (string.IsNullOrWhiteSpace(name))
            {
                return "DiGi";
            }

            string[] values = name.Split(".", StringSplitOptions.RemoveEmptyEntries);
            if (values.Length <= 2)
            {
                return name;
            }

            return string.Join(".", values[0], values[1]);
        }
    }
}
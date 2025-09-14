using System;

namespace DiGi.Rhino.Core
{
    public static partial class Query
    {
        public static string Subcategory(this Type type)
        {
            string? name = type?.Assembly?.GetName()?.Name;
            if(string.IsNullOrWhiteSpace(name))
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

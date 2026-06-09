using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Core
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the name of the specified type as a <see cref="GH_String"/>.
        /// </summary>
        /// <param name="type">The type to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the full name of the type, or <c>null</c> if the provided type is null.</returns>
        [Inspect("Name", "Name", "Name")]
        public static GH_String? Name(this System.Type? type)
        {
            if (type == null)
            {
                return null;
            }

            return new GH_String(type.FullName);
        }

        /// <summary>
        /// Gets the full type name of the specified type as a <see cref="GH_String"/>.
        /// </summary>
        /// <param name="type">The type to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the formatted full type name, or <c>null</c> if the provided type is null.</returns>
        [Inspect("FullTypeName", "FullTypeName", "FullTypeName")]
        public static GH_String? FullTypeName(this System.Type? type)
        {
            if (type == null)
            {
                return null;
            }

            return new GH_String(DiGi.Core.Query.FullTypeName(type));
        }
    }
}
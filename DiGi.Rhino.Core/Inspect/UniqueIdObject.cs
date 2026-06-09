using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Core
{
    public static partial class Inspect
    {
        /// <summary>
        /// Extracts the unique identifier from an object implementing <see cref="IUniqueIdObject"/> and wraps it in a <see cref="GH_String"/>.
        /// </summary>
        /// <param name="uniqueIdObject">The object that provides the unique identifier.</param>
        /// <returns>A <see cref="GH_String"/> containing the unique ID if the input is not null; otherwise, <c>null</c>.</returns>
        [Inspect("UniqueId", "UniqueId", "Unique Id")]
        public static GH_String? UniqueId(this IUniqueIdObject? uniqueIdObject)
        {
            if (uniqueIdObject == null)
            {
                return null;
            }

            return new GH_String(uniqueIdObject.UniqueId);
        }
    }
}
using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Core
{
    public static partial class Inspect
    {
        /// <summary>
        /// Converts an <see cref="IGuidObject"/> to a Grasshopper <see cref="GH_Guid"/>.
        /// </summary>
        /// <param name="guidObject">The object implementing <see cref="IGuidObject"/> to be converted.</param>
        /// <returns>A <see cref="GH_Guid"/> representation of the object's GUID, or <c>null</c> if the provided <paramref name="guidObject"/> is null.</returns>
        [Inspect("Guid", "Guid", "Guid")]
        public static GH_Guid? Guid(this IGuidObject? guidObject)
        {
            if (guidObject == null)
            {
                return null;
            }

            return new GH_Guid(guidObject.Guid);
        }
    }
}
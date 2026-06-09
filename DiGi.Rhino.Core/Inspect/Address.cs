using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Core
{
    public static partial class Inspect
    {
        /// <summary>
        /// Extracts the street name from the provided address as a Grasshopper string.
        /// </summary>
        /// <param name="address">The address object to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the street, or <c>null</c> if the address is null.</returns>
        [Inspect("Street", "Street", "Street")]
        public static GH_String? Street(this DiGi.Core.Classes.Address? address)
        {
            if (address == null)
            {
                return null;
            }

            return new GH_String(address.Street);
        }

        /// <summary>
        /// Extracts the city name from the provided address as a Grasshopper string.
        /// </summary>
        /// <param name="address">The address object to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the city, or <c>null</c> if the address is null.</returns>
        [Inspect("City", "City", "City")]
        public static GH_String? City(this DiGi.Core.Classes.Address? address)
        {
            if (address == null)
            {
                return null;
            }

            return new GH_String(address.City);
        }

        /// <summary>
        /// Extracts the postal code from the provided address as a Grasshopper string.
        /// </summary>
        /// <param name="address">The address object to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the postal code, or <c>null</c> if the address is null.</returns>
        [Inspect("PostalCode", "PostalCode", "PostalCode")]
        public static GH_String? PostalCode(this DiGi.Core.Classes.Address? address)
        {
            if (address == null)
            {
                return null;
            }

            return new GH_String(address.PostalCode);
        }

        /// <summary>
        /// Extracts the country code from the provided address as a Grasshopper enum.
        /// </summary>
        /// <param name="address">The address object to inspect.</param>
        /// <returns>A <see cref="GooEnum"/> containing the country code, or <c>null</c> if the address is null.</returns>
        [Inspect("CountryCode", "CountryCode", "CountryCode")]
        public static GooEnum? CountryCode(this DiGi.Core.Classes.Address? address)
        {
            if (address == null)
            {
                return null;
            }

            return new GooEnum(address.CountryCode);
        }
    }
}
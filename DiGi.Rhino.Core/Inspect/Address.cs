using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Core
{
    public static partial class Inspect
    {
        [Inspect("Street", "Street", "Street")]
        public static GH_String? Street(this DiGi.Core.Classes.Address? address)
        {
            if (address == null)
            {
                return null;
            }

            return new GH_String(address.Street);
        }

        [Inspect("City", "City", "City")]
        public static GH_String? City(this DiGi.Core.Classes.Address? address)
        {
            if (address == null)
            {
                return null;
            }

            return new GH_String(address.City);
        }

        [Inspect("PostalCode", "PostalCode", "PostalCode")]
        public static GH_String? PostalCode(this DiGi.Core.Classes.Address? address)
        {
            if (address == null)
            {
                return null;
            }

            return new GH_String(address.PostalCode);
        }

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
using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;


namespace DiGi.Rhino.Core
{
    public static partial class Inspect
    {

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

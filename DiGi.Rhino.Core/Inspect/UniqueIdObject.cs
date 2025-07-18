using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;


namespace DiGi.Rhino.Core
{
    public static partial class Inspect
    {

        [Inspect("UniqueId", "UniqueId", "Unique Id")]
        public static GH_String UniqueId(this IUniqueIdObject uniqueIdObject)
        {
            if(uniqueIdObject == null)
            {
                return null;
            }

            return new GH_String(uniqueIdObject.UniqueId);
        }
    }
}

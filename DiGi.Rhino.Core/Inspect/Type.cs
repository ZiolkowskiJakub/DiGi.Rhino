using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Core
{
    public static partial class Inspect
    {

        [Inspect("Name", "Name", "Name")]
        public static GH_String? Name(this System.Type? type)
        {
            if (type == null)
            {
                return null;
            }

            return new GH_String(type.FullName);
        }

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

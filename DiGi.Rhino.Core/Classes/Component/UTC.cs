using System;

namespace DiGi.Rhino.Core.Classes
{
    public class UTC : EnumComponent<DiGi.Core.Enums.UTC>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("45480a11-ad3f-46eb-9fbc-35e13b5d254b");

        /// <summary>
        /// Panel Type
        /// </summary>
        public UTC()
          : base("Core")
        {
        }
    }
}

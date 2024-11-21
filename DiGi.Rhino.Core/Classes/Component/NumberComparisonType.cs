using System;

namespace DiGi.Rhino.Core.Classes
{
    public class NumberComparisonType : EnumComponent<DiGi.Core.Enums.NumberComparisonType>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("acb79b9c-0038-484f-96fd-664692723928");

        /// <summary>
        /// Panel Type
        /// </summary>
        public NumberComparisonType()
          : base("Core")
        {
        }
    }
}

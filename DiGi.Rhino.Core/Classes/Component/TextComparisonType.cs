using System;

namespace DiGi.Rhino.Core.Classes
{
    public class TextComparisonType : EnumComponent<DiGi.Core.Enums.TextComparisonType>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("caee035c-51e1-4560-888b-0da1cb2bf12f");

        /// <summary>
        /// Panel Type
        /// </summary>
        public TextComparisonType()
          : base("Core")
        {
        }
    }
}

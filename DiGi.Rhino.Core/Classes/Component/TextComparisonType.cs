using System;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Represents the text comparison type component, providing functionality to specify how two strings are compared.
    /// </summary>
    public class TextComparisonType : EnumComponent<DiGi.Core.Enums.TextComparisonType>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("caee035c-51e1-4560-888b-0da1cb2bf12f");

        /// <summary>
        /// Initializes a new instance of the <see cref="TextComparisonType"/> class.
        /// </summary>
        public TextComparisonType()
          : base("Core")
        {
        }
    }
}
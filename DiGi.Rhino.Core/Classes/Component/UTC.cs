using System;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Represents a component for handling Coordinated Universal Time (UTC) time zones.
    /// </summary>
    public class UTC : EnumComponent<DiGi.Core.Enums.UTC>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("45480a11-ad3f-46eb-9fbc-35e13b5d254b");

        /// <summary>
        /// Initializes a new instance of the <see cref="UTC"/> class.
        /// </summary>
        public UTC()
          : base("Core")
        {
        }
    }
}
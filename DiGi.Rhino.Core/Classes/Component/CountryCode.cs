using System;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Represents the country code component used for ISO country identification within the system.
    /// </summary>
    public class CountryCode : EnumComponent<DiGi.Core.Enums.CountryCode>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("87e31e1d-dcb1-42bd-bedc-3aa43198202c");

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryCode"/> class.
        /// </summary>
        public CountryCode()
          : base("Core")
        {
        }
    }
}
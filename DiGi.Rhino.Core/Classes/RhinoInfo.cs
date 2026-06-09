using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Provides assembly information for the DiGi.Rhino.Core Grasshopper plugin.
    /// </summary>
    public class RhinoInfo : GH_AssemblyInfo
    {
        /// <summary>
        /// Gets the name of the GHA library.
        /// </summary>
        public override string Name => "DiGi.Rhino.Core";

        /// <summary>
        /// Gets a 24x24 pixel bitmap to represent this GHA library.
        /// </summary>
        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap? Icon => null;

        /// <summary>
        /// Gets a short string describing the purpose of this GHA library.
        /// </summary>
        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        /// <summary>
        /// Gets the unique identifier for this assembly.
        /// </summary>
        public override Guid Id => new("8694c9c9-44d6-4454-8281-c5ce70b43c65");

        /// <summary>
        /// Gets the name of the author or company.
        /// </summary>
        //Return a string identifying you or your company.
        public override string AuthorName => "Jakub Ziolkowski";

        /// <summary>
        /// Gets the preferred contact details for the author.
        /// </summary>
        //Return a string representing your preferred contact details.
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}
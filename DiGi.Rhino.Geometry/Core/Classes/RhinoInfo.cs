using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.Rhino.Geometry.Core.Classes
{
    /// <summary>
    /// Provides assembly information for the Rhino geometry library.
    /// </summary>
    public class RhinoInfo : GH_AssemblyInfo
    {
        /// <summary>
        /// Gets the name of the assembly.
        /// </summary>
        public override string Name => "DiGi.Rhino.Geometry";

        /// <summary>
        /// Gets the icon for the assembly.
        /// </summary>
        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap? Icon => null;

        /// <summary>
        /// Gets the description of the assembly.
        /// </summary>
        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        /// <summary>
        /// Gets the unique identifier for the assembly.
        /// </summary>
        public override Guid Id => new("0d2b4e84-b010-4425-b467-87c0a6b5c75c");

        /// <summary>
        /// Gets the name of the author.
        /// </summary>
        //Return a string identifying you or your company.
        public override string AuthorName => "Jakub Ziolkowski";

        /// <summary>
        /// Gets the contact information for the author.
        /// </summary>
        //Return a string representing your preferred contact details.
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}
using GH_IO.Serialization;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Represents a Grasshopper parameter that handles generic goo objects (<see cref="IGH_Goo"/>).
    /// </summary>
    public class GooParam : GH_Param<IGH_Goo>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("b5355531-7d1b-46a7-831f-28bcc73d9e95");

        /// <summary>
        /// Gets the exposure level of the parameter.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.hidden;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooParam"/> class with specified metadata and access mode.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="nickname">The nickname of the parameter.</param>
        /// <param name="description">The description of the parameter.</param>
        /// <param name="gH_ParamAccess">The access mode for the parameter (e.g., Item or List).</param>
        public GooParam(string name, string nickname, string description, GH_ParamAccess gH_ParamAccess)
            : base(name, nickname, description, "Params", "DiGi", gH_ParamAccess)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooParam"/> class with default values and item access.
        /// </summary>
        public GooParam()
            : base(string.Empty, string.Empty, string.Empty, "Params", "DiGi", GH_ParamAccess.item)
        {
        }

        /// <summary>
        /// Returns a hash code for the current object based on its name.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            if (Name == null)
            {
                return base.GetHashCode();
            }

            return Name.GetHashCode();
        }

        /// <summary>
        /// Reads the parameter data from the specified reader.
        /// </summary>
        /// <param name="reader">The reader used to deserialize the object.</param>
        /// <returns><c>true</c> if the read operation was successful; otherwise, <c>false</c>.</returns>
        public override sealed bool Read(GH_IReader reader)
        {
            return base.Read(reader);
        }

        /// <summary>
        /// Writes the parameter data to the specified writer.
        /// </summary>
        /// <param name="writer">The writer used to serialize the object.</param>
        /// <returns><c>true</c> if the write operation was successful; otherwise, <c>false</c>.</returns>
        public override sealed bool Write(GH_IWriter writer)
        {
            return base.Write(writer);
        }
    }
}
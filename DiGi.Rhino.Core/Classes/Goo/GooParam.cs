using Grasshopper.Kernel;
using System;
using GH_IO.Serialization;
using Grasshopper.Kernel.Types;

namespace DiGi.Rhino.Core.Classes
{
    public class GooParam : GH_Param<IGH_Goo>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("b5355531-7d1b-46a7-831f-28bcc73d9e95");

        public override GH_Exposure Exposure => GH_Exposure.hidden;

        public GooParam(string name, string nickname, string description, GH_ParamAccess gH_ParamAccess)
            : base(name, nickname, description, "Params", "DiGi", gH_ParamAccess)
        {

        }

        public GooParam()
            : base(string.Empty, string.Empty, string.Empty, "Params", "DiGi", GH_ParamAccess.item)
        {

        }

        public override int GetHashCode()
        {
            if (Name == null)
            {
                return base.GetHashCode();
            }

            return Name.GetHashCode();
        }

        public override sealed bool Read(GH_IReader reader)
        {
            return base.Read(reader);
        }

        public override sealed bool Write(GH_IWriter writer)
        {
            return base.Write(writer);
        }
    }
}

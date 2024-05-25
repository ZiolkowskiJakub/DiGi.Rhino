using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Core;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Classes;
using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Random.Classes
{
    public class Segment2DByRange : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("bf29bf62-ecc4-4686-9277-00648998c9fc");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Segment2DByRange()
          : base("Geometry.Random.Segment2DByRange", "Geomery.Random.Segment2DByRange",
              "Generate random Segment2D by given range",
              "DiGi", "DiGi.Geometry")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override Param[] Inputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Interval() { Name = "x", NickName = "x", Description = "x Range", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Interval() { Name = "y", NickName = "y", Description = "y Range", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Integer() { Name = "seed", NickName = "seed", Description = "seed", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary));

                Grasshopper.Kernel.Parameters.Param_Number param_Number = new Grasshopper.Kernel.Parameters.Param_Number() { Name = "tolerance", NickName = "tolerance", Description = "tolerance", Access = GH_ParamAccess.item, Optional = true };
                param_Number.SetPersistentData(DiGi.Core.Constans.Tolerance.Distance);
                result.Add(new Param(param_Number, ParameterVisibility.Voluntary));
                return result.ToArray();
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooSegment2DParam() { Name = "segment2D", NickName = "segment2D", Description = "DiGi Geometry Segment2D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                return result.ToArray();
            }
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="dataAccess">
        /// The DA object is used to retrieve from inputs and store in outputs.
        /// </param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            int index;

            index = Params.IndexOfInputParam("x");
            Interval interval_X = Interval.Unset;
            if (index == -1 || !dataAccess.GetData(index, ref interval_X) || interval_X == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("y");
            Interval interval_Y = Interval.Unset;
            if (index == -1 || !dataAccess.GetData(index, ref interval_Y) || interval_Y == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("seed");
            int seed = -1;
            if (index == -1 || !dataAccess.GetData(index, ref seed))
            {
                seed = -1;
            }

            index = Params.IndexOfInputParam("tolerance");
            double tolerance = DiGi.Core.Constans.Tolerance.Distance;
            if (index == -1 || !dataAccess.GetData(index, ref tolerance))
            {
                tolerance = DiGi.Core.Constans.Tolerance.Distance;
            }

            index = Params.IndexOfOutputParam("segment2D");
            if (index != -1)
            {
                Segment2D segment2D = DiGi.Geometry.Planar.Random.Create.Segment2D(interval_X.ToDiGi(), interval_Y.ToDiGi(), seed, tolerance);

                dataAccess.SetData(index, segment2D == null ? null : new GooSegment2D(segment2D));
            }
        }
    }
}
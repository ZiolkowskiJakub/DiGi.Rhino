using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Core;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Planar.Classes;
using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Random.Classes
{
    public class Polygon2DByRange : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("fefc5785-4659-4fe0-b316-65b3eb304723");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Polygon2DByRange()
          : base("Geometry.Random.Polygon2DByRange", "Geomery.Random.Polygon2DByRange",
              "Generate random Polygon2D by given range",
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
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Integer() { Name = "pointCount", NickName = "pointCount", Description = "Point count", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary));
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
                result.Add(new Param(new GooPolygon2DParam() { Name = "polygon2D", NickName = "polygon2D", Description = "DiGi Geometry Polygon2D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("pointCount");
            int pointCount = -1;
            if (index == -1 || !dataAccess.GetData(index, ref pointCount))
            {
                pointCount = -1;
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

            index = Params.IndexOfOutputParam("polygon2D");
            if (index != -1)
            {
                Polygon2D polygon2D = null;
                if (pointCount == -1)
                {
                    System.Random random = DiGi.Core.Create.Random(seed); 
                    
                    polygon2D = DiGi.Geometry.Planar.Random.Create.Polygon2D(interval_X.ToDiGi(), interval_Y.ToDiGi(), DiGi.Core.Query.Random(random, 5, 10), seed, tolerance);
                }
                else
                {
                    polygon2D = DiGi.Geometry.Planar.Random.Create.Polygon2D(interval_X.ToDiGi(), interval_Y.ToDiGi(), pointCount, seed, tolerance);
                }

                dataAccess.SetData(index, polygon2D == null ? null : new GooPolygon2D(polygon2D));
            }
        }
    }
}
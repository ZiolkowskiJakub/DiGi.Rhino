using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Core;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Classes;
using Eto.Forms;
using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Random.Classes
{
    public class PolygonalFace2DByRange : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("51201449-28b2-43f0-97dd-391ec76a1adc");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public PolygonalFace2DByRange()
          : base("Geometry.Random.PolygonalFace2DByRange", "Geomery.Random.PolygonalFace2DByRange",
              "Generate random PolygonalFace2D by given range",
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

                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Interval() { Name = "pointCount", NickName = "pointCount", Description = "Point count", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Interval() { Name = "internalEdgeCount", NickName = "internalEdgeCount", Description = "Internal edge count", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary));
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
                result.Add(new Param(new GooPolygonalFace2DParam() { Name = "polygonalFace2D", NickName = "polygonalFace2D", Description = "DiGi Geometry PolygonalFace2D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("pointCount");
            Interval interval_PointCount = Interval.Unset;
            if (index == -1 || !dataAccess.GetData(index, ref interval_PointCount))
            {
                interval_PointCount = new Interval(3, 10);
            }

            if (interval_PointCount == Interval.Unset)
            {
                interval_PointCount = new Interval(3, 10);
            }

            index = Params.IndexOfInputParam("internalEdgeCount");
            Interval interval_InternalEdgeCount = Interval.Unset;
            if (index == -1 || !dataAccess.GetData(index, ref interval_InternalEdgeCount))
            {
                interval_InternalEdgeCount = new Interval(0, 0);
            }

            if(interval_InternalEdgeCount == Interval.Unset)
            {
                interval_InternalEdgeCount = new Interval(0, 0);
            }

            index = Params.IndexOfOutputParam("polygonalFace2D");
            if (index != -1)
            {
                PolygonalFace2D polygonalFace2D = DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(interval_X.ToDiGi(), interval_Y.ToDiGi(), new DiGi.Core.Classes.Range<int>((int)interval_PointCount.T0, (int)interval_PointCount.T1), new DiGi.Core.Classes.Range<int>((int)interval_InternalEdgeCount.T0, (int)interval_InternalEdgeCount.T1), seed, tolerance);

                dataAccess.SetData(index, polygonalFace2D == null ? null : new GooPolygonalFace2D(polygonalFace2D));
            }
        }
    }
}
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class PolygonalFace3DByPolygonal3D : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("cb1c010d-cd43-4f2d-9378-212e4083838b");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public PolygonalFace3DByPolygonal3D()
          : base("Geometry.PolygonalFace3DByPolygonal3D", "Geomery.PolygonalFace3DByPolygonal3D",
              "Create PolygonalFace3D By Polygonal3D",
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
                result.Add(new Param(new GooPolygonal3DParam() { Name = "ExternalEdge", NickName = "ExternalEdge", Description = "ExternalEdge", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooPolygonal3DParam() { Name = "InternalEdges", NickName = "InternalEdges", Description = "InternalEdges", Access = GH_ParamAccess.list, Optional = true }, ParameterVisibility.Voluntary));

                Grasshopper.Kernel.Parameters.Param_Number param_Number = new Grasshopper.Kernel.Parameters.Param_Number() { Name = "Tolerance", NickName = "Tolerance", Description = "Tolerance", Access = GH_ParamAccess.item, Optional = true };
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
                result.Add(new Param(new GooPolygonalFace3DParam() { Name = "PolygonalFace3D", NickName = "PolygonalFace3D", Description = "DiGi PolygonalFace3D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("ExternalEdge");
            DiGi.Geometry.Spatial.Interfaces.IPolygonal3D externalEdge = null;
            if (index == -1 || !dataAccess.GetData(index, ref externalEdge) || externalEdge == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("InternalEdges");
            List<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D> internalEdges = new List<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D>();
            if (index != -1 || !dataAccess.GetData(index, ref internalEdges))
            {
                internalEdges = null;
            }

            double tolerance = DiGi.Core.Constans.Tolerance.Distance;
            index = Params.IndexOfInputParam("Tolerance");
            if (index != -1)
            {
                dataAccess.GetData(index, ref tolerance);
            }

            PolygonalFace3D polygonalFace3D = DiGi.Geometry.Spatial.Create.PolygonalFace3D(externalEdge, internalEdges, tolerance);
            index = Params.IndexOfOutputParam("PolygonalFace3D");
            if (index != -1)
            {
                dataAccess.SetData(index, polygonalFace3D == null ? null : new GooPolygonalFace3D(polygonalFace3D));
            }
        }
    }
}
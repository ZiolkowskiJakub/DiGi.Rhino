using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Classes
{
    public class ToGeometry3D : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("42d8cfda-ad7c-4e6e-b90e-f7a2ccf1cdc4");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public ToGeometry3D()
          : base("Geometry.ToGeometry3D", "Geomery.ToGeometry3D",
              "Converts DiGi geometry 3D to DiGi geometry 3D",
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
                result.Add(new Param(new GooGeometry2DParam() { Name = "Geometry2D", NickName = "Geometry2D", Description = "DiGi geometry", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooPlaneParam() { Name = "Plane", NickName = "Plane", Description = "DiGi Geometry Plane", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary));
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
                result.Add(new Param(new GooGeometry3DParam() { Name = "Geometry3D", NickName = "Geometry3D", Description = "DiGi Geometry 3D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("Geometry2D");
            IGeometry2D geometry2D = null;
            if (index == -1 || !dataAccess.GetData(index, ref geometry2D) || geometry2D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Plane plane = null;

            index = Params.IndexOfInputParam("Plane");
            if (index != -1)
            {
                if (!dataAccess.GetData(index, ref plane))
                {
                    plane = null;
                }
            }

            if (plane == null)
            {
                plane = DiGi.Geometry.Spatial.Constans.Plane.WorldZ;
            }

            index = Params.IndexOfOutputParam("Geometry3D");
            if (index != -1)
            {
                IGeometry3D geometry3D = DiGi.Geometry.Spatial.Query.Convert(plane, geometry2D);

                dataAccess.SetData(index, new GooGeometry3D(geometry3D));
            }
        }
    }
}
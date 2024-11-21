using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Rhino.Geometry.Classes
{
    public class ToGeometry2D : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("07dc7a7e-8105-4e90-a664-2d3ad2c6ab68");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public ToGeometry2D()
          : base("Geometry.ToGeometry2D", "Geomery.ToGeometry2D",
              "Converts DiGi geometry 3D to DiGi geometry 2D",
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
                result.Add(new Param(new GooGeometry3DParam() { Name = "Geometry3D", NickName = "Geometry3D", Description = "DiGi geometry", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooPlaneParam() { Name = "Plane", NickName = "Plane", Description = "DiGi Geometry Plane", Access = GH_ParamAccess.item }, ParameterVisibility.Voluntary));
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
                result.Add(new Param(new GooGeometry2DParam() { Name = "Geometry2D", NickName = "Geometry2D", Description = "DiGi Geometry 2D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooPlaneParam() { Name = "Plane", NickName = "Plane", Description = "DiGi Geometry Plane", Access = GH_ParamAccess.item }, ParameterVisibility.Voluntary));
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

            index = Params.IndexOfInputParam("Geometry3D");
            IGeometry3D geometry3D = null;
            if (index == -1 || !dataAccess.GetData(index, ref geometry3D) || geometry3D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Plane plane = null;
            if (geometry3D is IPlanar)
            {
                plane = ((IPlanar)geometry3D).Plane;
            }

            if(plane == null)
            {
                plane = DiGi.Geometry.Spatial.Constans.Plane.WorldZ;
            }


            index = Params.IndexOfOutputParam("Geometry2D");
            if (index != -1)
            {
                IGeometry2D geometry2D = null;

                PlanarResult planarResult = DiGi.Geometry.Spatial.Create.ProjectionResult(plane, geometry3D);
                if(planarResult != null)
                {
                    geometry2D = planarResult.GetGeometry2Ds<IGeometry2D>()?.FirstOrDefault();
                }

                dataAccess.SetData(index, new GooGeometry2D(geometry2D));
            }
        }
    }
}
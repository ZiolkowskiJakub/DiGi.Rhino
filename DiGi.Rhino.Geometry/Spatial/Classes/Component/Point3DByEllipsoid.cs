using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class Point3DByEllipsoid : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("6045bc78-7069-4265-8f76-615326635d2c");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Point3DByEllipsoid()
          : base("Geometry.Point3DByEllipsoid", "Geomery.Point3DByEllipsoid",
              "Create Point3D by Ellipsoid",
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
                result.Add(new Param(new GooEllipsoidParam() { Name = "Ellipsoid", NickName = "Ellipsoid", Description = "Ellipsoid", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Number() { Name = "Phi", NickName = "Phi", Description = "Phi", Access = GH_ParamAccess.item}, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Number() { Name = "Theta", NickName = "Theta", Description = "Theta", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

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
                result.Add(new Param(new GooPoint3DParam() { Name = "Point3D", NickName = "Point3D", Description = "DiGi Point3D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("Ellipsoid");
            DiGi.Geometry.Spatial.Classes.Ellipsoid ellipsoid = null;
            if (index == -1 || !dataAccess.GetData(index, ref ellipsoid) || ellipsoid == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            double phi = -1;
            index = Params.IndexOfInputParam("Phi");
            if (index == -1 || !dataAccess.GetData(index, ref phi))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            double theta = -1;
            index = Params.IndexOfInputParam("Theta");
            if (index == -1 || !dataAccess.GetData(index, ref theta))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Point3D point3D = ellipsoid.GetPoint(theta, phi);
            index = Params.IndexOfOutputParam("Point3D");
            if (index != -1)
            {
                dataAccess.SetData(index, ellipsoid == null ? null : new GooPoint3D(point3D));
            }
        }
    }
}
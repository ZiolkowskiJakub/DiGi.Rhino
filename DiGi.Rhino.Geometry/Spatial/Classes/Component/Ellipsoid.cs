using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class Point3D : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("760539d2-870c-448e-ba87-52e3dbeff623");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Point3D()
          : base("Geometry.Point3D", "Geomery.Point3D",
              "Create Point3D",
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
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Number() { Name = "X", NickName = "X", Description = "X", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Number() { Name = "Y", NickName = "Y", Description = "Y", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Number() { Name = "Z", NickName = "Z", Description = "Z", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

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

            double x = double.NaN;
            index = Params.IndexOfInputParam("X");
            if (index == -1 || !dataAccess.GetData(index, ref x))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            double y = double.NaN;
            index = Params.IndexOfInputParam("Y");
            if (index == -1 || !dataAccess.GetData(index, ref y))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            double z = double.NaN;
            index = Params.IndexOfInputParam("Z");
            if (index == -1 || !dataAccess.GetData(index, ref z))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            DiGi.Geometry.Spatial.Classes.Point3D point3D = new DiGi.Geometry.Spatial.Classes.Point3D(x, y, z);
            index = Params.IndexOfOutputParam("Point3D");
            if (index != -1)
            {
                dataAccess.SetData(index, point3D == null ? null : new GooPoint3D(point3D));
            }
        }
    }
}
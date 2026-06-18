using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    /// <summary>
    /// A Grasshopper component that creates an ellipsoid geometry based on a plane and three semi-axes lengths.
    /// </summary>
    public class Ellipsoid : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("3bb37fd8-0b29-43ec-baea-564606ac192b");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary> Gets the exposure level of the component, which determines when it is executed. </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipsoid"/> class.
        /// </summary>
        public Ellipsoid()
          : base("Geometry.Ellipsoid", "Geomery.Ellipsoid",
              "Create Ellipsoid",
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
                List<Param> result =
                [
                    new Param(new GooPlaneParam() { Name = "Plane", NickName = "Plane", Description = "Plane", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new Grasshopper.Kernel.Parameters.Param_Number() { Name = "A", NickName = "A", Description = "A", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new Grasshopper.Kernel.Parameters.Param_Number() { Name = "B", NickName = "B", Description = "B", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new Grasshopper.Kernel.Parameters.Param_Number() { Name = "C", NickName = "C", Description = "C", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];

                return [.. result];
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new GooEllipsoidParam() { Name = "Ellipsoid", NickName = "Ellipsoid", Description = "DiGi Ellipsoid", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];
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

            index = Params.IndexOfInputParam("Plane");
            Plane? plane = null;
            if (index == -1 || !dataAccess.GetData(index, ref plane) || plane == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            double a = double.NaN;
            index = Params.IndexOfInputParam("A");
            if (index == -1 || !dataAccess.GetData(index, ref a))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            double b = double.NaN;
            index = Params.IndexOfInputParam("B");
            if (index == -1 || !dataAccess.GetData(index, ref b))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            double c = double.NaN;
            index = Params.IndexOfInputParam("C");
            if (index == -1 || !dataAccess.GetData(index, ref c))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            DiGi.Geometry.Spatial.Classes.Ellipsoid ellipsoid = new(plane, a, b, c);
            index = Params.IndexOfOutputParam("Ellipsoid");
            if (index != -1)
            {
                dataAccess.SetData(index, ellipsoid == null ? null : new GooEllipsoid(ellipsoid));
            }
        }
    }
}

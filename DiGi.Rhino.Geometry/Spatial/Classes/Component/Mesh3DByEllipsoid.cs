using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class Mesh3DByEllipsoid : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("b060c096-fc99-48ca-90c3-a4b1f1482de3");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Mesh3DByEllipsoid()
          : base("Geometry.Mesh3DByEllipsoid", "Geomery.Mesh3DByEllipsoid",
              "Create Mesh3D",
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
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Integer() { Name = "Stacks", NickName = "Stacks", Description = "Stacks", Access = GH_ParamAccess.item}, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Integer() { Name = "Slices", NickName = "Slices", Description = "Slices", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

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
                result.Add(new Param(new GooMesh3DParam() { Name = "Mesh3D", NickName = "Mesh3D", Description = "DiGi Mesh3D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            int stacks = -1;
            index = Params.IndexOfInputParam("Stacks");
            if (index == -1 || !dataAccess.GetData(index, ref stacks))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            int slices = -1;
            index = Params.IndexOfInputParam("Slices");
            if (index == -1 || !dataAccess.GetData(index, ref slices))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }


            Mesh3D mesh3D = DiGi.Geometry.Spatial.Create.Mesh3D(ellipsoid, stacks, slices);
            index = Params.IndexOfOutputParam("Mesh3D");
            if (index != -1)
            {
                dataAccess.SetData(index, ellipsoid == null ? null : new GooMesh3D(mesh3D));
            }
        }
    }
}
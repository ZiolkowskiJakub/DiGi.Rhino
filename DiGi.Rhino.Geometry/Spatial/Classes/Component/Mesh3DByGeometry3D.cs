using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class Mesh3DByGeometry3D : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("c7cf7362-34e1-4222-8a9e-fb272fde8576");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Mesh3DByGeometry3D()
          : base("Geometry.Mesh3DByGeometry3D", "Geomery.Mesh3DByGeometry3D",
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
                result.Add(new Param(new GooGeometry3DParam() { Name = "Geometry3D", NickName = "Geometry3D", Description = "Geometry3D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

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

            index = Params.IndexOfInputParam("Geometry3D");
            IGeometry3D geometry3D = null;
            if (index == -1 || !dataAccess.GetData(index, ref geometry3D) || geometry3D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            double tolerance = DiGi.Core.Constans.Tolerance.Distance;
            index = Params.IndexOfInputParam("Tolerance");
            if (index != -1)
            {
                dataAccess.GetData(index, ref tolerance);
            }

            Mesh3D mesh3D = null;

            if (geometry3D is PolygonalFace3D)
            {
                mesh3D = DiGi.Geometry.Spatial.Create.Mesh3D((PolygonalFace3D)geometry3D, tolerance);
            }
            else if (geometry3D is Polyhedron)
            {
                mesh3D = DiGi.Geometry.Spatial.Create.Mesh3D((Polyhedron)geometry3D, tolerance);
            }
            else if (geometry3D is IPolygonal3D)
            {
                mesh3D = DiGi.Geometry.Spatial.Create.Mesh3D(new PolygonalFace3D((IPolygonal3D)geometry3D), tolerance);
            }

            index = Params.IndexOfOutputParam("Mesh3D");
            if (index != -1)
            {
                dataAccess.SetData(index, mesh3D == null ? null : new GooMesh3D(mesh3D));
            }
        }
    }
}
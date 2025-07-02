using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class EllipsoidByFocalPoints : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("3fa53622-f528-44e3-853c-11d5af0976f4");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public EllipsoidByFocalPoints()
          : base("Geometry.EllipsoidByFocalPoints", "Geomery.EllipsoidByFocalPoints",
              "Create Ellipsoid By Focal Points",
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
                result.Add(new Param(new GooPoint3DParam() { Name = "FocalPoint_1", NickName = "FocalPoint_1", Description = "First Focal Point", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooPoint3DParam() { Name = "FocalPoint_2", NickName = "FocalPoint_2", Description = "Second Focal Point", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Number() { Name = "B", NickName = "B", Description = "B", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Number() { Name = "C", NickName = "C", Description = "C", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Binding));

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
                result.Add(new Param(new GooEllipsoidParam() { Name = "Ellipsoid", NickName = "Ellipsoid", Description = "DiGi Ellipsoid", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("FocalPoint_1");
            DiGi.Geometry.Spatial.Classes.Point3D focalPoint_1 = null;
            if (index == -1 || !dataAccess.GetData(index, ref focalPoint_1) || focalPoint_1 == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("FocalPoint_2");
            DiGi.Geometry.Spatial.Classes.Point3D focalPoint_2 = null;
            if (index == -1 || !dataAccess.GetData(index, ref focalPoint_2) || focalPoint_2 == null)
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

            double c = b;
            index = Params.IndexOfInputParam("C");
            if(index != -1)
            {
                if(!dataAccess.GetData(index, ref c))
                {
                    c = b;
                }
            }

            double tolerance = DiGi.Core.Constans.Tolerance.Distance;
            index = Params.IndexOfInputParam("Tolerance");
            if (index != -1)
            {
                dataAccess.GetData(index, ref tolerance);
            }

            DiGi.Geometry.Spatial.Classes.Ellipsoid ellipsoid = DiGi.Geometry.Spatial.Create.Ellipsoid(focalPoint_1, focalPoint_2, b, c, tolerance);
            index = Params.IndexOfOutputParam("Ellipsoid");
            if (index != -1)
            {
                dataAccess.SetData(index, ellipsoid == null ? null : new GooEllipsoid(ellipsoid));
            }
        }
    }
}
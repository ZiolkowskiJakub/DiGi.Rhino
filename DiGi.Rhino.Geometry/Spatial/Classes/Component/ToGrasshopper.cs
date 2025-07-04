﻿using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class ToGrasshopper : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("b5ca211a-a681-4149-9cdb-3eb933143127");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public ToGrasshopper()
          : base("Geometry.ToGrasshopper", "Geomery.ToGrasshopper",
              "Converts DiGi geometry to Grasshopper geometry",
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
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Geometry() { Name = "Geometry", NickName = "Geometry", Description = "Grasshopper Geometry3D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfOutputParam("Geometry");
            if (index != -1)
            {
                IGH_Goo gH_Goo = Convert.ToGrasshopper(geometry3D);

                dataAccess.SetData(index, gH_Goo);
            }
        }
    }
}
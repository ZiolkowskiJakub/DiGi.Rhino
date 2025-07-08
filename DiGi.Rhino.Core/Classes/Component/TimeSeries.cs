using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    public class TimeSeries : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("3f4c4cbd-5494-4f4c-acf8-4753771925c2");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public TimeSeries()
          : base("Core.TimeSeries", "Core.TimeSeries",
              "Create TimeSeries",
              "DiGi", "DiGi.Core")
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
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Time() { Name = "StartTime", NickName = "StartTime", Description = "Start Time", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Time() { Name = "EndTime", NickName = "EndTime", Description = "End Time", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Integer() { Name = "Step", NickName = "Step", Description = "Step in hours [h]", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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
                result.Add(new Param(new GooTimeSeriesParam() { Name = "TimeSeries", NickName = "TimeSeries", Description = "TimeSeries", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("StartTime");
            DateTime startDateTime = DateTime.Now;
            if (index == -1 || !dataAccess.GetData(index, ref startDateTime))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("EndTime");
            DateTime endDateTime = DateTime.Now;
            if (index == -1 || !dataAccess.GetData(index, ref endDateTime))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Step");
            int step = 1;
            if (index == -1 || !dataAccess.GetData(index, ref step))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            ITimeSeries timeSeries = new DateTimeSeries(new DateTimeRange(startDateTime, endDateTime), TimeSpan.FromHours(step).Ticks);

            index = Params.IndexOfOutputParam("TimeSeries");
            if (index != -1)
            {
                dataAccess.SetData(index, new GooTimeSeries(timeSeries));
            }
        }
    }
}
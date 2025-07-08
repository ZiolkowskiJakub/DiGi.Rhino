using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class GooTimeSeries : GooSerializableObject<Core.Interfaces.ITimeSeries>
    {
        public GooTimeSeries()
            : base()
        {
        }

        public GooTimeSeries(Core.Interfaces.ITimeSeries timeSeries)
            : base()
        {
            Value = timeSeries;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooTimeSeries(Value);
        }

    }

    public class GooTimeSeriesParam : GooPresistentParam<GooTimeSeries, Core.Interfaces.ITimeSeries>
    {
        public override Guid ComponentGuid => new Guid("13973939-9f83-42ff-80bc-8e11389d8a82");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooTimeSeriesParam()
            : base()
        {
        }
    }
}


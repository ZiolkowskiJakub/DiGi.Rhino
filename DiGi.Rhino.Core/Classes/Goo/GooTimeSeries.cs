using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for time-series data, enabling its use and serialization within the Grasshopper environment.
    /// </summary>
    public class GooTimeSeries : GooSerializableObject<Core.Interfaces.ITimeSeries>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooTimeSeries"/> class.
        /// </summary>
        public GooTimeSeries()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooTimeSeries"/> class with the specified time series value.
        /// </summary>
        /// <param name="timeSeries">The time series data to wrap.</param>
        public GooTimeSeries(Core.Interfaces.ITimeSeries? timeSeries)
            : base()
        {
            Value = timeSeries;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooTimeSeries"/> object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing a copy of the original value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooTimeSeries(Value);
        }
    }

    /// <summary>
    /// Represents a persistent Grasshopper parameter for handling <see cref="GooTimeSeries"/> objects.
    /// </summary>
    public class GooTimeSeriesParam : GooSerializablePresistentParam<GooTimeSeries, Core.Interfaces.ITimeSeries>
    {
        /// <summary>
        /// Gets the unique identifier (GUID) for the <see cref="GooTimeSeriesParam"/> component.
        /// </summary>
        public override Guid ComponentGuid => new("13973939-9f83-42ff-80bc-8e11389d8a82");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooTimeSeriesParam"/> class.
        /// </summary>
        public GooTimeSeriesParam()
            : base()
        {
        }
    }
}
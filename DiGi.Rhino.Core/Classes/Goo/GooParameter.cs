using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for a <see cref="Core.Parameter.Classes.Parameter"/> object, 
    /// enabling it to be passed through Grasshopper wires and stored in the document.
    /// </summary>
    public class GooParameter : GooSerializableObject<Core.Parameter.Classes.Parameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooParameter"/> class.
        /// </summary>
        public GooParameter()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooParameter"/> class with the specified parameter value.
        /// </summary>
        /// <param name="parameter">The <see cref="Core.Parameter.Classes.Parameter"/> to wrap.</param>
        public GooParameter(Core.Parameter.Classes.Parameter? parameter)
            : base()
        {
            Value = parameter;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing a copy of the wrapped value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooParameter(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type used to handle and persist <see cref="GooParameter"/> objects.
    /// </summary>
    public class GooParameterParam : GooSerializablePresistentParam<GooParameter, Core.Parameter.Classes.Parameter>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("e91d099f-37df-4817-aac9-0d3eded74b42");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooParameterParam"/> class.
        /// </summary>
        public GooParameterParam()
            : base()
        {
        }
    }
}
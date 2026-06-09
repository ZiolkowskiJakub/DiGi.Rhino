using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// Represents a serializable Goo wrapper for an <see cref="Core.Parameter.Interfaces.IParameterDefinition"/>.
    /// </summary>
    public class GooParameterDefinition : GooSerializableObject<Core.Parameter.Interfaces.IParameterDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooParameterDefinition"/> class.
        /// </summary>
        public GooParameterDefinition()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooParameterDefinition"/> class with the specified parameter definition.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition to wrap.</param>
        public GooParameterDefinition(Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition)
            : base()
        {
            Value = parameterDefinition;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooParameterDefinition(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type for <see cref="GooParameterDefinition"/>.
    /// </summary>
    public class GooParameterDefinitionParam : GooSerializablePresistentParam<GooParameterDefinition, Core.Parameter.Interfaces.IParameterDefinition>
    {
        /// <summary>
        /// Gets the unique identifier for the component associated with this parameter.
        /// </summary>
        /// <value>The GUID of the component.</value>
        public override Guid ComponentGuid => new("ec1459a7-fdfd-4380-8549-7212b9ecc0bb");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooParameterDefinitionParam"/> class.
        /// </summary>
        public GooParameterDefinitionParam()
            : base()
        {
        }
    }
}
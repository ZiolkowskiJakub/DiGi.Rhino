using DiGi.Core.Parameter.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for an <see cref="IParametrizedObject"/>, enabling it to be used within the Grasshopper environment and supporting serialization.
    /// </summary>
    public class GooParametrizedObject : GooSerializableObject<IParametrizedObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooParametrizedObject"/> class.
        /// </summary>
        public GooParametrizedObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooParametrizedObject"/> class with the specified parameterized object.
        /// </summary>
        /// <param name="parametrizedObject">The parameterized object to wrap.</param>
        public GooParametrizedObject(IParametrizedObject? parametrizedObject)
            : base()
        {
            Value = parametrizedObject;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooParametrizedObject"/> containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooParametrizedObject(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type for <see cref="GooParametrizedObject"/>.
    /// </summary>
    public class GooParametrizedObjectParam : GooSerializablePresistentParam<GooParametrizedObject, IParametrizedObject>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("221d1e55-a083-4d11-a1d2-65faa76972fb");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooParametrizedObjectParam"/> class.
        /// </summary>
        public GooParametrizedObjectParam()
            : base()
        {
        }
    }
}
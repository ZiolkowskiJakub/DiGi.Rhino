using DiGi.Rhino.Core.Interfaces;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for <see cref="Type"/>, allowing system types to be passed through Grasshopper wires.
    /// </summary>
    public class GooType : GooObject<Type>, IGooObject<Type>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooType"/> class.
        /// </summary>
        public GooType()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooType"/> class with a specified type.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to be wrapped in the Goo object.</param>
        public GooType(Type? type)
            : base(type)
        {
            Value = type;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new <see cref="GooType"/> instance containing the same value.</returns>
        public override IGH_Goo? Duplicate()
        {
            return new GooType(Value);
        }
    }

    /// <summary>
    /// A Grasshopper parameter used to input and output <see cref="GooType"/> objects.
    /// </summary>
    public class GooTypeParam : GH_PersistentParam<GooType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooTypeParam"/> class.
        /// </summary>
        public GooTypeParam()
            : base(Query.Name(typeof(Type)), Query.Name(typeof(Type)), typeof(Type).FullName?.Replace(".", " "), "Params", Query.Subcategory(typeof(Type)))
        {
        }

        /// <summary>
        /// Gets the unique identifier for the <see cref="GooTypeParam"/> component.
        /// </summary>
        public override Guid ComponentGuid => new("712daba3-50c2-4923-abca-bdbe0a0a0207");

        protected override GH_GetterResult Prompt_Plural(ref List<GooType> values)
        {
            throw new NotImplementedException();
        }

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
        protected override GH_GetterResult Prompt_Singular(ref GooType value)
        {
            throw new NotImplementedException();
        }
    }
}
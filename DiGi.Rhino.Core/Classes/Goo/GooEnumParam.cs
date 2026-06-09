using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Represents a persistent parameter in Grasshopper that handles enumeration values wrapped in a <see cref="GooEnum{X}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the value being stored, which must be a <see cref="GooEnum{X}"/>. </typeparam>
    /// <typeparam name="X">The underlying enumeration type.</typeparam>
    public abstract class GooEnumParam<T, X> : GH_PersistentParam<T> where T : GooEnum<X> where X : Enum
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooEnumParam{T, X}"/> class.
        /// </summary>
        public GooEnumParam()
            : base(typeof(X).Name, typeof(X).Name, typeof(X).FullName?.Replace(".", " "), "Params", "DiGi")
        {
        }

        /// <summary>
        /// Handles the prompt for multiple values when the parameter is accessed.
        /// </summary>
        /// <param name="values">A reference to the list of values to be updated.</param>
        /// <returns>The result of the getter operation.</returns>
        protected override GH_GetterResult Prompt_Plural(ref List<T> values)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Handles the prompt for a single value when the parameter is accessed.
        /// </summary>
        /// <param name="value">A reference to the value to be updated.</param>
        /// <returns>The result of the getter operation.</returns>
        protected override GH_GetterResult Prompt_Singular(ref T value)
        {
            throw new NotImplementedException();
        }
    }
}
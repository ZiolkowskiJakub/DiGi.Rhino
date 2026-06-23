using DiGi.Core.Interfaces;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Represents a persistent parameter in Grasshopper that manages data of type <typeparamref name="T"/>,
    /// which wraps an underlying object of type <typeparamref name="X"/>.
    /// </summary>
    /// <typeparam name="T">The type of the Goo object, which must inherit from <see cref="GooObject{TObject}"/>.</typeparam>
    /// <typeparam name="X">The type of the underlying data object, which must implement <see cref="IObject"/>.</typeparam>
    public class GooPresistentParam<T, X> : GH_PersistentParam<T?> where T : GooObject<X?> where X : IObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooPresistentParam{T, X}"/> class with a specified name and subcategory.
        /// </summary>
        /// <param name="name">The display name of the parameter.</param>
        /// <param name="subcategory">The subcategory under which the parameter is listed in the Grasshopper menu.</param>
        public GooPresistentParam(string name, string subcategory)
            : base(name, name, typeof(X).FullName?.Replace(".", " "), "Params", subcategory)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooPresistentParam{T, X}"/> class using default values derived from type <typeparamref name="X"/>.
        /// </summary>
        public GooPresistentParam()
            : base(Query.Name(typeof(X)), Query.Name(typeof(X)), typeof(X).FullName?.Replace(".", " "), "Params", Query.Subcategory(typeof(X)))
        {
        }

        /// <summary>
        /// Gets the unique identifier for this component.
        /// </summary>
        public override Guid ComponentGuid => new("a2f8ed2f-2634-416a-b119-57bd05dc559c");

        /// <summary>
        /// Prompts the user to supply multiple values of type <typeparamref name="T"/>.
        /// </summary>
        /// <param name="values">The list of values supplied by the user.</param>
        /// <returns>A <see cref="GH_GetterResult"/> indicating the outcome of the prompt.</returns>
        protected override GH_GetterResult Prompt_Plural(ref List<T?> values)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prompts the user to supply a single value of type <typeparamref name="T"/>.
        /// </summary>
        /// <param name="value">The value supplied by the user.</param>
        /// <returns>A <see cref="GH_GetterResult"/> indicating the outcome of the prompt.</returns>
        protected override GH_GetterResult Prompt_Singular(ref T? value)
        {
            throw new NotImplementedException();
        }
    }
}
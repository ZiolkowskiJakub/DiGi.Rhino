using DiGi.Core.Interfaces;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    public class GooPresistentParam<T, X> : GH_PersistentParam<T?> where T : GooObject<X?> where X : IObject
    {
        public GooPresistentParam(string name, string subcategory)
            : base(name, name, typeof(X).FullName?.Replace(".", " "), "Params", subcategory)
        {
        }

        public GooPresistentParam()
            : base(Query.Name(typeof(X)), Query.Name(typeof(X)), typeof(X).FullName?.Replace(".", " "), "Params", Query.Subcategory(typeof(X)))
        {
        }

        public override Guid ComponentGuid => new("a2f8ed2f-2634-416a-b119-57bd05dc559c");

        protected override GH_GetterResult Prompt_Plural(ref List<T?> values)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Singular(ref T? value)
        {
            throw new NotImplementedException();
        }
    }
}
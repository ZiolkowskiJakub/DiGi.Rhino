using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    public abstract class GooEnumParam<T, X> : GH_PersistentParam<T> where T : GooEnum<X> where X : Enum
    {
        public GooEnumParam()
            : base(typeof(X).Name, typeof(X).Name, typeof(X).FullName.Replace(".", " "), "Params", "DiGi")
        {
        }

        protected override GH_GetterResult Prompt_Plural(ref List<T> values)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Singular(ref T value)
        {
            throw new NotImplementedException();
        }
    }
}

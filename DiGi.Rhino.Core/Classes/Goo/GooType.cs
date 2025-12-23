using DiGi.Rhino.Core.Interfaces;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    public class GooType : GooObject<Type>, IGooObject<Type>
    {
        public GooType()
            : base()
        {
        }

        public GooType(Type? type)
            : base(type)
        {
            Value = type;
        }

        public override IGH_Goo? Duplicate()
        {
            return new GooType(Value);
        }
    }

    public class GooTypeParam : GH_PersistentParam<GooType>
    {
        public GooTypeParam()
            : base(Query.Name(typeof(Type)), Query.Name(typeof(Type)), typeof(Type).FullName?.Replace(".", " "), "Params", Query.Subcategory(typeof(Type)))
        {
        }

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

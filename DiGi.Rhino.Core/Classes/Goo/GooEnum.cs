using Grasshopper.Kernel.Types;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;
using DiGi.Rhino.Core.Interfaces;
using GH_IO.Serialization;

namespace DiGi.Rhino.Core.Classes
{
    public class GooEnum<T> : GH_Goo<T>, IGoo where T : Enum
    {
        public GooEnum()
            : base()
        {
        }

        public GooEnum(GooEnum<T> gooEnum)
            : base(gooEnum)
        {

        }

        public GooEnum(T @enum)
            : base(@enum)
        {

        }

        public override bool IsValid => Value != null;

        public override string TypeName
        {
            get
            {
                if (Value == null)
                {
                    return typeof(T).FullName;
                }

                return Value.GetType().FullName;
            }
        }

        public override string TypeDescription
        {
            get
            {
                if (Value == null)
                {
                    return typeof(T).FullName.Replace(".", " ");
                }

                return Value.GetType().FullName.Replace(".", " ");
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooEnum<T>(Value);
        }

        public override bool Write(GH_IWriter writer)
        {
            if (Value == null || writer == null)
            {
                return false;
            }

            writer.SetString(typeof(T).FullName, Value.ToString());
            return true;
        }

        public override bool Read(GH_IReader reader)
        {
            if(reader == null)
            {
                return false;
            }

            string value = null;
            if (!reader.TryGetString(typeof(T).FullName, ref value))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                Value = default;
                return true;
            }

            if(!DiGi.Core.Query.TryGetEnum(value, out T @enum))
            {
                Value = default;
                return true;
            }

            Value = @enum;
            return true;
        }

        public override string ToString()
        {
            if (Value == null)
            {
                return null;
            }

            return Value.ToString();
        }

        public override bool CastFrom(object source)
        {
            if (source == null)
            {
                return false;
            }

            if (source is T)
            {
                Value = (T)(object)source;
                return true;
            }

            object value = source;
            if(value is IGH_Goo)
            {
                value = ((dynamic)value).Value;
            }

            if(DiGi.Core.Query.TryConvert(value, out T @enum))
            {
                Value = @enum;
                return true;
            }

            return base.CastFrom(source);
        }

        public override bool CastTo<Y>(ref Y target)
        {
            if (typeof(Y) == typeof(T))
            {
                target = (Y)(object)Value;
                return true;
            }

            if (typeof(Y) == typeof(object))
            {
                target = (Y)(object)Value;
                return true;
            }

            if (typeof(GH_ObjectWrapper) == typeof(Y))
            {
                target = (Y)(object)(new GH_ObjectWrapper(Value));
                return true;
            }

            if (DiGi.Core.Query.TryConvert(Value, out Y value))
            {
                target = value;
                return true;
            }

            return base.CastTo(ref target);
        }
    }

    public class GooEnumParam<T> : GooEnumParam<GooEnum<T>, T> where T : Enum
    {
        public override Guid ComponentGuid => new Guid("fa4f4af4-3a0d-45d4-be59-bfb65dc350cb");
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooEnumParam()
            : base()
        {
        }
    }

    public class GooEnum : GooEnum<Enum>
    {
        public GooEnum()
            : base()
        {
        }

        public GooEnum(Enum @enum)
        {
            Value = @enum;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooEnum(Value);
        }
    }

    public class GooEnumParam : GH_PersistentParam<GooEnum>
    {
        public override Guid ComponentGuid => new Guid("659a3dbe-c305-4512-94c2-202f18c80911");
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooEnumParam()
            : base(typeof(Enum).Name, typeof(Enum).Name, typeof(Enum).FullName.Replace(".", " "), "Params", "DiGi")
        {
        }

        protected override GH_GetterResult Prompt_Singular(ref GooEnum value)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Plural(ref List<GooEnum> values)
        {
            throw new NotImplementedException();
        }
    }
}

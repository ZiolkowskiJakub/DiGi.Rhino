using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Interfaces;
using GH_IO.Serialization;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    public class GooEnum<T> : GH_Goo<T?>, IGooObject where T : Enum
    {
        public GooEnum()
            : base()
        {
        }

        public GooEnum(GooEnum<T>? gooEnum)
            : base(gooEnum)
        {

        }

        public GooEnum(T? @enum)
            : base(@enum)
        {

        }

        public override bool IsValid => Value != null;

        public override string? TypeDescription
        {
            get
            {
                if (Value == null)
                {
                    return typeof(T).FullName?.Replace(".", " ");
                }

                return Value.GetType().FullName?.Replace(".", " ");
            }
        }

        public override string? TypeName
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
            if (value is IGH_Goo)
            {
                value = ((dynamic)value).Value;
            }

            if (DiGi.Core.Query.TryConvert(value, out T? @enum))
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
                if ((Y?)(object?)Value is Y y)
                {
                    target = y;
                    return true;
                }
            }

            if (typeof(Y) == typeof(object))
            {
                if ((Y?)(object?)Value is Y y)
                {
                    target = y;
                    return true;
                }
            }

            if (typeof(GH_ObjectWrapper) == typeof(Y))
            {
                target = (Y)(object)(new GH_ObjectWrapper(Value));
                return true;
            }

            if (DiGi.Core.Query.TryConvert(Value, out Y? value) && value is not null)
            {
                target = value;
                return true;
            }

            return base.CastTo(ref target);
        }

        public override IGH_Goo? Duplicate()
        {
            return new GooEnum<T>(Value);
        }

        public override bool Read(GH_IReader? reader)
        {
            if (reader == null)
            {
                return false;
            }

            string? value = null;
            if (!reader.TryGetString(typeof(T).FullName, ref value))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                Value = default;
                return true;
            }

            if (!DiGi.Core.Query.TryGetEnum(value, out T? @enum))
            {
                Value = default;
                return true;
            }

            Value = @enum;
            return true;
        }

        public override string? ToString()
        {
            if (Value == null)
            {
                return null;
            }

            return Value.ToString();
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
    }

    public class GooEnum : GooEnum<Enum>
    {
        public GooEnum()
            : base()
        {
        }

        public GooEnum(Enum? @enum)
        {
            Value = @enum;
        }

        public override IGH_Goo? Duplicate()
        {
            return new GooEnum(Value);
        }
    }

    public class GooEnumParam<T> : GooEnumParam<GooEnum<T>, T> where T : Enum
    {
        public GooEnumParam()
            : base()
        {
        }

        public override Guid ComponentGuid => new ("fa4f4af4-3a0d-45d4-be59-bfb65dc350cb");
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
    public class GooEnumParam : GH_PersistentParam<GooEnum>
    {
        public GooEnumParam()
            : base(Query.Name(typeof(Enum)), Query.Name(typeof(Enum)), typeof(Enum).FullName?.Replace(".", " "), "Params", Query.Subcategory(typeof(IObject)))
        {
        }

        public override Guid ComponentGuid => new("659a3dbe-c305-4512-94c2-202f18c80911");
        
        protected override GH_GetterResult Prompt_Plural(ref List<GooEnum> values)
        {
            throw new NotImplementedException();
        }

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
        protected override GH_GetterResult Prompt_Singular(ref GooEnum value)
        {
            throw new NotImplementedException();
        }
    }
}

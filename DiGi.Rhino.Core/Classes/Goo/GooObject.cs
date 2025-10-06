using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Interfaces;
using GH_IO.Serialization;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DiGi.Rhino.Core.Classes
{
    public class GooObject<TObject> : GH_Goo<TObject?>, IGooObject<TObject>
    {
        public GooObject()
            : base()
        {
        }

        public GooObject(TObject? @object)
        {
            Value = @object;
        }

        public override bool IsValid => Value != null;

        public override string? TypeDescription
        {
            get
            {
                if (Value == null)
                {
                    return typeof(TObject).FullName?.Replace(".", " ");
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
                    return typeof(TObject).FullName;
                }

                return Value.GetType().FullName;
            }
        }
        
        public override bool CastFrom(object? source)
        {
            object? source_Temp = source;
            if (source_Temp is IGH_Goo gH_Goo)
            {
                if(Query.TryGetValue(gH_Goo, out object? value))
                {
                    source_Temp = value;
                }
            }

            if (source_Temp is TObject @object)
            {
                Value = @object;
                return true;
            }

            return base.CastFrom(source);
        }

        public override bool CastTo<Y>(ref Y target)
        {
            Type type = typeof(Y);

            if (type == typeof(TObject))
            {
                target = (Y)(object)Value!;
                return true;
            }
            else if (type == typeof(object))
            {
                target = (Y)(object)Value!;
                return true;
            }
            else if (type == typeof(GH_ObjectWrapper))
            {
                target = (Y)(object)(new GH_ObjectWrapper(Value));
                return true;
            }
            else if (typeof(IGH_Goo).IsAssignableFrom(type))
            {
                PropertyInfo? propertyInfo = type.GetProperty("Value", BindingFlags.Public | BindingFlags.Instance);
                if (propertyInfo is not null && propertyInfo.CanWrite)
                {
                    propertyInfo.SetValue(target, Value);
                    return true;
                }
            }

            if(Value is Y)
            {
                target = (Y)(object)Value;
                return true;
            }

            try
            {
                if (Value != null && Value is ISerializableObject serializableObject)
                {
                    if (typeof(Y).IsAssignableFrom(Value.GetType()))
                    {
                        target = (Y)(object)serializableObject.Clone()!;
                    }
                    else
                    {
                        target = DiGi.Core.Create.Object<Y>(serializableObject)!;
                    }

                    if (target != null)
                    {
                        return true;
                    }
                }
            }
            catch
            {

            }

            return base.CastTo(ref target);
        }

        public override IGH_Goo? Duplicate()
        {
            return new GooObject<TObject>(Value);
        }

        public XObject? GetValue<XObject>() where XObject : TObject
        {
            return Value is XObject ? (XObject)(object)Value : default;
        }

        public override bool Read(GH_IReader reader)
        {
            if (reader == null)
            {
                return false;
            }

            string? json = null;
            if (!reader.TryGetString(typeof(TObject).FullName, ref json))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(json))
            {
                Value = default;
                return true;
            }

            ISerializableObject? serializableObject = DiGi.Core.Convert.ToDiGi<ISerializableObject>(json)?.FirstOrDefault();
            if (serializableObject is null)
            {
                Value = default;
                return true;
            }

            object value = serializableObject;

            if (serializableObject is IValue)
            {
                try
                {
                    value = (serializableObject as dynamic).GetValue<TObject>();
                }
                catch
                {

                }
            }

            if (value is not TObject)
            {
                return false;
            }
           
            Value = (TObject)(object)value;
            return true;
        }

        public override string? ToString()
        {
            if (Value == null)
            {
                return null;
            }

            string? value = Value.GetType()?.FullName;

            return value;
        }

        public override bool Write(GH_IWriter writer)
        {
            if (Value == null || writer == null)
            {
                return false;
            }

            string? json;

            if (Value is ISerializableObject serializableObject && Value is not IValue)
            {
                json = DiGi.Core.Convert.ToSystem_String(serializableObject);
            }
            else
            {
                try
                {
                    json = DiGi.Core.Convert.ToSystem_String(new Value(Value as dynamic));
                }
                catch
                {
                    return false;
                }
            }

            if (json == null)
            {
                return false;
            }

            writer.SetString(typeof(TObject).FullName, json);
            return true;
        }
    }

    public class GooObject : GooObject<object>
    {
        public GooObject()
            : base()
        {
        }

        public GooObject(object? @object)
        {
            Value = @object;
        }

        public override IGH_Goo? Duplicate()
        {
            return new GooObject(Value);
        }
    }

    public class GooObjectParam : GH_PersistentParam<GooObject>
    {
        public GooObjectParam()
            : base(Query.Name(typeof(object)), Query.Name(typeof(object)), typeof(object).FullName?.Replace(".", " "), "Params", Query.Subcategory(typeof(ISerializableObject)))
        {
        }

        public override Guid ComponentGuid => new("2f2f88d8-fe6c-498a-8767-6bf2b18f5566");
        protected override GH_GetterResult Prompt_Plural(ref List<GooObject> values)
        {
            throw new NotImplementedException();
        }

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
        protected override GH_GetterResult Prompt_Singular(ref GooObject value)
        {
            throw new NotImplementedException();
        }
    }
}

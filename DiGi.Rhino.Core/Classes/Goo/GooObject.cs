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
    /// <summary>
    /// A generic wrapper for objects to be used within Grasshopper, providing serialization and casting capabilities.
    /// </summary>
    /// <typeparam name="TObject">The type of the object wrapped by this Goo container.</typeparam>
    public class GooObject<TObject> : GH_Goo<TObject?>, IGooObject<TObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooObject{TObject}"/> class.
        /// </summary>
        public GooObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooObject{TObject}"/> class with a specified value.
        /// </summary>
        /// <param name="object">The object to wrap in this Goo container.</param>
        public GooObject(TObject? @object)
        {
            Value = @object;
        }

        /// <summary>
        /// Gets a value indicating whether the wrapped object is valid (not null).
        /// </summary>
        public override bool IsValid => Value != null;

        /// <summary>
        /// Gets a human-readable description of the type of the wrapped object.
        /// </summary>
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

        /// <summary>
        /// Gets the full name of the type of the wrapped object.
        /// </summary>
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

        /// <summary>
        /// Attempts to cast the specified source object into this Goo container.
        /// </summary>
        /// <param name="source">The source object to cast from.</param>
        /// <returns>True if the casting was successful; otherwise, false.</returns>
        public override bool CastFrom(object? source)
        {
            object? source_Temp = source;
            if (source_Temp is IGH_Goo gH_Goo)
            {
                if (Query.TryGetValue(gH_Goo, out object? value))
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

        /// <summary>
        /// Attempts to cast the wrapped object into the specified target type.
        /// </summary>
        /// <typeparam name="Y">The target type to cast to.</typeparam>
        /// <param name="target">A reference to the target variable where the result will be stored.</param>
        /// <returns>True if the casting was successful; otherwise, false.</returns>
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

            if (Value is Y)
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

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="IGH_Goo"/> containing the same value.</returns>
        public override IGH_Goo? Duplicate()
        {
            return new GooObject<TObject>(Value);
        }

        /// <summary>
        /// Retrieves the wrapped value cast to a more specific type.
        /// </summary>
        /// <typeparam name="XObject">The specific type to retrieve, which must inherit from <typeparamref name="TObject"/>.</typeparam>
        /// <returns>The wrapped value as <typeparamref name="XObject"/> if possible; otherwise, the default value of <typeparamref name="XObject"/>.</returns>
        public XObject? GetValue<XObject>() where XObject : TObject
        {
            return Value is XObject ? (XObject)(object)Value : default;
        }

        /// <summary>
        /// Reads the wrapped object from a Grasshopper reader.
        /// </summary>
        /// <param name="reader">The reader used to deserialize the object.</param>
        /// <returns>True if reading was successful; otherwise, false.</returns>
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

        /// <summary>
        /// Returns a string representation of the wrapped object.
        /// </summary>
        /// <returns>The full name of the type of the wrapped value, or null if the value is null.</returns>
        public override string? ToString()
        {
            if (Value == null)
            {
                return null;
            }

            string? value = Value.GetType()?.FullName;

            return value;
        }

        /// <summary>
        /// Writes the wrapped object to a Grasshopper writer.
        /// </summary>
        /// <param name="writer">The writer used to serialize the object.</param>
        /// <returns>True if writing was successful; otherwise, false.</returns>
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

    /// <summary>
    /// A non-generic version of <see cref="GooObject{TObject}"/> that wraps an object of type <see cref="object"/>.
    /// </summary>
    public class GooObject : GooObject<object>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooObject"/> class.
        /// </summary>
        public GooObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooObject"/> class with a specified value.
        /// </summary>
        /// <param name="object">The object to wrap in this Goo container.</param>
        public GooObject(object? @object)
        {
            Value = @object;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooObject"/> containing the same value.</returns>
        public override IGH_Goo? Duplicate()
        {
            return new GooObject(Value);
        }
    }

    /// <summary>
    /// A Grasshopper persistent parameter for <see cref="GooObject"/>.
    /// </summary>
    public class GooObjectParam : GH_PersistentParam<GooObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooObjectParam"/> class.
        /// </summary>
        public GooObjectParam()
            : base(Query.Name(typeof(object)), Query.Name(typeof(object)), typeof(object).FullName?.Replace(".", " "), "Params", Query.Subcategory(typeof(ISerializableObject)))
        {
        }

        /// <summary>
        /// Gets the unique identifier for this component.
        /// </summary>
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
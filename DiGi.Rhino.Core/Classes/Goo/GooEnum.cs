using DiGi.Core.Interfaces;
using DiGi.Rhino.Core.Interfaces;
using GH_IO.Serialization;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// A generic wrapper for enumeration types to be used within the Grasshopper environment.
    /// </summary>
    /// <typeparam name="T">The type of the enumeration.</typeparam>
    public class GooEnum<T> : GH_Goo<T?>, IGooObject where T : Enum
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooEnum{T}"/> class.
        /// </summary>
        public GooEnum()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooEnum{T}"/> class using an existing <see cref="GooEnum{T}"/>.
        /// </summary>
        /// <param name="gooEnum">The source GooEnum object.</param>
        public GooEnum(GooEnum<T>? gooEnum)
            : base(gooEnum)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooEnum{T}"/> class with a specific enumeration value.
        /// </summary>
        /// <param name="enum">The enumeration value.</param>
        public GooEnum(T? @enum)
            : base(@enum)
        {
        }

        /// <summary>
        /// Gets a value indicating whether the current instance contains a valid value.
        /// </summary>
        public override bool IsValid => Value != null;

        /// <summary>
        /// Gets a description of the type, replacing dots with spaces for readability.
        /// </summary>
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

        /// <summary>
        /// Gets the full name of the type.
        /// </summary>
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

        /// <summary>
        /// Attempts to cast the specified object to a <see cref="GooEnum{T}"/>.
        /// </summary>
        /// <param name="source">The object to cast.</param>
        /// <returns>True if the casting was successful; otherwise, false.</returns>
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

        /// <summary>
        /// Attempts to cast the current value to a specified type.
        /// </summary>
        /// <typeparam name="Y">The target type.</typeparam>
        /// <param name="target">A reference to the target variable where the result will be stored.</param>
        /// <returns>True if the casting was successful; otherwise, false.</returns>
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

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooEnum{T}"/> containing the same value.</returns>
        public override IGH_Goo? Duplicate()
        {
            return new GooEnum<T>(Value);
        }

        /// <summary>
        /// Reads the enumeration value from a serialization reader.
        /// </summary>
        /// <param name="reader">The reader used to deserialize the data.</param>
        /// <returns>True if the read operation was successful; otherwise, false.</returns>
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

        /// <summary>
        /// Returns a string representation of the current enumeration value.
        /// </summary>
        /// <returns>The string representation of the value, or null if no value is present.</returns>
        public override string? ToString()
        {
            if (Value == null)
            {
                return null;
            }

            return Value.ToString();
        }

        /// <summary>
        /// Writes the enumeration value to a serialization writer.
        /// </summary>
        /// <param name="writer">The writer used to serialize the data.</param>
        /// <returns>True if the write operation was successful; otherwise, false.</returns>
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

    /// <summary>
    /// A non-generic wrapper for enumeration types to be used within the Grasshopper environment.
    /// </summary>
    public class GooEnum : GooEnum<Enum>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooEnum"/> class.
        /// </summary>
        public GooEnum()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooEnum"/> class with a specific enumeration value.
        /// </summary>
        /// <param name="enum">The enumeration value.</param>
        public GooEnum(Enum? @enum)
        {
            Value = @enum;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooEnum"/> containing the same value.</returns>
        public override IGH_Goo? Duplicate()
        {
            return new GooEnum(Value);
        }
    }

    /// <summary>
    /// A Grasshopper parameter component for generic enumeration types.
    /// </summary>
    /// <typeparam name="T">The type of the enumeration.</typeparam>
    public class GooEnumParam<T> : GooEnumParam<GooEnum<T>, T> where T : Enum
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooEnumParam{T}"/> class.
        /// </summary>
        public GooEnumParam()
            : base()
        {
        }

        /// <summary>
        /// Gets the unique identifier for this component.
        /// </summary>
        public override Guid ComponentGuid => new("fa4f4af4-3a0d-45d4-be59-bfb65dc350cb");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }

    /// <summary>
    /// A Grasshopper parameter component for general enumeration types.
    /// </summary>
    public class GooEnumParam : GH_PersistentParam<GooEnum>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooEnumParam"/> class.
        /// </summary>
        public GooEnumParam()
            : base(Query.Name(typeof(Enum)), Query.Name(typeof(Enum)), typeof(Enum).FullName?.Replace(".", " "), "Params", Query.Subcategory(typeof(IObject)))
        {
        }

        /// <summary>
        /// Gets the unique identifier for this component.
        /// </summary>
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
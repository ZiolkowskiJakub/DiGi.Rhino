using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Core
{
    public static partial class Create
    {
        /// <summary>
        /// Converts a given value to its corresponding Grasshopper Goo representation based on the specified parameter type.
        /// </summary>
        /// <param name="parameterType">The type of parameter used to determine which GH_Goo implementation to create.</param>
        /// <param name="value">The object value to be converted into a Goo object.</param>
        /// <returns>An <see cref="IGH_Goo"/> instance wrapping the value, or <c>null</c> if the conversion fails or the value is null.</returns>
        /// <exception cref="NotImplementedException">Thrown when the provided <paramref name="parameterType"/> is not supported.</exception>
        public static IGH_Goo? GH_Goo(this ParameterType parameterType, object? value)
        {
            if (value == null)
            {
                return null;
            }

            switch (parameterType)
            {
                case ParameterType.Color:
                    {
                        if (DiGi.Core.Query.TryConvert(value, out System.Drawing.Color color))
                        {
                            return new GH_Colour(color);
                        }
                    }
                    break;

                case ParameterType.Boolean:
                    {
                        if (DiGi.Core.Query.TryConvert(value, out bool @bool))
                        {
                            return new GH_Boolean(@bool);
                        }
                    }
                    break;

                case ParameterType.Object:
                    {
                        if (value is ISerializableObject)
                        {
                            if (DiGi.Core.Query.TryConvert(value, out ISerializableObject? serializableObject))
                            {
                                return new GooSerializableObject(serializableObject);
                            }
                        }
                        else
                        {
                            return new GH_ObjectWrapper(value);
                        }
                    }
                    break;

                case ParameterType.DateTime:
                    {
                        if (DiGi.Core.Query.TryConvert(value, out DateTime dateTime))
                        {
                            return new GH_Time(dateTime);
                        }
                    }
                    break;

                case ParameterType.Double:
                    {
                        if (DiGi.Core.Query.TryConvert(value, out double @double))
                        {
                            return new GH_Number(@double);
                        }
                    }
                    break;

                case ParameterType.Guid:
                    {
                        if (DiGi.Core.Query.TryConvert(value, out Guid guid))
                        {
                            return new GH_Guid(guid);
                        }
                    }
                    break;

                case ParameterType.Integer:
                    {
                        if (DiGi.Core.Query.TryConvert(value, out int @int))
                        {
                            return new GH_Integer(@int);
                        }
                    }
                    break;

                case ParameterType.String:
                    {
                        if (DiGi.Core.Query.TryConvert(value, out string? @string))
                        {
                            return new GH_String(@string);
                        }
                    }
                    break;

                case ParameterType.Undefined:
                    {
                        return new GH_ObjectWrapper(value);
                    }

                default:
                    {
                        throw new NotImplementedException();
                    }
            }

            return null;
        }
    }
}
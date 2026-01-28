using DiGi.Core.Interfaces;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;

namespace DiGi.Rhino.Core
{
    public static partial class Query
    {
        public static List<T>? SerializableObjects<T>(this Grasshopper.Kernel.Data.IGH_Structure? gH_Structure) where T : ISerializableObject
        {
            if (gH_Structure == null)
            {
                return null;
            }

            List<T> result = [];
            foreach (IGH_Goo goo in gH_Structure.AllData(true))
            {
                if (goo == null)
                {
                    continue;
                }

                ISerializableObject? serializableObject;
                try
                {
                    serializableObject = (goo as dynamic).Value as ISerializableObject;
                }
                catch
                {
                    serializableObject = null;
                }

                if (serializableObject is not T)
                {
                    continue;
                }

                result.Add((T)serializableObject);
            }

            return result;
        }
    }
}
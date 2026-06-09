using DiGi.Core.Interfaces;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;

namespace DiGi.Rhino.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts a list of serializable objects of a specific type from a Grasshopper structure.
        /// </summary>
        /// <typeparam name="T">The type of serializable object to extract. Must implement <see cref="ISerializableObject"/>.</typeparam>
        /// <param name="gH_Structure">The Grasshopper structure to query for serializable objects.</param>
        /// <returns>A list containing the found objects of type <typeparamref name="T"/>, or <c>null</c> if the provided structure is null.</returns>
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
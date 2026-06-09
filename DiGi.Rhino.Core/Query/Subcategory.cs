using DiGi.Rhino.Core.Classes;
using Grasshopper;
using Grasshopper.Kernel;

namespace DiGi.Rhino.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Creates a duplicate of the specified Grasshopper parameter, ensuring it has a new instance GUID 
        /// and updating its nickname based on the central settings if applicable.
        /// </summary>
        /// <param name="param">The Grasshopper parameter to clone.</param>
        /// <returns>A new instance of the cloned <see cref="IGH_Param"/>.</returns>
        public static IGH_Param Clone(this IGH_Param param)
        {
            var attributes = param.Attributes;
            try
            {
                param.Attributes = new NullAttributes();
                IGH_Param newParam = GH_ComponentParamServer.CreateDuplicate(param);

                newParam.NewInstanceGuid();

                if (newParam.MutableNickName && CentralSettings.CanvasFullNames)
                {
                    newParam.NickName = newParam.Name;
                }

                return newParam;
            }
            finally
            {
                param.Attributes = attributes;
            }
        }
    }
}
using Grasshopper.Kernel;
using Grasshopper;
using DiGi.Rhino.Core.Classes;

namespace DiGi.Rhino.Core
{
    public static partial class Query
    {
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

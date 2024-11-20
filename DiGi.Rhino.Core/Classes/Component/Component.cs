using Grasshopper.Kernel;

namespace DiGi.Rhino.Core.Classes
{
    public abstract class Component : GH_Component
    {
        public Component(string name, string nickname, string description, string category, string subCategory)
          : base(name, nickname, description, category, subCategory)
        {
        }
    }
}

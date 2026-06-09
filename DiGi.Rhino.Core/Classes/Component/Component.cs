using Grasshopper.Kernel;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// Provides a base abstract class for custom Grasshopper components, extending the standard GH_Component functionality.
    /// </summary>
    public abstract class Component : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Component"/> class with specified identification and categorization details.
        /// </summary>
        /// <param name="name">The full name of the component.</param>
        /// <param name="nickname">The short name displayed on the Grasshopper canvas.</param>
        /// <param name="description">A detailed description of the component's functionality.</param>
        /// <param name="category">The primary category in the Grasshopper menu where this component is located.</param>
        /// <param name="subCategory">The sub-category within the primary category for further organization.</param>
        public Component(string name, string nickname, string description, string category, string subCategory)
          : base(name, nickname, description, category, subCategory)
        {
        }
    }
}
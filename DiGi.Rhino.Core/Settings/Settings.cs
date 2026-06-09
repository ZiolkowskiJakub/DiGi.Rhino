using DiGi.Rhino.Core.Classes;

namespace DiGi.Rhino.Core
{
    public static partial class Settings
    {
        /// <summary>
        /// Gets the global instance of the <see cref="InspectManager"/>.
        /// </summary>
        public static InspectManager InspectManager { get; } = new InspectManager();
    }
}
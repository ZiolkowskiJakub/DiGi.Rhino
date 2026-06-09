using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for geographic coordinates.
    /// </summary>
    public class GooCoordinates : GooSerializableObject<Core.Classes.Coordinates>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooCoordinates"/> class.
        /// </summary>
        public GooCoordinates()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooCoordinates"/> class with the specified coordinates.
        /// </summary>
        /// <param name="coordinates">The geographic coordinates to wrap.</param>
        public GooCoordinates(Core.Classes.Coordinates? coordinates)
            : base()
        {
            Value = coordinates;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing the same coordinate value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooCoordinates(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter for geographic coordinates.
    /// </summary>
    public class GooCoordinatesParam : GooSerializablePresistentParam<GooCoordinates, Core.Classes.Coordinates>
    {
        /// <summary>
        /// Gets the unique identifier for the coordinate component.
        /// </summary>
        /// <value>The <see cref="Guid"/> associated with this parameter type.</value>
        public override Guid ComponentGuid => new("1dedddb6-0ea6-42a3-ba70-dafec74e9bee");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooCoordinatesParam"/> class.
        /// </summary>
        public GooCoordinatesParam()
            : base()
        {
        }
    }
}
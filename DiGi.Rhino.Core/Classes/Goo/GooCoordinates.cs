using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class GooCoordinates : GooSerializableObject<Core.Classes.Coordinates>
    {
        public GooCoordinates()
            : base()
        {
        }

        public GooCoordinates(Core.Classes.Coordinates coordinates)
            : base()
        {
            Value = coordinates;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooCoordinates(Value);
        }

    }

    public class GooCoordinatesParam : GooPresistentParam<GooCoordinates, Core.Classes.Coordinates>
    {
        public override Guid ComponentGuid => new Guid("1dedddb6-0ea6-42a3-ba70-dafec74e9bee");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooCoordinatesParam()
            : base()
        {
        }
    }
}


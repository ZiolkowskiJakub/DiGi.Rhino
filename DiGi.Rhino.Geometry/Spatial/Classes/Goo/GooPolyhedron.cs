using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Rhino.Geometry.Spatial.Classes
{
    public class GooPolyhedron : GooGeometry3D<Polyhedron>
    {
        public GooPolyhedron()
            : base()
        {
        }

        public GooPolyhedron(Polyhedron polyhedron)
        {
            Value = polyhedron;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooPolyhedron(Value);
        }

    }

    public class GooPolyhedronParam : GooGeometryParam<Polyhedron>
    {
        public override Guid ComponentGuid => new Guid("e125980f-b14a-4f02-9910-55c2d093e13c");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooPolyhedronParam()
            : base()
        {
        }
    }
}


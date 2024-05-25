using Grasshopper.Kernel.Types;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DiGi.Rhino.Core.Interfaces;
using DiGi.Core.Interfaces;
using GH_IO.Serialization;

namespace DiGi.Rhino.Core.Classes
{
    public class GooSerializableObject<T> : GH_Goo<T>, IGooSerializableObject where T : ISerializableObject
    {
        public GooSerializableObject()
            : base()
        {
        }

        public GooSerializableObject(T sAMObject)
        {
            Value = sAMObject;
        }

        public override bool IsValid => Value != null;

        public override string TypeName
        {
            get
            {
                if (Value == null)
                {
                    return typeof(T).FullName;
                }

                return Value.GetType().FullName;
            }
        }

        public override string TypeDescription
        {
            get
            {
                if (Value == null)
                {
                    return typeof(T).FullName.Replace(".", " ");
                }

                return Value.GetType().FullName.Replace(".", " ");
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooSerializableObject<T>(Value);
        }

        public override bool Write(GH_IWriter writer)
        {
            if (Value == null || writer == null)
            {
                return false;
            }

            string json = DiGi.Core.Convert.ToString(Value);
            if (json == null)
            {
                return false;
            }

            writer.SetString(typeof(T).FullName, json);
            return true;
        }

        public override bool Read(GH_IReader reader)
        {
            if(reader == null)
            {
                return false;
            }

            string json = null;
            if (!reader.TryGetString(typeof(T).FullName, ref json))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(json))
            {
                Value = default;
                return true;
            }

            List<T> values = DiGi.Core.Convert.ToDiGi<T>(json);
            if (values == null || values.Count == 0)
            {
                Value = default;
                return true;
            }

            Value = values[0];
            return true;
        }

        public X GetValue<X>() where X : ISerializableObject
        {
            return Value is X ? (X)(object)Value : default;
        }

        public override string ToString()
        {
            if (Value == null)
            {
                return null;
            }

            string value = Value.GetType().FullName;

            return value;
        }

        public override bool CastFrom(object source)
        {
            if (source == null)
            {
                return false;
            }

            if (source is T)
            {
                Value = (T)(object)source;
                return true;
            }

            Type type_Source = source?.GetType();
            if (type_Source != null)
            {
                if (typeof(IGooSerializableObject).IsAssignableFrom(type_Source))
                {
                    ISerializableObject serializableObject = ((IGooSerializableObject)source).GetValue<ISerializableObject>();
                    if (serializableObject is T)
                    {
                        Value = (T)serializableObject;
                    }

                    return true;
                }

                if (typeof(IGH_Goo).IsAssignableFrom(type_Source))
                {
                    object @object = (source as dynamic).Value;
                    if (@object is T)
                    {
                        Value = (T)@object;
                        return true;
                    }
                }
            }

            return base.CastFrom(source);
        }

        public override bool CastTo<Y>(ref Y target)
        {
            if (typeof(Y) == typeof(T))
            {
                target = (Y)(object)Value;
                return true;
            }

            if (typeof(Y) == typeof(object))
            {
                target = (Y)(object)Value;
                return true;
            }

            if (typeof(GH_ObjectWrapper) == typeof(Y))
            {
                target = (Y)(object)(new GH_ObjectWrapper(Value));
                return true;
            }

            try
            {
                if (Value != null)
                {
                    if (typeof(Y).IsAssignableFrom(Value.GetType()))
                    {
                        target = (Y)(object)Value.Clone();
                    }
                    else
                    {
                        target = DiGi.Core.Create.Object<Y>(Value);
                    }

                    if (target != null)
                    {
                        return true;
                    }
                }
            }
            catch
            {

            }

            return base.CastTo(ref target);
        }
    }

    public class GooSerializableObjectParam<T> : GooPresistentParam<GooSerializableObject<T>, T> where T : ISerializableObject
    {
        public override Guid ComponentGuid => new Guid("bb4a37e5-b901-422a-89b5-19b8e5463724");
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooSerializableObjectParam()
            : base()
        {
        }

        protected override GH_GetterResult Prompt_Plural(ref List<GooSerializableObject<T>> values)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Singular(ref GooSerializableObject<T> value)
        {
            throw new NotImplementedException();
        }

        public override void AppendAdditionalMenuItems(ToolStripDropDown menu)
        {
            Menu_AppendItem(menu, "Save As...", Menu_SaveAs, VolatileData.AllData(true).Any());

            //Menu_AppendSeparator(menu);

            base.AppendAdditionalMenuItems(menu);
        }

        private void Menu_SaveAs(object sender, EventArgs e)
        {
            Query.SaveAs(VolatileData);
        }
    }

    public class GooSerializableObject : GooSerializableObject<ISerializableObject>
    {
        public GooSerializableObject()
            : base()
        {
        }

        public GooSerializableObject(ISerializableObject serializableObject)
        {
            Value = serializableObject;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooSerializableObject(Value);
        }
    }

    public class GooSerializableObjectParam : GH_PersistentParam<GooSerializableObject>
    {
        public override Guid ComponentGuid => new Guid("a557ef4b-4fa1-47a4-a5cc-894c03f057e7");
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooSerializableObjectParam()
            : base(typeof(ISerializableObject).Name, typeof(ISerializableObject).Name, typeof(ISerializableObject).FullName.Replace(".", " "), "Params", "DiGi")
        {
        }

        protected override GH_GetterResult Prompt_Singular(ref GooSerializableObject value)
        {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Plural(ref List<GooSerializableObject> values)
        {
            throw new NotImplementedException();
        }
    }
}

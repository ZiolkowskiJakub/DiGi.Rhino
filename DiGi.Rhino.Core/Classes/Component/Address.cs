using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    public class Address : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new ("7fc32700-de9c-498b-9b6a-bfdf3bdd1ea1");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of object.
        /// </summary>
        public Address()
          : base("Core.Address", "Core.Address",
              "Create Address",
              "DiGi", "DiGi.Core")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override Param[] Inputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new Grasshopper.Kernel.Parameters.Param_String() { Name = "Street", NickName = "Street", Description = "Street", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new Grasshopper.Kernel.Parameters.Param_String() { Name = "City", NickName = "City", Description = "City", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new Grasshopper.Kernel.Parameters.Param_String() { Name = "PostalCode", NickName = "PostalCode", Description = "PostalCode", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new GooEnumParam() { Name = "CountryCode", NickName = "CountryCode", Description = "CountryCode", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];

                
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new GooAddressParam() { Name = "Address", NickName = "Address", Description = "Address", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="dataAccess">
        /// The DA object is used to retrieve from inputs and store in outputs.
        /// </param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            int index;

            index = Params.IndexOfInputParam("Street");
            string? street = null;
            if (index == -1 || !dataAccess.GetData(index, ref street))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("City");
            string? city = null;
            if (index == -1 || !dataAccess.GetData(index, ref city))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("PostalCode");
            string? postalCode = null;
            if (index == -1 || !dataAccess.GetData(index, ref postalCode))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("CountryCode");
            DiGi.Core.Enums.CountryCode countryCode = DiGi.Core.Enums.CountryCode.Undefined;
            if (index == -1 || !dataAccess.GetData(index, ref countryCode))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            DiGi.Core.Classes.Address address = new (street, city, postalCode, countryCode);

            index = Params.IndexOfOutputParam("Address");
            if (index != -1)
            {
                dataAccess.SetData(index, new GooAddress(address));
            }
        }
    }
}
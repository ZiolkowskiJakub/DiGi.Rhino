using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Rhino.Core.Classes
{
    /// <summary>
    /// A Grasshopper component that creates a <see cref="DiGi.Core.Classes.Address"/> object
    /// based on street, city, postal code, and country code inputs.
    /// </summary>
    public class Address : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique identifier for this Grasshopper component.
        /// </summary>
        public override Guid ComponentGuid => new("7fc32700-de9c-498b-9b6a-bfdf3bdd1ea1");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Gets the exposure level of the component in the Grasshopper toolbar.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> component.
        /// </summary>
        public Address()
          : base("Core.Address", "Core.Address",
              "Create Address",
              "DiGi", "DiGi.Core")
        {
        }

        /// <summary>
        /// Gets the input parameters for this component.
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
        /// Gets the output parameters for this component.
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
        /// Executes the main logic of the component, reading input data and producing an <see cref="DiGi.Core.Classes.Address"/> output.
        /// </summary>
        /// <param name="dataAccess">The data access object used to retrieve inputs and set outputs.</param>
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

            DiGi.Core.Classes.Address address = new(street, city, postalCode, countryCode);

            index = Params.IndexOfOutputParam("Address");
            if (index != -1)
            {
                dataAccess.SetData(index, new GooAddress(address));
            }
        }
    }
}
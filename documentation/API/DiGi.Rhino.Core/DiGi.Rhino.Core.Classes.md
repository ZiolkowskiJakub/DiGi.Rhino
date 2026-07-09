#### [DiGi\.Rhino\.Core](DiGi.Rhino.Core.Overview.md 'DiGi\.Rhino\.Core\.Overview')

## DiGi\.Rhino\.Core\.Classes Namespace
### Classes

<a name='DiGi.Rhino.Core.Classes.Address'></a>

## Address Class

A Grasshopper component that creates a [DiGi\.Core\.Classes\.Address](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.address 'DiGi\.Core\.Classes\.Address') object
based on street, city, postal code, and country code inputs\.

```csharp
public class Address : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Address
### Constructors

<a name='DiGi.Rhino.Core.Classes.Address.Address()'></a>

## Address\(\) Constructor

Initializes a new instance of the [Address](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Address 'DiGi\.Rhino\.Core\.Classes\.Address') component\.

```csharp
public Address();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.Address.ComponentGuid'></a>

## Address\.ComponentGuid Property

Gets the unique identifier for this Grasshopper component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.Address.Exposure'></a>

## Address\.Exposure Property

Gets the exposure level of the component in the Grasshopper toolbar\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.Address.Inputs'></a>

## Address\.Inputs Property

Gets the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.Address.Outputs'></a>

## Address\.Outputs Property

Gets the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.Address.SolveInstance(IGH_DataAccess)'></a>

## Address\.SolveInstance\(IGH\_DataAccess\) Method

Executes the main logic of the component, reading input data and producing an [DiGi\.Core\.Classes\.Address](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.address 'DiGi\.Core\.Classes\.Address') output\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.Address.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The data access object used to retrieve inputs and set outputs\.

<a name='DiGi.Rhino.Core.Classes.Component'></a>

## Component Class

Provides a base abstract class for custom Grasshopper components, extending the standard GH\_Component functionality\.

```csharp
public abstract class Component
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → Component

Derived  
↳ [ElementLogicalFilter](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.ElementLogicalFilter 'DiGi\.Rhino\.Core\.Classes\.ElementLogicalFilter')  
↳ [Inspect](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Inspect 'DiGi\.Rhino\.Core\.Classes\.Inspect')  
↳ [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent')
### Constructors

<a name='DiGi.Rhino.Core.Classes.Component.Component(string,string,string,string,string)'></a>

## Component\(string, string, string, string, string\) Constructor

Initializes a new instance of the [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') class with specified identification and categorization details\.

```csharp
public Component(string name, string nickname, string description, string category, string subCategory);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.Component.Component(string,string,string,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full name of the component\.

<a name='DiGi.Rhino.Core.Classes.Component.Component(string,string,string,string,string).nickname'></a>

`nickname` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The short name displayed on the Grasshopper canvas\.

<a name='DiGi.Rhino.Core.Classes.Component.Component(string,string,string,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A detailed description of the component's functionality\.

<a name='DiGi.Rhino.Core.Classes.Component.Component(string,string,string,string,string).category'></a>

`category` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The primary category in the Grasshopper menu where this component is located\.

<a name='DiGi.Rhino.Core.Classes.Component.Component(string,string,string,string,string).subCategory'></a>

`subCategory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The sub\-category within the primary category for further organization\.

<a name='DiGi.Rhino.Core.Classes.Coordinates'></a>

## Coordinates Class

Represents a Grasshopper component that creates geographic coordinates from latitude and longitude inputs\.

```csharp
public class Coordinates : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Coordinates
### Constructors

<a name='DiGi.Rhino.Core.Classes.Coordinates.Coordinates()'></a>

## Coordinates\(\) Constructor

Initializes a new instance of the [Coordinates](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Coordinates 'DiGi\.Rhino\.Core\.Classes\.Coordinates') class\.

```csharp
public Coordinates();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.Coordinates.ComponentGuid'></a>

## Coordinates\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.Coordinates.Exposure'></a>

## Coordinates\.Exposure Property

Gets the exposure level of the component, determining when it is executed\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.Coordinates.Inputs'></a>

## Coordinates\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.Coordinates.Outputs'></a>

## Coordinates\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.Coordinates.SolveInstance(IGH_DataAccess)'></a>

## Coordinates\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work, processing input latitude and longitude to produce a coordinates object\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.Coordinates.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object used to retrieve data from inputs and store results in outputs\.

<a name='DiGi.Rhino.Core.Classes.CountryCode'></a>

## CountryCode Class

Represents the country code component used for ISO country identification within the system\.

```csharp
public class CountryCode : DiGi.Rhino.Core.Classes.EnumComponent<DiGi.Core.Enums.CountryCode>
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.EnumComponent&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.EnumComponent_T_ 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\<T\>')[DiGi\.Core\.Enums\.CountryCode](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.countrycode 'DiGi\.Core\.Enums\.CountryCode')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.EnumComponent_T_ 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\<T\>') → CountryCode
### Constructors

<a name='DiGi.Rhino.Core.Classes.CountryCode.CountryCode()'></a>

## CountryCode\(\) Constructor

Initializes a new instance of the [CountryCode](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.CountryCode 'DiGi\.Rhino\.Core\.Classes\.CountryCode') class\.

```csharp
public CountryCode();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.CountryCode.ComponentGuid'></a>

## CountryCode\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.Deserialize'></a>

## Deserialize Class

A Grasshopper component that deserializes JSON strings into a list of serializable objects\.

```csharp
public class Deserialize : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Deserialize
### Constructors

<a name='DiGi.Rhino.Core.Classes.Deserialize.Deserialize()'></a>

## Deserialize\(\) Constructor

Initializes a new instance of object\.

```csharp
public Deserialize();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.Deserialize.ComponentGuid'></a>

## Deserialize\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.Deserialize.Exposure'></a>

## Deserialize\.Exposure Property

Gets the exposure level of the component, which determines how it is displayed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.Deserialize.Inputs'></a>

## Deserialize\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.Deserialize.Outputs'></a>

## Deserialize\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.Deserialize.SolveInstance(IGH_DataAccess)'></a>

## Deserialize\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.Deserialize.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalAndFilter'></a>

## ElementLogicalAndFilter Class

Implementation of a logical AND filter that combines multiple input filters into a single output string\.

```csharp
public class ElementLogicalAndFilter : DiGi.Rhino.Core.Classes.ElementLogicalFilter
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [ElementLogicalFilter](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.ElementLogicalFilter 'DiGi\.Rhino\.Core\.Classes\.ElementLogicalFilter') → ElementLogicalAndFilter
### Constructors

<a name='DiGi.Rhino.Core.Classes.ElementLogicalAndFilter.ElementLogicalAndFilter()'></a>

## ElementLogicalAndFilter\(\) Constructor

Initializes a new instance of the [ElementLogicalAndFilter](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.ElementLogicalAndFilter 'DiGi\.Rhino\.Core\.Classes\.ElementLogicalAndFilter') class\.

```csharp
public ElementLogicalAndFilter();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.ElementLogicalAndFilter.ComponentGuid'></a>

## ElementLogicalAndFilter\.ComponentGuid Property

Gets the unique identifier for this component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.ElementLogicalAndFilter.Exposure'></a>

## ElementLogicalAndFilter\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter'></a>

## ElementLogicalFilter Class

Base abstract class for logical filter components that support a variable number of input parameters\.

```csharp
public abstract class ElementLogicalFilter : DiGi.Rhino.Core.Classes.Component
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → ElementLogicalFilter

Derived  
↳ [ElementLogicalAndFilter](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.ElementLogicalAndFilter 'DiGi\.Rhino\.Core\.Classes\.ElementLogicalAndFilter')
### Constructors

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.ElementLogicalFilter(string,string,string,string,string)'></a>

## ElementLogicalFilter\(string, string, string, string, string\) Constructor

Initializes a new instance of the [ElementLogicalFilter](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.ElementLogicalFilter 'DiGi\.Rhino\.Core\.Classes\.ElementLogicalFilter') class\.

```csharp
protected ElementLogicalFilter(string name, string nickname, string description, string category, string subCategory);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.ElementLogicalFilter(string,string,string,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full name of the component\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.ElementLogicalFilter(string,string,string,string,string).nickname'></a>

`nickname` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The short nickname of the component\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.ElementLogicalFilter(string,string,string,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A description of what the component does\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.ElementLogicalFilter(string,string,string,string,string).category'></a>

`category` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The category in the Grasshopper menu\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.ElementLogicalFilter(string,string,string,string,string).subCategory'></a>

`subCategory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The sub\-category in the Grasshopper menu\.
### Methods

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.AddedToDocument(GH_Document)'></a>

## ElementLogicalFilter\.AddedToDocument\(GH\_Document\) Method

Called when the component is added to a Grasshopper document\.

```csharp
public override void AddedToDocument(GH_Document document);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.AddedToDocument(GH_Document).document'></a>

`document` [Grasshopper\.Kernel\.GH\_Document](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_document 'Grasshopper\.Kernel\.GH\_Document')

The document the component is being added to\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.CanInsertParameter(GH_ParameterSide,int)'></a>

## ElementLogicalFilter\.CanInsertParameter\(GH\_ParameterSide, int\) Method

Determines whether a parameter can be inserted at the specified side and index\.

```csharp
public bool CanInsertParameter(GH_ParameterSide side, int index);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.CanInsertParameter(GH_ParameterSide,int).side'></a>

`side` [Grasshopper\.Kernel\.GH\_ParameterSide](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_parameterside 'Grasshopper\.Kernel\.GH\_ParameterSide')

The side of the component where the parameter would be inserted\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.CanInsertParameter(GH_ParameterSide,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the parameter\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the parameter can be inserted; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.CanRemoveParameter(GH_ParameterSide,int)'></a>

## ElementLogicalFilter\.CanRemoveParameter\(GH\_ParameterSide, int\) Method

Determines whether a parameter can be removed from the specified side and index\.

```csharp
public bool CanRemoveParameter(GH_ParameterSide side, int index);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.CanRemoveParameter(GH_ParameterSide,int).side'></a>

`side` [Grasshopper\.Kernel\.GH\_ParameterSide](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_parameterside 'Grasshopper\.Kernel\.GH\_ParameterSide')

The side of the component where the parameter would be removed\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.CanRemoveParameter(GH_ParameterSide,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the parameter\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the parameter can be removed; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.CreateParameter(GH_ParameterSide,int)'></a>

## ElementLogicalFilter\.CreateParameter\(GH\_ParameterSide, int\) Method

Creates a new parameter for the specified side and index\.

```csharp
public IGH_Param? CreateParameter(GH_ParameterSide side, int index);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.CreateParameter(GH_ParameterSide,int).side'></a>

`side` [Grasshopper\.Kernel\.GH\_ParameterSide](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_parameterside 'Grasshopper\.Kernel\.GH\_ParameterSide')

The side of the component where the parameter is created\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.CreateParameter(GH_ParameterSide,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the parameter\.

#### Returns
[Grasshopper\.Kernel\.IGH\_Param](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_param 'Grasshopper\.Kernel\.IGH\_Param')  
The newly created [Grasshopper\.Kernel\.IGH\_Param](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_param 'Grasshopper\.Kernel\.IGH\_Param'), or `null` if creation is not possible\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.DestroyParameter(GH_ParameterSide,int)'></a>

## ElementLogicalFilter\.DestroyParameter\(GH\_ParameterSide, int\) Method

Destroys the parameter at the specified side and index\.

```csharp
public bool DestroyParameter(GH_ParameterSide side, int index);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.DestroyParameter(GH_ParameterSide,int).side'></a>

`side` [Grasshopper\.Kernel\.GH\_ParameterSide](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_parameterside 'Grasshopper\.Kernel\.GH\_ParameterSide')

The side of the component where the parameter is located\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.DestroyParameter(GH_ParameterSide,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the parameter\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the parameter was successfully destroyed; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.RemovedFromDocument(GH_Document)'></a>

## ElementLogicalFilter\.RemovedFromDocument\(GH\_Document\) Method

Called when the component is removed from a Grasshopper document\.

```csharp
public override void RemovedFromDocument(GH_Document document);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.RemovedFromDocument(GH_Document).document'></a>

`document` [Grasshopper\.Kernel\.GH\_Document](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_document 'Grasshopper\.Kernel\.GH\_Document')

The document the component is being removed from\.

<a name='DiGi.Rhino.Core.Classes.ElementLogicalFilter.VariableParameterMaintenance()'></a>

## ElementLogicalFilter\.VariableParameterMaintenance\(\) Method

Performs maintenance on variable parameters to ensure consistency\.

```csharp
public void VariableParameterMaintenance();
```

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_'></a>

## EnumComponent\<T\> Class

An abstract base class for Grasshopper components that manage a value of a specific enumeration type\.

```csharp
public abstract class EnumComponent<T>
    where T : System.Enum
```
#### Type parameters

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.T'></a>

`T`

The enumeration type used by the component\.

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → EnumComponent\<T\>

Derived  
↳ [CountryCode](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.CountryCode 'DiGi\.Rhino\.Core\.Classes\.CountryCode')  
↳ [NumberComparisonType](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.NumberComparisonType 'DiGi\.Rhino\.Core\.Classes\.NumberComparisonType')  
↳ [TextComparisonType](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.TextComparisonType 'DiGi\.Rhino\.Core\.Classes\.TextComparisonType')  
↳ [UTC](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.UTC 'DiGi\.Rhino\.Core\.Classes\.UTC')
### Constructors

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.EnumComponent(string)'></a>

## EnumComponent\(string\) Constructor

Initializes a new instance of the [EnumComponent&lt;T&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.EnumComponent_T_ 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\<T\>') class using a prefix to automatically generate metadata\.

```csharp
public EnumComponent(string prefix);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.EnumComponent(string).prefix'></a>

`prefix` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The prefix used to construct the component's identity and category path\.

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.EnumComponent(string,string,string,string,string)'></a>

## EnumComponent\(string, string, string, string, string\) Constructor

Initializes a new instance of the [EnumComponent&lt;T&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.EnumComponent_T_ 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\<T\>') class with specified metadata\.

```csharp
public EnumComponent(string name, string nickname, string description, string category, string subCategory);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.EnumComponent(string,string,string,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full name of the component\.

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.EnumComponent(string,string,string,string,string).nickname'></a>

`nickname` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The short nickname of the component\.

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.EnumComponent(string,string,string,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A detailed description of the component's functionality\.

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.EnumComponent(string,string,string,string,string).category'></a>

`category` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The primary category in the Grasshopper menu\.

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.EnumComponent(string,string,string,string,string).subCategory'></a>

`subCategory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The sub\-category in the Grasshopper menu\.
### Methods

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.AppendAdditionalComponentMenuItems(System.Windows.Forms.ToolStripDropDown)'></a>

## EnumComponent\<T\>\.AppendAdditionalComponentMenuItems\(ToolStripDropDown\) Method

Appends the enumeration values of type [T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.EnumComponent_T_.T 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\<T\>\.T') as selectable items in the component's context menu\.

```csharp
protected override void AppendAdditionalComponentMenuItems(System.Windows.Forms.ToolStripDropDown menu);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.AppendAdditionalComponentMenuItems(System.Windows.Forms.ToolStripDropDown).menu'></a>

`menu` [System\.Windows\.Forms\.ToolStripDropDown](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.toolstripdropdown 'System\.Windows\.Forms\.ToolStripDropDown')

The drop\-down menu to which the items are appended\.

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.Read(GH_IReader)'></a>

## EnumComponent\<T\>\.Read\(GH\_IReader\) Method

Reads the serialized state of the component from the provided reader\.

```csharp
public override bool Read(GH_IReader reader);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.Read(GH_IReader).reader'></a>

`reader` [GH\_IO\.Serialization\.GH\_IReader](https://learn.microsoft.com/en-us/dotnet/api/gh_io.serialization.gh_ireader 'GH\_IO\.Serialization\.GH\_IReader')

The reader used to retrieve stored data\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the read operation was successful; otherwise, false\.

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.RegisterInputParams(GH_InputParamManager)'></a>

## EnumComponent\<T\>\.RegisterInputParams\(GH\_InputParamManager\) Method

Registers all the input parameters for this component\.

```csharp
protected override void RegisterInputParams(GH_InputParamManager inputParamManager);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.RegisterInputParams(GH_InputParamManager).inputParamManager'></a>

`inputParamManager` [Grasshopper\.Kernel\.GH\_Component\.GH\_InputParamManager](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component.gh_inputparammanager 'Grasshopper\.Kernel\.GH\_Component\.GH\_InputParamManager')

The manager used to register input parameters\.

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.RegisterOutputParams(GH_OutputParamManager)'></a>

## EnumComponent\<T\>\.RegisterOutputParams\(GH\_OutputParamManager\) Method

Registers all the output parameters for this component\.

```csharp
protected override void RegisterOutputParams(GH_OutputParamManager outputParamManager);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.RegisterOutputParams(GH_OutputParamManager).outputParamManager'></a>

`outputParamManager` [Grasshopper\.Kernel\.GH\_Component\.GH\_OutputParamManager](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component.gh_outputparammanager 'Grasshopper\.Kernel\.GH\_Component\.GH\_OutputParamManager')

The manager used to register output parameters\.

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.SolveInstance(IGH_DataAccess)'></a>

## EnumComponent\<T\>\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.Write(GH_IWriter)'></a>

## EnumComponent\<T\>\.Write\(GH\_IWriter\) Method

Writes the current state of the component to the provided writer for serialization\.

```csharp
public override bool Write(GH_IWriter writer);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.EnumComponent_T_.Write(GH_IWriter).writer'></a>

`writer` [GH\_IO\.Serialization\.GH\_IWriter](https://learn.microsoft.com/en-us/dotnet/api/gh_io.serialization.gh_iwriter 'GH\_IO\.Serialization\.GH\_IWriter')

The writer used to store data\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the write operation was successful; otherwise, false\.

<a name='DiGi.Rhino.Core.Classes.FilterByMask'></a>

## FilterByMask Class

A component that filters a list of serializable objects based on a provided boolean mask\.

```csharp
public class FilterByMask : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → FilterByMask
### Constructors

<a name='DiGi.Rhino.Core.Classes.FilterByMask.FilterByMask()'></a>

## FilterByMask\(\) Constructor

Initializes a new instance of the [FilterByMask](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.FilterByMask 'DiGi\.Rhino\.Core\.Classes\.FilterByMask') class\.

```csharp
public FilterByMask();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.FilterByMask.ComponentGuid'></a>

## FilterByMask\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.FilterByMask.Exposure'></a>

## FilterByMask\.Exposure Property

Gets the exposure level of the component, which determines its visibility and behavior in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.FilterByMask.Inputs'></a>

## FilterByMask\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.FilterByMask.Outputs'></a>

## FilterByMask\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.FilterByMask.SolveInstance(IGH_DataAccess)'></a>

## FilterByMask\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work, filtering the input list based on the provided boolean mask\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.FilterByMask.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object used to retrieve data from inputs and store results in outputs\.

<a name='DiGi.Rhino.Core.Classes.FilterByNumber'></a>

## FilterByNumber Class

A component that filters a list of serializable objects based on the value of a specified numeric property\.

```csharp
public class FilterByNumber : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → FilterByNumber
### Constructors

<a name='DiGi.Rhino.Core.Classes.FilterByNumber.FilterByNumber()'></a>

## FilterByNumber\(\) Constructor

Initializes a new instance of the [FilterByNumber](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.FilterByNumber 'DiGi\.Rhino\.Core\.Classes\.FilterByNumber') class\.

```csharp
public FilterByNumber();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.FilterByNumber.ComponentGuid'></a>

## FilterByNumber\.ComponentGuid Property

Gets the unique identifier for this component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.FilterByNumber.Exposure'></a>

## FilterByNumber\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.FilterByNumber.Inputs'></a>

## FilterByNumber\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.FilterByNumber.Outputs'></a>

## FilterByNumber\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.FilterByNumber.SolveInstance(IGH_DataAccess)'></a>

## FilterByNumber\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work of filtering objects by a numeric property value\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.FilterByNumber.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Core.Classes.FilterByText'></a>

## FilterByText Class

A Grasshopper component that filters a list of serializable objects based on the text value of a specified parameter\.

```csharp
public class FilterByText : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → FilterByText
### Constructors

<a name='DiGi.Rhino.Core.Classes.FilterByText.FilterByText()'></a>

## FilterByText\(\) Constructor

Initializes a new instance of the [FilterByText](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.FilterByText 'DiGi\.Rhino\.Core\.Classes\.FilterByText') class\.

```csharp
public FilterByText();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.FilterByText.ComponentGuid'></a>

## FilterByText\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.FilterByText.Exposure'></a>

## FilterByText\.Exposure Property

Gets the exposure level of the component, which determines its visibility and behavior on the canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.FilterByText.Inputs'></a>

## FilterByText\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.FilterByText.Outputs'></a>

## FilterByText\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.FilterByText.SolveInstance(IGH_DataAccess)'></a>

## FilterByText\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work of filtering objects based on text comparison\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.FilterByText.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The data access object used to retrieve input values and set output values\.

<a name='DiGi.Rhino.Core.Classes.GetValue'></a>

## GetValue Class

A Grasshopper component that retrieves a value for a given parameter definition from a parametrized object\.

```csharp
public class GetValue : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → GetValue
### Constructors

<a name='DiGi.Rhino.Core.Classes.GetValue.GetValue()'></a>

## GetValue\(\) Constructor

Initializes a new instance of the [GetValue](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GetValue 'DiGi\.Rhino\.Core\.Classes\.GetValue') class\.

```csharp
public GetValue();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.GetValue.ComponentGuid'></a>

## GetValue\.ComponentGuid Property

Gets the unique identifier for this component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.GetValue.Exposure'></a>

## GetValue\.Exposure Property

Gets the exposure level of this component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.GetValue.Inputs'></a>

## GetValue\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.GetValue.Outputs'></a>

## GetValue\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.GetValue.SolveInstance(IGH_DataAccess)'></a>

## GetValue\.SolveInstance\(IGH\_DataAccess\) Method

Performs the main logic of the component, retrieving a value from the parametrized object based on the provided parameter definition\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GetValue.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Core.Classes.GooEnum'></a>

## GooEnum Class

A non\-generic wrapper for enumeration types to be used within the Grasshopper environment\.

```csharp
public class GooEnum : DiGi.Rhino.Core.Classes.GooEnum<System.Enum>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooEnum&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>')[System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>') → GooEnum
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooEnum.GooEnum()'></a>

## GooEnum\(\) Constructor

Initializes a new instance of the [GooEnum](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum 'DiGi\.Rhino\.Core\.Classes\.GooEnum') class\.

```csharp
public GooEnum();
```

<a name='DiGi.Rhino.Core.Classes.GooEnum.GooEnum(System.Enum)'></a>

## GooEnum\(Enum\) Constructor

Initializes a new instance of the [GooEnum](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum 'DiGi\.Rhino\.Core\.Classes\.GooEnum') class with a specific enumeration value\.

```csharp
public GooEnum(System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooEnum.GooEnum(System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value\.
### Methods

<a name='DiGi.Rhino.Core.Classes.GooEnum.Duplicate()'></a>

## GooEnum\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo? Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooEnum](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum 'DiGi\.Rhino\.Core\.Classes\.GooEnum') containing the same value\.

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_'></a>

## GooEnum\<T\> Class

A generic wrapper for enumeration types to be used within the Grasshopper environment\.

```csharp
public class GooEnum<T> : DiGi.Rhino.Core.Interfaces.IGooObject
    where T : System.Enum
```
#### Type parameters

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.T'></a>

`T`

The type of the enumeration\.

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → GooEnum\<T\>

Derived  
↳ [GooEnum](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum 'DiGi\.Rhino\.Core\.Classes\.GooEnum')

Implements [IGooObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject')
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.GooEnum()'></a>

## GooEnum\(\) Constructor

Initializes a new instance of the [GooEnum&lt;T&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>') class\.

```csharp
public GooEnum();
```

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.GooEnum(DiGi.Rhino.Core.Classes.GooEnum_T_)'></a>

## GooEnum\(GooEnum\<T\>\) Constructor

Initializes a new instance of the [GooEnum&lt;T&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>') class using an existing [GooEnum&lt;T&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>')\.

```csharp
public GooEnum(DiGi.Rhino.Core.Classes.GooEnum<T>? gooEnum);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.GooEnum(DiGi.Rhino.Core.Classes.GooEnum_T_).gooEnum'></a>

`gooEnum` [DiGi\.Rhino\.Core\.Classes\.GooEnum&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>')[T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_.T 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>\.T')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>')

The source GooEnum object\.

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.GooEnum(T)'></a>

## GooEnum\(T\) Constructor

Initializes a new instance of the [GooEnum&lt;T&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>') class with a specific enumeration value\.

```csharp
public GooEnum(T? @enum);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.GooEnum(T).enum'></a>

`enum` [T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_.T 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>\.T')

The enumeration value\.
### Properties

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.IsValid'></a>

## GooEnum\<T\>\.IsValid Property

Gets a value indicating whether the current instance contains a valid value\.

```csharp
public override bool IsValid { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.TypeDescription'></a>

## GooEnum\<T\>\.TypeDescription Property

Gets a description of the type, replacing dots with spaces for readability\.

```csharp
public override string? TypeDescription { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.TypeName'></a>

## GooEnum\<T\>\.TypeName Property

Gets the full name of the type\.

```csharp
public override string? TypeName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.CastFrom(object)'></a>

## GooEnum\<T\>\.CastFrom\(object\) Method

Attempts to cast the specified object to a [GooEnum&lt;T&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>')\.

```csharp
public override bool CastFrom(object source);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.CastFrom(object).source'></a>

`source` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to cast\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the casting was successful; otherwise, false\.

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.CastTo_Y_(Y)'></a>

## GooEnum\<T\>\.CastTo\<Y\>\(Y\) Method

Attempts to cast the current value to a specified type\.

```csharp
public override bool CastTo<Y>(ref Y target);
```
#### Type parameters

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.CastTo_Y_(Y).Y'></a>

`Y`

The target type\.
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.CastTo_Y_(Y).target'></a>

`target` [Y](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_.CastTo_Y_(Y).Y 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>\.CastTo\<Y\>\(Y\)\.Y')

A reference to the target variable where the result will be stored\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the casting was successful; otherwise, false\.

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.Duplicate()'></a>

## GooEnum\<T\>\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo? Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooEnum&lt;T&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>') containing the same value\.

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.Read(GH_IReader)'></a>

## GooEnum\<T\>\.Read\(GH\_IReader\) Method

Reads the enumeration value from a serialization reader\.

```csharp
public override bool Read(GH_IReader? reader);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.Read(GH_IReader).reader'></a>

`reader` [GH\_IO\.Serialization\.GH\_IReader](https://learn.microsoft.com/en-us/dotnet/api/gh_io.serialization.gh_ireader 'GH\_IO\.Serialization\.GH\_IReader')

The reader used to deserialize the data\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the read operation was successful; otherwise, false\.

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.ToString()'></a>

## GooEnum\<T\>\.ToString\(\) Method

Returns a string representation of the current enumeration value\.

```csharp
public override string? ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The string representation of the value, or null if no value is present\.

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.Write(GH_IWriter)'></a>

## GooEnum\<T\>\.Write\(GH\_IWriter\) Method

Writes the enumeration value to a serialization writer\.

```csharp
public override bool Write(GH_IWriter writer);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooEnum_T_.Write(GH_IWriter).writer'></a>

`writer` [GH\_IO\.Serialization\.GH\_IWriter](https://learn.microsoft.com/en-us/dotnet/api/gh_io.serialization.gh_iwriter 'GH\_IO\.Serialization\.GH\_IWriter')

The writer used to serialize the data\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the write operation was successful; otherwise, false\.

<a name='DiGi.Rhino.Core.Classes.GooEnumParam'></a>

## GooEnumParam Class

A Grasshopper parameter component for general enumeration types\.

```csharp
public class GooEnumParam
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → GooEnumParam
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooEnumParam.GooEnumParam()'></a>

## GooEnumParam\(\) Constructor

Initializes a new instance of the [GooEnumParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnumParam 'DiGi\.Rhino\.Core\.Classes\.GooEnumParam') class\.

```csharp
public GooEnumParam();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.GooEnumParam.ComponentGuid'></a>

## GooEnumParam\.ComponentGuid Property

Gets the unique identifier for this component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.GooEnumParam_T,X_'></a>

## GooEnumParam\<T,X\> Class

Represents a persistent parameter in Grasshopper that handles enumeration values wrapped in a [GooEnum&lt;T&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>')\.

```csharp
public abstract class GooEnumParam<T,X>
    where T : DiGi.Rhino.Core.Classes.GooEnum<X>
    where X : System.Enum
```
#### Type parameters

<a name='DiGi.Rhino.Core.Classes.GooEnumParam_T,X_.T'></a>

`T`

The type of the value being stored, which must be a [GooEnum&lt;T&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>')\.

<a name='DiGi.Rhino.Core.Classes.GooEnumParam_T,X_.X'></a>

`X`

The underlying enumeration type\.

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → GooEnumParam\<T,X\>

Derived  
↳ [GooEnumParam&lt;T&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnumParam_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnumParam\<T\>')
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooEnumParam_T,X_.GooEnumParam()'></a>

## GooEnumParam\(\) Constructor

Initializes a new instance of the [GooEnumParam&lt;T,X&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnumParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooEnumParam\<T,X\>') class\.

```csharp
public GooEnumParam();
```
### Methods

<a name='DiGi.Rhino.Core.Classes.GooEnumParam_T,X_.Prompt_Plural(System.Collections.Generic.List_T_)'></a>

## GooEnumParam\<T,X\>\.Prompt\_Plural\(List\<T\>\) Method

Handles the prompt for multiple values when the parameter is accessed\.

```csharp
protected override GH_GetterResult Prompt_Plural(ref System.Collections.Generic.List<T> values);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooEnumParam_T,X_.Prompt_Plural(System.Collections.Generic.List_T_).values'></a>

`values` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnumParam_T,X_.T 'DiGi\.Rhino\.Core\.Classes\.GooEnumParam\<T,X\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

A reference to the list of values to be updated\.

#### Returns
[Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult')  
The result of the getter operation\.

<a name='DiGi.Rhino.Core.Classes.GooEnumParam_T,X_.Prompt_Singular(T)'></a>

## GooEnumParam\<T,X\>\.Prompt\_Singular\(T\) Method

Handles the prompt for a single value when the parameter is accessed\.

```csharp
protected override GH_GetterResult Prompt_Singular(ref T value);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooEnumParam_T,X_.Prompt_Singular(T).value'></a>

`value` [T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnumParam_T,X_.T 'DiGi\.Rhino\.Core\.Classes\.GooEnumParam\<T,X\>\.T')

A reference to the value to be updated\.

#### Returns
[Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult')  
The result of the getter operation\.

<a name='DiGi.Rhino.Core.Classes.GooEnumParam_T_'></a>

## GooEnumParam\<T\> Class

A Grasshopper parameter component for generic enumeration types\.

```csharp
public class GooEnumParam<T> : DiGi.Rhino.Core.Classes.GooEnumParam<DiGi.Rhino.Core.Classes.GooEnum<T>, T>
    where T : System.Enum
```
#### Type parameters

<a name='DiGi.Rhino.Core.Classes.GooEnumParam_T_.T'></a>

`T`

The type of the enumeration\.

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooEnumParam&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnumParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooEnumParam\<T,X\>')[DiGi\.Rhino\.Core\.Classes\.GooEnum&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>')[T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnumParam_T_.T 'DiGi\.Rhino\.Core\.Classes\.GooEnumParam\<T\>\.T')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>')[,](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnumParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooEnumParam\<T,X\>')[T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnumParam_T_.T 'DiGi\.Rhino\.Core\.Classes\.GooEnumParam\<T\>\.T')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnumParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooEnumParam\<T,X\>') → GooEnumParam\<T\>
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooEnumParam_T_.GooEnumParam()'></a>

## GooEnumParam\(\) Constructor

Initializes a new instance of the [GooEnumParam&lt;T&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnumParam_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnumParam\<T\>') class\.

```csharp
public GooEnumParam();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.GooEnumParam_T_.ComponentGuid'></a>

## GooEnumParam\<T\>\.ComponentGuid Property

Gets the unique identifier for this component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.GooObject'></a>

## GooObject Class

A non\-generic version of [GooObject&lt;TObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>') that wraps an object of type [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')\.

```csharp
public class GooObject : DiGi.Rhino.Core.Classes.GooObject<object>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>') → GooObject
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooObject.GooObject()'></a>

## GooObject\(\) Constructor

Initializes a new instance of the [GooObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject 'DiGi\.Rhino\.Core\.Classes\.GooObject') class\.

```csharp
public GooObject();
```

<a name='DiGi.Rhino.Core.Classes.GooObject.GooObject(object)'></a>

## GooObject\(object\) Constructor

Initializes a new instance of the [GooObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject 'DiGi\.Rhino\.Core\.Classes\.GooObject') class with a specified value\.

```csharp
public GooObject(object? @object);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooObject.GooObject(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to wrap in this Goo container\.
### Methods

<a name='DiGi.Rhino.Core.Classes.GooObject.Duplicate()'></a>

## GooObject\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo? Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject 'DiGi\.Rhino\.Core\.Classes\.GooObject') containing the same value\.

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_'></a>

## GooObject\<TObject\> Class

A generic wrapper for objects to be used within Grasshopper, providing serialization and casting capabilities\.

```csharp
public class GooObject<TObject> : DiGi.Rhino.Core.Interfaces.IGooObject<TObject>, DiGi.Rhino.Core.Interfaces.IGooObject
```
#### Type parameters

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.TObject'></a>

`TObject`

The type of the object wrapped by this Goo container\.

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → GooObject\<TObject\>

Derived  
↳ [GooObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject 'DiGi\.Rhino\.Core\.Classes\.GooObject')  
↳ [GooSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>')  
↳ [GooType](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooType 'DiGi\.Rhino\.Core\.Classes\.GooType')

Implements [DiGi\.Rhino\.Core\.Interfaces\.IGooObject&lt;](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_ 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>')[TObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_.TObject 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>\.TObject')[&gt;](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_ 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>'), [IGooObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject')
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.GooObject()'></a>

## GooObject\(\) Constructor

Initializes a new instance of the [GooObject&lt;TObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>') class\.

```csharp
public GooObject();
```

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.GooObject(TObject)'></a>

## GooObject\(TObject\) Constructor

Initializes a new instance of the [GooObject&lt;TObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>') class with a specified value\.

```csharp
public GooObject(TObject? @object);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.GooObject(TObject).object'></a>

`object` [TObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_.TObject 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>\.TObject')

The object to wrap in this Goo container\.
### Properties

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.IsValid'></a>

## GooObject\<TObject\>\.IsValid Property

Gets a value indicating whether the wrapped object is valid \(not null\)\.

```csharp
public override bool IsValid { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.TypeDescription'></a>

## GooObject\<TObject\>\.TypeDescription Property

Gets a human\-readable description of the type of the wrapped object\.

```csharp
public override string? TypeDescription { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.TypeName'></a>

## GooObject\<TObject\>\.TypeName Property

Gets the full name of the type of the wrapped object\.

```csharp
public override string? TypeName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.CastFrom(object)'></a>

## GooObject\<TObject\>\.CastFrom\(object\) Method

Attempts to cast the specified source object into this Goo container\.

```csharp
public override bool CastFrom(object? source);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.CastFrom(object).source'></a>

`source` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The source object to cast from\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the casting was successful; otherwise, false\.

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.CastTo_Y_(Y)'></a>

## GooObject\<TObject\>\.CastTo\<Y\>\(Y\) Method

Attempts to cast the wrapped object into the specified target type\.

```csharp
public override bool CastTo<Y>(ref Y target);
```
#### Type parameters

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.CastTo_Y_(Y).Y'></a>

`Y`

The target type to cast to\.
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.CastTo_Y_(Y).target'></a>

`target` [Y](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_.CastTo_Y_(Y).Y 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>\.CastTo\<Y\>\(Y\)\.Y')

A reference to the target variable where the result will be stored\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the casting was successful; otherwise, false\.

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.Duplicate()'></a>

## GooObject\<TObject\>\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo? Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') containing the same value\.

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.GetValue_XObject_()'></a>

## GooObject\<TObject\>\.GetValue\<XObject\>\(\) Method

Retrieves the wrapped value cast to a more specific type\.

```csharp
public XObject? GetValue<XObject>()
    where XObject : TObject;
```
#### Type parameters

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.GetValue_XObject_().XObject'></a>

`XObject`

The specific type to retrieve, which must inherit from [TObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_.TObject 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>\.TObject')\.

Implements [GetValue&lt;XObject&gt;\(\)](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_.GetValue_XObject_() 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>\.GetValue\<XObject\>\(\)')

#### Returns
[XObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_.GetValue_XObject_().XObject 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>\.GetValue\<XObject\>\(\)\.XObject')  
The wrapped value as [XObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_.GetValue_XObject_().XObject 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>\.GetValue\<XObject\>\(\)\.XObject') if possible; otherwise, the default value of [XObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_.GetValue_XObject_().XObject 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>\.GetValue\<XObject\>\(\)\.XObject')\.

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.Read(GH_IReader)'></a>

## GooObject\<TObject\>\.Read\(GH\_IReader\) Method

Reads the wrapped object from a Grasshopper reader\.

```csharp
public override bool Read(GH_IReader reader);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.Read(GH_IReader).reader'></a>

`reader` [GH\_IO\.Serialization\.GH\_IReader](https://learn.microsoft.com/en-us/dotnet/api/gh_io.serialization.gh_ireader 'GH\_IO\.Serialization\.GH\_IReader')

The reader used to deserialize the object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if reading was successful; otherwise, false\.

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.ToString()'></a>

## GooObject\<TObject\>\.ToString\(\) Method

Returns a string representation of the wrapped object\.

```csharp
public override string? ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The full name of the type of the wrapped value, or null if the value is null\.

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.Write(GH_IWriter)'></a>

## GooObject\<TObject\>\.Write\(GH\_IWriter\) Method

Writes the wrapped object to a Grasshopper writer\.

```csharp
public override bool Write(GH_IWriter writer);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooObject_TObject_.Write(GH_IWriter).writer'></a>

`writer` [GH\_IO\.Serialization\.GH\_IWriter](https://learn.microsoft.com/en-us/dotnet/api/gh_io.serialization.gh_iwriter 'GH\_IO\.Serialization\.GH\_IWriter')

The writer used to serialize the object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if writing was successful; otherwise, false\.

<a name='DiGi.Rhino.Core.Classes.GooObjectParam'></a>

## GooObjectParam Class

A Grasshopper persistent parameter for [GooObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject 'DiGi\.Rhino\.Core\.Classes\.GooObject')\.

```csharp
public class GooObjectParam
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → GooObjectParam
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooObjectParam.GooObjectParam()'></a>

## GooObjectParam\(\) Constructor

Initializes a new instance of the [GooObjectParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObjectParam 'DiGi\.Rhino\.Core\.Classes\.GooObjectParam') class\.

```csharp
public GooObjectParam();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.GooObjectParam.ComponentGuid'></a>

## GooObjectParam\.ComponentGuid Property

Gets the unique identifier for this component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.GooParam'></a>

## GooParam Class

Represents a Grasshopper parameter that handles generic goo objects \([Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')\)\.

```csharp
public class GooParam
```

Inheritance [Grasshopper\.Kernel\.GH\_Param](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_param 'Grasshopper\.Kernel\.GH\_Param') → GooParam
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooParam.GooParam()'></a>

## GooParam\(\) Constructor

Initializes a new instance of the [GooParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooParam 'DiGi\.Rhino\.Core\.Classes\.GooParam') class with default values and item access\.

```csharp
public GooParam();
```

<a name='DiGi.Rhino.Core.Classes.GooParam.GooParam(string,string,string,GH_ParamAccess)'></a>

## GooParam\(string, string, string, GH\_ParamAccess\) Constructor

Initializes a new instance of the [GooParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooParam 'DiGi\.Rhino\.Core\.Classes\.GooParam') class with specified metadata and access mode\.

```csharp
public GooParam(string name, string nickname, string description, GH_ParamAccess gH_ParamAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooParam.GooParam(string,string,string,GH_ParamAccess).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Rhino.Core.Classes.GooParam.GooParam(string,string,string,GH_ParamAccess).nickname'></a>

`nickname` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The nickname of the parameter\.

<a name='DiGi.Rhino.Core.Classes.GooParam.GooParam(string,string,string,GH_ParamAccess).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the parameter\.

<a name='DiGi.Rhino.Core.Classes.GooParam.GooParam(string,string,string,GH_ParamAccess).gH_ParamAccess'></a>

`gH_ParamAccess` [Grasshopper\.Kernel\.GH\_ParamAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_paramaccess 'Grasshopper\.Kernel\.GH\_ParamAccess')

The access mode for the parameter \(e\.g\., Item or List\)\.
### Properties

<a name='DiGi.Rhino.Core.Classes.GooParam.ComponentGuid'></a>

## GooParam\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.GooParam.Exposure'></a>

## GooParam\.Exposure Property

Gets the exposure level of the parameter\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')
### Methods

<a name='DiGi.Rhino.Core.Classes.GooParam.GetHashCode()'></a>

## GooParam\.GetHashCode\(\) Method

Returns a hash code for the current object based on its name\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A hash code for the current object\.

<a name='DiGi.Rhino.Core.Classes.GooParam.Read(GH_IReader)'></a>

## GooParam\.Read\(GH\_IReader\) Method

Reads the parameter data from the specified reader\.

```csharp
public sealed override bool Read(GH_IReader reader);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooParam.Read(GH_IReader).reader'></a>

`reader` [GH\_IO\.Serialization\.GH\_IReader](https://learn.microsoft.com/en-us/dotnet/api/gh_io.serialization.gh_ireader 'GH\_IO\.Serialization\.GH\_IReader')

The reader used to deserialize the object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the read operation was successful; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.GooParam.Write(GH_IWriter)'></a>

## GooParam\.Write\(GH\_IWriter\) Method

Writes the parameter data to the specified writer\.

```csharp
public sealed override bool Write(GH_IWriter writer);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooParam.Write(GH_IWriter).writer'></a>

`writer` [GH\_IO\.Serialization\.GH\_IWriter](https://learn.microsoft.com/en-us/dotnet/api/gh_io.serialization.gh_iwriter 'GH\_IO\.Serialization\.GH\_IWriter')

The writer used to serialize the object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the write operation was successful; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_'></a>

## GooPresistentParam\<T,X\> Class

Represents a persistent parameter in Grasshopper that manages data of type [T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.T 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>\.T'),
which wraps an underlying object of type [X](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.X 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>\.X')\.

```csharp
public class GooPresistentParam<T,X>
    where T : DiGi.Rhino.Core.Classes.GooObject<X?>
    where X : DiGi.Core.Interfaces.IObject
```
#### Type parameters

<a name='DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.T'></a>

`T`

The type of the Goo object, which must inherit from [GooObject&lt;TObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>')\.

<a name='DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.X'></a>

`X`

The type of the underlying data object, which must implement [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')\.

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → GooPresistentParam\<T,X\>

Derived  
↳ [GooSerializablePresistentParam&lt;T,X&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>')
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.GooPresistentParam()'></a>

## GooPresistentParam\(\) Constructor

Initializes a new instance of the [GooPresistentParam&lt;T,X&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>') class using default values derived from type [X](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.X 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>\.X')\.

```csharp
public GooPresistentParam();
```

<a name='DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.GooPresistentParam(string,string)'></a>

## GooPresistentParam\(string, string\) Constructor

Initializes a new instance of the [GooPresistentParam&lt;T,X&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>') class with a specified name and subcategory\.

```csharp
public GooPresistentParam(string name, string subcategory);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.GooPresistentParam(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the parameter\.

<a name='DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.GooPresistentParam(string,string).subcategory'></a>

`subcategory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The subcategory under which the parameter is listed in the Grasshopper menu\.
### Properties

<a name='DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.ComponentGuid'></a>

## GooPresistentParam\<T,X\>\.ComponentGuid Property

Gets the unique identifier for this component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')
### Methods

<a name='DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.Prompt_Plural(System.Collections.Generic.List_T_)'></a>

## GooPresistentParam\<T,X\>\.Prompt\_Plural\(List\<T\>\) Method

Prompts the user to supply multiple values of type [T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.T 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>\.T')\.

```csharp
protected override GH_GetterResult Prompt_Plural(ref System.Collections.Generic.List<T?> values);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.Prompt_Plural(System.Collections.Generic.List_T_).values'></a>

`values` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.T 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of values supplied by the user\.

#### Returns
[Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult')  
A [Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult') indicating the outcome of the prompt\.

<a name='DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.Prompt_Singular(T)'></a>

## GooPresistentParam\<T,X\>\.Prompt\_Singular\(T\) Method

Prompts the user to supply a single value of type [T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.T 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>\.T')\.

```csharp
protected override GH_GetterResult Prompt_Singular(ref T? value);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.Prompt_Singular(T).value'></a>

`value` [T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_.T 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>\.T')

The value supplied by the user\.

#### Returns
[Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult')  
A [Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult') indicating the outcome of the prompt\.

<a name='DiGi.Rhino.Core.Classes.GooSerializableObject'></a>

## GooSerializableObject Class

Represents a non\-generic Goo wrapper for any object implementing [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

```csharp
public class GooSerializableObject : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Core.Interfaces.ISerializableObject>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>') → GooSerializableObject
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooSerializableObject.GooSerializableObject()'></a>

## GooSerializableObject\(\) Constructor

Initializes a new instance of the [GooSerializableObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject') class\.

```csharp
public GooSerializableObject();
```

<a name='DiGi.Rhino.Core.Classes.GooSerializableObject.GooSerializableObject(DiGi.Core.Interfaces.ISerializableObject)'></a>

## GooSerializableObject\(ISerializableObject\) Constructor

Initializes a new instance of the [GooSerializableObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject') class with a specified serializable object\.

```csharp
public GooSerializableObject(DiGi.Core.Interfaces.ISerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooSerializableObject.GooSerializableObject(DiGi.Core.Interfaces.ISerializableObject).serializableObject'></a>

`serializableObject` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object to wrap\.
### Methods

<a name='DiGi.Rhino.Core.Classes.GooSerializableObject.Duplicate()'></a>

## GooSerializableObject\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo? Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooSerializableObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject') containing the same value\.

<a name='DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_'></a>

## GooSerializableObject\<TSerializableObject\> Class

Represents a Goo wrapper for an object that implements the [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') interface,
allowing it to be passed through Grasshopper wires while maintaining serialization capabilities\.

```csharp
public class GooSerializableObject<TSerializableObject> : DiGi.Rhino.Core.Classes.GooObject<TSerializableObject?>, DiGi.Rhino.Core.Interfaces.IGooSerializableObject<TSerializableObject>, DiGi.Rhino.Core.Interfaces.IGooSerializableObject, DiGi.Rhino.Core.Interfaces.IGooObject, DiGi.Rhino.Core.Interfaces.IGooObject<TSerializableObject?>
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_.TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object\.

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>')[TSerializableObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_.TSerializableObject 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>\.TSerializableObject')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>') → GooSerializableObject\<TSerializableObject\>

Derived  
↳ [GooAddress](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAddress 'DiGi\.GIS\.Rhino\.Classes\.GooAddress')  
↳ [GooCoordinates](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooCoordinates 'DiGi\.GIS\.Rhino\.Classes\.GooCoordinates')  
↳ [GooParameter](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameter 'DiGi\.GIS\.Rhino\.Classes\.GooParameter')  
↳ [GooParameterDefinition](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameterDefinition 'DiGi\.GIS\.Rhino\.Classes\.GooParameterDefinition')  
↳ [GooParametrizedObject](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParametrizedObject 'DiGi\.GIS\.Rhino\.Classes\.GooParametrizedObject')  
↳ [GooTimeSeries](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooTimeSeries 'DiGi\.GIS\.Rhino\.Classes\.GooTimeSeries')  
↳ [GooSerializableObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject')

Implements [DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject&lt;](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject\<TSerializableObject\>')[TSerializableObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_.TSerializableObject 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>\.TSerializableObject')[&gt;](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject\<TSerializableObject\>'), [IGooSerializableObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooSerializableObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject'), [IGooObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject'), [DiGi\.Rhino\.Core\.Interfaces\.IGooObject&lt;](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_ 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>')[TSerializableObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_.TSerializableObject 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>\.TSerializableObject')[&gt;](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_ 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>')
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_.GooSerializableObject()'></a>

## GooSerializableObject\(\) Constructor

Initializes a new instance of the [GooSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>') class\.

```csharp
public GooSerializableObject();
```

<a name='DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_.GooSerializableObject(TSerializableObject)'></a>

## GooSerializableObject\(TSerializableObject\) Constructor

Initializes a new instance of the [GooSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>') class with a specified serializable object\.

```csharp
public GooSerializableObject(TSerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_.GooSerializableObject(TSerializableObject).serializableObject'></a>

`serializableObject` [TSerializableObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_.TSerializableObject 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>\.TSerializableObject')

The serializable object to wrap\.
### Methods

<a name='DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_.Duplicate()'></a>

## GooSerializableObject\<TSerializableObject\>\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo? Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>') containing the same value\.

<a name='DiGi.Rhino.Core.Classes.GooSerializableObjectParam'></a>

## GooSerializableObjectParam Class

A Grasshopper persistent parameter that handles [GooSerializableObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject') types\.

```csharp
public class GooSerializableObjectParam
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → GooSerializableObjectParam
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooSerializableObjectParam.GooSerializableObjectParam()'></a>

## GooSerializableObjectParam\(\) Constructor

Initializes a new instance of the [GooSerializableObjectParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObjectParam 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObjectParam') class\.

```csharp
public GooSerializableObjectParam();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.GooSerializableObjectParam.ComponentGuid'></a>

## GooSerializableObjectParam\.ComponentGuid Property

Gets the unique identifier for this component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')
### Methods

<a name='DiGi.Rhino.Core.Classes.GooSerializableObjectParam.AppendAdditionalMenuItems(System.Windows.Forms.ToolStripDropDown)'></a>

## GooSerializableObjectParam\.AppendAdditionalMenuItems\(ToolStripDropDown\) Method

Appends additional custom menu items to the parameter's context menu\.

```csharp
public override void AppendAdditionalMenuItems(System.Windows.Forms.ToolStripDropDown menu);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooSerializableObjectParam.AppendAdditionalMenuItems(System.Windows.Forms.ToolStripDropDown).menu'></a>

`menu` [System\.Windows\.Forms\.ToolStripDropDown](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.toolstripdropdown 'System\.Windows\.Forms\.ToolStripDropDown')

The dropdown menu to append items to\.

<a name='DiGi.Rhino.Core.Classes.GooSerializableObjectParam.Menu_SaveAs(object,System.EventArgs)'></a>

## GooSerializableObjectParam\.Menu\_SaveAs\(object, EventArgs\) Method

Handles the "Save As\.\.\." menu item click event\.

```csharp
private void Menu_SaveAs(object? sender, System.EventArgs? e);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooSerializableObjectParam.Menu_SaveAs(object,System.EventArgs).sender'></a>

`sender` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The source of the event\.

<a name='DiGi.Rhino.Core.Classes.GooSerializableObjectParam.Menu_SaveAs(object,System.EventArgs).e'></a>

`e` [System\.EventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.eventargs 'System\.EventArgs')

The event arguments\.

<a name='DiGi.Rhino.Core.Classes.GooSerializableObjectParam.Prompt_Plural(System.Collections.Generic.List_DiGi.Rhino.Core.Classes.GooSerializableObject_)'></a>

## GooSerializableObjectParam\.Prompt\_Plural\(List\<GooSerializableObject\>\) Method

Prompts the user to select multiple values for the parameter\.

```csharp
protected override GH_GetterResult Prompt_Plural(ref System.Collections.Generic.List<DiGi.Rhino.Core.Classes.GooSerializableObject?> values);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooSerializableObjectParam.Prompt_Plural(System.Collections.Generic.List_DiGi.Rhino.Core.Classes.GooSerializableObject_).values'></a>

`values` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GooSerializableObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of selected values\.

#### Returns
[Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult')  
A result indicating whether the operation was successful\.

<a name='DiGi.Rhino.Core.Classes.GooSerializableObjectParam.Prompt_Singular(DiGi.Rhino.Core.Classes.GooSerializableObject)'></a>

## GooSerializableObjectParam\.Prompt\_Singular\(GooSerializableObject\) Method

Prompts the user to select a single value for the parameter\.

```csharp
protected override GH_GetterResult Prompt_Singular(ref DiGi.Rhino.Core.Classes.GooSerializableObject? value);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooSerializableObjectParam.Prompt_Singular(DiGi.Rhino.Core.Classes.GooSerializableObject).value'></a>

`value` [GooSerializableObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject')

The selected value\.

#### Returns
[Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult')  
A result indicating whether the operation was successful\.

<a name='DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_'></a>

## GooSerializablePresistentParam\<T,X\> Class

Represents a persistent parameter that handles serializable objects of type [T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.T 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>\.T') and [X](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.X 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>\.X')\.

```csharp
public class GooSerializablePresistentParam<T,X> : DiGi.Rhino.Core.Classes.GooPresistentParam<T, X>
    where T : DiGi.Rhino.Core.Classes.GooSerializableObject<X>
    where X : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.T'></a>

`T`

The type of the Goo object, which must derive from [GooSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>')\.

<a name='DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.X'></a>

`X`

The underlying serializable data type that implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>')[T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.T 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>\.T')[,](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>')[X](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.X 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>\.X')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>') → GooSerializablePresistentParam\<T,X\>

Derived  
↳ [GooAddressParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAddressParam 'DiGi\.GIS\.Rhino\.Classes\.GooAddressParam')  
↳ [GooCoordinatesParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooCoordinatesParam 'DiGi\.GIS\.Rhino\.Classes\.GooCoordinatesParam')  
↳ [GooParameterDefinitionParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameterDefinitionParam 'DiGi\.GIS\.Rhino\.Classes\.GooParameterDefinitionParam')  
↳ [GooParameterParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameterParam 'DiGi\.GIS\.Rhino\.Classes\.GooParameterParam')  
↳ [GooParametrizedObjectParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParametrizedObjectParam 'DiGi\.GIS\.Rhino\.Classes\.GooParametrizedObjectParam')  
↳ [GooTimeSeriesParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooTimeSeriesParam 'DiGi\.GIS\.Rhino\.Classes\.GooTimeSeriesParam')
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.GooSerializablePresistentParam()'></a>

## GooSerializablePresistentParam\(\) Constructor

Initializes a new instance of the [GooSerializablePresistentParam&lt;T,X&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>') class\.

```csharp
public GooSerializablePresistentParam();
```

<a name='DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.GooSerializablePresistentParam(string,string)'></a>

## GooSerializablePresistentParam\(string, string\) Constructor

Initializes a new instance of the [GooSerializablePresistentParam&lt;T,X&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>') class with a specified name and subcategory\.

```csharp
public GooSerializablePresistentParam(string name, string subcategory);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.GooSerializablePresistentParam(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the parameter\.

<a name='DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.GooSerializablePresistentParam(string,string).subcategory'></a>

`subcategory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The subcategory used for grouping in the Grasshopper interface\.
### Properties

<a name='DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.ComponentGuid'></a>

## GooSerializablePresistentParam\<T,X\>\.ComponentGuid Property

Gets the unique identifier for this component type\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')
### Methods

<a name='DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.AppendAdditionalMenuItems(System.Windows.Forms.ToolStripDropDown)'></a>

## GooSerializablePresistentParam\<T,X\>\.AppendAdditionalMenuItems\(ToolStripDropDown\) Method

Appends additional custom items to the context menu of the parameter\.

```csharp
public override void AppendAdditionalMenuItems(System.Windows.Forms.ToolStripDropDown menu);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.AppendAdditionalMenuItems(System.Windows.Forms.ToolStripDropDown).menu'></a>

`menu` [System\.Windows\.Forms\.ToolStripDropDown](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.toolstripdropdown 'System\.Windows\.Forms\.ToolStripDropDown')

The [System\.Windows\.Forms\.ToolStripDropDown](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.toolstripdropdown 'System\.Windows\.Forms\.ToolStripDropDown') menu to which items will be added\.

<a name='DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.Prompt_Plural(System.Collections.Generic.List_T_)'></a>

## GooSerializablePresistentParam\<T,X\>\.Prompt\_Plural\(List\<T\>\) Method

Prompts the user to provide multiple values for the parameter\.

```csharp
protected override GH_GetterResult Prompt_Plural(ref System.Collections.Generic.List<T?> values);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.Prompt_Plural(System.Collections.Generic.List_T_).values'></a>

`values` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.T 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

A reference to the list of values to be retrieved\.

#### Returns
[Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult')  
The result of the getter operation as a [Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult')\.

<a name='DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.Prompt_Singular(T)'></a>

## GooSerializablePresistentParam\<T,X\>\.Prompt\_Singular\(T\) Method

Prompts the user to provide a single value for the parameter\.

```csharp
protected override GH_GetterResult Prompt_Singular(ref T? value);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.Prompt_Singular(T).value'></a>

`value` [T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_.T 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>\.T')

A reference to the value to be retrieved\.

#### Returns
[Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult')  
The result of the getter operation as a [Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult')\.

<a name='DiGi.Rhino.Core.Classes.GooType'></a>

## GooType Class

Represents a Goo wrapper for [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type'), allowing system types to be passed through Grasshopper wires\.

```csharp
public class GooType : DiGi.Rhino.Core.Classes.GooObject<System.Type>, DiGi.Rhino.Core.Interfaces.IGooObject<System.Type>, DiGi.Rhino.Core.Interfaces.IGooObject
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>')[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>') → GooType

Implements [DiGi\.Rhino\.Core\.Interfaces\.IGooObject&lt;](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_ 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>')[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')[&gt;](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_ 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>'), [IGooObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject')
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooType.GooType()'></a>

## GooType\(\) Constructor

Initializes a new instance of the [GooType](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooType 'DiGi\.Rhino\.Core\.Classes\.GooType') class\.

```csharp
public GooType();
```

<a name='DiGi.Rhino.Core.Classes.GooType.GooType(System.Type)'></a>

## GooType\(Type\) Constructor

Initializes a new instance of the [GooType](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooType 'DiGi\.Rhino\.Core\.Classes\.GooType') class with a specified type\.

```csharp
public GooType(System.Type? type);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.GooType.GooType(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type') to be wrapped in the Goo object\.
### Methods

<a name='DiGi.Rhino.Core.Classes.GooType.Duplicate()'></a>

## GooType\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo? Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [GooType](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooType 'DiGi\.Rhino\.Core\.Classes\.GooType') instance containing the same value\.

<a name='DiGi.Rhino.Core.Classes.GooTypeParam'></a>

## GooTypeParam Class

A Grasshopper parameter used to input and output [GooType](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooType 'DiGi\.Rhino\.Core\.Classes\.GooType') objects\.

```csharp
public class GooTypeParam
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → GooTypeParam
### Constructors

<a name='DiGi.Rhino.Core.Classes.GooTypeParam.GooTypeParam()'></a>

## GooTypeParam\(\) Constructor

Initializes a new instance of the [GooTypeParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooTypeParam 'DiGi\.Rhino\.Core\.Classes\.GooTypeParam') class\.

```csharp
public GooTypeParam();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.GooTypeParam.ComponentGuid'></a>

## GooTypeParam\.ComponentGuid Property

Gets the unique identifier for the [GooTypeParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooTypeParam 'DiGi\.Rhino\.Core\.Classes\.GooTypeParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.Inspect'></a>

## Inspect Class

A Grasshopper component that inspects DiGi objects and dynamically generates
output parameters based on the input object's serializable properties\.

```csharp
public class Inspect : DiGi.Rhino.Core.Classes.Component
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → Inspect
### Constructors

<a name='DiGi.Rhino.Core.Classes.Inspect.Inspect()'></a>

## Inspect\(\) Constructor

Initializes a new instance of the [Inspect](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Inspect 'DiGi\.Rhino\.Core\.Classes\.Inspect') component\.

```csharp
public Inspect();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.Inspect.ComponentGuid'></a>

## Inspect\.ComponentGuid Property

Gets the unique identifier for this Grasshopper component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.Inspect.Exposure'></a>

## Inspect\.Exposure Property

Gets the exposure level of the component in the Grasshopper toolbar\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')
### Methods

<a name='DiGi.Rhino.Core.Classes.Inspect.AddedToDocument(GH_Document)'></a>

## Inspect\.AddedToDocument\(GH\_Document\) Method

Called when this component is added to a Grasshopper document\.

```csharp
public override void AddedToDocument(GH_Document document);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.Inspect.AddedToDocument(GH_Document).document'></a>

`document` [Grasshopper\.Kernel\.GH\_Document](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_document 'Grasshopper\.Kernel\.GH\_Document')

The Grasshopper document to which the component is being added\.

<a name='DiGi.Rhino.Core.Classes.Inspect.AppendAdditionalMenuItems(System.Windows.Forms.ToolStripDropDown)'></a>

## Inspect\.AppendAdditionalMenuItems\(ToolStripDropDown\) Method

Appends additional custom menu items to the component's right\-click context menu\.

```csharp
public override void AppendAdditionalMenuItems(System.Windows.Forms.ToolStripDropDown menu);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.Inspect.AppendAdditionalMenuItems(System.Windows.Forms.ToolStripDropDown).menu'></a>

`menu` [System\.Windows\.Forms\.ToolStripDropDown](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.toolstripdropdown 'System\.Windows\.Forms\.ToolStripDropDown')

The tool strip dropdown menu to which items are appended\.

<a name='DiGi.Rhino.Core.Classes.Inspect.RegisterInputParams(GH_InputParamManager)'></a>

## Inspect\.RegisterInputParams\(GH\_InputParamManager\) Method

Registers all input parameters for this component\.

```csharp
protected override void RegisterInputParams(GH_InputParamManager inputParamManager);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.Inspect.RegisterInputParams(GH_InputParamManager).inputParamManager'></a>

`inputParamManager` [Grasshopper\.Kernel\.GH\_Component\.GH\_InputParamManager](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component.gh_inputparammanager 'Grasshopper\.Kernel\.GH\_Component\.GH\_InputParamManager')

The manager used to register input parameters\.

<a name='DiGi.Rhino.Core.Classes.Inspect.RegisterOutputParams(GH_OutputParamManager)'></a>

## Inspect\.RegisterOutputParams\(GH\_OutputParamManager\) Method

Registers all output parameters for this component\.

```csharp
protected override void RegisterOutputParams(GH_OutputParamManager outputParamManager);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.Inspect.RegisterOutputParams(GH_OutputParamManager).outputParamManager'></a>

`outputParamManager` [Grasshopper\.Kernel\.GH\_Component\.GH\_OutputParamManager](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component.gh_outputparammanager 'Grasshopper\.Kernel\.GH\_Component\.GH\_OutputParamManager')

The manager used to register output parameters\.

<a name='DiGi.Rhino.Core.Classes.Inspect.SolveInstance(IGH_DataAccess)'></a>

## Inspect\.SolveInstance\(IGH\_DataAccess\) Method

Executes the main logic of the component, reading the input object and setting
values on the dynamically generated output parameters\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.Inspect.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The data access object used to retrieve inputs and set outputs\.

<a name='DiGi.Rhino.Core.Classes.InspectAttribute'></a>

## InspectAttribute Class

Attribute used to mark methods for inspection purposes, providing metadata such as name, nickname, and description\.

```csharp
public class InspectAttribute : System.Attribute
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → InspectAttribute
### Constructors

<a name='DiGi.Rhino.Core.Classes.InspectAttribute.InspectAttribute(string,string,string)'></a>

## InspectAttribute\(string, string, string\) Constructor

Initializes a new instance of the [InspectAttribute](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.InspectAttribute 'DiGi\.Rhino\.Core\.Classes\.InspectAttribute') class\.

```csharp
public InspectAttribute(string name, string nickname, string description);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.InspectAttribute.InspectAttribute(string,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The formal name of the inspection\.

<a name='DiGi.Rhino.Core.Classes.InspectAttribute.InspectAttribute(string,string,string).nickname'></a>

`nickname` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The nickname of the inspection\.

<a name='DiGi.Rhino.Core.Classes.InspectAttribute.InspectAttribute(string,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the inspection\.
### Properties

<a name='DiGi.Rhino.Core.Classes.InspectAttribute.Description'></a>

## InspectAttribute\.Description Property

Gets the detailed description of the inspected method\.

```csharp
public string Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Rhino.Core.Classes.InspectAttribute.Name'></a>

## InspectAttribute\.Name Property

Gets the formal name associated with the inspected method\.

```csharp
public string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Rhino.Core.Classes.InspectAttribute.Nickname'></a>

## InspectAttribute\.Nickname Property

Gets the nickname or short name associated with the inspected method\.

```csharp
public string Nickname { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Rhino.Core.Classes.InspectManager'></a>

## InspectManager Class

Manages the discovery and retrieval of inspection methods associated with specific types\.

```csharp
public class InspectManager
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → InspectManager
### Constructors

<a name='DiGi.Rhino.Core.Classes.InspectManager.InspectManager()'></a>

## InspectManager\(\) Constructor

Initializes a new instance of the [InspectManager](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.InspectManager 'DiGi\.Rhino\.Core\.Classes\.InspectManager') class\.

```csharp
public InspectManager();
```
### Methods

<a name='DiGi.Rhino.Core.Classes.InspectManager.GetInspectMethods(System.Type)'></a>

## InspectManager\.GetInspectMethods\(Type\) Method

Retrieves a list of inspection methods that are applicable to the specified type\.

```csharp
public System.Collections.Generic.List<DiGi.Rhino.Core.Classes.InspectMethod>? GetInspectMethods(System.Type? type);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.InspectManager.GetInspectMethods(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type for which to retrieve inspection methods\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[InspectMethod](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.InspectMethod 'DiGi\.Rhino\.Core\.Classes\.InspectMethod')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [InspectMethod](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.InspectMethod 'DiGi\.Rhino\.Core\.Classes\.InspectMethod') objects associated with the provided type or its base types; returns null if the internal dictionary fails to initialize\.

<a name='DiGi.Rhino.Core.Classes.InspectMethod'></a>

## InspectMethod Class

Provides functionality to inspect and invoke a method associated with an [InspectAttribute](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.InspectMethod.InspectAttribute 'DiGi\.Rhino\.Core\.Classes\.InspectMethod\.InspectAttribute')\.

```csharp
public class InspectMethod
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → InspectMethod
### Constructors

<a name='DiGi.Rhino.Core.Classes.InspectMethod.InspectMethod(System.Reflection.MethodInfo,DiGi.Rhino.Core.Classes.InspectAttribute)'></a>

## InspectMethod\(MethodInfo, InspectAttribute\) Constructor

Initializes a new instance of the [InspectMethod](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.InspectMethod 'DiGi\.Rhino\.Core\.Classes\.InspectMethod') class\.

```csharp
public InspectMethod(System.Reflection.MethodInfo? methodInfo, DiGi.Rhino.Core.Classes.InspectAttribute? inspectAttribute);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.InspectMethod.InspectMethod(System.Reflection.MethodInfo,DiGi.Rhino.Core.Classes.InspectAttribute).methodInfo'></a>

`methodInfo` [System\.Reflection\.MethodInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.methodinfo 'System\.Reflection\.MethodInfo')

The reflection information of the method\.

<a name='DiGi.Rhino.Core.Classes.InspectMethod.InspectMethod(System.Reflection.MethodInfo,DiGi.Rhino.Core.Classes.InspectAttribute).inspectAttribute'></a>

`inspectAttribute` [InspectAttribute](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.InspectAttribute 'DiGi\.Rhino\.Core\.Classes\.InspectAttribute')

The attribute associated with the method\.
### Properties

<a name='DiGi.Rhino.Core.Classes.InspectMethod.InspectAttribute'></a>

## InspectMethod\.InspectAttribute Property

Gets the attribute associated with the inspected method\.

```csharp
public DiGi.Rhino.Core.Classes.InspectAttribute? InspectAttribute { get; }
```

#### Property Value
[InspectAttribute](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.InspectAttribute 'DiGi\.Rhino\.Core\.Classes\.InspectAttribute')

<a name='DiGi.Rhino.Core.Classes.InspectMethod.MethodInfo'></a>

## InspectMethod\.MethodInfo Property

Gets the reflection information of the inspected method\.

```csharp
public System.Reflection.MethodInfo? MethodInfo { get; }
```

#### Property Value
[System\.Reflection\.MethodInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.methodinfo 'System\.Reflection\.MethodInfo')
### Methods

<a name='DiGi.Rhino.Core.Classes.InspectMethod.IsEnumerable()'></a>

## InspectMethod\.IsEnumerable\(\) Method

Checks if the inspected method is valid and specifically returns an enumerable collection\.

```csharp
public bool IsEnumerable();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the method is valid and return type is enumerable; otherwise, false\.

<a name='DiGi.Rhino.Core.Classes.InspectMethod.IsValid()'></a>

## InspectMethod\.IsValid\(\) Method

Determines whether the inspected method is valid\.

```csharp
public bool IsValid();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the method is valid; otherwise, false\.

<a name='DiGi.Rhino.Core.Classes.InspectMethod.IsValid(bool)'></a>

## InspectMethod\.IsValid\(bool\) Method

Determines whether the inspected method is valid based on its return type\.

```csharp
public bool IsValid(out bool enumerable);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.InspectMethod.IsValid(bool).enumerable'></a>

`enumerable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When this method returns, contains a boolean value indicating whether the return type is an enumerable collection\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the method is valid; otherwise, false\.

<a name='DiGi.Rhino.Core.Classes.InspectMethod.TryGetValue_T_(object,T)'></a>

## InspectMethod\.TryGetValue\<T\>\(object, T\) Method

Attempts to invoke the inspected method and convert its result to a specified type\.

```csharp
public bool TryGetValue<T>(object? @object, out T? value);
```
#### Type parameters

<a name='DiGi.Rhino.Core.Classes.InspectMethod.TryGetValue_T_(object,T).T'></a>

`T`

The target type for the return value\.
#### Parameters

<a name='DiGi.Rhino.Core.Classes.InspectMethod.TryGetValue_T_(object,T).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object instance to use for invocation \(if applicable\)\.

<a name='DiGi.Rhino.Core.Classes.InspectMethod.TryGetValue_T_(object,T).value'></a>

`value` [T](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.InspectMethod.TryGetValue_T_(object,T).T 'DiGi\.Rhino\.Core\.Classes\.InspectMethod\.TryGetValue\<T\>\(object, T\)\.T')

When this method returns, contains the converted value if successful; otherwise, the default value of \<typeparam ref="T" /\>\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved and converted; otherwise, false\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes'></a>

## NullAttributes Class

Provides a null implementation of the [Grasshopper\.Kernel\.IGH\_Attributes](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_attributes 'Grasshopper\.Kernel\.IGH\_Attributes') interface,
serving as a placeholder or default attribute set that performs no operations\.

```csharp
public class NullAttributes
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.IGH\_Attributes](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_attributes 'Grasshopper\.Kernel\.IGH\_Attributes') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [Grasshopper\.GUI\.Canvas\.IGH\_ResponsiveObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.igh_responsiveobject 'Grasshopper\.GUI\.Canvas\.IGH\_ResponsiveObject') → [Grasshopper\.GUI\.Canvas\.IGH\_TooltipAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.igh_tooltipawareobject 'Grasshopper\.GUI\.Canvas\.IGH\_TooltipAwareObject') → NullAttributes
### Constructors

<a name='DiGi.Rhino.Core.Classes.NullAttributes.NullAttributes()'></a>

## NullAttributes\(\) Constructor

Initializes a new instance of the [NullAttributes](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.NullAttributes 'DiGi\.Rhino\.Core\.Classes\.NullAttributes') class\.

```csharp
public NullAttributes();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.NullAttributes.AllowMessageBalloon'></a>

## NullAttributes\.AllowMessageBalloon Property

Gets a value indicating whether message balloons are allowed for these attributes\.

```csharp
public bool AllowMessageBalloon { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Rhino.Core.Classes.NullAttributes.Bounds'></a>

## NullAttributes\.Bounds Property

Gets or sets the bounding rectangle of the attributes\.

```csharp
public System.Drawing.RectangleF Bounds { get; set; }
```

#### Property Value
[System\.Drawing\.RectangleF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectanglef 'System\.Drawing\.RectangleF')

#### Exceptions

[System\.NotImplementedException](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception 'System\.NotImplementedException')  
Thrown when setting the value\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.DocObject'></a>

## NullAttributes\.DocObject Property

Gets the document object associated with these attributes\.

```csharp
public IGH_DocumentObject? DocObject { get; }
```

#### Property Value
[Grasshopper\.Kernel\.IGH\_DocumentObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_documentobject 'Grasshopper\.Kernel\.IGH\_DocumentObject')

<a name='DiGi.Rhino.Core.Classes.NullAttributes.GetTopLevel'></a>

## NullAttributes\.GetTopLevel Property

Gets the top\-level attribute set in the hierarchy\.

```csharp
public IGH_Attributes? GetTopLevel { get; }
```

#### Property Value
[Grasshopper\.Kernel\.IGH\_Attributes](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_attributes 'Grasshopper\.Kernel\.IGH\_Attributes')

<a name='DiGi.Rhino.Core.Classes.NullAttributes.HasInputGrip'></a>

## NullAttributes\.HasInputGrip Property

Gets a value indicating whether the attributes have an input grip\.

```csharp
public bool HasInputGrip { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Rhino.Core.Classes.NullAttributes.HasOutputGrip'></a>

## NullAttributes\.HasOutputGrip Property

Gets a value indicating whether the attributes have an output grip\.

```csharp
public bool HasOutputGrip { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Rhino.Core.Classes.NullAttributes.InputGrip'></a>

## NullAttributes\.InputGrip Property

Gets the position of the input grip on the canvas\.

```csharp
public System.Drawing.PointF InputGrip { get; }
```

#### Property Value
[System\.Drawing\.PointF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pointf 'System\.Drawing\.PointF')

<a name='DiGi.Rhino.Core.Classes.NullAttributes.InstanceGuid'></a>

## NullAttributes\.InstanceGuid Property

Gets the unique identifier for this instance of the attributes\.

```csharp
public System.Guid InstanceGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.NullAttributes.IsTopLevel'></a>

## NullAttributes\.IsTopLevel Property

Gets a value indicating whether these attributes are at the top level of the hierarchy\.

```csharp
public bool IsTopLevel { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Rhino.Core.Classes.NullAttributes.OutputGrip'></a>

## NullAttributes\.OutputGrip Property

Gets the position of the output grip on the canvas\.

```csharp
public System.Drawing.PointF OutputGrip { get; }
```

#### Property Value
[System\.Drawing\.PointF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pointf 'System\.Drawing\.PointF')

<a name='DiGi.Rhino.Core.Classes.NullAttributes.Parent'></a>

## NullAttributes\.Parent Property

Gets or sets the parent attribute set\.

```csharp
public IGH_Attributes? Parent { get; set; }
```

#### Property Value
[Grasshopper\.Kernel\.IGH\_Attributes](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_attributes 'Grasshopper\.Kernel\.IGH\_Attributes')

#### Exceptions

[System\.NotImplementedException](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception 'System\.NotImplementedException')  
Thrown when setting the value\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.PathName'></a>

## NullAttributes\.PathName Property

Gets the path name associated with these attributes\.

```csharp
public string PathName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Rhino.Core.Classes.NullAttributes.Pivot'></a>

## NullAttributes\.Pivot Property

Gets or sets the pivot point of the attributes\.

```csharp
public System.Drawing.PointF Pivot { get; set; }
```

#### Property Value
[System\.Drawing\.PointF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pointf 'System\.Drawing\.PointF')

#### Exceptions

[System\.NotImplementedException](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception 'System\.NotImplementedException')  
Thrown when setting the value\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.Selected'></a>

## NullAttributes\.Selected Property

Gets or sets a value indicating whether these attributes are currently selected\.

```csharp
public bool Selected { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

#### Exceptions

[System\.NotImplementedException](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception 'System\.NotImplementedException')  
Thrown when setting the value\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.TooltipEnabled'></a>

## NullAttributes\.TooltipEnabled Property

Gets a value indicating whether tooltips are enabled for these attributes\.

```csharp
public bool TooltipEnabled { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')
### Methods

<a name='DiGi.Rhino.Core.Classes.NullAttributes.AppendToAttributeTree(System.Collections.Generic.List_IGH_Attributes_)'></a>

## NullAttributes\.AppendToAttributeTree\(List\<IGH\_Attributes\>\) Method

Appends the current attribute instance to the provided attribute tree list\.

```csharp
public void AppendToAttributeTree(System.Collections.Generic.List<IGH_Attributes> attributes);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.AppendToAttributeTree(System.Collections.Generic.List_IGH_Attributes_).attributes'></a>

`attributes` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Grasshopper\.Kernel\.IGH\_Attributes](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_attributes 'Grasshopper\.Kernel\.IGH\_Attributes')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of attributes to append to\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.ExpireLayout()'></a>

## NullAttributes\.ExpireLayout\(\) Method

Notifies the system that the layout of the attributes has expired and needs to be recalculated\.

```csharp
public void ExpireLayout();
```

<a name='DiGi.Rhino.Core.Classes.NullAttributes.InvalidateCanvas(GH_Canvas,GH_CanvasMouseEvent)'></a>

## NullAttributes\.InvalidateCanvas\(GH\_Canvas, GH\_CanvasMouseEvent\) Method

Determines whether the canvas should be invalidated based on a mouse event\.

```csharp
public bool InvalidateCanvas(GH_Canvas canvas, GH_CanvasMouseEvent e);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.InvalidateCanvas(GH_Canvas,GH_CanvasMouseEvent).canvas'></a>

`canvas` [Grasshopper\.GUI\.Canvas\.GH\_Canvas](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_canvas 'Grasshopper\.GUI\.Canvas\.GH\_Canvas')

The canvas where the event occurred\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.InvalidateCanvas(GH_Canvas,GH_CanvasMouseEvent).e'></a>

`e` [Grasshopper\.GUI\.GH\_CanvasMouseEvent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.gh_canvasmouseevent 'Grasshopper\.GUI\.GH\_CanvasMouseEvent')

The mouse event arguments\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the canvas should be invalidated; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.IsMenuRegion(System.Drawing.PointF)'></a>

## NullAttributes\.IsMenuRegion\(PointF\) Method

Determines whether a specific point on the canvas is within the menu region of these attributes\.

```csharp
public bool IsMenuRegion(System.Drawing.PointF point);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.IsMenuRegion(System.Drawing.PointF).point'></a>

`point` [System\.Drawing\.PointF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pointf 'System\.Drawing\.PointF')

The point to test\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the point is in the menu region; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.IsPickRegion(System.Drawing.PointF)'></a>

## NullAttributes\.IsPickRegion\(PointF\) Method

Determines whether a specific point on the canvas is within the pickable region of these attributes\.

```csharp
public bool IsPickRegion(System.Drawing.PointF point);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.IsPickRegion(System.Drawing.PointF).point'></a>

`point` [System\.Drawing\.PointF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pointf 'System\.Drawing\.PointF')

The point to test\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the point is in the pick region; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.IsPickRegion(System.Drawing.RectangleF,GH_PickBox)'></a>

## NullAttributes\.IsPickRegion\(RectangleF, GH\_PickBox\) Method

Determines whether a specific rectangular area on the canvas intersects with the pickable region of these attributes\.

```csharp
public bool IsPickRegion(System.Drawing.RectangleF box, GH_PickBox method);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.IsPickRegion(System.Drawing.RectangleF,GH_PickBox).box'></a>

`box` [System\.Drawing\.RectangleF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectanglef 'System\.Drawing\.RectangleF')

The bounding box to test\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.IsPickRegion(System.Drawing.RectangleF,GH_PickBox).method'></a>

`method` [Grasshopper\.Kernel\.GH\_PickBox](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_pickbox 'Grasshopper\.Kernel\.GH\_PickBox')

The picking method used\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the area is in the pick region; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.IsTooltipRegion(System.Drawing.PointF)'></a>

## NullAttributes\.IsTooltipRegion\(PointF\) Method

Determines whether a specific point on the canvas is within the tooltip region of these attributes\.

```csharp
public bool IsTooltipRegion(System.Drawing.PointF canvasPoint);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.IsTooltipRegion(System.Drawing.PointF).canvasPoint'></a>

`canvasPoint` [System\.Drawing\.PointF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pointf 'System\.Drawing\.PointF')

The point to test\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the point is in the tooltip region; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.NewInstanceGuid()'></a>

## NullAttributes\.NewInstanceGuid\(\) Method

Generates a new unique identifier for this instance\.

```csharp
public void NewInstanceGuid();
```

#### Exceptions

[System\.NotImplementedException](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception 'System\.NotImplementedException')  
Thrown because this method is not implemented\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.NewInstanceGuid(System.Guid)'></a>

## NullAttributes\.NewInstanceGuid\(Guid\) Method

Assigns a specific unique identifier to this instance\.

```csharp
public void NewInstanceGuid(System.Guid newID);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.NewInstanceGuid(System.Guid).newID'></a>

`newID` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The new GUID to assign\.

#### Exceptions

[System\.NotImplementedException](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception 'System\.NotImplementedException')  
Thrown because this method is not implemented\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.PerformLayout()'></a>

## NullAttributes\.PerformLayout\(\) Method

Performs the layout calculations for the attributes\.

```csharp
public void PerformLayout();
```

#### Exceptions

[System\.NotImplementedException](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception 'System\.NotImplementedException')  
Thrown because this method is not implemented\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.Read(GH_IReader)'></a>

## NullAttributes\.Read\(GH\_IReader\) Method

Reads the attributes from a serialization reader\.

```csharp
public bool Read(GH_IReader reader);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.Read(GH_IReader).reader'></a>

`reader` [GH\_IO\.Serialization\.GH\_IReader](https://learn.microsoft.com/en-us/dotnet/api/gh_io.serialization.gh_ireader 'GH\_IO\.Serialization\.GH\_IReader')

The reader to read data from\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if reading was successful; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RenderToCanvas(GH_Canvas,GH_CanvasChannel)'></a>

## NullAttributes\.RenderToCanvas\(GH\_Canvas, GH\_CanvasChannel\) Method

Renders the attributes onto the Grasshopper canvas using the specified channel\.

```csharp
public void RenderToCanvas(GH_Canvas canvas, GH_CanvasChannel channel);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RenderToCanvas(GH_Canvas,GH_CanvasChannel).canvas'></a>

`canvas` [Grasshopper\.GUI\.Canvas\.GH\_Canvas](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_canvas 'Grasshopper\.GUI\.Canvas\.GH\_Canvas')

The canvas to render on\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RenderToCanvas(GH_Canvas,GH_CanvasChannel).channel'></a>

`channel` [Grasshopper\.GUI\.Canvas\.GH\_CanvasChannel](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_canvaschannel 'Grasshopper\.GUI\.Canvas\.GH\_CanvasChannel')

The rendering channel to use\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToKeyDown(GH_Canvas,System.Windows.Forms.KeyEventArgs)'></a>

## NullAttributes\.RespondToKeyDown\(GH\_Canvas, KeyEventArgs\) Method

Handles the key down event on the canvas\.

```csharp
public GH_ObjectResponse RespondToKeyDown(GH_Canvas sender, System.Windows.Forms.KeyEventArgs e);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToKeyDown(GH_Canvas,System.Windows.Forms.KeyEventArgs).sender'></a>

`sender` [Grasshopper\.GUI\.Canvas\.GH\_Canvas](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_canvas 'Grasshopper\.GUI\.Canvas\.GH\_Canvas')

The canvas that sent the event\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToKeyDown(GH_Canvas,System.Windows.Forms.KeyEventArgs).e'></a>

`e` [System\.Windows\.Forms\.KeyEventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keyeventargs 'System\.Windows\.Forms\.KeyEventArgs')

The key event arguments\.

#### Returns
[Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_objectresponse 'Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse')  
A [Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_objectresponse 'Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse') indicating how the event was handled\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToKeyUp(GH_Canvas,System.Windows.Forms.KeyEventArgs)'></a>

## NullAttributes\.RespondToKeyUp\(GH\_Canvas, KeyEventArgs\) Method

Handles the key up event on the canvas\.

```csharp
public GH_ObjectResponse RespondToKeyUp(GH_Canvas sender, System.Windows.Forms.KeyEventArgs e);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToKeyUp(GH_Canvas,System.Windows.Forms.KeyEventArgs).sender'></a>

`sender` [Grasshopper\.GUI\.Canvas\.GH\_Canvas](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_canvas 'Grasshopper\.GUI\.Canvas\.GH\_Canvas')

The canvas that sent the event\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToKeyUp(GH_Canvas,System.Windows.Forms.KeyEventArgs).e'></a>

`e` [System\.Windows\.Forms\.KeyEventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keyeventargs 'System\.Windows\.Forms\.KeyEventArgs')

The key event arguments\.

#### Returns
[Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_objectresponse 'Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse')  
A [Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_objectresponse 'Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse') indicating how the event was handled\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToMouseDoubleClick(GH_Canvas,GH_CanvasMouseEvent)'></a>

## NullAttributes\.RespondToMouseDoubleClick\(GH\_Canvas, GH\_CanvasMouseEvent\) Method

Handles the mouse double\-click event on the canvas\.

```csharp
public GH_ObjectResponse RespondToMouseDoubleClick(GH_Canvas sender, GH_CanvasMouseEvent e);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToMouseDoubleClick(GH_Canvas,GH_CanvasMouseEvent).sender'></a>

`sender` [Grasshopper\.GUI\.Canvas\.GH\_Canvas](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_canvas 'Grasshopper\.GUI\.Canvas\.GH\_Canvas')

The canvas that sent the event\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToMouseDoubleClick(GH_Canvas,GH_CanvasMouseEvent).e'></a>

`e` [Grasshopper\.GUI\.GH\_CanvasMouseEvent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.gh_canvasmouseevent 'Grasshopper\.GUI\.GH\_CanvasMouseEvent')

The mouse event arguments\.

#### Returns
[Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_objectresponse 'Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse')  
A [Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_objectresponse 'Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse') indicating how the event was handled\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToMouseDown(GH_Canvas,GH_CanvasMouseEvent)'></a>

## NullAttributes\.RespondToMouseDown\(GH\_Canvas, GH\_CanvasMouseEvent\) Method

Handles the mouse down event on the canvas\.

```csharp
public GH_ObjectResponse RespondToMouseDown(GH_Canvas sender, GH_CanvasMouseEvent e);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToMouseDown(GH_Canvas,GH_CanvasMouseEvent).sender'></a>

`sender` [Grasshopper\.GUI\.Canvas\.GH\_Canvas](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_canvas 'Grasshopper\.GUI\.Canvas\.GH\_Canvas')

The canvas that sent the event\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToMouseDown(GH_Canvas,GH_CanvasMouseEvent).e'></a>

`e` [Grasshopper\.GUI\.GH\_CanvasMouseEvent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.gh_canvasmouseevent 'Grasshopper\.GUI\.GH\_CanvasMouseEvent')

The mouse event arguments\.

#### Returns
[Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_objectresponse 'Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse')  
A [Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_objectresponse 'Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse') indicating how the event was handled\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToMouseMove(GH_Canvas,GH_CanvasMouseEvent)'></a>

## NullAttributes\.RespondToMouseMove\(GH\_Canvas, GH\_CanvasMouseEvent\) Method

Handles the mouse move event on the canvas\.

```csharp
public GH_ObjectResponse RespondToMouseMove(GH_Canvas sender, GH_CanvasMouseEvent e);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToMouseMove(GH_Canvas,GH_CanvasMouseEvent).sender'></a>

`sender` [Grasshopper\.GUI\.Canvas\.GH\_Canvas](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_canvas 'Grasshopper\.GUI\.Canvas\.GH\_Canvas')

The canvas that sent the event\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToMouseMove(GH_Canvas,GH_CanvasMouseEvent).e'></a>

`e` [Grasshopper\.GUI\.GH\_CanvasMouseEvent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.gh_canvasmouseevent 'Grasshopper\.GUI\.GH\_CanvasMouseEvent')

The mouse event arguments\.

#### Returns
[Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_objectresponse 'Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse')  
A [Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_objectresponse 'Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse') indicating how the event was handled\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToMouseUp(GH_Canvas,GH_CanvasMouseEvent)'></a>

## NullAttributes\.RespondToMouseUp\(GH\_Canvas, GH\_CanvasMouseEvent\) Method

Handles the mouse up event on the canvas\.

```csharp
public GH_ObjectResponse RespondToMouseUp(GH_Canvas sender, GH_CanvasMouseEvent e);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToMouseUp(GH_Canvas,GH_CanvasMouseEvent).sender'></a>

`sender` [Grasshopper\.GUI\.Canvas\.GH\_Canvas](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_canvas 'Grasshopper\.GUI\.Canvas\.GH\_Canvas')

The canvas that sent the event\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.RespondToMouseUp(GH_Canvas,GH_CanvasMouseEvent).e'></a>

`e` [Grasshopper\.GUI\.GH\_CanvasMouseEvent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.gh_canvasmouseevent 'Grasshopper\.GUI\.GH\_CanvasMouseEvent')

The mouse event arguments\.

#### Returns
[Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_objectresponse 'Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse')  
A [Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.canvas.gh_objectresponse 'Grasshopper\.GUI\.Canvas\.GH\_ObjectResponse') indicating how the event was handled\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.SetupTooltip(System.Drawing.PointF,GH_TooltipDisplayEventArgs)'></a>

## NullAttributes\.SetupTooltip\(PointF, GH\_TooltipDisplayEventArgs\) Method

Configures the tooltip display for these attributes at a specific canvas point\.

```csharp
public void SetupTooltip(System.Drawing.PointF canvasPoint, GH_TooltipDisplayEventArgs e);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.SetupTooltip(System.Drawing.PointF,GH_TooltipDisplayEventArgs).canvasPoint'></a>

`canvasPoint` [System\.Drawing\.PointF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pointf 'System\.Drawing\.PointF')

The point on the canvas where the tooltip is triggered\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.SetupTooltip(System.Drawing.PointF,GH_TooltipDisplayEventArgs).e'></a>

`e` [Grasshopper\.GUI\.GH\_TooltipDisplayEventArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.gui.gh_tooltipdisplayeventargs 'Grasshopper\.GUI\.GH\_TooltipDisplayEventArgs')

The tooltip display event arguments\.

<a name='DiGi.Rhino.Core.Classes.NullAttributes.Write(GH_IWriter)'></a>

## NullAttributes\.Write\(GH\_IWriter\) Method

Writes the attributes to a serialization writer\.

```csharp
public bool Write(GH_IWriter writer);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.NullAttributes.Write(GH_IWriter).writer'></a>

`writer` [GH\_IO\.Serialization\.GH\_IWriter](https://learn.microsoft.com/en-us/dotnet/api/gh_io.serialization.gh_iwriter 'GH\_IO\.Serialization\.GH\_IWriter')

The writer to write data to\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if writing was successful; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.NumberComparisonType'></a>

## NumberComparisonType Class

Represents a component that allows the selection of a number comparison type\.

```csharp
public class NumberComparisonType : DiGi.Rhino.Core.Classes.EnumComponent<DiGi.Core.Enums.NumberComparisonType>
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.EnumComponent&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.EnumComponent_T_ 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\<T\>')[DiGi\.Core\.Enums\.NumberComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.numbercomparisontype 'DiGi\.Core\.Enums\.NumberComparisonType')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.EnumComponent_T_ 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\<T\>') → NumberComparisonType
### Constructors

<a name='DiGi.Rhino.Core.Classes.NumberComparisonType.NumberComparisonType()'></a>

## NumberComparisonType\(\) Constructor

Initializes a new instance of the [NumberComparisonType](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.NumberComparisonType 'DiGi\.Rhino\.Core\.Classes\.NumberComparisonType') class\.

```csharp
public NumberComparisonType();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.NumberComparisonType.ComponentGuid'></a>

## NumberComparisonType\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.Read'></a>

## Read Class

A Grasshopper component that reads serializable objects from a specified file path\.

```csharp
public class Read : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Read
### Constructors

<a name='DiGi.Rhino.Core.Classes.Read.Read()'></a>

## Read\(\) Constructor

Initializes a new instance of the [Read](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Read 'DiGi\.Rhino\.Core\.Classes\.Read') class\.

```csharp
public Read();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.Read.ComponentGuid'></a>

## Read\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.Read.Exposure'></a>

## Read\.Exposure Property

Gets the exposure level of the component, determining how it is displayed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.Read.Inputs'></a>

## Read\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.Read.Outputs'></a>

## Read\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.Read.SolveInstance(IGH_DataAccess)'></a>

## Read\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.Read.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Core.Classes.RemoveValue'></a>

## RemoveValue Class

A component that removes a specific parameter definition from a parametrized object\.

```csharp
public class RemoveValue : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → RemoveValue
### Constructors

<a name='DiGi.Rhino.Core.Classes.RemoveValue.RemoveValue()'></a>

## RemoveValue\(\) Constructor

Initializes a new instance of the [RemoveValue](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.RemoveValue 'DiGi\.Rhino\.Core\.Classes\.RemoveValue') class\.

```csharp
public RemoveValue();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.RemoveValue.ComponentGuid'></a>

## RemoveValue\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.RemoveValue.Exposure'></a>

## RemoveValue\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.RemoveValue.Inputs'></a>

## RemoveValue\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.RemoveValue.Outputs'></a>

## RemoveValue\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.RemoveValue.SolveInstance(IGH_DataAccess)'></a>

## RemoveValue\.SolveInstance\(IGH\_DataAccess\) Method

Executes the logic to remove a specific parameter definition from the provided parametrized object\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.RemoveValue.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object used to retrieve data from inputs and store results in outputs\.

<a name='DiGi.Rhino.Core.Classes.RhinoInfo'></a>

## RhinoInfo Class

Provides assembly information for the DiGi\.Rhino\.Core Grasshopper plugin\.

```csharp
public class RhinoInfo
```

Inheritance [Grasshopper\.Kernel\.GH\_AssemblyInfo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_assemblyinfo 'Grasshopper\.Kernel\.GH\_AssemblyInfo') → RhinoInfo
### Properties

<a name='DiGi.Rhino.Core.Classes.RhinoInfo.AuthorContact'></a>

## RhinoInfo\.AuthorContact Property

Gets the preferred contact details for the author\.

```csharp
public override string AuthorContact { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Rhino.Core.Classes.RhinoInfo.AuthorName'></a>

## RhinoInfo\.AuthorName Property

Gets the name of the author or company\.

```csharp
public override string AuthorName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Rhino.Core.Classes.RhinoInfo.Description'></a>

## RhinoInfo\.Description Property

Gets a short string describing the purpose of this GHA library\.

```csharp
public override string Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Rhino.Core.Classes.RhinoInfo.Icon'></a>

## RhinoInfo\.Icon Property

Gets a 24x24 pixel bitmap to represent this GHA library\.

```csharp
public override System.Drawing.Bitmap? Icon { get; }
```

#### Property Value
[System\.Drawing\.Bitmap](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bitmap 'System\.Drawing\.Bitmap')

<a name='DiGi.Rhino.Core.Classes.RhinoInfo.Id'></a>

## RhinoInfo\.Id Property

Gets the unique identifier for this assembly\.

```csharp
public override System.Guid Id { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.RhinoInfo.Name'></a>

## RhinoInfo\.Name Property

Gets the name of the GHA library\.

```csharp
public override string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Rhino.Core.Classes.Serialize'></a>

## Serialize Class

A Grasshopper component that serializes a collection of [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') objects into a JSON string format\.

```csharp
public class Serialize : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Serialize
### Constructors

<a name='DiGi.Rhino.Core.Classes.Serialize.Serialize()'></a>

## Serialize\(\) Constructor

Initializes a new instance of object\.

```csharp
public Serialize();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.Serialize.ComponentGuid'></a>

## Serialize\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.Serialize.Exposure'></a>

## Serialize\.Exposure Property

Gets the exposure level of the component, which determines how it is displayed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.Serialize.Inputs'></a>

## Serialize\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.Serialize.Outputs'></a>

## Serialize\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.Serialize.SolveInstance(IGH_DataAccess)'></a>

## Serialize\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.Serialize.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Core.Classes.SetValue'></a>

## SetValue Class

A Grasshopper component that sets a value for a given parameter definition on a parametrized object\.

```csharp
public class SetValue : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → SetValue
### Constructors

<a name='DiGi.Rhino.Core.Classes.SetValue.SetValue()'></a>

## SetValue\(\) Constructor

Initializes a new instance of object\.

```csharp
public SetValue();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.SetValue.ComponentGuid'></a>

## SetValue\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.SetValue.Exposure'></a>

## SetValue\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.SetValue.Inputs'></a>

## SetValue\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.SetValue.Outputs'></a>

## SetValue\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.SetValue.SolveInstance(IGH_DataAccess)'></a>

## SetValue\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.SetValue.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Core.Classes.TextComparisonType'></a>

## TextComparisonType Class

Represents the text comparison type component, providing functionality to specify how two strings are compared\.

```csharp
public class TextComparisonType : DiGi.Rhino.Core.Classes.EnumComponent<DiGi.Core.Enums.TextComparisonType>
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.EnumComponent&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.EnumComponent_T_ 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\<T\>')[DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.EnumComponent_T_ 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\<T\>') → TextComparisonType
### Constructors

<a name='DiGi.Rhino.Core.Classes.TextComparisonType.TextComparisonType()'></a>

## TextComparisonType\(\) Constructor

Initializes a new instance of the [TextComparisonType](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.TextComparisonType 'DiGi\.Rhino\.Core\.Classes\.TextComparisonType') class\.

```csharp
public TextComparisonType();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.TextComparisonType.ComponentGuid'></a>

## TextComparisonType\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.TimeSeries'></a>

## TimeSeries Class

Represents a Grasshopper component that generates a time series based on a specified start time, end time, and step interval\.

```csharp
public class TimeSeries : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → TimeSeries
### Constructors

<a name='DiGi.Rhino.Core.Classes.TimeSeries.TimeSeries()'></a>

## TimeSeries\(\) Constructor

Initializes a new instance of the [TimeSeries](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.TimeSeries 'DiGi\.Rhino\.Core\.Classes\.TimeSeries') class\.

```csharp
public TimeSeries();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.TimeSeries.ComponentGuid'></a>

## TimeSeries\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.TimeSeries.Exposure'></a>

## TimeSeries\.Exposure Property

Gets the exposure level of the component, determining its visibility and priority in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.TimeSeries.Inputs'></a>

## TimeSeries\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.TimeSeries.Outputs'></a>

## TimeSeries\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.TimeSeries.SolveInstance(IGH_DataAccess)'></a>

## TimeSeries\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.TimeSeries.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Core.Classes.TypeByFullName'></a>

## TypeByFullName Class

A Grasshopper component that retrieves a \.NET [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type') based on its full assembly\-qualified name\.

```csharp
public class TypeByFullName : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → TypeByFullName
### Constructors

<a name='DiGi.Rhino.Core.Classes.TypeByFullName.TypeByFullName()'></a>

## TypeByFullName\(\) Constructor

Initializes a new instance of the [TypeByFullName](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.TypeByFullName 'DiGi\.Rhino\.Core\.Classes\.TypeByFullName') class\.

```csharp
public TypeByFullName();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.TypeByFullName.ComponentGuid'></a>

## TypeByFullName\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.TypeByFullName.Exposure'></a>

## TypeByFullName\.Exposure Property

Gets the exposure level of the component, which determines its visual representation in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.TypeByFullName.Inputs'></a>

## TypeByFullName\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.TypeByFullName.Outputs'></a>

## TypeByFullName\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.TypeByFullName.SolveInstance(IGH_DataAccess)'></a>

## TypeByFullName\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.TypeByFullName.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Core.Classes.TypeByObject'></a>

## TypeByObject Class

A Grasshopper component that retrieves the type of a given input object\.

```csharp
public class TypeByObject : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → TypeByObject
### Constructors

<a name='DiGi.Rhino.Core.Classes.TypeByObject.TypeByObject()'></a>

## TypeByObject\(\) Constructor

Initializes a new instance of the [TypeByObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.TypeByObject 'DiGi\.Rhino\.Core\.Classes\.TypeByObject') class\.

```csharp
public TypeByObject();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.TypeByObject.ComponentGuid'></a>

## TypeByObject\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.TypeByObject.Exposure'></a>

## TypeByObject\.Exposure Property

Gets the exposure level of the component, which defines how it is displayed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.TypeByObject.Inputs'></a>

## TypeByObject\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.TypeByObject.Outputs'></a>

## TypeByObject\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.TypeByObject.SolveInstance(IGH_DataAccess)'></a>

## TypeByObject\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.TypeByObject.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Core.Classes.UTC'></a>

## UTC Class

Represents a component for handling Coordinated Universal Time \(UTC\) time zones\.

```csharp
public class UTC : DiGi.Rhino.Core.Classes.EnumComponent<DiGi.Core.Enums.UTC>
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.EnumComponent&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.EnumComponent_T_ 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\<T\>')[DiGi\.Core\.Enums\.UTC](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.utc 'DiGi\.Core\.Enums\.UTC')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.EnumComponent_T_ 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\<T\>') → UTC
### Constructors

<a name='DiGi.Rhino.Core.Classes.UTC.UTC()'></a>

## UTC\(\) Constructor

Initializes a new instance of the [UTC](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.UTC 'DiGi\.Rhino\.Core\.Classes\.UTC') class\.

```csharp
public UTC();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.UTC.ComponentGuid'></a>

## UTC\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent'></a>

## VariableParameterComponent Class

Provides a base implementation for Grasshopper components that support dynamic addition and removal of parameters based on predefined templates\.

```csharp
public abstract class VariableParameterComponent : DiGi.Rhino.Core.Classes.Component
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → VariableParameterComponent

Derived  
↳ [Address](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Address 'DiGi\.Rhino\.Core\.Classes\.Address')  
↳ [Coordinates](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Coordinates 'DiGi\.Rhino\.Core\.Classes\.Coordinates')  
↳ [Deserialize](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Deserialize 'DiGi\.Rhino\.Core\.Classes\.Deserialize')  
↳ [FilterByMask](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.FilterByMask 'DiGi\.Rhino\.Core\.Classes\.FilterByMask')  
↳ [FilterByNumber](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.FilterByNumber 'DiGi\.Rhino\.Core\.Classes\.FilterByNumber')  
↳ [FilterByText](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.FilterByText 'DiGi\.Rhino\.Core\.Classes\.FilterByText')  
↳ [GetValue](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GetValue 'DiGi\.Rhino\.Core\.Classes\.GetValue')  
↳ [Read](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Read 'DiGi\.Rhino\.Core\.Classes\.Read')  
↳ [RemoveValue](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.RemoveValue 'DiGi\.Rhino\.Core\.Classes\.RemoveValue')  
↳ [Serialize](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Serialize 'DiGi\.Rhino\.Core\.Classes\.Serialize')  
↳ [SetValue](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.SetValue 'DiGi\.Rhino\.Core\.Classes\.SetValue')  
↳ [TimeSeries](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.TimeSeries 'DiGi\.Rhino\.Core\.Classes\.TimeSeries')  
↳ [TypeByFullName](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.TypeByFullName 'DiGi\.Rhino\.Core\.Classes\.TypeByFullName')  
↳ [TypeByObject](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.TypeByObject 'DiGi\.Rhino\.Core\.Classes\.TypeByObject')  
↳ [Write](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Write 'DiGi\.Rhino\.Core\.Classes\.Write')
### Constructors

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.VariableParameterComponent(string,string,string,string,string)'></a>

## VariableParameterComponent\(string, string, string, string, string\) Constructor

Initializes a new instance of the [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') class\.

```csharp
public VariableParameterComponent(string name, string nickname, string description, string category, string subCategory);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.VariableParameterComponent(string,string,string,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the component\.

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.VariableParameterComponent(string,string,string,string,string).nickname'></a>

`nickname` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The nickname of the component\.

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.VariableParameterComponent(string,string,string,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the component\.

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.VariableParameterComponent(string,string,string,string,string).category'></a>

`category` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The category the component belongs to\.

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.VariableParameterComponent(string,string,string,string,string).subCategory'></a>

`subCategory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The sub\-category the component belongs to\.
### Properties

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.Inputs'></a>

## VariableParameterComponent\.Inputs Property

Gets the template definitions for the input parameters\.

```csharp
protected abstract DiGi.Rhino.Core.Classes.Param[]? Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.Outputs'></a>

## VariableParameterComponent\.Outputs Property

Gets the template definitions for the output parameters\.

```csharp
protected abstract DiGi.Rhino.Core.Classes.Param[]? Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.CanInsertParameter(GH_ParameterSide,int)'></a>

## VariableParameterComponent\.CanInsertParameter\(GH\_ParameterSide, int\) Method

Determines whether a parameter can be inserted at the specified index on the given side of the component\.

```csharp
public bool CanInsertParameter(GH_ParameterSide parameterSide, int index);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.CanInsertParameter(GH_ParameterSide,int).parameterSide'></a>

`parameterSide` [Grasshopper\.Kernel\.GH\_ParameterSide](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_parameterside 'Grasshopper\.Kernel\.GH\_ParameterSide')

The side \(Input or Output\) where the parameter is to be inserted\.

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.CanInsertParameter(GH_ParameterSide,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index position for insertion\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the parameter can be inserted; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.CanRemoveParameter(GH_ParameterSide,int)'></a>

## VariableParameterComponent\.CanRemoveParameter\(GH\_ParameterSide, int\) Method

Determines whether a parameter can be removed from the specified index on the given side of the component\.

```csharp
public bool CanRemoveParameter(GH_ParameterSide parameterSide, int index);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.CanRemoveParameter(GH_ParameterSide,int).parameterSide'></a>

`parameterSide` [Grasshopper\.Kernel\.GH\_ParameterSide](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_parameterside 'Grasshopper\.Kernel\.GH\_ParameterSide')

The side \(Input or Output\) where the parameter is to be removed\.

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.CanRemoveParameter(GH_ParameterSide,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index position of the parameter to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the parameter can be removed; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.CreateParameter(GH_ParameterSide,int)'></a>

## VariableParameterComponent\.CreateParameter\(GH\_ParameterSide, int\) Method

Creates a new parameter based on the template definition for the specified side and index\.

```csharp
public IGH_Param? CreateParameter(GH_ParameterSide parameterSide, int index);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.CreateParameter(GH_ParameterSide,int).parameterSide'></a>

`parameterSide` [Grasshopper\.Kernel\.GH\_ParameterSide](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_parameterside 'Grasshopper\.Kernel\.GH\_ParameterSide')

The side \(Input or Output\) where the parameter is to be created\.

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.CreateParameter(GH_ParameterSide,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index position for creation\.

#### Returns
[Grasshopper\.Kernel\.IGH\_Param](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_param 'Grasshopper\.Kernel\.IGH\_Param')  
A cloned instance of the template parameter, or `null` if no suitable template exists\.

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.DestroyParameter(GH_ParameterSide,int)'></a>

## VariableParameterComponent\.DestroyParameter\(GH\_ParameterSide, int\) Method

Destroys a parameter at the specified index on the given side of the component\.

```csharp
public virtual bool DestroyParameter(GH_ParameterSide parameterSide, int index);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.DestroyParameter(GH_ParameterSide,int).parameterSide'></a>

`parameterSide` [Grasshopper\.Kernel\.GH\_ParameterSide](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_parameterside 'Grasshopper\.Kernel\.GH\_ParameterSide')

The side \(Input or Output\) where the parameter is to be destroyed\.

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.DestroyParameter(GH_ParameterSide,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index position of the parameter to destroy\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the parameter was successfully destroyed; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.RegisterInputParams(GH_InputParamManager)'></a>

## VariableParameterComponent\.RegisterInputParams\(GH\_InputParamManager\) Method

Registers the default input parameters based on the provided templates\.

```csharp
protected sealed override void RegisterInputParams(GH_InputParamManager inputParamManager);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.RegisterInputParams(GH_InputParamManager).inputParamManager'></a>

`inputParamManager` [Grasshopper\.Kernel\.GH\_Component\.GH\_InputParamManager](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component.gh_inputparammanager 'Grasshopper\.Kernel\.GH\_Component\.GH\_InputParamManager')

The manager used to register input parameters\.

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.RegisterOutputParams(GH_OutputParamManager)'></a>

## VariableParameterComponent\.RegisterOutputParams\(GH\_OutputParamManager\) Method

Registers the default output parameters based on the provided templates\.

```csharp
protected sealed override void RegisterOutputParams(GH_OutputParamManager outputParamManager);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.RegisterOutputParams(GH_OutputParamManager).outputParamManager'></a>

`outputParamManager` [Grasshopper\.Kernel\.GH\_Component\.GH\_OutputParamManager](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component.gh_outputparammanager 'Grasshopper\.Kernel\.GH\_Component\.GH\_OutputParamManager')

The manager used to register output parameters\.

<a name='DiGi.Rhino.Core.Classes.VariableParameterComponent.VariableParameterMaintenance()'></a>

## VariableParameterComponent\.VariableParameterMaintenance\(\) Method

Performs maintenance tasks on the variable parameters of the component\.

```csharp
public void VariableParameterMaintenance();
```

<a name='DiGi.Rhino.Core.Classes.Write'></a>

## Write Class

A Grasshopper component that serializes a collection of [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instances and writes them to a file in JSON format\.

```csharp
public class Write : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [Component](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [VariableParameterComponent](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.VariableParameterComponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Write
### Constructors

<a name='DiGi.Rhino.Core.Classes.Write.Write()'></a>

## Write\(\) Constructor

Initializes a new instance of the [Write](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Write 'DiGi\.Rhino\.Core\.Classes\.Write') class\.

```csharp
public Write();
```
### Properties

<a name='DiGi.Rhino.Core.Classes.Write.ComponentGuid'></a>

## Write\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Core.Classes.Write.Exposure'></a>

## Write\.Exposure Property

Gets the exposure level of the component, which determines how it is displayed and interacted with in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Core.Classes.Write.Inputs'></a>

## Write\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Core.Classes.Write.Outputs'></a>

## Write\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Core.Classes.Write.SolveInstance(IGH_DataAccess)'></a>

## Write\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.Write.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.
### Structs

<a name='DiGi.Rhino.Core.Classes.Param'></a>

## Param Struct

Represents a wrapper for a Grasshopper parameter, including its visibility settings\.

```csharp
public readonly struct Param
```
### Constructors

<a name='DiGi.Rhino.Core.Classes.Param.Param(IGH_Param)'></a>

## Param\(IGH\_Param\) Constructor

Initializes a new instance of the [Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param') struct with default visibility set to [Binding](DiGi.Rhino.Core.Enums.md#DiGi.Rhino.Core.Enums.ParameterVisibility.Binding 'DiGi\.Rhino\.Core\.Enums\.ParameterVisibility\.Binding')\.

```csharp
public Param(IGH_Param gH_Param);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.Param.Param(IGH_Param).gH_Param'></a>

`gH_Param` [Grasshopper\.Kernel\.IGH\_Param](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_param 'Grasshopper\.Kernel\.IGH\_Param')

The Grasshopper parameter to wrap\.

<a name='DiGi.Rhino.Core.Classes.Param.Param(IGH_Param,DiGi.Rhino.Core.Enums.ParameterVisibility)'></a>

## Param\(IGH\_Param, ParameterVisibility\) Constructor

Initializes a new instance of the [Param](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.Param 'DiGi\.Rhino\.Core\.Classes\.Param') struct with specified visibility\.

```csharp
public Param(IGH_Param gH_Param, DiGi.Rhino.Core.Enums.ParameterVisibility parameterVisibility);
```
#### Parameters

<a name='DiGi.Rhino.Core.Classes.Param.Param(IGH_Param,DiGi.Rhino.Core.Enums.ParameterVisibility).gH_Param'></a>

`gH_Param` [Grasshopper\.Kernel\.IGH\_Param](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_param 'Grasshopper\.Kernel\.IGH\_Param')

The Grasshopper parameter to wrap\.

<a name='DiGi.Rhino.Core.Classes.Param.Param(IGH_Param,DiGi.Rhino.Core.Enums.ParameterVisibility).parameterVisibility'></a>

`parameterVisibility` [ParameterVisibility](DiGi.Rhino.Core.Enums.md#DiGi.Rhino.Core.Enums.ParameterVisibility 'DiGi\.Rhino\.Core\.Enums\.ParameterVisibility')

The visibility setting for the parameter\.
### Fields

<a name='DiGi.Rhino.Core.Classes.Param.GH_Param'></a>

## Param\.GH\_Param Field

Gets the underlying Grasshopper parameter instance\.

```csharp
public readonly IGH_Param GH_Param;
```

#### Field Value
[Grasshopper\.Kernel\.IGH\_Param](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_param 'Grasshopper\.Kernel\.IGH\_Param')

<a name='DiGi.Rhino.Core.Classes.Param.ParameterVisibility'></a>

## Param\.ParameterVisibility Field

Gets the visibility setting for this parameter\.

```csharp
public readonly ParameterVisibility ParameterVisibility;
```

#### Field Value
[ParameterVisibility](DiGi.Rhino.Core.Enums.md#DiGi.Rhino.Core.Enums.ParameterVisibility 'DiGi\.Rhino\.Core\.Enums\.ParameterVisibility')
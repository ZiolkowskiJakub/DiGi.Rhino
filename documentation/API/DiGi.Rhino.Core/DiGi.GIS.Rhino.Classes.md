#### [DiGi\.Rhino\.Core](DiGi.Rhino.Core.Overview.md 'DiGi\.Rhino\.Core\.Overview')

## DiGi\.GIS\.Rhino\.Classes Namespace
### Classes

<a name='DiGi.GIS.Rhino.Classes.GooAddress'></a>

## GooAddress Class

Represents a Grasshopper Goo wrapper for a physical mailing address\.

```csharp
public class GooAddress : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Core.Classes.Address>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>')[DiGi\.Core\.Classes\.Address](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.address 'DiGi\.Core\.Classes\.Address')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>')[DiGi\.Core\.Classes\.Address](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.address 'DiGi\.Core\.Classes\.Address')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>') → GooAddress
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooAddress.GooAddress()'></a>

## GooAddress\(\) Constructor

Initializes a new instance of the [GooAddress](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAddress 'DiGi\.GIS\.Rhino\.Classes\.GooAddress') class\.

```csharp
public GooAddress();
```

<a name='DiGi.GIS.Rhino.Classes.GooAddress.GooAddress(DiGi.Core.Classes.Address)'></a>

## GooAddress\(Address\) Constructor

Initializes a new instance of the [GooAddress](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAddress 'DiGi\.GIS\.Rhino\.Classes\.GooAddress') class with the specified address\.

```csharp
public GooAddress(DiGi.Core.Classes.Address? address);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GooAddress.GooAddress(DiGi.Core.Classes.Address).address'></a>

`address` [DiGi\.Core\.Classes\.Address](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.address 'DiGi\.Core\.Classes\.Address')

The physical mailing address to wrap\.
### Methods

<a name='DiGi.GIS.Rhino.Classes.GooAddress.Duplicate()'></a>

## GooAddress\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing the same address value\.

<a name='DiGi.GIS.Rhino.Classes.GooAddressParam'></a>

## GooAddressParam Class

Represents a Grasshopper parameter that handles [GooAddress](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAddress 'DiGi\.GIS\.Rhino\.Classes\.GooAddress') objects\.

```csharp
public class GooAddressParam : DiGi.Rhino.Core.Classes.GooSerializablePresistentParam<DiGi.GIS.Rhino.Classes.GooAddress, DiGi.Core.Classes.Address>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>')[GooAddress](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAddress 'DiGi\.GIS\.Rhino\.Classes\.GooAddress')[,](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>')[DiGi\.Core\.Classes\.Address](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.address 'DiGi\.Core\.Classes\.Address')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>')[GooAddress](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAddress 'DiGi\.GIS\.Rhino\.Classes\.GooAddress')[,](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>')[DiGi\.Core\.Classes\.Address](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.address 'DiGi\.Core\.Classes\.Address')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>') → GooAddressParam
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooAddressParam.GooAddressParam()'></a>

## GooAddressParam\(\) Constructor

Initializes a new instance of the [GooAddressParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAddressParam 'DiGi\.GIS\.Rhino\.Classes\.GooAddressParam') class\.

```csharp
public GooAddressParam();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.GooAddressParam.ComponentGuid'></a>

## GooAddressParam\.ComponentGuid Property

Gets the unique identifier for the [GooAddressParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAddressParam 'DiGi\.GIS\.Rhino\.Classes\.GooAddressParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')  
The GUID of the component\.

<a name='DiGi.GIS.Rhino.Classes.GooCoordinates'></a>

## GooCoordinates Class

Represents a Grasshopper Goo wrapper for geographic coordinates\.

```csharp
public class GooCoordinates : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Core.Classes.Coordinates>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>')[DiGi\.Core\.Classes\.Coordinates](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.coordinates 'DiGi\.Core\.Classes\.Coordinates')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>')[DiGi\.Core\.Classes\.Coordinates](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.coordinates 'DiGi\.Core\.Classes\.Coordinates')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>') → GooCoordinates
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooCoordinates.GooCoordinates()'></a>

## GooCoordinates\(\) Constructor

Initializes a new instance of the [GooCoordinates](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooCoordinates 'DiGi\.GIS\.Rhino\.Classes\.GooCoordinates') class\.

```csharp
public GooCoordinates();
```

<a name='DiGi.GIS.Rhino.Classes.GooCoordinates.GooCoordinates(DiGi.Core.Classes.Coordinates)'></a>

## GooCoordinates\(Coordinates\) Constructor

Initializes a new instance of the [GooCoordinates](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooCoordinates 'DiGi\.GIS\.Rhino\.Classes\.GooCoordinates') class with the specified coordinates\.

```csharp
public GooCoordinates(DiGi.Core.Classes.Coordinates? coordinates);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GooCoordinates.GooCoordinates(DiGi.Core.Classes.Coordinates).coordinates'></a>

`coordinates` [DiGi\.Core\.Classes\.Coordinates](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.coordinates 'DiGi\.Core\.Classes\.Coordinates')

The geographic coordinates to wrap\.
### Methods

<a name='DiGi.GIS.Rhino.Classes.GooCoordinates.Duplicate()'></a>

## GooCoordinates\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing the same coordinate value\.

<a name='DiGi.GIS.Rhino.Classes.GooCoordinatesParam'></a>

## GooCoordinatesParam Class

Represents a Grasshopper parameter for geographic coordinates\.

```csharp
public class GooCoordinatesParam : DiGi.Rhino.Core.Classes.GooSerializablePresistentParam<DiGi.GIS.Rhino.Classes.GooCoordinates, DiGi.Core.Classes.Coordinates>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>')[GooCoordinates](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooCoordinates 'DiGi\.GIS\.Rhino\.Classes\.GooCoordinates')[,](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>')[DiGi\.Core\.Classes\.Coordinates](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.coordinates 'DiGi\.Core\.Classes\.Coordinates')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>')[GooCoordinates](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooCoordinates 'DiGi\.GIS\.Rhino\.Classes\.GooCoordinates')[,](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>')[DiGi\.Core\.Classes\.Coordinates](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.coordinates 'DiGi\.Core\.Classes\.Coordinates')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>') → GooCoordinatesParam
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooCoordinatesParam.GooCoordinatesParam()'></a>

## GooCoordinatesParam\(\) Constructor

Initializes a new instance of the [GooCoordinatesParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooCoordinatesParam 'DiGi\.GIS\.Rhino\.Classes\.GooCoordinatesParam') class\.

```csharp
public GooCoordinatesParam();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.GooCoordinatesParam.ComponentGuid'></a>

## GooCoordinatesParam\.ComponentGuid Property

Gets the unique identifier for the coordinate component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')  
The [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid') associated with this parameter type\.

<a name='DiGi.GIS.Rhino.Classes.GooParameter'></a>

## GooParameter Class

Represents a Goo wrapper for a [DiGi\.Core\.Parameter\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter') object,
enabling it to be passed through Grasshopper wires and stored in the document\.

```csharp
public class GooParameter : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Core.Parameter.Classes.Parameter>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>')[DiGi\.Core\.Parameter\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>')[DiGi\.Core\.Parameter\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>') → GooParameter
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooParameter.GooParameter()'></a>

## GooParameter\(\) Constructor

Initializes a new instance of the [GooParameter](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameter 'DiGi\.GIS\.Rhino\.Classes\.GooParameter') class\.

```csharp
public GooParameter();
```

<a name='DiGi.GIS.Rhino.Classes.GooParameter.GooParameter(DiGi.Core.Parameter.Classes.Parameter)'></a>

## GooParameter\(Parameter\) Constructor

Initializes a new instance of the [GooParameter](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameter 'DiGi\.GIS\.Rhino\.Classes\.GooParameter') class with the specified parameter value\.

```csharp
public GooParameter(DiGi.Core.Parameter.Classes.Parameter? parameter);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GooParameter.GooParameter(DiGi.Core.Parameter.Classes.Parameter).parameter'></a>

`parameter` [DiGi\.Core\.Parameter\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')

The [DiGi\.Core\.Parameter\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter') to wrap\.
### Methods

<a name='DiGi.GIS.Rhino.Classes.GooParameter.Duplicate()'></a>

## GooParameter\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing a copy of the wrapped value\.

<a name='DiGi.GIS.Rhino.Classes.GooParameterDefinition'></a>

## GooParameterDefinition Class

Represents a serializable Goo wrapper for an [DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparameterdefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')\.

```csharp
public class GooParameterDefinition : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Core.Parameter.Interfaces.IParameterDefinition>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>')[DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparameterdefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>')[DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparameterdefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>') → GooParameterDefinition
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooParameterDefinition.GooParameterDefinition()'></a>

## GooParameterDefinition\(\) Constructor

Initializes a new instance of the [GooParameterDefinition](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameterDefinition 'DiGi\.GIS\.Rhino\.Classes\.GooParameterDefinition') class\.

```csharp
public GooParameterDefinition();
```

<a name='DiGi.GIS.Rhino.Classes.GooParameterDefinition.GooParameterDefinition(DiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## GooParameterDefinition\(IParameterDefinition\) Constructor

Initializes a new instance of the [GooParameterDefinition](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameterDefinition 'DiGi\.GIS\.Rhino\.Classes\.GooParameterDefinition') class with the specified parameter definition\.

```csharp
public GooParameterDefinition(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GooParameterDefinition.GooParameterDefinition(DiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparameterdefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition to wrap\.
### Methods

<a name='DiGi.GIS.Rhino.Classes.GooParameterDefinition.Duplicate()'></a>

## GooParameterDefinition\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing the same value\.

<a name='DiGi.GIS.Rhino.Classes.GooParameterDefinitionParam'></a>

## GooParameterDefinitionParam Class

Represents the Grasshopper parameter type for [GooParameterDefinition](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameterDefinition 'DiGi\.GIS\.Rhino\.Classes\.GooParameterDefinition')\.

```csharp
public class GooParameterDefinitionParam : DiGi.Rhino.Core.Classes.GooSerializablePresistentParam<DiGi.GIS.Rhino.Classes.GooParameterDefinition, DiGi.Core.Parameter.Interfaces.IParameterDefinition>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>')[GooParameterDefinition](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameterDefinition 'DiGi\.GIS\.Rhino\.Classes\.GooParameterDefinition')[,](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>')[DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparameterdefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>')[GooParameterDefinition](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameterDefinition 'DiGi\.GIS\.Rhino\.Classes\.GooParameterDefinition')[,](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>')[DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparameterdefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>') → GooParameterDefinitionParam
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooParameterDefinitionParam.GooParameterDefinitionParam()'></a>

## GooParameterDefinitionParam\(\) Constructor

Initializes a new instance of the [GooParameterDefinitionParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameterDefinitionParam 'DiGi\.GIS\.Rhino\.Classes\.GooParameterDefinitionParam') class\.

```csharp
public GooParameterDefinitionParam();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.GooParameterDefinitionParam.ComponentGuid'></a>

## GooParameterDefinitionParam\.ComponentGuid Property

Gets the unique identifier for the component associated with this parameter\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')  
The GUID of the component\.

<a name='DiGi.GIS.Rhino.Classes.GooParameterParam'></a>

## GooParameterParam Class

Represents the Grasshopper parameter type used to handle and persist [GooParameter](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameter 'DiGi\.GIS\.Rhino\.Classes\.GooParameter') objects\.

```csharp
public class GooParameterParam : DiGi.Rhino.Core.Classes.GooSerializablePresistentParam<DiGi.GIS.Rhino.Classes.GooParameter, DiGi.Core.Parameter.Classes.Parameter>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>')[GooParameter](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameter 'DiGi\.GIS\.Rhino\.Classes\.GooParameter')[,](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>')[DiGi\.Core\.Parameter\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>')[GooParameter](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameter 'DiGi\.GIS\.Rhino\.Classes\.GooParameter')[,](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>')[DiGi\.Core\.Parameter\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>') → GooParameterParam
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooParameterParam.GooParameterParam()'></a>

## GooParameterParam\(\) Constructor

Initializes a new instance of the [GooParameterParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameterParam 'DiGi\.GIS\.Rhino\.Classes\.GooParameterParam') class\.

```csharp
public GooParameterParam();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.GooParameterParam.ComponentGuid'></a>

## GooParameterParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.GooParametrizedObject'></a>

## GooParametrizedObject Class

Represents a Goo wrapper for an [DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizedobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject'), enabling it to be used within the Grasshopper environment and supporting serialization\.

```csharp
public class GooParametrizedObject : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Core.Parameter.Interfaces.IParametrizedObject>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>')[DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizedobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>')[DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizedobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>') → GooParametrizedObject
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooParametrizedObject.GooParametrizedObject()'></a>

## GooParametrizedObject\(\) Constructor

Initializes a new instance of the [GooParametrizedObject](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParametrizedObject 'DiGi\.GIS\.Rhino\.Classes\.GooParametrizedObject') class\.

```csharp
public GooParametrizedObject();
```

<a name='DiGi.GIS.Rhino.Classes.GooParametrizedObject.GooParametrizedObject(DiGi.Core.Parameter.Interfaces.IParametrizedObject)'></a>

## GooParametrizedObject\(IParametrizedObject\) Constructor

Initializes a new instance of the [GooParametrizedObject](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParametrizedObject 'DiGi\.GIS\.Rhino\.Classes\.GooParametrizedObject') class with the specified parameterized object\.

```csharp
public GooParametrizedObject(DiGi.Core.Parameter.Interfaces.IParametrizedObject? parametrizedObject);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GooParametrizedObject.GooParametrizedObject(DiGi.Core.Parameter.Interfaces.IParametrizedObject).parametrizedObject'></a>

`parametrizedObject` [DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizedobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject')

The parameterized object to wrap\.
### Methods

<a name='DiGi.GIS.Rhino.Classes.GooParametrizedObject.Duplicate()'></a>

## GooParametrizedObject\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooParametrizedObject](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParametrizedObject 'DiGi\.GIS\.Rhino\.Classes\.GooParametrizedObject') containing the same value\.

<a name='DiGi.GIS.Rhino.Classes.GooParametrizedObjectParam'></a>

## GooParametrizedObjectParam Class

Represents the Grasshopper parameter type for [GooParametrizedObject](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParametrizedObject 'DiGi\.GIS\.Rhino\.Classes\.GooParametrizedObject')\.

```csharp
public class GooParametrizedObjectParam : DiGi.Rhino.Core.Classes.GooSerializablePresistentParam<DiGi.GIS.Rhino.Classes.GooParametrizedObject, DiGi.Core.Parameter.Interfaces.IParametrizedObject>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>')[GooParametrizedObject](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParametrizedObject 'DiGi\.GIS\.Rhino\.Classes\.GooParametrizedObject')[,](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>')[DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizedobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>')[GooParametrizedObject](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParametrizedObject 'DiGi\.GIS\.Rhino\.Classes\.GooParametrizedObject')[,](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>')[DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizedobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>') → GooParametrizedObjectParam
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooParametrizedObjectParam.GooParametrizedObjectParam()'></a>

## GooParametrizedObjectParam\(\) Constructor

Initializes a new instance of the [GooParametrizedObjectParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParametrizedObjectParam 'DiGi\.GIS\.Rhino\.Classes\.GooParametrizedObjectParam') class\.

```csharp
public GooParametrizedObjectParam();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.GooParametrizedObjectParam.ComponentGuid'></a>

## GooParametrizedObjectParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.GooTimeSeries'></a>

## GooTimeSeries Class

Represents a Goo wrapper for time\-series data, enabling its use and serialization within the Grasshopper environment\.

```csharp
public class GooTimeSeries : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Core.Interfaces.ITimeSeries>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>')[DiGi\.Core\.Interfaces\.ITimeSeries](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.itimeseries 'DiGi\.Core\.Interfaces\.ITimeSeries')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>')[DiGi\.Core\.Interfaces\.ITimeSeries](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.itimeseries 'DiGi\.Core\.Interfaces\.ITimeSeries')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>') → GooTimeSeries
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooTimeSeries.GooTimeSeries()'></a>

## GooTimeSeries\(\) Constructor

Initializes a new instance of the [GooTimeSeries](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooTimeSeries 'DiGi\.GIS\.Rhino\.Classes\.GooTimeSeries') class\.

```csharp
public GooTimeSeries();
```

<a name='DiGi.GIS.Rhino.Classes.GooTimeSeries.GooTimeSeries(DiGi.Core.Interfaces.ITimeSeries)'></a>

## GooTimeSeries\(ITimeSeries\) Constructor

Initializes a new instance of the [GooTimeSeries](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooTimeSeries 'DiGi\.GIS\.Rhino\.Classes\.GooTimeSeries') class with the specified time series value\.

```csharp
public GooTimeSeries(DiGi.Core.Interfaces.ITimeSeries? timeSeries);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GooTimeSeries.GooTimeSeries(DiGi.Core.Interfaces.ITimeSeries).timeSeries'></a>

`timeSeries` [DiGi\.Core\.Interfaces\.ITimeSeries](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.itimeseries 'DiGi\.Core\.Interfaces\.ITimeSeries')

The time series data to wrap\.
### Methods

<a name='DiGi.GIS.Rhino.Classes.GooTimeSeries.Duplicate()'></a>

## GooTimeSeries\.Duplicate\(\) Method

Creates a duplicate of the current [GooTimeSeries](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooTimeSeries 'DiGi\.GIS\.Rhino\.Classes\.GooTimeSeries') object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing a copy of the original value\.

<a name='DiGi.GIS.Rhino.Classes.GooTimeSeriesParam'></a>

## GooTimeSeriesParam Class

Represents a persistent Grasshopper parameter for handling [GooTimeSeries](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooTimeSeries 'DiGi\.GIS\.Rhino\.Classes\.GooTimeSeries') objects\.

```csharp
public class GooTimeSeriesParam : DiGi.Rhino.Core.Classes.GooSerializablePresistentParam<DiGi.GIS.Rhino.Classes.GooTimeSeries, DiGi.Core.Interfaces.ITimeSeries>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>')[GooTimeSeries](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooTimeSeries 'DiGi\.GIS\.Rhino\.Classes\.GooTimeSeries')[,](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>')[DiGi\.Core\.Interfaces\.ITimeSeries](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.itimeseries 'DiGi\.Core\.Interfaces\.ITimeSeries')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooPresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\<T,X\>') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>')[GooTimeSeries](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooTimeSeries 'DiGi\.GIS\.Rhino\.Classes\.GooTimeSeries')[,](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>')[DiGi\.Core\.Interfaces\.ITimeSeries](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.itimeseries 'DiGi\.Core\.Interfaces\.ITimeSeries')[&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializablePresistentParam_T,X_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\<T,X\>') → GooTimeSeriesParam
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooTimeSeriesParam.GooTimeSeriesParam()'></a>

## GooTimeSeriesParam\(\) Constructor

Initializes a new instance of the [GooTimeSeriesParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooTimeSeriesParam 'DiGi\.GIS\.Rhino\.Classes\.GooTimeSeriesParam') class\.

```csharp
public GooTimeSeriesParam();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.GooTimeSeriesParam.ComponentGuid'></a>

## GooTimeSeriesParam\.ComponentGuid Property

Gets the unique identifier \(GUID\) for the [GooTimeSeriesParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooTimeSeriesParam 'DiGi\.GIS\.Rhino\.Classes\.GooTimeSeriesParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')
#### [DiGi\.Rhino\.Core](index.md 'index')

## DiGi\.Rhino\.Core Namespace
### Classes

<a name='DiGi.Rhino.Core.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.Rhino.Core.Convert.ToDiGi(thisInterval)'></a>

## Convert\.ToDiGi\(this Interval\) Method

Converts a [Rhino\.Geometry\.Interval](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.interval 'Rhino\.Geometry\.Interval') to a nullable [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')\.

```csharp
public static DiGi.Core.Classes.Range<double>? ToDiGi(this Interval interval);
```
#### Parameters

<a name='DiGi.Rhino.Core.Convert.ToDiGi(thisInterval).interval'></a>

`interval` [Rhino\.Geometry\.Interval](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.interval 'Rhino\.Geometry\.Interval')

The interval to convert\.

#### Returns
[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')  
A [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of [double](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/double 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/double') representing the interval, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the interval is unset\.

<a name='DiGi.Rhino.Core.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Rhino.Core.Create.GH_Goo(thisDiGi.Core.Parameter.Enums.ParameterType,object)'></a>

## Create\.GH\_Goo\(this ParameterType, object\) Method

Converts a given value to its corresponding Grasshopper Goo representation based on the specified parameter type\.

```csharp
public static IGH_Goo? GH_Goo(this DiGi.Core.Parameter.Enums.ParameterType parameterType, object? value);
```
#### Parameters

<a name='DiGi.Rhino.Core.Create.GH_Goo(thisDiGi.Core.Parameter.Enums.ParameterType,object).parameterType'></a>

`parameterType` [DiGi\.Core\.Parameter\.Enums\.ParameterType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.enums.parametertype 'DiGi\.Core\.Parameter\.Enums\.ParameterType')

The type of parameter used to determine which GH\_Goo implementation to create\.

<a name='DiGi.Rhino.Core.Create.GH_Goo(thisDiGi.Core.Parameter.Enums.ParameterType,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object value to be converted into a Goo object\.

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
An [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance wrapping the value, or `null` if the conversion fails or the value is null\.

#### Exceptions

[System\.NotImplementedException](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception 'System\.NotImplementedException')  
Thrown when the provided [parameterType](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Create.GH_Goo(thisDiGi.Core.Parameter.Enums.ParameterType,object).parameterType 'DiGi\.Rhino\.Core\.Create\.GH\_Goo\(this DiGi\.Core\.Parameter\.Enums\.ParameterType, object\)\.parameterType') is not supported\.

<a name='DiGi.Rhino.Core.Create.GooParams(thisDiGi.Rhino.Core.Interfaces.IGooSerializableObject)'></a>

## Create\.GooParams\(this IGooSerializableObject\) Method

Retrieves the list of goo parameters associated with the specified serializable object\.

```csharp
public static System.Collections.Generic.List<DiGi.Rhino.Core.Classes.GooParam>? GooParams(this DiGi.Rhino.Core.Interfaces.IGooSerializableObject? gooSerializableObject);
```
#### Parameters

<a name='DiGi.Rhino.Core.Create.GooParams(thisDiGi.Rhino.Core.Interfaces.IGooSerializableObject).gooSerializableObject'></a>

`gooSerializableObject` [IGooSerializableObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooSerializableObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject')

The serializable object to extract parameters from\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GooParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooParam 'DiGi\.Rhino\.Core\.Classes\.GooParam')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [GooParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooParam 'DiGi\.Rhino\.Core\.Classes\.GooParam') objects if found; otherwise, `null`\.

<a name='DiGi.Rhino.Core.Create.GooParams(thisobject)'></a>

## Create\.GooParams\(this object\) Method

Retrieves the list of goo parameters associated with the specified object based on its type and inspection settings\.

```csharp
public static System.Collections.Generic.List<DiGi.Rhino.Core.Classes.GooParam>? GooParams(this object? @object);
```
#### Parameters

<a name='DiGi.Rhino.Core.Create.GooParams(thisobject).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to inspect for parameters\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GooParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooParam 'DiGi\.Rhino\.Core\.Classes\.GooParam')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [GooParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooParam 'DiGi\.Rhino\.Core\.Classes\.GooParam') objects if found; otherwise, `null`\.

<a name='DiGi.Rhino.Core.Inspect'></a>

## Inspect Class

```csharp
public static class Inspect
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Inspect
### Methods

<a name='DiGi.Rhino.Core.Inspect.City(thisDiGi.Core.Classes.Address)'></a>

## Inspect\.City\(this Address\) Method

Extracts the city name from the provided address as a Grasshopper string\.

```csharp
public static GH_String? City(this DiGi.Core.Classes.Address? address);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.City(thisDiGi.Core.Classes.Address).address'></a>

`address` [DiGi\.Core\.Classes\.Address](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.address 'DiGi\.Core\.Classes\.Address')

The address object to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the city, or `null` if the address is null\.

<a name='DiGi.Rhino.Core.Inspect.CountryCode(thisDiGi.Core.Classes.Address)'></a>

## Inspect\.CountryCode\(this Address\) Method

Extracts the country code from the provided address as a Grasshopper enum\.

```csharp
public static DiGi.Rhino.Core.Classes.GooEnum? CountryCode(this DiGi.Core.Classes.Address? address);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.CountryCode(thisDiGi.Core.Classes.Address).address'></a>

`address` [DiGi\.Core\.Classes\.Address](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.address 'DiGi\.Core\.Classes\.Address')

The address object to inspect\.

#### Returns
[GooEnum](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum 'DiGi\.Rhino\.Core\.Classes\.GooEnum')  
A [GooEnum](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum 'DiGi\.Rhino\.Core\.Classes\.GooEnum') containing the country code, or `null` if the address is null\.

<a name='DiGi.Rhino.Core.Inspect.DateTimes(thisDiGi.Core.Interfaces.ITimeSeries)'></a>

## Inspect\.DateTimes\(this ITimeSeries\) Method

Extracts the date\-times from a time series and converts them into a collection of Grasshopper GH\_Time objects\.

```csharp
public static System.Collections.IEnumerable? DateTimes(this DiGi.Core.Interfaces.ITimeSeries? timeSeries);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.DateTimes(thisDiGi.Core.Interfaces.ITimeSeries).timeSeries'></a>

`timeSeries` [DiGi\.Core\.Interfaces\.ITimeSeries](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.itimeseries 'DiGi\.Core\.Interfaces\.ITimeSeries')

The time series instance to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An enumerable collection of [Grasshopper\.Kernel\.Types\.GH\_Time](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_time 'Grasshopper\.Kernel\.Types\.GH\_Time') objects if the time series is provided; otherwise, null\.

<a name='DiGi.Rhino.Core.Inspect.FullTypeName(thisSystem.Type)'></a>

## Inspect\.FullTypeName\(this Type\) Method

Gets the full type name of the specified type as a [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')\.

```csharp
public static GH_String? FullTypeName(this System.Type? type);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.FullTypeName(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the formatted full type name, or `null` if the provided type is null\.

<a name='DiGi.Rhino.Core.Inspect.GroupName(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## Inspect\.GroupName\(this IParameterDefinition\) Method

Gets the group name of the specified parameter definition as a [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')\.

```csharp
public static GH_String? GroupName(this DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.GroupName(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparameterdefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the group name, or `null` if the [parameterDefinition](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Inspect.GroupName(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition 'DiGi\.Rhino\.Core\.Inspect\.GroupName\(this DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\)\.parameterDefinition') is null\.

<a name='DiGi.Rhino.Core.Inspect.Guid(thisDiGi.Core.Interfaces.IGuidObject)'></a>

## Inspect\.Guid\(this IGuidObject\) Method

Converts an [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject') to a Grasshopper [Grasshopper\.Kernel\.Types\.GH\_Guid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_guid 'Grasshopper\.Kernel\.Types\.GH\_Guid')\.

```csharp
public static GH_Guid? Guid(this DiGi.Core.Interfaces.IGuidObject? guidObject);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.Guid(thisDiGi.Core.Interfaces.IGuidObject).guidObject'></a>

`guidObject` [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')

The object implementing [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject') to be converted\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Guid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_guid 'Grasshopper\.Kernel\.Types\.GH\_Guid')  
A [Grasshopper\.Kernel\.Types\.GH\_Guid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_guid 'Grasshopper\.Kernel\.Types\.GH\_Guid') representation of the object's GUID, or `null` if the provided [guidObject](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Inspect.Guid(thisDiGi.Core.Interfaces.IGuidObject).guidObject 'DiGi\.Rhino\.Core\.Inspect\.Guid\(this DiGi\.Core\.Interfaces\.IGuidObject\)\.guidObject') is null\.

<a name='DiGi.Rhino.Core.Inspect.Name(thisDiGi.Core.Parameter.Classes.Parameter)'></a>

## Inspect\.Name\(this Parameter\) Method

Gets the name of the specified parameter as a [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')\.

```csharp
public static GH_String? Name(this DiGi.Core.Parameter.Classes.Parameter? parameter);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.Name(thisDiGi.Core.Parameter.Classes.Parameter).parameter'></a>

`parameter` [DiGi\.Core\.Parameter\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')

The parameter to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the parameter's name, or `null` if the parameter is null\.

<a name='DiGi.Rhino.Core.Inspect.Name(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## Inspect\.Name\(this IParameterDefinition\) Method

Gets the name of the specified parameter definition as a [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')\.

```csharp
public static GH_String? Name(this DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.Name(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparameterdefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the name, or `null` if the [parameterDefinition](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Inspect.Name(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition 'DiGi\.Rhino\.Core\.Inspect\.Name\(this DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\)\.parameterDefinition') is null\.

<a name='DiGi.Rhino.Core.Inspect.Name(thisSystem.Type)'></a>

## Inspect\.Name\(this Type\) Method

Gets the name of the specified type as a [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')\.

```csharp
public static GH_String? Name(this System.Type? type);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.Name(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the full name of the type, or `null` if the provided type is null\.

<a name='DiGi.Rhino.Core.Inspect.ParameterDefinition(thisDiGi.Core.Parameter.Classes.Parameter)'></a>

## Inspect\.ParameterDefinition\(this Parameter\) Method

Gets the definition of the specified parameter as a [GooParameterDefinition](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameterDefinition 'DiGi\.GIS\.Rhino\.Classes\.GooParameterDefinition')\.

```csharp
public static DiGi.GIS.Rhino.Classes.GooParameterDefinition? ParameterDefinition(this DiGi.Core.Parameter.Classes.Parameter? parameter);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.ParameterDefinition(thisDiGi.Core.Parameter.Classes.Parameter).parameter'></a>

`parameter` [DiGi\.Core\.Parameter\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')

The parameter to inspect\.

#### Returns
[GooParameterDefinition](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameterDefinition 'DiGi\.GIS\.Rhino\.Classes\.GooParameterDefinition')  
A [GooParameterDefinition](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameterDefinition 'DiGi\.GIS\.Rhino\.Classes\.GooParameterDefinition') wrapping the parameter's definition, or `null` if the parameter is null\.

<a name='DiGi.Rhino.Core.Inspect.Parameters(thisDiGi.Core.Parameter.Interfaces.IParametrizedObject)'></a>

## Inspect\.Parameters\(this IParametrizedObject\) Method

Retrieves a collection of parameters from the specified parametrized object\.

```csharp
public static System.Collections.IEnumerable? Parameters(this DiGi.Core.Parameter.Interfaces.IParametrizedObject? parametrizedObject);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.Parameters(thisDiGi.Core.Parameter.Interfaces.IParametrizedObject).parametrizedObject'></a>

`parametrizedObject` [DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizedobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject')

The object that implements [DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizedobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject') and contains the parameters to be retrieved\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An enumerable collection of [GooParameter](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooParameter 'DiGi\.GIS\.Rhino\.Classes\.GooParameter') objects if successful; otherwise, null\.

<a name='DiGi.Rhino.Core.Inspect.ParameterType(thisDiGi.Core.Parameter.Classes.Parameter)'></a>

## Inspect\.ParameterType\(this Parameter\) Method

Gets the type of the specified parameter as a [GooEnum](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum 'DiGi\.Rhino\.Core\.Classes\.GooEnum')\.

```csharp
public static DiGi.Rhino.Core.Classes.GooEnum? ParameterType(this DiGi.Core.Parameter.Classes.Parameter? parameter);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.ParameterType(thisDiGi.Core.Parameter.Classes.Parameter).parameter'></a>

`parameter` [DiGi\.Core\.Parameter\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')

The parameter to inspect\.

#### Returns
[GooEnum](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum 'DiGi\.Rhino\.Core\.Classes\.GooEnum')  
A [GooEnum](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum 'DiGi\.Rhino\.Core\.Classes\.GooEnum') wrapping the parameter's type, or `null` if the parameter is null\.

<a name='DiGi.Rhino.Core.Inspect.ParameterType(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## Inspect\.ParameterType\(this IParameterDefinition\) Method

Gets the parameter type of the specified parameter definition as a [GooEnum](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum 'DiGi\.Rhino\.Core\.Classes\.GooEnum')\.

```csharp
public static DiGi.Rhino.Core.Classes.GooEnum? ParameterType(this DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.ParameterType(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparameterdefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition to inspect\.

#### Returns
[GooEnum](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum 'DiGi\.Rhino\.Core\.Classes\.GooEnum')  
A [GooEnum](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum 'DiGi\.Rhino\.Core\.Classes\.GooEnum') containing the parameter type, or `null` if the [parameterDefinition](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Inspect.ParameterType(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition 'DiGi\.Rhino\.Core\.Inspect\.ParameterType\(this DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\)\.parameterDefinition') is null\.

<a name='DiGi.Rhino.Core.Inspect.PostalCode(thisDiGi.Core.Classes.Address)'></a>

## Inspect\.PostalCode\(this Address\) Method

Extracts the postal code from the provided address as a Grasshopper string\.

```csharp
public static GH_String? PostalCode(this DiGi.Core.Classes.Address? address);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.PostalCode(thisDiGi.Core.Classes.Address).address'></a>

`address` [DiGi\.Core\.Classes\.Address](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.address 'DiGi\.Core\.Classes\.Address')

The address object to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the postal code, or `null` if the address is null\.

<a name='DiGi.Rhino.Core.Inspect.Street(thisDiGi.Core.Classes.Address)'></a>

## Inspect\.Street\(this Address\) Method

Extracts the street name from the provided address as a Grasshopper string\.

```csharp
public static GH_String? Street(this DiGi.Core.Classes.Address? address);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.Street(thisDiGi.Core.Classes.Address).address'></a>

`address` [DiGi\.Core\.Classes\.Address](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.address 'DiGi\.Core\.Classes\.Address')

The address object to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the street, or `null` if the address is null\.

<a name='DiGi.Rhino.Core.Inspect.UniqueId(thisDiGi.Core.Interfaces.IUniqueIdObject)'></a>

## Inspect\.UniqueId\(this IUniqueIdObject\) Method

Extracts the unique identifier from an object implementing [DiGi\.Core\.Interfaces\.IUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueidobject 'DiGi\.Core\.Interfaces\.IUniqueIdObject') and wraps it in a [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')\.

```csharp
public static GH_String? UniqueId(this DiGi.Core.Interfaces.IUniqueIdObject? uniqueIdObject);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.UniqueId(thisDiGi.Core.Interfaces.IUniqueIdObject).uniqueIdObject'></a>

`uniqueIdObject` [DiGi\.Core\.Interfaces\.IUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueidobject 'DiGi\.Core\.Interfaces\.IUniqueIdObject')

The object that provides the unique identifier\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the unique ID if the input is not null; otherwise, `null`\.

<a name='DiGi.Rhino.Core.Inspect.UniqueId(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## Inspect\.UniqueId\(this IParameterDefinition\) Method

Gets the unique identifier of the specified parameter definition as a [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')\.

```csharp
public static GH_String? UniqueId(this DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.UniqueId(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparameterdefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the unique identifier, or `null` if the [parameterDefinition](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Inspect.UniqueId(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition 'DiGi\.Rhino\.Core\.Inspect\.UniqueId\(this DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition\)\.parameterDefinition') is null\.

<a name='DiGi.Rhino.Core.Inspect.Value(thisDiGi.Core.Parameter.Classes.Parameter)'></a>

## Inspect\.Value\(this Parameter\) Method

Gets the value of the specified parameter as an [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object\.

```csharp
public static IGH_Goo? Value(this DiGi.Core.Parameter.Classes.Parameter? parameter);
```
#### Parameters

<a name='DiGi.Rhino.Core.Inspect.Value(thisDiGi.Core.Parameter.Classes.Parameter).parameter'></a>

`parameter` [DiGi\.Core\.Parameter\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')

The parameter to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
An [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') representation of the parameter's value, or `null` if the parameter is null\.

<a name='DiGi.Rhino.Core.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Rhino.Core.Query.Clone(thisIGH_Param)'></a>

## Query\.Clone\(this IGH\_Param\) Method

Creates a duplicate of the specified Grasshopper parameter, ensuring it has a new instance GUID
and updating its nickname based on the central settings if applicable\.

```csharp
public static IGH_Param Clone(this IGH_Param param);
```
#### Parameters

<a name='DiGi.Rhino.Core.Query.Clone(thisIGH_Param).param'></a>

`param` [Grasshopper\.Kernel\.IGH\_Param](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_param 'Grasshopper\.Kernel\.IGH\_Param')

The Grasshopper parameter to clone\.

#### Returns
[Grasshopper\.Kernel\.IGH\_Param](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_param 'Grasshopper\.Kernel\.IGH\_Param')  
A new instance of the cloned [Grasshopper\.Kernel\.IGH\_Param](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_param 'Grasshopper\.Kernel\.IGH\_Param')\.

<a name='DiGi.Rhino.Core.Query.Name(thisSystem.Type)'></a>

## Query\.Name\(this Type\) Method

Gets the name of the specified type, removing the 'I' prefix if it is an interface
following standard naming conventions \(where the second character is uppercase\)\.

```csharp
public static string? Name(this System.Type? type);
```
#### Parameters

<a name='DiGi.Rhino.Core.Query.Name(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type') to retrieve the name from\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The processed name of the type, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided type is null\.

<a name='DiGi.Rhino.Core.Query.SaveAs(thisIGH_Structure)'></a>

## Query\.SaveAs\(this IGH\_Structure\) Method

Prompts the user to save a Grasshopper structure containing serializable objects to a JSON file\.

```csharp
public static bool SaveAs(this IGH_Structure gH_Structure);
```
#### Parameters

<a name='DiGi.Rhino.Core.Query.SaveAs(thisIGH_Structure).gH_Structure'></a>

`gH_Structure` [Grasshopper\.Kernel\.Data\.IGH\_Structure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.data.igh_structure 'Grasshopper\.Kernel\.Data\.IGH\_Structure')

The Grasshopper structure to evaluate for serializable objects and save\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the file was successfully saved and exists on disk; otherwise, false\.

<a name='DiGi.Rhino.Core.Query.SerializableObjects_T_(thisIGH_Structure)'></a>

## Query\.SerializableObjects\<T\>\(this IGH\_Structure\) Method

Extracts a list of serializable objects of a specific type from a Grasshopper structure\.

```csharp
public static System.Collections.Generic.List<T>? SerializableObjects<T>(this IGH_Structure? gH_Structure)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Rhino.Core.Query.SerializableObjects_T_(thisIGH_Structure).T'></a>

`T`

The type of serializable object to extract\. Must implement [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.
#### Parameters

<a name='DiGi.Rhino.Core.Query.SerializableObjects_T_(thisIGH_Structure).gH_Structure'></a>

`gH_Structure` [Grasshopper\.Kernel\.Data\.IGH\_Structure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.data.igh_structure 'Grasshopper\.Kernel\.Data\.IGH\_Structure')

The Grasshopper structure to query for serializable objects\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Query.SerializableObjects_T_(thisIGH_Structure).T 'DiGi\.Rhino\.Core\.Query\.SerializableObjects\<T\>\(this IGH\_Structure\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the found objects of type [T](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Query.SerializableObjects_T_(thisIGH_Structure).T 'DiGi\.Rhino\.Core\.Query\.SerializableObjects\<T\>\(this IGH\_Structure\)\.T'), or `null` if the provided structure is null\.

<a name='DiGi.Rhino.Core.Query.Subcategory(thisSystem.Type)'></a>

## Query\.Subcategory\(this Type\) Method

Extracts the subcategory name from the assembly of the provided type\.
If the assembly name is missing, it defaults to "DiGi"\.
If the assembly name contains more than two segments separated by dots, only the first two are returned\.

```csharp
public static string Subcategory(this System.Type type);
```
#### Parameters

<a name='DiGi.Rhino.Core.Query.Subcategory(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type') for which the subcategory is being determined\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the subcategory of the type's assembly\.

<a name='DiGi.Rhino.Core.Query.TryGetValue(thisIGH_Goo,object)'></a>

## Query\.TryGetValue\(this IGH\_Goo, object\) Method

Attempts to retrieve the value from an [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object by accessing its "Value" property via reflection\.

```csharp
public static bool TryGetValue(this IGH_Goo? gH_Goo, out object? value);
```
#### Parameters

<a name='DiGi.Rhino.Core.Query.TryGetValue(thisIGH_Goo,object).gH_Goo'></a>

`gH_Goo` [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')

The Grasshopper Goo object to extract the value from\.

<a name='DiGi.Rhino.Core.Query.TryGetValue(thisIGH_Goo,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the extracted value if successful; otherwise, `null`\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the "Value" property was found and successfully read; otherwise, `false`\.

<a name='DiGi.Rhino.Core.Query.TryGetValue_TObject_(thisobject,TObject)'></a>

## Query\.TryGetValue\<TObject\>\(this object, TObject\) Method

Attempts to retrieve a value of a specific type from an object, handling both standard objects and those wrapped in [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')\.

```csharp
public static bool TryGetValue<TObject>(this object? @object, out TObject? value);
```
#### Type parameters

<a name='DiGi.Rhino.Core.Query.TryGetValue_TObject_(thisobject,TObject).TObject'></a>

`TObject`

The expected type of the resulting value\.
#### Parameters

<a name='DiGi.Rhino.Core.Query.TryGetValue_TObject_(thisobject,TObject).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to evaluate\.

<a name='DiGi.Rhino.Core.Query.TryGetValue_TObject_(thisobject,TObject).value'></a>

`value` [TObject](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Query.TryGetValue_TObject_(thisobject,TObject).TObject 'DiGi\.Rhino\.Core\.Query\.TryGetValue\<TObject\>\(this object, TObject\)\.TObject')

When this method returns, contains the extracted value cast to [TObject](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Query.TryGetValue_TObject_(thisobject,TObject).TObject 'DiGi\.Rhino\.Core\.Query\.TryGetValue\<TObject\>\(this object, TObject\)\.TObject') if successful; otherwise, the default value of [TObject](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Query.TryGetValue_TObject_(thisobject,TObject).TObject 'DiGi\.Rhino\.Core\.Query\.TryGetValue\<TObject\>\(this object, TObject\)\.TObject')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the object \(or its wrapped value\) is of type [TObject](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Query.TryGetValue_TObject_(thisobject,TObject).TObject 'DiGi\.Rhino\.Core\.Query\.TryGetValue\<TObject\>\(this object, TObject\)\.TObject'); otherwise, `false`\.

<a name='DiGi.Rhino.Core.Query.TryGetValue_TSerializableObject_(thisDiGi.Rhino.Core.Interfaces.IGooSerializableObject,TSerializableObject)'></a>

## Query\.TryGetValue\<TSerializableObject\>\(this IGooSerializableObject, TSerializableObject\) Method

Attempts to retrieve the value of a serializable object from an [IGooSerializableObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooSerializableObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject') wrapper, cast to a specific type\.

```csharp
public static bool TryGetValue<TSerializableObject>(this DiGi.Rhino.Core.Interfaces.IGooSerializableObject? gooSerializableObject, out TSerializableObject? serializableObject)
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Rhino.Core.Query.TryGetValue_TSerializableObject_(thisDiGi.Rhino.Core.Interfaces.IGooSerializableObject,TSerializableObject).TSerializableObject'></a>

`TSerializableObject`

The expected type of the serializable object\. Must implement [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.
#### Parameters

<a name='DiGi.Rhino.Core.Query.TryGetValue_TSerializableObject_(thisDiGi.Rhino.Core.Interfaces.IGooSerializableObject,TSerializableObject).gooSerializableObject'></a>

`gooSerializableObject` [IGooSerializableObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooSerializableObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject')

The serializable object wrapper to extract the value from\.

<a name='DiGi.Rhino.Core.Query.TryGetValue_TSerializableObject_(thisDiGi.Rhino.Core.Interfaces.IGooSerializableObject,TSerializableObject).serializableObject'></a>

`serializableObject` [TSerializableObject](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Query.TryGetValue_TSerializableObject_(thisDiGi.Rhino.Core.Interfaces.IGooSerializableObject,TSerializableObject).TSerializableObject 'DiGi\.Rhino\.Core\.Query\.TryGetValue\<TSerializableObject\>\(this DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject, TSerializableObject\)\.TSerializableObject')

When this method returns, contains the extracted serializable object if successful; otherwise, the default value of [TSerializableObject](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Query.TryGetValue_TSerializableObject_(thisDiGi.Rhino.Core.Interfaces.IGooSerializableObject,TSerializableObject).TSerializableObject 'DiGi\.Rhino\.Core\.Query\.TryGetValue\<TSerializableObject\>\(this DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject, TSerializableObject\)\.TSerializableObject')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the value was successfully extracted and is of type [TSerializableObject](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Query.TryGetValue_TSerializableObject_(thisDiGi.Rhino.Core.Interfaces.IGooSerializableObject,TSerializableObject).TSerializableObject 'DiGi\.Rhino\.Core\.Query\.TryGetValue\<TSerializableObject\>\(this DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject, TSerializableObject\)\.TSerializableObject'); otherwise, `false`\.

<a name='DiGi.Rhino.Core.Query.Value(thisDiGi.Rhino.Core.Interfaces.IGooSerializableObject,DiGi.Rhino.Core.Classes.GooParam)'></a>

## Query\.Value\(this IGooSerializableObject, GooParam\) Method

Retrieves a value from an [IGooSerializableObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooSerializableObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject') based on the specified [GooParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooParam 'DiGi\.Rhino\.Core\.Classes\.GooParam')\.

```csharp
public static object? Value(this DiGi.Rhino.Core.Interfaces.IGooSerializableObject? gooSerializableObject, DiGi.Rhino.Core.Classes.GooParam? gooParam);
```
#### Parameters

<a name='DiGi.Rhino.Core.Query.Value(thisDiGi.Rhino.Core.Interfaces.IGooSerializableObject,DiGi.Rhino.Core.Classes.GooParam).gooSerializableObject'></a>

`gooSerializableObject` [IGooSerializableObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooSerializableObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject')

The serializable object to extract the value from\.

<a name='DiGi.Rhino.Core.Query.Value(thisDiGi.Rhino.Core.Interfaces.IGooSerializableObject,DiGi.Rhino.Core.Classes.GooParam).gooParam'></a>

`gooParam` [GooParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooParam 'DiGi\.Rhino\.Core\.Classes\.GooParam')

The parameter definition used to identify the value\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The extracted value if found; otherwise, `null`\.

<a name='DiGi.Rhino.Core.Query.Value(thisobject,DiGi.Rhino.Core.Classes.GooParam)'></a>

## Query\.Value\(this object, GooParam\) Method

Retrieves a value from an object based on the specified [GooParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooParam 'DiGi\.Rhino\.Core\.Classes\.GooParam') by inspecting the object's type\.

```csharp
public static object? Value(this object? @object, DiGi.Rhino.Core.Classes.GooParam? gooParam);
```
#### Parameters

<a name='DiGi.Rhino.Core.Query.Value(thisobject,DiGi.Rhino.Core.Classes.GooParam).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to inspect\.

<a name='DiGi.Rhino.Core.Query.Value(thisobject,DiGi.Rhino.Core.Classes.GooParam).gooParam'></a>

`gooParam` [GooParam](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooParam 'DiGi\.Rhino\.Core\.Classes\.GooParam')

The parameter definition used to identify the value\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The extracted value if found; otherwise, `null`\.

<a name='DiGi.Rhino.Core.Settings'></a>

## Settings Class

```csharp
public static class Settings
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Settings
### Properties

<a name='DiGi.Rhino.Core.Settings.InspectManager'></a>

## Settings\.InspectManager Property

Gets the global instance of the [InspectManager](DiGi.Rhino.Core.md#DiGi.Rhino.Core.Settings.InspectManager 'DiGi\.Rhino\.Core\.Settings\.InspectManager')\.

```csharp
public static DiGi.Rhino.Core.Classes.InspectManager InspectManager { get; }
```

#### Property Value
[InspectManager](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.InspectManager 'DiGi\.Rhino\.Core\.Classes\.InspectManager')
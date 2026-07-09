#### [DiGi\.Rhino\.Geometry](DiGi.Rhino.Geometry.Overview.md 'DiGi\.Rhino\.Geometry\.Overview')

## DiGi\.Rhino\.Geometry\.Core Namespace
### Classes

<a name='DiGi.Rhino.Geometry.Core.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Rhino.Geometry.Core.Query.UnitScale()'></a>

## Query\.UnitScale\(\) Method

Gets the unit scale of the currently active Rhino document\.

```csharp
public static double UnitScale();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The unit scale as a double\.

<a name='DiGi.Rhino.Geometry.Core.Query.UnitScale(RhinoDoc)'></a>

## Query\.UnitScale\(RhinoDoc\) Method

Gets the unit scale for the specified Rhino document relative to meters\.

```csharp
public static double UnitScale(RhinoDoc rhinoDoc);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Query.UnitScale(RhinoDoc).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The Rhino document to query\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The unit scale as a double, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the provided document is null\.
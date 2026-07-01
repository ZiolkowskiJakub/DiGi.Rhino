#### [DiGi\.Rhino\.Geometry](index.md 'index')

## DiGi\.Rhino\.Geometry\.Core\.Interfaces Namespace
### Interfaces

<a name='DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware'></a>

## IGooBakeAware Interface

Defines a contract for objects that can be baked into the Rhino document and are aware of the baking process\.

```csharp
public interface IGooBakeAware
```

Derived  
↳ [GooBakeAwareSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\<TSerializableObject\>')  
↳ [GooGeometry&lt;T&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')  
↳ [IGooBakeAwareSerializableObject](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAwareSerializableObject 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject')  
↳ [IGooGeometry](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooGeometry 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooGeometry')
### Methods

<a name='DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_)'></a>

## IGooBakeAware\.BakeGeometry\(RhinoDoc, ObjectAttributes, List\<Guid\>\) Method

Bakes the geometry associated with this object into the specified Rhino document\.

```csharp
bool BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out System.Collections.Generic.List<System.Guid>? guids);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The target [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc') where the geometry should be baked\.

<a name='DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).objectAttributes'></a>

`objectAttributes` [Rhino\.DocObjects\.ObjectAttributes](https://learn.microsoft.com/en-us/dotnet/api/rhino.docobjects.objectattributes 'Rhino\.DocObjects\.ObjectAttributes')

The [Rhino\.DocObjects\.ObjectAttributes](https://learn.microsoft.com/en-us/dotnet/api/rhino.docobjects.objectattributes 'Rhino\.DocObjects\.ObjectAttributes') to apply to the baked objects\.

<a name='DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).guids'></a>

`guids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of unique identifiers for the objects created in the Rhino document\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the geometry was successfully baked; otherwise, `false`\.

<a name='DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAwareParam'></a>

## IGooBakeAwareParam Interface

Defines an interface for objects that are both previewable and bake\-aware within the Grasshopper environment\.

```csharp
public interface IGooBakeAwareParam
```

Derived  
↳ [GooBakeAwareSerializableParam&lt;X,T&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\<X,T\>')  
↳ [GooGeometryParam&lt;T&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')  
↳ [IGooGeometryParam](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooGeometryParam 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooGeometryParam')

<a name='DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAwareSerializableObject'></a>

## IGooBakeAwareSerializableObject Interface

Defines a serializable object that is aware of the baking process and can provide its associated geometry representations\.

```csharp
public interface IGooBakeAwareSerializableObject : DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware
```

Derived  
↳ [GooBakeAwareSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\<TSerializableObject\>')

Implements [IGooBakeAware](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAware')
### Properties

<a name='DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAwareSerializableObject.Geometries'></a>

## IGooBakeAwareSerializableObject\.Geometries Property

Gets the collection of geometries associated with this serializable object\.

```csharp
DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry') objects, or `null` if no geometries are available\.

<a name='DiGi.Rhino.Geometry.Core.Interfaces.IGooGeometry'></a>

## IGooGeometry Interface

Defines the base contract for geometry objects within the Goo framework,
ensuring they are bake\-aware\.

```csharp
public interface IGooGeometry : DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware
```

Derived  
↳ [GooGeometry&lt;T&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')

Implements [IGooBakeAware](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAware')

<a name='DiGi.Rhino.Geometry.Core.Interfaces.IGooGeometryParam'></a>

## IGooGeometryParam Interface

Defines the contract for a geometry parameter that supports baking operations\.

```csharp
public interface IGooGeometryParam : DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAwareParam
```

Derived  
↳ [GooGeometryParam&lt;T&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')

Implements [IGooBakeAwareParam](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAwareParam 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareParam')
#### [DiGi\.Rhino\.Geometry](index.md 'index')

## DiGi\.Rhino\.Geometry\.Core\.Classes Namespace
### Classes

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_'></a>

## GooBakeAwareSerializableObject\<TSerializableObject\> Class

Represents an abstract base class for objects that are both serializable and aware of the baking process into a Rhino document\.

```csharp
public abstract class GooBakeAwareSerializableObject<TSerializableObject> : DiGi.Rhino.Core.Classes.GooSerializableObject<TSerializableObject>, DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAwareSerializableObject, DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object, which must implement [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[TSerializableObject](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.TSerializableObject 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[TSerializableObject](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.TSerializableObject 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → GooBakeAwareSerializableObject\<TSerializableObject\>

Derived  
↳ [GooIntersectionResult3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooIntersectionResult3D')

Implements [IGooBakeAwareSerializableObject](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAwareSerializableObject 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject'), [IGooBakeAware](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAware')
### Constructors

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.GooBakeAwareSerializableObject()'></a>

## GooBakeAwareSerializableObject\(\) Constructor

Initializes a new instance of the [GooBakeAwareSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\<TSerializableObject\>') class\.

```csharp
public GooBakeAwareSerializableObject();
```

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.GooBakeAwareSerializableObject(TSerializableObject)'></a>

## GooBakeAwareSerializableObject\(TSerializableObject\) Constructor

Initializes a new instance of the [GooBakeAwareSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\<TSerializableObject\>') class with a specified geometry value\.

```csharp
public GooBakeAwareSerializableObject(TSerializableObject? geometry);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.GooBakeAwareSerializableObject(TSerializableObject).geometry'></a>

`geometry` [TSerializableObject](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.TSerializableObject 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\<TSerializableObject\>\.TSerializableObject')

The serializable geometry object to initialize the value with\.
### Properties

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.ClippingBox'></a>

## GooBakeAwareSerializableObject\<TSerializableObject\>\.ClippingBox Property

Gets the bounding box of the geometries associated with this object, used for clipping\.

```csharp
public virtual BoundingBox ClippingBox { get; }
```

#### Property Value
[Rhino\.Geometry\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox 'Rhino\.Geometry\.BoundingBox')

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.Geometries'></a>

## GooBakeAwareSerializableObject\<TSerializableObject\>\.Geometries Property

Gets the array of geometries that represent this object in 3D space\.

```csharp
public abstract DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAwareSerializableObject.Geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_)'></a>

## GooBakeAwareSerializableObject\<TSerializableObject\>\.BakeGeometry\(RhinoDoc, ObjectAttributes, List\<Guid\>\) Method

Bakes the associated geometries into the specified Rhino document using the provided attributes and returns a list of all created object Guids\.

```csharp
public virtual bool BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out System.Collections.Generic.List<System.Guid>? guids);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The target Rhino document\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).objectAttributes'></a>

`objectAttributes` [Rhino\.DocObjects\.ObjectAttributes](https://learn.microsoft.com/en-us/dotnet/api/rhino.docobjects.objectattributes 'Rhino\.DocObjects\.ObjectAttributes')

The attributes to apply to the baked objects\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).guids'></a>

`guids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of Guids for all successfully baked objects\.

Implements [BakeGeometry\(RhinoDoc, ObjectAttributes, List&lt;Guid&gt;\)](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_) 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAware\.BakeGeometry\(RhinoDoc, ObjectAttributes, System\.Collections\.Generic\.List\<System\.Guid\>\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if baking was successful; otherwise, `false`\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Guid)'></a>

## GooBakeAwareSerializableObject\<TSerializableObject\>\.BakeGeometry\(RhinoDoc, ObjectAttributes, Guid\) Method

Bakes the associated geometries into the specified Rhino document using the provided attributes\.

```csharp
public virtual bool BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out System.Guid guid);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Guid).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The target Rhino document\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Guid).objectAttributes'></a>

`objectAttributes` [Rhino\.DocObjects\.ObjectAttributes](https://learn.microsoft.com/en-us/dotnet/api/rhino.docobjects.objectattributes 'Rhino\.DocObjects\.ObjectAttributes')

The attributes to apply to the baked objects\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Guid).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

When this method returns, contains the Guid of the first baked object, or [System\.Guid\.Empty](https://learn.microsoft.com/en-us/dotnet/api/system.guid.empty 'System\.Guid\.Empty') if baking failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if at least one geometry was successfully baked; otherwise, `false`\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.DrawViewportMeshes(GH_PreviewMeshArgs)'></a>

## GooBakeAwareSerializableObject\<TSerializableObject\>\.DrawViewportMeshes\(GH\_PreviewMeshArgs\) Method

Draws the mesh representations of the geometries in the Rhino viewport\.

```csharp
public void DrawViewportMeshes(GH_PreviewMeshArgs? args);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.DrawViewportMeshes(GH_PreviewMeshArgs).args'></a>

`args` [Grasshopper\.Kernel\.GH\_PreviewMeshArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_previewmeshargs 'Grasshopper\.Kernel\.GH\_PreviewMeshArgs')

The arguments containing preview and material information\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.DrawViewportWires(GH_PreviewWireArgs)'></a>

## GooBakeAwareSerializableObject\<TSerializableObject\>\.DrawViewportWires\(GH\_PreviewWireArgs\) Method

Draws the wireframe representations of the geometries in the Rhino viewport\.

```csharp
public void DrawViewportWires(GH_PreviewWireArgs? args);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_.DrawViewportWires(GH_PreviewWireArgs).args'></a>

`args` [Grasshopper\.Kernel\.GH\_PreviewWireArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_previewwireargs 'Grasshopper\.Kernel\.GH\_PreviewWireArgs')

The arguments containing preview and color information\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_'></a>

## GooBakeAwareSerializableParam\<X,T\> Class

Represents a Grasshopper parameter that handles serializable and bake\-aware objects\.

```csharp
public class GooBakeAwareSerializableParam<X,T> : DiGi.Rhino.Core.Classes.GooSerializablePresistentParam<X, T>, DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAwareParam
    where X : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<T>
    where T : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.X'></a>

`X`

The type of the Goo object, which must inherit from [GooBakeAwareSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\<TSerializableObject\>')\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.T'></a>

`T`

The type of the underlying serializable object, which must implement [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[X](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.X 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\<X,T\>\.X')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[T](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.T 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\<X,T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[X](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.X 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\<X,T\>\.X')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[T](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.T 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\<X,T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → GooBakeAwareSerializableParam\<X,T\>

Derived  
↳ [GooIntersectionResult3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooIntersectionResult3DParam')

Implements [IGooBakeAwareParam](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAwareParam 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareParam')
### Constructors

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.GooBakeAwareSerializableParam()'></a>

## GooBakeAwareSerializableParam\(\) Constructor

Initializes a new instance of the [GooBakeAwareSerializableParam&lt;X,T&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\<X,T\>') class\.

```csharp
public GooBakeAwareSerializableParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.ClippingBox'></a>

## GooBakeAwareSerializableParam\<X,T\>\.ClippingBox Property

Gets the clipping box for the parameter's preview based on its volatile data\.

```csharp
public virtual BoundingBox ClippingBox { get; }
```

#### Property Value
[Rhino\.Geometry\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox 'Rhino\.Geometry\.BoundingBox')

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.Hidden'></a>

## GooBakeAwareSerializableParam\<X,T\>\.Hidden Property

Gets or sets a value indicating whether the parameter is hidden from view\.

```csharp
public virtual bool Hidden { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.IsBakeCapable'></a>

## GooBakeAwareSerializableParam\<X,T\>\.IsBakeCapable Property

Gets a value indicating whether the current data in the parameter can be baked into Rhino\.

```csharp
public virtual bool IsBakeCapable { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.IsPreviewCapable'></a>

## GooBakeAwareSerializableParam\<X,T\>\.IsPreviewCapable Property

Gets a value indicating whether the current data in the parameter can be previewed in the viewport\.

```csharp
public virtual bool IsPreviewCapable { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')
### Methods

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_)'></a>

## GooBakeAwareSerializableParam\<X,T\>\.BakeGeometry\(RhinoDoc, ObjectAttributes, List\<Guid\>\) Method

Bakes the objects contained within the parameter into the specified Rhino document using provided attributes\.

```csharp
public virtual void BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, System.Collections.Generic.List<System.Guid>? guids);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The target Rhino document\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).objectAttributes'></a>

`objectAttributes` [Rhino\.DocObjects\.ObjectAttributes](https://learn.microsoft.com/en-us/dotnet/api/rhino.docobjects.objectattributes 'Rhino\.DocObjects\.ObjectAttributes')

The attributes to apply to the baked objects\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).guids'></a>

`guids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to which the Guids of the baked objects will be added\. If null, a new list may be initialized internally but not returned unless passed by reference\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.BakeGeometry(RhinoDoc,System.Collections.Generic.List_System.Guid_)'></a>

## GooBakeAwareSerializableParam\<X,T\>\.BakeGeometry\(RhinoDoc, List\<Guid\>\) Method

Bakes the objects contained within the parameter into the specified Rhino document using default attributes\.

```csharp
public virtual void BakeGeometry(RhinoDoc rhinoDoc, System.Collections.Generic.List<System.Guid> guids);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.BakeGeometry(RhinoDoc,System.Collections.Generic.List_System.Guid_).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The target Rhino document\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.BakeGeometry(RhinoDoc,System.Collections.Generic.List_System.Guid_).guids'></a>

`guids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to which the Guids of the baked objects will be added\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.DrawViewportMeshes(IGH_PreviewArgs)'></a>

## GooBakeAwareSerializableParam\<X,T\>\.DrawViewportMeshes\(IGH\_PreviewArgs\) Method

Handles the rendering of mesh previews for the objects contained within the parameter\.

```csharp
public virtual void DrawViewportMeshes(IGH_PreviewArgs args);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.DrawViewportMeshes(IGH_PreviewArgs).args'></a>

`args` [Grasshopper\.Kernel\.IGH\_PreviewArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewargs 'Grasshopper\.Kernel\.IGH\_PreviewArgs')

The preview arguments provided by Grasshopper\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.DrawViewportWires(IGH_PreviewArgs)'></a>

## GooBakeAwareSerializableParam\<X,T\>\.DrawViewportWires\(IGH\_PreviewArgs\) Method

Handles the rendering of wireframe previews for the objects contained within the parameter\.

```csharp
public virtual void DrawViewportWires(IGH_PreviewArgs args);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_.DrawViewportWires(IGH_PreviewArgs).args'></a>

`args` [Grasshopper\.Kernel\.IGH\_PreviewArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewargs 'Grasshopper\.Kernel\.IGH\_PreviewArgs')

The preview arguments provided by Grasshopper\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_'></a>

## GooGeometry\<T\> Class

A generic Grasshopper Goo wrapper for DiGi geometry types that implement [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')\.
Provides baking, viewport preview, and type\-casting capabilities\.

```csharp
public class GooGeometry<T> : DiGi.Rhino.Core.Classes.GooSerializableObject<T>, DiGi.Rhino.Geometry.Core.Interfaces.IGooGeometry, DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware
    where T : DiGi.Geometry.Core.Interfaces.IGeometry
```
#### Type parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.T'></a>

`T`

The DiGi geometry type being wrapped\. Must implement [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')\.

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[T](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.T 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[T](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.T 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → GooGeometry\<T\>

Derived  
↳ [GooGeometry2D&lt;T&gt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>')  
↳ [GooGeometry3D&lt;T&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')

Implements [IGooGeometry](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooGeometry 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooGeometry'), [IGooBakeAware](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAware')
### Constructors

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.GooGeometry()'></a>

## GooGeometry\(\) Constructor

Initializes a new default instance of [GooGeometry&lt;T&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')\.

```csharp
public GooGeometry();
```

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.GooGeometry(T)'></a>

## GooGeometry\(T\) Constructor

Initializes a new instance of [GooGeometry&lt;T&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') with the specified geometry value\.

```csharp
public GooGeometry(T? geometry);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.GooGeometry(T).geometry'></a>

`geometry` [T](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.T 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>\.T')

The geometry object to wrap, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.
### Properties

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.ClippingBox'></a>

## GooGeometry\<T\>\.ClippingBox Property

Gets the Rhino bounding box used for viewport clipping\.

```csharp
public virtual BoundingBox ClippingBox { get; }
```

#### Property Value
[Rhino\.Geometry\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox 'Rhino\.Geometry\.BoundingBox')
### Methods

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_)'></a>

## GooGeometry\<T\>\.BakeGeometry\(RhinoDoc, ObjectAttributes, List\<Guid\>\) Method

Bakes the wrapped geometry into a Rhino document, returning all generated GUIDs\.

```csharp
public bool BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out System.Collections.Generic.List<System.Guid>? guids);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The Rhino document to bake into, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).objectAttributes'></a>

`objectAttributes` [Rhino\.DocObjects\.ObjectAttributes](https://learn.microsoft.com/en-us/dotnet/api/rhino.docobjects.objectattributes 'Rhino\.DocObjects\.ObjectAttributes')

The object attributes to apply when baking, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).guids'></a>

`guids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains the list of GUIDs of all baked objects, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

Implements [BakeGeometry\(RhinoDoc, ObjectAttributes, List&lt;Guid&gt;\)](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAware.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_) 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAware\.BakeGeometry\(RhinoDoc, ObjectAttributes, System\.Collections\.Generic\.List\<System\.Guid\>\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if baking was successful; otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Guid)'></a>

## GooGeometry\<T\>\.BakeGeometry\(RhinoDoc, ObjectAttributes, Guid\) Method

Bakes the wrapped geometry into a Rhino document, returning the GUID of the first baked object\.

```csharp
public bool BakeGeometry(RhinoDoc rhinoDoc, ObjectAttributes objectAttributes, out System.Guid guid);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Guid).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The Rhino document to bake into\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Guid).objectAttributes'></a>

`objectAttributes` [Rhino\.DocObjects\.ObjectAttributes](https://learn.microsoft.com/en-us/dotnet/api/rhino.docobjects.objectattributes 'Rhino\.DocObjects\.ObjectAttributes')

The object attributes to apply when baking\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Guid).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

When this method returns, contains the GUID of the first baked object, or [System\.Guid\.Empty](https://learn.microsoft.com/en-us/dotnet/api/system.guid.empty 'System\.Guid\.Empty') if baking failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if baking was successful; otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.CastFrom(object)'></a>

## GooGeometry\<T\>\.CastFrom\(object\) Method

Attempts to cast from a source object into this wrapper's value\.

```csharp
public override bool CastFrom(object? source);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.CastFrom(object).source'></a>

`source` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The source object to cast from\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the cast was successful; otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.CastTo_Y_(Y)'></a>

## GooGeometry\<T\>\.CastTo\<Y\>\(Y\) Method

Attempts to cast the wrapped geometry value to the specified target type [Y](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.CastTo_Y_(Y).Y 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>\.CastTo\<Y\>\(Y\)\.Y')\.

```csharp
public override bool CastTo<Y>(ref Y target);
```
#### Type parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.CastTo_Y_(Y).Y'></a>

`Y`

The target type to cast to\.
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.CastTo_Y_(Y).target'></a>

`target` [Y](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.CastTo_Y_(Y).Y 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>\.CastTo\<Y\>\(Y\)\.Y')

When this method returns, contains the cast value if successful\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the cast was successful; otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.DrawViewportMeshes(GH_PreviewMeshArgs)'></a>

## GooGeometry\<T\>\.DrawViewportMeshes\(GH\_PreviewMeshArgs\) Method

Draws the geometry as shaded meshes in the Grasshopper viewport preview\.

```csharp
public void DrawViewportMeshes(GH_PreviewMeshArgs args);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.DrawViewportMeshes(GH_PreviewMeshArgs).args'></a>

`args` [Grasshopper\.Kernel\.GH\_PreviewMeshArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_previewmeshargs 'Grasshopper\.Kernel\.GH\_PreviewMeshArgs')

The preview mesh arguments including material settings\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.DrawViewportWires(GH_PreviewWireArgs)'></a>

## GooGeometry\<T\>\.DrawViewportWires\(GH\_PreviewWireArgs\) Method

Draws the geometry as wireframe curves in the Grasshopper viewport preview\.

```csharp
public void DrawViewportWires(GH_PreviewWireArgs args);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.DrawViewportWires(GH_PreviewWireArgs).args'></a>

`args` [Grasshopper\.Kernel\.GH\_PreviewWireArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_previewwireargs 'Grasshopper\.Kernel\.GH\_PreviewWireArgs')

The preview wire arguments including color settings\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_.Duplicate()'></a>

## GooGeometry\<T\>\.Duplicate\(\) Method

Creates a duplicate of this [GooGeometry&lt;T&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') wrapping the same geometry value\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam'></a>

## GooGeometryParam Class

A non\-generic Grasshopper persistent parameter for [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry') values,
specializing [GooGeometryParam&lt;T&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') with [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')\.

```csharp
public class GooGeometryParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Core.Interfaces.IGeometry>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooGeometryParam
### Constructors

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam.GooGeometryParam()'></a>

## GooGeometryParam\(\) Constructor

Initializes a new default instance of [GooGeometryParam](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam')\.

```csharp
public GooGeometryParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam.ComponentGuid'></a>

## GooGeometryParam\.ComponentGuid Property

Gets the unique identifier for this parameter component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_'></a>

## GooGeometryParam\<T\> Class

A generic Grasshopper persistent parameter for [GooGeometry&lt;T&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') values,
supporting baking and viewport preview\.

```csharp
public class GooGeometryParam<T> : DiGi.Rhino.Core.Classes.GooSerializablePresistentParam<DiGi.Rhino.Geometry.Core.Classes.GooGeometry<T>, T>, DiGi.Rhino.Geometry.Core.Interfaces.IGooGeometryParam, DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAwareParam
    where T : DiGi.Geometry.Core.Interfaces.IGeometry
```
#### Type parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.T'></a>

`T`

The DiGi geometry type\. Must implement [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')\.

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[T](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.T 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>\.T')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[T](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.T 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[T](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.T 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>\.T')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[T](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.T 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → GooGeometryParam\<T\>

Derived  
↳ [GooGeometryParam](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam')  
↳ [GooBoundingBox2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox2DParam')  
↳ [GooBoundingBox3DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox3DParam')  
↳ [GooEllipse2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooEllipse2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooEllipse2DParam')  
↳ [GooGeometry2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2DParam')  
↳ [GooPoint2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2DParam')  
↳ [GooPolygon2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygon2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygon2DParam')  
↳ [GooPolygonal2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonal2DParam')  
↳ [GooPolygonalFace2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonalFace2DParam')  
↳ [GooRectangle2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooRectangle2DParam')  
↳ [GooSegment2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooSegment2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooSegment2DParam')  
↳ [GooVector2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2DParam')  
↳ [GooEllipsoidParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoidParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooEllipsoidParam')  
↳ [GooGeometry3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3DParam')  
↳ [GooMesh3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3DParam')  
↳ [GooPlaneParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPlaneParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPlaneParam')  
↳ [GooPoint3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3DParam')  
↳ [GooPolygonal3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonal3DParam')  
↳ [GooPolygonalFace3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3DParam')  
↳ [GooPolyhedronParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedronParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyhedronParam')  
↳ [GooPolyline3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyline3DParam')  
↳ [GooRay3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooRay3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooRay3DParam')  
↳ [GooSegment3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooSegment3DParam')  
↳ [GooTriangle3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooTriangle3DParam')  
↳ [GooVector3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3DParam')

Implements [IGooGeometryParam](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooGeometryParam 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooGeometryParam'), [IGooBakeAwareParam](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAwareParam 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareParam')
### Constructors

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.GooGeometryParam()'></a>

## GooGeometryParam\(\) Constructor

Initializes a new default instance of [GooGeometryParam&lt;T&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')\.

```csharp
public GooGeometryParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.ClippingBox'></a>

## GooGeometryParam\<T\>\.ClippingBox Property

Gets the Rhino bounding box enclosing all geometry values held in this parameter\.

```csharp
public BoundingBox ClippingBox { get; }
```

#### Property Value
[Rhino\.Geometry\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox 'Rhino\.Geometry\.BoundingBox')

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.ComponentGuid'></a>

## GooGeometryParam\<T\>\.ComponentGuid Property

Gets the unique identifier for this parameter component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.Hidden'></a>

## GooGeometryParam\<T\>\.Hidden Property

Gets or sets a value indicating whether this parameter is hidden in the viewport\.

```csharp
public bool Hidden { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.IsBakeCapable'></a>

## GooGeometryParam\<T\>\.IsBakeCapable Property

Gets a value indicating whether this parameter is capable of baking geometry to Rhino\.

```csharp
public bool IsBakeCapable { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.IsPreviewCapable'></a>

## GooGeometryParam\<T\>\.IsPreviewCapable Property

Gets a value indicating whether this parameter is capable of showing a viewport preview\.

```csharp
public bool IsPreviewCapable { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')
### Methods

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_)'></a>

## GooGeometryParam\<T\>\.BakeGeometry\(RhinoDoc, ObjectAttributes, List\<Guid\>\) Method

Bakes all geometry values in this parameter to a Rhino document with the specified attributes\.

```csharp
public void BakeGeometry(RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, System.Collections.Generic.List<System.Guid>? guids);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The Rhino document to bake into, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).objectAttributes'></a>

`objectAttributes` [Rhino\.DocObjects\.ObjectAttributes](https://learn.microsoft.com/en-us/dotnet/api/rhino.docobjects.objectattributes 'Rhino\.DocObjects\.ObjectAttributes')

The object attributes to apply when baking, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.BakeGeometry(RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).guids'></a>

`guids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to which the GUIDs of all baked objects are added, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.BakeGeometry(RhinoDoc,System.Collections.Generic.List_System.Guid_)'></a>

## GooGeometryParam\<T\>\.BakeGeometry\(RhinoDoc, List\<Guid\>\) Method

Bakes all geometry values in this parameter to a Rhino document using default attributes\.

```csharp
public void BakeGeometry(RhinoDoc rhinoDoc, System.Collections.Generic.List<System.Guid> guids);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.BakeGeometry(RhinoDoc,System.Collections.Generic.List_System.Guid_).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The Rhino document to bake into\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.BakeGeometry(RhinoDoc,System.Collections.Generic.List_System.Guid_).guids'></a>

`guids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to which the GUIDs of all baked objects are added\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.Prompt_Plural(System.Collections.Generic.List_DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T__)'></a>

## GooGeometryParam\<T\>\.Prompt\_Plural\(List\<GooGeometry\<T\>\>\) Method

Prompts the user to select multiple geometry values\.

```csharp
protected override GH_GetterResult Prompt_Plural(ref System.Collections.Generic.List<DiGi.Rhino.Geometry.Core.Classes.GooGeometry<T>?> values);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.Prompt_Plural(System.Collections.Generic.List_DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T__).values'></a>

`values` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[T](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.T 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>\.T')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of selected values\.

#### Returns
[Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult')  
A [Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult') indicating the result of the prompt\.

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.Prompt_Singular(DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_)'></a>

## GooGeometryParam\<T\>\.Prompt\_Singular\(GooGeometry\<T\>\) Method

Prompts the user to select a single geometry value\.

```csharp
protected override GH_GetterResult Prompt_Singular(ref DiGi.Rhino.Geometry.Core.Classes.GooGeometry<T>? value);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.Prompt_Singular(DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_).value'></a>

`value` [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[T](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_.T 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>\.T')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')

The selected value\.

#### Returns
[Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult')  
A [Grasshopper\.Kernel\.GH\_GetterResult](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_getterresult 'Grasshopper\.Kernel\.GH\_GetterResult') indicating the result of the prompt\.

<a name='DiGi.Rhino.Geometry.Core.Classes.RhinoInfo'></a>

## RhinoInfo Class

Provides assembly information for the Rhino geometry library\.

```csharp
public class RhinoInfo
```

Inheritance [Grasshopper\.Kernel\.GH\_AssemblyInfo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_assemblyinfo 'Grasshopper\.Kernel\.GH\_AssemblyInfo') → RhinoInfo
### Properties

<a name='DiGi.Rhino.Geometry.Core.Classes.RhinoInfo.AuthorContact'></a>

## RhinoInfo\.AuthorContact Property

Gets the contact information for the author\.

```csharp
public override string AuthorContact { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Rhino.Geometry.Core.Classes.RhinoInfo.AuthorName'></a>

## RhinoInfo\.AuthorName Property

Gets the name of the author\.

```csharp
public override string AuthorName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Rhino.Geometry.Core.Classes.RhinoInfo.Description'></a>

## RhinoInfo\.Description Property

Gets the description of the assembly\.

```csharp
public override string Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Rhino.Geometry.Core.Classes.RhinoInfo.Icon'></a>

## RhinoInfo\.Icon Property

Gets the icon for the assembly\.

```csharp
public override System.Drawing.Bitmap? Icon { get; }
```

#### Property Value
[System\.Drawing\.Bitmap](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bitmap 'System\.Drawing\.Bitmap')

<a name='DiGi.Rhino.Geometry.Core.Classes.RhinoInfo.Id'></a>

## RhinoInfo\.Id Property

Gets the unique identifier for the assembly\.

```csharp
public override System.Guid Id { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Core.Classes.RhinoInfo.Name'></a>

## RhinoInfo\.Name Property

Gets the name of the assembly\.

```csharp
public override string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Rhino.Geometry.Core.Classes.ToDiGi'></a>

## ToDiGi Class

A Grasshopper component that converts Rhino geometry to DiGi 3D geometry\.

```csharp
public class ToDiGi : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ToDiGi
### Constructors

<a name='DiGi.Rhino.Geometry.Core.Classes.ToDiGi.ToDiGi()'></a>

## ToDiGi\(\) Constructor

Initializes a new instance of object\.

```csharp
public ToDiGi();
```
### Properties

<a name='DiGi.Rhino.Geometry.Core.Classes.ToDiGi.ComponentGuid'></a>

## ToDiGi\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Core.Classes.ToDiGi.Exposure'></a>

## ToDiGi\.Exposure Property

Gets the exposure level of the component in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Core.Classes.ToDiGi.Inputs'></a>

## ToDiGi\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Core.Classes.ToDiGi.Outputs'></a>

## ToDiGi\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Core.Classes.ToDiGi.SolveInstance(IGH_DataAccess)'></a>

## ToDiGi\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Core.Classes.ToDiGi.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.
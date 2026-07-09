#### [DiGi\.Rhino\.Geometry](DiGi.Rhino.Geometry.Overview.md 'DiGi\.Rhino\.Geometry\.Overview')

## DiGi\.Rhino\.Geometry\.Planar\.Classes Namespace
### Classes

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D'></a>

## GooBoundingBox2D Class

Represents a Grasshopper Goo wrapper for a 2D bounding box, allowing it to be passed through Grasshopper wires\.

```csharp
public class GooBoundingBox2D : DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D<DiGi.Geometry.Planar.Classes.BoundingBox2D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D&lt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>')[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')[&gt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>') → GooBoundingBox2D
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D.GooBoundingBox2D()'></a>

## GooBoundingBox2D\(\) Constructor

Initializes a new instance of the [GooBoundingBox2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox2D') class\.

```csharp
public GooBoundingBox2D();
```

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D.GooBoundingBox2D(DiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## GooBoundingBox2D\(BoundingBox2D\) Constructor

Initializes a new instance of the [GooBoundingBox2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox2D') class with the specified 2D bounding box\.

```csharp
public GooBoundingBox2D(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D.GooBoundingBox2D(DiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The 2D bounding box to wrap\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D.GooBoundingBox2D(DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D)'></a>

## GooBoundingBox2D\(GooBoundingBox2D\) Constructor

Initializes a new instance of the [GooBoundingBox2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox2D') class by copying another Goo bounding box wrapper\.

```csharp
public GooBoundingBox2D(DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D? gooBoundingBox2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D.GooBoundingBox2D(DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D).gooBoundingBox2D'></a>

`gooBoundingBox2D` [GooBoundingBox2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox2D')

The source Goo bounding box wrapper to copy from\.
### Methods

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D.Duplicate()'></a>

## GooBoundingBox2D\.Duplicate\(\) Method

Creates a duplicate of the current Goo bounding box\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A duplicated [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2DParam'></a>

## GooBoundingBox2DParam Class

Represents a Grasshopper parameter used to handle 2D bounding box data in component inputs and outputs\.

```csharp
public class GooBoundingBox2DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Planar.Classes.BoundingBox2D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooBoundingBox2DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2DParam.GooBoundingBox2DParam()'></a>

## GooBoundingBox2DParam\(\) Constructor

Initializes a new instance of the [GooBoundingBox2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox2DParam') class\.

```csharp
public GooBoundingBox2DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2DParam.ComponentGuid'></a>

## GooBoundingBox2DParam\.ComponentGuid Property

Gets the unique identifier for the 2D bounding box component parameter\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')  
The GUID associated with this parameter type\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D'></a>

## GooBoundingBox3D Class

Represents a Goo wrapper for a three\-dimensional bounding box\.

```csharp
public class GooBoundingBox3D : DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D<DiGi.Geometry.Spatial.Classes.BoundingBox3D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D&lt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')[&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') → GooBoundingBox3D
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D.GooBoundingBox3D()'></a>

## GooBoundingBox3D\(\) Constructor

Initializes a new instance of the [GooBoundingBox3D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox3D') class\.

```csharp
public GooBoundingBox3D();
```

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D.GooBoundingBox3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D)'></a>

## GooBoundingBox3D\(BoundingBox3D\) Constructor

Initializes a new instance of the [GooBoundingBox3D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox3D') class with the specified bounding box\.

```csharp
public GooBoundingBox3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D boundingBox3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D.GooBoundingBox3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The bounding box to wrap\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D.GooBoundingBox3D(DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D)'></a>

## GooBoundingBox3D\(GooBoundingBox3D\) Constructor

Initializes a new instance of the [GooBoundingBox3D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox3D') class by copying another Goo bounding box\.

```csharp
public GooBoundingBox3D(DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D gooBoundingBox3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D.GooBoundingBox3D(DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D).gooBoundingBox3D'></a>

`gooBoundingBox3D` [GooBoundingBox3D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox3D')

The source Goo bounding box to copy\.
### Methods

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D.Duplicate()'></a>

## GooBoundingBox3D\.Duplicate\(\) Method

Creates a duplicate of the current Goo bounding box\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A duplicate [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3DParam'></a>

## GooBoundingBox3DParam Class

Represents the Grasshopper parameter type for [GooBoundingBox3D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox3D')\.

```csharp
public class GooBoundingBox3DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Spatial.Classes.BoundingBox3D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooBoundingBox3DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3DParam.GooBoundingBox3DParam()'></a>

## GooBoundingBox3DParam\(\) Constructor

Initializes a new instance of the [GooBoundingBox3DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox3DParam') class\.

```csharp
public GooBoundingBox3DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3DParam.ComponentGuid'></a>

## GooBoundingBox3DParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooEllipse2D'></a>

## GooEllipse2D Class

Represents a Grasshopper Goo wrapper for a 2D ellipse\.

```csharp
public class GooEllipse2D : DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D<DiGi.Geometry.Planar.Classes.Ellipse2D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Ellipse2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.ellipse2d 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Ellipse2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.ellipse2d 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Ellipse2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.ellipse2d 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D&lt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Ellipse2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.ellipse2d 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')[&gt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>') → GooEllipse2D
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooEllipse2D.GooEllipse2D()'></a>

## GooEllipse2D\(\) Constructor

Initializes a new instance of the [GooEllipse2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooEllipse2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooEllipse2D') class\.

```csharp
public GooEllipse2D();
```

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooEllipse2D.GooEllipse2D(DiGi.Geometry.Planar.Classes.Ellipse2D)'></a>

## GooEllipse2D\(Ellipse2D\) Constructor

Initializes a new instance of the [GooEllipse2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooEllipse2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooEllipse2D') class with the specified 2D ellipse\.

```csharp
public GooEllipse2D(DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooEllipse2D.GooEllipse2D(DiGi.Geometry.Planar.Classes.Ellipse2D).ellipse2D'></a>

`ellipse2D` [DiGi\.Geometry\.Planar\.Classes\.Ellipse2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.ellipse2d 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The 2D ellipse to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooEllipse2D.Duplicate()'></a>

## GooEllipse2D\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing the same value\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooEllipse2DParam'></a>

## GooEllipse2DParam Class

Represents a Grasshopper parameter type for 2D ellipses\.

```csharp
public class GooEllipse2DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Planar.Classes.Ellipse2D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Ellipse2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.ellipse2d 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.Ellipse2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.ellipse2d 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Ellipse2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.ellipse2d 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.Ellipse2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.ellipse2d 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Ellipse2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.ellipse2d 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooEllipse2DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooEllipse2DParam.GooEllipse2DParam()'></a>

## GooEllipse2DParam\(\) Constructor

Initializes a new instance of the [GooEllipse2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooEllipse2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooEllipse2DParam') class\.

```csharp
public GooEllipse2DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooEllipse2DParam.ComponentGuid'></a>

## GooEllipse2DParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D'></a>

## GooGeometry2D Class

Represents a Goo wrapper for 2D geometry implementing [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')\.

```csharp
public class GooGeometry2D : DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D<DiGi.Geometry.Planar.Interfaces.IGeometry2D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D&lt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>') → GooGeometry2D
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D.GooGeometry2D()'></a>

## GooGeometry2D\(\) Constructor

Initializes a new instance of the [GooGeometry2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D') class\.

```csharp
public GooGeometry2D();
```

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D.GooGeometry2D(DiGi.Geometry.Planar.Interfaces.IGeometry2D)'></a>

## GooGeometry2D\(IGeometry2D\) Constructor

Initializes a new instance of the [GooGeometry2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D') class with the specified geometry\.

```csharp
public GooGeometry2D(DiGi.Geometry.Planar.Interfaces.IGeometry2D? geometry2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D.GooGeometry2D(DiGi.Geometry.Planar.Interfaces.IGeometry2D).geometry2D'></a>

`geometry2D` [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')

The 2D geometry to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D.Duplicate()'></a>

## GooGeometry2D\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooGeometry2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D') containing the same value\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_'></a>

## GooGeometry2D\<T\> Class

Represents a Goo wrapper for 2D geometry of type [T](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_.T 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>\.T')\.

```csharp
public class GooGeometry2D<T> : DiGi.Rhino.Geometry.Core.Classes.GooGeometry<T>
    where T : DiGi.Geometry.Planar.Interfaces.IGeometry2D
```
#### Type parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_.T'></a>

`T`

The type of the 2D geometry, which must implement [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')\.

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[T](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_.T 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[T](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_.T 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[T](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_.T 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>\.T')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → GooGeometry2D\<T\>

Derived  
↳ [GooBoundingBox2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox2D')  
↳ [GooEllipse2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooEllipse2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooEllipse2D')  
↳ [GooGeometry2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D')  
↳ [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')  
↳ [GooPolygon2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygon2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygon2D')  
↳ [GooPolygonal2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonal2D')  
↳ [GooPolygonalFace2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonalFace2D')  
↳ [GooRectangle2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooRectangle2D')  
↳ [GooSegment2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooSegment2D')  
↳ [GooVector2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2D')
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_.GooGeometry2D()'></a>

## GooGeometry2D\(\) Constructor

Initializes a new instance of the [GooGeometry2D&lt;T&gt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>') class\.

```csharp
public GooGeometry2D();
```

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_.GooGeometry2D(T)'></a>

## GooGeometry2D\(T\) Constructor

Initializes a new instance of the [GooGeometry2D&lt;T&gt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>') class with the specified geometry\.

```csharp
public GooGeometry2D(T? geometry2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_.GooGeometry2D(T).geometry2D'></a>

`geometry2D` [T](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_.T 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>\.T')

The 2D geometry to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_.Duplicate()'></a>

## GooGeometry2D\<T\>\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooGeometry2D&lt;T&gt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>') containing the same value\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2DParam'></a>

## GooGeometry2DParam Class

Represents a Grasshopper parameter for 2D geometry\.

```csharp
public class GooGeometry2DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Planar.Interfaces.IGeometry2D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooGeometry2DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2DParam.GooGeometry2DParam()'></a>

## GooGeometry2DParam\(\) Constructor

Initializes a new instance of the [GooGeometry2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2DParam') class\.

```csharp
public GooGeometry2DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2DParam.ComponentGuid'></a>

## GooGeometry2DParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D'></a>

## GooPoint2D Class

Represents a Grasshopper Goo wrapper for a 2D point\.

```csharp
public class GooPoint2D : DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D<DiGi.Geometry.Planar.Classes.Point2D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D&lt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>') → GooPoint2D
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D.GooPoint2D()'></a>

## GooPoint2D\(\) Constructor

Initializes a new instance of the [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') class\.

```csharp
public GooPoint2D();
```

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D.GooPoint2D(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## GooPoint2D\(Point2D\) Constructor

Initializes a new instance of the [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') class with the specified 2D point\.

```csharp
public GooPoint2D(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D.GooPoint2D(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The 2D point to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D.Duplicate()'></a>

## GooPoint2D\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing the same value\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPoint2DParam'></a>

## GooPoint2DParam Class

Represents a Grasshopper parameter for 2D points\.

```csharp
public class GooPoint2DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Planar.Classes.Point2D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooPoint2DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPoint2DParam.GooPoint2DParam()'></a>

## GooPoint2DParam\(\) Constructor

Initializes a new instance of the [GooPoint2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2DParam') class\.

```csharp
public GooPoint2DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPoint2DParam.ComponentGuid'></a>

## GooPoint2DParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygon2D'></a>

## GooPolygon2D Class

Represents a Grasshopper Goo wrapper for a [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')\.

```csharp
public class GooPolygon2D : DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D<DiGi.Geometry.Planar.Classes.Polygon2D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D&lt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>') → GooPolygon2D
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygon2D.GooPolygon2D()'></a>

## GooPolygon2D\(\) Constructor

Initializes a new instance of the [GooPolygon2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygon2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygon2D') class\.

```csharp
public GooPolygon2D();
```

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygon2D.GooPolygon2D(DiGi.Geometry.Planar.Classes.Polygon2D)'></a>

## GooPolygon2D\(Polygon2D\) Constructor

Initializes a new instance of the [GooPolygon2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygon2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygon2D') class with the specified 2D polygon\.

```csharp
public GooPolygon2D(DiGi.Geometry.Planar.Classes.Polygon2D? polygon2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygon2D.GooPolygon2D(DiGi.Geometry.Planar.Classes.Polygon2D).polygon2D'></a>

`polygon2D` [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The 2D polygon to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygon2D.Duplicate()'></a>

## GooPolygon2D\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing the same value\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygon2DParam'></a>

## GooPolygon2DParam Class

Represents a Grasshopper parameter type for 2D polygons\.

```csharp
public class GooPolygon2DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Planar.Classes.Polygon2D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooPolygon2DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygon2DParam.GooPolygon2DParam()'></a>

## GooPolygon2DParam\(\) Constructor

Initializes a new instance of the [GooPolygon2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygon2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygon2DParam') class\.

```csharp
public GooPolygon2DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygon2DParam.ComponentGuid'></a>

## GooPolygon2DParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2D'></a>

## GooPolygonal2D Class

Represents a Grasshopper Goo wrapper for 2D polygonal geometry\.

```csharp
public class GooPolygonal2D : DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D&lt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>') → GooPolygonal2D
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2D.GooPolygonal2D()'></a>

## GooPolygonal2D\(\) Constructor

Initializes a new instance of the [GooPolygonal2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonal2D') class\.

```csharp
public GooPolygonal2D();
```

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2D.GooPolygonal2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## GooPolygonal2D\(IPolygonal2D\) Constructor

Initializes a new instance of the [GooPolygonal2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonal2D') class with the specified polygonal geometry\.

```csharp
public GooPolygonal2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2D.GooPolygonal2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The 2D polygonal geometry to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2D.Duplicate()'></a>

## GooPolygonal2D\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing the same value\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2DParam'></a>

## GooPolygonal2DParam Class

Represents a Grasshopper parameter for 2D polygonal geometry\.

```csharp
public class GooPolygonal2DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooPolygonal2DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2DParam.GooPolygonal2DParam()'></a>

## GooPolygonal2DParam\(\) Constructor

Initializes a new instance of the [GooPolygonal2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonal2DParam') class\.

```csharp
public GooPolygonal2DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2DParam.ComponentGuid'></a>

## GooPolygonal2DParam\.ComponentGuid Property

Gets the unique identifier for the [GooPolygonal2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonal2DParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D'></a>

## GooPolygonalFace2D Class

Represents a Grasshopper wrapper for a [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')\.

```csharp
public class GooPolygonalFace2D : DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D<DiGi.Geometry.Planar.Classes.PolygonalFace2D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D&lt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>') → GooPolygonalFace2D
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D.GooPolygonalFace2D()'></a>

## GooPolygonalFace2D\(\) Constructor

Initializes a new instance of the [GooPolygonalFace2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonalFace2D') class\.

```csharp
public GooPolygonalFace2D();
```

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D.GooPolygonalFace2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D)'></a>

## GooPolygonalFace2D\(PolygonalFace2D\) Constructor

Initializes a new instance of the [GooPolygonalFace2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonalFace2D') class with the specified polygonal face\.

```csharp
public GooPolygonalFace2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D.GooPolygonalFace2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The 2D polygonal face to wrap\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D.GooPolygonalFace2D(DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D)'></a>

## GooPolygonalFace2D\(GooPolygonalFace2D\) Constructor

Initializes a new instance of the [GooPolygonalFace2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonalFace2D') class by copying another wrapper\.

```csharp
public GooPolygonalFace2D(DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D? gooPolygonalFace2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D.GooPolygonalFace2D(DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D).gooPolygonalFace2D'></a>

`gooPolygonalFace2D` [GooPolygonalFace2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonalFace2D')

The source wrapper to copy from\.
### Methods

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D.Duplicate()'></a>

## GooPolygonalFace2D\.Duplicate\(\) Method

Creates a duplicate of the current object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A duplicated [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2DParam'></a>

## GooPolygonalFace2DParam Class

Represents the parameter type for 2D polygonal faces in Grasshopper\.

```csharp
public class GooPolygonalFace2DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Planar.Classes.PolygonalFace2D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooPolygonalFace2DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2DParam.GooPolygonalFace2DParam()'></a>

## GooPolygonalFace2DParam\(\) Constructor

Initializes a new instance of the [GooPolygonalFace2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonalFace2DParam') class\.

```csharp
public GooPolygonalFace2DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2DParam.ComponentGuid'></a>

## GooPolygonalFace2DParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2D'></a>

## GooRectangle2D Class

Represents a Grasshopper Goo wrapper for a [DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')\.

```csharp
public class GooRectangle2D : DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D<DiGi.Geometry.Planar.Classes.Rectangle2D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D&lt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')[&gt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>') → GooRectangle2D
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2D.GooRectangle2D()'></a>

## GooRectangle2D\(\) Constructor

Initializes a new instance of the [GooRectangle2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooRectangle2D') class\.

```csharp
public GooRectangle2D();
```

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2D.GooRectangle2D(DiGi.Geometry.Planar.Classes.Rectangle2D)'></a>

## GooRectangle2D\(Rectangle2D\) Constructor

Initializes a new instance of the [GooRectangle2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooRectangle2D') class with the specified 2D rectangle\.

```csharp
public GooRectangle2D(DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2D.GooRectangle2D(DiGi.Geometry.Planar.Classes.Rectangle2D).rectangle2D'></a>

`rectangle2D` [DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The 2D rectangle to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2D.Duplicate()'></a>

## GooRectangle2D\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooRectangle2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooRectangle2D') containing the same value\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2DParam'></a>

## GooRectangle2DParam Class

Represents a Grasshopper parameter for 2D rectangles\.

```csharp
public class GooRectangle2DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Planar.Classes.Rectangle2D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooRectangle2DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2DParam.GooRectangle2DParam()'></a>

## GooRectangle2DParam\(\) Constructor

Initializes a new instance of the [GooRectangle2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooRectangle2DParam') class\.

```csharp
public GooRectangle2DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2DParam.ComponentGuid'></a>

## GooRectangle2DParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')  
The GUID associated with this parameter type\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D'></a>

## GooSegment2D Class

Represents a Grasshopper Goo wrapper for a 2D line segment\.

```csharp
public class GooSegment2D : DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D<DiGi.Geometry.Planar.Classes.Segment2D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D&lt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>') → GooSegment2D
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D.GooSegment2D()'></a>

## GooSegment2D\(\) Constructor

Initializes a new instance of the [GooSegment2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooSegment2D') class\.

```csharp
public GooSegment2D();
```

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D.GooSegment2D(DiGi.Geometry.Planar.Classes.Segment2D)'></a>

## GooSegment2D\(Segment2D\) Constructor

Initializes a new instance of the [GooSegment2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooSegment2D') class with the specified 2D segment\.

```csharp
public GooSegment2D(DiGi.Geometry.Planar.Classes.Segment2D? segment2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D.GooSegment2D(DiGi.Geometry.Planar.Classes.Segment2D).segment2D'></a>

`segment2D` [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The 2D segment to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D.Duplicate()'></a>

## GooSegment2D\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooSegment2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooSegment2D') containing the same value\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooSegment2DParam'></a>

## GooSegment2DParam Class

Represents the Grasshopper parameter type for 2D line segments\.

```csharp
public class GooSegment2DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Planar.Classes.Segment2D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooSegment2DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooSegment2DParam.GooSegment2DParam()'></a>

## GooSegment2DParam\(\) Constructor

Initializes a new instance of the [GooSegment2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooSegment2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooSegment2DParam') class\.

```csharp
public GooSegment2DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooSegment2DParam.ComponentGuid'></a>

## GooSegment2DParam\.ComponentGuid Property

Gets the unique identifier for the [GooSegment2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooSegment2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooSegment2DParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooVector2D'></a>

## GooVector2D Class

Represents a Grasshopper Goo wrapper for a [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')\.

```csharp
public class GooVector2D : DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D<DiGi.Geometry.Planar.Classes.Vector2D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D&lt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooGeometry2D_T_ 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooGeometry2D\<T\>') → GooVector2D
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooVector2D.GooVector2D()'></a>

## GooVector2D\(\) Constructor

Initializes a new instance of the [GooVector2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2D') class\.

```csharp
public GooVector2D();
```

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooVector2D.GooVector2D(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## GooVector2D\(Vector2D\) Constructor

Initializes a new instance of the [GooVector2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2D') class with the specified 2D vector\.

```csharp
public GooVector2D(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooVector2D.GooVector2D(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The 2D vector to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooVector2D.Duplicate()'></a>

## GooVector2D\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing the same value\.

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooVector2DParam'></a>

## GooVector2DParam Class

Represents a Grasshopper parameter used to pass 2D vector data\.

```csharp
public class GooVector2DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Planar.Classes.Vector2D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooVector2DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooVector2DParam.GooVector2DParam()'></a>

## GooVector2DParam\(\) Constructor

Initializes a new instance of the [GooVector2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2DParam') class\.

```csharp
public GooVector2DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Planar.Classes.GooVector2DParam.ComponentGuid'></a>

## GooVector2DParam\.ComponentGuid Property

Gets the unique identifier for the [GooVector2DParam](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2DParam 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2DParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Planar.Classes.ToGeometry2D'></a>

## ToGeometry2D Class

A Grasshopper component that converts 3D DiGi geometry to its 2D representation on a specified plane\.

```csharp
public class ToGeometry2D : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ToGeometry2D
### Constructors

<a name='DiGi.Rhino.Geometry.Planar.Classes.ToGeometry2D.ToGeometry2D()'></a>

## ToGeometry2D\(\) Constructor

Initializes a new instance of object\.

```csharp
public ToGeometry2D();
```
### Properties

<a name='DiGi.Rhino.Geometry.Planar.Classes.ToGeometry2D.ComponentGuid'></a>

## ToGeometry2D\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Planar.Classes.ToGeometry2D.Exposure'></a>

## ToGeometry2D\.Exposure Property

Gets the exposure of the component, which determines how it is displayed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Planar.Classes.ToGeometry2D.Inputs'></a>

## ToGeometry2D\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Planar.Classes.ToGeometry2D.Outputs'></a>

## ToGeometry2D\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Planar.Classes.ToGeometry2D.SolveInstance(IGH_DataAccess)'></a>

## ToGeometry2D\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Classes.ToGeometry2D.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.
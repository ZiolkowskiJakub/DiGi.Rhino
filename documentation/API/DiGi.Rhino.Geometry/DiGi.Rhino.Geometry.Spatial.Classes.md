#### [DiGi\.Rhino\.Geometry](index.md 'index')

## DiGi\.Rhino\.Geometry\.Spatial\.Classes Namespace
### Classes

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Ellipsoid'></a>

## Ellipsoid Class

A Grasshopper component that creates an ellipsoid geometry based on a plane and three semi\-axes lengths\.

```csharp
public class Ellipsoid : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Ellipsoid
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid()'></a>

## Ellipsoid\(\) Constructor

Initializes a new instance of the [Ellipsoid](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.Ellipsoid') class\.

```csharp
public Ellipsoid();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Ellipsoid.ComponentGuid'></a>

## Ellipsoid\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Ellipsoid.Exposure'></a>

## Ellipsoid\.Exposure Property

Gets the exposure level of the component, which determines when it is executed\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Ellipsoid.Inputs'></a>

## Ellipsoid\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Ellipsoid.Outputs'></a>

## Ellipsoid\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Ellipsoid.SolveInstance(IGH_DataAccess)'></a>

## Ellipsoid\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Ellipsoid.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.EllipsoidByFocalPoints'></a>

## EllipsoidByFocalPoints Class

A Grasshopper component that creates an ellipsoid geometry based on two focal points and semi\-axes lengths\.

```csharp
public class EllipsoidByFocalPoints : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → EllipsoidByFocalPoints
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.EllipsoidByFocalPoints.EllipsoidByFocalPoints()'></a>

## EllipsoidByFocalPoints\(\) Constructor

Initializes a new instance of object\.

```csharp
public EllipsoidByFocalPoints();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.EllipsoidByFocalPoints.ComponentGuid'></a>

## EllipsoidByFocalPoints\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.EllipsoidByFocalPoints.Exposure'></a>

## EllipsoidByFocalPoints\.Exposure Property

Gets the exposure level of the component, determining how it is displayed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.EllipsoidByFocalPoints.Inputs'></a>

## EllipsoidByFocalPoints\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.EllipsoidByFocalPoints.Outputs'></a>

## EllipsoidByFocalPoints\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.EllipsoidByFocalPoints.SolveInstance(IGH_DataAccess)'></a>

## EllipsoidByFocalPoints\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.EllipsoidByFocalPoints.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoid'></a>

## GooEllipsoid Class

Represents a Goo wrapper for an ellipsoid geometry, allowing it to be passed through Grasshopper components\.

```csharp
public class GooEllipsoid : DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D<DiGi.Geometry.Spatial.Classes.Ellipsoid>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D&lt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')[&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') → GooEllipsoid
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoid.GooEllipsoid()'></a>

## GooEllipsoid\(\) Constructor

Initializes a new instance of the [GooEllipsoid](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoid 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooEllipsoid') class\.

```csharp
public GooEllipsoid();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoid.GooEllipsoid(DiGi.Geometry.Spatial.Classes.Ellipsoid)'></a>

## GooEllipsoid\(Ellipsoid\) Constructor

Initializes a new instance of the [GooEllipsoid](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoid 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooEllipsoid') class with the specified ellipsoid value\.

```csharp
public GooEllipsoid(DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoid.GooEllipsoid(DiGi.Geometry.Spatial.Classes.Ellipsoid).ellipsoid'></a>

`ellipsoid` [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The ellipsoid geometry to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoid.Duplicate()'></a>

## GooEllipsoid\.Duplicate\(\) Method

Creates a duplicate of the current [GooEllipsoid](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoid 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooEllipsoid') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object containing a copy of the ellipsoid value\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoidParam'></a>

## GooEllipsoidParam Class

Represents a Grasshopper parameter type for handling [GooEllipsoid](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoid 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooEllipsoid') objects\.

```csharp
public class GooEllipsoidParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Spatial.Classes.Ellipsoid>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooEllipsoidParam
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoidParam.GooEllipsoidParam()'></a>

## GooEllipsoidParam\(\) Constructor

Initializes a new instance of the [GooEllipsoidParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoidParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooEllipsoidParam') class\.

```csharp
public GooEllipsoidParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoidParam.ComponentGuid'></a>

## GooEllipsoidParam\.ComponentGuid Property

Gets the unique identifier for the component associated with this parameter\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D'></a>

## GooGeometry3D Class

Represents a non\-generic Goo wrapper for 3D geometry implementing [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')\.

```csharp
public class GooGeometry3D : DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D<DiGi.Geometry.Spatial.Interfaces.IGeometry3D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D&lt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')[&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') → GooGeometry3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D.GooGeometry3D()'></a>

## GooGeometry3D\(\) Constructor

Initializes a new instance of the [GooGeometry3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D') class\.

```csharp
public GooGeometry3D();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D.GooGeometry3D(DiGi.Geometry.Spatial.Interfaces.IGeometry3D)'></a>

## GooGeometry3D\(IGeometry3D\) Constructor

Initializes a new instance of the [GooGeometry3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D') class with the specified geometry value\.

```csharp
public GooGeometry3D(DiGi.Geometry.Spatial.Interfaces.IGeometry3D? geometry3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D.GooGeometry3D(DiGi.Geometry.Spatial.Interfaces.IGeometry3D).geometry3D'></a>

`geometry3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')

The 3D geometry to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D.Duplicate()'></a>

## GooGeometry3D\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') containing the same geometry value\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_'></a>

## GooGeometry3D\<T\> Class

Represents a Goo wrapper for 3D geometry types\.

```csharp
public class GooGeometry3D<T> : DiGi.Rhino.Geometry.Core.Classes.GooGeometry<T>
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D
```
#### Type parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_.T'></a>

`T`

The type of the 3D geometry, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')\.

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[T](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_.T 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[T](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_.T 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[T](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_.T 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>\.T')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → GooGeometry3D\<T\>

Derived  
↳ [GooBoundingBox3D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox3D')  
↳ [GooEllipsoid](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooEllipsoid 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooEllipsoid')  
↳ [GooGeometry3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D')  
↳ [GooMesh3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D')  
↳ [GooPlane](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPlane 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPlane')  
↳ [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')  
↳ [GooPolygonal3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonal3D')  
↳ [GooPolygonalFace3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D')  
↳ [GooPolyhedron](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedron 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyhedron')  
↳ [GooPolyline3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyline3D')  
↳ [GooRay3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooRay3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooRay3D')  
↳ [GooSegment3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooSegment3D')  
↳ [GooTriangle3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooTriangle3D')  
↳ [GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D')
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_.GooGeometry3D()'></a>

## GooGeometry3D\(\) Constructor

Initializes a new instance of the [GooGeometry3D&lt;T&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') class\.

```csharp
public GooGeometry3D();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_.GooGeometry3D(T)'></a>

## GooGeometry3D\(T\) Constructor

Initializes a new instance of the [GooGeometry3D&lt;T&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') class with the specified geometry value\.

```csharp
public GooGeometry3D(T? geometry3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_.GooGeometry3D(T).geometry3D'></a>

`geometry3D` [T](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_.T 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>\.T')

The 3D geometry to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_.Duplicate()'></a>

## GooGeometry3D\<T\>\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') containing the same geometry value\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3DParam'></a>

## GooGeometry3DParam Class

Represents the Grasshopper parameter type for 3D geometry objects\.

```csharp
public class GooGeometry3DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Spatial.Interfaces.IGeometry3D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooGeometry3DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3DParam.GooGeometry3DParam()'></a>

## GooGeometry3DParam\(\) Constructor

Initializes a new instance of the [GooGeometry3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3DParam') class\.

```csharp
public GooGeometry3DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3DParam.ComponentGuid'></a>

## GooGeometry3DParam\.ComponentGuid Property

Gets the unique identifier for the component associated with this parameter\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D'></a>

## GooIntersectionResult3D Class

Represents a Grasshopper Goo wrapper for the [DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.intersectionresult3d 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') class,
providing serialization and bake\-aware capabilities\.

```csharp
public class GooIntersectionResult3D : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.Geometry.Spatial.Classes.IntersectionResult3D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.intersectionresult3d 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.intersectionresult3d 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\<TSerializableObject\>')[DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.intersectionresult3d 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\<TSerializableObject\>') → GooIntersectionResult3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D.GooIntersectionResult3D()'></a>

## GooIntersectionResult3D\(\) Constructor

Initializes a new instance of the [GooIntersectionResult3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooIntersectionResult3D') class\.

```csharp
public GooIntersectionResult3D();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D.GooIntersectionResult3D(DiGi.Geometry.Spatial.Classes.IntersectionResult3D)'></a>

## GooIntersectionResult3D\(IntersectionResult3D\) Constructor

Initializes a new instance of the [GooIntersectionResult3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooIntersectionResult3D') class with the specified intersection result\.

```csharp
public GooIntersectionResult3D(DiGi.Geometry.Spatial.Classes.IntersectionResult3D? intersectionResult3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D.GooIntersectionResult3D(DiGi.Geometry.Spatial.Classes.IntersectionResult3D).intersectionResult3D'></a>

`intersectionResult3D` [DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.intersectionresult3d 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')

The 3D intersection result to wrap\.
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D.Geometries'></a>

## GooIntersectionResult3D\.Geometries Property

Gets the collection of geometries associated with the 3D intersection result\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](DiGi.Rhino.Geometry.Core.Interfaces.md#DiGi.Rhino.Geometry.Core.Interfaces.IGooBakeAwareSerializableObject.Geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D.CastFrom(object)'></a>

## GooIntersectionResult3D\.CastFrom\(object\) Method

Attempts to cast the specified source object to a [GooIntersectionResult3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooIntersectionResult3D')\.

```csharp
public override bool CastFrom(object? source);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D.CastFrom(object).source'></a>

`source` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to cast from\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the cast was successful; otherwise, false\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D.CastTo_Y_(Y)'></a>

## GooIntersectionResult3D\.CastTo\<Y\>\(Y\) Method

Attempts to cast the wrapped value to a target type [Y](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D.CastTo_Y_(Y).Y 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooIntersectionResult3D\.CastTo\<Y\>\(Y\)\.Y')\.

```csharp
public override bool CastTo<Y>(ref Y target);
```
#### Type parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D.CastTo_Y_(Y).Y'></a>

`Y`

The target type for the cast\.
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D.CastTo_Y_(Y).target'></a>

`target` [Y](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D.CastTo_Y_(Y).Y 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooIntersectionResult3D\.CastTo\<Y\>\(Y\)\.Y')

A reference to the target variable where the result will be stored\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the cast was successful; otherwise, false\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D.Duplicate()'></a>

## GooIntersectionResult3D\.Duplicate\(\) Method

Creates a duplicate of the current [GooIntersectionResult3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooIntersectionResult3D') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object containing a copy of the value\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3DParam'></a>

## GooIntersectionResult3DParam Class

Represents the Grasshopper parameter type for [GooIntersectionResult3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooIntersectionResult3D')\.

```csharp
public class GooIntersectionResult3DParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D, DiGi.Geometry.Spatial.Classes.IntersectionResult3D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooIntersectionResult3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooIntersectionResult3D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.intersectionresult3d 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooIntersectionResult3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooIntersectionResult3D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.intersectionresult3d 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\<X,T\>')[GooIntersectionResult3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooIntersectionResult3D')[,](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\<X,T\>')[DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.intersectionresult3d 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam_X,T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\<X,T\>') → GooIntersectionResult3DParam
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooIntersectionResult3DParam.ComponentGuid'></a>

## GooIntersectionResult3DParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D'></a>

## GooMesh3D Class

Represents a wrapper for a 3D mesh object, allowing it to be passed through the Grasshopper data pipeline\.

```csharp
public class GooMesh3D : DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D<DiGi.Geometry.Spatial.Classes.Mesh3D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D&lt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') → GooMesh3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D.GooMesh3D()'></a>

## GooMesh3D\(\) Constructor

Initializes a new instance of the [GooMesh3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D') class\.

```csharp
public GooMesh3D();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D.GooMesh3D(DiGi.Geometry.Spatial.Classes.Mesh3D)'></a>

## GooMesh3D\(Mesh3D\) Constructor

Initializes a new instance of the [GooMesh3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D') class with the specified mesh\.

```csharp
public GooMesh3D(DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D.GooMesh3D(DiGi.Geometry.Spatial.Classes.Mesh3D).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The 3D mesh to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D.Duplicate()'></a>

## GooMesh3D\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [GooMesh3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D') instance containing the same value\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3DParam'></a>

## GooMesh3DParam Class

Represents the Grasshopper parameter type for 3D mesh objects\.

```csharp
public class GooMesh3DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Spatial.Classes.Mesh3D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooMesh3DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3DParam.GooMesh3DParam()'></a>

## GooMesh3DParam\(\) Constructor

Initializes a new instance of the [GooMesh3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3DParam') class\.

```csharp
public GooMesh3DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3DParam.ComponentGuid'></a>

## GooMesh3DParam\.ComponentGuid Property

Gets the unique identifier for the component associated with this parameter\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')  
The GUID of the component\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPlane'></a>

## GooPlane Class

Represents a Goo wrapper for a [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') geometry object, allowing it to be passed through Grasshopper wires\.

```csharp
public class GooPlane : DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D<DiGi.Geometry.Spatial.Classes.Plane>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D&lt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')[&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') → GooPlane
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPlane.GooPlane()'></a>

## GooPlane\(\) Constructor

Initializes a new instance of the [GooPlane](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPlane 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPlane') class\.

```csharp
public GooPlane();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPlane.GooPlane(DiGi.Geometry.Spatial.Classes.Plane)'></a>

## GooPlane\(Plane\) Constructor

Initializes a new instance of the [GooPlane](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPlane 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPlane') class with the specified plane value\.

```csharp
public GooPlane(DiGi.Geometry.Spatial.Classes.Plane? plane);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPlane.GooPlane(DiGi.Geometry.Spatial.Classes.Plane).plane'></a>

`plane` [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to be wrapped in this Goo object\.
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPlane.Duplicate()'></a>

## GooPlane\.Duplicate\(\) Method

Creates a duplicate of the current [GooPlane](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPlane 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPlane') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object containing a copy of the original plane value\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPlaneParam'></a>

## GooPlaneParam Class

Represents a Grasshopper parameter used to handle [GooPlane](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPlane 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPlane') objects\.

```csharp
public class GooPlaneParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Spatial.Classes.Plane>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooPlaneParam
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPlaneParam.GooPlaneParam()'></a>

## GooPlaneParam\(\) Constructor

Initializes a new instance of the [GooPlaneParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPlaneParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPlaneParam') class\.

```csharp
public GooPlaneParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPlaneParam.ComponentGuid'></a>

## GooPlaneParam\.ComponentGuid Property

Gets the unique identifier for the plane component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D'></a>

## GooPoint3D Class

Represents a wrapper for a 3D point that can be passed through Grasshopper components\.

```csharp
public class GooPoint3D : DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D<DiGi.Geometry.Spatial.Classes.Point3D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D&lt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') → GooPoint3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D.GooPoint3D()'></a>

## GooPoint3D\(\) Constructor

Initializes a new instance of the [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D') class\.

```csharp
public GooPoint3D();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D.GooPoint3D(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## GooPoint3D\(Point3D\) Constructor

Initializes a new instance of the [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D') class with the specified 3D point value\.

```csharp
public GooPoint3D(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D.GooPoint3D(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The 3D point to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D.Duplicate()'></a>

## GooPoint3D\.Duplicate\(\) Method

Creates a duplicate of the current [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object containing a copy of the original value\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3DParam'></a>

## GooPoint3DParam Class

Represents a Grasshopper parameter type for 3D points\.

```csharp
public class GooPoint3DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Spatial.Classes.Point3D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooPoint3DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3DParam.GooPoint3DParam()'></a>

## GooPoint3DParam\(\) Constructor

Initializes a new instance of the [GooPoint3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3DParam') class\.

```csharp
public GooPoint3DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3DParam.ComponentGuid'></a>

## GooPoint3DParam\.ComponentGuid Property

Gets the unique identifier for the component associated with this parameter\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D'></a>

## GooPolygonal3D Class

Represents a Goo wrapper for 3D polygonal geometry, allowing it to be passed through Grasshopper components\.

```csharp
public class GooPolygonal3D : DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D&lt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') → GooPolygonal3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D.GooPolygonal3D()'></a>

## GooPolygonal3D\(\) Constructor

Initializes a new instance of the [GooPolygonal3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonal3D') class\.

```csharp
public GooPolygonal3D();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D.GooPolygonal3D(DiGi.Geometry.Spatial.Interfaces.IPolygonal3D)'></a>

## GooPolygonal3D\(IPolygonal3D\) Constructor

Initializes a new instance of the [GooPolygonal3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonal3D') class with the specified polygonal geometry\.

```csharp
public GooPolygonal3D(DiGi.Geometry.Spatial.Interfaces.IPolygonal3D? polygonal3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D.GooPolygonal3D(DiGi.Geometry.Spatial.Interfaces.IPolygonal3D).polygonal3D'></a>

`polygonal3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')

The 3D polygonal geometry to wrap\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D.GooPolygonal3D(DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D)'></a>

## GooPolygonal3D\(GooPolygonal3D\) Constructor

Initializes a new instance of the [GooPolygonal3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonal3D') class by copying another [GooPolygonal3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonal3D') wrapper\.

```csharp
public GooPolygonal3D(DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D? gooPolygonal3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D.GooPolygonal3D(DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D).gooPolygonal3D'></a>

`gooPolygonal3D` [GooPolygonal3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonal3D')

The source Goo wrapper to copy\.
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D.Duplicate()'></a>

## GooPolygonal3D\.Duplicate\(\) Method

Creates a duplicate of the current [GooPolygonal3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonal3D') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object that is a copy of this instance\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3DParam'></a>

## GooPolygonal3DParam Class

Represents the parameter type for 3D polygonal geometry in Grasshopper\.

```csharp
public class GooPolygonal3DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooPolygonal3DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3DParam.GooPolygonal3DParam()'></a>

## GooPolygonal3DParam\(\) Constructor

Initializes a new instance of the [GooPolygonal3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonal3DParam') class\.

```csharp
public GooPolygonal3DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonal3DParam.ComponentGuid'></a>

## GooPolygonal3DParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D'></a>

## GooPolygonalFace3D Class

Represents a wrapper for a 3D polygonal face, allowing it to be used within the Grasshopper environment\.

```csharp
public class GooPolygonalFace3D : DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D&lt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') → GooPolygonalFace3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D.GooPolygonalFace3D()'></a>

## GooPolygonalFace3D\(\) Constructor

Initializes a new instance of the [GooPolygonalFace3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D') class\.

```csharp
public GooPolygonalFace3D();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D.GooPolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D)'></a>

## GooPolygonalFace3D\(IPolygonalFace3D\) Constructor

Initializes a new instance of the [GooPolygonalFace3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D') class with the specified polygonal face\.

```csharp
public GooPolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D.GooPolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The 3D polygonal face to wrap\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D.GooPolygonalFace3D(DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D)'></a>

## GooPolygonalFace3D\(GooPolygonalFace3D\) Constructor

Initializes a new instance of the [GooPolygonalFace3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D') class by copying another wrapper\.

```csharp
public GooPolygonalFace3D(DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D? gooPolygonalFace3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D.GooPolygonalFace3D(DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D).gooPolygonalFace3D'></a>

`gooPolygonalFace3D` [GooPolygonalFace3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D')

The source wrapper to copy from\.
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D.Duplicate()'></a>

## GooPolygonalFace3D\.Duplicate\(\) Method

Creates a duplicate of the current [GooPolygonalFace3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object that is a copy of this instance\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3DParam'></a>

## GooPolygonalFace3DParam Class

Represents a Grasshopper parameter used to handle [GooPolygonalFace3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D') objects\.

```csharp
public class GooPolygonalFace3DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooPolygonalFace3DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3DParam.GooPolygonalFace3DParam()'></a>

## GooPolygonalFace3DParam\(\) Constructor

Initializes a new instance of the [GooPolygonalFace3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3DParam') class\.

```csharp
public GooPolygonalFace3DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3DParam.ComponentGuid'></a>

## GooPolygonalFace3DParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedron'></a>

## GooPolyhedron Class

Represents a Grasshopper Goo wrapper for a [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') object\.

```csharp
public class GooPolyhedron : DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D<DiGi.Geometry.Spatial.Classes.Polyhedron>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D&lt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')[&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') → GooPolyhedron
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedron.GooPolyhedron()'></a>

## GooPolyhedron\(\) Constructor

Initializes a new instance of the [GooPolyhedron](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedron 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyhedron') class\.

```csharp
public GooPolyhedron();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedron.GooPolyhedron(DiGi.Geometry.Spatial.Classes.Polyhedron)'></a>

## GooPolyhedron\(Polyhedron\) Constructor

Initializes a new instance of the [GooPolyhedron](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedron 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyhedron') class with the specified polyhedron\.

```csharp
public GooPolyhedron(DiGi.Geometry.Spatial.Classes.Polyhedron? polyhedron);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedron.GooPolyhedron(DiGi.Geometry.Spatial.Classes.Polyhedron).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')

The [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedron.Duplicate()'></a>

## GooPolyhedron\.Duplicate\(\) Method

Creates a duplicate of the current [GooPolyhedron](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedron 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyhedron') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object containing a copy of the wrapped value\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedronParam'></a>

## GooPolyhedronParam Class

Represents a Grasshopper parameter type for [GooPolyhedron](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedron 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyhedron') objects\.

```csharp
public class GooPolyhedronParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Spatial.Classes.Polyhedron>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooPolyhedronParam
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedronParam.GooPolyhedronParam()'></a>

## GooPolyhedronParam\(\) Constructor

Initializes a new instance of the [GooPolyhedronParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedronParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyhedronParam') class\.

```csharp
public GooPolyhedronParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyhedronParam.ComponentGuid'></a>

## GooPolyhedronParam\.ComponentGuid Property

Gets the unique identifier for the polyhedron component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D'></a>

## GooPolyline3D Class

Represents a wrapper for a [DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') object to be used within the Grasshopper environment\.

```csharp
public class GooPolyline3D : DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D<DiGi.Geometry.Spatial.Classes.Polyline3D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D&lt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D')[&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') → GooPolyline3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D.GooPolyline3D()'></a>

## GooPolyline3D\(\) Constructor

Initializes a new instance of the [GooPolyline3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyline3D') class\.

```csharp
public GooPolyline3D();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D.GooPolyline3D(DiGi.Geometry.Spatial.Classes.Polyline3D)'></a>

## GooPolyline3D\(Polyline3D\) Constructor

Initializes a new instance of the [GooPolyline3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyline3D') class with the specified polyline\.

```csharp
public GooPolyline3D(DiGi.Geometry.Spatial.Classes.Polyline3D polyline3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D.GooPolyline3D(DiGi.Geometry.Spatial.Classes.Polyline3D).polyline3D'></a>

`polyline3D` [DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') to wrap\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D.GooPolyline3D(DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D)'></a>

## GooPolyline3D\(GooPolyline3D\) Constructor

Initializes a new instance of the [GooPolyline3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyline3D') class by copying another [GooPolyline3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyline3D') instance\.

```csharp
public GooPolyline3D(DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D gooPolyline3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D.GooPolyline3D(DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D).gooPolyline3D'></a>

`gooPolyline3D` [GooPolyline3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyline3D')

The source [GooPolyline3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyline3D') to copy from\.
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D.Duplicate()'></a>

## GooPolyline3D\.Duplicate\(\) Method

Creates a duplicate of the current [GooPolyline3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyline3D') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object that is a copy of this instance\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3DParam'></a>

## GooPolyline3DParam Class

Represents the parameter type for [GooPolyline3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyline3D') used in Grasshopper components\.

```csharp
public class GooPolyline3DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooPolyline3DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3DParam.GooPolyline3DParam()'></a>

## GooPolyline3DParam\(\) Constructor

Initializes a new instance of the [GooPolyline3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolyline3DParam') class\.

```csharp
public GooPolyline3DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooPolyline3DParam.ComponentGuid'></a>

## GooPolyline3DParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooRay3D'></a>

## GooRay3D Class

Represents a Grasshopper Goo wrapper for a [DiGi\.Geometry\.Spatial\.Classes\.Ray3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ray3d 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')\.

```csharp
public class GooRay3D : DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D<DiGi.Geometry.Spatial.Classes.Ray3D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Ray3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ray3d 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Ray3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ray3d 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Ray3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ray3d 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D&lt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Ray3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ray3d 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')[&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') → GooRay3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooRay3D.GooRay3D()'></a>

## GooRay3D\(\) Constructor

Initializes a new instance of the [GooRay3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooRay3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooRay3D') class\.

```csharp
public GooRay3D();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooRay3D.GooRay3D(DiGi.Geometry.Spatial.Classes.Ray3D)'></a>

## GooRay3D\(Ray3D\) Constructor

Initializes a new instance of the [GooRay3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooRay3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooRay3D') class with the specified ray\.

```csharp
public GooRay3D(DiGi.Geometry.Spatial.Classes.Ray3D? ray3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooRay3D.GooRay3D(DiGi.Geometry.Spatial.Classes.Ray3D).ray3D'></a>

`ray3D` [DiGi\.Geometry\.Spatial\.Classes\.Ray3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ray3d 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The 3D ray to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooRay3D.Duplicate()'></a>

## GooRay3D\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A copy of the current [GooRay3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooRay3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooRay3D') instance\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooRay3DParam'></a>

## GooRay3DParam Class

Represents a Grasshopper parameter for 3D rays\.

```csharp
public class GooRay3DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Spatial.Classes.Ray3D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Ray3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ray3d 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Ray3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ray3d 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Ray3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ray3d 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Ray3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ray3d 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Ray3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ray3d 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooRay3DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooRay3DParam.GooRay3DParam()'></a>

## GooRay3DParam\(\) Constructor

Initializes a new instance of the [GooRay3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooRay3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooRay3DParam') class\.

```csharp
public GooRay3DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooRay3DParam.ComponentGuid'></a>

## GooRay3DParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3D'></a>

## GooSegment3D Class

Represents a Goo wrapper for a 3D line segment, allowing it to be passed through Grasshopper components\.

```csharp
public class GooSegment3D : DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D<DiGi.Geometry.Spatial.Classes.Segment3D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D&lt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') → GooSegment3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3D.GooSegment3D()'></a>

## GooSegment3D\(\) Constructor

Initializes a new instance of the [GooSegment3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooSegment3D') class\.

```csharp
public GooSegment3D();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3D.GooSegment3D(DiGi.Geometry.Spatial.Classes.Segment3D)'></a>

## GooSegment3D\(Segment3D\) Constructor

Initializes a new instance of the [GooSegment3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooSegment3D') class with the specified 3D line segment\.

```csharp
public GooSegment3D(DiGi.Geometry.Spatial.Classes.Segment3D? segment3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3D.GooSegment3D(DiGi.Geometry.Spatial.Classes.Segment3D).segment3D'></a>

`segment3D` [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The 3D line segment to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3D.Duplicate()'></a>

## GooSegment3D\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing the same value\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3DParam'></a>

## GooSegment3DParam Class

Represents the Grasshopper parameter type for 3D line segments\.

```csharp
public class GooSegment3DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Spatial.Classes.Segment3D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooSegment3DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3DParam.GooSegment3DParam()'></a>

## GooSegment3DParam\(\) Constructor

Initializes a new instance of the [GooSegment3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooSegment3DParam') class\.

```csharp
public GooSegment3DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3DParam.ComponentGuid'></a>

## GooSegment3DParam\.ComponentGuid Property

Gets the unique identifier for the [GooSegment3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooSegment3DParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3D'></a>

## GooTriangle3D Class

Represents a Grasshopper Goo wrapper for a 3D triangle geometry\.

```csharp
public class GooTriangle3D : DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D<DiGi.Geometry.Spatial.Classes.Triangle3D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D&lt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') → GooTriangle3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3D.GooTriangle3D()'></a>

## GooTriangle3D\(\) Constructor

Initializes a new instance of the [GooTriangle3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooTriangle3D') class\.

```csharp
public GooTriangle3D();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3D.GooTriangle3D(DiGi.Geometry.Spatial.Classes.Triangle3D)'></a>

## GooTriangle3D\(Triangle3D\) Constructor

Initializes a new instance of the [GooTriangle3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooTriangle3D') class with the specified triangle geometry\.

```csharp
public GooTriangle3D(DiGi.Geometry.Spatial.Classes.Triangle3D? triangle3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3D.GooTriangle3D(DiGi.Geometry.Spatial.Classes.Triangle3D).triangle3D'></a>

`triangle3D` [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

The 3D triangle geometry to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3D.Duplicate()'></a>

## GooTriangle3D\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooTriangle3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooTriangle3D') containing the same value\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3DParam'></a>

## GooTriangle3DParam Class

Represents a Grasshopper parameter type for 3D triangle geometry\.

```csharp
public class GooTriangle3DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Spatial.Classes.Triangle3D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooTriangle3DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3DParam.GooTriangle3DParam()'></a>

## GooTriangle3DParam\(\) Constructor

Initializes a new instance of the [GooTriangle3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooTriangle3DParam') class\.

```csharp
public GooTriangle3DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3DParam.ComponentGuid'></a>

## GooTriangle3DParam\.ComponentGuid Property

Gets the unique identifier for the [GooTriangle3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooTriangle3DParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D'></a>

## GooVector3D Class

Represents a wrapper for a 3D vector used within the Grasshopper environment\.

```csharp
public class GooVector3D : DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D<DiGi.Geometry.Spatial.Classes.Vector3D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>') → [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D&lt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooGeometry3D_T_ 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooGeometry3D\<T\>') → GooVector3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D.GooVector3D()'></a>

## GooVector3D\(\) Constructor

Initializes a new instance of the [GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D') class\.

```csharp
public GooVector3D();
```

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D.GooVector3D(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## GooVector3D\(Vector3D\) Constructor

Initializes a new instance of the [GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D') class with the specified vector value\.

```csharp
public GooVector3D(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D.GooVector3D(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The 3D vector to wrap\.
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D.Duplicate()'></a>

## GooVector3D\.Duplicate\(\) Method

Creates a duplicate of the current [GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object containing a copy of the value\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooVector3DParam'></a>

## GooVector3DParam Class

Represents a Grasshopper parameter type for 3D vectors\.

```csharp
public class GooVector3DParam : DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam<DiGi.Geometry.Spatial.Classes.Vector3D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometry_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometry\<T\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam&lt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>')[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](DiGi.Rhino.Geometry.Core.Classes.md#DiGi.Rhino.Geometry.Core.Classes.GooGeometryParam_T_ 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooGeometryParam\<T\>') → GooVector3DParam
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooVector3DParam.GooVector3DParam()'></a>

## GooVector3DParam\(\) Constructor

Initializes a new instance of the [GooVector3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3DParam') class\.

```csharp
public GooVector3DParam();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.GooVector3DParam.ComponentGuid'></a>

## GooVector3DParam\.ComponentGuid Property

Gets the unique identifier for the [GooVector3DParam](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3DParam 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3DParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')  
The GUID of the component\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByEllipsoid'></a>

## Mesh3DByEllipsoid Class

A Grasshopper component that generates a 3D mesh from an ellipsoid geometry based on the specified number of stacks and slices\.

```csharp
public class Mesh3DByEllipsoid : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Mesh3DByEllipsoid
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByEllipsoid.Mesh3DByEllipsoid()'></a>

## Mesh3DByEllipsoid\(\) Constructor

Initializes a new instance of the [Mesh3DByEllipsoid](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByEllipsoid 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.Mesh3DByEllipsoid') class\.

```csharp
public Mesh3DByEllipsoid();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByEllipsoid.ComponentGuid'></a>

## Mesh3DByEllipsoid\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByEllipsoid.Exposure'></a>

## Mesh3DByEllipsoid\.Exposure Property

Gets or sets the exposure of the component, determining whether it is a primary or secondary component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByEllipsoid.Inputs'></a>

## Mesh3DByEllipsoid\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByEllipsoid.Outputs'></a>

## Mesh3DByEllipsoid\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByEllipsoid.SolveInstance(IGH_DataAccess)'></a>

## Mesh3DByEllipsoid\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByEllipsoid.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByGeometry3D'></a>

## Mesh3DByGeometry3D Class

A Grasshopper component that creates a [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') from various 3D geometry types\.

```csharp
public class Mesh3DByGeometry3D : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Mesh3DByGeometry3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByGeometry3D.Mesh3DByGeometry3D()'></a>

## Mesh3DByGeometry3D\(\) Constructor

Initializes a new instance of object\.

```csharp
public Mesh3DByGeometry3D();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByGeometry3D.ComponentGuid'></a>

## Mesh3DByGeometry3D\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByGeometry3D.Exposure'></a>

## Mesh3DByGeometry3D\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByGeometry3D.Inputs'></a>

## Mesh3DByGeometry3D\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByGeometry3D.Outputs'></a>

## Mesh3DByGeometry3D\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByGeometry3D.SolveInstance(IGH_DataAccess)'></a>

## Mesh3DByGeometry3D\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Mesh3DByGeometry3D.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3D'></a>

## Point3D Class

Represents a Grasshopper component that creates a 3D point based on X, Y, and Z input coordinates\.

```csharp
public class Point3D : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Point3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3D.Point3D()'></a>

## Point3D\(\) Constructor

Initializes a new instance of object\.

```csharp
public Point3D();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3D.ComponentGuid'></a>

## Point3D\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3D.Exposure'></a>

## Point3D\.Exposure Property

Gets the exposure of the component, determining if it is primary or secondary\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3D.Inputs'></a>

## Point3D\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3D.Outputs'></a>

## Point3D\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3D.SolveInstance(IGH_DataAccess)'></a>

## Point3D\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3D.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3DByEllipsoid'></a>

## Point3DByEllipsoid Class

A Grasshopper component that calculates a 3D point on the surface of an ellipsoid using phi and theta angles\.

```csharp
public class Point3DByEllipsoid : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Point3DByEllipsoid
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3DByEllipsoid.Point3DByEllipsoid()'></a>

## Point3DByEllipsoid\(\) Constructor

Initializes a new instance of object\.

```csharp
public Point3DByEllipsoid();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3DByEllipsoid.ComponentGuid'></a>

## Point3DByEllipsoid\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3DByEllipsoid.Exposure'></a>

## Point3DByEllipsoid\.Exposure Property

Gets the exposure level of the component, determining its visual priority on the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3DByEllipsoid.Inputs'></a>

## Point3DByEllipsoid\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3DByEllipsoid.Outputs'></a>

## Point3DByEllipsoid\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3DByEllipsoid.SolveInstance(IGH_DataAccess)'></a>

## Point3DByEllipsoid\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.Point3DByEllipsoid.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.PolygonalFace3DByPolygonal3D'></a>

## PolygonalFace3DByPolygonal3D Class

A Grasshopper component that creates a 3D polygonal face from an external boundary and optional internal boundaries\.

```csharp
public class PolygonalFace3DByPolygonal3D : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → PolygonalFace3DByPolygonal3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.PolygonalFace3DByPolygonal3D.PolygonalFace3DByPolygonal3D()'></a>

## PolygonalFace3DByPolygonal3D\(\) Constructor

Initializes a new instance of object\.

```csharp
public PolygonalFace3DByPolygonal3D();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.PolygonalFace3DByPolygonal3D.ComponentGuid'></a>

## PolygonalFace3DByPolygonal3D\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.PolygonalFace3DByPolygonal3D.Exposure'></a>

## PolygonalFace3DByPolygonal3D\.Exposure Property

Gets the exposure of the component, determining how it is displayed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.PolygonalFace3DByPolygonal3D.Inputs'></a>

## PolygonalFace3DByPolygonal3D\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.PolygonalFace3DByPolygonal3D.Outputs'></a>

## PolygonalFace3DByPolygonal3D\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.PolygonalFace3DByPolygonal3D.SolveInstance(IGH_DataAccess)'></a>

## PolygonalFace3DByPolygonal3D\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.PolygonalFace3DByPolygonal3D.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGeometry3D'></a>

## ToGeometry3D Class

A Grasshopper component that converts 2D geometry to 3D geometry based on a specified plane\.

```csharp
public class ToGeometry3D : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ToGeometry3D
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGeometry3D.ToGeometry3D()'></a>

## ToGeometry3D\(\) Constructor

Initializes a new instance of object\.

```csharp
public ToGeometry3D();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGeometry3D.ComponentGuid'></a>

## ToGeometry3D\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGeometry3D.Exposure'></a>

## ToGeometry3D\.Exposure Property

Gets the exposure of the component, which determines its visibility and priority in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGeometry3D.Inputs'></a>

## ToGeometry3D\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGeometry3D.Outputs'></a>

## ToGeometry3D\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGeometry3D.SolveInstance(IGH_DataAccess)'></a>

## ToGeometry3D\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGeometry3D.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGrasshopper'></a>

## ToGrasshopper Class

A Grasshopper component that converts DiGi geometry objects to their corresponding Grasshopper geometry representations\.

```csharp
public class ToGrasshopper : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ToGrasshopper
### Constructors

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGrasshopper.ToGrasshopper()'></a>

## ToGrasshopper\(\) Constructor

Initializes a new instance of object\.

```csharp
public ToGrasshopper();
```
### Properties

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGrasshopper.ComponentGuid'></a>

## ToGrasshopper\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGrasshopper.Exposure'></a>

## ToGrasshopper\.Exposure Property

Gets the exposure level of the component, determining how it is displayed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGrasshopper.Inputs'></a>

## ToGrasshopper\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGrasshopper.Outputs'></a>

## ToGrasshopper\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGrasshopper.SolveInstance(IGH_DataAccess)'></a>

## ToGrasshopper\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Classes.ToGrasshopper.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.
#### [DiGi\.Rhino\.Geometry](index.md 'index')

## DiGi\.Rhino\.Geometry\.Spatial Namespace
### Classes

<a name='DiGi.Rhino.Geometry.Spatial.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisCurve,double)'></a>

## Convert\.ToDiGi\(this Curve, double\) Method

Converts a Rhino [Rhino\.Geometry\.Curve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.curve 'Rhino\.Geometry\.Curve') to a DiGi [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D')\.

```csharp
public static DiGi.Geometry.Spatial.Interfaces.ICurve3D? ToDiGi(this Curve? curve, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisCurve,double).curve'></a>

`curve` [Rhino\.Geometry\.Curve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.curve 'Rhino\.Geometry\.Curve')

The Rhino curve to convert\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisCurve,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric evaluations\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D')  
A DiGi [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D') instance if the conversion is successful; otherwise, `null`\.

#### Exceptions

[System\.NotImplementedException](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception 'System\.NotImplementedException')  
Thrown when the specific curve type is not yet supported for conversion\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisEllipse)'></a>

## Convert\.ToDiGi\(this Ellipse\) Method

Converts a Rhino geometry ellipse to a DiGi spatial ellipse \([DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipse3d 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D')\)\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Ellipse3D? ToDiGi(this Ellipse ellipse);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisEllipse).ellipse'></a>

`ellipse` [Rhino\.Geometry\.Ellipse](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.ellipse 'Rhino\.Geometry\.Ellipse')

The Rhino ellipse instance to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipse3d 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipse3d 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D') object if the input ellipse is valid; otherwise, `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisIGH_GeometricGoo,double)'></a>

## Convert\.ToDiGi\(this IGH\_GeometricGoo, double\) Method

Converts a Grasshopper [Grasshopper\.Kernel\.Types\.IGH\_GeometricGoo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_geometricgoo 'Grasshopper\.Kernel\.Types\.IGH\_GeometricGoo') object to a DiGi [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') representation\.

```csharp
public static DiGi.Geometry.Spatial.Interfaces.IGeometry3D? ToDiGi(this IGH_GeometricGoo? geometricGoo, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisIGH_GeometricGoo,double).geometricGoo'></a>

`geometricGoo` [Grasshopper\.Kernel\.Types\.IGH\_GeometricGoo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_geometricgoo 'Grasshopper\.Kernel\.Types\.IGH\_GeometricGoo')

The Grasshopper geometric goo object to convert\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisIGH_GeometricGoo,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for geometric operations and conversions\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')  
An [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') instance if the conversion is successful; otherwise, `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisLine)'></a>

## Convert\.ToDiGi\(this Line\) Method

Converts a [Rhino\.Geometry\.Line](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.line 'Rhino\.Geometry\.Line') to a [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Segment3D? ToDiGi(this Line line);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisLine).line'></a>

`line` [Rhino\.Geometry\.Line](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.line 'Rhino\.Geometry\.Line')

The Rhino line to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') representation of the line, or `null` if the line is invalid\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisLineCurve)'></a>

## Convert\.ToDiGi\(this LineCurve\) Method

Converts a [Rhino\.Geometry\.LineCurve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.linecurve 'Rhino\.Geometry\.LineCurve') to a [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Segment3D? ToDiGi(this LineCurve lineCurve);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisLineCurve).lineCurve'></a>

`lineCurve` [Rhino\.Geometry\.LineCurve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.linecurve 'Rhino\.Geometry\.LineCurve')

The Rhino line curve to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') representation of the line curve, or `null` if the input is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisMesh)'></a>

## Convert\.ToDiGi\(this Mesh\) Method

Converts a Rhino [Rhino\.Geometry\.Mesh](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.mesh 'Rhino\.Geometry\.Mesh') to a DiGi [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Mesh3D? ToDiGi(this Mesh? mesh);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisMesh).mesh'></a>

`mesh` [Rhino\.Geometry\.Mesh](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.mesh 'Rhino\.Geometry\.Mesh')

The Rhino mesh to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') instance if the conversion is successful; otherwise, `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisPlane)'></a>

## Convert\.ToDiGi\(this Plane\) Method

Converts a Rhino Plane to a DiGi Plane\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane? ToDiGi(this Plane plane);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisPlane).plane'></a>

`plane` [Rhino\.Geometry\.Plane](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.plane 'Rhino\.Geometry\.Plane')

The Rhino plane to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A new [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') instance if the provided plane is valid; otherwise, `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisPoint3d)'></a>

## Convert\.ToDiGi\(this Point3d\) Method

Converts a Rhino Point3d to a DiGi Point3D\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ToDiGi(this Point3d point3d);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisPoint3d).point3d'></a>

`point3d` [Rhino\.Geometry\.Point3d](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.point3d 'Rhino\.Geometry\.Point3d')

The Rhino Point3d instance to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') if the input point is valid; otherwise, `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisPoint3f)'></a>

## Convert\.ToDiGi\(this Point3f\) Method

Converts a Rhino Point3f to a DiGi Point3D\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ToDiGi(this Point3f point3f);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisPoint3f).point3f'></a>

`point3f` [Rhino\.Geometry\.Point3f](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.point3f 'Rhino\.Geometry\.Point3f')

The Rhino Point3f instance to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') if the input point is valid; otherwise, `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisPolyCurve,double)'></a>

## Convert\.ToDiGi\(this PolyCurve, double\) Method

Converts a Rhino [Rhino\.Geometry\.PolyCurve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.polycurve 'Rhino\.Geometry\.PolyCurve') to a DiGi [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D')\.

```csharp
public static DiGi.Geometry.Spatial.Interfaces.ICurve3D? ToDiGi(this PolyCurve? polyCurve, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisPolyCurve,double).polyCurve'></a>

`polyCurve` [Rhino\.Geometry\.PolyCurve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.polycurve 'Rhino\.Geometry\.PolyCurve')

The Rhino polycurve to convert\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisPolyCurve,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric evaluations\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D')  
A DiGi [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D') instance \(such as [DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') or [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')\) if the conversion is successful; otherwise, `null`\.

#### Exceptions

[System\.NotImplementedException](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception 'System\.NotImplementedException')  
Thrown when the polycurve contains non\-linear segments that are not supported\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisPolyline)'></a>

## Convert\.ToDiGi\(this Polyline\) Method

Converts a Rhino Geometry Polyline to a DiGi Polyline3D\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyline3D? ToDiGi(this Polyline? polyline);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisPolyline).polyline'></a>

`polyline` [Rhino\.Geometry\.Polyline](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.polyline 'Rhino\.Geometry\.Polyline')

The Rhino polyline instance to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D')  
A new [DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') instance if the input is valid and not null; otherwise, `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisRectangle3d)'></a>

## Convert\.ToDiGi\(this Rectangle3d\) Method

Converts a Rhino [Rhino\.Geometry\.Rectangle3d](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.rectangle3d 'Rhino\.Geometry\.Rectangle3d') to a DiGi [DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.rectangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Rectangle3D? ToDiGi(this Rectangle3d rectangle3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisRectangle3d).rectangle3D'></a>

`rectangle3D` [Rhino\.Geometry\.Rectangle3d](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.rectangle3d 'Rhino\.Geometry\.Rectangle3d')

The Rhino rectangle to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.rectangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.rectangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') instance if the input rectangle is valid; otherwise, `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisVector3d)'></a>

## Convert\.ToDiGi\(this Vector3d\) Method

Converts a Rhino [Rhino\.Geometry\.Vector3d](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.vector3d 'Rhino\.Geometry\.Vector3d') to a DiGi [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? ToDiGi(this Vector3d vector3d);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(thisVector3d).vector3d'></a>

`vector3d` [Rhino\.Geometry\.Vector3d](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.vector3d 'Rhino\.Geometry\.Vector3d')

The Rhino vector to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') instance if the input vector is valid; otherwise, `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi_PolygonalFace3D(thisBrepFace,double)'></a>

## Convert\.ToDiGi\_PolygonalFace3D\(this BrepFace, double\) Method

Converts a Rhino [Rhino\.Geometry\.BrepFace](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.brepface 'Rhino\.Geometry\.BrepFace') to a [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PolygonalFace3D? ToDiGi_PolygonalFace3D(this BrepFace? brepFace, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi_PolygonalFace3D(thisBrepFace,double).brepFace'></a>

`brepFace` [Rhino\.Geometry\.BrepFace](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.brepface 'Rhino\.Geometry\.BrepFace')

The Rhino BrepFace to convert\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi_PolygonalFace3D(thisBrepFace,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for geometric operations and planarity checks\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') if the face is valid, planar, and consists of polygonal loops; otherwise, `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi_Polyhedron(thisBrep,double)'></a>

## Convert\.ToDiGi\_Polyhedron\(this Brep, double\) Method

Converts a Rhino [Rhino\.Geometry\.Brep](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.brep 'Rhino\.Geometry\.Brep') to a [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyhedron? ToDiGi_Polyhedron(this Brep? brep, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi_Polyhedron(thisBrep,double).brep'></a>

`brep` [Rhino\.Geometry\.Brep](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.brep 'Rhino\.Geometry\.Brep')

The [Rhino\.Geometry\.Brep](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.brep 'Rhino\.Geometry\.Brep') instance to convert\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi_Polyhedron(thisBrep,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for planarity checks and conversion\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')  
A [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') if the Brep is valid, solid, and consists of planar faces; otherwise, `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Ellipsoid)'></a>

## Convert\.ToGrasshopper\(this Ellipsoid\) Method

Converts an ellipsoid to a Grasshopper Brep\.

```csharp
public static GH_Brep? ToGrasshopper(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Ellipsoid).ellipsoid'></a>

`ellipsoid` [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The ellipsoid to convert\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Brep](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_brep 'Grasshopper\.Kernel\.Types\.GH\_Brep')  
A [Grasshopper\.Kernel\.Types\.GH\_Brep](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_brep 'Grasshopper\.Kernel\.Types\.GH\_Brep') representation of the ellipsoid, or `null` if the input is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Mesh3D)'></a>

## Convert\.ToGrasshopper\(this Mesh3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') instance to a Grasshopper [Grasshopper\.Kernel\.Types\.GH\_Mesh](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_mesh 'Grasshopper\.Kernel\.Types\.GH\_Mesh')\.

```csharp
public static GH_Mesh? ToGrasshopper(this DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Mesh3D).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') object to convert\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Mesh](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_mesh 'Grasshopper\.Kernel\.Types\.GH\_Mesh')  
A [Grasshopper\.Kernel\.Types\.GH\_Mesh](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_mesh 'Grasshopper\.Kernel\.Types\.GH\_Mesh') representation of the mesh, or `null` if the provided [mesh3D](DiGi.Rhino.Geometry.Spatial.md#DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Mesh3D).mesh3D 'DiGi\.Rhino\.Geometry\.Spatial\.Convert\.ToGrasshopper\(this DiGi\.Geometry\.Spatial\.Classes\.Mesh3D\)\.mesh3D') is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Convert\.ToGrasshopper\(this Point3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to a Grasshopper [Grasshopper\.Kernel\.Types\.GH\_Point](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_point 'Grasshopper\.Kernel\.Types\.GH\_Point')\.

```csharp
public static GH_Point? ToGrasshopper(this DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The 3D point to convert\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Point](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_point 'Grasshopper\.Kernel\.Types\.GH\_Point')  
A [Grasshopper\.Kernel\.Types\.GH\_Point](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_point 'Grasshopper\.Kernel\.Types\.GH\_Point') if the provided point is not null; otherwise, `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.PolygonalFace3D,double)'></a>

## Convert\.ToGrasshopper\(this PolygonalFace3D, double\) Method

Converts a planar polygonal face to a Grasshopper Brep\.

```csharp
public static GH_Brep? ToGrasshopper(this DiGi.Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.PolygonalFace3D,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')

The polygonal face to convert\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.PolygonalFace3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for the conversion\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Brep](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_brep 'Grasshopper\.Kernel\.Types\.GH\_Brep')  
A [Grasshopper\.Kernel\.Types\.GH\_Brep](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_brep 'Grasshopper\.Kernel\.Types\.GH\_Brep') representation of the polygonal face, or `null` if the input is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Polyhedron,double)'></a>

## Convert\.ToGrasshopper\(this Polyhedron, double\) Method

Converts a polyhedron to a Grasshopper Brep\.

```csharp
public static GH_Brep? ToGrasshopper(this DiGi.Geometry.Spatial.Classes.Polyhedron? polyhedron, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Polyhedron,double).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')

The polyhedron to convert\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Polyhedron,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for the conversion\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Brep](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_brep 'Grasshopper\.Kernel\.Types\.GH\_Brep')  
A [Grasshopper\.Kernel\.Types\.GH\_Brep](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_brep 'Grasshopper\.Kernel\.Types\.GH\_Brep') representation of the polyhedron, or `null` if the input is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Polyline3D)'></a>

## Convert\.ToGrasshopper\(this Polyline3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') to a Grasshopper [Grasshopper\.Kernel\.Types\.GH\_Curve](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_curve 'Grasshopper\.Kernel\.Types\.GH\_Curve')\.

```csharp
public static GH_Curve? ToGrasshopper(this DiGi.Geometry.Spatial.Classes.Polyline3D? polyline3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Polyline3D).polyline3D'></a>

`polyline3D` [DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D')

The 3D polyline to convert\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Curve](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_curve 'Grasshopper\.Kernel\.Types\.GH\_Curve')  
A [Grasshopper\.Kernel\.Types\.GH\_Curve](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_curve 'Grasshopper\.Kernel\.Types\.GH\_Curve') representing the polyline, or `null` if the input is `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Rectangle3D)'></a>

## Convert\.ToGrasshopper\(this Rectangle3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.rectangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') instance to a Grasshopper [Grasshopper\.Kernel\.Types\.GH\_Rectangle](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_rectangle 'Grasshopper\.Kernel\.Types\.GH\_Rectangle')\.

```csharp
public static GH_Rectangle? ToGrasshopper(this DiGi.Geometry.Spatial.Classes.Rectangle3D? rectangle3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Rectangle3D).rectangle3D'></a>

`rectangle3D` [DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.rectangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D')

The three\-dimensional rectangle to convert\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Rectangle](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_rectangle 'Grasshopper\.Kernel\.Types\.GH\_Rectangle')  
A [Grasshopper\.Kernel\.Types\.GH\_Rectangle](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_rectangle 'Grasshopper\.Kernel\.Types\.GH\_Rectangle') representation of the input, or `null` if the provided [rectangle3D](DiGi.Rhino.Geometry.Spatial.md#DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Rectangle3D).rectangle3D 'DiGi\.Rhino\.Geometry\.Spatial\.Convert\.ToGrasshopper\(this DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D\)\.rectangle3D') is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Segment3D)'></a>

## Convert\.ToGrasshopper\(this Segment3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') to a Grasshopper [Grasshopper\.Kernel\.Types\.GH\_Curve](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_curve 'Grasshopper\.Kernel\.Types\.GH\_Curve')\.

```csharp
public static GH_Curve? ToGrasshopper(this DiGi.Geometry.Spatial.Classes.Segment3D? segment3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Segment3D).segment3D'></a>

`segment3D` [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The 3D line segment to convert\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Curve](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_curve 'Grasshopper\.Kernel\.Types\.GH\_Curve')  
A [Grasshopper\.Kernel\.Types\.GH\_Curve](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_curve 'Grasshopper\.Kernel\.Types\.GH\_Curve') representing the segment, or `null` if the input is `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Convert\.ToGrasshopper\(this Vector3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to a Grasshopper [Grasshopper\.Kernel\.Types\.GH\_Vector](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_vector 'Grasshopper\.Kernel\.Types\.GH\_Vector')\.

```csharp
public static GH_Vector? ToGrasshopper(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The 3D vector to convert\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Vector](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_vector 'Grasshopper\.Kernel\.Types\.GH\_Vector')  
A [Grasshopper\.Kernel\.Types\.GH\_Vector](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_vector 'Grasshopper\.Kernel\.Types\.GH\_Vector') instance if the input is not null; otherwise, `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,double)'></a>

## Convert\.ToGrasshopper\(this IGeometry3D, double\) Method

Converts a 3D geometry object to its corresponding Grasshopper Goo representation\.

```csharp
public static IGH_Goo? ToGrasshopper(this DiGi.Geometry.Spatial.Interfaces.IGeometry3D? geometry3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,double).geometry3D'></a>

`geometry3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')

The 3D geometry object to convert\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for geometric operations during conversion\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
An [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object representing the geometry in Grasshopper, or `null` if the input is null or not a supported type\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Interfaces.IPolygonal3D)'></a>

## Convert\.ToGrasshopper\(this IPolygonal3D\) Method

Converts an [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') to a Grasshopper [Grasshopper\.Kernel\.Types\.GH\_Curve](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_curve 'Grasshopper\.Kernel\.Types\.GH\_Curve')\.

```csharp
public static GH_Curve? ToGrasshopper(this DiGi.Geometry.Spatial.Interfaces.IPolygonal3D? polygonal3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToGrasshopper(thisDiGi.Geometry.Spatial.Interfaces.IPolygonal3D).polygonal3D'></a>

`polygonal3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')

The polygonal object to convert\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Curve](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_curve 'Grasshopper\.Kernel\.Types\.GH\_Curve')  
A [Grasshopper\.Kernel\.Types\.GH\_Curve](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_curve 'Grasshopper\.Kernel\.Types\.GH\_Curve') representing the polygonal object, or `null` if the input is `null`\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D)'></a>

## Convert\.ToRhino\(this BoundingBox3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') to a Rhino \.

```csharp
public static BoundingBox ToRhino(this DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The 3D bounding box to convert\.

#### Returns
[Rhino\.Geometry\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox 'Rhino\.Geometry\.BoundingBox')  
The corresponding Rhino bounding box, or [Rhino\.Geometry\.BoundingBox\.Unset](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox.unset 'Rhino\.Geometry\.BoundingBox\.Unset') if the input is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Ellipse3D)'></a>

## Convert\.ToRhino\(this Ellipse3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipse3d 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D') instance to a Rhino [Rhino\.Geometry\.Ellipse](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.ellipse 'Rhino\.Geometry\.Ellipse')\.

```csharp
public static Ellipse ToRhino(this DiGi.Geometry.Spatial.Classes.Ellipse3D? ellipse3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Ellipse3D).ellipse3D'></a>

`ellipse3D` [DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipse3d 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D')

The 3D ellipse to convert\.

#### Returns
[Rhino\.Geometry\.Ellipse](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.ellipse 'Rhino\.Geometry\.Ellipse')  
A Rhino [Rhino\.Geometry\.Ellipse](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.ellipse 'Rhino\.Geometry\.Ellipse') representation of the provided ellipse, or a default Rhino ellipse if the input is null or incomplete\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Ellipsoid)'></a>

## Convert\.ToRhino\(this Ellipsoid\) Method

Converts an ellipsoid to a Rhino Brep\.

```csharp
public static Brep? ToRhino(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Ellipsoid).ellipsoid'></a>

`ellipsoid` [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The ellipsoid to convert\.

#### Returns
[Rhino\.Geometry\.Brep](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.brep 'Rhino\.Geometry\.Brep')  
A Rhino [Rhino\.Geometry\.Brep](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.brep 'Rhino\.Geometry\.Brep') representing the ellipsoid, or `null` if the conversion fails\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Mesh3D)'></a>

## Convert\.ToRhino\(this Mesh3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') to a Rhino [Rhino\.Geometry\.Mesh](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.mesh 'Rhino\.Geometry\.Mesh')\.

```csharp
public static Mesh? ToRhino(this DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Mesh3D).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The 3D mesh to convert\.

#### Returns
[Rhino\.Geometry\.Mesh](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.mesh 'Rhino\.Geometry\.Mesh')  
A Rhino [Rhino\.Geometry\.Mesh](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.mesh 'Rhino\.Geometry\.Mesh') instance, or `null` if the input [mesh3D](DiGi.Rhino.Geometry.Spatial.md#DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Mesh3D).mesh3D 'DiGi\.Rhino\.Geometry\.Spatial\.Convert\.ToRhino\(this DiGi\.Geometry\.Spatial\.Classes\.Mesh3D\)\.mesh3D') is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Plane)'></a>

## Convert\.ToRhino\(this Plane\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') instance to its corresponding Rhino geometry plane representation\.

```csharp
public static Plane ToRhino(this DiGi.Geometry.Spatial.Classes.Plane plane);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Plane).plane'></a>

`plane` [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The source plane to convert\.

#### Returns
[Rhino\.Geometry\.Plane](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.plane 'Rhino\.Geometry\.Plane')  
A [Rhino\.Geometry\.Plane](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.plane 'Rhino\.Geometry\.Plane') representing the converted plane, or [Rhino\.Geometry\.Plane\.Unset](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.plane.unset 'Rhino\.Geometry\.Plane\.Unset') if the conversion fails or the input is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Convert\.ToRhino\(this Point3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to a Rhino [Rhino\.Geometry\.Point3d](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.point3d 'Rhino\.Geometry\.Point3d')\.

```csharp
public static Point3d ToRhino(this DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The 3D point to convert\.

#### Returns
[Rhino\.Geometry\.Point3d](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.point3d 'Rhino\.Geometry\.Point3d')  
The equivalent Rhino [Rhino\.Geometry\.Point3d](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.point3d 'Rhino\.Geometry\.Point3d'), or [Rhino\.Geometry\.Point3d\.Unset](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.point3d.unset 'Rhino\.Geometry\.Point3d\.Unset') if the input is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Polyhedron,double)'></a>

## Convert\.ToRhino\(this Polyhedron, double\) Method

Converts a polyhedron to a Rhino Brep by joining its polygonal faces\.

```csharp
public static Brep? ToRhino(this DiGi.Geometry.Spatial.Classes.Polyhedron? polyhedron, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Polyhedron,double).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')

The polyhedron to convert\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Polyhedron,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for the conversion and joining process\.

#### Returns
[Rhino\.Geometry\.Brep](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.brep 'Rhino\.Geometry\.Brep')  
A Rhino [Rhino\.Geometry\.Brep](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.brep 'Rhino\.Geometry\.Brep') representing the polyhedron, or `null` if the conversion fails\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Polyline3D)'></a>

## Convert\.ToRhino\(this Polyline3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') instance to a Rhino [Rhino\.Geometry\.PolylineCurve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.polylinecurve 'Rhino\.Geometry\.PolylineCurve')\.

```csharp
public static PolylineCurve? ToRhino(this DiGi.Geometry.Spatial.Classes.Polyline3D? polyline3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Polyline3D).polyline3D'></a>

`polyline3D` [DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D')

The polyline 3D object to convert\.

#### Returns
[Rhino\.Geometry\.PolylineCurve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.polylinecurve 'Rhino\.Geometry\.PolylineCurve')  
A [Rhino\.Geometry\.PolylineCurve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.polylinecurve 'Rhino\.Geometry\.PolylineCurve') representing the polyline, or `null` if the input is null or contains insufficient points for a curve\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Rectangle3D)'></a>

## Convert\.ToRhino\(this Rectangle3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.rectangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') instance to a Rhino [Rhino\.Geometry\.Rectangle3d](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.rectangle3d 'Rhino\.Geometry\.Rectangle3d')\.

```csharp
public static Rectangle3d ToRhino(this DiGi.Geometry.Spatial.Classes.Rectangle3D? rectangle3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Rectangle3D).rectangle3D'></a>

`rectangle3D` [DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.rectangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D')

The source rectangle to convert\.

#### Returns
[Rhino\.Geometry\.Rectangle3d](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.rectangle3d 'Rhino\.Geometry\.Rectangle3d')  
A Rhino [Rhino\.Geometry\.Rectangle3d](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.rectangle3d 'Rhino\.Geometry\.Rectangle3d') representation of the input;
otherwise, [Rhino\.Geometry\.Rectangle3d\.Unset](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.rectangle3d.unset 'Rhino\.Geometry\.Rectangle3d\.Unset') if the input is null or contains invalid data\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Segment3D)'></a>

## Convert\.ToRhino\(this Segment3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') to a Rhino [Rhino\.Geometry\.LineCurve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.linecurve 'Rhino\.Geometry\.LineCurve')\.

```csharp
public static LineCurve ToRhino(this DiGi.Geometry.Spatial.Classes.Segment3D segment3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Segment3D).segment3D'></a>

`segment3D` [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The 3D line segment to convert\.

#### Returns
[Rhino\.Geometry\.LineCurve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.linecurve 'Rhino\.Geometry\.LineCurve')  
A Rhino [Rhino\.Geometry\.LineCurve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.linecurve 'Rhino\.Geometry\.LineCurve') representation of the segment\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Convert\.ToRhino\(this Vector3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to a Rhino [Rhino\.Geometry\.Vector3d](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.vector3d 'Rhino\.Geometry\.Vector3d')\.

```csharp
public static Vector3d ToRhino(this DiGi.Geometry.Spatial.Classes.Vector3D vector3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The source 3D vector to convert\.

#### Returns
[Rhino\.Geometry\.Vector3d](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.vector3d 'Rhino\.Geometry\.Vector3d')  
A Rhino [Rhino\.Geometry\.Vector3d](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.vector3d 'Rhino\.Geometry\.Vector3d') representation of the input vector, or [Rhino\.Geometry\.Vector3d\.Unset](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.vector3d.unset 'Rhino\.Geometry\.Vector3d\.Unset') if the input is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Interfaces.IPolygonal3D)'></a>

## Convert\.ToRhino\(this IPolygonal3D\) Method

Converts an [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') instance to a Rhino [Rhino\.Geometry\.PolylineCurve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.polylinecurve 'Rhino\.Geometry\.PolylineCurve')\.

```csharp
public static PolylineCurve? ToRhino(this DiGi.Geometry.Spatial.Interfaces.IPolygonal3D? polygonal3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Interfaces.IPolygonal3D).polygonal3D'></a>

`polygonal3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')

The polygonal 3D object to convert\.

#### Returns
[Rhino\.Geometry\.PolylineCurve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.polylinecurve 'Rhino\.Geometry\.PolylineCurve')  
A [Rhino\.Geometry\.PolylineCurve](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.polylinecurve 'Rhino\.Geometry\.PolylineCurve') representing the polygonal object, or `null` if the input is null or contains insufficient points for a curve\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double)'></a>

## Convert\.ToRhino\(this IPolygonalFace3D, double\) Method

Converts a polygonal face to a Rhino Brep\.

```csharp
public static Brep? ToRhino(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The polygonal face to convert\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for the conversion process\.

#### Returns
[Rhino\.Geometry\.Brep](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.brep 'Rhino\.Geometry\.Brep')  
A Rhino [Rhino\.Geometry\.Brep](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.brep 'Rhino\.Geometry\.Brep') representing the polygonal face, or `null` if the conversion fails\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino_Box(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D)'></a>

## Convert\.ToRhino\_Box\(this BoundingBox3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') to a Rhino [Rhino\.Geometry\.Box](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.box 'Rhino\.Geometry\.Box')\.

```csharp
public static Box ToRhino_Box(this DiGi.Geometry.Spatial.Classes.BoundingBox3D boundingBox3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino_Box(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The 3D bounding box to convert\.

#### Returns
[Rhino\.Geometry\.Box](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.box 'Rhino\.Geometry\.Box')  
A Rhino [Rhino\.Geometry\.Box](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.box 'Rhino\.Geometry\.Box') representation of the bounding box, or [Rhino\.Geometry\.Box\.Unset](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.box.unset 'Rhino\.Geometry\.Box\.Unset') if the input is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino_Line(thisDiGi.Geometry.Spatial.Classes.Segment3D)'></a>

## Convert\.ToRhino\_Line\(this Segment3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') to a Rhino [Rhino\.Geometry\.Line](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.line 'Rhino\.Geometry\.Line')\.

```csharp
public static Line ToRhino_Line(this DiGi.Geometry.Spatial.Classes.Segment3D segment3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Convert.ToRhino_Line(thisDiGi.Geometry.Spatial.Classes.Segment3D).segment3D'></a>

`segment3D` [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The 3D line segment to convert\.

#### Returns
[Rhino\.Geometry\.Line](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.line 'Rhino\.Geometry\.Line')  
A Rhino [Rhino\.Geometry\.Line](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.line 'Rhino\.Geometry\.Line') representation of the segment\.

<a name='DiGi.Rhino.Geometry.Spatial.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Create.BoundingBox(thisDiGi.Geometry.Core.Interfaces.IGeometry)'></a>

## Create\.BoundingBox\(this IGeometry\) Method

Calculates the bounding box for the specified geometry\.

```csharp
public static BoundingBox BoundingBox(this DiGi.Geometry.Core.Interfaces.IGeometry? geometry);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Create.BoundingBox(thisDiGi.Geometry.Core.Interfaces.IGeometry).geometry'></a>

`geometry` [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')

The geometry to calculate the bounding box for\.

#### Returns
[Rhino\.Geometry\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox 'Rhino\.Geometry\.BoundingBox')  
A [Rhino\.Geometry\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox 'Rhino\.Geometry\.BoundingBox') representing the bounds of the geometry, or [Rhino\.Geometry\.BoundingBox\.Unset](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox.unset 'Rhino\.Geometry\.BoundingBox\.Unset') if the geometry is null or cannot be bounded\.

<a name='DiGi.Rhino.Geometry.Spatial.Create.BoundingBox(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D)'></a>

## Create\.BoundingBox\(this IIntersectionResult3D\) Method

Calculates the bounding box for the geometries resulting from a 3D intersection operation\.

```csharp
public static BoundingBox BoundingBox(this DiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D? intersectionResult3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Create.BoundingBox(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D).intersectionResult3D'></a>

`intersectionResult3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iintersectionresult3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D')

The intersection result containing the geometries\.

#### Returns
[Rhino\.Geometry\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox 'Rhino\.Geometry\.BoundingBox')  
A [Rhino\.Geometry\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox 'Rhino\.Geometry\.BoundingBox') encompassing all resulting geometries, or [Rhino\.Geometry\.BoundingBox\.Unset](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox.unset 'Rhino\.Geometry\.BoundingBox\.Unset') if no valid geometry is found\.

<a name='DiGi.Rhino.Geometry.Spatial.Create.BoundingBox(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Core.Interfaces.IGeometry_)'></a>

## Create\.BoundingBox\(this IEnumerable\<IGeometry\>\) Method

Calculates the unioned bounding box for a collection of geometries\.

```csharp
public static BoundingBox BoundingBox(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Core.Interfaces.IGeometry>? geometries);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Create.BoundingBox(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Core.Interfaces.IGeometry_).geometries'></a>

`geometries` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of geometries to evaluate\.

#### Returns
[Rhino\.Geometry\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox 'Rhino\.Geometry\.BoundingBox')  
A [Rhino\.Geometry\.BoundingBox](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox 'Rhino\.Geometry\.BoundingBox') that encompasses all valid geometries in the collection, or [Rhino\.Geometry\.BoundingBox\.Unset](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.boundingbox.unset 'Rhino\.Geometry\.BoundingBox\.Unset') if the collection is null or empty\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect'></a>

## Inspect Class

```csharp
public static class Inspect
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Inspect
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.A(thisDiGi.Geometry.Spatial.Classes.Ellipse3D)'></a>

## Inspect\.A\(this Ellipse3D\) Method

Gets the semi\-major axis length of the specified 3D ellipse\.

```csharp
public static GH_Number? A(this DiGi.Geometry.Spatial.Classes.Ellipse3D? ellipse3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.A(thisDiGi.Geometry.Spatial.Classes.Ellipse3D).ellipse3D'></a>

`ellipse3D` [DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipse3d 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D')

The 3D ellipse to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
The semi\-major axis length as a [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number'), or null if the ellipse is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.A(thisDiGi.Geometry.Spatial.Classes.Ellipsoid)'></a>

## Inspect\.A\(this Ellipsoid\) Method

Gets the length of semi\-axis A of the specified ellipsoid\.

```csharp
public static GH_Number? A(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.A(thisDiGi.Geometry.Spatial.Classes.Ellipsoid).ellipsoid'></a>

`ellipsoid` [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The ellipsoid to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
The length of semi\-axis A as a [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number'), or `null` if the ellipsoid is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Area(thisDiGi.Geometry.Spatial.Classes.Triangle3D)'></a>

## Inspect\.Area\(this Triangle3D\) Method

Gets the area of the specified 3D triangle as a [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')\.

```csharp
public static GH_Number? Area(this DiGi.Geometry.Spatial.Classes.Triangle3D? triangle3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Area(thisDiGi.Geometry.Spatial.Classes.Triangle3D).triangle3D'></a>

`triangle3D` [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

The 3D triangle to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
The area of the triangle, or `null` if the triangle is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.B(thisDiGi.Geometry.Spatial.Classes.Ellipse3D)'></a>

## Inspect\.B\(this Ellipse3D\) Method

Gets the semi\-minor axis length of the specified 3D ellipse\.

```csharp
public static GH_Number? B(this DiGi.Geometry.Spatial.Classes.Ellipse3D? ellipse3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.B(thisDiGi.Geometry.Spatial.Classes.Ellipse3D).ellipse3D'></a>

`ellipse3D` [DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipse3d 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D')

The 3D ellipse to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
The semi\-minor axis length as a [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number'), or null if the ellipse is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.B(thisDiGi.Geometry.Spatial.Classes.Ellipsoid)'></a>

## Inspect\.B\(this Ellipsoid\) Method

Gets the length of semi\-axis B of the specified ellipsoid\.

```csharp
public static GH_Number? B(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.B(thisDiGi.Geometry.Spatial.Classes.Ellipsoid).ellipsoid'></a>

`ellipsoid` [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The ellipsoid to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
The length of semi\-axis B as a [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number'), or `null` if the ellipsoid is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.BoundingBox(thisDiGi.Geometry.Spatial.Classes.Polyhedron)'></a>

## Inspect\.BoundingBox\(this Polyhedron\) Method

Retrieves the bounding box of the specified polyhedron\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D? BoundingBox(this DiGi.Geometry.Spatial.Classes.Polyhedron? polyhedron);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.BoundingBox(thisDiGi.Geometry.Spatial.Classes.Polyhedron).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')

The polyhedron to inspect\.

#### Returns
[GooBoundingBox3D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox3D')  
The [GooBoundingBox3D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox3D') representing the bounding box, or `null` if the polyhedron is null or no bounding box exists\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.BoundingBox(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D)'></a>

## Inspect\.BoundingBox\(this IPolygonalFace3D\) Method

Retrieves the bounding box of the specified polygonal face\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D? BoundingBox(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.BoundingBox(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The polygonal face to inspect\.

#### Returns
[GooBoundingBox3D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox3D')  
A [GooBoundingBox3D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox3D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox3D') representing the bounding box, or `null` if the input is null or no bounding box exists\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.C(thisDiGi.Geometry.Spatial.Classes.Ellipsoid)'></a>

## Inspect\.C\(this Ellipsoid\) Method

Gets the length of semi\-axis C of the specified ellipsoid\.

```csharp
public static GH_Number? C(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.C(thisDiGi.Geometry.Spatial.Classes.Ellipsoid).ellipsoid'></a>

`ellipsoid` [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The ellipsoid to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
The length of semi\-axis C as a [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number'), or `null` if the ellipsoid is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Center(thisDiGi.Geometry.Spatial.Classes.Ellipse3D)'></a>

## Inspect\.Center\(this Ellipse3D\) Method

Gets the center point of the specified 3D ellipse\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D? Center(this DiGi.Geometry.Spatial.Classes.Ellipse3D? ellipse3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Center(thisDiGi.Geometry.Spatial.Classes.Ellipse3D).ellipse3D'></a>

`ellipse3D` [DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipse3d 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D')

The 3D ellipse to inspect\.

#### Returns
[GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')  
The center point as a [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D'), or null if the ellipse is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Center(thisDiGi.Geometry.Spatial.Classes.Ellipsoid)'></a>

## Inspect\.Center\(this Ellipsoid\) Method

Gets the center point of the specified ellipsoid\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D? Center(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Center(thisDiGi.Geometry.Spatial.Classes.Ellipsoid).ellipsoid'></a>

`ellipsoid` [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The ellipsoid to inspect\.

#### Returns
[GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')  
The center point as a [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D'), or `null` if the ellipsoid is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Centroid(thisDiGi.Geometry.Spatial.Classes.Triangle3D)'></a>

## Inspect\.Centroid\(this Triangle3D\) Method

Gets the centroid of the specified 3D triangle as a [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D? Centroid(this DiGi.Geometry.Spatial.Classes.Triangle3D? triangle3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Centroid(thisDiGi.Geometry.Spatial.Classes.Triangle3D).triangle3D'></a>

`triangle3D` [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

The 3D triangle to inspect\.

#### Returns
[GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')  
The centroid point of the triangle, or `null` if the triangle is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Direction(thisDiGi.Geometry.Spatial.Classes.Ray3D)'></a>

## Inspect\.Direction\(this Ray3D\) Method

Gets the direction vector of the specified ray as a [GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D')\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D? Direction(this DiGi.Geometry.Spatial.Classes.Ray3D? ray3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Direction(thisDiGi.Geometry.Spatial.Classes.Ray3D).ray3D'></a>

`ray3D` [DiGi\.Geometry\.Spatial\.Classes\.Ray3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ray3d 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The ray to inspect\.

#### Returns
[GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D')  
A [GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D') representing the direction, or `null` if the ray or its direction is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.DirectionA(thisDiGi.Geometry.Spatial.Classes.Ellipsoid)'></a>

## Inspect\.DirectionA\(this Ellipsoid\) Method

Gets the direction vector of semi\-axis A of the specified ellipsoid\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D? DirectionA(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.DirectionA(thisDiGi.Geometry.Spatial.Classes.Ellipsoid).ellipsoid'></a>

`ellipsoid` [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The ellipsoid to inspect\.

#### Returns
[GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D')  
The direction vector A as a [GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D'), or `null` if the ellipsoid is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.DirectionB(thisDiGi.Geometry.Spatial.Classes.Ellipsoid)'></a>

## Inspect\.DirectionB\(this Ellipsoid\) Method

Gets the direction vector of semi\-axis B of the specified ellipsoid\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D? DirectionB(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.DirectionB(thisDiGi.Geometry.Spatial.Classes.Ellipsoid).ellipsoid'></a>

`ellipsoid` [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The ellipsoid to inspect\.

#### Returns
[GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D')  
The direction vector B as a [GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D'), or `null` if the ellipsoid is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.DirectionC(thisDiGi.Geometry.Spatial.Classes.Ellipsoid)'></a>

## Inspect\.DirectionC\(this Ellipsoid\) Method

Gets the direction vector of semi\-axis C of the specified ellipsoid\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D? DirectionC(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.DirectionC(thisDiGi.Geometry.Spatial.Classes.Ellipsoid).ellipsoid'></a>

`ellipsoid` [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The ellipsoid to inspect\.

#### Returns
[GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D')  
The direction vector C as a [GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D'), or `null` if the ellipsoid is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.FocalPoints(thisDiGi.Geometry.Spatial.Classes.Ellipse3D)'></a>

## Inspect\.FocalPoints\(this Ellipse3D\) Method

Gets the focal points of the specified 3D ellipse\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D>? FocalPoints(this DiGi.Geometry.Spatial.Classes.Ellipse3D? ellipse3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.FocalPoints(thisDiGi.Geometry.Spatial.Classes.Ellipse3D).ellipse3D'></a>

`ellipse3D` [DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipse3d 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D')

The 3D ellipse to inspect\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of focal points as [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D'), or null if the ellipse is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.FocalPoints(thisDiGi.Geometry.Spatial.Classes.Ellipsoid)'></a>

## Inspect\.FocalPoints\(this Ellipsoid\) Method

Gets the focal points of the specified ellipsoid\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D>? FocalPoints(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.FocalPoints(thisDiGi.Geometry.Spatial.Classes.Ellipsoid).ellipsoid'></a>

`ellipsoid` [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The ellipsoid to inspect\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of focal points as [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D'), or `null` if the ellipsoid is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Geometry3Ds(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D)'></a>

## Inspect\.Geometry3Ds\(this IIntersectionResult3D\) Method

Extracts the 3D geometries from the specified intersection result\.

```csharp
public static System.Collections.IEnumerable? Geometry3Ds(this DiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D? intersectionResult3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Geometry3Ds(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D).intersectionResult3D'></a>

`intersectionResult3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iintersectionresult3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D')

The intersection result to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An enumerable collection of 3D geometries, or `null` if the intersection result is null or contains no geometries\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.InternalPoint(thisDiGi.Geometry.Spatial.Classes.Polyhedron)'></a>

## Inspect\.InternalPoint\(this Polyhedron\) Method

Retrieves the internal point of the specified polyhedron\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D? InternalPoint(this DiGi.Geometry.Spatial.Classes.Polyhedron? polyhedron);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.InternalPoint(thisDiGi.Geometry.Spatial.Classes.Polyhedron).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')

The polyhedron to inspect\.

#### Returns
[GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')  
The [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D') representing the internal point, or `null` if the polyhedron is null or no internal point exists\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.InternalPoint(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D)'></a>

## Inspect\.InternalPoint\(this IPolygonalFace3D\) Method

Retrieves the internal point of the specified polygonal face\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D? InternalPoint(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.InternalPoint(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The polygonal face to inspect\.

#### Returns
[GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')  
A [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D') representing the internal point, or `null` if the input is null or no internal point exists\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Length(thisDiGi.Geometry.Spatial.Classes.Triangle3D)'></a>

## Inspect\.Length\(this Triangle3D\) Method

Gets the total perimeter length of the specified 3D triangle as a [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')\.

```csharp
public static GH_Number? Length(this DiGi.Geometry.Spatial.Classes.Triangle3D? triangle3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Length(thisDiGi.Geometry.Spatial.Classes.Triangle3D).triangle3D'></a>

`triangle3D` [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

The 3D triangle to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
The total length of the triangle's edges, or `null` if the triangle is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Length(thisDiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Inspect\.Length\(this Vector3D\) Method

Gets the length of the specified vector as a GH\_Number\.

```csharp
public static GH_Number? Length(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Length(thisDiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D instance to measure\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') containing the length of the vector, or `null` if the input vector is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Mesh3D(thisDiGi.Geometry.Spatial.Classes.Polyhedron)'></a>

## Inspect\.Mesh3D\(this Polyhedron\) Method

Creates a mesh representation of the specified polyhedron\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D? Mesh3D(this DiGi.Geometry.Spatial.Classes.Polyhedron? polyhedron);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Mesh3D(thisDiGi.Geometry.Spatial.Classes.Polyhedron).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')

The polyhedron to convert into a mesh\.

#### Returns
[GooMesh3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D')  
The [GooMesh3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D') representing the polyhedron, or `null` if the conversion fails or the input is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Mesh3D(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D)'></a>

## Inspect\.Mesh3D\(this IPolygonalFace3D\) Method

Creates a mesh representation of the specified polygonal face\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D? Mesh3D(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Mesh3D(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The polygonal face to convert to a mesh\.

#### Returns
[GooMesh3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D')  
A [GooMesh3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D') representing the mesh, or `null` if the conversion fails or the input is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Origin(thisDiGi.Geometry.Spatial.Classes.Ray3D)'></a>

## Inspect\.Origin\(this Ray3D\) Method

Gets the origin point of the specified ray as a [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D? Origin(this DiGi.Geometry.Spatial.Classes.Ray3D? ray3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Origin(thisDiGi.Geometry.Spatial.Classes.Ray3D).ray3D'></a>

`ray3D` [DiGi\.Geometry\.Spatial\.Classes\.Ray3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ray3d 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The ray to inspect\.

#### Returns
[GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')  
A [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D') representing the origin, or `null` if the ray or its origin is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Plane(thisDiGi.Geometry.Spatial.Classes.Ellipse3D)'></a>

## Inspect\.Plane\(this Ellipse3D\) Method

Gets the plane on which the specified 3D ellipse is defined\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooPlane? Plane(this DiGi.Geometry.Spatial.Classes.Ellipse3D? ellipse3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Plane(thisDiGi.Geometry.Spatial.Classes.Ellipse3D).ellipse3D'></a>

`ellipse3D` [DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipse3d 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D')

The 3D ellipse to inspect\.

#### Returns
[GooPlane](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPlane 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPlane')  
The plane as a [GooPlane](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPlane 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPlane'), or null if the ellipse is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Plane(thisDiGi.Geometry.Spatial.Classes.Triangle3D)'></a>

## Inspect\.Plane\(this Triangle3D\) Method

Gets the plane on which the specified 3D triangle lies as a [GooPlane](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPlane 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPlane')\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooPlane? Plane(this DiGi.Geometry.Spatial.Classes.Triangle3D? triangle3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Plane(thisDiGi.Geometry.Spatial.Classes.Triangle3D).triangle3D'></a>

`triangle3D` [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

The 3D triangle to inspect\.

#### Returns
[GooPlane](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPlane 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPlane')  
The plane of the triangle, or `null` if the triangle is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Points(thisDiGi.Geometry.Spatial.Classes.Mesh3D)'></a>

## Inspect\.Points\(this Mesh3D\) Method

Retrieves the collection of points from the specified 3D mesh\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D>? Points(this DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Points(thisDiGi.Geometry.Spatial.Classes.Mesh3D).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The 3D mesh to extract points from\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D') objects if the mesh is not null; otherwise, null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Points(thisDiGi.Geometry.Spatial.Classes.Triangle3D)'></a>

## Inspect\.Points\(this Triangle3D\) Method

Gets the vertices of the specified 3D triangle as a collection of [GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D>? Points(this DiGi.Geometry.Spatial.Classes.Triangle3D? triangle3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Points(thisDiGi.Geometry.Spatial.Classes.Triangle3D).triangle3D'></a>

`triangle3D` [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

The 3D triangle to inspect\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GooPoint3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of points representing the triangle's vertices, or `null` if the triangle is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.PolygonalFaces(thisDiGi.Geometry.Spatial.Classes.Polyhedron)'></a>

## Inspect\.PolygonalFaces\(this Polyhedron\) Method

Retrieves the polygonal faces of the specified polyhedron\.

```csharp
public static System.Collections.IEnumerable? PolygonalFaces(this DiGi.Geometry.Spatial.Classes.Polyhedron? polyhedron);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.PolygonalFaces(thisDiGi.Geometry.Spatial.Classes.Polyhedron).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')

The polyhedron to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
A collection of polygonal faces as [GooPolygonalFace3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D') objects, or `null` if the polyhedron is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Segments(thisDiGi.Geometry.Spatial.Classes.Triangle3D)'></a>

## Inspect\.Segments\(this Triangle3D\) Method

Gets the segments forming the perimeter of the specified 3D triangle as a collection of [GooSegment3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooSegment3D')\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3D>? Segments(this DiGi.Geometry.Spatial.Classes.Triangle3D? triangle3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Segments(thisDiGi.Geometry.Spatial.Classes.Triangle3D).triangle3D'></a>

`triangle3D` [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

The 3D triangle to inspect\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GooSegment3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooSegment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of segments representing the triangle's edges, or `null` if the triangle is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Triangles(thisDiGi.Geometry.Spatial.Classes.Mesh3D)'></a>

## Inspect\.Triangles\(this Mesh3D\) Method

Retrieves the collection of triangles from the specified 3D mesh\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3D>? Triangles(this DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Triangles(thisDiGi.Geometry.Spatial.Classes.Mesh3D).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The 3D mesh to extract triangles from\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GooTriangle3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooTriangle3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of [GooTriangle3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooTriangle3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooTriangle3D') objects if the mesh is not null; otherwise, null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Unit(thisDiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Inspect\.Unit\(this Vector3D\) Method

Gets the unit vector of the specified vector as a GooVector3D\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D? Unit(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Unit(thisDiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D instance to normalize\.

#### Returns
[GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D')  
A [GooVector3D](DiGi.Rhino.Geometry.Spatial.Classes.md#DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D') representing the unit vector, or `null` if the input vector is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.X(thisDiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Inspect\.X\(this Point3D\) Method

Gets the X coordinate of the specified 3D point as a Grasshopper number\.

```csharp
public static GH_Number? X(this DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.X(thisDiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The 3D point to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') containing the X coordinate, or `null` if the point is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.X(thisDiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Inspect\.X\(this Vector3D\) Method

Gets the X coordinate of the specified vector as a GH\_Number\.

```csharp
public static GH_Number? X(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.X(thisDiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D instance\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') containing the X component, or `null` if the input vector is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Y(thisDiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Inspect\.Y\(this Point3D\) Method

Gets the Y coordinate of the specified 3D point as a Grasshopper number\.

```csharp
public static GH_Number? Y(this DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Y(thisDiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The 3D point to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') containing the Y coordinate, or `null` if the point is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Y(thisDiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Inspect\.Y\(this Vector3D\) Method

Gets the Y coordinate of the specified vector as a GH\_Number\.

```csharp
public static GH_Number? Y(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Y(thisDiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D instance\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') containing the Y component, or `null` if the input vector is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Z(thisDiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Inspect\.Z\(this Point3D\) Method

Gets the Z coordinate of the specified 3D point as a Grasshopper number\.

```csharp
public static GH_Number? Z(this DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Z(thisDiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The 3D point to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') containing the Z coordinate, or `null` if the point is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Z(thisDiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Inspect\.Z\(this Vector3D\) Method

Gets the Z coordinate of the specified vector as a GH\_Number\.

```csharp
public static GH_Number? Z(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Inspect.Z(thisDiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D instance\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') containing the Z component, or `null` if the input vector is null\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Core.Interfaces.IGeometry,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_)'></a>

## Modify\.BakeGeometry\(this IGeometry, RhinoDoc, ObjectAttributes, List\<Guid\>\) Method

Bakes a geometry object into the specified Rhino document\.

```csharp
public static bool BakeGeometry(this DiGi.Geometry.Core.Interfaces.IGeometry? geometry, RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out System.Collections.Generic.List<System.Guid>? guids);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Core.Interfaces.IGeometry,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).geometry'></a>

`geometry` [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')

The geometry to bake\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Core.Interfaces.IGeometry,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The target Rhino document\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Core.Interfaces.IGeometry,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).objectAttributes'></a>

`objectAttributes` [Rhino\.DocObjects\.ObjectAttributes](https://learn.microsoft.com/en-us/dotnet/api/rhino.docobjects.objectattributes 'Rhino\.DocObjects\.ObjectAttributes')

The attributes to assign to the baked object\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Core.Interfaces.IGeometry,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).guids'></a>

`guids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of GUIDs for the objects created in Rhino, or null if baking failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the geometry was successfully baked; otherwise, false\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Planar.Interfaces.IGeometry2D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_)'></a>

## Modify\.BakeGeometry\(this IGeometry2D, RhinoDoc, ObjectAttributes, List\<Guid\>\) Method

Bakes a 2D geometry object into the specified Rhino document by converting it to 3D on the World Z plane\.

```csharp
public static bool BakeGeometry(this DiGi.Geometry.Planar.Interfaces.IGeometry2D? geometry2D, RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out System.Collections.Generic.List<System.Guid>? guids);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Planar.Interfaces.IGeometry2D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).geometry2D'></a>

`geometry2D` [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')

The 2D geometry to bake\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Planar.Interfaces.IGeometry2D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The target Rhino document\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Planar.Interfaces.IGeometry2D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).objectAttributes'></a>

`objectAttributes` [Rhino\.DocObjects\.ObjectAttributes](https://learn.microsoft.com/en-us/dotnet/api/rhino.docobjects.objectattributes 'Rhino\.DocObjects\.ObjectAttributes')

The attributes to assign to the baked object\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Planar.Interfaces.IGeometry2D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).guids'></a>

`guids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of GUIDs for the objects created in Rhino, or null if baking failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the geometry was successfully baked; otherwise, false\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_)'></a>

## Modify\.BakeGeometry\(this IGeometry3D, RhinoDoc, ObjectAttributes, List\<Guid\>\) Method

Bakes a 3D geometry object into the specified Rhino document\.

```csharp
public static bool BakeGeometry(this DiGi.Geometry.Spatial.Interfaces.IGeometry3D? geometry3D, RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out System.Collections.Generic.List<System.Guid>? guids);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).geometry3D'></a>

`geometry3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')

The 3D geometry to bake\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The target Rhino document\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).objectAttributes'></a>

`objectAttributes` [Rhino\.DocObjects\.ObjectAttributes](https://learn.microsoft.com/en-us/dotnet/api/rhino.docobjects.objectattributes 'Rhino\.DocObjects\.ObjectAttributes')

The attributes to assign to the baked object\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).guids'></a>

`guids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of GUIDs for the objects created in Rhino, or null if baking failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the geometry was successfully baked; otherwise, false\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_)'></a>

## Modify\.BakeGeometry\(this IIntersectionResult3D, RhinoDoc, ObjectAttributes, List\<Guid\>\) Method

Bakes the geometries resulting from a 3D intersection into the specified Rhino document\.

```csharp
public static bool BakeGeometry(this DiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D? intersectionResult3D, RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out System.Collections.Generic.List<System.Guid>? guids);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).intersectionResult3D'></a>

`intersectionResult3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iintersectionresult3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D')

The result of a 3D intersection\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The target Rhino document\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).objectAttributes'></a>

`objectAttributes` [Rhino\.DocObjects\.ObjectAttributes](https://learn.microsoft.com/en-us/dotnet/api/rhino.docobjects.objectattributes 'Rhino\.DocObjects\.ObjectAttributes')

The attributes to assign to the baked objects\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).guids'></a>

`guids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of GUIDs for the objects created in Rhino, or null if baking failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the intersection geometries were successfully baked; otherwise, false\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_)'></a>

## Modify\.BakeGeometry\<TGeometry\>\(this IEnumerable\<TGeometry\>, RhinoDoc, ObjectAttributes, List\<Guid\>\) Method

Bakes a collection of geometry objects into the specified Rhino document\.

```csharp
public static bool BakeGeometry<TGeometry>(this System.Collections.Generic.IEnumerable<TGeometry>? geometries, RhinoDoc? rhinoDoc, ObjectAttributes? objectAttributes, out System.Collections.Generic.List<System.Guid>? guids)
    where TGeometry : DiGi.Geometry.Core.Interfaces.IGeometry;
```
#### Type parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).TGeometry'></a>

`TGeometry`

The type of geometry, which must implement [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')\.
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).geometries'></a>

`geometries` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TGeometry](DiGi.Rhino.Geometry.Spatial.md#DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).TGeometry 'DiGi\.Rhino\.Geometry\.Spatial\.Modify\.BakeGeometry\<TGeometry\>\(this System\.Collections\.Generic\.IEnumerable\<TGeometry\>, RhinoDoc, ObjectAttributes, System\.Collections\.Generic\.List\<System\.Guid\>\)\.TGeometry')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of geometries to bake\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).rhinoDoc'></a>

`rhinoDoc` [Rhino\.RhinoDoc](https://learn.microsoft.com/en-us/dotnet/api/rhino.rhinodoc 'Rhino\.RhinoDoc')

The target Rhino document\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).objectAttributes'></a>

`objectAttributes` [Rhino\.DocObjects\.ObjectAttributes](https://learn.microsoft.com/en-us/dotnet/api/rhino.docobjects.objectattributes 'Rhino\.DocObjects\.ObjectAttributes')

The attributes to assign to the baked objects\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.BakeGeometry_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,RhinoDoc,ObjectAttributes,System.Collections.Generic.List_System.Guid_).guids'></a>

`guids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of GUIDs for all objects created in Rhino, or null if baking failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if at least one geometry was successfully baked; otherwise, false\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Core.Interfaces.IGeometry,GH_PreviewMeshArgs,DisplayMaterial)'></a>

## Modify\.DrawViewportMeshes\(this IGeometry, GH\_PreviewMeshArgs, DisplayMaterial\) Method

Draws the viewport meshes for a given geometry using the provided preview arguments and material\.

```csharp
public static void DrawViewportMeshes(this DiGi.Geometry.Core.Interfaces.IGeometry? geometry, GH_PreviewMeshArgs? gH_PreviewMeshArgs, DisplayMaterial? displayMaterial=null);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Core.Interfaces.IGeometry,GH_PreviewMeshArgs,DisplayMaterial).geometry'></a>

`geometry` [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')

The geometry to draw\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Core.Interfaces.IGeometry,GH_PreviewMeshArgs,DisplayMaterial).gH_PreviewMeshArgs'></a>

`gH_PreviewMeshArgs` [Grasshopper\.Kernel\.GH\_PreviewMeshArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_previewmeshargs 'Grasshopper\.Kernel\.GH\_PreviewMeshArgs')

The Grasshopper preview mesh arguments containing pipeline information\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Core.Interfaces.IGeometry,GH_PreviewMeshArgs,DisplayMaterial).displayMaterial'></a>

`displayMaterial` [Rhino\.Display\.DisplayMaterial](https://learn.microsoft.com/en-us/dotnet/api/rhino.display.displaymaterial 'Rhino\.Display\.DisplayMaterial')

Optional display material to use; defaults to the one provided in [gH\_PreviewMeshArgs](DiGi.Rhino.Geometry.Spatial.md#DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Core.Interfaces.IGeometry,GH_PreviewMeshArgs,DisplayMaterial).gH_PreviewMeshArgs 'DiGi\.Rhino\.Geometry\.Spatial\.Modify\.DrawViewportMeshes\(this DiGi\.Geometry\.Core\.Interfaces\.IGeometry, GH\_PreviewMeshArgs, DisplayMaterial\)\.gH\_PreviewMeshArgs')\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,GH_PreviewMeshArgs,DisplayMaterial)'></a>

## Modify\.DrawViewportMeshes\(this IGeometry3D, GH\_PreviewMeshArgs, DisplayMaterial\) Method

Draws the viewport meshes for a given 3D geometry using the provided preview arguments and material\.

```csharp
public static void DrawViewportMeshes(this DiGi.Geometry.Spatial.Interfaces.IGeometry3D? geometry3D, GH_PreviewMeshArgs? gH_PreviewMeshArgs, DisplayMaterial? displayMaterial=null);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,GH_PreviewMeshArgs,DisplayMaterial).geometry3D'></a>

`geometry3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')

The 3D geometry to draw\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,GH_PreviewMeshArgs,DisplayMaterial).gH_PreviewMeshArgs'></a>

`gH_PreviewMeshArgs` [Grasshopper\.Kernel\.GH\_PreviewMeshArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_previewmeshargs 'Grasshopper\.Kernel\.GH\_PreviewMeshArgs')

The Grasshopper preview mesh arguments containing pipeline information\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,GH_PreviewMeshArgs,DisplayMaterial).displayMaterial'></a>

`displayMaterial` [Rhino\.Display\.DisplayMaterial](https://learn.microsoft.com/en-us/dotnet/api/rhino.display.displaymaterial 'Rhino\.Display\.DisplayMaterial')

Optional display material to use; defaults to the one provided in [gH\_PreviewMeshArgs](DiGi.Rhino.Geometry.Spatial.md#DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,GH_PreviewMeshArgs,DisplayMaterial).gH_PreviewMeshArgs 'DiGi\.Rhino\.Geometry\.Spatial\.Modify\.DrawViewportMeshes\(this DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D, GH\_PreviewMeshArgs, DisplayMaterial\)\.gH\_PreviewMeshArgs')\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D,GH_PreviewMeshArgs,DisplayMaterial)'></a>

## Modify\.DrawViewportMeshes\(this IIntersectionResult3D, GH\_PreviewMeshArgs, DisplayMaterial\) Method

Draws the viewport meshes for the results of a 3D intersection using the provided preview arguments and material\.

```csharp
public static void DrawViewportMeshes(this DiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D? intersectionResult3D, GH_PreviewMeshArgs? gH_PreviewMeshArgs, DisplayMaterial? displayMaterial=null);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D,GH_PreviewMeshArgs,DisplayMaterial).intersectionResult3D'></a>

`intersectionResult3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iintersectionresult3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D')

The result of a 3D intersection operation\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D,GH_PreviewMeshArgs,DisplayMaterial).gH_PreviewMeshArgs'></a>

`gH_PreviewMeshArgs` [Grasshopper\.Kernel\.GH\_PreviewMeshArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_previewmeshargs 'Grasshopper\.Kernel\.GH\_PreviewMeshArgs')

The Grasshopper preview mesh arguments containing pipeline information\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D,GH_PreviewMeshArgs,DisplayMaterial).displayMaterial'></a>

`displayMaterial` [Rhino\.Display\.DisplayMaterial](https://learn.microsoft.com/en-us/dotnet/api/rhino.display.displaymaterial 'Rhino\.Display\.DisplayMaterial')

Optional display material to use; defaults to the one provided in [gH\_PreviewMeshArgs](DiGi.Rhino.Geometry.Spatial.md#DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D,GH_PreviewMeshArgs,DisplayMaterial).gH_PreviewMeshArgs 'DiGi\.Rhino\.Geometry\.Spatial\.Modify\.DrawViewportMeshes\(this DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D, GH\_PreviewMeshArgs, DisplayMaterial\)\.gH\_PreviewMeshArgs')\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,GH_PreviewMeshArgs,DisplayMaterial)'></a>

## Modify\.DrawViewportMeshes\<TGeometry\>\(this IEnumerable\<TGeometry\>, GH\_PreviewMeshArgs, DisplayMaterial\) Method

Draws the viewport meshes for a collection of geometries using the provided preview arguments and material\.

```csharp
public static void DrawViewportMeshes<TGeometry>(this System.Collections.Generic.IEnumerable<TGeometry>? geometries, GH_PreviewMeshArgs? gH_PreviewMeshArgs, DisplayMaterial? displayMaterial=null)
    where TGeometry : DiGi.Geometry.Core.Interfaces.IGeometry;
```
#### Type parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,GH_PreviewMeshArgs,DisplayMaterial).TGeometry'></a>

`TGeometry`

The type of geometry, which must implement [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')\.
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,GH_PreviewMeshArgs,DisplayMaterial).geometries'></a>

`geometries` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TGeometry](DiGi.Rhino.Geometry.Spatial.md#DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,GH_PreviewMeshArgs,DisplayMaterial).TGeometry 'DiGi\.Rhino\.Geometry\.Spatial\.Modify\.DrawViewportMeshes\<TGeometry\>\(this System\.Collections\.Generic\.IEnumerable\<TGeometry\>, GH\_PreviewMeshArgs, DisplayMaterial\)\.TGeometry')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An enumerable collection of geometries to draw\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,GH_PreviewMeshArgs,DisplayMaterial).gH_PreviewMeshArgs'></a>

`gH_PreviewMeshArgs` [Grasshopper\.Kernel\.GH\_PreviewMeshArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_previewmeshargs 'Grasshopper\.Kernel\.GH\_PreviewMeshArgs')

The Grasshopper preview mesh arguments containing pipeline information\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,GH_PreviewMeshArgs,DisplayMaterial).displayMaterial'></a>

`displayMaterial` [Rhino\.Display\.DisplayMaterial](https://learn.microsoft.com/en-us/dotnet/api/rhino.display.displaymaterial 'Rhino\.Display\.DisplayMaterial')

Optional display material to use; defaults to the one provided in [gH\_PreviewMeshArgs](DiGi.Rhino.Geometry.Spatial.md#DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportMeshes_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,GH_PreviewMeshArgs,DisplayMaterial).gH_PreviewMeshArgs 'DiGi\.Rhino\.Geometry\.Spatial\.Modify\.DrawViewportMeshes\<TGeometry\>\(this System\.Collections\.Generic\.IEnumerable\<TGeometry\>, GH\_PreviewMeshArgs, DisplayMaterial\)\.gH\_PreviewMeshArgs')\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Core.Interfaces.IGeometry,GH_PreviewWireArgs,System.Drawing.Color)'></a>

## Modify\.DrawViewportWires\(this IGeometry, GH\_PreviewWireArgs, Color\) Method

Draws the wire representation of a geometry in the Rhino viewport\.

```csharp
public static void DrawViewportWires(this DiGi.Geometry.Core.Interfaces.IGeometry? geometry, GH_PreviewWireArgs? gH_PreviewWireArgs, System.Drawing.Color color);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Core.Interfaces.IGeometry,GH_PreviewWireArgs,System.Drawing.Color).geometry'></a>

`geometry` [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')

The geometry to draw\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Core.Interfaces.IGeometry,GH_PreviewWireArgs,System.Drawing.Color).gH_PreviewWireArgs'></a>

`gH_PreviewWireArgs` [Grasshopper\.Kernel\.GH\_PreviewWireArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_previewwireargs 'Grasshopper\.Kernel\.GH\_PreviewWireArgs')

The Grasshopper preview wire arguments providing the drawing pipeline\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Core.Interfaces.IGeometry,GH_PreviewWireArgs,System.Drawing.Color).color'></a>

`color` [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')

The color used for drawing\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Planar.Interfaces.IGeometry2D,GH_PreviewWireArgs,System.Drawing.Color)'></a>

## Modify\.DrawViewportWires\(this IGeometry2D, GH\_PreviewWireArgs, Color\) Method

Draws the wire representation of a 2D geometry in the Rhino viewport by converting it to 3D on the World Z plane\.

```csharp
public static void DrawViewportWires(this DiGi.Geometry.Planar.Interfaces.IGeometry2D? geometry2D, GH_PreviewWireArgs? gH_PreviewWireArgs, System.Drawing.Color color);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Planar.Interfaces.IGeometry2D,GH_PreviewWireArgs,System.Drawing.Color).geometry2D'></a>

`geometry2D` [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')

The 2D geometry to draw\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Planar.Interfaces.IGeometry2D,GH_PreviewWireArgs,System.Drawing.Color).gH_PreviewWireArgs'></a>

`gH_PreviewWireArgs` [Grasshopper\.Kernel\.GH\_PreviewWireArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_previewwireargs 'Grasshopper\.Kernel\.GH\_PreviewWireArgs')

The Grasshopper preview wire arguments providing the drawing pipeline\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Planar.Interfaces.IGeometry2D,GH_PreviewWireArgs,System.Drawing.Color).color'></a>

`color` [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')

The color used for drawing\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,GH_PreviewWireArgs,System.Drawing.Color)'></a>

## Modify\.DrawViewportWires\(this IGeometry3D, GH\_PreviewWireArgs, Color\) Method

Draws the wire representation of a 3D geometry in the Rhino viewport\.

```csharp
public static void DrawViewportWires(this DiGi.Geometry.Spatial.Interfaces.IGeometry3D? geometry3D, GH_PreviewWireArgs? gH_PreviewWireArgs, System.Drawing.Color color);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,GH_PreviewWireArgs,System.Drawing.Color).geometry3D'></a>

`geometry3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')

The 3D geometry to draw\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,GH_PreviewWireArgs,System.Drawing.Color).gH_PreviewWireArgs'></a>

`gH_PreviewWireArgs` [Grasshopper\.Kernel\.GH\_PreviewWireArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_previewwireargs 'Grasshopper\.Kernel\.GH\_PreviewWireArgs')

The Grasshopper preview wire arguments providing the drawing pipeline\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,GH_PreviewWireArgs,System.Drawing.Color).color'></a>

`color` [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')

The color used for drawing\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D,GH_PreviewWireArgs,System.Drawing.Color)'></a>

## Modify\.DrawViewportWires\(this IIntersectionResult3D, GH\_PreviewWireArgs, Color\) Method

Draws the wire representations of geometries resulting from a 3D intersection in the Rhino viewport\.

```csharp
public static void DrawViewportWires(this DiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D? intersectionResult3D, GH_PreviewWireArgs? gH_PreviewWireArgs, System.Drawing.Color color);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D,GH_PreviewWireArgs,System.Drawing.Color).intersectionResult3D'></a>

`intersectionResult3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iintersectionresult3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D')

The result of a 3D intersection containing geometries to draw\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D,GH_PreviewWireArgs,System.Drawing.Color).gH_PreviewWireArgs'></a>

`gH_PreviewWireArgs` [Grasshopper\.Kernel\.GH\_PreviewWireArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_previewwireargs 'Grasshopper\.Kernel\.GH\_PreviewWireArgs')

The Grasshopper preview wire arguments providing the drawing pipeline\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires(thisDiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D,GH_PreviewWireArgs,System.Drawing.Color).color'></a>

`color` [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')

The color used for drawing\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,GH_PreviewWireArgs,System.Drawing.Color)'></a>

## Modify\.DrawViewportWires\<TGeometry\>\(this IEnumerable\<TGeometry\>, GH\_PreviewWireArgs, Color\) Method

Draws the wire representations of a collection of geometries in the Rhino viewport\.

```csharp
public static void DrawViewportWires<TGeometry>(this System.Collections.Generic.IEnumerable<TGeometry>? geometries, GH_PreviewWireArgs? gH_PreviewWireArgs, System.Drawing.Color color)
    where TGeometry : DiGi.Geometry.Core.Interfaces.IGeometry;
```
#### Type parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,GH_PreviewWireArgs,System.Drawing.Color).TGeometry'></a>

`TGeometry`

The type of geometry, which must implement IGeometry\.
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,GH_PreviewWireArgs,System.Drawing.Color).geometries'></a>

`geometries` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TGeometry](DiGi.Rhino.Geometry.Spatial.md#DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,GH_PreviewWireArgs,System.Drawing.Color).TGeometry 'DiGi\.Rhino\.Geometry\.Spatial\.Modify\.DrawViewportWires\<TGeometry\>\(this System\.Collections\.Generic\.IEnumerable\<TGeometry\>, GH\_PreviewWireArgs, System\.Drawing\.Color\)\.TGeometry')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of geometries to draw\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,GH_PreviewWireArgs,System.Drawing.Color).gH_PreviewWireArgs'></a>

`gH_PreviewWireArgs` [Grasshopper\.Kernel\.GH\_PreviewWireArgs](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_previewwireargs 'Grasshopper\.Kernel\.GH\_PreviewWireArgs')

The Grasshopper preview wire arguments providing the drawing pipeline\.

<a name='DiGi.Rhino.Geometry.Spatial.Modify.DrawViewportWires_TGeometry_(thisSystem.Collections.Generic.IEnumerable_TGeometry_,GH_PreviewWireArgs,System.Drawing.Color).color'></a>

`color` [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')

The color used for drawing\.

<a name='DiGi.Rhino.Geometry.Spatial.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Rhino.Geometry.Spatial.Query.TryGetPlane(BrepFace,DiGi.Geometry.Spatial.Classes.Plane,double)'></a>

## Query\.TryGetPlane\(BrepFace, Plane, double\) Method

Attempts to retrieve a [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') from a Rhino [Rhino\.Geometry\.BrepFace](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.brepface 'Rhino\.Geometry\.BrepFace')\.

```csharp
public static bool TryGetPlane(BrepFace? brepFace, out DiGi.Geometry.Spatial.Classes.Plane? plane, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Spatial.Query.TryGetPlane(BrepFace,DiGi.Geometry.Spatial.Classes.Plane,double).brepFace'></a>

`brepFace` [Rhino\.Geometry\.BrepFace](https://learn.microsoft.com/en-us/dotnet/api/rhino.geometry.brepface 'Rhino\.Geometry\.BrepFace')

The Brep face to analyze\.

<a name='DiGi.Rhino.Geometry.Spatial.Query.TryGetPlane(BrepFace,DiGi.Geometry.Spatial.Classes.Plane,double).plane'></a>

`plane` [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

When this method returns, contains the extracted plane if successful; otherwise, null\.

<a name='DiGi.Rhino.Geometry.Spatial.Query.TryGetPlane(BrepFace,DiGi.Geometry.Spatial.Classes.Plane,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used to determine if the face is planar\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a valid plane was successfully extracted from the face; otherwise, false\.
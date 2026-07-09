#### [DiGi\.Rhino\.Geometry](DiGi.Rhino.Geometry.Overview.md 'DiGi\.Rhino\.Geometry\.Overview')

## DiGi\.Rhino\.Geometry\.Planar Namespace
### Classes

<a name='DiGi.Rhino.Geometry.Planar.Inspect'></a>

## Inspect Class

```csharp
public static class Inspect
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Inspect
### Methods

<a name='DiGi.Rhino.Geometry.Planar.Inspect.A(thisDiGi.Geometry.Planar.Classes.Ellipse2D)'></a>

## Inspect\.A\(this Ellipse2D\) Method

Retrieves the semi\-major axis length \(A\) of the specified 2D ellipse\.

```csharp
public static GH_Number? A(this DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.A(thisDiGi.Geometry.Planar.Classes.Ellipse2D).ellipse2D'></a>

`ellipse2D` [DiGi\.Geometry\.Planar\.Classes\.Ellipse2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.ellipse2d 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The 2D ellipse to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the semi\-major axis length, or `null` if the ellipse is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Area(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D)'></a>

## Inspect\.Area\(this PolygonalFace2D\) Method

Gets the area of the specified polygonal face\.

```csharp
public static GH_Number? Area(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Area(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The polygonal face to evaluate\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the area, or `null` if the input is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Area(thisDiGi.Geometry.Planar.Classes.Rectangle2D)'></a>

## Inspect\.Area\(this Rectangle2D\) Method

Calculates the area of the specified rectangle as a GH\_Number\.

```csharp
public static GH_Number? Area(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Area(thisDiGi.Geometry.Planar.Classes.Rectangle2D).rectangle2D'></a>

`rectangle2D` [DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The rectangle to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the area, or null if the rectangle is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.B(thisDiGi.Geometry.Planar.Classes.Ellipse2D)'></a>

## Inspect\.B\(this Ellipse2D\) Method

Retrieves the semi\-minor axis length \(B\) of the specified 2D ellipse\.

```csharp
public static GH_Number? B(this DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.B(thisDiGi.Geometry.Planar.Classes.Ellipse2D).ellipse2D'></a>

`ellipse2D` [DiGi\.Geometry\.Planar\.Classes\.Ellipse2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.ellipse2d 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The 2D ellipse to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the semi\-minor axis length, or `null` if the ellipse is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.BottomLeft(thisDiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Inspect\.BottomLeft\(this BoundingBox2D\) Method

Gets the bottom\-left corner of the specified 2D bounding box\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D? BottomLeft(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.BottomLeft(thisDiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The 2D bounding box to inspect\.

#### Returns
[GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')  
A [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') representing the bottom\-left corner, or null if the bounding box is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.BottomRight(thisDiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Inspect\.BottomRight\(this BoundingBox2D\) Method

Gets the bottom\-right corner of the specified 2D bounding box\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D? BottomRight(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.BottomRight(thisDiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The 2D bounding box to inspect\.

#### Returns
[GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')  
A [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') representing the bottom\-right corner, or null if the bounding box is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.BoundinBox2D(thisDiGi.Geometry.Planar.Interfaces.IBoundable2D)'></a>

## Inspect\.BoundinBox2D\(this IBoundable2D\) Method

Calculates the 2D bounding box for the specified boundable 2D object\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D? BoundinBox2D(this DiGi.Geometry.Planar.Interfaces.IBoundable2D? boundable2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.BoundinBox2D(thisDiGi.Geometry.Planar.Interfaces.IBoundable2D).boundable2D'></a>

`boundable2D` [DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iboundable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D')

The 2D object that implements [DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iboundable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D')\.

#### Returns
[GooBoundingBox2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox2D')  
A [GooBoundingBox2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox2D') representing the bounding box, or `null` if the provided [boundable2D](DiGi.Rhino.Geometry.Planar.md#DiGi.Rhino.Geometry.Planar.Inspect.BoundinBox2D(thisDiGi.Geometry.Planar.Interfaces.IBoundable2D).boundable2D 'DiGi\.Rhino\.Geometry\.Planar\.Inspect\.BoundinBox2D\(this DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D\)\.boundable2D') is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.BoundingBox(thisDiGi.Geometry.Planar.Classes.Rectangle2D)'></a>

## Inspect\.BoundingBox\(this Rectangle2D\) Method

Gets the 2D bounding box of the specified rectangle\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D? BoundingBox(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.BoundingBox(thisDiGi.Geometry.Planar.Classes.Rectangle2D).rectangle2D'></a>

`rectangle2D` [DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The rectangle to inspect\.

#### Returns
[GooBoundingBox2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox2D')  
A [GooBoundingBox2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooBoundingBox2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooBoundingBox2D') representing the bounding box, or null if the rectangle is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Centroid(thisDiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Inspect\.Centroid\(this BoundingBox2D\) Method

Gets the centroid of the specified 2D bounding box\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D? Centroid(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Centroid(thisDiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The 2D bounding box to inspect\.

#### Returns
[GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')  
A [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') representing the centroid, or null if the bounding box is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Centroid(thisDiGi.Geometry.Planar.Classes.Ellipse2D)'></a>

## Inspect\.Centroid\(this Ellipse2D\) Method

Retrieves the centroid \(center point\) of the specified 2D ellipse\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D? Centroid(this DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Centroid(thisDiGi.Geometry.Planar.Classes.Ellipse2D).ellipse2D'></a>

`ellipse2D` [DiGi\.Geometry\.Planar\.Classes\.Ellipse2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.ellipse2d 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The 2D ellipse to inspect\.

#### Returns
[GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')  
A [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') representing the center point, or `null` if the ellipse is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Centroid(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D)'></a>

## Inspect\.Centroid\(this PolygonalFace2D\) Method

Gets the centroid of the specified polygonal face\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D? Centroid(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Centroid(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The polygonal face to evaluate\.

#### Returns
[GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')  
A [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') representing the centroid, or `null` if the input is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Centroid(thisDiGi.Geometry.Planar.Classes.Rectangle2D)'></a>

## Inspect\.Centroid\(this Rectangle2D\) Method

Gets the centroid point of the specified rectangle\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D? Centroid(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Centroid(thisDiGi.Geometry.Planar.Classes.Rectangle2D).rectangle2D'></a>

`rectangle2D` [DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The rectangle to inspect\.

#### Returns
[GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')  
A [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') representing the centroid, or null if the rectangle is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.ExternalEdge(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D)'></a>

## Inspect\.ExternalEdge\(this PolygonalFace2D\) Method

Gets the external edge of the specified polygonal face\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2D? ExternalEdge(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.ExternalEdge(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The polygonal face to evaluate\.

#### Returns
[GooPolygonal2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonal2D')  
A [GooPolygonal2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonal2D') representing the outer boundary, or `null` if the input is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.FocalPoints(thisDiGi.Geometry.Planar.Classes.Ellipse2D)'></a>

## Inspect\.FocalPoints\(this Ellipse2D\) Method

Retrieves the focal points of the specified 2D ellipse\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D>? FocalPoints(this DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.FocalPoints(thisDiGi.Geometry.Planar.Classes.Ellipse2D).ellipse2D'></a>

`ellipse2D` [DiGi\.Geometry\.Planar\.Classes\.Ellipse2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.ellipse2d 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The 2D ellipse to inspect\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') representing the focal points, or `null` if the ellipse is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Height(thisDiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Inspect\.Height\(this BoundingBox2D\) Method

Gets the height of the specified 2D bounding box\.

```csharp
public static GH_Number? Height(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Height(thisDiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The 2D bounding box to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the height, or null if the bounding box is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Height(thisDiGi.Geometry.Planar.Classes.Rectangle2D)'></a>

## Inspect\.Height\(this Rectangle2D\) Method

Gets the height of the specified rectangle as a GH\_Number\.

```csharp
public static GH_Number? Height(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Height(thisDiGi.Geometry.Planar.Classes.Rectangle2D).rectangle2D'></a>

`rectangle2D` [DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The rectangle to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the height, or null if the rectangle is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.HeightDirection(thisDiGi.Geometry.Planar.Classes.Rectangle2D)'></a>

## Inspect\.HeightDirection\(this Rectangle2D\) Method

Gets the vector representing the height direction of the specified rectangle\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooVector2D? HeightDirection(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.HeightDirection(thisDiGi.Geometry.Planar.Classes.Rectangle2D).rectangle2D'></a>

`rectangle2D` [DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The rectangle to inspect\.

#### Returns
[GooVector2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2D')  
A [GooVector2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2D') representing the height direction, or null if the rectangle is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.InternalEdges(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D)'></a>

## Inspect\.InternalEdges\(this PolygonalFace2D\) Method

Gets the internal edges of the specified polygonal face\.

```csharp
public static System.Collections.IEnumerable? InternalEdges(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.InternalEdges(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The polygonal face to evaluate\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An enumerable collection of [GooPolygonal2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPolygonal2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonal2D') representing internal boundaries, or `null` if the input is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.InternalPoint(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D)'></a>

## Inspect\.InternalPoint\(this PolygonalFace2D\) Method

Gets an internal point of the specified polygonal face\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D? InternalPoint(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.InternalPoint(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The polygonal face to evaluate\.

#### Returns
[GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')  
A [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') representing a point inside the face, or `null` if the input is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Inversed(thisDiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Inspect\.Inversed\(this Vector2D\) Method

Returns the inversed version of the provided 2D vector as a [GooVector2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2D')\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooVector2D? Inversed(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Inversed(thisDiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The 2D vector to invert\.

#### Returns
[GooVector2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2D')  
A [GooVector2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2D') containing the inverted vector, or `null` if the input vector is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Length(thisDiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Inspect\.Length\(this Vector2D\) Method

Returns the length of the provided 2D vector as a [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')\.

```csharp
public static GH_Number? Length(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Length(thisDiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The 2D vector whose length is to be calculated\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the length, or `null` if the input vector is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Length(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D)'></a>

## Inspect\.Length\(this ISegmentable2D\) Method

Gets the length of the specified 2D segmentable object as a [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')\.

```csharp
public static GH_Number? Length(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Length(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D).segmentable2D'></a>

`segmentable2D` [DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isegmentable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The 2D segmentable object to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the length, or `null` if the input is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Origin(thisDiGi.Geometry.Planar.Classes.Rectangle2D)'></a>

## Inspect\.Origin\(this Rectangle2D\) Method

Gets the origin point of the specified rectangle\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D? Origin(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Origin(thisDiGi.Geometry.Planar.Classes.Rectangle2D).rectangle2D'></a>

`rectangle2D` [DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The rectangle to inspect\.

#### Returns
[GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')  
A [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') representing the origin, or null if the rectangle is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Points(thisDiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Inspect\.Points\(this BoundingBox2D\) Method

Gets the corner points of the specified 2D bounding box\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D>? Points(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Points(thisDiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The 2D bounding box to inspect\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') representing the corners, or null if the bounding box is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Points(thisDiGi.Geometry.Planar.Classes.Rectangle2D)'></a>

## Inspect\.Points\(this Rectangle2D\) Method

Gets the corner points of the specified rectangle converted to GooPoint2D objects\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D>? Points(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Points(thisDiGi.Geometry.Planar.Classes.Rectangle2D).rectangle2D'></a>

`rectangle2D` [DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The rectangle to inspect\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
An enumerable collection of [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D'), or null if the rectangle is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Points(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D)'></a>

## Inspect\.Points\(this ISegmentable2D\) Method

Retrieves the points of the specified 2D segmentable object as a collection of [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D>? Points(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Points(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D).segmentable2D'></a>

`segmentable2D` [DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isegmentable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The 2D segmentable object to inspect\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
An enumerable collection of [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D'), or `null` if the input is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Rectangle2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D)'></a>

## Inspect\.Rectangle2D\(this ISegmentable2D\) Method

Gets the bounding rectangle of the specified 2D segmentable object as a [GooRectangle2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooRectangle2D')\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2D? Rectangle2D(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Rectangle2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D).segmentable2D'></a>

`segmentable2D` [DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isegmentable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The 2D segmentable object to inspect\.

#### Returns
[GooRectangle2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooRectangle2D')  
A [GooRectangle2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooRectangle2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooRectangle2D') representing the bounding rectangle, or `null` if the input is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Segments(thisDiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Inspect\.Segments\(this BoundingBox2D\) Method

Gets the boundary segments of the specified 2D bounding box\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D>? Segments(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Segments(thisDiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The 2D bounding box to inspect\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GooSegment2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooSegment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of [GooSegment2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooSegment2D') representing the edges, or null if the bounding box is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Segments(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D)'></a>

## Inspect\.Segments\(this ISegmentable2D\) Method

Retrieves the segments of the specified 2D segmentable object as a collection of [GooSegment2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooSegment2D')\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D>? Segments(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Segments(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D).segmentable2D'></a>

`segmentable2D` [DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isegmentable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The 2D segmentable object to inspect\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GooSegment2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooSegment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
An enumerable collection of [GooSegment2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooSegment2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooSegment2D'), or `null` if the input is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.TopLeft(thisDiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Inspect\.TopLeft\(this BoundingBox2D\) Method

Gets the top\-left corner of the specified 2D bounding box\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D? TopLeft(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.TopLeft(thisDiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The 2D bounding box to inspect\.

#### Returns
[GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')  
A [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') representing the top\-left corner, or null if the bounding box is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.TopRight(thisDiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Inspect\.TopRight\(this BoundingBox2D\) Method

Gets the top\-right corner of the specified 2D bounding box\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D? TopRight(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.TopRight(thisDiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The 2D bounding box to inspect\.

#### Returns
[GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')  
A [GooPoint2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') representing the top\-right corner, or null if the bounding box is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Unit(thisDiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Inspect\.Unit\(this Vector2D\) Method

Returns the unit \(normalized\) version of the provided 2D vector as a [GooVector2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2D')\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooVector2D? Unit(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Unit(thisDiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The 2D vector to normalize\.

#### Returns
[GooVector2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2D')  
A [GooVector2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2D') containing the unit vector, or `null` if the input vector is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Width(thisDiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Inspect\.Width\(this BoundingBox2D\) Method

Gets the width of the specified 2D bounding box\.

```csharp
public static GH_Number? Width(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Width(thisDiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The 2D bounding box to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the width, or null if the bounding box is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Width(thisDiGi.Geometry.Planar.Classes.Rectangle2D)'></a>

## Inspect\.Width\(this Rectangle2D\) Method

Gets the width of the specified rectangle as a GH\_Number\.

```csharp
public static GH_Number? Width(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Width(thisDiGi.Geometry.Planar.Classes.Rectangle2D).rectangle2D'></a>

`rectangle2D` [DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The rectangle to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the width, or null if the rectangle is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.WidthDirection(thisDiGi.Geometry.Planar.Classes.Rectangle2D)'></a>

## Inspect\.WidthDirection\(this Rectangle2D\) Method

Gets the vector representing the width direction of the specified rectangle\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooVector2D? WidthDirection(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.WidthDirection(thisDiGi.Geometry.Planar.Classes.Rectangle2D).rectangle2D'></a>

`rectangle2D` [DiGi\.Geometry\.Planar\.Classes\.Rectangle2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.rectangle2d 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The rectangle to inspect\.

#### Returns
[GooVector2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2D')  
A [GooVector2D](DiGi.Rhino.Geometry.Planar.Classes.md#DiGi.Rhino.Geometry.Planar.Classes.GooVector2D 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooVector2D') representing the width direction, or null if the rectangle is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.X(thisDiGi.Geometry.Planar.Classes.Point2D)'></a>

## Inspect\.X\(this Point2D\) Method

Extracts the X coordinate of a 2D point as a Grasshopper number\.

```csharp
public static GH_Number? X(this DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.X(thisDiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The 2D point to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the X coordinate, or `null` if the input point is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.X(thisDiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Inspect\.X\(this Vector2D\) Method

Returns the X coordinate of the provided 2D vector as a [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')\.

```csharp
public static GH_Number? X(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.X(thisDiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The 2D vector whose X coordinate is to be retrieved\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the X coordinate, or `null` if the input vector is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Y(thisDiGi.Geometry.Planar.Classes.Point2D)'></a>

## Inspect\.Y\(this Point2D\) Method

Extracts the Y coordinate of a 2D point as a Grasshopper number\.

```csharp
public static GH_Number? Y(this DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Y(thisDiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The 2D point to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the Y coordinate, or `null` if the input point is null\.

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Y(thisDiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Inspect\.Y\(this Vector2D\) Method

Returns the Y coordinate of the provided 2D vector as a [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')\.

```csharp
public static GH_Number? Y(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Planar.Inspect.Y(thisDiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The 2D vector whose Y coordinate is to be retrieved\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the Y coordinate, or `null` if the input vector is null\.
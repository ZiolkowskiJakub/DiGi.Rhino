#### [DiGi\.Rhino\.Geometry](DiGi.Rhino.Geometry.Overview.md 'DiGi\.Rhino\.Geometry\.Overview')

## DiGi\.Rhino\.Geometry\.Random\.Classes Namespace
### Classes

<a name='DiGi.Rhino.Geometry.Random.Classes.Point2DByRange'></a>

## Point2DByRange Class

A Grasshopper component that generates a random 2D point within specified X and Y range intervals\.

```csharp
public class Point2DByRange : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Point2DByRange
### Constructors

<a name='DiGi.Rhino.Geometry.Random.Classes.Point2DByRange.Point2DByRange()'></a>

## Point2DByRange\(\) Constructor

Initializes a new instance of object\.

```csharp
public Point2DByRange();
```
### Properties

<a name='DiGi.Rhino.Geometry.Random.Classes.Point2DByRange.ComponentGuid'></a>

## Point2DByRange\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Random.Classes.Point2DByRange.Exposure'></a>

## Point2DByRange\.Exposure Property

Gets the exposure level of the component, which determines its visual priority in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Random.Classes.Point2DByRange.Inputs'></a>

## Point2DByRange\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Random.Classes.Point2DByRange.Outputs'></a>

## Point2DByRange\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Random.Classes.Point2DByRange.SolveInstance(IGH_DataAccess)'></a>

## Point2DByRange\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Random.Classes.Point2DByRange.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Geometry.Random.Classes.Polygon2DByRange'></a>

## Polygon2DByRange Class

A Grasshopper component that generates a random 2D polygon based on specified X and Y range intervals\.

```csharp
public class Polygon2DByRange : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Polygon2DByRange
### Constructors

<a name='DiGi.Rhino.Geometry.Random.Classes.Polygon2DByRange.Polygon2DByRange()'></a>

## Polygon2DByRange\(\) Constructor

Initializes a new instance of object\.

```csharp
public Polygon2DByRange();
```
### Properties

<a name='DiGi.Rhino.Geometry.Random.Classes.Polygon2DByRange.ComponentGuid'></a>

## Polygon2DByRange\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Random.Classes.Polygon2DByRange.Exposure'></a>

## Polygon2DByRange\.Exposure Property

Gets the exposure level of the component, determining how it is displayed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Random.Classes.Polygon2DByRange.Inputs'></a>

## Polygon2DByRange\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Random.Classes.Polygon2DByRange.Outputs'></a>

## Polygon2DByRange\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Random.Classes.Polygon2DByRange.SolveInstance(IGH_DataAccess)'></a>

## Polygon2DByRange\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Random.Classes.Polygon2DByRange.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Geometry.Random.Classes.PolygonalFace2DByRange'></a>

## PolygonalFace2DByRange Class

A Grasshopper component that generates a random 2D polygonal face based on specified coordinate ranges,
point counts, and internal edge counts\.

```csharp
public class PolygonalFace2DByRange : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → PolygonalFace2DByRange
### Constructors

<a name='DiGi.Rhino.Geometry.Random.Classes.PolygonalFace2DByRange.PolygonalFace2DByRange()'></a>

## PolygonalFace2DByRange\(\) Constructor

Initializes a new instance of object\.

```csharp
public PolygonalFace2DByRange();
```
### Properties

<a name='DiGi.Rhino.Geometry.Random.Classes.PolygonalFace2DByRange.ComponentGuid'></a>

## PolygonalFace2DByRange\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Random.Classes.PolygonalFace2DByRange.Exposure'></a>

## PolygonalFace2DByRange\.Exposure Property

Gets or sets the exposure level of the component in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Random.Classes.PolygonalFace2DByRange.Inputs'></a>

## PolygonalFace2DByRange\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Random.Classes.PolygonalFace2DByRange.Outputs'></a>

## PolygonalFace2DByRange\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Random.Classes.PolygonalFace2DByRange.SolveInstance(IGH_DataAccess)'></a>

## PolygonalFace2DByRange\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Random.Classes.PolygonalFace2DByRange.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Rhino.Geometry.Random.Classes.Segment2DByRange'></a>

## Segment2DByRange Class

A Grasshopper component that generates a random 2D line segment based on specified X and Y coordinate ranges\.

```csharp
public class Segment2DByRange : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Segment2DByRange
### Constructors

<a name='DiGi.Rhino.Geometry.Random.Classes.Segment2DByRange.Segment2DByRange()'></a>

## Segment2DByRange\(\) Constructor

Initializes a new instance of the [Segment2DByRange](DiGi.Rhino.Geometry.Random.Classes.md#DiGi.Rhino.Geometry.Random.Classes.Segment2DByRange 'DiGi\.Rhino\.Geometry\.Random\.Classes\.Segment2DByRange') class\.

```csharp
public Segment2DByRange();
```
### Properties

<a name='DiGi.Rhino.Geometry.Random.Classes.Segment2DByRange.ComponentGuid'></a>

## Segment2DByRange\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Rhino.Geometry.Random.Classes.Segment2DByRange.Exposure'></a>

## Segment2DByRange\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Rhino.Geometry.Random.Classes.Segment2DByRange.Inputs'></a>

## Segment2DByRange\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Rhino.Geometry.Random.Classes.Segment2DByRange.Outputs'></a>

## Segment2DByRange\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Rhino.Geometry.Random.Classes.Segment2DByRange.SolveInstance(IGH_DataAccess)'></a>

## Segment2DByRange\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Rhino.Geometry.Random.Classes.Segment2DByRange.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.
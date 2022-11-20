[![Build](https://github.com/ladybug-tools/ladybug-display-core-dotnet/workflows/CD/badge.svg)](https://github.com/ladybug-tools/ladybug-display-core-dotnet/actions) [![NuGet Version and Downloads count](https://buildstats.info/nuget/LadybugDisplaySchema?dWidth=50)](https://www.nuget.org/packages/LadybugDisplaySchema)

# LadybugDisplaySchema - the C# library for the Ladybug Visualization Schema

Documentation for Ladybug visualization schema

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.7.3
- SDK version: 0.7.3
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://github.com/ladybug-tools/ladybug-display-core](https://github.com/ladybug-tools/ladybug-display-core)

## Frameworks supported


- .NET Core >=1.0
- .NET Framework >=4.5

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using LadybugDisplaySchema.Api;
using LadybugDisplaySchema.Client;
using LadybugDisplaySchema.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out LadybugDisplaySchema.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LadybugDisplaySchema.Api;
using LadybugDisplaySchema.Client;
using LadybugDisplaySchema.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------


## Documentation for Models

 - [Model.AnalysisGeometry](docs/AnalysisGeometry.md)
 - [Model.AnalysisGeometryAllOf](docs/AnalysisGeometryAllOf.md)
 - [Model.Arc2D](docs/Arc2D.md)
 - [Model.Arc2DAllOf](docs/Arc2DAllOf.md)
 - [Model.Arc3D](docs/Arc3D.md)
 - [Model.Arc3DAllOf](docs/Arc3DAllOf.md)
 - [Model.Color](docs/Color.md)
 - [Model.ColorAllOf](docs/ColorAllOf.md)
 - [Model.Cone](docs/Cone.md)
 - [Model.ConeAllOf](docs/ConeAllOf.md)
 - [Model.ContextGeometry](docs/ContextGeometry.md)
 - [Model.ContextGeometryAllOf](docs/ContextGeometryAllOf.md)
 - [Model.Cylinder](docs/Cylinder.md)
 - [Model.CylinderAllOf](docs/CylinderAllOf.md)
 - [Model.DataType](docs/DataType.md)
 - [Model.DataTypeAllOf](docs/DataTypeAllOf.md)
 - [Model.DataTypes](docs/DataTypes.md)
 - [Model.Default](docs/Default.md)
 - [Model.DefaultAllOf](docs/DefaultAllOf.md)
 - [Model.DisplayArc2D](docs/DisplayArc2D.md)
 - [Model.DisplayArc2DAllOf](docs/DisplayArc2DAllOf.md)
 - [Model.DisplayArc3D](docs/DisplayArc3D.md)
 - [Model.DisplayArc3DAllOf](docs/DisplayArc3DAllOf.md)
 - [Model.DisplayBaseModel](docs/DisplayBaseModel.md)
 - [Model.DisplayBaseModelAllOf](docs/DisplayBaseModelAllOf.md)
 - [Model.DisplayCone](docs/DisplayCone.md)
 - [Model.DisplayConeAllOf](docs/DisplayConeAllOf.md)
 - [Model.DisplayCylinder](docs/DisplayCylinder.md)
 - [Model.DisplayCylinderAllOf](docs/DisplayCylinderAllOf.md)
 - [Model.DisplayFace3D](docs/DisplayFace3D.md)
 - [Model.DisplayFace3DAllOf](docs/DisplayFace3DAllOf.md)
 - [Model.DisplayLineSegment2D](docs/DisplayLineSegment2D.md)
 - [Model.DisplayLineSegment2DAllOf](docs/DisplayLineSegment2DAllOf.md)
 - [Model.DisplayLineSegment3D](docs/DisplayLineSegment3D.md)
 - [Model.DisplayLineSegment3DAllOf](docs/DisplayLineSegment3DAllOf.md)
 - [Model.DisplayMesh2D](docs/DisplayMesh2D.md)
 - [Model.DisplayMesh2DAllOf](docs/DisplayMesh2DAllOf.md)
 - [Model.DisplayMesh3D](docs/DisplayMesh3D.md)
 - [Model.DisplayMesh3DAllOf](docs/DisplayMesh3DAllOf.md)
 - [Model.DisplayModes](docs/DisplayModes.md)
 - [Model.DisplayPlane](docs/DisplayPlane.md)
 - [Model.DisplayPlaneAllOf](docs/DisplayPlaneAllOf.md)
 - [Model.DisplayPoint2D](docs/DisplayPoint2D.md)
 - [Model.DisplayPoint2DAllOf](docs/DisplayPoint2DAllOf.md)
 - [Model.DisplayPoint3D](docs/DisplayPoint3D.md)
 - [Model.DisplayPoint3DAllOf](docs/DisplayPoint3DAllOf.md)
 - [Model.DisplayPolyface3D](docs/DisplayPolyface3D.md)
 - [Model.DisplayPolyface3DAllOf](docs/DisplayPolyface3DAllOf.md)
 - [Model.DisplayPolygon2D](docs/DisplayPolygon2D.md)
 - [Model.DisplayPolygon2DAllOf](docs/DisplayPolygon2DAllOf.md)
 - [Model.DisplayPolyline2D](docs/DisplayPolyline2D.md)
 - [Model.DisplayPolyline2DAllOf](docs/DisplayPolyline2DAllOf.md)
 - [Model.DisplayPolyline3D](docs/DisplayPolyline3D.md)
 - [Model.DisplayPolyline3DAllOf](docs/DisplayPolyline3DAllOf.md)
 - [Model.DisplayRay2D](docs/DisplayRay2D.md)
 - [Model.DisplayRay2DAllOf](docs/DisplayRay2DAllOf.md)
 - [Model.DisplayRay3D](docs/DisplayRay3D.md)
 - [Model.DisplayRay3DAllOf](docs/DisplayRay3DAllOf.md)
 - [Model.DisplaySphere](docs/DisplaySphere.md)
 - [Model.DisplaySphereAllOf](docs/DisplaySphereAllOf.md)
 - [Model.DisplayText3D](docs/DisplayText3D.md)
 - [Model.DisplayText3DAllOf](docs/DisplayText3DAllOf.md)
 - [Model.DisplayVector2D](docs/DisplayVector2D.md)
 - [Model.DisplayVector2DAllOf](docs/DisplayVector2DAllOf.md)
 - [Model.DisplayVector3D](docs/DisplayVector3D.md)
 - [Model.DisplayVector3DAllOf](docs/DisplayVector3DAllOf.md)
 - [Model.Face3D](docs/Face3D.md)
 - [Model.Face3DAllOf](docs/Face3DAllOf.md)
 - [Model.GenericDataType](docs/GenericDataType.md)
 - [Model.GenericDataTypeAllOf](docs/GenericDataTypeAllOf.md)
 - [Model.HorizontalAlignments](docs/HorizontalAlignments.md)
 - [Model.Legend2DParameters](docs/Legend2DParameters.md)
 - [Model.Legend2DParametersAllOf](docs/Legend2DParametersAllOf.md)
 - [Model.Legend3DParameters](docs/Legend3DParameters.md)
 - [Model.Legend3DParametersAllOf](docs/Legend3DParametersAllOf.md)
 - [Model.LegendParameters](docs/LegendParameters.md)
 - [Model.LegendParametersAllOf](docs/LegendParametersAllOf.md)
 - [Model.LineCurveBase](docs/LineCurveBase.md)
 - [Model.LineCurveBaseAllOf](docs/LineCurveBaseAllOf.md)
 - [Model.LineSegment2D](docs/LineSegment2D.md)
 - [Model.LineSegment2DAllOf](docs/LineSegment2DAllOf.md)
 - [Model.LineSegment3D](docs/LineSegment3D.md)
 - [Model.LineSegment3DAllOf](docs/LineSegment3DAllOf.md)
 - [Model.LineTypes](docs/LineTypes.md)
 - [Model.Mesh2D](docs/Mesh2D.md)
 - [Model.Mesh2DAllOf](docs/Mesh2DAllOf.md)
 - [Model.Mesh3D](docs/Mesh3D.md)
 - [Model.Mesh3DAllOf](docs/Mesh3DAllOf.md)
 - [Model.OpenAPIGenBaseModel](docs/OpenAPIGenBaseModel.md)
 - [Model.Plane](docs/Plane.md)
 - [Model.PlaneAllOf](docs/PlaneAllOf.md)
 - [Model.Point2D](docs/Point2D.md)
 - [Model.Point2DAllOf](docs/Point2DAllOf.md)
 - [Model.Point3D](docs/Point3D.md)
 - [Model.Point3DAllOf](docs/Point3DAllOf.md)
 - [Model.Polyface3D](docs/Polyface3D.md)
 - [Model.Polyface3DAllOf](docs/Polyface3DAllOf.md)
 - [Model.PolyfaceEdgeInfo](docs/PolyfaceEdgeInfo.md)
 - [Model.PolyfaceEdgeInfoAllOf](docs/PolyfaceEdgeInfoAllOf.md)
 - [Model.Polygon2D](docs/Polygon2D.md)
 - [Model.Polygon2DAllOf](docs/Polygon2DAllOf.md)
 - [Model.Polyline2D](docs/Polyline2D.md)
 - [Model.Polyline2DAllOf](docs/Polyline2DAllOf.md)
 - [Model.Polyline3D](docs/Polyline3D.md)
 - [Model.Polyline3DAllOf](docs/Polyline3DAllOf.md)
 - [Model.Ray2D](docs/Ray2D.md)
 - [Model.Ray2DAllOf](docs/Ray2DAllOf.md)
 - [Model.Ray3D](docs/Ray3D.md)
 - [Model.Ray3DAllOf](docs/Ray3DAllOf.md)
 - [Model.SingleColorBase](docs/SingleColorBase.md)
 - [Model.SingleColorBaseAllOf](docs/SingleColorBaseAllOf.md)
 - [Model.Sphere](docs/Sphere.md)
 - [Model.SphereAllOf](docs/SphereAllOf.md)
 - [Model.Vector2D](docs/Vector2D.md)
 - [Model.Vector2DAllOf](docs/Vector2DAllOf.md)
 - [Model.Vector3D](docs/Vector3D.md)
 - [Model.Vector3DAllOf](docs/Vector3DAllOf.md)
 - [Model.VerticalAlignments](docs/VerticalAlignments.md)
 - [Model.VisualizationBase](docs/VisualizationBase.md)
 - [Model.VisualizationBaseAllOf](docs/VisualizationBaseAllOf.md)
 - [Model.VisualizationData](docs/VisualizationData.md)
 - [Model.VisualizationDataAllOf](docs/VisualizationDataAllOf.md)
 - [Model.VisualizationSet](docs/VisualizationSet.md)
 - [Model.VisualizationSetAllOf](docs/VisualizationSetAllOf.md)


## Documentation for Authorization

All endpoints do not require authorization.

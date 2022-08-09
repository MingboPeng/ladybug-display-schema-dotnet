
# LadybugDisplaySchema.Model.DisplayPolygon2D

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserData** | **Object** | Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). | [optional] 
**Color** | [**Color**](Color.md) | Color for the geometry. | 
**Geometry** | [**Polygon2D**](Polygon2D.md) | Polygon2D for the geometry. | 
**Type** | **string** |  | [optional] [readonly] [default to "DisplayPolygon2D"]
**DisplayMode** | **DisplayModes** | Text to indicate the display mode (shaded, wireframe, etc.). The DisplayModes enumeration contains all acceptable types. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

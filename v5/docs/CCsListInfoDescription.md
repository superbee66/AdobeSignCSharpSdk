# IO.Swagger.Model.CCsListInfoDescription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MinListCount** | [**ModelInt**](ModelInt.md) | minimum number of entries allowed in the current CC list | [optional] 
**Visible** | **bool?** | Whether current field is visible or not. If visible attribute for this field is false then this field should not be shown in the agreement creation page using this workflow | [optional] 
**DefaultValue** | **string** | A default  email that will be used if no input is provided for this list element | [optional] 
**Editable** | **bool?** | Whether current field can be edited. If editable attribute for this field is false then this field should not be provided in the agreement creation request and default value of this field will be used in agreement creation | [optional] 
**Name** | **string** | Name of the current CC list | [optional] 
**MaxListCount** | [**ModelInt**](ModelInt.md) | maximum number of entries allowed in the current CC list | [optional] 
**Label** | **string** | A display text for the workflow user that can be used for the current CC list | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


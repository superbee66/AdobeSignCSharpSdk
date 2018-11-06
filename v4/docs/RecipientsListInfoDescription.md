# IO.Swagger.Model.RecipientsListInfoDescription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowSender** | **bool?** | whether sender is allowed as a recipient | [optional] 
**MinListCount** | [**ModelInt**](ModelInt.md) | minimum number of entries allowed in the current recipient list | [optional] 
**Visible** | **bool?** | Whether current field is visible. If visible attribute for this field is false then this field should not be shown in the agreement creation UI using this workflow to user | [optional] 
**AuthenticationMethod** | **string** | authentication method for the current recipient list to have access to view and sign the document | [optional] 
**Allowfax** | **bool?** | whether fax is allowed or not | [optional] 
**DefaultValue** | **string** | A default  email or fax number | [optional] 
**Editable** | **bool?** | Whether current field can be edited. If editable attribute for this field is false then this field should not be provided in the agreement creation request and default value of this field will be used in agreement creation | [optional] 
**Name** | **string** | Name of the current RecipientInfo list | [optional] 
**MaxListCount** | [**ModelInt**](ModelInt.md) | maximum number of entries allowed in the current recipient list | [optional] 
**Label** | **string** | A display text for the workflow user that can be used for the current recipients list | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


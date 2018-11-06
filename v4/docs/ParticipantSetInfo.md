# IO.Swagger.Model.ParticipantSetInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SigningOrder** | **int?** | Index indicating sequential signing group (specified for hybrid routing) | [optional] 
**ParticipantSetMemberInfos** | [**List&lt;ParticipantInfo&gt;**](ParticipantInfo.md) | Information about the members of the recipient set | [optional] 
**ParticipantSetName** | **string** | The name of the participant set. Returned only, if the API caller is the sender of agreement | [optional] 
**Roles** | **List&lt;string&gt;** | The current roles of the participant set. A participant set can have one or more roles | [optional] 
**PrivateMessage** | **string** | Private message for the participants in the set | [optional] 
**SecurityOptions** | **List&lt;string&gt;** | Security options that apply to the participant | [optional] 
**Status** | **string** | The status of the participant set with respect to the document | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


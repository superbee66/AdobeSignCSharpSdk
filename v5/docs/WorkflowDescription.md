# IO.Swagger.Model.WorkflowDescription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | Identifier of scope. Currently it is applicable for scope GROUP only and the value will be groupId. | [optional] 
**MessageInfo** | [**WorkflowDefaultParams**](WorkflowDefaultParams.md) | Information about message field in DocumentCreationInfo input field in the agreement creation request when using the API which creates an agreement in a workflow | [optional] 
**Created** | **DateTime?** | The day on which the workflow was created | [optional] 
**DisplayName** | **string** | The display name of the workflow. | [optional] 
**Description** | **string** | Description provided for this workflow at the time of its creation | [optional] 
**MergeFieldsInfo** | [**List&lt;MergeFieldInfoDescription&gt;**](MergeFieldInfoDescription.md) | Information about customFieldInfos in DocumentCreationInfo input field in the agreement creation request when using the API which creates an agreement in a workflow | [optional] 
**AgreementNameInfo** | [**WorkflowDefaultParams**](WorkflowDefaultParams.md) | Information about name field in DocumentCreationInfo input field in the agreement creation request when using the API which creates an agreement in a workflow | [optional] 
**PasswordInfo** | [**PasswordFieldInfoDescription**](PasswordFieldInfoDescription.md) | Information about openPassword field in SecurityOptions input field in the agreement creation request when using the API which creates an agreement in a workflow | [optional] 
**AuthoringInfo** | [**WorkflowDefaultParams**](WorkflowDefaultParams.md) | Information about authoringRequested field in SendDocumentInteractiveOptions input field in the agreement creation request when using the API which creates an agreement in a workflow | [optional] 
**RecipientsListInfo** | [**List&lt;RecipientsListInfoDescription&gt;**](RecipientsListInfoDescription.md) | Information about RecepientsInfo input field in the agreement creation request when using the API which creates an agreement in a workflow | [optional] 
**Scope** | **string** | The workflow scope (ACCOUNT or GROUP or OTHER) | [optional] 
**ExpirationInfo** | [**ExpirationFieldInfoDescription**](ExpirationFieldInfoDescription.md) | Information about daysUntilSigningDeadline field in DocumentCreationInfo input field in the agreement creation request when using the API which creates an agreement in a workflow | [optional] 
**Name** | **string** | The name of the workflow. | [optional] 
**Modified** | **DateTime?** | The day on which the workflow was last modified | [optional] 
**FileInfos** | [**List&lt;FileInfosDescription&gt;**](FileInfosDescription.md) | Information about FileInfo input field in the agreement creation request when using the API which creates an agreement in a workflow | [optional] 
**LocaleInfo** | [**LocaleFieldInfoDescription**](LocaleFieldInfoDescription.md) | Information about locale  field in DocumentCreationInfo input field in the agreement creation request when using the API which creates an agreement in a workflow | [optional] 
**CcsListInfo** | [**List&lt;CCsListInfoDescription&gt;**](CCsListInfoDescription.md) | Information about CCList input field in the agreement creation request when using the API which creates an agreement in a workflow | [optional] 
**Status** | **string** | The workflow status (ACTIVE or DRAFT or INACTIVE or OTHER) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


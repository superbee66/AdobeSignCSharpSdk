# IO.Swagger.Model.RequestFormField
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BorderColor** | **string** | Color of the border of the field in RGB or HEX format | [optional] 
**FormatData** | **string** | The format of data in text field | [optional] 
**Hidden** | **bool?** | true if the field is hidden, else false | [optional] 
**MaskingText** | **string** | Text to mask the masked form field | [optional] 
**RegularExpression** | **string** | Regular expression validation of the form field | [optional] 
**DefaultValue** | **string** | Default value of the form field | [optional] 
**Masked** | **bool?** | true if the input entered by the signer has to be masked (like password), false if it shouldn&#39;t be | [optional] 
**SpecialErrMsg** | **string** | Error message to be shown to the signer if filled value doesn&#39;t match the validations of the form field | [optional] 
**MinLength** | **int?** | Minimum length of the input text field in terms of no. of characters | [optional] 
**CalculatedExpression** | **string** | Expression to calculate value of the form field | [optional] 
**Tooltip** | **string** | Text that appears while hovering over the field | [optional] 
**HiddenOptions** | **List&lt;string&gt;** | Text values which are hidden in a drop down form field | [optional] 
**SpecialFormula** | **string** | Formula used to calculate the value of the form field | [optional] 
**Required** | **bool?** | true if it is a mandatory field to be filled by the signer, else false | [optional] 
**MaxNumberValue** | **double?** | Upper bound of the number that can be entered by the signer | [optional] 
**BorderWidth** | **float?** | Width of the border of the field in pixels | [optional] 
**DisplayLabel** | **string** | Display label attached to the field | [optional] 
**BackgroundColor** | **string** | Background color of the form field in RGB or HEX format | [optional] 
**MinNumberValue** | **double?** | Lower bound of the number that can be entered by the signer | [optional] 
**DisplayFormat** | **string** | Format of the value of the field to be displayed based on the displayFormatType property. | [optional] 
**VisibleOptions** | **List&lt;string&gt;** | Text values which are visible in a drop down form field | [optional] 
**_ReadOnly** | **bool?** | true if it is a read-only field, else false | [optional] 
**RecipientIndex** | **int?** | Index of recipient, starting from 1, in recipients list passed in the request | [optional] 
**FontName** | **string** | Font name of the form field | [optional] 
**Name** | **string** | The name of the form field | [optional] 
**FontSize** | **float?** | Font size of the form field in points | [optional] 
**Locations** | [**List&lt;FormFieldLocation&gt;**](FormFieldLocation.md) | All locations in a document where the form field is placed | [optional] 
**Conditions** | [**List&lt;FormFieldCondition&gt;**](FormFieldCondition.md) | Conditions to be evaluated which decides the visibility of the form field in association with showOrHide property | [optional] 
**FontColor** | **string** | Font color of the form field in RGB or HEX format | [optional] 
**MaxLength** | **int?** | Maximum length of the input text field in terms of no. of characters | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


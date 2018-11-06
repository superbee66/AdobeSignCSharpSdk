using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class RequestFormField
    {
        /// <summary>
        ///     true if it is a read-only field, else false
        /// </summary>
        /// <value>true if it is a read-only field, else false</value>
        [DataMember(Name = "readOnly", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "readOnly")]
        public bool? _ReadOnly { get; set; }

        /// <summary>
        ///     Alignment of the text.
        /// </summary>
        /// <value>Alignment of the text.</value>
        [DataMember(Name = "alignment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "alignment")]
        public string Alignment { get; set; }

        /// <summary>
        ///     It indicates if any one of the conditions or all of them have to be true.
        /// </summary>
        /// <value>It indicates if any one of the conditions or all of them have to be true.</value>
        [DataMember(Name = "anyOrAll", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "anyOrAll")]
        public string AnyOrAll { get; set; }

        /// <summary>
        ///     Background color of the form field in RGB or HEX format
        /// </summary>
        /// <value>Background color of the form field in RGB or HEX format</value>
        [DataMember(Name = "backgroundColor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "backgroundColor")]
        public string BackgroundColor { get; set; }

        /// <summary>
        ///     Color of the border of the field in RGB or HEX format
        /// </summary>
        /// <value>Color of the border of the field in RGB or HEX format</value>
        [DataMember(Name = "borderColor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "borderColor")]
        public string BorderColor { get; set; }

        /// <summary>
        ///     Style of the border of the field.
        /// </summary>
        /// <value>Style of the border of the field.</value>
        [DataMember(Name = "borderStyle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "borderStyle")]
        public string BorderStyle { get; set; }

        /// <summary>
        ///     Width of the border of the field in pixels
        /// </summary>
        /// <value>Width of the border of the field in pixels</value>
        [DataMember(Name = "borderWidth", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "borderWidth")]
        public float? BorderWidth { get; set; }

        /// <summary>
        ///     Expression to calculate value of the form field
        /// </summary>
        /// <value>Expression to calculate value of the form field</value>
        [DataMember(Name = "calculatedExpression", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "calculatedExpression")]
        public string CalculatedExpression { get; set; }

        /// <summary>
        ///     Conditions to be evaluated which decides the visibility of the form field in association with showOrHide property
        /// </summary>
        /// <value>
        ///     Conditions to be evaluated which decides the visibility of the form field in association with showOrHide
        ///     property
        /// </value>
        [DataMember(Name = "conditions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conditions")]
        public List<FormFieldCondition> Conditions { get; set; }

        /// <summary>
        ///     Content Type of the form field.
        /// </summary>
        /// <value>Content Type of the form field.</value>
        [DataMember(Name = "contentType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }

        /// <summary>
        ///     Default value of the form field
        /// </summary>
        /// <value>Default value of the form field</value>
        [DataMember(Name = "defaultValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }

        /// <summary>
        ///     Format of the value of the field to be displayed based on the displayFormatType property.
        /// </summary>
        /// <value>Format of the value of the field to be displayed based on the displayFormatType property.</value>
        [DataMember(Name = "displayFormat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayFormat")]
        public string DisplayFormat { get; set; }

        /// <summary>
        ///     Format type of the text field.
        /// </summary>
        /// <value>Format type of the text field.</value>
        [DataMember(Name = "displayFormatType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayFormatType")]
        public string DisplayFormatType { get; set; }

        /// <summary>
        ///     Display label attached to the field
        /// </summary>
        /// <value>Display label attached to the field</value>
        [DataMember(Name = "displayLabel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayLabel")]
        public string DisplayLabel { get; set; }

        /// <summary>
        ///     Font color of the form field in RGB or HEX format
        /// </summary>
        /// <value>Font color of the form field in RGB or HEX format</value>
        [DataMember(Name = "fontColor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fontColor")]
        public string FontColor { get; set; }

        /// <summary>
        ///     Font name of the form field
        /// </summary>
        /// <value>Font name of the form field</value>
        [DataMember(Name = "fontName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fontName")]
        public string FontName { get; set; }

        /// <summary>
        ///     Font size of the form field in points
        /// </summary>
        /// <value>Font size of the form field in points</value>
        [DataMember(Name = "fontSize", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fontSize")]
        public float? FontSize { get; set; }

        /// <summary>
        ///     Format of the form field
        /// </summary>
        /// <value>Format of the form field</value>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        ///     The format of data in text field
        /// </summary>
        /// <value>The format of data in text field</value>
        [DataMember(Name = "formatData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "formatData")]
        public string FormatData { get; set; }

        /// <summary>
        ///     true if the field is hidden, else false
        /// </summary>
        /// <value>true if the field is hidden, else false</value>
        [DataMember(Name = "hidden", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        ///     Text values which are hidden in a drop down form field
        /// </summary>
        /// <value>Text values which are hidden in a drop down form field</value>
        [DataMember(Name = "hiddenOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hiddenOptions")]
        public List<string> HiddenOptions { get; set; }

        /// <summary>
        ///     Input type of the form field
        /// </summary>
        /// <value>Input type of the form field</value>
        [DataMember(Name = "inputType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inputType")]
        public string InputType { get; set; }

        /// <summary>
        ///     All locations in a document where the form field is placed
        /// </summary>
        /// <value>All locations in a document where the form field is placed</value>
        [DataMember(Name = "locations", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "locations")]
        public List<FormFieldLocation> Locations { get; set; }

        /// <summary>
        ///     true if the input entered by the signer has to be masked (like password), false if it shouldn't be
        /// </summary>
        /// <value>true if the input entered by the signer has to be masked (like password), false if it shouldn't be</value>
        [DataMember(Name = "masked", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "masked")]
        public bool? Masked { get; set; }

        /// <summary>
        ///     Text to mask the masked form field
        /// </summary>
        /// <value>Text to mask the masked form field</value>
        [DataMember(Name = "maskingText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "maskingText")]
        public string MaskingText { get; set; }

        /// <summary>
        ///     Maximum length of the input text field in terms of no. of characters
        /// </summary>
        /// <value>Maximum length of the input text field in terms of no. of characters</value>
        [DataMember(Name = "maxLength", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "maxLength")]
        public int? MaxLength { get; set; }

        /// <summary>
        ///     Upper bound of the number that can be entered by the signer
        /// </summary>
        /// <value>Upper bound of the number that can be entered by the signer</value>
        [DataMember(Name = "maxNumberValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "maxNumberValue")]
        public double? MaxNumberValue { get; set; }

        /// <summary>
        ///     Minimum length of the input text field in terms of no. of characters
        /// </summary>
        /// <value>Minimum length of the input text field in terms of no. of characters</value>
        [DataMember(Name = "minLength", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minLength")]
        public int? MinLength { get; set; }

        /// <summary>
        ///     Lower bound of the number that can be entered by the signer
        /// </summary>
        /// <value>Lower bound of the number that can be entered by the signer</value>
        [DataMember(Name = "minNumberValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minNumberValue")]
        public double? MinNumberValue { get; set; }

        /// <summary>
        ///     The name of the form field
        /// </summary>
        /// <value>The name of the form field</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     The type of radio button (if field is radio button, identified by inputType).
        /// </summary>
        /// <value>The type of radio button (if field is radio button, identified by inputType).</value>
        [DataMember(Name = "radioCheckType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "radioCheckType")]
        public string RadioCheckType { get; set; }

        /// <summary>
        ///     Index of recipient, starting from 1, in recipients list passed in the request
        /// </summary>
        /// <value>Index of recipient, starting from 1, in recipients list passed in the request</value>
        [DataMember(Name = "recipientIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recipientIndex")]
        public int? RecipientIndex { get; set; }

        /// <summary>
        ///     Regular expression validation of the form field
        /// </summary>
        /// <value>Regular expression validation of the form field</value>
        [DataMember(Name = "regularExpression", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "regularExpression")]
        public string RegularExpression { get; set; }

        /// <summary>
        ///     true if it is a mandatory field to be filled by the signer, else false
        /// </summary>
        /// <value>true if it is a mandatory field to be filled by the signer, else false</value>
        [DataMember(Name = "required", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "required")]
        public bool? Required { get; set; }

        /// <summary>
        ///     Action to show/hide the form field is to be taken on the basis of evaluation of conditions.
        /// </summary>
        /// <value>Action to show/hide the form field is to be taken on the basis of evaluation of conditions.</value>
        [DataMember(Name = "showOrHide", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "showOrHide")]
        public string ShowOrHide { get; set; }

        /// <summary>
        ///     Error message to be shown to the signer if filled value doesn't match the validations of the form field
        /// </summary>
        /// <value>Error message to be shown to the signer if filled value doesn't match the validations of the form field</value>
        [DataMember(Name = "specialErrMsg", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "specialErrMsg")]
        public string SpecialErrMsg { get; set; }

        /// <summary>
        ///     Formula used to calculate the value of the form field
        /// </summary>
        /// <value>Formula used to calculate the value of the form field</value>
        [DataMember(Name = "specialFormula", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "specialFormula")]
        public string SpecialFormula { get; set; }

        /// <summary>
        ///     Text that appears while hovering over the field
        /// </summary>
        /// <value>Text that appears while hovering over the field</value>
        [DataMember(Name = "tooltip", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tooltip")]
        public string Tooltip { get; set; }

        /// <summary>
        ///     Text values which are visible in a drop down form field
        /// </summary>
        /// <value>Text values which are visible in a drop down form field</value>
        [DataMember(Name = "visibleOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "visibleOptions")]
        public List<string> VisibleOptions { get; set; }

        /// <summary>
        ///     Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);


        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestFormField {\n");
            sb.Append("  RadioCheckType: ").Append(RadioCheckType).Append("\n");
            sb.Append("  BorderColor: ").Append(BorderColor).Append("\n");
            sb.Append("  FormatData: ").Append(FormatData).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  MaskingText: ").Append(MaskingText).Append("\n");
            sb.Append("  RegularExpression: ").Append(RegularExpression).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  Masked: ").Append(Masked).Append("\n");
            sb.Append("  SpecialErrMsg: ").Append(SpecialErrMsg).Append("\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  CalculatedExpression: ").Append(CalculatedExpression).Append("\n");
            sb.Append("  ShowOrHide: ").Append(ShowOrHide).Append("\n");
            sb.Append("  Tooltip: ").Append(Tooltip).Append("\n");
            sb.Append("  HiddenOptions: ").Append(HiddenOptions).Append("\n");
            sb.Append("  SpecialFormula: ").Append(SpecialFormula).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  MaxNumberValue: ").Append(MaxNumberValue).Append("\n");
            sb.Append("  BorderWidth: ").Append(BorderWidth).Append("\n");
            sb.Append("  InputType: ").Append(InputType).Append("\n");
            sb.Append("  BorderStyle: ").Append(BorderStyle).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  DisplayLabel: ").Append(DisplayLabel).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  DisplayFormatType: ").Append(DisplayFormatType).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  MinNumberValue: ").Append(MinNumberValue).Append("\n");
            sb.Append("  DisplayFormat: ").Append(DisplayFormat).Append("\n");
            sb.Append("  VisibleOptions: ").Append(VisibleOptions).Append("\n");
            sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
            sb.Append("  RecipientIndex: ").Append(RecipientIndex).Append("\n");
            sb.Append("  FontName: ").Append(FontName).Append("\n");
            sb.Append("  AnyOrAll: ").Append(AnyOrAll).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  Alignment: ").Append(Alignment).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  FontColor: ").Append(FontColor).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
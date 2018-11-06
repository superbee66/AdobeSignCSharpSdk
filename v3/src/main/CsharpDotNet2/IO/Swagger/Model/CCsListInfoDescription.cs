using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class CCsListInfoDescription
    {
        /// <summary>
        ///     A default  email that will be used if no input is provided for this list element
        /// </summary>
        /// <value>A default  email that will be used if no input is provided for this list element</value>
        [DataMember(Name = "defaultValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }

        /// <summary>
        ///     Whether current field can be edited. If editable attribute for this field is false then this field should not be
        ///     provided in the agreement creation request and default value of this field will be used in agreement creation
        /// </summary>
        /// <value>
        ///     Whether current field can be edited. If editable attribute for this field is false then this field should not be
        ///     provided in the agreement creation request and default value of this field will be used in agreement creation
        /// </value>
        [DataMember(Name = "editable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "editable")]
        public bool? Editable { get; set; }

        /// <summary>
        ///     A display text for the workflow user that can be used for the current CC list
        /// </summary>
        /// <value>A display text for the workflow user that can be used for the current CC list</value>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        ///     maximum number of entries allowed in the current CC list
        /// </summary>
        /// <value>maximum number of entries allowed in the current CC list</value>
        [DataMember(Name = "maxListCount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "maxListCount")]
        public int MaxListCount { get; set; }

        /// <summary>
        ///     minimum number of entries allowed in the current CC list
        /// </summary>
        /// <value>minimum number of entries allowed in the current CC list</value>
        [DataMember(Name = "minListCount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minListCount")]
        public int MinListCount { get; set; }

        /// <summary>
        ///     Name of the current CC list
        /// </summary>
        /// <value>Name of the current CC list</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Whether current field is visible or not. If visible attribute for this field is false then this field should not be
        ///     shown in the agreement creation page using this workflow
        /// </summary>
        /// <value>
        ///     Whether current field is visible or not. If visible attribute for this field is false then this field should not
        ///     be shown in the agreement creation page using this workflow
        /// </value>
        [DataMember(Name = "visible", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "visible")]
        public bool? Visible { get; set; }

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
            sb.Append("class CCsListInfoDescription {\n");
            sb.Append("  MinListCount: ").Append(MinListCount).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  Editable: ").Append(Editable).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MaxListCount: ").Append(MaxListCount).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
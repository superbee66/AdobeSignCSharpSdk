using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class WorkflowDefaultParams
    {
        /// <summary>
        ///     default value of the field if input for this field is not provided and this field is required
        /// </summary>
        /// <value>default value of the field if input for this field is not provided and this field is required</value>
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
        ///     Whether this field is required or optional
        /// </summary>
        /// <value>Whether this field is required or optional</value>
        [DataMember(Name = "required", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "required")]
        public bool? Required { get; set; }

        /// <summary>
        ///     Whether current field is visible or not. If visible attribute for this field is false then this field should not be
        ///     visible in the agreement creation UI using this workflow to user
        /// </summary>
        /// <value>
        ///     Whether current field is visible or not. If visible attribute for this field is false then this field should not
        ///     be visible in the agreement creation UI using this workflow to user
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
            sb.Append("class WorkflowDefaultParams {\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  Editable: ").Append(Editable).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
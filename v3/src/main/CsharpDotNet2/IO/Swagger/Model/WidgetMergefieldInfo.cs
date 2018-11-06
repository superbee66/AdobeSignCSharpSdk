using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class WidgetMergefieldInfo
    {
        /// <summary>
        ///     The default value of the field
        /// </summary>
        /// <value>The default value of the field</value>
        [DataMember(Name = "defaultValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }

        /// <summary>
        ///     The name of the field
        /// </summary>
        /// <value>The name of the field</value>
        [DataMember(Name = "fieldName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fieldName")]
        public string FieldName { get; set; }

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
            sb.Append("class WidgetMergefieldInfo {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
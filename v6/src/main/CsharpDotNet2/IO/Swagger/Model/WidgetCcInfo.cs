using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class WidgetCcInfo
    {
        /// <summary>
        ///     Email of the CC participant of the widget
        /// </summary>
        /// <value>Email of the CC participant of the widget</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

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
            sb.Append("class WidgetCcInfo {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
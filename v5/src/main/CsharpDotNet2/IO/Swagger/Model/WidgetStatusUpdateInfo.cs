using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class WidgetStatusUpdateInfo
    {
        /// <summary>
        ///     Display this custom message to the user when the widget is accessed. Note that this can contain wiki markup to
        ///     include clickable links in the message. This is required if redirectUrl is not provided. Both message and
        ///     redirectUrl can not be specified.
        /// </summary>
        /// <value>
        ///     Display this custom message to the user when the widget is accessed. Note that this can contain wiki markup to
        ///     include clickable links in the message. This is required if redirectUrl is not provided. Both message and
        ///     redirectUrl can not be specified.
        /// </value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        ///     Redirect the user to this URL when the widget is accessed. This is required if message is not provided. Both
        ///     message and redirectUrl can not be specified.
        /// </summary>
        /// <value>
        ///     Redirect the user to this URL when the widget is accessed. This is required if message is not provided. Both
        ///     message and redirectUrl can not be specified.
        /// </value>
        [DataMember(Name = "redirectUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "redirectUrl")]
        public string RedirectUrl { get; set; }

        /// <summary>
        ///     The status to which the widget is to be updated. The possible values for this variable are ENABLE and DISABLE
        /// </summary>
        /// <value>The status to which the widget is to be updated. The possible values for this variable are ENABLE and DISABLE</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

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
            sb.Append("class WidgetStatusUpdateInfo {\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    ///     A JSON object describing the personalize widget
    /// </summary>
    [DataContract]
    public class WidgetPersonalizeResponse
    {
        /// <summary>
        ///     Javascript snippet suitable for an embedded page taking a user to a URL
        /// </summary>
        /// <value>Javascript snippet suitable for an embedded page taking a user to a URL</value>
        [DataMember(Name = "javascript", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "javascript")]
        public string Javascript { get; set; }

        /// <summary>
        ///     Standalone URL to direct end users to
        /// </summary>
        /// <value>Standalone URL to direct end users to</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        ///     The unique identifier of widget which can be used to retrieve the data entered by the signers.
        /// </summary>
        /// <value>The unique identifier of widget which can be used to retrieve the data entered by the signers.</value>
        [DataMember(Name = "widgetId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "widgetId")]
        public string WidgetId { get; set; }

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
            sb.Append("class WidgetPersonalizeResponse {\n");
            sb.Append("  WidgetId: ").Append(WidgetId).Append("\n");
            sb.Append("  Javascript: ").Append(Javascript).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
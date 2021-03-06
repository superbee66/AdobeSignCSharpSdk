using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V2.Model
{
    /// <summary>
    ///     A JSON object describing the widget
    /// </summary>
    [DataContract]
    public class WidgetCreationResponse
    {
        /// <summary>
        ///     Javascript snippet suitable for an embedded page taking a user to a URL
        /// </summary>
        /// <value>Javascript snippet suitable for an embedded page taking a user to a URL</value>
        [DataMember(Name = "javascript", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "javascript")]
        public string Javascript { get; set; }

        /// <summary>
        ///     Javascript snippet suitable for an embedded page of the redirected URL that can be used by widget creators
        /// </summary>
        /// <value>Javascript snippet suitable for an embedded page of the redirected URL that can be used by widget creators</value>
        [DataMember(Name = "nextPageEmbeddedCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nextPageEmbeddedCode")]
        public string NextPageEmbeddedCode { get; set; }

        /// <summary>
        ///     Redirect URL once the widget is created
        /// </summary>
        /// <value>Redirect URL once the widget is created</value>
        [DataMember(Name = "nextPageUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nextPageUrl")]
        public string NextPageUrl { get; set; }

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
            sb.Append("class WidgetCreationResponse {\n");
            sb.Append("  NextPageUrl: ").Append(NextPageUrl).Append("\n");
            sb.Append("  WidgetId: ").Append(WidgetId).Append("\n");
            sb.Append("  NextPageEmbeddedCode: ").Append(NextPageEmbeddedCode).Append("\n");
            sb.Append("  Javascript: ").Append(Javascript).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
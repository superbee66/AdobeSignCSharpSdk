using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model
{
    /// <summary>
    ///     A JSON object describing the library template
    /// </summary>
    [DataContract]
    public class LibraryDocumentCreationResponse
    {
        /// <summary>
        ///     Javascript snippet suitable for an embedded page taking a user to a URL
        /// </summary>
        /// <value>Javascript snippet suitable for an embedded page taking a user to a URL</value>
        [DataMember(Name = "embeddedCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "embeddedCode")]
        public string EmbeddedCode { get; set; }

        /// <summary>
        ///     Expiration date for autologin. This is based on the user setting, API_AUTO_LOGIN_LIFETIME
        /// </summary>
        /// <value>Expiration date for autologin. This is based on the user setting, API_AUTO_LOGIN_LIFETIME</value>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expiration")]
        public DateTime? Expiration { get; set; }

        /// <summary>
        ///     The unique identifier that can be used to refer to the library template
        /// </summary>
        /// <value>The unique identifier that can be used to refer to the library template</value>
        [DataMember(Name = "libraryDocumentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "libraryDocumentId")]
        public string LibraryDocumentId { get; set; }

        /// <summary>
        ///     Standalone URL to direct end users to
        /// </summary>
        /// <value>Standalone URL to direct end users to</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

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
            sb.Append("class LibraryDocumentCreationResponse {\n");
            sb.Append("  EmbeddedCode: ").Append(EmbeddedCode).Append("\n");
            sb.Append("  LibraryDocumentId: ").Append(LibraryDocumentId).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
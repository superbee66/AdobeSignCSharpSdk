using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class CounterSignerInfo
    {
        /// <summary>
        ///     Email of the recipient
        /// </summary>
        /// <value>Email of the recipient</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        ///     Security options that apply to the counter signers
        /// </summary>
        /// <value>Security options that apply to the counter signers</value>
        [DataMember(Name = "securityOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "securityOptions")]
        public List<WidgetSignerSecurityOption> SecurityOptions { get; set; }

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
            sb.Append("class CounterSignerInfo {\n");
            sb.Append("  SecurityOptions: ").Append(SecurityOptions).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
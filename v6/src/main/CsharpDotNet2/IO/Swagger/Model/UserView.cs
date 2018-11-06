using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class UserView
    {
        /// <summary>
        ///     Embedded code of url of resource
        /// </summary>
        /// <value>Embedded code of url of resource </value>
        [DataMember(Name = "embeddedCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "embeddedCode")]
        public string EmbeddedCode { get; set; }

        /// <summary>
        ///     Expiration of user url
        /// </summary>
        /// <value>Expiration of user url </value>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expiration")]
        public DateTime? Expiration { get; set; }

        /// <summary>
        ///     Name of the requested user view
        /// </summary>
        /// <value>Name of the requested user view</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Url of resource location
        /// </summary>
        /// <value>Url of resource location</value>
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
            sb.Append("class UserView {\n");
            sb.Append("  EmbeddedCode: ").Append(EmbeddedCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class BaseUriInfo
    {
        /// <summary>
        ///     The access point from where other APIs need to be accessed. In case other APIs are accessed from a different end
        ///     point, it will be considered an invalid request
        /// </summary>
        /// <value>
        ///     The access point from where other APIs need to be accessed. In case other APIs are accessed from a different end
        ///     point, it will be considered an invalid request
        /// </value>
        [DataMember(Name = "api_access_point", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "api_access_point")]
        public string ApiAccessPoint { get; set; }

        /// <summary>
        ///     The access point from where Adobe Sign website can be be accessed
        /// </summary>
        /// <value>The access point from where Adobe Sign website can be be accessed</value>
        [DataMember(Name = "web_access_point", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "web_access_point")]
        public string WebAccessPoint { get; set; }

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
            sb.Append("class BaseUriInfo {\n");
            sb.Append("  ApiAccessPoint: ").Append(ApiAccessPoint).Append("\n");
            sb.Append("  WebAccessPoint: ").Append(WebAccessPoint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
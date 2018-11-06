using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class MegaSignCreationRequest
    {
        /// <summary>
        ///     Information about the MegaSign you want to send
        /// </summary>
        /// <value>Information about the MegaSign you want to send</value>
        [DataMember(Name = "megaSignCreationInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "megaSignCreationInfo")]
        public MegaSignCreationInfo MegaSignCreationInfo { get; set; }

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
            sb.Append("class MegaSignCreationRequest {\n");
            sb.Append("  MegaSignCreationInfo: ").Append(MegaSignCreationInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
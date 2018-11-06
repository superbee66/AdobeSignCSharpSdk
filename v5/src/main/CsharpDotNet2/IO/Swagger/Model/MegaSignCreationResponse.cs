using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    ///     A JSON  that contains the id of the newly created Mega Sign
    /// </summary>
    [DataContract]
    public class MegaSignCreationResponse
    {
        /// <summary>
        ///     Unique identifier of the MegaSign parent agreement
        /// </summary>
        /// <value>Unique identifier of the MegaSign parent agreement</value>
        [DataMember(Name = "megaSignId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "megaSignId")]
        public string MegaSignId { get; set; }

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
            sb.Append("class MegaSignCreationResponse {\n");
            sb.Append("  MegaSignId: ").Append(MegaSignId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
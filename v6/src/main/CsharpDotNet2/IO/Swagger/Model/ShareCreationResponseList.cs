using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class ShareCreationResponseList
    {
        /// <summary>
        ///     List of ShareCreationResponse
        /// </summary>
        /// <value>List of ShareCreationResponse</value>
        [DataMember(Name = "shareCreationResponseList", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shareCreationResponseList")]
        public List<ShareCreationResponse> _ShareCreationResponseList { get; set; }

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
            sb.Append("class ShareCreationResponseList {\n");
            sb.Append("  _ShareCreationResponseList: ").Append(_ShareCreationResponseList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class ShareCreationInfoList
    {
        /// <summary>
        ///     List of ShareCreationInfo
        /// </summary>
        /// <value>List of ShareCreationInfo</value>
        [DataMember(Name = "shareCreationInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shareCreationInfo")]
        public List<ShareCreationInfo> ShareCreationInfo { get; set; }

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
            sb.Append("class ShareCreationInfoList {\n");
            sb.Append("  ShareCreationInfo: ").Append(ShareCreationInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
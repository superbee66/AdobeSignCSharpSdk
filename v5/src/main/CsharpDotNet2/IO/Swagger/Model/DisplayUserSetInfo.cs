using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class DisplayUserSetInfo
    {
        /// <summary>
        ///     Displays the info about user set
        /// </summary>
        /// <value>Displays the info about user set</value>
        [DataMember(Name = "displayUserSetMemberInfos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayUserSetMemberInfos")]
        public List<DisplayUserInfo> DisplayUserSetMemberInfos { get; set; }

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
            sb.Append("class DisplayUserSetInfo {\n");
            sb.Append("  DisplayUserSetMemberInfos: ").Append(DisplayUserSetMemberInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
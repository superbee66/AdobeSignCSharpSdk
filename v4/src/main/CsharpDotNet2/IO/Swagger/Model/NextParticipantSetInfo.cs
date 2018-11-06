using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class NextParticipantSetInfo
    {
        /// <summary>
        ///     Information about the members of the next participant set
        /// </summary>
        /// <value>Information about the members of the next participant set</value>
        [DataMember(Name = "nextParticipantSetMemberInfos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nextParticipantSetMemberInfos")]
        public List<NextParticipantInfo> NextParticipantSetMemberInfos { get; set; }

        /// <summary>
        ///     The name of the next participant set. Returned only, if the API caller is the sender of agreement.
        /// </summary>
        /// <value>The name of the next participant set. Returned only, if the API caller is the sender of agreement.</value>
        [DataMember(Name = "nextParticipantSetName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nextParticipantSetName")]
        public string NextParticipantSetName { get; set; }

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
            sb.Append("class NextParticipantSetInfo {\n");
            sb.Append("  NextParticipantSetName: ").Append(NextParticipantSetName).Append("\n");
            sb.Append("  NextParticipantSetMemberInfos: ").Append(NextParticipantSetMemberInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
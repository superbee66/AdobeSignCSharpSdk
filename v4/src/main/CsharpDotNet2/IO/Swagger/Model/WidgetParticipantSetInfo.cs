using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class WidgetParticipantSetInfo
    {
        /// <summary>
        ///     Information about the members of the recipient set
        /// </summary>
        /// <value>Information about the members of the recipient set</value>
        [DataMember(Name = "participantSetMemberInfos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "participantSetMemberInfos")]
        public List<WidgetParticipantInfo> ParticipantSetMemberInfos { get; set; }

        /// <summary>
        ///     The current roles of the participant set. A participant set can have one or more roles
        /// </summary>
        /// <value>The current roles of the participant set. A participant set can have one or more roles</value>
        [DataMember(Name = "roles", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "roles")]
        public List<string> Roles { get; set; }

        /// <summary>
        ///     Security options that apply to the participant
        /// </summary>
        /// <value>Security options that apply to the participant</value>
        [DataMember(Name = "securityOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "securityOptions")]
        public List<string> SecurityOptions { get; set; }

        /// <summary>
        ///     The status of the participant set with respect to the widget
        /// </summary>
        /// <value>The status of the participant set with respect to the widget</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

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
            sb.Append("class WidgetParticipantSetInfo {\n");
            sb.Append("  ParticipantSetMemberInfos: ").Append(ParticipantSetMemberInfos).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  SecurityOptions: ").Append(SecurityOptions).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
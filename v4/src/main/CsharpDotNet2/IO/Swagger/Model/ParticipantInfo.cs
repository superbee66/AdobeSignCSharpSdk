using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class ParticipantInfo
    {
        /// <summary>
        ///     All the child participants of the current participant. The possible values for the status of these participants
        ///     are, SHARE and DELEGATE
        /// </summary>
        /// <value>
        ///     All the child participants of the current participant. The possible values for the status of these participants
        ///     are, SHARE and DELEGATE
        /// </value>
        [DataMember(Name = "alternateParticipants", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "alternateParticipants")]
        public List<ParticipantSetInfo> AlternateParticipants { get; set; }

        /// <summary>
        ///     The company of the participant, if available
        /// </summary>
        /// <value>The company of the participant, if available</value>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "company")]
        public string Company { get; set; }

        /// <summary>
        ///     The email address of the participant
        /// </summary>
        /// <value>The email address of the participant</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        ///     The name of the participant, if available
        /// </summary>
        /// <value>The name of the participant, if available</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Security options that apply to the participant
        /// </summary>
        /// <value>Security options that apply to the participant</value>
        [DataMember(Name = "securityOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "securityOptions")]
        public List<string> SecurityOptions { get; set; }

        /// <summary>
        ///     The title of the participant, if available
        /// </summary>
        /// <value>The title of the participant, if available</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

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
            sb.Append("class ParticipantInfo {\n");
            sb.Append("  AlternateParticipants: ").Append(AlternateParticipants).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  SecurityOptions: ").Append(SecurityOptions).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
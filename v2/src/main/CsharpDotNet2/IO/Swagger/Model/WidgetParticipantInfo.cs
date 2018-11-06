using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V2.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class WidgetParticipantInfo
    {
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
        ///     The current roles of the participant. A participant can have one or more roles
        /// </summary>
        /// <value>The current roles of the participant. A participant can have one or more roles</value>
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
        ///     The status of the participant with respect to the widget
        /// </summary>
        /// <value>The status of the participant with respect to the widget</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

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
            sb.Append("class WidgetParticipantInfo {\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  SecurityOptions: ").Append(SecurityOptions).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
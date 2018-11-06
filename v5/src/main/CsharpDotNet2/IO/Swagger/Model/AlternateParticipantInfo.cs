using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class AlternateParticipantInfo
    {
        /// <summary>
        ///     The country code for the alternate participant
        /// </summary>
        /// <value>The country code for the alternate participant</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     The email of the alternate participant. This is required if fax is not provided. Both fax and email can not be
        ///     provided
        /// </summary>
        /// <value>
        ///     The email of the alternate participant. This is required if fax is not provided. Both fax and email can not be
        ///     provided
        /// </value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        ///     The phone number for the alternate participant
        /// </summary>
        /// <value>The phone number for the alternate participant</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        ///     The private message for the alternate participant
        /// </summary>
        /// <value>The private message for the alternate participant</value>
        [DataMember(Name = "privateMessage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "privateMessage")]
        public string PrivateMessage { get; set; }

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
            sb.Append("class AlternateParticipantInfo {\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PrivateMessage: ").Append(PrivateMessage).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class DisplayUserInfo
    {
        /// <summary>
        ///     Displays the name of the company of the user, if available
        /// </summary>
        /// <value>Displays the name of the company of the user, if available</value>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "company")]
        public string Company { get; set; }

        /// <summary>
        ///     Displays the email of the user
        /// </summary>
        /// <value>Displays the email of the user</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        ///     Displays the full name of the user, if available.
        /// </summary>
        /// <value>Displays the full name of the user, if available. </value>
        [DataMember(Name = "fullName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }

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
            sb.Append("class DisplayUserInfo {\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
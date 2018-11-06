using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class UserInfo
    {
        /// <summary>
        ///     The name of company of the user
        /// </summary>
        /// <value>The name of company of the user</value>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "company")]
        public string Company { get; set; }

        /// <summary>
        ///     The email address of the user
        /// </summary>
        /// <value>The email address of the user</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        ///     The full name of the user, if available; or their email address
        /// </summary>
        /// <value>The full name of the user, if available; or their email address</value>
        [DataMember(Name = "fullNameOrEmail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fullNameOrEmail")]
        public string FullNameOrEmail { get; set; }

        /// <summary>
        ///     The identifier that can be used in group management methods
        /// </summary>
        /// <value>The identifier that can be used in group management methods</value>
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }

        /// <summary>
        ///     A unique identifier of the user resource for REST APIs. This identifier can not be used in SOAP APIs
        /// </summary>
        /// <value>A unique identifier of the user resource for REST APIs. This identifier can not be used in SOAP APIs</value>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

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
            sb.Append("class UserInfo {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  FullNameOrEmail: ").Append(FullNameOrEmail).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
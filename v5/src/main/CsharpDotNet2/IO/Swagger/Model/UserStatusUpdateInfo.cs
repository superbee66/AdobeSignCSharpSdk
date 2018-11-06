using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class UserStatusUpdateInfo
    {
        /// <summary>
        ///     An optional comment describing why you want to activate/deactivate a given user
        /// </summary>
        /// <value>An optional comment describing why you want to activate/deactivate a given user</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        ///     The state to which the user is to be updated. The valid states for this variable is currently, ACTIVE and INACTIVE
        /// </summary>
        /// <value>
        ///     The state to which the user is to be updated. The valid states for this variable is currently, ACTIVE and
        ///     INACTIVE
        /// </value>
        [DataMember(Name = "userStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "userStatus")]
        public string UserStatus { get; set; }

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
            sb.Append("class UserStatusUpdateInfo {\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
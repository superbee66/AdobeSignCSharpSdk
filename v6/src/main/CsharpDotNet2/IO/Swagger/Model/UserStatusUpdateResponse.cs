using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class UserStatusUpdateResponse
    {
        /// <summary>
        ///     The result of the attempt to activate or deactivate the user
        /// </summary>
        /// <value>The result of the attempt to activate or deactivate the user</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        ///     String result message if there was no error
        /// </summary>
        /// <value>String result message if there was no error</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        ///     A status value showing the result of this operation
        /// </summary>
        /// <value>A status value showing the result of this operation</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

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
            sb.Append("class UserStatusUpdateResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
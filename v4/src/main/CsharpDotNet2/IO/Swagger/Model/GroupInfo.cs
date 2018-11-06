using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class GroupInfo
    {
        /// <summary>
        ///     Unique identifier of the group
        /// </summary>
        /// <value>Unique identifier of the group</value>
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }

        /// <summary>
        ///     Name of the group
        /// </summary>
        /// <value>Name of the group</value>
        [DataMember(Name = "groupName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groupName")]
        public string GroupName { get; set; }

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
            sb.Append("class GroupInfo {\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
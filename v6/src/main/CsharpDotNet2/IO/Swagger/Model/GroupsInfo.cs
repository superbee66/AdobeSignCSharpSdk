using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class GroupsInfo
    {
        /// <summary>
        ///     The list of groups in the account.
        /// </summary>
        /// <value>The list of groups in the account.</value>
        [DataMember(Name = "groupInfoList", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groupInfoList")]
        public List<GroupInfo> GroupInfoList { get; set; }

        /// <summary>
        ///     Pagination information for navigating through the response
        /// </summary>
        /// <value>Pagination information for navigating through the response</value>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "page")]
        public PageInfo Page { get; set; }

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
            sb.Append("class GroupsInfo {\n");
            sb.Append("  GroupInfoList: ").Append(GroupInfoList).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
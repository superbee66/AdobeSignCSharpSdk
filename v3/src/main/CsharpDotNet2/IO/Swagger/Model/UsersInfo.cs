using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class UsersInfo
    {
        /// <summary>
        ///     The list of users in the account
        /// </summary>
        /// <value>The list of users in the account</value>
        [DataMember(Name = "userInfoList", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "userInfoList")]
        public List<UserInfo> UserInfoList { get; set; }

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
            sb.Append("class UsersInfo {\n");
            sb.Append("  UserInfoList: ").Append(UserInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
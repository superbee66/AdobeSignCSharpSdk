using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V2.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class UserAgreements
    {
        /// <summary>
        ///     An array of UserAgreement items
        /// </summary>
        /// <value>An array of UserAgreement items</value>
        [DataMember(Name = "userAgreementList", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "userAgreementList")]
        public List<UserAgreement> UserAgreementList { get; set; }

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
            sb.Append("class UserAgreements {\n");
            sb.Append("  UserAgreementList: ").Append(UserAgreementList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class AgreementViews
    {
        /// <summary>
        ///     List of agreement views
        /// </summary>
        /// <value>List of agreement views</value>
        [DataMember(Name = "agreementViewList", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "agreementViewList")]
        public List<AgreementView> AgreementViewList { get; set; }

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
            sb.Append("class AgreementViews {\n");
            sb.Append("  AgreementViewList: ").Append(AgreementViewList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class MegaSignChildAgreements
    {
        /// <summary>
        ///     A array of MegaSign child agreements
        /// </summary>
        /// <value>A array of MegaSign child agreements</value>
        [DataMember(Name = "megaSignChildAgreementList", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "megaSignChildAgreementList")]
        public List<MegaSignChildAgreement> MegaSignChildAgreementList { get; set; }

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
            sb.Append("class MegaSignChildAgreements {\n");
            sb.Append("  MegaSignChildAgreementList: ").Append(MegaSignChildAgreementList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
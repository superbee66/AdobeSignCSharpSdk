using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class AgreementStateInfo
    {
        /// <summary>
        ///     Cancellation information for the agreement
        /// </summary>
        /// <value>Cancellation information for the agreement</value>
        [DataMember(Name = "agreementCancellationInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "agreementCancellationInfo")]
        public AgreementCancellationInfo AgreementCancellationInfo { get; set; }

        /// <summary>
        ///     The state in which the agreement should land
        /// </summary>
        /// <value>The state in which the agreement should land</value>
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
            sb.Append("class AgreementStateInfo {\n");
            sb.Append("  AgreementCancellationInfo: ").Append(AgreementCancellationInfo).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
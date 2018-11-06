using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class PhoneInfo
    {
        /// <summary>
        ///     The phoneInfo country code required for the counter signer to view and sign the widget if authentication type is
        ///     PHONE
        /// </summary>
        /// <value>
        ///     The phoneInfo country code required for the counter signer to view and sign the widget if authentication type is
        ///     PHONE
        /// </value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     The phoneInfo country code required for the counter signer to view and sign the widget if authentication type is
        ///     PHONE
        /// </summary>
        /// <value>
        ///     The phoneInfo country code required for the counter signer to view and sign the widget if authentication type is
        ///     PHONE
        /// </value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

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
            sb.Append("class PhoneInfo {\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
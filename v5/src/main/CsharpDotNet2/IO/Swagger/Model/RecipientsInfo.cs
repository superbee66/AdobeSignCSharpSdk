using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class RecipientsInfo
    {
        /// <summary>
        ///     Name of the recipient list as returned in workflow description
        /// </summary>
        /// <value>Name of the recipient list as returned in workflow description</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     A list of one or more recipients. For regular (non-MegaSign) documents, there is no limit on the number of
        ///     electronic signatures in a single document. Written signatures are limited to four per document. This limit
        ///     includes the sender if the signature of the sender is also required
        /// </summary>
        /// <value>
        ///     A list of one or more recipients. For regular (non-MegaSign) documents, there is no limit on the number of
        ///     electronic signatures in a single document. Written signatures are limited to four per document. This limit
        ///     includes the sender if the signature of the sender is also required
        /// </value>
        [DataMember(Name = "recipients", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recipients")]
        public List<RecipientInfo> Recipients { get; set; }

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
            sb.Append("class RecipientsInfo {\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
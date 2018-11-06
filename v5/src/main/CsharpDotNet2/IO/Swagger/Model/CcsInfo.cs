using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class CcsInfo
    {
        /// <summary>
        ///     A list of one or more email addresses that you want to copy on this transaction. The email addresses will each
        ///     receive an email at the beginning of the transaction and also when the final document is signed. The email
        ///     addresses will also receive a copy of the document, attached as a PDF file
        /// </summary>
        /// <value>
        ///     A list of one or more email addresses that you want to copy on this transaction. The email addresses will each
        ///     receive an email at the beginning of the transaction and also when the final document is signed. The email
        ///     addresses will also receive a copy of the document, attached as a PDF file
        /// </value>
        [DataMember(Name = "emails", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "emails")]
        public List<string> Emails { get; set; }

        /// <summary>
        ///     Name of the CC list as returned in workflow description
        /// </summary>
        /// <value>Name of the CC list as returned in workflow description</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

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
            sb.Append("class CcsInfo {\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
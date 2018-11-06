using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class VaultingInfo
    {
        /// <summary>
        ///     For accounts set up for document vaulting and the option to enable per agreement, this determines whether the
        ///     document is to be vaulted
        /// </summary>
        /// <value>
        ///     For accounts set up for document vaulting and the option to enable per agreement, this determines whether the
        ///     document is to be vaulted
        /// </value>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

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
            sb.Append("class VaultingInfo {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
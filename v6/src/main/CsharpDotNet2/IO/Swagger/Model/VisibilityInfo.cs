using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class VisibilityInfo
    {
        /// <summary>
        ///     Specifies the visibility. The possible values are HIDE or SHOW
        /// </summary>
        /// <value>Specifies the visibility. The possible values are HIDE or SHOW</value>
        [DataMember(Name = "visibility", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "visibility")]
        public string Visibility { get; set; }

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
            sb.Append("class VisibilityInfo {\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
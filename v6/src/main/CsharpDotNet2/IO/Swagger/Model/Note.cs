using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Note
    {
        /// <summary>
        ///     Content of Note field
        /// </summary>
        /// <value>Content of Note field</value>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "note")]
        public string _Note { get; set; }

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
            sb.Append("class Note {\n");
            sb.Append("  _Note: ").Append(_Note).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class WidgetDocuments
    {
        /// <summary>
        ///     A list of documents
        /// </summary>
        /// <value>A list of documents</value>
        [DataMember(Name = "documents", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "documents")]
        public List<WidgetOriginalDocument> Documents { get; set; }

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
            sb.Append("class WidgetDocuments {\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class MegaSigns
    {
        /// <summary>
        ///     An array of MegaSign parent agreements
        /// </summary>
        /// <value>An array of MegaSign parent agreements</value>
        [DataMember(Name = "megaSignList", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "megaSignList")]
        public List<MegaSign> MegaSignList { get; set; }

        /// <summary>
        ///     Pagination information for navigating through the response
        /// </summary>
        /// <value>Pagination information for navigating through the response</value>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "page")]
        public PageInfo Page { get; set; }

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
            sb.Append("class MegaSigns {\n");
            sb.Append("  MegaSignList: ").Append(MegaSignList).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class DocumentPageInfo
    {
        /// <summary>
        ///     Height of the page
        /// </summary>
        /// <value>Height of the page</value>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "height")]
        public double? Height { get; set; }

        /// <summary>
        ///     Number of the page in combined document starting from 1.
        /// </summary>
        /// <value>Number of the page in combined document starting from 1.</value>
        [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pageNumber")]
        public int PageNumber { get; set; }

        /// <summary>
        ///     Rotation angle of the page in clockwise direction in degree
        /// </summary>
        /// <value>Rotation angle of the page in clockwise direction in degree</value>
        [DataMember(Name = "rotation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rotation")]
        public double? Rotation { get; set; }

        /// <summary>
        ///     Width of the page
        /// </summary>
        /// <value>Width of the page</value>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "width")]
        public double? Width { get; set; }

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
            sb.Append("class DocumentPageInfo {\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
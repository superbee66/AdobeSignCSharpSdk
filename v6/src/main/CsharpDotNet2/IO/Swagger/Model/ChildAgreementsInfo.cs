using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class ChildAgreementsInfo
    {
        /// <summary>
        ///     File info containing per child agreement information of megaSign.
        /// </summary>
        /// <value>File info containing per child agreement information of megaSign.</value>
        [DataMember(Name = "fileInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fileInfo")]
        public MegaSignChildAgreementsFileInfo FileInfo { get; set; }

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
            sb.Append("class ChildAgreementsInfo {\n");
            sb.Append("  FileInfo: ").Append(FileInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
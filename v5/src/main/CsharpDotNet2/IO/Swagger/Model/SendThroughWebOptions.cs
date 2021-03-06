using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class SendThroughWebOptions
    {
        /// <summary>
        ///     Controls various file upload options available on the compose page
        /// </summary>
        /// <value>Controls various file upload options available on the compose page</value>
        [DataMember(Name = "fileUploadOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fileUploadOptions")]
        public FileUploadOptions FileUploadOptions { get; set; }

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
            sb.Append("class SendThroughWebOptions {\n");
            sb.Append("  FileUploadOptions: ").Append(FileUploadOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
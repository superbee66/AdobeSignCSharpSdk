using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V1.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class ApplicationCredentials
    {
        /// <summary>
        ///     Unique identifier of the application
        /// </summary>
        /// <value>Unique identifier of the application</value>
        [DataMember(Name = "applicationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        ///     The value used to authenticate an application (similar to a password)
        /// </summary>
        /// <value>The value used to authenticate an application (similar to a password)</value>
        [DataMember(Name = "applicationSecret", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "applicationSecret")]
        public string ApplicationSecret { get; set; }

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
            sb.Append("class ApplicationCredentials {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationSecret: ").Append(ApplicationSecret).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
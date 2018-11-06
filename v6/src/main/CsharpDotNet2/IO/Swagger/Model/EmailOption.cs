using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class EmailOption
    {
        /// <summary>
        ///     Specify emails to be sent to different participants at different steps of the agreement process. Note: ALL means
        ///     emails for the events will be sent to all participants. NONE means emails for the events will not be sent to any
        ///     participant
        /// </summary>
        /// <value>
        ///     Specify emails to be sent to different participants at different steps of the agreement process. Note: ALL means
        ///     emails for the events will be sent to all participants. NONE means emails for the events will not be sent to any
        ///     participant
        /// </value>
        [DataMember(Name = "sendOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sendOptions")]
        public SendOptions SendOptions { get; set; }

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
            sb.Append("class EmailOption {\n");
            sb.Append("  SendOptions: ").Append(SendOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
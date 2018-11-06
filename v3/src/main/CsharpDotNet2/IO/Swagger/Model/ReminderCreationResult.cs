using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class ReminderCreationResult
    {
        /// <summary>
        ///     The email address of the user to whom the reminder was sent. This may either be the sender or the recipient of the
        ///     document depending on the selected workflow, and on whose turn it was to sign. In the current release, the reminder
        ///     is sent to that user that is currently expected to sign a given document
        /// </summary>
        /// <value>
        ///     The email address of the user to whom the reminder was sent. This may either be the sender or the recipient of
        ///     the document depending on the selected workflow, and on whose turn it was to sign. In the current release, the
        ///     reminder is sent to that user that is currently expected to sign a given document
        /// </value>
        [DataMember(Name = "recipientEmail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recipientEmail")]
        public string RecipientEmail { get; set; }

        /// <summary>
        ///     A status value indicating the result of the operation
        /// </summary>
        /// <value>A status value indicating the result of the operation</value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

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
            sb.Append("class ReminderCreationResult {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  RecipientEmail: ").Append(RecipientEmail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
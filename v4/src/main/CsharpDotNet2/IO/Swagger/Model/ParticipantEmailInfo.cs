using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class ParticipantEmailInfo
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
        [DataMember(Name = "participantEmail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "participantEmail")]
        public string ParticipantEmail { get; set; }

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
            sb.Append("class ParticipantEmailInfo {\n");
            sb.Append("  ParticipantEmail: ").Append(ParticipantEmail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
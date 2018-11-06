using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    ///     A JSON that contains the id of the newly created alternate participant
    /// </summary>
    [DataContract]
    public class AlternateParticipantResponse
    {
        /// <summary>
        ///     The unique identifier of the alternate participant
        /// </summary>
        /// <value>The unique identifier of the alternate participant</value>
        [DataMember(Name = "participantId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "participantId")]
        public string ParticipantId { get; set; }

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
            sb.Append("class AlternateParticipantResponse {\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
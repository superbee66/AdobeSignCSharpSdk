using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V2.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class WidgetHistoryEvent
    {
        /// <summary>
        ///     Email address of the user that initiated the event
        /// </summary>
        /// <value>Email address of the user that initiated the event</value>
        [DataMember(Name = "actingUserEmail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "actingUserEmail")]
        public string ActingUserEmail { get; set; }

        /// <summary>
        ///     The IP address of the user that initiated the event
        /// </summary>
        /// <value>The IP address of the user that initiated the event</value>
        [DataMember(Name = "actingUserIpAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "actingUserIpAddress")]
        public string ActingUserIpAddress { get; set; }

        /// <summary>
        ///     The event comment. For RECALLED or REJECTED, the reason given by the user that initiates the event. For DELEGATE or
        ///     SHARE, the message from the acting user to the participant
        /// </summary>
        /// <value>
        ///     The event comment. For RECALLED or REJECTED, the reason given by the user that initiates the event. For DELEGATE
        ///     or SHARE, the message from the acting user to the participant
        /// </value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        ///     The date of the audit event
        /// </summary>
        /// <value>The date of the audit event</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        ///     A description of the audit event
        /// </summary>
        /// <value>A description of the audit event</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        ///     Location of the device that created the event (This value may be null due to limited privileges)
        /// </summary>
        /// <value>Location of the device that created the event (This value may be null due to limited privileges)</value>
        [DataMember(Name = "deviceLocation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deviceLocation")]
        public WidgetEventDeviceLocation DeviceLocation { get; set; }

        /// <summary>
        ///     Email address of the user that initiated the event
        /// </summary>
        /// <value>Email address of the user that initiated the event</value>
        [DataMember(Name = "participantEmail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "participantEmail")]
        public string ParticipantEmail { get; set; }

        /// <summary>
        ///     A unique identifier linking offline events to synchronization events (specified for offline signing events and
        ///     synchronization events, else null)
        /// </summary>
        /// <value>
        ///     A unique identifier linking offline events to synchronization events (specified for offline signing events and
        ///     synchronization events, else null)
        /// </value>
        [DataMember(Name = "synchronizationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "synchronizationId")]
        public string SynchronizationId { get; set; }

        /// <summary>
        ///     Type of the widget event
        /// </summary>
        /// <value>Type of the widget event</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        ///     The identifier assigned by the vault provider for the vault event (if vaulted, otherwise null)
        /// </summary>
        /// <value>The identifier assigned by the vault provider for the vault event (if vaulted, otherwise null)</value>
        [DataMember(Name = "vaultEventId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vaultEventId")]
        public string VaultEventId { get; set; }

        /// <summary>
        ///     An ID which uniquely identifies the version of the widget associated with this audit event
        /// </summary>
        /// <value>An ID which uniquely identifies the version of the widget associated with this audit event</value>
        [DataMember(Name = "versionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "versionId")]
        public string VersionId { get; set; }

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
            sb.Append("class WidgetHistoryEvent {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  ActingUserEmail: ").Append(ActingUserEmail).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  ActingUserIpAddress: ").Append(ActingUserIpAddress).Append("\n");
            sb.Append("  ParticipantEmail: ").Append(ParticipantEmail).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SynchronizationId: ").Append(SynchronizationId).Append("\n");
            sb.Append("  VaultEventId: ").Append(VaultEventId).Append("\n");
            sb.Append("  DeviceLocation: ").Append(DeviceLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
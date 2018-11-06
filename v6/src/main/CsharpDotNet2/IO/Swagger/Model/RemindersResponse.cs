using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class RemindersResponse
    {
        /// <summary>
        ///     A list of one or more reminders created on the agreement specified by the unique identifier agreementId by the user
        ///     invoking the API.
        /// </summary>
        /// <value>
        ///     A list of one or more reminders created on the agreement specified by the unique identifier agreementId by the
        ///     user invoking the API.
        /// </value>
        [DataMember(Name = "reminderInfoList", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reminderInfoList")]
        public List<ReminderInfo> ReminderInfoList { get; set; }

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
            sb.Append("class RemindersResponse {\n");
            sb.Append("  ReminderInfoList: ").Append(ReminderInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
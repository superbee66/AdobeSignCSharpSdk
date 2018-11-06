using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class OfflineDeviceInfo
    {
        /// <summary>
        ///     Application Description
        /// </summary>
        /// <value>Application Description</value>
        [DataMember(Name = "applicationDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "applicationDescription")]
        public string ApplicationDescription { get; set; }

        /// <summary>
        ///     Device Description
        /// </summary>
        /// <value>Device Description</value>
        [DataMember(Name = "deviceDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deviceDescription")]
        public string DeviceDescription { get; set; }

        /// <summary>
        ///     The device local time. The device time provided should not be before 30 days of current date.Format should be
        ///     yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
        /// </summary>
        /// <value>
        ///     The device local time. The device time provided should not be before 30 days of current date.Format should be
        ///     yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
        /// </value>
        [DataMember(Name = "deviceTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deviceTime")]
        public DateTime? DeviceTime { get; set; }

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
            sb.Append("class OfflineDeviceInfo {\n");
            sb.Append("  DeviceDescription: ").Append(DeviceDescription).Append("\n");
            sb.Append("  ApplicationDescription: ").Append(ApplicationDescription).Append("\n");
            sb.Append("  DeviceTime: ").Append(DeviceTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
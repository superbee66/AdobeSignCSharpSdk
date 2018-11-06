using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class LibDocEventDeviceLocation
    {
        /// <summary>
        ///     Latitude coordinate
        /// </summary>
        /// <value>Latitude coordinate</value>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "latitude")]
        public float? Latitude { get; set; }

        /// <summary>
        ///     Longitude coordinate
        /// </summary>
        /// <value>Longitude coordinate</value>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "longitude")]
        public float? Longitude { get; set; }

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
            sb.Append("class LibDocEventDeviceLocation {\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
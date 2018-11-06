using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ParticipantEmailSetInfo {
    /// <summary>
    /// The info about the members of the participant set
    /// </summary>
    /// <value>The info about the members of the participant set</value>
    [DataMember(Name="participantEmailSetInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "participantEmailSetInfo")]
    public List<ParticipantEmailInfo> _ParticipantEmailSetInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ParticipantEmailSetInfo {\n");
      sb.Append("  _ParticipantEmailSetInfo: ").Append(_ParticipantEmailSetInfo).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}

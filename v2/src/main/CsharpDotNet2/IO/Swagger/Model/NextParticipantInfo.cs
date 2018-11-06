using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V2.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class NextParticipantInfo {
    /// <summary>
    /// The date since which the document has been waiting for the participant to take action
    /// </summary>
    /// <value>The date since which the document has been waiting for the participant to take action</value>
    [DataMember(Name="waitingSince", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "waitingSince")]
    public DateTime? WaitingSince { get; set; }

    /// <summary>
    /// The name of the next participant, if available
    /// </summary>
    /// <value>The name of the next participant, if available</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The email address of the next participant
    /// </summary>
    /// <value>The email address of the next participant</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NextParticipantInfo {\n");
      sb.Append("  WaitingSince: ").Append(WaitingSince).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
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

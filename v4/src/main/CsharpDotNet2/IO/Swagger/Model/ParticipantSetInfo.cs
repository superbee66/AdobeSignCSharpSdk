using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ParticipantSetInfo {
    /// <summary>
    /// Index indicating sequential signing group (specified for hybrid routing)
    /// </summary>
    /// <value>Index indicating sequential signing group (specified for hybrid routing)</value>
    [DataMember(Name="signingOrder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signingOrder")]
    public int? SigningOrder { get; set; }

    /// <summary>
    /// Information about the members of the recipient set
    /// </summary>
    /// <value>Information about the members of the recipient set</value>
    [DataMember(Name="participantSetMemberInfos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "participantSetMemberInfos")]
    public List<ParticipantInfo> ParticipantSetMemberInfos { get; set; }

    /// <summary>
    /// The name of the participant set. Returned only, if the API caller is the sender of agreement
    /// </summary>
    /// <value>The name of the participant set. Returned only, if the API caller is the sender of agreement</value>
    [DataMember(Name="participantSetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "participantSetName")]
    public string ParticipantSetName { get; set; }

    /// <summary>
    /// The current roles of the participant set. A participant set can have one or more roles
    /// </summary>
    /// <value>The current roles of the participant set. A participant set can have one or more roles</value>
    [DataMember(Name="roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles")]
    public List<string> Roles { get; set; }

    /// <summary>
    /// Private message for the participants in the set
    /// </summary>
    /// <value>Private message for the participants in the set</value>
    [DataMember(Name="privateMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privateMessage")]
    public string PrivateMessage { get; set; }

    /// <summary>
    /// Security options that apply to the participant
    /// </summary>
    /// <value>Security options that apply to the participant</value>
    [DataMember(Name="securityOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityOptions")]
    public List<string> SecurityOptions { get; set; }

    /// <summary>
    /// The status of the participant set with respect to the document
    /// </summary>
    /// <value>The status of the participant set with respect to the document</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ParticipantSetInfo {\n");
      sb.Append("  SigningOrder: ").Append(SigningOrder).Append("\n");
      sb.Append("  ParticipantSetMemberInfos: ").Append(ParticipantSetMemberInfos).Append("\n");
      sb.Append("  ParticipantSetName: ").Append(ParticipantSetName).Append("\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
      sb.Append("  PrivateMessage: ").Append(PrivateMessage).Append("\n");
      sb.Append("  SecurityOptions: ").Append(SecurityOptions).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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

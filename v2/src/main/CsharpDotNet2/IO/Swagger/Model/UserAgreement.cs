using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V2.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserAgreement {
    /// <summary>
    /// The display date for the agreement
    /// </summary>
    /// <value>The display date for the agreement</value>
    [DataMember(Name="displayDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayDate")]
    public DateTime? DisplayDate { get; set; }

    /// <summary>
    /// The most relevant current user for the agreement. It is typically the next signer if the agreement is from the current user, or the sender if received from another user
    /// </summary>
    /// <value>The most relevant current user for the agreement. It is typically the next signer if the agreement is from the current user, or the sender if received from another user</value>
    [DataMember(Name="displayUserInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayUserInfo")]
    public DisplayUserInfo DisplayUserInfo { get; set; }

    /// <summary>
    /// True if this is an e-sign document
    /// </summary>
    /// <value>True if this is an e-sign document</value>
    [DataMember(Name="esign", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "esign")]
    public bool? Esign { get; set; }

    /// <summary>
    /// The unique identifier of the agreement
    /// </summary>
    /// <value>The unique identifier of the agreement</value>
    [DataMember(Name="agreementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agreementId")]
    public string AgreementId { get; set; }

    /// <summary>
    /// Name of the Agreement
    /// </summary>
    /// <value>Name of the Agreement</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A version ID which uniquely identifies the current version of the agreement
    /// </summary>
    /// <value>A version ID which uniquely identifies the current version of the agreement</value>
    [DataMember(Name="latestVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latestVersionId")]
    public string LatestVersionId { get; set; }

    /// <summary>
    /// The current status of the document from the perspective of the user
    /// </summary>
    /// <value>The current status of the document from the perspective of the user</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserAgreement {\n");
      sb.Append("  DisplayDate: ").Append(DisplayDate).Append("\n");
      sb.Append("  DisplayUserInfo: ").Append(DisplayUserInfo).Append("\n");
      sb.Append("  Esign: ").Append(Esign).Append("\n");
      sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  LatestVersionId: ").Append(LatestVersionId).Append("\n");
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

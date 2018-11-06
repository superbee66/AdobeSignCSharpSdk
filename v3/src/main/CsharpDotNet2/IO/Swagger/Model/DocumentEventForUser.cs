using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DocumentEventForUser {
    /// <summary>
    /// An ordered list of the events in the audit trail of this document
    /// </summary>
    /// <value>An ordered list of the events in the audit trail of this document</value>
    [DataMember(Name="documentHistoryEvent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentHistoryEvent")]
    public DocumentHistoryEvent DocumentHistoryEvent { get; set; }

    /// <summary>
    /// The name of the agreement asset
    /// </summary>
    /// <value>The name of the agreement asset</value>
    [DataMember(Name="agreementAssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agreementAssetName")]
    public string AgreementAssetName { get; set; }

    /// <summary>
    /// The ID of the agreement asset.
    /// </summary>
    /// <value>The ID of the agreement asset.</value>
    [DataMember(Name="agreementAssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agreementAssetId")]
    public string AgreementAssetId { get; set; }

    /// <summary>
    /// The type of the agreement asset
    /// </summary>
    /// <value>The type of the agreement asset</value>
    [DataMember(Name="agreementAssetType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agreementAssetType")]
    public string AgreementAssetType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentEventForUser {\n");
      sb.Append("  DocumentHistoryEvent: ").Append(DocumentHistoryEvent).Append("\n");
      sb.Append("  AgreementAssetName: ").Append(AgreementAssetName).Append("\n");
      sb.Append("  AgreementAssetId: ").Append(AgreementAssetId).Append("\n");
      sb.Append("  AgreementAssetType: ").Append(AgreementAssetType).Append("\n");
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

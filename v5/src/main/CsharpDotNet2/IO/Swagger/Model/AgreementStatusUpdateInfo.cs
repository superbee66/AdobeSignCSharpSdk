using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AgreementStatusUpdateInfo {
    /// <summary>
    /// Whether or not you would like the recipient to be notified that the transaction has been cancelled. The notification is mandatory if any party has already signed this document. The default value is false. In case the invoker is a signer, the flag has no effect.
    /// </summary>
    /// <value>Whether or not you would like the recipient to be notified that the transaction has been cancelled. The notification is mandatory if any party has already signed this document. The default value is false. In case the invoker is a signer, the flag has no effect.</value>
    [DataMember(Name="notifySigner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notifySigner")]
    public bool? NotifySigner { get; set; }

    /// <summary>
    /// An optional comment describing to the recipient why you want to cancel the transaction.  Mandatory if the caller is a signer.
    /// </summary>
    /// <value>An optional comment describing to the recipient why you want to cancel the transaction.  Mandatory if the caller is a signer.</value>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// The state to which the agreement is to be updated. The only valid state for this variable is currently, CANCEL
    /// </summary>
    /// <value>The state to which the agreement is to be updated. The only valid state for this variable is currently, CANCEL</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AgreementStatusUpdateInfo {\n");
      sb.Append("  NotifySigner: ").Append(NotifySigner).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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

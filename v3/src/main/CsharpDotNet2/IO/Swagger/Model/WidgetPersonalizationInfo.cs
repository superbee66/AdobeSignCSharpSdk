using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class WidgetPersonalizationInfo {
    /// <summary>
    /// Comment describing how the API caller established the signer's identity - will appear in the audit trail.
    /// </summary>
    /// <value>Comment describing how the API caller established the signer's identity - will appear in the audit trail.</value>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Expiration date for the personalization of this widget. After this date, the identity of the signer will not be assumed by Adobe Sign.
    /// </summary>
    /// <value>Expiration date for the personalization of this widget. After this date, the identity of the signer will not be assumed by Adobe Sign.</value>
    [DataMember(Name="expiration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiration")]
    public DateTime? Expiration { get; set; }

    /// <summary>
    /// Not used at this time
    /// </summary>
    /// <value>Not used at this time</value>
    [DataMember(Name="allowManualVerification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowManualVerification")]
    public bool? AllowManualVerification { get; set; }

    /// <summary>
    /// The email address of the person who will be receiving this widget
    /// </summary>
    /// <value>The email address of the person who will be receiving this widget</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Should the intended signer be allowed to sign this widget more than once
    /// </summary>
    /// <value>Should the intended signer be allowed to sign this widget more than once</value>
    [DataMember(Name="reusable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reusable")]
    public bool? Reusable { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetPersonalizationInfo {\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  Expiration: ").Append(Expiration).Append("\n");
      sb.Append("  AllowManualVerification: ").Append(AllowManualVerification).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Reusable: ").Append(Reusable).Append("\n");
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

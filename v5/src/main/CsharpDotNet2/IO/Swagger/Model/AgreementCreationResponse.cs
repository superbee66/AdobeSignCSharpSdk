using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model {

  /// <summary>
  /// A JSON  that contains both the id of the newly created agreement and URL / embedded code to direct the user to tne next step in the creation process.
  /// </summary>
  [DataContract]
  public class AgreementCreationResponse {
    /// <summary>
    /// Javascript snippet suitable for an embedded page taking a user to a URL
    /// </summary>
    /// <value>Javascript snippet suitable for an embedded page taking a user to a URL</value>
    [DataMember(Name="embeddedCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "embeddedCode")]
    public string EmbeddedCode { get; set; }

    /// <summary>
    /// The unique identifier that can be used to query status and download signed documents
    /// </summary>
    /// <value>The unique identifier that can be used to query status and download signed documents</value>
    [DataMember(Name="agreementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agreementId")]
    public string AgreementId { get; set; }

    /// <summary>
    /// Expiration date for autologin. This is based on the user setting, API_AUTO_LOGIN_LIFETIME
    /// </summary>
    /// <value>Expiration date for autologin. This is based on the user setting, API_AUTO_LOGIN_LIFETIME</value>
    [DataMember(Name="expiration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiration")]
    public DateTime? Expiration { get; set; }

    /// <summary>
    /// Standalone URL to direct end users to
    /// </summary>
    /// <value>Standalone URL to direct end users to</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AgreementCreationResponse {\n");
      sb.Append("  EmbeddedCode: ").Append(EmbeddedCode).Append("\n");
      sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
      sb.Append("  Expiration: ").Append(Expiration).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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

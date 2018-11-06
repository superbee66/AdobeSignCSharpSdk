using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AgreementAssetRequest {
    /// <summary>
    /// No Chrome Flag. If true, the embedded page is shown without a navigation header or footer. If false, the standard page header and footer will be present. By default its value is false
    /// </summary>
    /// <value>No Chrome Flag. If true, the embedded page is shown without a navigation header or footer. If false, the standard page header and footer will be present. By default its value is false</value>
    [DataMember(Name="noChrome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "noChrome")]
    public bool? NoChrome { get; set; }

    /// <summary>
    /// The ID of the agreement asset.
    /// </summary>
    /// <value>The ID of the agreement asset.</value>
    [DataMember(Name="agreementAssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agreementAssetId")]
    public string AgreementAssetId { get; set; }

    /// <summary>
    /// Auto LogIn Flag. If true, the URL returned will automatically log the user in. If false, the URL returned will require the credentials. By default its value is false
    /// </summary>
    /// <value>Auto LogIn Flag. If true, the URL returned will automatically log the user in. If false, the URL returned will require the credentials. By default its value is false</value>
    [DataMember(Name="autoLogin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoLogin")]
    public bool? AutoLogin { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AgreementAssetRequest {\n");
      sb.Append("  NoChrome: ").Append(NoChrome).Append("\n");
      sb.Append("  AgreementAssetId: ").Append(AgreementAssetId).Append("\n");
      sb.Append("  AutoLogin: ").Append(AutoLogin).Append("\n");
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

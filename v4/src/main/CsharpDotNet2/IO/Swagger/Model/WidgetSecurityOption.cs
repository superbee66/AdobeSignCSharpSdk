using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class WidgetSecurityOption {
    /// <summary>
    /// Signers need to pass Knowledge Based Authentication before they gain access to view and sign the widget.
    /// </summary>
    /// <value>Signers need to pass Knowledge Based Authentication before they gain access to view and sign the widget.</value>
    [DataMember(Name="kbaProtection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kbaProtection")]
    public string KbaProtection { get; set; }

    /// <summary>
    /// Specifies if signers are required to enter a password to have access to sign the widget.
    /// </summary>
    /// <value>Specifies if signers are required to enter a password to have access to sign the widget.</value>
    [DataMember(Name="passwordProtection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passwordProtection")]
    public string PasswordProtection { get; set; }

    /// <summary>
    /// Specifies if signers are required to provide their web identity, before they gain access to view and sign the widget.
    /// </summary>
    /// <value>Specifies if signers are required to provide their web identity, before they gain access to view and sign the widget.</value>
    [DataMember(Name="webIdentityProtection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webIdentityProtection")]
    public string WebIdentityProtection { get; set; }

    /// <summary>
    /// The secondary password that will be used to protect signing the widget for external signers. Note that Adobe Sign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. This password is applied only if password protection is specified for external signers or all signers
    /// </summary>
    /// <value>The secondary password that will be used to protect signing the widget for external signers. Note that Adobe Sign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. This password is applied only if password protection is specified for external signers or all signers</value>
    [DataMember(Name="externalPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalPassword")]
    public string ExternalPassword { get; set; }

    /// <summary>
    /// The secondary password that will be used to protect signing the widget for internal signers. Note that Adobe Sign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. This password is applied only if password protection is specified for internal signers or all signers
    /// </summary>
    /// <value>The secondary password that will be used to protect signing the widget for internal signers. Note that Adobe Sign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. This password is applied only if password protection is specified for internal signers or all signers</value>
    [DataMember(Name="internalPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internalPassword")]
    public string InternalPassword { get; set; }

    /// <summary>
    /// If set to true, the document is always be encrypted with this password every time it is sent by email. Recipients need to provide the password to be able to view the PDF files
    /// </summary>
    /// <value>If set to true, the document is always be encrypted with this password every time it is sent by email. Recipients need to provide the password to be able to view the PDF files</value>
    [DataMember(Name="protectOpen", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protectOpen")]
    public bool? ProtectOpen { get; set; }

    /// <summary>
    /// The secondary password that will be used to secure the PDF document. Note that Adobe Sign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. This password is used only if protectOpen field is set to true
    /// </summary>
    /// <value>The secondary password that will be used to secure the PDF document. Note that Adobe Sign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. This password is used only if protectOpen field is set to true</value>
    [DataMember(Name="openPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openPassword")]
    public string OpenPassword { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetSecurityOption {\n");
      sb.Append("  KbaProtection: ").Append(KbaProtection).Append("\n");
      sb.Append("  PasswordProtection: ").Append(PasswordProtection).Append("\n");
      sb.Append("  WebIdentityProtection: ").Append(WebIdentityProtection).Append("\n");
      sb.Append("  ExternalPassword: ").Append(ExternalPassword).Append("\n");
      sb.Append("  InternalPassword: ").Append(InternalPassword).Append("\n");
      sb.Append("  ProtectOpen: ").Append(ProtectOpen).Append("\n");
      sb.Append("  OpenPassword: ").Append(OpenPassword).Append("\n");
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

using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SecurityOption {
    /// <summary>
    /// Signers need to pass Knowledge Based Authentication before they gain access to view and sign the document.
    /// </summary>
    /// <value>Signers need to pass Knowledge Based Authentication before they gain access to view and sign the document.</value>
    [DataMember(Name="kbaProtection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kbaProtection")]
    public string KbaProtection { get; set; }

    /// <summary>
    /// The secondary password that is used to secure the document. Note that Adobe Sign never displays this password. You need to communicate this password to the appropriate users. Note: This field is required if either sign or open password option was set
    /// </summary>
    /// <value>The secondary password that is used to secure the document. Note that Adobe Sign never displays this password. You need to communicate this password to the appropriate users. Note: This field is required if either sign or open password option was set</value>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    /// <summary>
    /// Specifies if signers are required to enter a password to have access to sign the document.
    /// </summary>
    /// <value>Specifies if signers are required to enter a password to have access to sign the document.</value>
    [DataMember(Name="passwordProtection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passwordProtection")]
    public string PasswordProtection { get; set; }

    /// <summary>
    /// Specifies if signers are required to provide their web identity, before they gain access to view and sign the document.
    /// </summary>
    /// <value>Specifies if signers are required to provide their web identity, before they gain access to view and sign the document.</value>
    [DataMember(Name="webIdentityProtection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webIdentityProtection")]
    public string WebIdentityProtection { get; set; }

    /// <summary>
    /// If set to true, the document is always be encrypted with this password every time it is sent by email. Recipients need to provide the password to be able to view the PDF files
    /// </summary>
    /// <value>If set to true, the document is always be encrypted with this password every time it is sent by email. Recipients need to provide the password to be able to view the PDF files</value>
    [DataMember(Name="protectOpen", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protectOpen")]
    public bool? ProtectOpen { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SecurityOption {\n");
      sb.Append("  KbaProtection: ").Append(KbaProtection).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  PasswordProtection: ").Append(PasswordProtection).Append("\n");
      sb.Append("  WebIdentityProtection: ").Append(WebIdentityProtection).Append("\n");
      sb.Append("  ProtectOpen: ").Append(ProtectOpen).Append("\n");
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

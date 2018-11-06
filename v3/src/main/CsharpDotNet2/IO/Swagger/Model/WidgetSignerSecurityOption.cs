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
  public class WidgetSignerSecurityOption {
    /// <summary>
    /// The password required for the recipient to view and sign the widget
    /// </summary>
    /// <value>The password required for the recipient to view and sign the widget</value>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    /// <summary>
    /// The authentication method for the recipients to have access to view and sign the widget. PHONE authentication is only applicable to counter signers but not to widget signer
    /// </summary>
    /// <value>The authentication method for the recipients to have access to view and sign the widget. PHONE authentication is only applicable to counter signers but not to widget signer</value>
    [DataMember(Name="authenticationMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationMethod")]
    public string AuthenticationMethod { get; set; }

    /// <summary>
    /// The phoneInfo required for the counter signer to view and sign the widget if authentication method is PHONE. Not applicable to widget signer
    /// </summary>
    /// <value>The phoneInfo required for the counter signer to view and sign the widget if authentication method is PHONE. Not applicable to widget signer</value>
    [DataMember(Name="phoneInfos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phoneInfos")]
    public List<PhoneInfo> PhoneInfos { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetSignerSecurityOption {\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
      sb.Append("  PhoneInfos: ").Append(PhoneInfos).Append("\n");
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

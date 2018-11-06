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
  public class SigningUrl {
    /// <summary>
    /// The authenticated secure url for the regular e-sign page for this signer
    /// </summary>
    /// <value>The authenticated secure url for the regular e-sign page for this signer</value>
    [DataMember(Name="esignUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "esignUrl")]
    public string EsignUrl { get; set; }

    /// <summary>
    /// The email address of the signer associated with this signing url
    /// </summary>
    /// <value>The email address of the signer associated with this signing url</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SigningUrl {\n");
      sb.Append("  EsignUrl: ").Append(EsignUrl).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
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
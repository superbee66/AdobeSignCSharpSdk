using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V2.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class RecipientInfo {
    /// <summary>
    /// Specify the role of recipient
    /// </summary>
    /// <value>Specify the role of recipient</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }

    /// <summary>
    /// Fax of the recipient. This is required if email is not provided. Both fax and email can not be provided
    /// </summary>
    /// <value>Fax of the recipient. This is required if email is not provided. Both fax and email can not be provided</value>
    [DataMember(Name="fax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fax")]
    public string Fax { get; set; }

    /// <summary>
    /// Security options that apply to the recipient
    /// </summary>
    /// <value>Security options that apply to the recipient</value>
    [DataMember(Name="securityOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityOptions")]
    public List<RecipientSecurityOption> SecurityOptions { get; set; }

    /// <summary>
    /// Email of the recipient. This is required if fax is not provided. Both fax and email can not be provided
    /// </summary>
    /// <value>Email of the recipient. This is required if fax is not provided. Both fax and email can not be provided</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RecipientInfo {\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
      sb.Append("  Fax: ").Append(Fax).Append("\n");
      sb.Append("  SecurityOptions: ").Append(SecurityOptions).Append("\n");
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

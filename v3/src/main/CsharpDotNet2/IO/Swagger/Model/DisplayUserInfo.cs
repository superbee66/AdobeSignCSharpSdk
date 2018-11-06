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
  public class DisplayUserInfo {
    /// <summary>
    /// Displays the name of the company of the user, if available
    /// </summary>
    /// <value>Displays the name of the company of the user, if available</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// Displays the full name of the user, if available. Displays the email address if the name is not available
    /// </summary>
    /// <value>Displays the full name of the user, if available. Displays the email address if the name is not available</value>
    [DataMember(Name="fullNameOrEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullNameOrEmail")]
    public string FullNameOrEmail { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DisplayUserInfo {\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  FullNameOrEmail: ").Append(FullNameOrEmail).Append("\n");
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

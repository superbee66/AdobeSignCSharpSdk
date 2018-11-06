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
  public class MegaSignCreationRequest {
    /// <summary>
    /// Information about the MegaSign you want to send
    /// </summary>
    /// <value>Information about the MegaSign you want to send</value>
    [DataMember(Name="megaSignCreationInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "megaSignCreationInfo")]
    public MegaSignCreationInfo MegaSignCreationInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MegaSignCreationRequest {\n");
      sb.Append("  MegaSignCreationInfo: ").Append(MegaSignCreationInfo).Append("\n");
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

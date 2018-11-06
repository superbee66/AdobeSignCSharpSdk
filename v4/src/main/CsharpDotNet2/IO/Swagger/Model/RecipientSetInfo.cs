using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class RecipientSetInfo {
    /// <summary>
    /// Information about the members of the recipient set
    /// </summary>
    /// <value>Information about the members of the recipient set</value>
    [DataMember(Name="recipientSetMemberInfos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipientSetMemberInfos")]
    public List<RecipientInfo> RecipientSetMemberInfos { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RecipientSetInfo {\n");
      sb.Append("  RecipientSetMemberInfos: ").Append(RecipientSetMemberInfos).Append("\n");
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

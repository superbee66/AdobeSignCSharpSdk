using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CounterSignerSetInfo {
    /// <summary>
    /// Specify the role of counter signer set
    /// </summary>
    /// <value>Specify the role of counter signer set</value>
    [DataMember(Name="counterSignerSetRole", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterSignerSetRole")]
    public string CounterSignerSetRole { get; set; }

    /// <summary>
    /// Information about the members of the counter signer set, currently we support only one member
    /// </summary>
    /// <value>Information about the members of the counter signer set, currently we support only one member</value>
    [DataMember(Name="counterSignerSetMemberInfos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counterSignerSetMemberInfos")]
    public List<CounterSignerInfo> CounterSignerSetMemberInfos { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CounterSignerSetInfo {\n");
      sb.Append("  CounterSignerSetRole: ").Append(CounterSignerSetRole).Append("\n");
      sb.Append("  CounterSignerSetMemberInfos: ").Append(CounterSignerSetMemberInfos).Append("\n");
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

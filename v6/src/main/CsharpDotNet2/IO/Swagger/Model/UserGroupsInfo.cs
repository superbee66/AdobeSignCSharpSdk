using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserGroupsInfo {
    /// <summary>
    /// The list of groups for given user.
    /// </summary>
    /// <value>The list of groups for given user.</value>
    [DataMember(Name="groupInfoList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupInfoList")]
    public List<UserGroupInfo> GroupInfoList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserGroupsInfo {\n");
      sb.Append("  GroupInfoList: ").Append(GroupInfoList).Append("\n");
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

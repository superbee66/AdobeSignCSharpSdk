using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserWidgets {
    /// <summary>
    /// An array of widget items
    /// </summary>
    /// <value>An array of widget items</value>
    [DataMember(Name="userWidgetList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userWidgetList")]
    public List<UserWidget> UserWidgetList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserWidgets {\n");
      sb.Append("  UserWidgetList: ").Append(UserWidgetList).Append("\n");
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

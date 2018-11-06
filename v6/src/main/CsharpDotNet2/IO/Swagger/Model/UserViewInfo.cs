using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserViewInfo {
    /// <summary>
    /// Common view configuration for all the available views
    /// </summary>
    /// <value>Common view configuration for all the available views</value>
    [DataMember(Name="commonViewConfiguration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commonViewConfiguration")]
    public CommonViewConfiguration CommonViewConfiguration { get; set; }

    /// <summary>
    /// Name of the requested user view
    /// </summary>
    /// <value>Name of the requested user view</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserViewInfo {\n");
      sb.Append("  CommonViewConfiguration: ").Append(CommonViewConfiguration).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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

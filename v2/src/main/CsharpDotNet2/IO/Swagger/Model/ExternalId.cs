using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V2.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ExternalId {
    /// <summary>
    /// Only supported value for the ExternalID namespace at this time is API_OTHER
    /// </summary>
    /// <value>Only supported value for the ExternalID namespace at this time is API_OTHER</value>
    [DataMember(Name="namespace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "namespace")]
    public string _Namespace { get; set; }

    /// <summary>
    /// An arbitrary value from your system, which can be specified at sending time and then later returned or queried
    /// </summary>
    /// <value>An arbitrary value from your system, which can be specified at sending time and then later returned or queried</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// An arbitrary value from your system, which can be specified at sending time and then later returned or queried
    /// </summary>
    /// <value>An arbitrary value from your system, which can be specified at sending time and then later returned or queried</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public string Group { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExternalId {\n");
      sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
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

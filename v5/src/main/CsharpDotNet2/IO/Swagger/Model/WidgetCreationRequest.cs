using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class WidgetCreationRequest {
    /// <summary>
    /// Information about the widget that you want to create.
    /// </summary>
    /// <value>Information about the widget that you want to create.</value>
    [DataMember(Name="widgetCreationInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "widgetCreationInfo")]
    public WidgetCreationInfo WidgetCreationInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetCreationRequest {\n");
      sb.Append("  WidgetCreationInfo: ").Append(WidgetCreationInfo).Append("\n");
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

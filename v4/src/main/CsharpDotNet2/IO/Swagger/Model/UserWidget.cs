using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserWidget {
    /// <summary>
    /// The unique identifier of a widget
    /// </summary>
    /// <value>The unique identifier of a widget</value>
    [DataMember(Name="widgetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "widgetId")]
    public string WidgetId { get; set; }

    /// <summary>
    /// The day on which the widget was last modified
    /// </summary>
    /// <value>The day on which the widget was last modified</value>
    [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifiedDate")]
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// The name of the widget.
    /// </summary>
    /// <value>The name of the widget.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The embedded javascript code of the widget
    /// </summary>
    /// <value>The embedded javascript code of the widget</value>
    [DataMember(Name="javascript", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "javascript")]
    public string Javascript { get; set; }

    /// <summary>
    /// The hosted url of the widget
    /// </summary>
    /// <value>The hosted url of the widget</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// The widget status (enabled or disabled or aborted or other)
    /// </summary>
    /// <value>The widget status (enabled or disabled or aborted or other)</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserWidget {\n");
      sb.Append("  WidgetId: ").Append(WidgetId).Append("\n");
      sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Javascript: ").Append(Javascript).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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

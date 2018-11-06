using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class WidgetInfo {
    /// <summary>
    /// Information about the participant sets of the widget.
    /// </summary>
    /// <value>Information about the participant sets of the widget.</value>
    [DataMember(Name="participantSetInfos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "participantSetInfos")]
    public List<WidgetParticipantSetInfo> ParticipantSetInfos { get; set; }

    /// <summary>
    /// A resource identifier that can be used to uniquely identify the widget in other apis
    /// </summary>
    /// <value>A resource identifier that can be used to uniquely identify the widget in other apis</value>
    [DataMember(Name="widgetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "widgetId")]
    public string WidgetId { get; set; }

    /// <summary>
    /// The widget name specified by the sender
    /// </summary>
    /// <value>The widget name specified by the sender</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// An ID which uniquely identifies the current version of the widget
    /// </summary>
    /// <value>An ID which uniquely identifies the current version of the widget</value>
    [DataMember(Name="latestVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latestVersionId")]
    public string LatestVersionId { get; set; }

    /// <summary>
    /// The locale associated with this widget - for example, en_US or fr_FR
    /// </summary>
    /// <value>The locale associated with this widget - for example, en_US or fr_FR</value>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// The message associated with the widget that the sender has provided
    /// </summary>
    /// <value>The message associated with the widget that the sender has provided</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Security information about the widget that specifies whether or not a password is required to view and sign the widget
    /// </summary>
    /// <value>Security information about the widget that specifies whether or not a password is required to view and sign the widget</value>
    [DataMember(Name="securityOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityOptions")]
    public List<string> SecurityOptions { get; set; }

    /// <summary>
    /// An ordered list of the events in the audit trail of this widget
    /// </summary>
    /// <value>An ordered list of the events in the audit trail of this widget</value>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<WidgetHistoryEvent> Events { get; set; }

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
    /// The current status of the widget
    /// </summary>
    /// <value>The current status of the widget</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetInfo {\n");
      sb.Append("  ParticipantSetInfos: ").Append(ParticipantSetInfos).Append("\n");
      sb.Append("  WidgetId: ").Append(WidgetId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  LatestVersionId: ").Append(LatestVersionId).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  SecurityOptions: ").Append(SecurityOptions).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
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

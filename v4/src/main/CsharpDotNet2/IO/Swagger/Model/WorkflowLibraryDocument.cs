using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class WorkflowLibraryDocument {
    /// <summary>
    /// An id of the workflow library document that can be provided as an input file in the custom workflow agreement creation request
    /// </summary>
    /// <value>An id of the workflow library document that can be provided as an input file in the custom workflow agreement creation request</value>
    [DataMember(Name="workflowLibDoc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workflowLibDoc")]
    public string WorkflowLibDoc { get; set; }

    /// <summary>
    /// A display text for this form for workflow users
    /// </summary>
    /// <value>A display text for this form for workflow users</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WorkflowLibraryDocument {\n");
      sb.Append("  WorkflowLibDoc: ").Append(WorkflowLibDoc).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
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

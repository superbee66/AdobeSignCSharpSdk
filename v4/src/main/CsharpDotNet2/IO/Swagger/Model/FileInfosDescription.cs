using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FileInfosDescription {
    /// <summary>
    /// Name of the fileInfo element
    /// </summary>
    /// <value>Name of the fileInfo element</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A list of workflow library documents out of which one workflow library document can be selected with this fileInfo object
    /// </summary>
    /// <value>A list of workflow library documents out of which one workflow library document can be selected with this fileInfo object</value>
    [DataMember(Name="workflowLibraryDocumentSelectorList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workflowLibraryDocumentSelectorList")]
    public List<WorkflowLibraryDocument> WorkflowLibraryDocumentSelectorList { get; set; }

    /// <summary>
    /// Display label of this field for the external users
    /// </summary>
    /// <value>Display label of this field for the external users</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// Whether this field is required or optional
    /// </summary>
    /// <value>Whether this field is required or optional</value>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FileInfosDescription {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  WorkflowLibraryDocumentSelectorList: ").Append(WorkflowLibraryDocumentSelectorList).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
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

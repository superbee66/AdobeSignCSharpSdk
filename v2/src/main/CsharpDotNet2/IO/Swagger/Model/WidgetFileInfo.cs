using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class WidgetFileInfo {
    /// <summary>
    /// The name of a library document that is available to the sender. Note only applicable when used as formFieldLayerTemplates
    /// </summary>
    /// <value>The name of a library document that is available to the sender. Note only applicable when used as formFieldLayerTemplates</value>
    [DataMember(Name="libraryDocumentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "libraryDocumentName")]
    public string LibraryDocumentName { get; set; }

    /// <summary>
    /// The documentID as returned from the transient document creation API
    /// </summary>
    /// <value>The documentID as returned from the transient document creation API</value>
    [DataMember(Name="transientDocumentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transientDocumentId")]
    public string TransientDocumentId { get; set; }

    /// <summary>
    /// File at a public URL location
    /// </summary>
    /// <value>File at a public URL location</value>
    [DataMember(Name="documentURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentURL")]
    public WidgetURLFileInfo DocumentURL { get; set; }

    /// <summary>
    /// The ID for a library document that is available to the sender. Note only applicable when used as formFieldLayerTemplates
    /// </summary>
    /// <value>The ID for a library document that is available to the sender. Note only applicable when used as formFieldLayerTemplates</value>
    [DataMember(Name="libraryDocumentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "libraryDocumentId")]
    public string LibraryDocumentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetFileInfo {\n");
      sb.Append("  LibraryDocumentName: ").Append(LibraryDocumentName).Append("\n");
      sb.Append("  TransientDocumentId: ").Append(TransientDocumentId).Append("\n");
      sb.Append("  DocumentURL: ").Append(DocumentURL).Append("\n");
      sb.Append("  LibraryDocumentId: ").Append(LibraryDocumentId).Append("\n");
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
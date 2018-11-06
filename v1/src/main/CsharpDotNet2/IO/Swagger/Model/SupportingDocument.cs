using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V1.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SupportingDocument {
    /// <summary>
    /// Display name of the document
    /// </summary>
    /// <value>Display name of the document</value>
    [DataMember(Name="displayLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayLabel")]
    public string DisplayLabel { get; set; }

    /// <summary>
    /// The name of the supporting document field
    /// </summary>
    /// <value>The name of the supporting document field</value>
    [DataMember(Name="fieldName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldName")]
    public string FieldName { get; set; }

    /// <summary>
    /// Id representing the document
    /// </summary>
    /// <value>Id representing the document</value>
    [DataMember(Name="supportingDocumentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supportingDocumentId")]
    public string SupportingDocumentId { get; set; }

    /// <summary>
    /// Mime-type of the document
    /// </summary>
    /// <value>Mime-type of the document</value>
    [DataMember(Name="mimeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mimeType")]
    public string MimeType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SupportingDocument {\n");
      sb.Append("  DisplayLabel: ").Append(DisplayLabel).Append("\n");
      sb.Append("  FieldName: ").Append(FieldName).Append("\n");
      sb.Append("  SupportingDocumentId: ").Append(SupportingDocumentId).Append("\n");
      sb.Append("  MimeType: ").Append(MimeType).Append("\n");
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

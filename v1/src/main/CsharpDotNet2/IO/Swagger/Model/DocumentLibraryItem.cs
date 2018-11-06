using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V1.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DocumentLibraryItem {
    /// <summary>
    /// The scope of visibility of the library document
    /// </summary>
    /// <value>The scope of visibility of the library document</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public string Scope { get; set; }

    /// <summary>
    /// The day on which the library document was last modified
    /// </summary>
    /// <value>The day on which the library document was last modified</value>
    [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifiedDate")]
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// The name of the library document
    /// </summary>
    /// <value>The name of the library document</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The unique identifier of the library document used when sending the document to be signed
    /// </summary>
    /// <value>The unique identifier of the library document used when sending the document to be signed</value>
    [DataMember(Name="libraryDocumentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "libraryDocumentId")]
    public string LibraryDocumentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentLibraryItem {\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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

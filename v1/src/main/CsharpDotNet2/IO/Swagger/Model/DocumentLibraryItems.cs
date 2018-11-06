using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V1.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DocumentLibraryItems {
    /// <summary>
    /// An array of document library items
    /// </summary>
    /// <value>An array of document library items</value>
    [DataMember(Name="libraryDocumentList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "libraryDocumentList")]
    public List<DocumentLibraryItem> LibraryDocumentList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentLibraryItems {\n");
      sb.Append("  LibraryDocumentList: ").Append(LibraryDocumentList).Append("\n");
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

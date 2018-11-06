using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class LibraryDocumentViewResponse {
    /// <summary>
    /// List of library docuemnt views
    /// </summary>
    /// <value>List of library docuemnt views</value>
    [DataMember(Name="libraryViewList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "libraryViewList")]
    public List<LibraryView> LibraryViewList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LibraryDocumentViewResponse {\n");
      sb.Append("  LibraryViewList: ").Append(LibraryViewList).Append("\n");
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

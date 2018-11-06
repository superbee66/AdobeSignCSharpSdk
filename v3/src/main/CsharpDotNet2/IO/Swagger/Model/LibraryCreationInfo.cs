using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class LibraryCreationInfo {
    /// <summary>
    /// Options for authoring and sending the agreement
    /// </summary>
    /// <value>Options for authoring and sending the agreement</value>
    [DataMember(Name="options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "options")]
    public InteractiveOptions Options { get; set; }

    /// <summary>
    /// Information about the library document you want to create
    /// </summary>
    /// <value>Information about the library document you want to create</value>
    [DataMember(Name="libraryDocumentCreationInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "libraryDocumentCreationInfo")]
    public LibraryDocumentCreationInfo LibraryDocumentCreationInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LibraryCreationInfo {\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
      sb.Append("  LibraryDocumentCreationInfo: ").Append(LibraryDocumentCreationInfo).Append("\n");
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

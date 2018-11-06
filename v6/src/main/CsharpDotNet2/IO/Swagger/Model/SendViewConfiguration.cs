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
  public class SendViewConfiguration {
    /// <summary>
    /// Controls various file upload options available on the compose page
    /// </summary>
    /// <value>Controls various file upload options available on the compose page</value>
    [DataMember(Name="fileUploadOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileUploadOptions")]
    public FileUploadOptions FileUploadOptions { get; set; }

    /// <summary>
    /// Should the compose page be provided with authoring mode selected?
    /// </summary>
    /// <value>Should the compose page be provided with authoring mode selected?</value>
    [DataMember(Name="isPreviewSelected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPreviewSelected")]
    public bool? IsPreviewSelected { get; set; }

    /// <summary>
    /// The agreement name for the library document on the compose page
    /// </summary>
    /// <value>The agreement name for the library document on the compose page</value>
    [DataMember(Name="agrName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agrName")]
    public string AgrName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SendViewConfiguration {\n");
      sb.Append("  FileUploadOptions: ").Append(FileUploadOptions).Append("\n");
      sb.Append("  IsPreviewSelected: ").Append(IsPreviewSelected).Append("\n");
      sb.Append("  AgrName: ").Append(AgrName).Append("\n");
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

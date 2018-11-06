using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V1.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class InteractiveOptions {
    /// <summary>
    /// Indicates that authoring is requested prior to sending the document
    /// </summary>
    /// <value>Indicates that authoring is requested prior to sending the document</value>
    [DataMember(Name="authoringRequested", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authoringRequested")]
    public bool? AuthoringRequested { get; set; }

    /// <summary>
    /// If user settings allow, automatically logs the user in
    /// </summary>
    /// <value>If user settings allow, automatically logs the user in</value>
    [DataMember(Name="autoLoginUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoLoginUser")]
    public bool? AutoLoginUser { get; set; }

    /// <summary>
    /// Turn off Chrome for the URL generated
    /// </summary>
    /// <value>Turn off Chrome for the URL generated</value>
    [DataMember(Name="noChrome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "noChrome")]
    public bool? NoChrome { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InteractiveOptions {\n");
      sb.Append("  AuthoringRequested: ").Append(AuthoringRequested).Append("\n");
      sb.Append("  AutoLoginUser: ").Append(AutoLoginUser).Append("\n");
      sb.Append("  NoChrome: ").Append(NoChrome).Append("\n");
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

using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V2.Model {

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
    /// A url to send page will be returned from where the agreement creation needs to be completed. All the parameters provided here will be retained in the send page
    /// </summary>
    /// <value>A url to send page will be returned from where the agreement creation needs to be completed. All the parameters provided here will be retained in the send page</value>
    [DataMember(Name="sendThroughWeb", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sendThroughWeb")]
    public bool? SendThroughWeb { get; set; }

    /// <summary>
    /// A JSON object of Type SendThroughWebOptions to customize the sendPage. This one will apply only if sendThroughWeb is set to true
    /// </summary>
    /// <value>A JSON object of Type SendThroughWebOptions to customize the sendPage. This one will apply only if sendThroughWeb is set to true</value>
    [DataMember(Name="sendThroughWebOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sendThroughWebOptions")]
    public SendThroughWebOptions SendThroughWebOptions { get; set; }

    /// <summary>
    /// The locale in which page returned by this API should be shown in - for example, en_US or fr_FR. In case locale provided by client is not available or no locale is specified, page will be shown in the default language set in the user account
    /// </summary>
    /// <value>The locale in which page returned by this API should be shown in - for example, en_US or fr_FR. In case locale provided by client is not available or no locale is specified, page will be shown in the default language set in the user account</value>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }


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
      sb.Append("  SendThroughWeb: ").Append(SendThroughWeb).Append("\n");
      sb.Append("  SendThroughWebOptions: ").Append(SendThroughWebOptions).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
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

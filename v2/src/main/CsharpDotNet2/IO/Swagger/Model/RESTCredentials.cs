using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V2.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class RESTCredentials {
    /// <summary>
    /// The application identifier and secret
    /// </summary>
    /// <value>The application identifier and secret</value>
    [DataMember(Name="applicationCredentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationCredentials")]
    public ApplicationCredentials ApplicationCredentials { get; set; }

    /// <summary>
    /// The user's credentials. Either an API key, or an email-password combination should be provided
    /// </summary>
    /// <value>The user's credentials. Either an API key, or an email-password combination should be provided</value>
    [DataMember(Name="userCredentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userCredentials")]
    public UserCredentials UserCredentials { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RESTCredentials {\n");
      sb.Append("  ApplicationCredentials: ").Append(ApplicationCredentials).Append("\n");
      sb.Append("  UserCredentials: ").Append(UserCredentials).Append("\n");
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

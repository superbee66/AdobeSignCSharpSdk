using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V1.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AccessToken {
    /// <summary>
    /// The time remaining, in seconds, before the access token expires and a new one needs to be issued
    /// </summary>
    /// <value>The time remaining, in seconds, before the access token expires and a new one needs to be issued</value>
    [DataMember(Name="expiresIn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiresIn")]
    public long? ExpiresIn { get; set; }

    /// <summary>
    /// The issued access token that has a validity of 14 days
    /// </summary>
    /// <value>The issued access token that has a validity of 14 days</value>
    [DataMember(Name="accessToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessToken")]
    public string _AccessToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessToken {\n");
      sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
      sb.Append("  _AccessToken: ").Append(_AccessToken).Append("\n");
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

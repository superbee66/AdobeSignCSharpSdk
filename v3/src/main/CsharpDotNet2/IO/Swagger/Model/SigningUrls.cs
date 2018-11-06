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
  public class SigningUrls {
    /// <summary>
    /// An array of urls for current signers.
    /// </summary>
    /// <value>An array of urls for current signers.</value>
    [DataMember(Name="signingUrls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signingUrls")]
    public List<SigningUrl> _SigningUrls { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SigningUrls {\n");
      sb.Append("  _SigningUrls: ").Append(_SigningUrls).Append("\n");
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

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
  public class UserCreationResponse {
    /// <summary>
    /// Status of the user
    /// </summary>
    /// <value>Status of the user</value>
    [DataMember(Name="userStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userStatus")]
    public string UserStatus { get; set; }

    /// <summary>
    /// The unique identifier for user in REST APIs. This identifier will not be compatible with any existing SOAP APIs and is different from user key that SOAP APIs provide and consume. userid being provided here and userkey that SOAP uses are different and the two can not be interchanged with each other
    /// </summary>
    /// <value>The unique identifier for user in REST APIs. This identifier will not be compatible with any existing SOAP APIs and is different from user key that SOAP APIs provide and consume. userid being provided here and userkey that SOAP uses are different and the two can not be interchanged with each other</value>
    [DataMember(Name="userId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userId")]
    public string UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserCreationResponse {\n");
      sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
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

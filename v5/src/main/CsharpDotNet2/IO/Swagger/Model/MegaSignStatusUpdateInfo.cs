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
  public class MegaSignStatusUpdateInfo {
    /// <summary>
    /// Whether or not you would like the recipient to be notified that the transaction has been cancelled. The default value is false
    /// </summary>
    /// <value>Whether or not you would like the recipient to be notified that the transaction has been cancelled. The default value is false</value>
    [DataMember(Name="notifySigner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notifySigner")]
    public bool? NotifySigner { get; set; }

    /// <summary>
    /// Comment describing to the recipient why you want to cancel the transaction
    /// </summary>
    /// <value>Comment describing to the recipient why you want to cancel the transaction</value>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// The state to which the megaSign is to be updated. The only valid state for this variable is currently, CANCEL
    /// </summary>
    /// <value>The state to which the megaSign is to be updated. The only valid state for this variable is currently, CANCEL</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MegaSignStatusUpdateInfo {\n");
      sb.Append("  NotifySigner: ").Append(NotifySigner).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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

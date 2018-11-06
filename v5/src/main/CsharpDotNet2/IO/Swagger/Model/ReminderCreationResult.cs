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
  public class ReminderCreationResult {
    /// <summary>
    /// A status value indicating the result of the operation
    /// </summary>
    /// <value>A status value indicating the result of the operation</value>
    [DataMember(Name="result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "result")]
    public string Result { get; set; }

    /// <summary>
    /// The info of the party (participant sets) that was reminded.
    /// </summary>
    /// <value>The info of the party (participant sets) that was reminded.</value>
    [DataMember(Name="participantEmailsSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "participantEmailsSet")]
    public List<ParticipantEmailSetInfo> ParticipantEmailsSet { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReminderCreationResult {\n");
      sb.Append("  Result: ").Append(Result).Append("\n");
      sb.Append("  ParticipantEmailsSet: ").Append(ParticipantEmailsSet).Append("\n");
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
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
  public class MegaSignChildAgreement {
    /// <summary>
    /// The display date for the agreement
    /// </summary>
    /// <value>The display date for the agreement</value>
    [DataMember(Name="displayDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayDate")]
    public DateTime? DisplayDate { get; set; }

    /// <summary>
    /// True if this is an e-sign document
    /// </summary>
    /// <value>True if this is an e-sign document</value>
    [DataMember(Name="esign", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "esign")]
    public bool? Esign { get; set; }

    /// <summary>
    /// The unique identifier of the agreement
    /// </summary>
    /// <value>The unique identifier of the agreement</value>
    [DataMember(Name="agreementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agreementId")]
    public string AgreementId { get; set; }

    /// <summary>
    /// Name of the Agreement
    /// </summary>
    /// <value>Name of the Agreement</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The current status of the agreement from the perspective of the user
    /// </summary>
    /// <value>The current status of the agreement from the perspective of the user</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MegaSignChildAgreement {\n");
      sb.Append("  DisplayDate: ").Append(DisplayDate).Append("\n");
      sb.Append("  Esign: ").Append(Esign).Append("\n");
      sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
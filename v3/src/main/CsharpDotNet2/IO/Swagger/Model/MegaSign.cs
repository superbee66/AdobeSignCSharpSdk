using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class MegaSign {
    /// <summary>
    /// The display date for the MegaSign parent agreement
    /// </summary>
    /// <value>The display date for the MegaSign parent agreement</value>
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
    /// Name of the MegaSign parent agreement
    /// </summary>
    /// <value>Name of the MegaSign parent agreement</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Unique identifier of the MegaSign parent agreement
    /// </summary>
    /// <value>Unique identifier of the MegaSign parent agreement</value>
    [DataMember(Name="megaSignId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "megaSignId")]
    public string MegaSignId { get; set; }

    /// <summary>
    /// Current status of the MegaSign parent agreement from the perspective of the user
    /// </summary>
    /// <value>Current status of the MegaSign parent agreement from the perspective of the user</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MegaSign {\n");
      sb.Append("  DisplayDate: ").Append(DisplayDate).Append("\n");
      sb.Append("  Esign: ").Append(Esign).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  MegaSignId: ").Append(MegaSignId).Append("\n");
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

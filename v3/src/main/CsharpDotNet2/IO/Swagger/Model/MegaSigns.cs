using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class MegaSigns {
    /// <summary>
    /// An array of MegaSign parent agreements
    /// </summary>
    /// <value>An array of MegaSign parent agreements</value>
    [DataMember(Name="megaSignList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "megaSignList")]
    public List<MegaSign> MegaSignList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MegaSigns {\n");
      sb.Append("  MegaSignList: ").Append(MegaSignList).Append("\n");
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

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
  public class ViewUrl {
    /// <summary>
    /// The output URL of the selected view.
    /// </summary>
    /// <value>The output URL of the selected view.</value>
    [DataMember(Name="viewURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "viewURL")]
    public string _ViewURL { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ViewUrl {\n");
      sb.Append("  _ViewURL: ").Append(_ViewURL).Append("\n");
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

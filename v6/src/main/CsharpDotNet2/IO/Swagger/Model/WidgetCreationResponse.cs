using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model {

  /// <summary>
  /// A JSON object describing the widget
  /// </summary>
  [DataContract]
  public class WidgetCreationResponse {
    /// <summary>
    /// The unique identifier of widget which can be used to retrieve the data entered by the signers.
    /// </summary>
    /// <value>The unique identifier of widget which can be used to retrieve the data entered by the signers.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetCreationResponse {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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

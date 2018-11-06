using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V2.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FormFieldCondition {
    /// <summary>
    /// Index of the location of the whenField whose value is the basis of the condition
    /// </summary>
    /// <value>Index of the location of the whenField whose value is the basis of the condition</value>
    [DataMember(Name="whenFieldLocationIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "whenFieldLocationIndex")]
    public int WhenFieldLocationIndex { get; set; }

    /// <summary>
    /// Value to compare the value of the whenField with, to evaluate the condition
    /// </summary>
    /// <value>Value to compare the value of the whenField with, to evaluate the condition</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Operator to be applied on the value of the whenField. 
    /// </summary>
    /// <value>Operator to be applied on the value of the whenField. </value>
    [DataMember(Name="operator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operator")]
    public string _Operator { get; set; }

    /// <summary>
    /// Name of the field whose value is the basis of condition
    /// </summary>
    /// <value>Name of the field whose value is the basis of condition</value>
    [DataMember(Name="whenFieldName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "whenFieldName")]
    public string WhenFieldName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FormFieldCondition {\n");
      sb.Append("  WhenFieldLocationIndex: ").Append(WhenFieldLocationIndex).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  _Operator: ").Append(_Operator).Append("\n");
      sb.Append("  WhenFieldName: ").Append(WhenFieldName).Append("\n");
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

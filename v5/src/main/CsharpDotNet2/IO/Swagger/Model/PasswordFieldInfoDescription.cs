using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PasswordFieldInfoDescription {
    /// <summary>
    /// Whether password info field is visible on agreement creation page
    /// </summary>
    /// <value>Whether password info field is visible on agreement creation page</value>
    [DataMember(Name="visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible")]
    public bool? Visible { get; set; }

    /// <summary>
    /// Default value of the password info field
    /// </summary>
    /// <value>Default value of the password info field</value>
    [DataMember(Name="defaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultValue")]
    public string DefaultValue { get; set; }

    /// <summary>
    /// Name of password field
    /// </summary>
    /// <value>Name of password field</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Label of password field
    /// </summary>
    /// <value>Label of password field</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// Whether this field is required or optional
    /// </summary>
    /// <value>Whether this field is required or optional</value>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PasswordFieldInfoDescription {\n");
      sb.Append("  Visible: ").Append(Visible).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
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

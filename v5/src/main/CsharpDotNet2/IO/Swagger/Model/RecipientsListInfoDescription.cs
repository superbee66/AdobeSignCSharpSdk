using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class RecipientsListInfoDescription {
    /// <summary>
    /// whether sender is allowed as a recipient
    /// </summary>
    /// <value>whether sender is allowed as a recipient</value>
    [DataMember(Name="allowSender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowSender")]
    public bool? AllowSender { get; set; }

    /// <summary>
    /// minimum number of entries allowed in the current recipient list
    /// </summary>
    /// <value>minimum number of entries allowed in the current recipient list</value>
    [DataMember(Name="minListCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minListCount")]
    public int MinListCount { get; set; }

    /// <summary>
    /// Whether current field is visible. If visible attribute for this field is false then this field should not be shown in the agreement creation UI using this workflow to user
    /// </summary>
    /// <value>Whether current field is visible. If visible attribute for this field is false then this field should not be shown in the agreement creation UI using this workflow to user</value>
    [DataMember(Name="visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible")]
    public bool? Visible { get; set; }

    /// <summary>
    /// authentication method for the current recipient list to have access to view and sign the document
    /// </summary>
    /// <value>authentication method for the current recipient list to have access to view and sign the document</value>
    [DataMember(Name="authenticationMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationMethod")]
    public string AuthenticationMethod { get; set; }

    /// <summary>
    /// whether fax is allowed or not
    /// </summary>
    /// <value>whether fax is allowed or not</value>
    [DataMember(Name="allowfax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowfax")]
    public bool? Allowfax { get; set; }

    /// <summary>
    /// A default  email or fax number
    /// </summary>
    /// <value>A default  email or fax number</value>
    [DataMember(Name="defaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultValue")]
    public string DefaultValue { get; set; }

    /// <summary>
    /// Whether current field can be edited. If editable attribute for this field is false then this field should not be provided in the agreement creation request and default value of this field will be used in agreement creation
    /// </summary>
    /// <value>Whether current field can be edited. If editable attribute for this field is false then this field should not be provided in the agreement creation request and default value of this field will be used in agreement creation</value>
    [DataMember(Name="editable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "editable")]
    public bool? Editable { get; set; }

    /// <summary>
    /// Name of the current RecipientInfo list
    /// </summary>
    /// <value>Name of the current RecipientInfo list</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// maximum number of entries allowed in the current recipient list
    /// </summary>
    /// <value>maximum number of entries allowed in the current recipient list</value>
    [DataMember(Name="maxListCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxListCount")]
    public int MaxListCount { get; set; }

    /// <summary>
    /// A display text for the workflow user that can be used for the current recipients list
    /// </summary>
    /// <value>A display text for the workflow user that can be used for the current recipients list</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RecipientsListInfoDescription {\n");
      sb.Append("  AllowSender: ").Append(AllowSender).Append("\n");
      sb.Append("  MinListCount: ").Append(MinListCount).Append("\n");
      sb.Append("  Visible: ").Append(Visible).Append("\n");
      sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
      sb.Append("  Allowfax: ").Append(Allowfax).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  Editable: ").Append(Editable).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  MaxListCount: ").Append(MaxListCount).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
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

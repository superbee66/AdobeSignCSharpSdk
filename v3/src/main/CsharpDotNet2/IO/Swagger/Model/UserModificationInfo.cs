using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserModificationInfo {
    /// <summary>
    /// The new first name of the user
    /// </summary>
    /// <value>The new first name of the user</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// The new last name of the user
    /// </summary>
    /// <value>The new last name of the user</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// The new phone number of the user. The server will reset to null if the value is not provided
    /// </summary>
    /// <value>The new phone number of the user. The server will reset to null if the value is not provided</value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// The new group in which the user should be added. It can be obtained through <b>GET /users</b> call. The server will reset to default if the value is not provided 
    /// </summary>
    /// <value>The new group in which the user should be added. It can be obtained through <b>GET /users</b> call. The server will reset to default if the value is not provided </value>
    [DataMember(Name="groupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupId")]
    public string GroupId { get; set; }

    /// <summary>
    /// The new roles of the user
    /// </summary>
    /// <value>The new roles of the user</value>
    [DataMember(Name="roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles")]
    public List<string> Roles { get; set; }

    /// <summary>
    /// Whether or not the user has opted in to receive the marketing information from Adobe Sign and its partners. The server will reset to null if the value is not provided. 
    /// </summary>
    /// <value>Whether or not the user has opted in to receive the marketing information from Adobe Sign and its partners. The server will reset to null if the value is not provided. </value>
    [DataMember(Name="optIn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optIn")]
    public string OptIn { get; set; }

    /// <summary>
    /// The new company name of the user. The server will reset to null if the value is not provided
    /// </summary>
    /// <value>The new company name of the user. The server will reset to null if the value is not provided</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// The new job title of the user. The server will reset to null if the value is not provided
    /// </summary>
    /// <value>The new job title of the user. The server will reset to null if the value is not provided</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// The new email address of the user
    /// </summary>
    /// <value>The new email address of the user</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserModificationInfo {\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
      sb.Append("  OptIn: ").Append(OptIn).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
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

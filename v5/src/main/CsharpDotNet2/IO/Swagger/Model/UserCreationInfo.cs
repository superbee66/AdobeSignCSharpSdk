using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserCreationInfo {
    /// <summary>
    /// The first name of the new user
    /// </summary>
    /// <value>The first name of the new user</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// The last name of the new user
    /// </summary>
    /// <value>The last name of the new user</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// The password of the new user
    /// </summary>
    /// <value>The password of the new user</value>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    /// <summary>
    /// The phone number of the new user
    /// </summary>
    /// <value>The phone number of the new user</value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Group in which the new user should be added. It can be obtained through a call to the API which retrieves users. Default is Group of the user making this call. The user is inferred from the access_token header.
    /// </summary>
    /// <value>Group in which the new user should be added. It can be obtained through a call to the API which retrieves users. Default is Group of the user making this call. The user is inferred from the access_token header.</value>
    [DataMember(Name="groupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupId")]
    public string GroupId { get; set; }

    /// <summary>
    /// The current roles of the user
    /// </summary>
    /// <value>The current roles of the user</value>
    [DataMember(Name="roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles")]
    public List<string> Roles { get; set; }

    /// <summary>
    /// Whether or not the user has opted in to receive marketing information from Adobe Sign and its partners. Default value is UNKNOWN
    /// </summary>
    /// <value>Whether or not the user has opted in to receive marketing information from Adobe Sign and its partners. Default value is UNKNOWN</value>
    [DataMember(Name="optIn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optIn")]
    public string OptIn { get; set; }

    /// <summary>
    /// The name of the company of the new user
    /// </summary>
    /// <value>The name of the company of the new user</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// The job title of the new user
    /// </summary>
    /// <value>The job title of the new user</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// The email address of the new user
    /// </summary>
    /// <value>The email address of the new user</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserCreationInfo {\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
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

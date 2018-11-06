using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V2.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserDetailsInfo {
    /// <summary>
    /// The last name of the user
    /// </summary>
    /// <value>The last name of the user</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// The date of password expiration
    /// </summary>
    /// <value>The date of password expiration</value>
    [DataMember(Name="passwordExpiration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passwordExpiration")]
    public DateTime? PasswordExpiration { get; set; }

    /// <summary>
    /// Status of the user
    /// </summary>
    /// <value>Status of the user</value>
    [DataMember(Name="userStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userStatus")]
    public string UserStatus { get; set; }

    /// <summary>
    /// The initials of the user
    /// </summary>
    /// <value>The initials of the user</value>
    [DataMember(Name="initials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initials")]
    public string Initials { get; set; }

    /// <summary>
    /// Type of account to which the user belongs (null if no account)
    /// </summary>
    /// <value>Type of account to which the user belongs (null if no account)</value>
    [DataMember(Name="accountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountType")]
    public string AccountType { get; set; }

    /// <summary>
    /// The identifier that can be used in group management methods
    /// </summary>
    /// <value>The identifier that can be used in group management methods</value>
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
    /// Name of the channel to which the user belongs
    /// </summary>
    /// <value>Name of the channel to which the user belongs</value>
    [DataMember(Name="channel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "channel")]
    public string Channel { get; set; }

    /// <summary>
    /// Whether or not the user has opted in to receive marketing information from Adobe Sign and its partners. Default value is UNKNOWN
    /// </summary>
    /// <value>Whether or not the user has opted in to receive marketing information from Adobe Sign and its partners. Default value is UNKNOWN</value>
    [DataMember(Name="optIn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optIn")]
    public string OptIn { get; set; }

    /// <summary>
    /// A set of capabilities applicable to the user
    /// </summary>
    /// <value>A set of capabilities applicable to the user</value>
    [DataMember(Name="capabilityFlags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capabilityFlags")]
    public List<string> CapabilityFlags { get; set; }

    /// <summary>
    /// The UI locale of the user
    /// </summary>
    /// <value>The UI locale of the user</value>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// The job title of the user
    /// </summary>
    /// <value>The job title of the user</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// The first name of the user
    /// </summary>
    /// <value>The first name of the user</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// The phone number of the user
    /// </summary>
    /// <value>The phone number of the user</value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// The name of company of the user
    /// </summary>
    /// <value>The name of company of the user</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// Nickname of the account to which the user belongs
    /// </summary>
    /// <value>Nickname of the account to which the user belongs</value>
    [DataMember(Name="account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account")]
    public string Account { get; set; }

    /// <summary>
    /// The email address of the user
    /// </summary>
    /// <value>The email address of the user</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Name of the group to which the user belongs
    /// </summary>
    /// <value>Name of the group to which the user belongs</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public string Group { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserDetailsInfo {\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  PasswordExpiration: ").Append(PasswordExpiration).Append("\n");
      sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
      sb.Append("  Initials: ").Append(Initials).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
      sb.Append("  Channel: ").Append(Channel).Append("\n");
      sb.Append("  OptIn: ").Append(OptIn).Append("\n");
      sb.Append("  CapabilityFlags: ").Append(CapabilityFlags).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
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

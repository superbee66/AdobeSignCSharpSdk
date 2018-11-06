using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class DetailedGroupInfo
    {
        /// <summary>
        ///     Date of creation of the group. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z
        ///     represents UTC time
        /// </summary>
        /// <value>
        ///     Date of creation of the group. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z
        ///     represents UTC time
        /// </value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "created")]
        public DateTime? Created { get; set; }

        /// <summary>
        ///     The unique identifier of the Group. This will be returned as part of GET call but is not mandatory to be passed as
        ///     part of PUT/POST call for groups/{groupId}
        /// </summary>
        /// <value>
        ///     The unique identifier of the Group. This will be returned as part of GET call but is not mandatory to be passed
        ///     as part of PUT/POST call for groups/{groupId}
        /// </value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     Name of the group
        /// </summary>
        /// <value>Name of the group</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);


        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DetailedGroupInfo {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
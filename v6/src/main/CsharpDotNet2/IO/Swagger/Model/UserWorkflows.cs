using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class UserWorkflows
    {
        /// <summary>
        ///     An array of workflows
        /// </summary>
        /// <value>An array of workflows</value>
        [DataMember(Name = "userWorkflowList", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "userWorkflowList")]
        public List<UserWorkflow> UserWorkflowList { get; set; }

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
            sb.Append("class UserWorkflows {\n");
            sb.Append("  UserWorkflowList: ").Append(UserWorkflowList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
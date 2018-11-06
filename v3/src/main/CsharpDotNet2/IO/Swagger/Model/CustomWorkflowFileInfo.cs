using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class CustomWorkflowFileInfo
    {
        /// <summary>
        ///     Name of file info element
        /// </summary>
        /// <value>Name of file info element</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Transient document identifier obtained from the transient document creation API
        /// </summary>
        /// <value>Transient document identifier obtained from the transient document creation API</value>
        [DataMember(Name = "transientDocumentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transientDocumentId")]
        public string TransientDocumentId { get; set; }

        /// <summary>
        ///     An id of the workflow library document that can be provided as an input file in the custom workflow agreement
        ///     creation request
        /// </summary>
        /// <value>
        ///     An id of the workflow library document that can be provided as an input file in the custom workflow agreement
        ///     creation request
        /// </value>
        [DataMember(Name = "workflowLibraryDocumentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "workflowLibraryDocumentId")]
        public string WorkflowLibraryDocumentId { get; set; }

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
            sb.Append("class CustomWorkflowFileInfo {\n");
            sb.Append("  WorkflowLibraryDocumentId: ").Append(WorkflowLibraryDocumentId).Append("\n");
            sb.Append("  TransientDocumentId: ").Append(TransientDocumentId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
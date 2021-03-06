using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    ///     Data for updating the default values of existing form fields
    /// </summary>
    [DataContract]
    public class FormFieldMergeInfo
    {
        /// <summary>
        ///     A mapping of field names to default values
        /// </summary>
        /// <value>A mapping of field names to default values</value>
        [DataMember(Name = "fieldMergeInfos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fieldMergeInfos")]
        public List<MergefieldInfo> FieldMergeInfos { get; set; }

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
            sb.Append("class FormFieldMergeInfo {\n");
            sb.Append("  FieldMergeInfos: ").Append(FieldMergeInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
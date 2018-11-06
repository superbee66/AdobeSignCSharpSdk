using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    ///     A JSON list of all of the fields for a form
    /// </summary>
    [DataContract]
    public class AgreementFormFields
    {
        /// <summary>
        ///     List of the form fields in an agreement
        /// </summary>
        /// <value>List of the form fields in an agreement</value>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fields")]
        public List<FormField> Fields { get; set; }

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
            sb.Append("class AgreementFormFields {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
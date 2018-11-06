using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class LibraryDocumentCreationInfo
    {
        /// <summary>
        ///     A list of one or more files (or references to files) that will be used to create the template. If more than one
        ///     file is provided, they will be combined into one PDF. Note: Only a single parameter in every FileInfo object must
        ///     be specified
        /// </summary>
        /// <value>
        ///     A list of one or more files (or references to files) that will be used to create the template. If more than one
        ///     file is provided, they will be combined into one PDF. Note: Only a single parameter in every FileInfo object must
        ///     be specified
        /// </value>
        [DataMember(Name = "fileInfos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fileInfos")]
        public List<FileInfo> FileInfos { get; set; }

        /// <summary>
        ///     Specifies who should have access to this library document
        /// </summary>
        /// <value>Specifies who should have access to this library document</value>
        [DataMember(Name = "librarySharingMode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "librarySharingMode")]
        public string LibrarySharingMode { get; set; }

        /// <summary>
        ///     A list of one or more library template types
        /// </summary>
        /// <value>A list of one or more library template types</value>
        [DataMember(Name = "libraryTemplateTypes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "libraryTemplateTypes")]
        public List<string> LibraryTemplateTypes { get; set; }

        /// <summary>
        ///     The name of the library template that will be used to identify it, in emails and on the website
        /// </summary>
        /// <value>The name of the library template that will be used to identify it, in emails and on the website</value>
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
            sb.Append("class LibraryDocumentCreationInfo {\n");
            sb.Append("  LibrarySharingMode: ").Append(LibrarySharingMode).Append("\n");
            sb.Append("  LibraryTemplateTypes: ").Append(LibraryTemplateTypes).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FileInfos: ").Append(FileInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
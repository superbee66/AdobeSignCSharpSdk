using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class AgreementAssetEventPostResponse
    {
        /// <summary>
        ///     The value of the page cursor corresponding to the current page
        /// </summary>
        /// <value>The value of the page cursor corresponding to the current page</value>
        [DataMember(Name = "currentPageCursor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentPageCursor")]
        public string CurrentPageCursor { get; set; }

        /// <summary>
        ///     An ordered list of the events in the audit trail of this document
        /// </summary>
        /// <value>An ordered list of the events in the audit trail of this document</value>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "events")]
        public List<DocumentEventForUser> Events { get; set; }

        /// <summary>
        ///     The page cursor of the next page to be fetched. If the next page cursor is blank then the given page is the last
        ///     page
        /// </summary>
        /// <value>
        ///     The page cursor of the next page to be fetched. If the next page cursor is blank then the given page is the last
        ///     page
        /// </value>
        [DataMember(Name = "nextPageCursor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nextPageCursor")]
        public string NextPageCursor { get; set; }

        /// <summary>
        ///     The search Id corresponding to current search object. This searchId can be used in combination with pageCursors
        ///     retrieved from the API which retrieves agreementAssetEvents based on a searchId, to fetch the result for further
        ///     pages
        /// </summary>
        /// <value>
        ///     The search Id corresponding to current search object. This searchId can be used in combination with pageCursors
        ///     retrieved from the API which retrieves agreementAssetEvents based on a searchId, to fetch the result for further
        ///     pages
        /// </value>
        [DataMember(Name = "searchId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "searchId")]
        public string SearchId { get; set; }

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
            sb.Append("class AgreementAssetEventPostResponse {\n");
            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  NextPageCursor: ").Append(NextPageCursor).Append("\n");
            sb.Append("  CurrentPageCursor: ").Append(CurrentPageCursor).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
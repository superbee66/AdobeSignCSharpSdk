using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class AgreementAssetEventRequest
    {
        /// <summary>
        ///     The end of the date range for which events will be returned. Date should be mentioned in YYYY-MM-DDTHH:MM:SS format
        /// </summary>
        /// <value>
        ///     The end of the date range for which events will be returned. Date should be mentioned in YYYY-MM-DDTHH:MM:SS
        ///     format
        /// </value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        ///     If filterEvents are specified, only those event types will be returned. If filterEvents are not specified, all
        ///     event types will be returned.The Agreement Event type should be given in form of array like
        ///     [\"ESIGNED\",\"SIGNED\"]
        /// </summary>
        /// <value>
        ///     If filterEvents are specified, only those event types will be returned. If filterEvents are not specified, all
        ///     event types will be returned.The Agreement Event type should be given in form of array like
        ///     [\"ESIGNED\",\"SIGNED\"]
        /// </value>
        [DataMember(Name = "filterEvents", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "filterEvents")]
        public List<string> FilterEvents { get; set; }

        /// <summary>
        ///     If true, only the latest event for any given agreement asset within the specified date range will be returned. If
        ///     false, all events will be returned
        /// </summary>
        /// <value>
        ///     If true, only the latest event for any given agreement asset within the specified date range will be returned.
        ///     If false, all events will be returned
        /// </value>
        [DataMember(Name = "onlyShowLatestEvent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "onlyShowLatestEvent")]
        public bool? OnlyShowLatestEvent { get; set; }

        /// <summary>
        ///     Count of agreement asset events which will be returned in the response. Default page size for the response is 100.
        ///     Maximum value of page size is 500
        /// </summary>
        /// <value>
        ///     Count of agreement asset events which will be returned in the response. Default page size for the response is
        ///     100. Maximum value of page size is 500
        /// </value>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        ///     The beginning of the date range for which events will be returned. Date should be mentioned in YYYY-MM-DDTHH:MM:SS
        ///     format
        /// </summary>
        /// <value>
        ///     The beginning of the date range for which events will be returned. Date should be mentioned in
        ///     YYYY-MM-DDTHH:MM:SS format
        /// </value>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startDate")]
        public DateTime? StartDate { get; set; }

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
            sb.Append("class AgreementAssetEventRequest {\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  OnlyShowLatestEvent: ").Append(OnlyShowLatestEvent).Append("\n");
            sb.Append("  FilterEvents: ").Append(FilterEvents).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
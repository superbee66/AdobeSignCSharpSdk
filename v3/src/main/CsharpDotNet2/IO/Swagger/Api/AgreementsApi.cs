using System.Collections.Generic;
using AdobeSignClient.V3.Client;
using AdobeSignClient.V3.Model;
using RestSharp;

namespace AdobeSignClient.V3.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAgreementsApi
    {
        /// <summary>
        ///     Creates an agreement. Sends it out for signatures, and returns the agreementID in the response to the client.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_send&lt;/a
        ///     &gt; - If both authoringRequested and sendThroughWeb parameter are set to false&lt;/li&gt;&lt;li style&#x3D;&#39;
        ///     list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;
        ///     agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot;
        ///     target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt; - If any of the authoringRequested or
        ///     sendThroughWeb parameter is set to true&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href
        ///     &#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\
        ///     &quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a
        ///     &gt; - Required additionally if the autoLoginUser parameter is set to true&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementCreationInfo">
        ///     Information about the agreement that you want to send and authoring options that
        ///     you want to apply at the time of sending.
        /// </param>
        /// <param name="xUserId">The ID of the user on whose behalf agreement is being created.</param>
        /// <param name="xUserEmail">
        ///     The email address of the user on whose behalf agreement is being created. If both X-User-Id
        ///     and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred
        ///     from the access token.
        /// </param>
        /// <returns>AgreementCreationResponse</returns>
        AgreementCreationResponse CreateAgreement(string accessToken, AgreementCreationInfo agreementCreationInfo, string xUserId, string xUserEmail);

        /// <summary>
        ///     Deletes an agreement. Agreement will no longer be visible in the Manage Page of the user.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_retention&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_retention&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;
        ///     agreement_retention&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <returns></returns>
        void DeleteAgreement(string accessToken, string agreementId);

        /// <summary>
        ///     Retrieves the current status of an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <returns>AgreementInfo</returns>
        AgreementInfo GetAgreementInfo(string accessToken, string agreementId);

        /// <summary>
        ///     Retrieves agreements for the user.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="xUserId">The ID of the user whose agreements are being requested.</param>
        /// <param name="xUserEmail">
        ///     The email address of the user whose agreements are being requested. If both X-User-Id and
        ///     X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred
        ///     from the access token.
        /// </param>
        /// <param name="query">
        ///     The query string used for the search. Multiple search terms can be provided, separated by spaces.
        ///     Some of the search terms include document name, participant name or company, and form data
        /// </param>
        /// <param name="externalId">
        ///     Case-sensitive ExternalID for which you would like to retrieve agreement information.
        ///     ExternalId is passed in the call to the agreement creation API.
        /// </param>
        /// <param name="externalGroup">
        ///     ExternalGroup for which you would like to retrieve agreement information. ExternalGroup is
        ///     passed in the call to the agreement creation API. You must pass ExternalId if passing ExternalGroup parameter
        /// </param>
        /// <param name="externalNamespace">
        ///     ExternalNameSpace for which you would like to retrieve agreement information.
        ///     ExternalNameSpace is passed in the call to the agreement creation API. You must pass ExternalId if passing
        ///     ExternalNameSpace parameter
        /// </param>
        /// <returns>UserAgreements</returns>
        UserAgreements GetAgreements(string accessToken, string xUserId, string xUserEmail, string query, string externalId, string externalGroup, string externalNamespace);

        /// <summary>
        ///     Retrieves the IDs of the documents of an agreement identified by agreementId.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="versionId">
        ///     The version identifier of agreement as provided by the API which retrieves information of a
        ///     specific agreement. If not provided then latest version will be used.
        /// </param>
        /// <param name="participantEmail">The email address of the participant to be used to retrieve documents.</param>
        /// <param name="supportingDocumentContentFormat">
        ///     Content format of the supported documents. It can have two possible
        ///     values ORIGINAL or CONVERTED_PDF. Default value is CONVERTED_PDF.
        /// </param>
        /// <returns>AgreementDocuments</returns>
        AgreementDocuments GetAllDocuments(string accessToken, string agreementId, string versionId, string participantEmail, string supportingDocumentContentFormat);

        /// <summary>
        ///     Retrieves image urls of all visible pages of all the documents associated with an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="versionId">
        ///     The version identifier of agreement as provided by the API which retrieves information of a
        ///     specific agreement. If not provided then latest version will be used.
        /// </param>
        /// <param name="participantEmail">
        ///     The email address of the participant to be used to retrieve its visible document pages
        ///     &#39; image urls.
        /// </param>
        /// <param name="imageSizes">
        ///     A comma separated list of image sizes i.e. {FIXED_WIDTH_50px, FIXED_WIDTH_250px,
        ///     FIXED_WIDTH_675px, ZOOM_50_PERCENT, ZOOM_75_PERCENT, ZOOM_100_PERCENT, ZOOM_125_PERCENT, ZOOM_150_PERCENT,
        ///     ZOOM_200_PERCENT}. Default sizes returned are {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px,
        ///     ZOOM_100_PERCENT}.
        /// </param>
        /// <param name="includeSupportingDocumentsImageUrls">
        ///     When set to true, returns image urls of supporting documents as well.
        ///     Else, returns image urls of only the original documents.
        /// </param>
        /// <param name="showImageAvailabilityOnly">
        ///     When set to true, returns only image availability. Else, returns both image
        ///     urls and its availability.
        /// </param>
        /// <returns>DocumentImageUrls</returns>
        DocumentImageUrls GetAllDocumentsImageUrls(string accessToken, string agreementId, string versionId, string participantEmail, string imageSizes, bool? includeSupportingDocumentsImageUrls, bool? showImageAvailabilityOnly);

        /// <summary>
        ///     Retrieves the audit trail of an agreement identified by agreementId. PDF file stream containing audit trail
        ///     information
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <returns>byte[]</returns>
        byte[] GetAuditTrail(string accessToken, string agreementId);

        /// <summary>
        ///     Gets a single combined PDF document for the documents associated with an agreement. A File Stream of combined PDF
        ///     document
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="versionId">
        ///     The version identifier of agreement as provided by the API which retrieves information of a
        ///     specific agreement. If not provided then latest version will be used.
        /// </param>
        /// <param name="participantEmail">The email address of the participant to be used to retrieve documents.</param>
        /// <param name="attachSupportingDocuments">
        ///     When set to true, attach corresponding supporting documents to the signed
        ///     agreement PDF. Default value of this parameter is true.
        /// </param>
        /// <param name="auditReport">When set to true, attach an audit report to the signed agreement PDF. Default value is false</param>
        /// <returns>byte[]</returns>
        byte[] GetCombinedDocument(string accessToken, string agreementId, string versionId, string participantEmail, bool? attachSupportingDocuments, bool? auditReport);

        /// <summary>
        ///     Retrieves info of all pages of a combined PDF document for the documents associated with an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="includeSupportingDocumentsPagesInfo">
        ///     When set to true, returns info of all pages of supporting documents
        ///     as well. Else, return the info of pages of only the original document.
        /// </param>
        /// <returns>CombinedDocumentPagesInfo</returns>
        CombinedDocumentPagesInfo GetCombinedDocumentPagesInfo(string accessToken, string agreementId, bool? includeSupportingDocumentsPagesInfo);

        /// <summary>
        ///     Retrieves url of all visible pages of all the documents associated with an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="versionId">
        ///     The version identifier of agreement as provided by the API which retrieves information of a
        ///     specific agreement. If not provided then latest version will be used.
        /// </param>
        /// <param name="participantEmail">The email address of the participant to be used to retrieve its document url.</param>
        /// <param name="attachSupportingDocuments">
        ///     When set to true, attach corresponding supporting documents to the signed
        ///     agreement PDF. Default value of this parameter is true.
        /// </param>
        /// <param name="auditReport">When set to true, attach an audit report to the signed agreement PDF. Default value is false</param>
        /// <returns>DocumentUrl</returns>
        DocumentUrl GetCombinedDocumentUrl(string accessToken, string agreementId, string versionId, string participantEmail, bool? attachSupportingDocuments, bool? auditReport);

        /// <summary>
        ///     Retrieves the file stream of a document of an agreement. Raw stream of the file
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="documentId">
        ///     The document identifier, as retrieved from the API which fetches the documents of a specified
        ///     agreement
        /// </param>
        /// <returns>byte[]</returns>
        byte[] GetDocument(string accessToken, string agreementId, string documentId);

        /// <summary>
        ///     Retrieves image urls of all visible pages of a document associated with an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="documentId">
        ///     The document identifier, as retrieved from the API which fetches the documents of a specified
        ///     agreement
        /// </param>
        /// <param name="versionId">
        ///     The version identifier of agreement as provided by the API which retrieves information of a
        ///     specific agreement. If not provided then latest version will be used.
        /// </param>
        /// <param name="participantEmail">
        ///     The email address of the participant to be used to retrieve its visible document pages
        ///     &#39; image urls.
        /// </param>
        /// <param name="imageSizes">
        ///     A comma separated list of image sizes i.e. {FIXED_WIDTH_50px, FIXED_WIDTH_250px,
        ///     FIXED_WIDTH_675px, ZOOM_50_PERCENT, ZOOM_75_PERCENT, ZOOM_100_PERCENT, ZOOM_125_PERCENT, ZOOM_150_PERCENT,
        ///     ZOOM_200_PERCENT}. Default sizes returned are {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px,
        ///     ZOOM_100_PERCENT}.
        /// </param>
        /// <param name="showImageAvailabilityOnly">
        ///     When set to true, returns only image availability. Else, returns both image
        ///     urls and its availability.
        /// </param>
        /// <param name="startPage">
        ///     Start of page number range for which imageUrls are requested. Starting page number should be
        ///     greater than 0.
        /// </param>
        /// <param name="endPage">End of page number range for which imageUrls are requested.</param>
        /// <returns>DocumentImageUrl</returns>
        DocumentImageUrl GetDocumentImageUrls(string accessToken, string agreementId, string documentId, string versionId, string participantEmail, string imageSizes, bool? showImageAvailabilityOnly, int? startPage, int? endPage);

        /// <summary>
        ///     Retrieves the url of the document
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="documentId">
        ///     The document identifier, as retrieved from the API which fetches the documents of a specified
        ///     agreement
        /// </param>
        /// <param name="versionId">
        ///     The version identifier of agreement as provided by the API which retrieves information of a
        ///     specific agreement. If not provided then latest version will be used.
        /// </param>
        /// <param name="participantEmail">The email address of the participant to be used to retrieve its document url.</param>
        /// <returns>DocumentUrl</returns>
        DocumentUrl GetDocumentUrl(string accessToken, string agreementId, string documentId, string versionId, string participantEmail);

        /// <summary>
        ///     Retrieves data entered by the user into interactive form fields at the time they signed the agreement. CSV file
        ///     stream containing form data information
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <returns>byte[]</returns>
        byte[] GetFormData(string accessToken, string agreementId);

        /// <summary>
        ///     Retrieves the URL for the e-sign page for the current signer(s) of an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;
        ///     /a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <returns>SigningUrls</returns>
        SigningUrls GetSigningUrl(string accessToken, string agreementId);

        /// <summary>
        ///     Cancels an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;
        ///     /a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="agreementStatusUpdateInfo">Agreement status update information object.</param>
        /// <returns>AgreementStatusUpdateResponse</returns>
        AgreementStatusUpdateResponse UpdateStatus(string accessToken, string agreementId, AgreementStatusUpdateInfo agreementStatusUpdateInfo);
    }

    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AgreementsApi : IAgreementsApi
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AgreementsApi" /> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AgreementsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                ApiClient = Configuration.DefaultApiClient;
            else
                ApiClient = apiClient;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AgreementsApi" /> class.
        /// </summary>
        /// <returns></returns>
        public AgreementsApi(string basePath)
        {
            ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        ///     Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        ///     Creates an agreement. Sends it out for signatures, and returns the agreementID in the response to the client.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_send&lt;/a
        ///     &gt; - If both authoringRequested and sendThroughWeb parameter are set to false&lt;/li&gt;&lt;li style&#x3D;&#39;
        ///     list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;
        ///     agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot;
        ///     target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt; - If any of the authoringRequested or
        ///     sendThroughWeb parameter is set to true&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href
        ///     &#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\
        ///     &quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a
        ///     &gt; - Required additionally if the autoLoginUser parameter is set to true&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementCreationInfo">
        ///     Information about the agreement that you want to send and authoring options that
        ///     you want to apply at the time of sending.
        /// </param>
        /// <param name="xUserId">The ID of the user on whose behalf agreement is being created.</param>
        /// <param name="xUserEmail">
        ///     The email address of the user on whose behalf agreement is being created. If both X-User-Id
        ///     and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred
        ///     from the access token.
        /// </param>
        /// <returns>AgreementCreationResponse</returns>
        public AgreementCreationResponse CreateAgreement(string accessToken, AgreementCreationInfo agreementCreationInfo, string xUserId, string xUserEmail)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling CreateAgreement");

            // verify the required parameter 'agreementCreationInfo' is set
            if (agreementCreationInfo == null) throw new ApiException(400, "Missing required parameter 'agreementCreationInfo' when calling CreateAgreement");


            string path = "/agreements";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xUserId != null) headerParams.Add("x-user-id", ApiClient.ParameterToString(xUserId)); // header parameter
            if (xUserEmail != null) headerParams.Add("x-user-email", ApiClient.ParameterToString(xUserEmail)); // header parameter
            postBody = ApiClient.Serialize(agreementCreationInfo); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling CreateAgreement: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling CreateAgreement: " + response.ErrorMessage, response.ErrorMessage);

            return (AgreementCreationResponse) ApiClient.Deserialize(response.Content, typeof(AgreementCreationResponse), response.Headers);
        }

        /// <summary>
        ///     Deletes an agreement. Agreement will no longer be visible in the Manage Page of the user.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_retention&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_retention&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;
        ///     agreement_retention&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <returns></returns>
        public void DeleteAgreement(string accessToken, string agreementId)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling DeleteAgreement");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling DeleteAgreement");


            string path = "/agreements/{agreementId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling DeleteAgreement: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling DeleteAgreement: " + response.ErrorMessage, response.ErrorMessage);
        }

        /// <summary>
        ///     Retrieves the current status of an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <returns>AgreementInfo</returns>
        public AgreementInfo GetAgreementInfo(string accessToken, string agreementId)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetAgreementInfo");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAgreementInfo");


            string path = "/agreements/{agreementId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetAgreementInfo: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetAgreementInfo: " + response.ErrorMessage, response.ErrorMessage);

            return (AgreementInfo) ApiClient.Deserialize(response.Content, typeof(AgreementInfo), response.Headers);
        }

        /// <summary>
        ///     Retrieves agreements for the user.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="xUserId">The ID of the user whose agreements are being requested.</param>
        /// <param name="xUserEmail">
        ///     The email address of the user whose agreements are being requested. If both X-User-Id and
        ///     X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred
        ///     from the access token.
        /// </param>
        /// <param name="query">
        ///     The query string used for the search. Multiple search terms can be provided, separated by spaces.
        ///     Some of the search terms include document name, participant name or company, and form data
        /// </param>
        /// <param name="externalId">
        ///     Case-sensitive ExternalID for which you would like to retrieve agreement information.
        ///     ExternalId is passed in the call to the agreement creation API.
        /// </param>
        /// <param name="externalGroup">
        ///     ExternalGroup for which you would like to retrieve agreement information. ExternalGroup is
        ///     passed in the call to the agreement creation API. You must pass ExternalId if passing ExternalGroup parameter
        /// </param>
        /// <param name="externalNamespace">
        ///     ExternalNameSpace for which you would like to retrieve agreement information.
        ///     ExternalNameSpace is passed in the call to the agreement creation API. You must pass ExternalId if passing
        ///     ExternalNameSpace parameter
        /// </param>
        /// <returns>UserAgreements</returns>
        public UserAgreements GetAgreements(string accessToken, string xUserId, string xUserEmail, string query, string externalId, string externalGroup, string externalNamespace)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetAgreements");


            string path = "/agreements";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
            if (externalId != null) queryParams.Add("externalId", ApiClient.ParameterToString(externalId)); // query parameter
            if (externalGroup != null) queryParams.Add("externalGroup", ApiClient.ParameterToString(externalGroup)); // query parameter
            if (externalNamespace != null) queryParams.Add("externalNamespace", ApiClient.ParameterToString(externalNamespace)); // query parameter
            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xUserId != null) headerParams.Add("x-user-id", ApiClient.ParameterToString(xUserId)); // header parameter
            if (xUserEmail != null) headerParams.Add("x-user-email", ApiClient.ParameterToString(xUserEmail)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetAgreements: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetAgreements: " + response.ErrorMessage, response.ErrorMessage);

            return (UserAgreements) ApiClient.Deserialize(response.Content, typeof(UserAgreements), response.Headers);
        }

        /// <summary>
        ///     Retrieves the IDs of the documents of an agreement identified by agreementId.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="versionId">
        ///     The version identifier of agreement as provided by the API which retrieves information of a
        ///     specific agreement. If not provided then latest version will be used.
        /// </param>
        /// <param name="participantEmail">The email address of the participant to be used to retrieve documents.</param>
        /// <param name="supportingDocumentContentFormat">
        ///     Content format of the supported documents. It can have two possible
        ///     values ORIGINAL or CONVERTED_PDF. Default value is CONVERTED_PDF.
        /// </param>
        /// <returns>AgreementDocuments</returns>
        public AgreementDocuments GetAllDocuments(string accessToken, string agreementId, string versionId, string participantEmail, string supportingDocumentContentFormat)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetAllDocuments");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAllDocuments");


            string path = "/agreements/{agreementId}/documents";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
            if (participantEmail != null) queryParams.Add("participantEmail", ApiClient.ParameterToString(participantEmail)); // query parameter
            if (supportingDocumentContentFormat != null) queryParams.Add("supportingDocumentContentFormat", ApiClient.ParameterToString(supportingDocumentContentFormat)); // query parameter
            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetAllDocuments: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetAllDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return (AgreementDocuments) ApiClient.Deserialize(response.Content, typeof(AgreementDocuments), response.Headers);
        }

        /// <summary>
        ///     Retrieves image urls of all visible pages of all the documents associated with an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="versionId">
        ///     The version identifier of agreement as provided by the API which retrieves information of a
        ///     specific agreement. If not provided then latest version will be used.
        /// </param>
        /// <param name="participantEmail">
        ///     The email address of the participant to be used to retrieve its visible document pages
        ///     &#39; image urls.
        /// </param>
        /// <param name="imageSizes">
        ///     A comma separated list of image sizes i.e. {FIXED_WIDTH_50px, FIXED_WIDTH_250px,
        ///     FIXED_WIDTH_675px, ZOOM_50_PERCENT, ZOOM_75_PERCENT, ZOOM_100_PERCENT, ZOOM_125_PERCENT, ZOOM_150_PERCENT,
        ///     ZOOM_200_PERCENT}. Default sizes returned are {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px,
        ///     ZOOM_100_PERCENT}.
        /// </param>
        /// <param name="includeSupportingDocumentsImageUrls">
        ///     When set to true, returns image urls of supporting documents as well.
        ///     Else, returns image urls of only the original documents.
        /// </param>
        /// <param name="showImageAvailabilityOnly">
        ///     When set to true, returns only image availability. Else, returns both image
        ///     urls and its availability.
        /// </param>
        /// <returns>DocumentImageUrls</returns>
        public DocumentImageUrls GetAllDocumentsImageUrls(string accessToken, string agreementId, string versionId, string participantEmail, string imageSizes, bool? includeSupportingDocumentsImageUrls, bool? showImageAvailabilityOnly)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetAllDocumentsImageUrls");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAllDocumentsImageUrls");


            string path = "/agreements/{agreementId}/documents/imageUrls";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
            if (participantEmail != null) queryParams.Add("participantEmail", ApiClient.ParameterToString(participantEmail)); // query parameter
            if (imageSizes != null) queryParams.Add("imageSizes", ApiClient.ParameterToString(imageSizes)); // query parameter
            if (includeSupportingDocumentsImageUrls != null) queryParams.Add("includeSupportingDocumentsImageUrls", ApiClient.ParameterToString(includeSupportingDocumentsImageUrls)); // query parameter
            if (showImageAvailabilityOnly != null) queryParams.Add("showImageAvailabilityOnly", ApiClient.ParameterToString(showImageAvailabilityOnly)); // query parameter
            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetAllDocumentsImageUrls: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetAllDocumentsImageUrls: " + response.ErrorMessage, response.ErrorMessage);

            return (DocumentImageUrls) ApiClient.Deserialize(response.Content, typeof(DocumentImageUrls), response.Headers);
        }

        /// <summary>
        ///     Retrieves the audit trail of an agreement identified by agreementId. PDF file stream containing audit trail
        ///     information
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <returns>byte[]</returns>
        public byte[] GetAuditTrail(string accessToken, string agreementId)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetAuditTrail");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAuditTrail");


            string path = "/agreements/{agreementId}/auditTrail";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetAuditTrail: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetAuditTrail: " + response.ErrorMessage, response.ErrorMessage);

            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }

        /// <summary>
        ///     Gets a single combined PDF document for the documents associated with an agreement. A File Stream of combined PDF
        ///     document
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="versionId">
        ///     The version identifier of agreement as provided by the API which retrieves information of a
        ///     specific agreement. If not provided then latest version will be used.
        /// </param>
        /// <param name="participantEmail">The email address of the participant to be used to retrieve documents.</param>
        /// <param name="attachSupportingDocuments">
        ///     When set to true, attach corresponding supporting documents to the signed
        ///     agreement PDF. Default value of this parameter is true.
        /// </param>
        /// <param name="auditReport">When set to true, attach an audit report to the signed agreement PDF. Default value is false</param>
        /// <returns>byte[]</returns>
        public byte[] GetCombinedDocument(string accessToken, string agreementId, string versionId, string participantEmail, bool? attachSupportingDocuments, bool? auditReport)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetCombinedDocument");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetCombinedDocument");


            string path = "/agreements/{agreementId}/combinedDocument";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
            if (participantEmail != null) queryParams.Add("participantEmail", ApiClient.ParameterToString(participantEmail)); // query parameter
            if (attachSupportingDocuments != null) queryParams.Add("attachSupportingDocuments", ApiClient.ParameterToString(attachSupportingDocuments)); // query parameter
            if (auditReport != null) queryParams.Add("auditReport", ApiClient.ParameterToString(auditReport)); // query parameter
            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetCombinedDocument: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetCombinedDocument: " + response.ErrorMessage, response.ErrorMessage);

            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }

        /// <summary>
        ///     Retrieves info of all pages of a combined PDF document for the documents associated with an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="includeSupportingDocumentsPagesInfo">
        ///     When set to true, returns info of all pages of supporting documents
        ///     as well. Else, return the info of pages of only the original document.
        /// </param>
        /// <returns>CombinedDocumentPagesInfo</returns>
        public CombinedDocumentPagesInfo GetCombinedDocumentPagesInfo(string accessToken, string agreementId, bool? includeSupportingDocumentsPagesInfo)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetCombinedDocumentPagesInfo");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetCombinedDocumentPagesInfo");


            string path = "/agreements/{agreementId}/combinedDocument/pagesInfo";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (includeSupportingDocumentsPagesInfo != null) queryParams.Add("includeSupportingDocumentsPagesInfo", ApiClient.ParameterToString(includeSupportingDocumentsPagesInfo)); // query parameter
            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetCombinedDocumentPagesInfo: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetCombinedDocumentPagesInfo: " + response.ErrorMessage, response.ErrorMessage);

            return (CombinedDocumentPagesInfo) ApiClient.Deserialize(response.Content, typeof(CombinedDocumentPagesInfo), response.Headers);
        }

        /// <summary>
        ///     Retrieves url of all visible pages of all the documents associated with an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="versionId">
        ///     The version identifier of agreement as provided by the API which retrieves information of a
        ///     specific agreement. If not provided then latest version will be used.
        /// </param>
        /// <param name="participantEmail">The email address of the participant to be used to retrieve its document url.</param>
        /// <param name="attachSupportingDocuments">
        ///     When set to true, attach corresponding supporting documents to the signed
        ///     agreement PDF. Default value of this parameter is true.
        /// </param>
        /// <param name="auditReport">When set to true, attach an audit report to the signed agreement PDF. Default value is false</param>
        /// <returns>DocumentUrl</returns>
        public DocumentUrl GetCombinedDocumentUrl(string accessToken, string agreementId, string versionId, string participantEmail, bool? attachSupportingDocuments, bool? auditReport)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetCombinedDocumentUrl");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetCombinedDocumentUrl");


            string path = "/agreements/{agreementId}/combinedDocument/url";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
            if (participantEmail != null) queryParams.Add("participantEmail", ApiClient.ParameterToString(participantEmail)); // query parameter
            if (attachSupportingDocuments != null) queryParams.Add("attachSupportingDocuments", ApiClient.ParameterToString(attachSupportingDocuments)); // query parameter
            if (auditReport != null) queryParams.Add("auditReport", ApiClient.ParameterToString(auditReport)); // query parameter
            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetCombinedDocumentUrl: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetCombinedDocumentUrl: " + response.ErrorMessage, response.ErrorMessage);

            return (DocumentUrl) ApiClient.Deserialize(response.Content, typeof(DocumentUrl), response.Headers);
        }

        /// <summary>
        ///     Retrieves the file stream of a document of an agreement. Raw stream of the file
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="documentId">
        ///     The document identifier, as retrieved from the API which fetches the documents of a specified
        ///     agreement
        /// </param>
        /// <returns>byte[]</returns>
        public byte[] GetDocument(string accessToken, string agreementId, string documentId)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetDocument");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetDocument");

            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocument");


            string path = "/agreements/{agreementId}/documents/{documentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
            path = path.Replace("{" + "documentId" + "}", ApiClient.ParameterToString(documentId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetDocument: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetDocument: " + response.ErrorMessage, response.ErrorMessage);

            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }

        /// <summary>
        ///     Retrieves image urls of all visible pages of a document associated with an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="documentId">
        ///     The document identifier, as retrieved from the API which fetches the documents of a specified
        ///     agreement
        /// </param>
        /// <param name="versionId">
        ///     The version identifier of agreement as provided by the API which retrieves information of a
        ///     specific agreement. If not provided then latest version will be used.
        /// </param>
        /// <param name="participantEmail">
        ///     The email address of the participant to be used to retrieve its visible document pages
        ///     &#39; image urls.
        /// </param>
        /// <param name="imageSizes">
        ///     A comma separated list of image sizes i.e. {FIXED_WIDTH_50px, FIXED_WIDTH_250px,
        ///     FIXED_WIDTH_675px, ZOOM_50_PERCENT, ZOOM_75_PERCENT, ZOOM_100_PERCENT, ZOOM_125_PERCENT, ZOOM_150_PERCENT,
        ///     ZOOM_200_PERCENT}. Default sizes returned are {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px,
        ///     ZOOM_100_PERCENT}.
        /// </param>
        /// <param name="showImageAvailabilityOnly">
        ///     When set to true, returns only image availability. Else, returns both image
        ///     urls and its availability.
        /// </param>
        /// <param name="startPage">
        ///     Start of page number range for which imageUrls are requested. Starting page number should be
        ///     greater than 0.
        /// </param>
        /// <param name="endPage">End of page number range for which imageUrls are requested.</param>
        /// <returns>DocumentImageUrl</returns>
        public DocumentImageUrl GetDocumentImageUrls(string accessToken, string agreementId, string documentId, string versionId, string participantEmail, string imageSizes, bool? showImageAvailabilityOnly, int? startPage, int? endPage)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetDocumentImageUrls");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetDocumentImageUrls");

            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocumentImageUrls");


            string path = "/agreements/{agreementId}/documents/{documentId}/imageUrls";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
            path = path.Replace("{" + "documentId" + "}", ApiClient.ParameterToString(documentId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
            if (participantEmail != null) queryParams.Add("participantEmail", ApiClient.ParameterToString(participantEmail)); // query parameter
            if (imageSizes != null) queryParams.Add("imageSizes", ApiClient.ParameterToString(imageSizes)); // query parameter
            if (showImageAvailabilityOnly != null) queryParams.Add("showImageAvailabilityOnly", ApiClient.ParameterToString(showImageAvailabilityOnly)); // query parameter
            if (startPage != null) queryParams.Add("startPage", ApiClient.ParameterToString(startPage)); // query parameter
            if (endPage != null) queryParams.Add("endPage", ApiClient.ParameterToString(endPage)); // query parameter
            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetDocumentImageUrls: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetDocumentImageUrls: " + response.ErrorMessage, response.ErrorMessage);

            return (DocumentImageUrl) ApiClient.Deserialize(response.Content, typeof(DocumentImageUrl), response.Headers);
        }

        /// <summary>
        ///     Retrieves the url of the document
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="documentId">
        ///     The document identifier, as retrieved from the API which fetches the documents of a specified
        ///     agreement
        /// </param>
        /// <param name="versionId">
        ///     The version identifier of agreement as provided by the API which retrieves information of a
        ///     specific agreement. If not provided then latest version will be used.
        /// </param>
        /// <param name="participantEmail">The email address of the participant to be used to retrieve its document url.</param>
        /// <returns>DocumentUrl</returns>
        public DocumentUrl GetDocumentUrl(string accessToken, string agreementId, string documentId, string versionId, string participantEmail)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetDocumentUrl");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetDocumentUrl");

            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocumentUrl");


            string path = "/agreements/{agreementId}/documents/{documentId}/url";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
            path = path.Replace("{" + "documentId" + "}", ApiClient.ParameterToString(documentId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
            if (participantEmail != null) queryParams.Add("participantEmail", ApiClient.ParameterToString(participantEmail)); // query parameter
            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetDocumentUrl: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetDocumentUrl: " + response.ErrorMessage, response.ErrorMessage);

            return (DocumentUrl) ApiClient.Deserialize(response.Content, typeof(DocumentUrl), response.Headers);
        }

        /// <summary>
        ///     Retrieves data entered by the user into interactive form fields at the time they signed the agreement. CSV file
        ///     stream containing form data information
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <returns>byte[]</returns>
        public byte[] GetFormData(string accessToken, string agreementId)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetFormData");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetFormData");


            string path = "/agreements/{agreementId}/formData";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetFormData: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetFormData: " + response.ErrorMessage, response.ErrorMessage);

            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }

        /// <summary>
        ///     Retrieves the URL for the e-sign page for the current signer(s) of an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;
        ///     /a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <returns>SigningUrls</returns>
        public SigningUrls GetSigningUrl(string accessToken, string agreementId)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetSigningUrl");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetSigningUrl");


            string path = "/agreements/{agreementId}/signingUrls";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetSigningUrl: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetSigningUrl: " + response.ErrorMessage, response.ErrorMessage);

            return (SigningUrls) ApiClient.Deserialize(response.Content, typeof(SigningUrls), response.Headers);
        }

        /// <summary>
        ///     Cancels an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;
        ///     /a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementId">
        ///     The agreement identifier, as returned by the agreement creation API or retrieved from the API
        ///     to fetch agreements.
        /// </param>
        /// <param name="agreementStatusUpdateInfo">Agreement status update information object.</param>
        /// <returns>AgreementStatusUpdateResponse</returns>
        public AgreementStatusUpdateResponse UpdateStatus(string accessToken, string agreementId, AgreementStatusUpdateInfo agreementStatusUpdateInfo)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling UpdateStatus");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling UpdateStatus");

            // verify the required parameter 'agreementStatusUpdateInfo' is set
            if (agreementStatusUpdateInfo == null) throw new ApiException(400, "Missing required parameter 'agreementStatusUpdateInfo' when calling UpdateStatus");


            string path = "/agreements/{agreementId}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            postBody = ApiClient.Serialize(agreementStatusUpdateInfo); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling UpdateStatus: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling UpdateStatus: " + response.ErrorMessage, response.ErrorMessage);

            return (AgreementStatusUpdateResponse) ApiClient.Deserialize(response.Content, typeof(AgreementStatusUpdateResponse), response.Headers);
        }

        /// <summary>
        ///     Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public string GetBasePath(string basePath) => ApiClient.BasePath;

        /// <summary>
        ///     Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(string basePath)
        {
            ApiClient.BasePath = basePath;
        }
    }
}
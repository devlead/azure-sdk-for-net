namespace Microsoft.Azure.Management.Resources
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Azure.OData;
    using System.Linq.Expressions;
    using Microsoft.Azure;
    using Models;

    /// <summary>
    /// </summary>
    public partial interface ITagsOperations
    {
        /// <summary>
        /// Delete a subscription resource tag value.
        /// </summary>
        /// <param name='tagName'>
        /// The name of the tag.
        /// </param>
        /// <param name='tagValue'>
        /// The value of the tag.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteValueWithHttpMessagesAsync(string tagName, string tagValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a subscription resource tag value.
        /// </summary>
        /// <param name='tagName'>
        /// The name of the tag.
        /// </param>
        /// <param name='tagValue'>
        /// The value of the tag.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<AzureOperationResponse<TagValue>> CreateOrUpdateValueWithHttpMessagesAsync(string tagName, string tagValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a subscription resource tag.
        /// </summary>
        /// <param name='tagName'>
        /// The name of the tag.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<AzureOperationResponse<TagDetails>> CreateOrUpdateWithHttpMessagesAsync(string tagName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a subscription resource tag.
        /// </summary>
        /// <param name='tagName'>
        /// The name of the tag.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string tagName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a list of subscription resource tags.
        /// </summary>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<AzureOperationResponse<TagsListResult>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a list of subscription resource tags.
        /// </summary>
        /// <param name='nextLink'>
        /// NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<AzureOperationResponse<TagsListResult>> ListNextWithHttpMessagesAsync(string nextLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
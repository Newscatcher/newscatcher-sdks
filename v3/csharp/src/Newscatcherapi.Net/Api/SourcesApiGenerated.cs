/*
 * NewsCatcher-V3 Production API
 *
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>
 *
 * The version of the OpenAPI document: 3.2.16
 * Contact: maksym@newscatcherapi.com
 * Generated by: https://konfigthis.com
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Newscatcherapi.Net.Client;
using Newscatcherapi.Net.Model;

namespace Newscatcherapi.Net.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISourcesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [Get] Search For Sources Request
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang"> (optional)</param>
        /// <param name="countries"> (optional)</param>
        /// <param name="predefinedSources"> (optional)</param>
        /// <param name="includeAdditionalInfo"> (optional)</param>
        /// <param name="fromRank"> (optional)</param>
        /// <param name="toRank"> (optional)</param>
        /// <param name="sourceName"> (optional)</param>
        /// <param name="sourceUrl"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SourceResponse</returns>
        SourceResponse Get(string lang = default(string), string countries = default(string), string predefinedSources = default(string), bool? includeAdditionalInfo = default(bool?), int? fromRank = default(int?), int? toRank = default(int?), Object sourceName = default(Object), string sourceUrl = default(string), int operationIndex = 0);

        /// <summary>
        /// [Get] Search For Sources Request
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang"> (optional)</param>
        /// <param name="countries"> (optional)</param>
        /// <param name="predefinedSources"> (optional)</param>
        /// <param name="includeAdditionalInfo"> (optional)</param>
        /// <param name="fromRank"> (optional)</param>
        /// <param name="toRank"> (optional)</param>
        /// <param name="sourceName"> (optional)</param>
        /// <param name="sourceUrl"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SourceResponse</returns>
        ApiResponse<SourceResponse> GetWithHttpInfo(string lang = default(string), string countries = default(string), string predefinedSources = default(string), bool? includeAdditionalInfo = default(bool?), int? fromRank = default(int?), int? toRank = default(int?), Object sourceName = default(Object), string sourceUrl = default(string), int operationIndex = 0);
        /// <summary>
        /// [Post] Search For Sources Request
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourcesRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SourceResponse</returns>
        SourceResponse Post(SourcesRequest sourcesRequest, int operationIndex = 0);

        /// <summary>
        /// [Post] Search For Sources Request
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourcesRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SourceResponse</returns>
        ApiResponse<SourceResponse> PostWithHttpInfo(SourcesRequest sourcesRequest, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISourcesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [Get] Search For Sources Request
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang"> (optional)</param>
        /// <param name="countries"> (optional)</param>
        /// <param name="predefinedSources"> (optional)</param>
        /// <param name="includeAdditionalInfo"> (optional)</param>
        /// <param name="fromRank"> (optional)</param>
        /// <param name="toRank"> (optional)</param>
        /// <param name="sourceName"> (optional)</param>
        /// <param name="sourceUrl"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SourceResponse</returns>
        System.Threading.Tasks.Task<SourceResponse> GetAsync(string lang = default(string), string countries = default(string), string predefinedSources = default(string), bool? includeAdditionalInfo = default(bool?), int? fromRank = default(int?), int? toRank = default(int?), Object sourceName = default(Object), string sourceUrl = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [Get] Search For Sources Request
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang"> (optional)</param>
        /// <param name="countries"> (optional)</param>
        /// <param name="predefinedSources"> (optional)</param>
        /// <param name="includeAdditionalInfo"> (optional)</param>
        /// <param name="fromRank"> (optional)</param>
        /// <param name="toRank"> (optional)</param>
        /// <param name="sourceName"> (optional)</param>
        /// <param name="sourceUrl"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SourceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SourceResponse>> GetWithHttpInfoAsync(string lang = default(string), string countries = default(string), string predefinedSources = default(string), bool? includeAdditionalInfo = default(bool?), int? fromRank = default(int?), int? toRank = default(int?), Object sourceName = default(Object), string sourceUrl = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [Post] Search For Sources Request
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourcesRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SourceResponse</returns>
        System.Threading.Tasks.Task<SourceResponse> PostAsync(SourcesRequest sourcesRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [Post] Search For Sources Request
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourcesRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SourceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SourceResponse>> PostWithHttpInfoAsync(SourcesRequest sourcesRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISourcesApi : ISourcesApiSync, ISourcesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SourcesApiGenerated : ISourcesApi
    {
        private Newscatcherapi.Net.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SourcesApiGenerated"/> class.
        /// </summary>
        /// <returns></returns>
        public SourcesApiGenerated() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourcesApiGenerated"/> class.
        /// </summary>
        /// <returns></returns>
        public SourcesApiGenerated(string basePath)
        {
            this.Configuration = Newscatcherapi.Net.Client.Configuration.MergeConfigurations(
                Newscatcherapi.Net.Client.GlobalConfiguration.Instance,
                new Newscatcherapi.Net.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Newscatcherapi.Net.Client.ApiClient(this.Configuration);
            this.AsynchronousClient = new Newscatcherapi.Net.Client.ApiClient(this.Configuration);
            this.ExceptionFactory = Newscatcherapi.Net.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourcesApiGenerated"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SourcesApiGenerated(Newscatcherapi.Net.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Newscatcherapi.Net.Client.Configuration.MergeConfigurations(
                Newscatcherapi.Net.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Newscatcherapi.Net.Client.ApiClient(this.Configuration);
            this.AsynchronousClient = new Newscatcherapi.Net.Client.ApiClient(this.Configuration);
            this.ExceptionFactory = Newscatcherapi.Net.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourcesApiGenerated"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SourcesApiGenerated(Newscatcherapi.Net.Client.ISynchronousClient client, Newscatcherapi.Net.Client.IAsynchronousClient asyncClient, Newscatcherapi.Net.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Newscatcherapi.Net.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Newscatcherapi.Net.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Newscatcherapi.Net.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Newscatcherapi.Net.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Newscatcherapi.Net.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// [Get] Search For Sources Request This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang"> (optional)</param>
        /// <param name="countries"> (optional)</param>
        /// <param name="predefinedSources"> (optional)</param>
        /// <param name="includeAdditionalInfo"> (optional)</param>
        /// <param name="fromRank"> (optional)</param>
        /// <param name="toRank"> (optional)</param>
        /// <param name="sourceName"> (optional)</param>
        /// <param name="sourceUrl"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SourceResponse</returns>
        public SourceResponse Get(string lang = default(string), string countries = default(string), string predefinedSources = default(string), bool? includeAdditionalInfo = default(bool?), int? fromRank = default(int?), int? toRank = default(int?), Object sourceName = default(Object), string sourceUrl = default(string), int operationIndex = 0)
        {
            Newscatcherapi.Net.Client.ApiResponse<SourceResponse> localVarResponse = GetWithHttpInfo(lang, countries, predefinedSources, includeAdditionalInfo, fromRank, toRank, sourceName, sourceUrl);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [Get] Search For Sources Request This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang"> (optional)</param>
        /// <param name="countries"> (optional)</param>
        /// <param name="predefinedSources"> (optional)</param>
        /// <param name="includeAdditionalInfo"> (optional)</param>
        /// <param name="fromRank"> (optional)</param>
        /// <param name="toRank"> (optional)</param>
        /// <param name="sourceName"> (optional)</param>
        /// <param name="sourceUrl"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SourceResponse</returns>
        public Newscatcherapi.Net.Client.ApiResponse<SourceResponse> GetWithHttpInfo(string lang = default(string), string countries = default(string), string predefinedSources = default(string), bool? includeAdditionalInfo = default(bool?), int? fromRank = default(int?), int? toRank = default(int?), Object sourceName = default(Object), string sourceUrl = default(string), int operationIndex = 0)
        {
            Newscatcherapi.Net.Client.RequestOptions localVarRequestOptions = new Newscatcherapi.Net.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Newscatcherapi.Net.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Newscatcherapi.Net.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (lang != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "lang", lang, ""));
            }
            if (countries != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "countries", countries, ""));
            }
            if (predefinedSources != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "predefined_sources", predefinedSources, ""));
            }
            if (includeAdditionalInfo != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "include_additional_info", includeAdditionalInfo, ""));
            }
            if (fromRank != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "from_rank", fromRank, ""));
            }
            if (toRank != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "to_rank", toRank, ""));
            }
            if (sourceName != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "source_name", sourceName, ""));
            }
            if (sourceUrl != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "source_url", sourceUrl, ""));
            }

            localVarRequestOptions.Operation = "SourcesApi.Get";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-token")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-token", this.Configuration.GetApiKeyWithPrefix("x-api-token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<SourceResponse>("/api/sources", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// [Get] Search For Sources Request This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang"> (optional)</param>
        /// <param name="countries"> (optional)</param>
        /// <param name="predefinedSources"> (optional)</param>
        /// <param name="includeAdditionalInfo"> (optional)</param>
        /// <param name="fromRank"> (optional)</param>
        /// <param name="toRank"> (optional)</param>
        /// <param name="sourceName"> (optional)</param>
        /// <param name="sourceUrl"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SourceResponse</returns>
        public async System.Threading.Tasks.Task<SourceResponse> GetAsync(string lang = default(string), string countries = default(string), string predefinedSources = default(string), bool? includeAdditionalInfo = default(bool?), int? fromRank = default(int?), int? toRank = default(int?), Object sourceName = default(Object), string sourceUrl = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Newscatcherapi.Net.Client.ApiResponse<SourceResponse> localVarResponse = await GetWithHttpInfoAsync(lang, countries, predefinedSources, includeAdditionalInfo, fromRank, toRank, sourceName, sourceUrl, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [Get] Search For Sources Request This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang"> (optional)</param>
        /// <param name="countries"> (optional)</param>
        /// <param name="predefinedSources"> (optional)</param>
        /// <param name="includeAdditionalInfo"> (optional)</param>
        /// <param name="fromRank"> (optional)</param>
        /// <param name="toRank"> (optional)</param>
        /// <param name="sourceName"> (optional)</param>
        /// <param name="sourceUrl"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SourceResponse)</returns>
        public virtual async System.Threading.Tasks.Task<Newscatcherapi.Net.Client.ApiResponse<SourceResponse>> GetWithHttpInfoAsync(string lang = default(string), string countries = default(string), string predefinedSources = default(string), bool? includeAdditionalInfo = default(bool?), int? fromRank = default(int?), int? toRank = default(int?), Object sourceName = default(Object), string sourceUrl = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Newscatcherapi.Net.Client.RequestOptions localVarRequestOptions = new Newscatcherapi.Net.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Newscatcherapi.Net.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Newscatcherapi.Net.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (lang != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "lang", lang, ""));
            }
            if (countries != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "countries", countries, ""));
            }
            if (predefinedSources != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "predefined_sources", predefinedSources, ""));
            }
            if (includeAdditionalInfo != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "include_additional_info", includeAdditionalInfo, ""));
            }
            if (fromRank != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "from_rank", fromRank, ""));
            }
            if (toRank != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "to_rank", toRank, ""));
            }
            if (sourceName != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "source_name", sourceName, ""));
            }
            if (sourceUrl != null)
            {
                localVarRequestOptions.QueryParameters.Add(Newscatcherapi.Net.Client.ClientUtils.ParameterToMultiMap("", "source_url", sourceUrl, ""));
            }

            localVarRequestOptions.Operation = "SourcesApi.Get";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-token")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-token", this.Configuration.GetApiKeyWithPrefix("x-api-token"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<SourceResponse>("/api/sources", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// [Post] Search For Sources Request This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourcesRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SourceResponse</returns>
        public SourceResponse Post(SourcesRequest sourcesRequest, int operationIndex = 0)
        {
            Newscatcherapi.Net.Client.ApiResponse<SourceResponse> localVarResponse = PostWithHttpInfo(sourcesRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [Post] Search For Sources Request This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourcesRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SourceResponse</returns>
        public Newscatcherapi.Net.Client.ApiResponse<SourceResponse> PostWithHttpInfo(SourcesRequest sourcesRequest, int operationIndex = 0)
        {
            // verify the required parameter 'sourcesRequest' is set
            if (sourcesRequest == null)
            {
                throw new Newscatcherapi.Net.Client.ApiException(400, "Missing required parameter 'sourcesRequest' when calling SourcesApi->Post");
            }

            Newscatcherapi.Net.Client.RequestOptions localVarRequestOptions = new Newscatcherapi.Net.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Newscatcherapi.Net.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Newscatcherapi.Net.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = sourcesRequest;

            localVarRequestOptions.Operation = "SourcesApi.Post";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-token")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-token", this.Configuration.GetApiKeyWithPrefix("x-api-token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<SourceResponse>("/api/sources", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Post", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// [Post] Search For Sources Request This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourcesRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SourceResponse</returns>
        public async System.Threading.Tasks.Task<SourceResponse> PostAsync(SourcesRequest sourcesRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Newscatcherapi.Net.Client.ApiResponse<SourceResponse> localVarResponse = await PostWithHttpInfoAsync(sourcesRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [Post] Search For Sources Request This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourcesRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SourceResponse)</returns>
        public virtual async System.Threading.Tasks.Task<Newscatcherapi.Net.Client.ApiResponse<SourceResponse>> PostWithHttpInfoAsync(SourcesRequest sourcesRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'sourcesRequest' is set
            if (sourcesRequest == null)
            {
                throw new Newscatcherapi.Net.Client.ApiException(400, "Missing required parameter 'sourcesRequest' when calling SourcesApi->Post");
            }


            Newscatcherapi.Net.Client.RequestOptions localVarRequestOptions = new Newscatcherapi.Net.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Newscatcherapi.Net.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Newscatcherapi.Net.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = sourcesRequest;

            localVarRequestOptions.Operation = "SourcesApi.Post";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-token")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-token", this.Configuration.GetApiKeyWithPrefix("x-api-token"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<SourceResponse>("/api/sources", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Post", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}

/*
 * NewsCatcher-V3 Production API
 *
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>
 *
 * The version of the OpenAPI document: Beta-3.0.0
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
    public interface ISubscriptionApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [Get] Get My Plan Info
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get info about your subscription plan.
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SubscriptionResponse</returns>
        SubscriptionResponse Get(int operationIndex = 0);

        /// <summary>
        /// [Get] Get My Plan Info
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get info about your subscription plan.
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SubscriptionResponse</returns>
        ApiResponse<SubscriptionResponse> GetWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// [Post] Get My Plan Info
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get info about your subscription plan.
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SubscriptionResponse</returns>
        SubscriptionResponse Post(int operationIndex = 0);

        /// <summary>
        /// [Post] Get My Plan Info
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get info about your subscription plan.
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SubscriptionResponse</returns>
        ApiResponse<SubscriptionResponse> PostWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISubscriptionApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [Get] Get My Plan Info
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get info about your subscription plan.
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SubscriptionResponse</returns>
        System.Threading.Tasks.Task<SubscriptionResponse> GetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [Get] Get My Plan Info
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get info about your subscription plan.
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SubscriptionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionResponse>> GetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [Post] Get My Plan Info
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get info about your subscription plan.
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SubscriptionResponse</returns>
        System.Threading.Tasks.Task<SubscriptionResponse> PostAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [Post] Get My Plan Info
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get info about your subscription plan.
        /// </remarks>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SubscriptionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionResponse>> PostWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISubscriptionApi : ISubscriptionApiSync, ISubscriptionApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SubscriptionApi : ISubscriptionApi
    {
        private Newscatcherapi.Net.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubscriptionApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubscriptionApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SubscriptionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SubscriptionApi(Newscatcherapi.Net.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SubscriptionApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SubscriptionApi(Newscatcherapi.Net.Client.ISynchronousClient client, Newscatcherapi.Net.Client.IAsynchronousClient asyncClient, Newscatcherapi.Net.Client.IReadableConfiguration configuration)
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
        /// [Get] Get My Plan Info This endpoint allows you to get info about your subscription plan.
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SubscriptionResponse</returns>
        public SubscriptionResponse Get(int operationIndex = 0)
        {
            Newscatcherapi.Net.Client.ApiResponse<SubscriptionResponse> localVarResponse = GetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// [Get] Get My Plan Info This endpoint allows you to get info about your subscription plan.
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SubscriptionResponse</returns>
        public Newscatcherapi.Net.Client.ApiResponse<SubscriptionResponse> GetWithHttpInfo(int operationIndex = 0)
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


            localVarRequestOptions.Operation = "SubscriptionApi.Get";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-token")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-token", this.Configuration.GetApiKeyWithPrefix("x-api-token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<SubscriptionResponse>("/api/subscription", localVarRequestOptions, this.Configuration);
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
        /// [Get] Get My Plan Info This endpoint allows you to get info about your subscription plan.
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SubscriptionResponse</returns>
        public async System.Threading.Tasks.Task<SubscriptionResponse> GetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Newscatcherapi.Net.Client.ApiResponse<SubscriptionResponse> localVarResponse = await GetWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [Get] Get My Plan Info This endpoint allows you to get info about your subscription plan.
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SubscriptionResponse)</returns>
        public async System.Threading.Tasks.Task<Newscatcherapi.Net.Client.ApiResponse<SubscriptionResponse>> GetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            localVarRequestOptions.Operation = "SubscriptionApi.Get";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-token")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-token", this.Configuration.GetApiKeyWithPrefix("x-api-token"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<SubscriptionResponse>("/api/subscription", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

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
        /// [Post] Get My Plan Info This endpoint allows you to get info about your subscription plan.
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SubscriptionResponse</returns>
        public SubscriptionResponse Post(int operationIndex = 0)
        {
            Newscatcherapi.Net.Client.ApiResponse<SubscriptionResponse> localVarResponse = PostWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// [Post] Get My Plan Info This endpoint allows you to get info about your subscription plan.
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SubscriptionResponse</returns>
        public Newscatcherapi.Net.Client.ApiResponse<SubscriptionResponse> PostWithHttpInfo(int operationIndex = 0)
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


            localVarRequestOptions.Operation = "SubscriptionApi.Post";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-token")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-token", this.Configuration.GetApiKeyWithPrefix("x-api-token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<SubscriptionResponse>("/api/subscription", localVarRequestOptions, this.Configuration);
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
        /// [Post] Get My Plan Info This endpoint allows you to get info about your subscription plan.
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SubscriptionResponse</returns>
        public async System.Threading.Tasks.Task<SubscriptionResponse> PostAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Newscatcherapi.Net.Client.ApiResponse<SubscriptionResponse> localVarResponse = await PostWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [Post] Get My Plan Info This endpoint allows you to get info about your subscription plan.
        /// </summary>
        /// <exception cref="Newscatcherapi.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SubscriptionResponse)</returns>
        public async System.Threading.Tasks.Task<Newscatcherapi.Net.Client.ApiResponse<SubscriptionResponse>> PostWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            localVarRequestOptions.Operation = "SubscriptionApi.Post";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-token")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-token", this.Configuration.GetApiKeyWithPrefix("x-api-token"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<SubscriptionResponse>("/api/subscription", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

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

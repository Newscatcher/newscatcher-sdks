/*
 * NewsCatcher-V3 Production API
 *
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>
 *
 * The version of the OpenAPI document: 3.2.16
 * Contact: maksym@newscatcherapi.com
 * Generated by: https://konfigthis.com
 */


using Newscatcherapi.Net.Api;

namespace Newscatcherapi.Net.Client
{
    /// <summary>
    ///  SDK client
    /// </summary>
    public class NewscatcherClient
    {
        /// <summary>
        /// API instance
        /// </summary>
        public virtual AuthorsApi Authors { get; set; }

        /// <summary>
        /// API instance
        /// </summary>
        public virtual LatestHeadlinesApi LatestHeadlines { get; set; }

        /// <summary>
        /// API instance
        /// </summary>
        public virtual SearchApi Search { get; set; }

        /// <summary>
        /// API instance
        /// </summary>
        public virtual SearchLinkApi SearchLink { get; set; }

        /// <summary>
        /// API instance
        /// </summary>
        public virtual SearchSimilarApi SearchSimilar { get; set; }

        /// <summary>
        /// API instance
        /// </summary>
        public virtual SourcesApi Sources { get; set; }

        /// <summary>
        /// API instance
        /// </summary>
        public virtual SubscriptionApi Subscription { get; set; }

        /// <summary>
        /// Configuration instance
        /// </summary>
        public readonly Configuration Configuration;

        /// <summary>
        /// Constructor
        /// </summary>
        public NewscatcherClient()
        {
            Configuration = new Configuration();
            init();
        }

        private void init()
        {
            Authors = new AuthorsApi(Configuration);
            LatestHeadlines = new LatestHeadlinesApi(Configuration);
            Search = new SearchApi(Configuration);
            SearchLink = new SearchLinkApi(Configuration);
            SearchSimilar = new SearchSimilarApi(Configuration);
            Sources = new SourcesApi(Configuration);
            Subscription = new SubscriptionApi(Configuration);
        }

        /// <summary>
        /// Setter for base path
        /// </summary>
        public NewscatcherClient SetBasePath(string basePath)
        {
            Configuration.BasePath = basePath;
            init();
            return this;
        }

        /// <summary>
        /// Setter for verify SSL configuration. Set to false when you want to disable SSL verification.
        /// </summary>
        public NewscatcherClient SetVerifySsl(bool verifySsl)
        {
            Configuration.VerifySsl = verifySsl;
            init();
            return this;
        }

        /// <summary>
        /// Setter for Access Token
        /// </summary>
        public NewscatcherClient SetAccessToken(string accessToken)
        {
            Configuration.AccessToken = accessToken;
            init();
            return this;
        }

        /// <summary>
        /// Setter for API Key
        /// </summary>
        public NewscatcherClient SetApiKey(string apiKey)
        {
            Configuration.ApiKey["x-api-token"] = apiKey;
            init();
            return this;
        }
    }
}

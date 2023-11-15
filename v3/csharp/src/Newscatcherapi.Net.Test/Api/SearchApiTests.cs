/*
 * NewsCatcher-V3 Production API
 *
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a> <br> <p style=\"color: red\"><b><em> This is a Testing Phase API. Please use it for testing purposes only. </em></b></p> <br>
 *
 * The version of the OpenAPI document: Beta-3.0.0
 * Contact: maksym@newscatcherapi.com
 * Generated by: https://konfigthis.com
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Newscatcherapi.Net.Client;
using Newscatcherapi.Net.Api;
using Newscatcherapi.Net.Model;

namespace Newscatcherapi.Net.Test.Api
{
    /// <summary>
    ///  Class for testing SearchApi
    /// </summary>
    public class SearchApiTests : IDisposable
    {
        private NewscatcherClient client;

        public SearchApiTests()
        {
            client = new NewscatcherClient();
            client.SetBasePath("http://127.0.0.1:4010");
            // Configure API key authorization: apiKey
            client.SetApiKey("YOUR_API_KEY");

        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test Get
        /// </summary>
        [Fact]
        public void GetTest()
        {
            var q = "q_example";
            var searchIn = "title_content";
            var predefinedSources = "predefinedSources_example";
            var sources = "sources_example";
            var notSources = "notSources_example";
            var lang = "lang_example";
            var notLang = "notLang_example";
            var countries = "countries_example";
            var notCountries = "notCountries_example";
            var from = new From(
            );
            var to = new To(
            );
            var publishedDatePrecision = "publishedDatePrecision_example";
            var byParseDate = false;
            var sortBy = "relevancy";
            var rankedOnly = "rankedOnly_example";
            var fromRank = 56;
            var toRank = 56;
            var isHeadline = true;
            var isPaidContent = true;
            var parentUrl = "parentUrl_example";
            var allLinks = "allLinks_example";
            var allDomainLinks = "allDomainLinks_example";
            var wordCountMin = 56;
            var wordCountMax = 56;
            var page = 1;
            var pageSize = 100;
            var clusteringEnabled = true;
            var clusteringThreshold = 8.14D;
            var clusteringVariable = "clusteringVariable_example";
            var includeNlpData = true;
            var hasNlp = true;
            var theme = "theme_example";
            var oRGEntityName = "oRGEntityName_example";
            var pEREntityName = "pEREntityName_example";
            var lOCEntityName = "lOCEntityName_example";
            var mISCEntityName = "mISCEntityName_example";
            var titleSentimentMin = 8.14D;
            var titleSentimentMax = 8.14D;
            var contentSentimentMin = 8.14D;
            var contentSentimentMax = 8.14D;
            
            try
            {
                // [Get] Search For Articles Request
                SearchGetResponse result = client.Search.Get(q, searchIn, predefinedSources, sources, notSources, lang, notLang, countries, notCountries, from, to, publishedDatePrecision, byParseDate, sortBy, rankedOnly, fromRank, toRank, isHeadline, isPaidContent, parentUrl, allLinks, allDomainLinks, wordCountMin, wordCountMax, page, pageSize, clusteringEnabled, clusteringThreshold, clusteringVariable, includeNlpData, hasNlp, theme, oRGEntityName, pEREntityName, lOCEntityName, mISCEntityName, titleSentimentMin, titleSentimentMax, contentSentimentMin, contentSentimentMax);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SearchApi.Get: " + e.Message);
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.Response.StatusCode);
                Console.WriteLine(e.Response.RawContent);
                Console.WriteLine(e.InnerException);
            }
        }

        /// <summary>
        /// Test Post
        /// </summary>
        [Fact]
        public void PostTest()
        {
            var q = "q_example";
            var searchIn = "title_content";
            var predefinedSources = "predefinedSources_example";
            var sources = "sources_example";
            var notSources = "notSources_example";
            var lang = "lang_example";
            var notLang = "notLang_example";
            var countries = "countries_example";
            var notCountries = "notCountries_example";
            var from = new From();
            var to = new To();
            var publishedDatePrecision = "publishedDatePrecision_example";
            var byParseDate = false;
            var sortBy = "relevancy";
            var rankedOnly = "rankedOnly_example";
            var isHeadline = false;
            var isPaidContent = false;
            var parentUrl = "parentUrl_example";
            var allLinks = "allLinks_example";
            var allDomainLinks = "allDomainLinks_example";
            var page = 1;
            var pageSize = 100;
            var clusteringEnabled = false;
            var clusteringThreshold = default(double);
            var clusteringVariable = "clusteringVariable_example";
            var includeNlpData = false;
            var hasNlp = false;
            var theme = "theme_example";
            var oRGEntityName = "oRGEntityName_example";
            var pEREntityName = "pEREntityName_example";
            var lOCEntityName = "lOCEntityName_example";
            var mISCEntityName = "mISCEntityName_example";
            var titleSentimentMin = default(double);
            var titleSentimentMax = default(double);
            var contentSentimentMin = default(double);
            var contentSentimentMax = default(double);
            
            var searchRequest = new SearchRequest(
                q,
                searchIn,
                predefinedSources,
                sources,
                notSources,
                lang,
                notLang,
                countries,
                notCountries,
                from,
                to,
                publishedDatePrecision,
                byParseDate,
                sortBy,
                rankedOnly,
                fromRank,
                toRank,
                isHeadline,
                isPaidContent,
                parentUrl,
                allLinks,
                allDomainLinks,
                wordCountMin,
                wordCountMax,
                page,
                pageSize,
                clusteringEnabled,
                clusteringThreshold,
                clusteringVariable,
                includeNlpData,
                hasNlp,
                theme,
                oRGEntityName,
                pEREntityName,
                lOCEntityName,
                mISCEntityName,
                titleSentimentMin,
                titleSentimentMax,
                contentSentimentMin,
                contentSentimentMax
            );
            
            try
            {
                // [Post] Search For Articles Request
                SearchPostResponse result = client.Search.Post(searchRequest);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SearchApi.Post: " + e.Message);
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.Response.StatusCode);
                Console.WriteLine(e.Response.RawContent);
                Console.WriteLine(e.InnerException);
            }
        }
    }
}

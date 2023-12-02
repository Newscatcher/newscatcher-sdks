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
    ///  Class for testing LatestHeadlinesApi
    /// </summary>
    public class LatestHeadlinesApiTests : IDisposable
    {
        private NewscatcherClient client;

        public LatestHeadlinesApiTests()
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
            var when = "7d";
            var byParseDate = false;
            var lang = "lang_example";
            var notLang = "notLang_example";
            var countries = "countries_example";
            var notCountries = "notCountries_example";
            var sources = "sources_example";
            var predefinedSources = "predefinedSources_example";
            var notSources = "notSources_example";
            var rankedOnly = "rankedOnly_example";
            var isHeadline = true;
            var isPaidContent = true;
            var parentUrl = "parentUrl_example";
            var theme = "theme_example";
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
                // [Get] Search For Latest Headlines Request
                LatestHeadlinesGetResponse result = client.LatestHeadlines.Get(when, byParseDate, lang, notLang, countries, notCountries, sources, predefinedSources, notSources, rankedOnly, isHeadline, isPaidContent, parentUrl, theme, allLinks, allDomainLinks, wordCountMin, wordCountMax, page, pageSize, clusteringEnabled, clusteringThreshold, clusteringVariable, includeNlpData, hasNlp, oRGEntityName, pEREntityName, lOCEntityName, mISCEntityName, titleSentimentMin, titleSentimentMax, contentSentimentMin, contentSentimentMax);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling LatestHeadlinesApi.Get: " + e.Message);
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
            var when = "7d";
            var byParseDate = false;
            var lang = "lang_example";
            var notLang = "notLang_example";
            var countries = "countries_example";
            var notCountries = "notCountries_example";
            var sources = "sources_example";
            var predefinedSources = "predefinedSources_example";
            var notSources = "notSources_example";
            var rankedOnly = "rankedOnly_example";
            var isHeadline = false;
            var isPaidContent = false;
            var parentUrl = "parentUrl_example";
            var theme = "theme_example";
            var allLinks = "allLinks_example";
            var allDomainLinks = "allDomainLinks_example";
            var wordCountMin = default(int);
            var wordCountMax = default(int);
            var page = 1;
            var pageSize = 100;
            var clusteringEnabled = false;
            var clusteringThreshold = default(double);
            var clusteringVariable = "clusteringVariable_example";
            var includeNlpData = false;
            var hasNlp = false;
            var oRGEntityName = "oRGEntityName_example";
            var pEREntityName = "pEREntityName_example";
            var lOCEntityName = "lOCEntityName_example";
            var mISCEntityName = "mISCEntityName_example";
            var titleSentimentMin = default(double);
            var titleSentimentMax = default(double);
            var contentSentimentMin = default(double);
            var contentSentimentMax = default(double);
            
            var latestHeadlinesRequest = new LatestHeadlinesRequest(
                when,
                byParseDate,
                lang,
                notLang,
                countries,
                notCountries,
                sources,
                predefinedSources,
                notSources,
                rankedOnly,
                isHeadline,
                isPaidContent,
                parentUrl,
                theme,
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
                // [Post] Search For Latest Headlines Request
                LatestHeadlinesPostResponse result = client.LatestHeadlines.Post(latestHeadlinesRequest);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling LatestHeadlinesApi.Post: " + e.Message);
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

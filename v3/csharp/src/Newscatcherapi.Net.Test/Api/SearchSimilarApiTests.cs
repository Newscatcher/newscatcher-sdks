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
    ///  Class for testing SearchSimilarApi
    /// </summary>
    public class SearchSimilarApiTests : IDisposable
    {
        private NewscatcherClient client;

        public SearchSimilarApiTests()
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
            var includeSimilarDocuments = false;
            var similarDocumentsNumber = 5;
            var similarDocumentsFields = "title,content";
            var predefinedSources = new Object(
            );
            var sources = new Object(
            );
            var notSources = new Object(
            );
            var lang = new Object(
            );
            var notLang = new Object(
            );
            var countries = new Object(
            );
            var notCountries = new Object(
            );
            var from = new From(DateTime.Now);
            var to = new To(DateTime.Now);
            var byParseDate = false;
            var publishedDatePrecision = "publishedDatePrecision_example";
            var sortBy = "relevancy";
            var rankedOnly = "rankedOnly_example";
            var fromRank = 56;
            var toRank = 56;
            var isHeadline = true;
            var isPaidContent = true;
            var parentUrl = new Object(
            );
            var allLinks = new Object(
            );
            var allDomainLinks = new Object(
            );
            var wordCountMin = 56;
            var wordCountMax = 56;
            var page = 1;
            var pageSize = 100;
            var includeNlpData = true;
            var hasNlp = true;
            var theme = "theme_example";
            var notTheme = "notTheme_example";
            var nerName = "nerName_example";
            var titleSentimentMin = 8.14D;
            var titleSentimentMax = 8.14D;
            var contentSentimentMin = 8.14D;
            var contentSentimentMax = 8.14D;
            var iptcTags = new Object(
            );
            var notIptcTags = new Object(
            );
            
            try
            {
                // [Get] Search For Similar Articles Request
                SearchSimilarGetResponse result = client.SearchSimilar.Get(q, searchIn, includeSimilarDocuments, similarDocumentsNumber, similarDocumentsFields, predefinedSources, sources, notSources, lang, notLang, countries, notCountries, from, to, byParseDate, publishedDatePrecision, sortBy, rankedOnly, fromRank, toRank, isHeadline, isPaidContent, parentUrl, allLinks, allDomainLinks, wordCountMin, wordCountMax, page, pageSize, includeNlpData, hasNlp, theme, notTheme, nerName, titleSentimentMin, titleSentimentMax, contentSentimentMin, contentSentimentMax, iptcTags, notIptcTags);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SearchSimilarApi.Get: " + e.Message);
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
            var includeSimilarDocuments = false;
            var similarDocumentsNumber = 5;
            var similarDocumentsFields = "title,content";
            var predefinedSources = "predefinedSources_example";
            var sources = "sources_example";
            var notSources = "notSources_example";
            var lang = "lang_example";
            var notLang = "notLang_example";
            var countries = "countries_example";
            var notCountries = "notCountries_example";
            var from = new From(DateTime.Now);
            var to = new To(DateTime.Now);
            var byParseDate = false;
            var publishedDatePrecision = "publishedDatePrecision_example";
            var sortBy = "relevancy";
            var rankedOnly = "rankedOnly_example";
            var fromRank = default(int);
            var toRank = default(int);
            var isHeadline = false;
            var isPaidContent = false;
            var parentUrl = "parentUrl_example";
            var allLinks = "allLinks_example";
            var allDomainLinks = "allDomainLinks_example";
            var wordCountMin = default(int);
            var wordCountMax = default(int);
            var page = 1;
            var pageSize = 100;
            var includeNlpData = false;
            var hasNlp = false;
            var theme = "theme_example";
            var notTheme = "notTheme_example";
            var nerName = "nerName_example";
            var titleSentimentMin = default(double);
            var titleSentimentMax = default(double);
            var contentSentimentMin = default(double);
            var contentSentimentMax = default(double);
            var iptcTags = "iptcTags_example";
            var notIptcTags = "notIptcTags_example";
            
            var moreLikeThisRequest = new MoreLikeThisRequest(
                q,
                searchIn,
                includeSimilarDocuments,
                similarDocumentsNumber,
                similarDocumentsFields,
                predefinedSources,
                sources,
                notSources,
                lang,
                notLang,
                countries,
                notCountries,
                from,
                to,
                byParseDate,
                publishedDatePrecision,
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
                includeNlpData,
                hasNlp,
                theme,
                notTheme,
                nerName,
                titleSentimentMin,
                titleSentimentMax,
                contentSentimentMin,
                contentSentimentMax,
                iptcTags,
                notIptcTags
            );
            
            try
            {
                // [Post] Search For Similar Articles Request
                SearchSimilarPostResponse result = client.SearchSimilar.Post(moreLikeThisRequest);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SearchSimilarApi.Post: " + e.Message);
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

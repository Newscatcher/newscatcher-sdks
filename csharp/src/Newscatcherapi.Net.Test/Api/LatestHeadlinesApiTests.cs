/*
 * NewsCatcher News API V2
 *
 * NewsCatcher is a data-as-a-service startup that has one main goal: to build the largest database of structured news articles published online. In other words, we're like Google for the news part of the web, which you can access as a source of data.  Some useful links: - [How NewsCatcher Works](https://docs.newscatcherapi.com/knowledge-base/how-newscatcher-works) - [GitHub for the Python SDK](https://github.com/NewscatcherAPI/newscatcherapi-sdk-python) 
 *
 * The version of the OpenAPI document: 1.0.1
 * Contact: team@newscatcherapi.com
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
// uncomment below to import models
//using Newscatcherapi.Net.Model;

namespace Newscatcherapi.Net.Test.Api
{
    /// <summary>
    ///  Class for testing LatestHeadlinesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Konfig (https://konfigthis.com).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LatestHeadlinesApiTests : IDisposable
    {
        private LatestHeadlinesApi instance;

        public LatestHeadlinesApiTests()
        {
            Configuration config = new Configuration();
            string apiKey = System.Environment.GetEnvironmentVariable("NEWSCATCHER_API_KEY");
            config.ApiKey.Add("x-api-key", apiKey);
            instance = new LatestHeadlinesApi(config);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LatestHeadlinesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LatestHeadlinesApi
            //Assert.IsType<LatestHeadlinesApi>(instance);
        }

        /// <summary>
        /// Test Get
        /// </summary>
        [Fact]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string lang = null;
            //string notLang = null;
            //string countries = null;
            //string notCountries = null;
            //Topic? topic = null;
            //string sources = null;
            //string notSources = null;
            //bool? rankedOnly = null;
            //int? pageSize = null;
            //int? page = null;
            //var response = instance.Get(lang, notLang, countries, notCountries, topic, sources, notSources, rankedOnly, pageSize, page);
            //Assert.IsType<Model200ResponseLatest>(response);
        }

        /// <summary>
        /// Test Post
        /// </summary>
        [Fact]
        public void PostTest()
        {
            LatestHeadlines latestHeadlines = new LatestHeadlines(null, LatestHeadlines.LangEnum.En);
            var response = instance.Post(latestHeadlines);
            Assert.IsType<Model200ResponseLatest>(response);
        }
    }
}

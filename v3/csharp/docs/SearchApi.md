# Newscatcherapi.Net.Api.SearchApi

All URIs are relative to *https://v3-api.newscatcherapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Get**](SearchApi.md#get) | **GET** /api/search | [Get] Search For Articles Request |
| [**Post**](SearchApi.md#post) | **POST** /api/search | [Post] Search For Articles Request |


# **Get**



This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.

### Example
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newscatcherapi.Net.Client;
using Newscatcherapi.Net.Model;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            NewscatcherClient client = new NewscatcherClient();
            // Configure API key authorization: apiKey
            client.SetApiKey("YOUR_API_KEY");

            var q = "q_example";
            var searchIn = "title_content";
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
            var notAuthorName = new Object(
            );
            var from = new From(DateTime.Now);
            var to = new To(DateTime.Now);
            var publishedDatePrecision = "publishedDatePrecision_example";
            var byParseDate = new ByParseDate("example");
            var sortBy = "relevancy";
            var rankedOnly = new RankedOnly("example");
            var fromRank = new FromRank("example");
            var toRank = new ToRank("example");
            var isHeadline = new IsHeadline("example");
            var isOpinion = new IsOpinion("example");
            var isPaidContent = new IsPaidContent("example");
            var parentUrl = new Object(
            );
            var allLinks = new Object(
            );
            var allDomainLinks = new Object(
            );
            var wordCountMin = new WordCountMin("example");
            var wordCountMax = new WordCountMax("example");
            var page = new Page("example");
            var pageSize = new PageSize("example");
            var clusteringVariable = "clusteringVariable_example";
            var clusteringEnabled = new ClusteringEnabled("example");
            var clusteringThreshold = new ClusteringThreshold(100);
            var includeNlpData = new IncludeNlpData("example");
            var hasNlp = true;
            var theme = "theme_example";
            var notTheme = "notTheme_example";
            var oRGEntityName = "oRGEntityName_example";
            var pEREntityName = "pEREntityName_example";
            var lOCEntityName = "lOCEntityName_example";
            var mISCEntityName = "mISCEntityName_example";
            var titleSentimentMin = 8.14D;
            var titleSentimentMax = 8.14D;
            var contentSentimentMin = 8.14D;
            var contentSentimentMax = 8.14D;
            var iptcTags = new Object(
            );
            var notIptcTags = new Object(
            );
            var sourceName = new Object(
            );
            var iabTags = new Object(
            );
            var notIabTags = new Object(
            );
            var excludeDuplicates = true;
            var additionalDomainInfo = true;
            var isNewsDomain = true;
            var newsDomainType = new Object(
            );
            var newsType = new Object(
            );
            
            try
            {
                // [Get] Search For Articles Request
                SearchGetResponse result = client.Search.Get(q, searchIn, predefinedSources, sources, notSources, lang, notLang, countries, notCountries, notAuthorName, from, to, publishedDatePrecision, byParseDate, sortBy, rankedOnly, fromRank, toRank, isHeadline, isOpinion, isPaidContent, parentUrl, allLinks, allDomainLinks, wordCountMin, wordCountMax, page, pageSize, clusteringVariable, clusteringEnabled, clusteringThreshold, includeNlpData, hasNlp, theme, notTheme, oRGEntityName, pEREntityName, lOCEntityName, mISCEntityName, titleSentimentMin, titleSentimentMax, contentSentimentMin, contentSentimentMax, iptcTags, notIptcTags, sourceName, iabTags, notIabTags, excludeDuplicates, additionalDomainInfo, isNewsDomain, newsDomainType, newsType);
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
    }
}
```

#### Using the GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [Get] Search For Articles Request
    ApiResponse<SearchGetResponse> response = apiInstance.GetWithHttpInfo(q, searchIn, predefinedSources, sources, notSources, lang, notLang, countries, notCountries, notAuthorName, from, to, publishedDatePrecision, byParseDate, sortBy, rankedOnly, fromRank, toRank, isHeadline, isOpinion, isPaidContent, parentUrl, allLinks, allDomainLinks, wordCountMin, wordCountMax, page, pageSize, clusteringVariable, clusteringEnabled, clusteringThreshold, includeNlpData, hasNlp, theme, notTheme, oRGEntityName, pEREntityName, lOCEntityName, mISCEntityName, titleSentimentMin, titleSentimentMax, contentSentimentMin, contentSentimentMax, iptcTags, notIptcTags, sourceName, iabTags, notIabTags, excludeDuplicates, additionalDomainInfo, isNewsDomain, newsDomainType, newsType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string** |  |  |
| **searchIn** | **string** |  | [optional] [default to &quot;title_content&quot;] |
| **predefinedSources** | [**Object**](Object.md) |  | [optional]  |
| **sources** | [**Object**](Object.md) |  | [optional]  |
| **notSources** | [**Object**](Object.md) |  | [optional]  |
| **lang** | [**Object**](Object.md) |  | [optional]  |
| **notLang** | [**Object**](Object.md) |  | [optional]  |
| **countries** | [**Object**](Object.md) |  | [optional]  |
| **notCountries** | [**Object**](Object.md) |  | [optional]  |
| **notAuthorName** | [**Object**](Object.md) |  | [optional]  |
| **from** | [**From**](From.md) |  | [optional]  |
| **to** | [**To**](To.md) |  | [optional]  |
| **publishedDatePrecision** | **string** |  | [optional]  |
| **byParseDate** | [**ByParseDate**](ByParseDate.md) |  | [optional]  |
| **sortBy** | **string** |  | [optional] [default to &quot;relevancy&quot;] |
| **rankedOnly** | [**RankedOnly**](RankedOnly.md) |  | [optional]  |
| **fromRank** | [**FromRank**](FromRank.md) |  | [optional]  |
| **toRank** | [**ToRank**](ToRank.md) |  | [optional]  |
| **isHeadline** | [**IsHeadline**](IsHeadline.md) |  | [optional]  |
| **isOpinion** | [**IsOpinion**](IsOpinion.md) |  | [optional]  |
| **isPaidContent** | [**IsPaidContent**](IsPaidContent.md) |  | [optional]  |
| **parentUrl** | [**Object**](Object.md) |  | [optional]  |
| **allLinks** | [**Object**](Object.md) |  | [optional]  |
| **allDomainLinks** | [**Object**](Object.md) |  | [optional]  |
| **wordCountMin** | [**WordCountMin**](WordCountMin.md) |  | [optional]  |
| **wordCountMax** | [**WordCountMax**](WordCountMax.md) |  | [optional]  |
| **page** | [**Page**](Page.md) |  | [optional]  |
| **pageSize** | [**PageSize**](PageSize.md) |  | [optional]  |
| **clusteringVariable** | **string** |  | [optional]  |
| **clusteringEnabled** | [**ClusteringEnabled**](ClusteringEnabled.md) |  | [optional]  |
| **clusteringThreshold** | [**ClusteringThreshold**](ClusteringThreshold.md) |  | [optional]  |
| **includeNlpData** | [**IncludeNlpData**](IncludeNlpData.md) |  | [optional]  |
| **hasNlp** | **bool?** |  | [optional]  |
| **theme** | **string** |  | [optional]  |
| **notTheme** | **string** |  | [optional]  |
| **oRGEntityName** | **string** |  | [optional]  |
| **pEREntityName** | **string** |  | [optional]  |
| **lOCEntityName** | **string** |  | [optional]  |
| **mISCEntityName** | **string** |  | [optional]  |
| **titleSentimentMin** | **double?** |  | [optional]  |
| **titleSentimentMax** | **double?** |  | [optional]  |
| **contentSentimentMin** | **double?** |  | [optional]  |
| **contentSentimentMax** | **double?** |  | [optional]  |
| **iptcTags** | [**Object**](Object.md) |  | [optional]  |
| **notIptcTags** | [**Object**](Object.md) |  | [optional]  |
| **sourceName** | [**Object**](Object.md) |  | [optional]  |
| **iabTags** | [**Object**](Object.md) |  | [optional]  |
| **notIabTags** | [**Object**](Object.md) |  | [optional]  |
| **excludeDuplicates** | **bool?** |  | [optional]  |
| **additionalDomainInfo** | **bool?** |  | [optional]  |
| **isNewsDomain** | **bool?** |  | [optional]  |
| **newsDomainType** | [**Object**](Object.md) |  | [optional]  |
| **newsType** | [**Object**](Object.md) |  | [optional]  |

### Return type

[**SearchGetResponse**](SearchGetResponse.md)


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# **Post**



This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.

### Example
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newscatcherapi.Net.Client;
using Newscatcherapi.Net.Model;

namespace Example
{
    public class PostExample
    {
        public static void Main()
        {
            NewscatcherClient client = new NewscatcherClient();
            // Configure API key authorization: apiKey
            client.SetApiKey("YOUR_API_KEY");

            var q = "q_example";
            var searchIn = "title_content";
            var predefinedSources = "predefinedSources_example";
            var sources = "sources_example";
            var notSources = "notSources_example";
            var lang = "lang_example";
            var notLang = "notLang_example";
            var countries = "countries_example";
            var notCountries = "notCountries_example";
            var notAuthorName = "notAuthorName_example";
            var from = new From(DateTime.Now);
            var to = new To(DateTime.Now);
            var publishedDatePrecision = "publishedDatePrecision_example";
            var byParseDate = new ByParseDate("example");
            var sortBy = "relevancy";
            var rankedOnly = new RankedOnly("example");
            var fromRank = new FromRank("example");
            var toRank = new ToRank("example");
            var isHeadline = new IsHeadline("example");
            var isOpinion = new IsOpinion("example");
            var isPaidContent = new IsPaidContent("example");
            var parentUrl = "parentUrl_example";
            var allLinks = "allLinks_example";
            var allDomainLinks = "allDomainLinks_example";
            var wordCountMin = new WordCountMin("example");
            var wordCountMax = new WordCountMax("example");
            var page = new Page("example");
            var pageSize = new PageSize("example");
            var clusteringVariable = "clusteringVariable_example";
            var clusteringEnabled = new ClusteringEnabled("example");
            var clusteringThreshold = new ClusteringThreshold(100);
            var includeNlpData = new IncludeNlpData("example");
            var hasNlp = false;
            var theme = "theme_example";
            var notTheme = "notTheme_example";
            var oRGEntityName = "oRGEntityName_example";
            var pEREntityName = "pEREntityName_example";
            var lOCEntityName = "lOCEntityName_example";
            var mISCEntityName = "mISCEntityName_example";
            var titleSentimentMin = default(double);
            var titleSentimentMax = default(double);
            var contentSentimentMin = default(double);
            var contentSentimentMax = default(double);
            var iptcTags = "iptcTags_example";
            var notIptcTags = "notIptcTags_example";
            var sourceName = "sourceName_example";
            var iabTags = "iabTags_example";
            var notIabTags = "notIabTags_example";
            var excludeDuplicates = false;
            var additionalDomainInfo = false;
            var isNewsDomain = false;
            var newsDomainType = "newsDomainType_example";
            var newsType = "newsType_example";
            
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
                notAuthorName,
                from,
                to,
                publishedDatePrecision,
                byParseDate,
                sortBy,
                rankedOnly,
                fromRank,
                toRank,
                isHeadline,
                isOpinion,
                isPaidContent,
                parentUrl,
                allLinks,
                allDomainLinks,
                wordCountMin,
                wordCountMax,
                page,
                pageSize,
                clusteringVariable,
                clusteringEnabled,
                clusteringThreshold,
                includeNlpData,
                hasNlp,
                theme,
                notTheme,
                oRGEntityName,
                pEREntityName,
                lOCEntityName,
                mISCEntityName,
                titleSentimentMin,
                titleSentimentMax,
                contentSentimentMin,
                contentSentimentMax,
                iptcTags,
                notIptcTags,
                sourceName,
                iabTags,
                notIabTags,
                excludeDuplicates,
                additionalDomainInfo,
                isNewsDomain,
                newsDomainType,
                newsType
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
```

#### Using the PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [Post] Search For Articles Request
    ApiResponse<SearchPostResponse> response = apiInstance.PostWithHttpInfo(searchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchRequest** | [**SearchRequest**](SearchRequest.md) |  |  |

### Return type

[**SearchPostResponse**](SearchPostResponse.md)


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


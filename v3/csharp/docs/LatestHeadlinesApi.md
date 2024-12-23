# Newscatcherapi.Net.Api.LatestHeadlinesApi

All URIs are relative to *https://v3-api.newscatcherapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Get**](LatestHeadlinesApi.md#get) | **GET** /api/latest_headlines | [Get] Search For Latest Headlines Request |
| [**Post**](LatestHeadlinesApi.md#post) | **POST** /api/latest_headlines | [Post] Search For Latest Headlines Request |


# **Get**



This endpoint allows you to get latest headlines. You need to specify since when you want to get the latest headlines. You can also filter by language, country, source, and more.

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

            var when = "7d";
            var byParseDate = new ByParseDate("example");
            var sortBy = "relevancy";
            var lang = new Object(
            );
            var notLang = new Object(
            );
            var countries = new Object(
            );
            var notCountries = new Object(
            );
            var sources = new Object(
            );
            var predefinedSources = new Object(
            );
            var notSources = new Object(
            );
            var notAuthorName = new Object(
            );
            var rankedOnly = new RankedOnly("example");
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
            var includeNlpData = true;
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
            var iabTags = new Object(
            );
            var notIabTags = new Object(
            );
            
            try
            {
                // [Get] Search For Latest Headlines Request
                LatestHeadlinesGetResponse result = client.LatestHeadlines.Get(when, byParseDate, sortBy, lang, notLang, countries, notCountries, sources, predefinedSources, notSources, notAuthorName, rankedOnly, isHeadline, isOpinion, isPaidContent, parentUrl, allLinks, allDomainLinks, wordCountMin, wordCountMax, page, pageSize, clusteringVariable, clusteringEnabled, clusteringThreshold, includeNlpData, hasNlp, theme, notTheme, oRGEntityName, pEREntityName, lOCEntityName, mISCEntityName, titleSentimentMin, titleSentimentMax, contentSentimentMin, contentSentimentMax, iptcTags, notIptcTags, iabTags, notIabTags);
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
    }
}
```

#### Using the GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [Get] Search For Latest Headlines Request
    ApiResponse<LatestHeadlinesGetResponse> response = apiInstance.GetWithHttpInfo(when, byParseDate, sortBy, lang, notLang, countries, notCountries, sources, predefinedSources, notSources, notAuthorName, rankedOnly, isHeadline, isOpinion, isPaidContent, parentUrl, allLinks, allDomainLinks, wordCountMin, wordCountMax, page, pageSize, clusteringVariable, clusteringEnabled, clusteringThreshold, includeNlpData, hasNlp, theme, notTheme, oRGEntityName, pEREntityName, lOCEntityName, mISCEntityName, titleSentimentMin, titleSentimentMax, contentSentimentMin, contentSentimentMax, iptcTags, notIptcTags, iabTags, notIabTags);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LatestHeadlinesApi.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **when** | **string** |  | [optional] [default to &quot;7d&quot;] |
| **byParseDate** | [**ByParseDate**](ByParseDate.md) |  | [optional]  |
| **sortBy** | **string** |  | [optional] [default to &quot;relevancy&quot;] |
| **lang** | [**Object**](Object.md) |  | [optional]  |
| **notLang** | [**Object**](Object.md) |  | [optional]  |
| **countries** | [**Object**](Object.md) |  | [optional]  |
| **notCountries** | [**Object**](Object.md) |  | [optional]  |
| **sources** | [**Object**](Object.md) |  | [optional]  |
| **predefinedSources** | [**Object**](Object.md) |  | [optional]  |
| **notSources** | [**Object**](Object.md) |  | [optional]  |
| **notAuthorName** | [**Object**](Object.md) |  | [optional]  |
| **rankedOnly** | [**RankedOnly**](RankedOnly.md) |  | [optional]  |
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
| **includeNlpData** | **bool?** |  | [optional]  |
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
| **iabTags** | [**Object**](Object.md) |  | [optional]  |
| **notIabTags** | [**Object**](Object.md) |  | [optional]  |

### Return type

[**LatestHeadlinesGetResponse**](LatestHeadlinesGetResponse.md)


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# **Post**



This endpoint allows you to get latest headlines. You need to specify since when you want to get the latest headlines. You can also filter by language, country, source, and more.

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

            var when = "7d";
            var byParseDate = new ByParseDate("example");
            var sortBy = "relevancy";
            var lang = "lang_example";
            var notLang = "notLang_example";
            var countries = "countries_example";
            var notCountries = "notCountries_example";
            var sources = "sources_example";
            var predefinedSources = "predefinedSources_example";
            var notSources = "notSources_example";
            var notAuthorName = "notAuthorName_example";
            var rankedOnly = new RankedOnly("example");
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
            var includeNlpData = false;
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
            var iabTags = "iabTags_example";
            var notIabTags = "notIabTags_example";
            
            var latestHeadlinesRequest = new LatestHeadlinesRequest(
                when,
                byParseDate,
                sortBy,
                lang,
                notLang,
                countries,
                notCountries,
                sources,
                predefinedSources,
                notSources,
                notAuthorName,
                rankedOnly,
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
                iabTags,
                notIabTags
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
```

#### Using the PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [Post] Search For Latest Headlines Request
    ApiResponse<LatestHeadlinesPostResponse> response = apiInstance.PostWithHttpInfo(latestHeadlinesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LatestHeadlinesApi.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **latestHeadlinesRequest** | [**LatestHeadlinesRequest**](LatestHeadlinesRequest.md) |  |  |

### Return type

[**LatestHeadlinesPostResponse**](LatestHeadlinesPostResponse.md)


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


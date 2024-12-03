# SearchApi

All URIs are relative to *https://v3-api.newscatcherapi.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**get**](SearchApi.md#get) | **GET** /api/search | [Get] Search For Articles Request |
| [**post**](SearchApi.md#post) | **POST** /api/search | [Post] Search For Articles Request |


<a name="get"></a>
# **get**
> CSearchResponse get(q).searchIn(searchIn).predefinedSources(predefinedSources).sources(sources).notSources(notSources).lang(lang).notLang(notLang).countries(countries).notCountries(notCountries).notAuthorName(notAuthorName).from(from).to(to).publishedDatePrecision(publishedDatePrecision).byParseDate(byParseDate).sortBy(sortBy).rankedOnly(rankedOnly).fromRank(fromRank).toRank(toRank).isHeadline(isHeadline).isOpinion(isOpinion).isPaidContent(isPaidContent).parentUrl(parentUrl).allLinks(allLinks).allDomainLinks(allDomainLinks).wordCountMin(wordCountMin).wordCountMax(wordCountMax).page(page).pageSize(pageSize).clusteringVariable(clusteringVariable).clusteringEnabled(clusteringEnabled).clusteringThreshold(clusteringThreshold).includeNlpData(includeNlpData).hasNlp(hasNlp).theme(theme).notTheme(notTheme).orGEntityName(orGEntityName).peREntityName(peREntityName).loCEntityName(loCEntityName).miSCEntityName(miSCEntityName).titleSentimentMin(titleSentimentMin).titleSentimentMax(titleSentimentMax).contentSentimentMin(contentSentimentMin).contentSentimentMax(contentSentimentMax).iptcTags(iptcTags).notIptcTags(notIptcTags).sourceName(sourceName).iabTags(iabTags).notIabTags(notIabTags).excludeDuplicates(excludeDuplicates).additionalDomainInfo(additionalDomainInfo).isNewsDomain(isNewsDomain).newsDomainType(newsDomainType).newsType(newsType).execute();

[Get] Search For Articles Request

This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.

### Example
```java
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.ApiResponse;
import com.konfigthis.newscatcherapi.client.Newscatcher;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.*;
import com.konfigthis.newscatcherapi.client.model.*;
import com.konfigthis.newscatcherapi.client.api.SearchApi;
import java.util.List;
import java.util.Map;
import java.util.UUID;

public class Example {
  public static void main(String[] args) {
    Configuration configuration = new Configuration();
    configuration.host = "https://v3-api.newscatcherapi.com";
    
    configuration.apiKey  = "YOUR API KEY";
    Newscatcher client = new Newscatcher(configuration);
    String q = "q_example";
    String searchIn = "title_content";
    Object predefinedSources = null;
    Object sources = null;
    Object notSources = null;
    Object lang = null;
    Object notLang = null;
    Object countries = null;
    Object notCountries = null;
    Object notAuthorName = null;
    String from = "from_example";
    String to = "to_example";
    String publishedDatePrecision = "publishedDatePrecision_example";
    Object byParseDate = null;
    String sortBy = "relevancy";
    Object rankedOnly = null;
    Object fromRank = null;
    Object toRank = null;
    Object isHeadline = null;
    Object isOpinion = null;
    Object isPaidContent = null;
    Object parentUrl = null;
    Object allLinks = null;
    Object allDomainLinks = null;
    Object wordCountMin = null;
    Object wordCountMax = null;
    Object page = null;
    Object pageSize = null;
    String clusteringVariable = "clusteringVariable_example";
    Object clusteringEnabled = null;
    Object clusteringThreshold = null;
    Object includeNlpData = null;
    Boolean hasNlp = true;
    String theme = "theme_example";
    String notTheme = "notTheme_example";
    String orGEntityName = "orGEntityName_example";
    String peREntityName = "peREntityName_example";
    String loCEntityName = "loCEntityName_example";
    String miSCEntityName = "miSCEntityName_example";
    Double titleSentimentMin = 3.4D;
    Double titleSentimentMax = 3.4D;
    Double contentSentimentMin = 3.4D;
    Double contentSentimentMax = 3.4D;
    Object iptcTags = null;
    Object notIptcTags = null;
    Object sourceName = null;
    Object iabTags = null;
    Object notIabTags = null;
    Boolean excludeDuplicates = true;
    Boolean additionalDomainInfo = true;
    Boolean isNewsDomain = true;
    Object newsDomainType = null;
    Object newsType = null;
    try {
      CSearchResponse result = client
              .search
              .get(q)
              .searchIn(searchIn)
              .predefinedSources(predefinedSources)
              .sources(sources)
              .notSources(notSources)
              .lang(lang)
              .notLang(notLang)
              .countries(countries)
              .notCountries(notCountries)
              .notAuthorName(notAuthorName)
              .from(from)
              .to(to)
              .publishedDatePrecision(publishedDatePrecision)
              .byParseDate(byParseDate)
              .sortBy(sortBy)
              .rankedOnly(rankedOnly)
              .fromRank(fromRank)
              .toRank(toRank)
              .isHeadline(isHeadline)
              .isOpinion(isOpinion)
              .isPaidContent(isPaidContent)
              .parentUrl(parentUrl)
              .allLinks(allLinks)
              .allDomainLinks(allDomainLinks)
              .wordCountMin(wordCountMin)
              .wordCountMax(wordCountMax)
              .page(page)
              .pageSize(pageSize)
              .clusteringVariable(clusteringVariable)
              .clusteringEnabled(clusteringEnabled)
              .clusteringThreshold(clusteringThreshold)
              .includeNlpData(includeNlpData)
              .hasNlp(hasNlp)
              .theme(theme)
              .notTheme(notTheme)
              .orGEntityName(orGEntityName)
              .peREntityName(peREntityName)
              .loCEntityName(loCEntityName)
              .miSCEntityName(miSCEntityName)
              .titleSentimentMin(titleSentimentMin)
              .titleSentimentMax(titleSentimentMax)
              .contentSentimentMin(contentSentimentMin)
              .contentSentimentMax(contentSentimentMax)
              .iptcTags(iptcTags)
              .notIptcTags(notIptcTags)
              .sourceName(sourceName)
              .iabTags(iabTags)
              .notIabTags(notIabTags)
              .excludeDuplicates(excludeDuplicates)
              .additionalDomainInfo(additionalDomainInfo)
              .isNewsDomain(isNewsDomain)
              .newsDomainType(newsDomainType)
              .newsType(newsType)
              .execute();
      System.out.println(result);
      System.out.println(result.getStatus());
      System.out.println(result.getTotalHits());
      System.out.println(result.getPage());
      System.out.println(result.getTotalPages());
      System.out.println(result.getPageSize());
      System.out.println(result.getArticles());
      System.out.println(result.getUserInput());
      System.out.println(result.getClustersCount());
      System.out.println(result.getClusters());
    } catch (ApiException e) {
      System.err.println("Exception when calling SearchApi#get");
      System.err.println("Status code: " + e.getStatusCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }

    // Use .executeWithHttpInfo() to retrieve HTTP Status Code, Headers and Request
    try {
      ApiResponse<CSearchResponse> response = client
              .search
              .get(q)
              .searchIn(searchIn)
              .predefinedSources(predefinedSources)
              .sources(sources)
              .notSources(notSources)
              .lang(lang)
              .notLang(notLang)
              .countries(countries)
              .notCountries(notCountries)
              .notAuthorName(notAuthorName)
              .from(from)
              .to(to)
              .publishedDatePrecision(publishedDatePrecision)
              .byParseDate(byParseDate)
              .sortBy(sortBy)
              .rankedOnly(rankedOnly)
              .fromRank(fromRank)
              .toRank(toRank)
              .isHeadline(isHeadline)
              .isOpinion(isOpinion)
              .isPaidContent(isPaidContent)
              .parentUrl(parentUrl)
              .allLinks(allLinks)
              .allDomainLinks(allDomainLinks)
              .wordCountMin(wordCountMin)
              .wordCountMax(wordCountMax)
              .page(page)
              .pageSize(pageSize)
              .clusteringVariable(clusteringVariable)
              .clusteringEnabled(clusteringEnabled)
              .clusteringThreshold(clusteringThreshold)
              .includeNlpData(includeNlpData)
              .hasNlp(hasNlp)
              .theme(theme)
              .notTheme(notTheme)
              .orGEntityName(orGEntityName)
              .peREntityName(peREntityName)
              .loCEntityName(loCEntityName)
              .miSCEntityName(miSCEntityName)
              .titleSentimentMin(titleSentimentMin)
              .titleSentimentMax(titleSentimentMax)
              .contentSentimentMin(contentSentimentMin)
              .contentSentimentMax(contentSentimentMax)
              .iptcTags(iptcTags)
              .notIptcTags(notIptcTags)
              .sourceName(sourceName)
              .iabTags(iabTags)
              .notIabTags(notIabTags)
              .excludeDuplicates(excludeDuplicates)
              .additionalDomainInfo(additionalDomainInfo)
              .isNewsDomain(isNewsDomain)
              .newsDomainType(newsDomainType)
              .newsType(newsType)
              .executeWithHttpInfo();
      System.out.println(response.getResponseBody());
      System.out.println(response.getResponseHeaders());
      System.out.println(response.getStatusCode());
      System.out.println(response.getRoundTripTime());
      System.out.println(response.getRequest());
    } catch (ApiException e) {
      System.err.println("Exception when calling SearchApi#get");
      System.err.println("Status code: " + e.getStatusCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}

```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q** | **String**|  | |
| **searchIn** | **String**|  | [optional] [default to title_content] |
| **predefinedSources** | [**Object**](.md)|  | [optional] |
| **sources** | [**Object**](.md)|  | [optional] |
| **notSources** | [**Object**](.md)|  | [optional] |
| **lang** | [**Object**](.md)|  | [optional] |
| **notLang** | [**Object**](.md)|  | [optional] |
| **countries** | [**Object**](.md)|  | [optional] |
| **notCountries** | [**Object**](.md)|  | [optional] |
| **notAuthorName** | [**Object**](.md)|  | [optional] |
| **from** | **String**|  | [optional] |
| **to** | **String**|  | [optional] |
| **publishedDatePrecision** | **String**|  | [optional] |
| **byParseDate** | [**Object**](.md)|  | [optional] |
| **sortBy** | **String**|  | [optional] [default to relevancy] |
| **rankedOnly** | [**Object**](.md)|  | [optional] |
| **fromRank** | [**Object**](.md)|  | [optional] |
| **toRank** | [**Object**](.md)|  | [optional] |
| **isHeadline** | [**Object**](.md)|  | [optional] |
| **isOpinion** | [**Object**](.md)|  | [optional] |
| **isPaidContent** | [**Object**](.md)|  | [optional] |
| **parentUrl** | [**Object**](.md)|  | [optional] |
| **allLinks** | [**Object**](.md)|  | [optional] |
| **allDomainLinks** | [**Object**](.md)|  | [optional] |
| **wordCountMin** | [**Object**](.md)|  | [optional] |
| **wordCountMax** | [**Object**](.md)|  | [optional] |
| **page** | [**Object**](.md)|  | [optional] |
| **pageSize** | [**Object**](.md)|  | [optional] |
| **clusteringVariable** | **String**|  | [optional] |
| **clusteringEnabled** | [**Object**](.md)|  | [optional] |
| **clusteringThreshold** | [**Object**](.md)|  | [optional] |
| **includeNlpData** | [**Object**](.md)|  | [optional] |
| **hasNlp** | **Boolean**|  | [optional] |
| **theme** | **String**|  | [optional] |
| **notTheme** | **String**|  | [optional] |
| **orGEntityName** | **String**|  | [optional] |
| **peREntityName** | **String**|  | [optional] |
| **loCEntityName** | **String**|  | [optional] |
| **miSCEntityName** | **String**|  | [optional] |
| **titleSentimentMin** | **Double**|  | [optional] |
| **titleSentimentMax** | **Double**|  | [optional] |
| **contentSentimentMin** | **Double**|  | [optional] |
| **contentSentimentMax** | **Double**|  | [optional] |
| **iptcTags** | [**Object**](.md)|  | [optional] |
| **notIptcTags** | [**Object**](.md)|  | [optional] |
| **sourceName** | [**Object**](.md)|  | [optional] |
| **iabTags** | [**Object**](.md)|  | [optional] |
| **notIabTags** | [**Object**](.md)|  | [optional] |
| **excludeDuplicates** | **Boolean**|  | [optional] |
| **additionalDomainInfo** | **Boolean**|  | [optional] |
| **isNewsDomain** | **Boolean**|  | [optional] |
| **newsDomainType** | [**Object**](.md)|  | [optional] |
| **newsType** | [**Object**](.md)|  | [optional] |

### Return type

[**CSearchResponse**](CSearchResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

<a name="post"></a>
# **post**
> CSearchResponse1 post(searchRequest).execute();

[Post] Search For Articles Request

This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.

### Example
```java
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.ApiResponse;
import com.konfigthis.newscatcherapi.client.Newscatcher;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.*;
import com.konfigthis.newscatcherapi.client.model.*;
import com.konfigthis.newscatcherapi.client.api.SearchApi;
import java.util.List;
import java.util.Map;
import java.util.UUID;

public class Example {
  public static void main(String[] args) {
    Configuration configuration = new Configuration();
    configuration.host = "https://v3-api.newscatcherapi.com";
    
    configuration.apiKey  = "YOUR API KEY";
    Newscatcher client = new Newscatcher(configuration);
    String q = "q_example";
    String searchIn = "title_content";
    Object predefinedSources = null;
    Object sources = null;
    Object notSources = null;
    Object lang = null;
    Object notLang = null;
    Object countries = null;
    Object notCountries = null;
    Object notAuthorName = null;
    String from = "from_example";
    String to = "to_example";
    String publishedDatePrecision = "publishedDatePrecision_example";
    Object byParseDate = null;
    String sortBy = "relevancy";
    Object rankedOnly = null;
    Object fromRank = null;
    Object toRank = null;
    Object isHeadline = null;
    Object isOpinion = null;
    Object isPaidContent = null;
    Object parentUrl = null;
    Object allLinks = null;
    Object allDomainLinks = null;
    Object wordCountMin = null;
    Object wordCountMax = null;
    Object page = null;
    Object pageSize = null;
    String clusteringVariable = "clusteringVariable_example";
    Object clusteringEnabled = null;
    Object clusteringThreshold = null;
    Object includeNlpData = null;
    Boolean hasNlp = true;
    String theme = "theme_example";
    String notTheme = "notTheme_example";
    String orGEntityName = "orGEntityName_example";
    String peREntityName = "peREntityName_example";
    String loCEntityName = "loCEntityName_example";
    String miSCEntityName = "miSCEntityName_example";
    Double titleSentimentMin = 3.4D;
    Double titleSentimentMax = 3.4D;
    Double contentSentimentMin = 3.4D;
    Double contentSentimentMax = 3.4D;
    Object iptcTags = null;
    Object notIptcTags = null;
    Object sourceName = null;
    Object iabTags = null;
    Object notIabTags = null;
    Boolean excludeDuplicates = true;
    Boolean additionalDomainInfo = true;
    Boolean isNewsDomain = true;
    Object newsDomainType = null;
    Object newsType = null;
    try {
      CSearchResponse1 result = client
              .search
              .post(q)
              .searchIn(searchIn)
              .predefinedSources(predefinedSources)
              .sources(sources)
              .notSources(notSources)
              .lang(lang)
              .notLang(notLang)
              .countries(countries)
              .notCountries(notCountries)
              .notAuthorName(notAuthorName)
              .from(from)
              .to(to)
              .publishedDatePrecision(publishedDatePrecision)
              .byParseDate(byParseDate)
              .sortBy(sortBy)
              .rankedOnly(rankedOnly)
              .fromRank(fromRank)
              .toRank(toRank)
              .isHeadline(isHeadline)
              .isOpinion(isOpinion)
              .isPaidContent(isPaidContent)
              .parentUrl(parentUrl)
              .allLinks(allLinks)
              .allDomainLinks(allDomainLinks)
              .wordCountMin(wordCountMin)
              .wordCountMax(wordCountMax)
              .page(page)
              .pageSize(pageSize)
              .clusteringVariable(clusteringVariable)
              .clusteringEnabled(clusteringEnabled)
              .clusteringThreshold(clusteringThreshold)
              .includeNlpData(includeNlpData)
              .hasNlp(hasNlp)
              .theme(theme)
              .notTheme(notTheme)
              .orGEntityName(orGEntityName)
              .peREntityName(peREntityName)
              .loCEntityName(loCEntityName)
              .miSCEntityName(miSCEntityName)
              .titleSentimentMin(titleSentimentMin)
              .titleSentimentMax(titleSentimentMax)
              .contentSentimentMin(contentSentimentMin)
              .contentSentimentMax(contentSentimentMax)
              .iptcTags(iptcTags)
              .notIptcTags(notIptcTags)
              .sourceName(sourceName)
              .iabTags(iabTags)
              .notIabTags(notIabTags)
              .excludeDuplicates(excludeDuplicates)
              .additionalDomainInfo(additionalDomainInfo)
              .isNewsDomain(isNewsDomain)
              .newsDomainType(newsDomainType)
              .newsType(newsType)
              .execute();
      System.out.println(result);
      System.out.println(result.getStatus());
      System.out.println(result.getTotalHits());
      System.out.println(result.getPage());
      System.out.println(result.getTotalPages());
      System.out.println(result.getPageSize());
      System.out.println(result.getArticles());
      System.out.println(result.getUserInput());
      System.out.println(result.getClustersCount());
      System.out.println(result.getClusters());
    } catch (ApiException e) {
      System.err.println("Exception when calling SearchApi#post");
      System.err.println("Status code: " + e.getStatusCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }

    // Use .executeWithHttpInfo() to retrieve HTTP Status Code, Headers and Request
    try {
      ApiResponse<CSearchResponse1> response = client
              .search
              .post(q)
              .searchIn(searchIn)
              .predefinedSources(predefinedSources)
              .sources(sources)
              .notSources(notSources)
              .lang(lang)
              .notLang(notLang)
              .countries(countries)
              .notCountries(notCountries)
              .notAuthorName(notAuthorName)
              .from(from)
              .to(to)
              .publishedDatePrecision(publishedDatePrecision)
              .byParseDate(byParseDate)
              .sortBy(sortBy)
              .rankedOnly(rankedOnly)
              .fromRank(fromRank)
              .toRank(toRank)
              .isHeadline(isHeadline)
              .isOpinion(isOpinion)
              .isPaidContent(isPaidContent)
              .parentUrl(parentUrl)
              .allLinks(allLinks)
              .allDomainLinks(allDomainLinks)
              .wordCountMin(wordCountMin)
              .wordCountMax(wordCountMax)
              .page(page)
              .pageSize(pageSize)
              .clusteringVariable(clusteringVariable)
              .clusteringEnabled(clusteringEnabled)
              .clusteringThreshold(clusteringThreshold)
              .includeNlpData(includeNlpData)
              .hasNlp(hasNlp)
              .theme(theme)
              .notTheme(notTheme)
              .orGEntityName(orGEntityName)
              .peREntityName(peREntityName)
              .loCEntityName(loCEntityName)
              .miSCEntityName(miSCEntityName)
              .titleSentimentMin(titleSentimentMin)
              .titleSentimentMax(titleSentimentMax)
              .contentSentimentMin(contentSentimentMin)
              .contentSentimentMax(contentSentimentMax)
              .iptcTags(iptcTags)
              .notIptcTags(notIptcTags)
              .sourceName(sourceName)
              .iabTags(iabTags)
              .notIabTags(notIabTags)
              .excludeDuplicates(excludeDuplicates)
              .additionalDomainInfo(additionalDomainInfo)
              .isNewsDomain(isNewsDomain)
              .newsDomainType(newsDomainType)
              .newsType(newsType)
              .executeWithHttpInfo();
      System.out.println(response.getResponseBody());
      System.out.println(response.getResponseHeaders());
      System.out.println(response.getStatusCode());
      System.out.println(response.getRoundTripTime());
      System.out.println(response.getRequest());
    } catch (ApiException e) {
      System.err.println("Exception when calling SearchApi#post");
      System.err.println("Status code: " + e.getStatusCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}

```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **searchRequest** | [**SearchRequest**](SearchRequest.md)|  | |

### Return type

[**CSearchResponse1**](CSearchResponse1.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |


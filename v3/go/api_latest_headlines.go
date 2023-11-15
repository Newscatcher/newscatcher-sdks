/*
NewsCatcher-V3 Production API

<img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a> <br> <p style=\"color: red\"><b><em> This is a Testing Phase API. Please use it for testing purposes only. </em></b></p> <br>

API version: Beta-3.0.0
Contact: maksym@newscatcherapi.com
*/

// Code generated by Konfig (https://konfigthis.com); DO NOT EDIT.

package newscatcherapi

import (
	"bytes"
	"context"
	"io/ioutil"
	"net/http"
	"net/url"
)


// LatestHeadlinesApiService LatestHeadlinesApi service
type LatestHeadlinesApiService service

type LatestHeadlinesApiGetRequest struct {
	ctx context.Context
	ApiService *LatestHeadlinesApiService
	when *string
	byParseDate *bool
	lang *string
	notLang *string
	countries *string
	notCountries *string
	sources *string
	predefinedSources *string
	notSources *string
	rankedOnly *string
	isHeadline *bool
	isPaidContent *bool
	parentUrl *string
	theme *string
	allLinks *string
	allDomainLinks *string
	wordCountMin *int32
	wordCountMax *int32
	page *int32
	pageSize *int32
	clusteringEnabled *bool
	clusteringThreshold *float32
	clusteringVariable *string
	includeNlpData *bool
	hasNlp *bool
	oRGEntityName *string
	pEREntityName *string
	lOCEntityName *string
	mISCEntityName *string
	titleSentimentMin *float32
	titleSentimentMax *float32
	contentSentimentMin *float32
	contentSentimentMax *float32
}

func (r *LatestHeadlinesApiGetRequest) When(when string) *LatestHeadlinesApiGetRequest {
	r.when = &when
	return r
}

func (r *LatestHeadlinesApiGetRequest) ByParseDate(byParseDate bool) *LatestHeadlinesApiGetRequest {
	r.byParseDate = &byParseDate
	return r
}

func (r *LatestHeadlinesApiGetRequest) Lang(lang string) *LatestHeadlinesApiGetRequest {
	r.lang = &lang
	return r
}

func (r *LatestHeadlinesApiGetRequest) NotLang(notLang string) *LatestHeadlinesApiGetRequest {
	r.notLang = &notLang
	return r
}

func (r *LatestHeadlinesApiGetRequest) Countries(countries string) *LatestHeadlinesApiGetRequest {
	r.countries = &countries
	return r
}

func (r *LatestHeadlinesApiGetRequest) NotCountries(notCountries string) *LatestHeadlinesApiGetRequest {
	r.notCountries = &notCountries
	return r
}

func (r *LatestHeadlinesApiGetRequest) Sources(sources string) *LatestHeadlinesApiGetRequest {
	r.sources = &sources
	return r
}

func (r *LatestHeadlinesApiGetRequest) PredefinedSources(predefinedSources string) *LatestHeadlinesApiGetRequest {
	r.predefinedSources = &predefinedSources
	return r
}

func (r *LatestHeadlinesApiGetRequest) NotSources(notSources string) *LatestHeadlinesApiGetRequest {
	r.notSources = &notSources
	return r
}

func (r *LatestHeadlinesApiGetRequest) RankedOnly(rankedOnly string) *LatestHeadlinesApiGetRequest {
	r.rankedOnly = &rankedOnly
	return r
}

func (r *LatestHeadlinesApiGetRequest) IsHeadline(isHeadline bool) *LatestHeadlinesApiGetRequest {
	r.isHeadline = &isHeadline
	return r
}

func (r *LatestHeadlinesApiGetRequest) IsPaidContent(isPaidContent bool) *LatestHeadlinesApiGetRequest {
	r.isPaidContent = &isPaidContent
	return r
}

func (r *LatestHeadlinesApiGetRequest) ParentUrl(parentUrl string) *LatestHeadlinesApiGetRequest {
	r.parentUrl = &parentUrl
	return r
}

func (r *LatestHeadlinesApiGetRequest) Theme(theme string) *LatestHeadlinesApiGetRequest {
	r.theme = &theme
	return r
}

func (r *LatestHeadlinesApiGetRequest) AllLinks(allLinks string) *LatestHeadlinesApiGetRequest {
	r.allLinks = &allLinks
	return r
}

func (r *LatestHeadlinesApiGetRequest) AllDomainLinks(allDomainLinks string) *LatestHeadlinesApiGetRequest {
	r.allDomainLinks = &allDomainLinks
	return r
}

func (r *LatestHeadlinesApiGetRequest) WordCountMin(wordCountMin int32) *LatestHeadlinesApiGetRequest {
	r.wordCountMin = &wordCountMin
	return r
}

func (r *LatestHeadlinesApiGetRequest) WordCountMax(wordCountMax int32) *LatestHeadlinesApiGetRequest {
	r.wordCountMax = &wordCountMax
	return r
}

func (r *LatestHeadlinesApiGetRequest) Page(page int32) *LatestHeadlinesApiGetRequest {
	r.page = &page
	return r
}

func (r *LatestHeadlinesApiGetRequest) PageSize(pageSize int32) *LatestHeadlinesApiGetRequest {
	r.pageSize = &pageSize
	return r
}

func (r *LatestHeadlinesApiGetRequest) ClusteringEnabled(clusteringEnabled bool) *LatestHeadlinesApiGetRequest {
	r.clusteringEnabled = &clusteringEnabled
	return r
}

func (r *LatestHeadlinesApiGetRequest) ClusteringThreshold(clusteringThreshold float32) *LatestHeadlinesApiGetRequest {
	r.clusteringThreshold = &clusteringThreshold
	return r
}

func (r *LatestHeadlinesApiGetRequest) ClusteringVariable(clusteringVariable string) *LatestHeadlinesApiGetRequest {
	r.clusteringVariable = &clusteringVariable
	return r
}

func (r *LatestHeadlinesApiGetRequest) IncludeNlpData(includeNlpData bool) *LatestHeadlinesApiGetRequest {
	r.includeNlpData = &includeNlpData
	return r
}

func (r *LatestHeadlinesApiGetRequest) HasNlp(hasNlp bool) *LatestHeadlinesApiGetRequest {
	r.hasNlp = &hasNlp
	return r
}

func (r *LatestHeadlinesApiGetRequest) ORGEntityName(oRGEntityName string) *LatestHeadlinesApiGetRequest {
	r.oRGEntityName = &oRGEntityName
	return r
}

func (r *LatestHeadlinesApiGetRequest) PEREntityName(pEREntityName string) *LatestHeadlinesApiGetRequest {
	r.pEREntityName = &pEREntityName
	return r
}

func (r *LatestHeadlinesApiGetRequest) LOCEntityName(lOCEntityName string) *LatestHeadlinesApiGetRequest {
	r.lOCEntityName = &lOCEntityName
	return r
}

func (r *LatestHeadlinesApiGetRequest) MISCEntityName(mISCEntityName string) *LatestHeadlinesApiGetRequest {
	r.mISCEntityName = &mISCEntityName
	return r
}

func (r *LatestHeadlinesApiGetRequest) TitleSentimentMin(titleSentimentMin float32) *LatestHeadlinesApiGetRequest {
	r.titleSentimentMin = &titleSentimentMin
	return r
}

func (r *LatestHeadlinesApiGetRequest) TitleSentimentMax(titleSentimentMax float32) *LatestHeadlinesApiGetRequest {
	r.titleSentimentMax = &titleSentimentMax
	return r
}

func (r *LatestHeadlinesApiGetRequest) ContentSentimentMin(contentSentimentMin float32) *LatestHeadlinesApiGetRequest {
	r.contentSentimentMin = &contentSentimentMin
	return r
}

func (r *LatestHeadlinesApiGetRequest) ContentSentimentMax(contentSentimentMax float32) *LatestHeadlinesApiGetRequest {
	r.contentSentimentMax = &contentSentimentMax
	return r
}

func (r LatestHeadlinesApiGetRequest) Execute() (*LatestHeadlinesGetResponse, *http.Response, error) {
	return r.ApiService.GetExecute(r)
}

/*
Get [Get] Search For Latest Headlines Request

This endpoint allows you to get latest headlines. You need to specify since when you want to get the latest headlines. You can also filter by language, country, source, and more.

 @param ctx context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 @return LatestHeadlinesApiGetRequest
*/
func (a *LatestHeadlinesApiService) Get() LatestHeadlinesApiGetRequest {
	return LatestHeadlinesApiGetRequest{
		ApiService: a,
		ctx: a.client.cfg.Context,
	}
}

// Execute executes the request
//  @return LatestHeadlinesGetResponse
func (a *LatestHeadlinesApiService) GetExecute(r LatestHeadlinesApiGetRequest) (*LatestHeadlinesGetResponse, *http.Response, error) {
	var (
		localVarHTTPMethod   = http.MethodGet
		localVarPostBody     interface{}
		formFiles            []formFile
		localVarReturnValue  *LatestHeadlinesGetResponse
	)

	localBasePath, err := a.client.cfg.ServerURLWithContext(r.ctx, "LatestHeadlinesApiService.Get")
	if err != nil {
		return localVarReturnValue, nil, &GenericOpenAPIError{error: err.Error()}
	}

	localVarPath := localBasePath + "/api/latest_headlines"

	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := url.Values{}
	localVarFormParams := url.Values{}
	if *r.wordCountMin < 0 {
		return localVarReturnValue, nil, reportError("wordCountMin must be greater than 0")
	}
	if *r.wordCountMax < 0 {
		return localVarReturnValue, nil, reportError("wordCountMax must be greater than 0")
	}
	if *r.page < 0 {
		return localVarReturnValue, nil, reportError("page must be greater than 0")
	}
	if *r.pageSize < 0 {
		return localVarReturnValue, nil, reportError("pageSize must be greater than 0")
	}

	if r.when != nil {
		localVarQueryParams.Add("when", parameterToString(*r.when, ""))
	}
	if r.byParseDate != nil {
		localVarQueryParams.Add("by_parse_date", parameterToString(*r.byParseDate, ""))
	}
	if r.lang != nil {
		localVarQueryParams.Add("lang", parameterToString(*r.lang, ""))
	}
	if r.notLang != nil {
		localVarQueryParams.Add("not_lang", parameterToString(*r.notLang, ""))
	}
	if r.countries != nil {
		localVarQueryParams.Add("countries", parameterToString(*r.countries, ""))
	}
	if r.notCountries != nil {
		localVarQueryParams.Add("not_countries", parameterToString(*r.notCountries, ""))
	}
	if r.sources != nil {
		localVarQueryParams.Add("sources", parameterToString(*r.sources, ""))
	}
	if r.predefinedSources != nil {
		localVarQueryParams.Add("predefined_sources", parameterToString(*r.predefinedSources, ""))
	}
	if r.notSources != nil {
		localVarQueryParams.Add("not_sources", parameterToString(*r.notSources, ""))
	}
	if r.rankedOnly != nil {
		localVarQueryParams.Add("ranked_only", parameterToString(*r.rankedOnly, ""))
	}
	if r.isHeadline != nil {
		localVarQueryParams.Add("is_headline", parameterToString(*r.isHeadline, ""))
	}
	if r.isPaidContent != nil {
		localVarQueryParams.Add("is_paid_content", parameterToString(*r.isPaidContent, ""))
	}
	if r.parentUrl != nil {
		localVarQueryParams.Add("parent_url", parameterToString(*r.parentUrl, ""))
	}
	if r.theme != nil {
		localVarQueryParams.Add("theme", parameterToString(*r.theme, ""))
	}
	if r.allLinks != nil {
		localVarQueryParams.Add("all_links", parameterToString(*r.allLinks, ""))
	}
	if r.allDomainLinks != nil {
		localVarQueryParams.Add("all_domain_links", parameterToString(*r.allDomainLinks, ""))
	}
	if r.wordCountMin != nil {
		localVarQueryParams.Add("word_count_min", parameterToString(*r.wordCountMin, ""))
	}
	if r.wordCountMax != nil {
		localVarQueryParams.Add("word_count_max", parameterToString(*r.wordCountMax, ""))
	}
	if r.page != nil {
		localVarQueryParams.Add("page", parameterToString(*r.page, ""))
	}
	if r.pageSize != nil {
		localVarQueryParams.Add("page_size", parameterToString(*r.pageSize, ""))
	}
	if r.clusteringEnabled != nil {
		localVarQueryParams.Add("clustering_enabled", parameterToString(*r.clusteringEnabled, ""))
	}
	if r.clusteringThreshold != nil {
		localVarQueryParams.Add("clustering_threshold", parameterToString(*r.clusteringThreshold, ""))
	}
	if r.clusteringVariable != nil {
		localVarQueryParams.Add("clustering_variable", parameterToString(*r.clusteringVariable, ""))
	}
	if r.includeNlpData != nil {
		localVarQueryParams.Add("include_nlp_data", parameterToString(*r.includeNlpData, ""))
	}
	if r.hasNlp != nil {
		localVarQueryParams.Add("has_nlp", parameterToString(*r.hasNlp, ""))
	}
	if r.oRGEntityName != nil {
		localVarQueryParams.Add("ORG_entity_name", parameterToString(*r.oRGEntityName, ""))
	}
	if r.pEREntityName != nil {
		localVarQueryParams.Add("PER_entity_name", parameterToString(*r.pEREntityName, ""))
	}
	if r.lOCEntityName != nil {
		localVarQueryParams.Add("LOC_entity_name", parameterToString(*r.lOCEntityName, ""))
	}
	if r.mISCEntityName != nil {
		localVarQueryParams.Add("MISC_entity_name", parameterToString(*r.mISCEntityName, ""))
	}
	if r.titleSentimentMin != nil {
		localVarQueryParams.Add("title_sentiment_min", parameterToString(*r.titleSentimentMin, ""))
	}
	if r.titleSentimentMax != nil {
		localVarQueryParams.Add("title_sentiment_max", parameterToString(*r.titleSentimentMax, ""))
	}
	if r.contentSentimentMin != nil {
		localVarQueryParams.Add("content_sentiment_min", parameterToString(*r.contentSentimentMin, ""))
	}
	if r.contentSentimentMax != nil {
		localVarQueryParams.Add("content_sentiment_max", parameterToString(*r.contentSentimentMax, ""))
	}
	// to determine the Content-Type header
	localVarHTTPContentTypes := []string{}

	// set Content-Type header
	localVarHTTPContentType := selectHeaderContentType(localVarHTTPContentTypes)
	if localVarHTTPContentType != "" {
		localVarHeaderParams["Content-Type"] = localVarHTTPContentType
	}

	// to determine the Accept header
	localVarHTTPHeaderAccepts := []string{"application/json"}

	// set Accept header
	localVarHTTPHeaderAccept := selectHeaderAccept(localVarHTTPHeaderAccepts)
	if localVarHTTPHeaderAccept != "" {
		localVarHeaderParams["Accept"] = localVarHTTPHeaderAccept
	}
	if r.ctx != nil {
		// API Key Authentication
		if auth, ok := r.ctx.Value(ContextAPIKeys).(map[string]APIKey); ok {
			if apiKey, ok := auth["apiKey"]; ok {
				var key string
				if apiKey.Prefix != "" {
					key = apiKey.Prefix + " " + apiKey.Key
				} else {
					key = apiKey.Key
				}
				localVarHeaderParams["x-api-token"] = key
			}
		}
	}
	req, err := a.client.prepareRequest(r.ctx, localVarPath, localVarHTTPMethod, localVarPostBody, localVarHeaderParams, localVarQueryParams, localVarFormParams, formFiles)
	if err != nil {
		return localVarReturnValue, nil, err
	}

	localVarHTTPResponse, err := a.client.callAPI(req)
	if err != nil || localVarHTTPResponse == nil {
		return localVarReturnValue, localVarHTTPResponse, err
	}

	localVarBody, err := ioutil.ReadAll(localVarHTTPResponse.Body)
	localVarHTTPResponse.Body.Close()
	localVarHTTPResponse.Body = ioutil.NopCloser(bytes.NewBuffer(localVarBody))
	if err != nil {
		return localVarReturnValue, localVarHTTPResponse, err
	}

	if localVarHTTPResponse.StatusCode >= 300 {
		newErr := &GenericOpenAPIError{
			body:  localVarBody,
			error: localVarHTTPResponse.Status,
		}
		if localVarHTTPResponse.StatusCode == 422 {
			var v HTTPValidationError
			err = a.client.decode(&v, localVarBody, localVarHTTPResponse.Header.Get("Content-Type"))
			if err != nil {
				newErr.error = err.Error()
				return localVarReturnValue, localVarHTTPResponse, newErr
			}
            		newErr.error = formatErrorMessage(localVarHTTPResponse.Status, &v)
            		newErr.model = v
		}
		return localVarReturnValue, localVarHTTPResponse, newErr
	}

	err = a.client.decode(&localVarReturnValue, localVarBody, localVarHTTPResponse.Header.Get("Content-Type"))
	if err != nil {
		newErr := &GenericOpenAPIError{
			body:  localVarBody,
			error: err.Error(),
		}
		return localVarReturnValue, localVarHTTPResponse, newErr
	}

	return localVarReturnValue, localVarHTTPResponse, nil
}

type LatestHeadlinesApiPostRequest struct {
	ctx context.Context
	ApiService *LatestHeadlinesApiService
	latestHeadlinesRequest LatestHeadlinesRequest
}

func (r LatestHeadlinesApiPostRequest) Execute() (*LatestHeadlinesPostResponse, *http.Response, error) {
	return r.ApiService.PostExecute(r)
}

/*
Post [Post] Search For Latest Headlines Request

This endpoint allows you to get latest headlines. You need to specify since when you want to get the latest headlines. You can also filter by language, country, source, and more.

 @param ctx context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 @param latestHeadlinesRequest
 @return LatestHeadlinesApiPostRequest
*/
func (a *LatestHeadlinesApiService) Post(latestHeadlinesRequest LatestHeadlinesRequest) LatestHeadlinesApiPostRequest {
	return LatestHeadlinesApiPostRequest{
		ApiService: a,
		ctx: a.client.cfg.Context,
		latestHeadlinesRequest: latestHeadlinesRequest,
	}
}

// Execute executes the request
//  @return LatestHeadlinesPostResponse
func (a *LatestHeadlinesApiService) PostExecute(r LatestHeadlinesApiPostRequest) (*LatestHeadlinesPostResponse, *http.Response, error) {
	var (
		localVarHTTPMethod   = http.MethodPost
		localVarPostBody     interface{}
		formFiles            []formFile
		localVarReturnValue  *LatestHeadlinesPostResponse
	)

	localBasePath, err := a.client.cfg.ServerURLWithContext(r.ctx, "LatestHeadlinesApiService.Post")
	if err != nil {
		return localVarReturnValue, nil, &GenericOpenAPIError{error: err.Error()}
	}

	localVarPath := localBasePath + "/api/latest_headlines"

	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := url.Values{}
	localVarFormParams := url.Values{}

	// to determine the Content-Type header
	localVarHTTPContentTypes := []string{"application/json"}

	// set Content-Type header
	localVarHTTPContentType := selectHeaderContentType(localVarHTTPContentTypes)
	if localVarHTTPContentType != "" {
		localVarHeaderParams["Content-Type"] = localVarHTTPContentType
	}

	// to determine the Accept header
	localVarHTTPHeaderAccepts := []string{"application/json"}

	// set Accept header
	localVarHTTPHeaderAccept := selectHeaderAccept(localVarHTTPHeaderAccepts)
	if localVarHTTPHeaderAccept != "" {
		localVarHeaderParams["Accept"] = localVarHTTPHeaderAccept
	}
	// body params
	localVarPostBody = r.latestHeadlinesRequest
	if r.ctx != nil {
		// API Key Authentication
		if auth, ok := r.ctx.Value(ContextAPIKeys).(map[string]APIKey); ok {
			if apiKey, ok := auth["apiKey"]; ok {
				var key string
				if apiKey.Prefix != "" {
					key = apiKey.Prefix + " " + apiKey.Key
				} else {
					key = apiKey.Key
				}
				localVarHeaderParams["x-api-token"] = key
			}
		}
	}
	req, err := a.client.prepareRequest(r.ctx, localVarPath, localVarHTTPMethod, localVarPostBody, localVarHeaderParams, localVarQueryParams, localVarFormParams, formFiles)
	if err != nil {
		return localVarReturnValue, nil, err
	}

	localVarHTTPResponse, err := a.client.callAPI(req)
	if err != nil || localVarHTTPResponse == nil {
		return localVarReturnValue, localVarHTTPResponse, err
	}

	localVarBody, err := ioutil.ReadAll(localVarHTTPResponse.Body)
	localVarHTTPResponse.Body.Close()
	localVarHTTPResponse.Body = ioutil.NopCloser(bytes.NewBuffer(localVarBody))
	if err != nil {
		return localVarReturnValue, localVarHTTPResponse, err
	}

	if localVarHTTPResponse.StatusCode >= 300 {
		newErr := &GenericOpenAPIError{
			body:  localVarBody,
			error: localVarHTTPResponse.Status,
		}
		if localVarHTTPResponse.StatusCode == 422 {
			var v HTTPValidationError
			err = a.client.decode(&v, localVarBody, localVarHTTPResponse.Header.Get("Content-Type"))
			if err != nil {
				newErr.error = err.Error()
				return localVarReturnValue, localVarHTTPResponse, newErr
			}
            		newErr.error = formatErrorMessage(localVarHTTPResponse.Status, &v)
            		newErr.model = v
		}
		return localVarReturnValue, localVarHTTPResponse, newErr
	}

	err = a.client.decode(&localVarReturnValue, localVarBody, localVarHTTPResponse.Header.Get("Content-Type"))
	if err != nil {
		newErr := &GenericOpenAPIError{
			body:  localVarBody,
			error: err.Error(),
		}
		return localVarReturnValue, localVarHTTPResponse, newErr
	}

	return localVarReturnValue, localVarHTTPResponse, nil
}

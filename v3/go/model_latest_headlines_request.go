/*
NewsCatcher-V3 Production API

<img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a> <br> <p style=\"color: red\"><b><em> This is a Testing Phase API. Please use it for testing purposes only. </em></b></p> <br>

API version: Beta-3.0.0
Contact: maksym@newscatcherapi.com
*/

// Code generated by Konfig (https://konfigthis.com); DO NOT EDIT.

package newscatcherapi

import (
	"encoding/json"
)

// LatestHeadlinesRequest struct for LatestHeadlinesRequest
type LatestHeadlinesRequest struct {
	When *string `json:"when,omitempty"`
	ByParseDate *bool `json:"by_parse_date,omitempty"`
	Lang *string `json:"lang,omitempty"`
	NotLang *string `json:"not_lang,omitempty"`
	Countries *string `json:"countries,omitempty"`
	NotCountries *string `json:"not_countries,omitempty"`
	Sources *string `json:"sources,omitempty"`
	PredefinedSources *string `json:"predefined_sources,omitempty"`
	NotSources *string `json:"not_sources,omitempty"`
	RankedOnly *string `json:"ranked_only,omitempty"`
	IsHeadline *bool `json:"is_headline,omitempty"`
	IsPaidContent *bool `json:"is_paid_content,omitempty"`
	ParentUrl *string `json:"parent_url,omitempty"`
	Theme *string `json:"theme,omitempty"`
	AllLinks *string `json:"all_links,omitempty"`
	AllDomainLinks *string `json:"all_domain_links,omitempty"`
	WordCountMin *int32 `json:"word_count_min,omitempty"`
	WordCountMax *int32 `json:"word_count_max,omitempty"`
	Page *int32 `json:"page,omitempty"`
	PageSize *int32 `json:"page_size,omitempty"`
	ClusteringEnabled *bool `json:"clustering_enabled,omitempty"`
	ClusteringThreshold *float32 `json:"clustering_threshold,omitempty"`
	ClusteringVariable *string `json:"clustering_variable,omitempty"`
	IncludeNlpData *bool `json:"include_nlp_data,omitempty"`
	HasNlp *bool `json:"has_nlp,omitempty"`
	ORGEntityName *string `json:"ORG_entity_name,omitempty"`
	PEREntityName *string `json:"PER_entity_name,omitempty"`
	LOCEntityName *string `json:"LOC_entity_name,omitempty"`
	MISCEntityName *string `json:"MISC_entity_name,omitempty"`
	TitleSentimentMin *float32 `json:"title_sentiment_min,omitempty"`
	TitleSentimentMax *float32 `json:"title_sentiment_max,omitempty"`
	ContentSentimentMin *float32 `json:"content_sentiment_min,omitempty"`
	ContentSentimentMax *float32 `json:"content_sentiment_max,omitempty"`
}

// NewLatestHeadlinesRequest instantiates a new LatestHeadlinesRequest object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewLatestHeadlinesRequest() *LatestHeadlinesRequest {
	this := LatestHeadlinesRequest{}
	var when string = "7d"
	this.When = &when
	var byParseDate bool = false
	this.ByParseDate = &byParseDate
	var page int32 = 1
	this.Page = &page
	var pageSize int32 = 100
	this.PageSize = &pageSize
	return &this
}

// NewLatestHeadlinesRequestWithDefaults instantiates a new LatestHeadlinesRequest object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewLatestHeadlinesRequestWithDefaults() *LatestHeadlinesRequest {
	this := LatestHeadlinesRequest{}
	var when string = "7d"
	this.When = &when
	var byParseDate bool = false
	this.ByParseDate = &byParseDate
	var page int32 = 1
	this.Page = &page
	var pageSize int32 = 100
	this.PageSize = &pageSize
	return &this
}

// GetWhen returns the When field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetWhen() string {
	if o == nil || isNil(o.When) {
		var ret string
		return ret
	}
	return *o.When
}

// GetWhenOk returns a tuple with the When field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetWhenOk() (*string, bool) {
	if o == nil || isNil(o.When) {
    return nil, false
	}
	return o.When, true
}

// HasWhen returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasWhen() bool {
	if o != nil && !isNil(o.When) {
		return true
	}

	return false
}

// SetWhen gets a reference to the given string and assigns it to the When field.
func (o *LatestHeadlinesRequest) SetWhen(v string) {
	o.When = &v
}

// GetByParseDate returns the ByParseDate field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetByParseDate() bool {
	if o == nil || isNil(o.ByParseDate) {
		var ret bool
		return ret
	}
	return *o.ByParseDate
}

// GetByParseDateOk returns a tuple with the ByParseDate field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetByParseDateOk() (*bool, bool) {
	if o == nil || isNil(o.ByParseDate) {
    return nil, false
	}
	return o.ByParseDate, true
}

// HasByParseDate returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasByParseDate() bool {
	if o != nil && !isNil(o.ByParseDate) {
		return true
	}

	return false
}

// SetByParseDate gets a reference to the given bool and assigns it to the ByParseDate field.
func (o *LatestHeadlinesRequest) SetByParseDate(v bool) {
	o.ByParseDate = &v
}

// GetLang returns the Lang field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetLang() string {
	if o == nil || isNil(o.Lang) {
		var ret string
		return ret
	}
	return *o.Lang
}

// GetLangOk returns a tuple with the Lang field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetLangOk() (*string, bool) {
	if o == nil || isNil(o.Lang) {
    return nil, false
	}
	return o.Lang, true
}

// HasLang returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasLang() bool {
	if o != nil && !isNil(o.Lang) {
		return true
	}

	return false
}

// SetLang gets a reference to the given string and assigns it to the Lang field.
func (o *LatestHeadlinesRequest) SetLang(v string) {
	o.Lang = &v
}

// GetNotLang returns the NotLang field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetNotLang() string {
	if o == nil || isNil(o.NotLang) {
		var ret string
		return ret
	}
	return *o.NotLang
}

// GetNotLangOk returns a tuple with the NotLang field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetNotLangOk() (*string, bool) {
	if o == nil || isNil(o.NotLang) {
    return nil, false
	}
	return o.NotLang, true
}

// HasNotLang returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasNotLang() bool {
	if o != nil && !isNil(o.NotLang) {
		return true
	}

	return false
}

// SetNotLang gets a reference to the given string and assigns it to the NotLang field.
func (o *LatestHeadlinesRequest) SetNotLang(v string) {
	o.NotLang = &v
}

// GetCountries returns the Countries field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetCountries() string {
	if o == nil || isNil(o.Countries) {
		var ret string
		return ret
	}
	return *o.Countries
}

// GetCountriesOk returns a tuple with the Countries field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetCountriesOk() (*string, bool) {
	if o == nil || isNil(o.Countries) {
    return nil, false
	}
	return o.Countries, true
}

// HasCountries returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasCountries() bool {
	if o != nil && !isNil(o.Countries) {
		return true
	}

	return false
}

// SetCountries gets a reference to the given string and assigns it to the Countries field.
func (o *LatestHeadlinesRequest) SetCountries(v string) {
	o.Countries = &v
}

// GetNotCountries returns the NotCountries field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetNotCountries() string {
	if o == nil || isNil(o.NotCountries) {
		var ret string
		return ret
	}
	return *o.NotCountries
}

// GetNotCountriesOk returns a tuple with the NotCountries field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetNotCountriesOk() (*string, bool) {
	if o == nil || isNil(o.NotCountries) {
    return nil, false
	}
	return o.NotCountries, true
}

// HasNotCountries returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasNotCountries() bool {
	if o != nil && !isNil(o.NotCountries) {
		return true
	}

	return false
}

// SetNotCountries gets a reference to the given string and assigns it to the NotCountries field.
func (o *LatestHeadlinesRequest) SetNotCountries(v string) {
	o.NotCountries = &v
}

// GetSources returns the Sources field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetSources() string {
	if o == nil || isNil(o.Sources) {
		var ret string
		return ret
	}
	return *o.Sources
}

// GetSourcesOk returns a tuple with the Sources field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetSourcesOk() (*string, bool) {
	if o == nil || isNil(o.Sources) {
    return nil, false
	}
	return o.Sources, true
}

// HasSources returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasSources() bool {
	if o != nil && !isNil(o.Sources) {
		return true
	}

	return false
}

// SetSources gets a reference to the given string and assigns it to the Sources field.
func (o *LatestHeadlinesRequest) SetSources(v string) {
	o.Sources = &v
}

// GetPredefinedSources returns the PredefinedSources field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetPredefinedSources() string {
	if o == nil || isNil(o.PredefinedSources) {
		var ret string
		return ret
	}
	return *o.PredefinedSources
}

// GetPredefinedSourcesOk returns a tuple with the PredefinedSources field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetPredefinedSourcesOk() (*string, bool) {
	if o == nil || isNil(o.PredefinedSources) {
    return nil, false
	}
	return o.PredefinedSources, true
}

// HasPredefinedSources returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasPredefinedSources() bool {
	if o != nil && !isNil(o.PredefinedSources) {
		return true
	}

	return false
}

// SetPredefinedSources gets a reference to the given string and assigns it to the PredefinedSources field.
func (o *LatestHeadlinesRequest) SetPredefinedSources(v string) {
	o.PredefinedSources = &v
}

// GetNotSources returns the NotSources field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetNotSources() string {
	if o == nil || isNil(o.NotSources) {
		var ret string
		return ret
	}
	return *o.NotSources
}

// GetNotSourcesOk returns a tuple with the NotSources field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetNotSourcesOk() (*string, bool) {
	if o == nil || isNil(o.NotSources) {
    return nil, false
	}
	return o.NotSources, true
}

// HasNotSources returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasNotSources() bool {
	if o != nil && !isNil(o.NotSources) {
		return true
	}

	return false
}

// SetNotSources gets a reference to the given string and assigns it to the NotSources field.
func (o *LatestHeadlinesRequest) SetNotSources(v string) {
	o.NotSources = &v
}

// GetRankedOnly returns the RankedOnly field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetRankedOnly() string {
	if o == nil || isNil(o.RankedOnly) {
		var ret string
		return ret
	}
	return *o.RankedOnly
}

// GetRankedOnlyOk returns a tuple with the RankedOnly field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetRankedOnlyOk() (*string, bool) {
	if o == nil || isNil(o.RankedOnly) {
    return nil, false
	}
	return o.RankedOnly, true
}

// HasRankedOnly returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasRankedOnly() bool {
	if o != nil && !isNil(o.RankedOnly) {
		return true
	}

	return false
}

// SetRankedOnly gets a reference to the given string and assigns it to the RankedOnly field.
func (o *LatestHeadlinesRequest) SetRankedOnly(v string) {
	o.RankedOnly = &v
}

// GetIsHeadline returns the IsHeadline field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetIsHeadline() bool {
	if o == nil || isNil(o.IsHeadline) {
		var ret bool
		return ret
	}
	return *o.IsHeadline
}

// GetIsHeadlineOk returns a tuple with the IsHeadline field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetIsHeadlineOk() (*bool, bool) {
	if o == nil || isNil(o.IsHeadline) {
    return nil, false
	}
	return o.IsHeadline, true
}

// HasIsHeadline returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasIsHeadline() bool {
	if o != nil && !isNil(o.IsHeadline) {
		return true
	}

	return false
}

// SetIsHeadline gets a reference to the given bool and assigns it to the IsHeadline field.
func (o *LatestHeadlinesRequest) SetIsHeadline(v bool) {
	o.IsHeadline = &v
}

// GetIsPaidContent returns the IsPaidContent field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetIsPaidContent() bool {
	if o == nil || isNil(o.IsPaidContent) {
		var ret bool
		return ret
	}
	return *o.IsPaidContent
}

// GetIsPaidContentOk returns a tuple with the IsPaidContent field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetIsPaidContentOk() (*bool, bool) {
	if o == nil || isNil(o.IsPaidContent) {
    return nil, false
	}
	return o.IsPaidContent, true
}

// HasIsPaidContent returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasIsPaidContent() bool {
	if o != nil && !isNil(o.IsPaidContent) {
		return true
	}

	return false
}

// SetIsPaidContent gets a reference to the given bool and assigns it to the IsPaidContent field.
func (o *LatestHeadlinesRequest) SetIsPaidContent(v bool) {
	o.IsPaidContent = &v
}

// GetParentUrl returns the ParentUrl field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetParentUrl() string {
	if o == nil || isNil(o.ParentUrl) {
		var ret string
		return ret
	}
	return *o.ParentUrl
}

// GetParentUrlOk returns a tuple with the ParentUrl field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetParentUrlOk() (*string, bool) {
	if o == nil || isNil(o.ParentUrl) {
    return nil, false
	}
	return o.ParentUrl, true
}

// HasParentUrl returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasParentUrl() bool {
	if o != nil && !isNil(o.ParentUrl) {
		return true
	}

	return false
}

// SetParentUrl gets a reference to the given string and assigns it to the ParentUrl field.
func (o *LatestHeadlinesRequest) SetParentUrl(v string) {
	o.ParentUrl = &v
}

// GetTheme returns the Theme field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetTheme() string {
	if o == nil || isNil(o.Theme) {
		var ret string
		return ret
	}
	return *o.Theme
}

// GetThemeOk returns a tuple with the Theme field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetThemeOk() (*string, bool) {
	if o == nil || isNil(o.Theme) {
    return nil, false
	}
	return o.Theme, true
}

// HasTheme returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasTheme() bool {
	if o != nil && !isNil(o.Theme) {
		return true
	}

	return false
}

// SetTheme gets a reference to the given string and assigns it to the Theme field.
func (o *LatestHeadlinesRequest) SetTheme(v string) {
	o.Theme = &v
}

// GetAllLinks returns the AllLinks field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetAllLinks() string {
	if o == nil || isNil(o.AllLinks) {
		var ret string
		return ret
	}
	return *o.AllLinks
}

// GetAllLinksOk returns a tuple with the AllLinks field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetAllLinksOk() (*string, bool) {
	if o == nil || isNil(o.AllLinks) {
    return nil, false
	}
	return o.AllLinks, true
}

// HasAllLinks returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasAllLinks() bool {
	if o != nil && !isNil(o.AllLinks) {
		return true
	}

	return false
}

// SetAllLinks gets a reference to the given string and assigns it to the AllLinks field.
func (o *LatestHeadlinesRequest) SetAllLinks(v string) {
	o.AllLinks = &v
}

// GetAllDomainLinks returns the AllDomainLinks field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetAllDomainLinks() string {
	if o == nil || isNil(o.AllDomainLinks) {
		var ret string
		return ret
	}
	return *o.AllDomainLinks
}

// GetAllDomainLinksOk returns a tuple with the AllDomainLinks field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetAllDomainLinksOk() (*string, bool) {
	if o == nil || isNil(o.AllDomainLinks) {
    return nil, false
	}
	return o.AllDomainLinks, true
}

// HasAllDomainLinks returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasAllDomainLinks() bool {
	if o != nil && !isNil(o.AllDomainLinks) {
		return true
	}

	return false
}

// SetAllDomainLinks gets a reference to the given string and assigns it to the AllDomainLinks field.
func (o *LatestHeadlinesRequest) SetAllDomainLinks(v string) {
	o.AllDomainLinks = &v
}

// GetWordCountMin returns the WordCountMin field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetWordCountMin() int32 {
	if o == nil || isNil(o.WordCountMin) {
		var ret int32
		return ret
	}
	return *o.WordCountMin
}

// GetWordCountMinOk returns a tuple with the WordCountMin field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetWordCountMinOk() (*int32, bool) {
	if o == nil || isNil(o.WordCountMin) {
    return nil, false
	}
	return o.WordCountMin, true
}

// HasWordCountMin returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasWordCountMin() bool {
	if o != nil && !isNil(o.WordCountMin) {
		return true
	}

	return false
}

// SetWordCountMin gets a reference to the given int32 and assigns it to the WordCountMin field.
func (o *LatestHeadlinesRequest) SetWordCountMin(v int32) {
	o.WordCountMin = &v
}

// GetWordCountMax returns the WordCountMax field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetWordCountMax() int32 {
	if o == nil || isNil(o.WordCountMax) {
		var ret int32
		return ret
	}
	return *o.WordCountMax
}

// GetWordCountMaxOk returns a tuple with the WordCountMax field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetWordCountMaxOk() (*int32, bool) {
	if o == nil || isNil(o.WordCountMax) {
    return nil, false
	}
	return o.WordCountMax, true
}

// HasWordCountMax returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasWordCountMax() bool {
	if o != nil && !isNil(o.WordCountMax) {
		return true
	}

	return false
}

// SetWordCountMax gets a reference to the given int32 and assigns it to the WordCountMax field.
func (o *LatestHeadlinesRequest) SetWordCountMax(v int32) {
	o.WordCountMax = &v
}

// GetPage returns the Page field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetPage() int32 {
	if o == nil || isNil(o.Page) {
		var ret int32
		return ret
	}
	return *o.Page
}

// GetPageOk returns a tuple with the Page field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetPageOk() (*int32, bool) {
	if o == nil || isNil(o.Page) {
    return nil, false
	}
	return o.Page, true
}

// HasPage returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasPage() bool {
	if o != nil && !isNil(o.Page) {
		return true
	}

	return false
}

// SetPage gets a reference to the given int32 and assigns it to the Page field.
func (o *LatestHeadlinesRequest) SetPage(v int32) {
	o.Page = &v
}

// GetPageSize returns the PageSize field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetPageSize() int32 {
	if o == nil || isNil(o.PageSize) {
		var ret int32
		return ret
	}
	return *o.PageSize
}

// GetPageSizeOk returns a tuple with the PageSize field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetPageSizeOk() (*int32, bool) {
	if o == nil || isNil(o.PageSize) {
    return nil, false
	}
	return o.PageSize, true
}

// HasPageSize returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasPageSize() bool {
	if o != nil && !isNil(o.PageSize) {
		return true
	}

	return false
}

// SetPageSize gets a reference to the given int32 and assigns it to the PageSize field.
func (o *LatestHeadlinesRequest) SetPageSize(v int32) {
	o.PageSize = &v
}

// GetClusteringEnabled returns the ClusteringEnabled field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetClusteringEnabled() bool {
	if o == nil || isNil(o.ClusteringEnabled) {
		var ret bool
		return ret
	}
	return *o.ClusteringEnabled
}

// GetClusteringEnabledOk returns a tuple with the ClusteringEnabled field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetClusteringEnabledOk() (*bool, bool) {
	if o == nil || isNil(o.ClusteringEnabled) {
    return nil, false
	}
	return o.ClusteringEnabled, true
}

// HasClusteringEnabled returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasClusteringEnabled() bool {
	if o != nil && !isNil(o.ClusteringEnabled) {
		return true
	}

	return false
}

// SetClusteringEnabled gets a reference to the given bool and assigns it to the ClusteringEnabled field.
func (o *LatestHeadlinesRequest) SetClusteringEnabled(v bool) {
	o.ClusteringEnabled = &v
}

// GetClusteringThreshold returns the ClusteringThreshold field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetClusteringThreshold() float32 {
	if o == nil || isNil(o.ClusteringThreshold) {
		var ret float32
		return ret
	}
	return *o.ClusteringThreshold
}

// GetClusteringThresholdOk returns a tuple with the ClusteringThreshold field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetClusteringThresholdOk() (*float32, bool) {
	if o == nil || isNil(o.ClusteringThreshold) {
    return nil, false
	}
	return o.ClusteringThreshold, true
}

// HasClusteringThreshold returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasClusteringThreshold() bool {
	if o != nil && !isNil(o.ClusteringThreshold) {
		return true
	}

	return false
}

// SetClusteringThreshold gets a reference to the given float32 and assigns it to the ClusteringThreshold field.
func (o *LatestHeadlinesRequest) SetClusteringThreshold(v float32) {
	o.ClusteringThreshold = &v
}

// GetClusteringVariable returns the ClusteringVariable field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetClusteringVariable() string {
	if o == nil || isNil(o.ClusteringVariable) {
		var ret string
		return ret
	}
	return *o.ClusteringVariable
}

// GetClusteringVariableOk returns a tuple with the ClusteringVariable field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetClusteringVariableOk() (*string, bool) {
	if o == nil || isNil(o.ClusteringVariable) {
    return nil, false
	}
	return o.ClusteringVariable, true
}

// HasClusteringVariable returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasClusteringVariable() bool {
	if o != nil && !isNil(o.ClusteringVariable) {
		return true
	}

	return false
}

// SetClusteringVariable gets a reference to the given string and assigns it to the ClusteringVariable field.
func (o *LatestHeadlinesRequest) SetClusteringVariable(v string) {
	o.ClusteringVariable = &v
}

// GetIncludeNlpData returns the IncludeNlpData field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetIncludeNlpData() bool {
	if o == nil || isNil(o.IncludeNlpData) {
		var ret bool
		return ret
	}
	return *o.IncludeNlpData
}

// GetIncludeNlpDataOk returns a tuple with the IncludeNlpData field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetIncludeNlpDataOk() (*bool, bool) {
	if o == nil || isNil(o.IncludeNlpData) {
    return nil, false
	}
	return o.IncludeNlpData, true
}

// HasIncludeNlpData returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasIncludeNlpData() bool {
	if o != nil && !isNil(o.IncludeNlpData) {
		return true
	}

	return false
}

// SetIncludeNlpData gets a reference to the given bool and assigns it to the IncludeNlpData field.
func (o *LatestHeadlinesRequest) SetIncludeNlpData(v bool) {
	o.IncludeNlpData = &v
}

// GetHasNlp returns the HasNlp field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetHasNlp() bool {
	if o == nil || isNil(o.HasNlp) {
		var ret bool
		return ret
	}
	return *o.HasNlp
}

// GetHasNlpOk returns a tuple with the HasNlp field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetHasNlpOk() (*bool, bool) {
	if o == nil || isNil(o.HasNlp) {
    return nil, false
	}
	return o.HasNlp, true
}

// HasHasNlp returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasHasNlp() bool {
	if o != nil && !isNil(o.HasNlp) {
		return true
	}

	return false
}

// SetHasNlp gets a reference to the given bool and assigns it to the HasNlp field.
func (o *LatestHeadlinesRequest) SetHasNlp(v bool) {
	o.HasNlp = &v
}

// GetORGEntityName returns the ORGEntityName field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetORGEntityName() string {
	if o == nil || isNil(o.ORGEntityName) {
		var ret string
		return ret
	}
	return *o.ORGEntityName
}

// GetORGEntityNameOk returns a tuple with the ORGEntityName field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetORGEntityNameOk() (*string, bool) {
	if o == nil || isNil(o.ORGEntityName) {
    return nil, false
	}
	return o.ORGEntityName, true
}

// HasORGEntityName returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasORGEntityName() bool {
	if o != nil && !isNil(o.ORGEntityName) {
		return true
	}

	return false
}

// SetORGEntityName gets a reference to the given string and assigns it to the ORGEntityName field.
func (o *LatestHeadlinesRequest) SetORGEntityName(v string) {
	o.ORGEntityName = &v
}

// GetPEREntityName returns the PEREntityName field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetPEREntityName() string {
	if o == nil || isNil(o.PEREntityName) {
		var ret string
		return ret
	}
	return *o.PEREntityName
}

// GetPEREntityNameOk returns a tuple with the PEREntityName field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetPEREntityNameOk() (*string, bool) {
	if o == nil || isNil(o.PEREntityName) {
    return nil, false
	}
	return o.PEREntityName, true
}

// HasPEREntityName returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasPEREntityName() bool {
	if o != nil && !isNil(o.PEREntityName) {
		return true
	}

	return false
}

// SetPEREntityName gets a reference to the given string and assigns it to the PEREntityName field.
func (o *LatestHeadlinesRequest) SetPEREntityName(v string) {
	o.PEREntityName = &v
}

// GetLOCEntityName returns the LOCEntityName field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetLOCEntityName() string {
	if o == nil || isNil(o.LOCEntityName) {
		var ret string
		return ret
	}
	return *o.LOCEntityName
}

// GetLOCEntityNameOk returns a tuple with the LOCEntityName field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetLOCEntityNameOk() (*string, bool) {
	if o == nil || isNil(o.LOCEntityName) {
    return nil, false
	}
	return o.LOCEntityName, true
}

// HasLOCEntityName returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasLOCEntityName() bool {
	if o != nil && !isNil(o.LOCEntityName) {
		return true
	}

	return false
}

// SetLOCEntityName gets a reference to the given string and assigns it to the LOCEntityName field.
func (o *LatestHeadlinesRequest) SetLOCEntityName(v string) {
	o.LOCEntityName = &v
}

// GetMISCEntityName returns the MISCEntityName field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetMISCEntityName() string {
	if o == nil || isNil(o.MISCEntityName) {
		var ret string
		return ret
	}
	return *o.MISCEntityName
}

// GetMISCEntityNameOk returns a tuple with the MISCEntityName field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetMISCEntityNameOk() (*string, bool) {
	if o == nil || isNil(o.MISCEntityName) {
    return nil, false
	}
	return o.MISCEntityName, true
}

// HasMISCEntityName returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasMISCEntityName() bool {
	if o != nil && !isNil(o.MISCEntityName) {
		return true
	}

	return false
}

// SetMISCEntityName gets a reference to the given string and assigns it to the MISCEntityName field.
func (o *LatestHeadlinesRequest) SetMISCEntityName(v string) {
	o.MISCEntityName = &v
}

// GetTitleSentimentMin returns the TitleSentimentMin field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetTitleSentimentMin() float32 {
	if o == nil || isNil(o.TitleSentimentMin) {
		var ret float32
		return ret
	}
	return *o.TitleSentimentMin
}

// GetTitleSentimentMinOk returns a tuple with the TitleSentimentMin field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetTitleSentimentMinOk() (*float32, bool) {
	if o == nil || isNil(o.TitleSentimentMin) {
    return nil, false
	}
	return o.TitleSentimentMin, true
}

// HasTitleSentimentMin returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasTitleSentimentMin() bool {
	if o != nil && !isNil(o.TitleSentimentMin) {
		return true
	}

	return false
}

// SetTitleSentimentMin gets a reference to the given float32 and assigns it to the TitleSentimentMin field.
func (o *LatestHeadlinesRequest) SetTitleSentimentMin(v float32) {
	o.TitleSentimentMin = &v
}

// GetTitleSentimentMax returns the TitleSentimentMax field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetTitleSentimentMax() float32 {
	if o == nil || isNil(o.TitleSentimentMax) {
		var ret float32
		return ret
	}
	return *o.TitleSentimentMax
}

// GetTitleSentimentMaxOk returns a tuple with the TitleSentimentMax field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetTitleSentimentMaxOk() (*float32, bool) {
	if o == nil || isNil(o.TitleSentimentMax) {
    return nil, false
	}
	return o.TitleSentimentMax, true
}

// HasTitleSentimentMax returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasTitleSentimentMax() bool {
	if o != nil && !isNil(o.TitleSentimentMax) {
		return true
	}

	return false
}

// SetTitleSentimentMax gets a reference to the given float32 and assigns it to the TitleSentimentMax field.
func (o *LatestHeadlinesRequest) SetTitleSentimentMax(v float32) {
	o.TitleSentimentMax = &v
}

// GetContentSentimentMin returns the ContentSentimentMin field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetContentSentimentMin() float32 {
	if o == nil || isNil(o.ContentSentimentMin) {
		var ret float32
		return ret
	}
	return *o.ContentSentimentMin
}

// GetContentSentimentMinOk returns a tuple with the ContentSentimentMin field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetContentSentimentMinOk() (*float32, bool) {
	if o == nil || isNil(o.ContentSentimentMin) {
    return nil, false
	}
	return o.ContentSentimentMin, true
}

// HasContentSentimentMin returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasContentSentimentMin() bool {
	if o != nil && !isNil(o.ContentSentimentMin) {
		return true
	}

	return false
}

// SetContentSentimentMin gets a reference to the given float32 and assigns it to the ContentSentimentMin field.
func (o *LatestHeadlinesRequest) SetContentSentimentMin(v float32) {
	o.ContentSentimentMin = &v
}

// GetContentSentimentMax returns the ContentSentimentMax field value if set, zero value otherwise.
func (o *LatestHeadlinesRequest) GetContentSentimentMax() float32 {
	if o == nil || isNil(o.ContentSentimentMax) {
		var ret float32
		return ret
	}
	return *o.ContentSentimentMax
}

// GetContentSentimentMaxOk returns a tuple with the ContentSentimentMax field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *LatestHeadlinesRequest) GetContentSentimentMaxOk() (*float32, bool) {
	if o == nil || isNil(o.ContentSentimentMax) {
    return nil, false
	}
	return o.ContentSentimentMax, true
}

// HasContentSentimentMax returns a boolean if a field has been set.
func (o *LatestHeadlinesRequest) HasContentSentimentMax() bool {
	if o != nil && !isNil(o.ContentSentimentMax) {
		return true
	}

	return false
}

// SetContentSentimentMax gets a reference to the given float32 and assigns it to the ContentSentimentMax field.
func (o *LatestHeadlinesRequest) SetContentSentimentMax(v float32) {
	o.ContentSentimentMax = &v
}

func (o LatestHeadlinesRequest) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.When) {
		toSerialize["when"] = o.When
	}
	if !isNil(o.ByParseDate) {
		toSerialize["by_parse_date"] = o.ByParseDate
	}
	if !isNil(o.Lang) {
		toSerialize["lang"] = o.Lang
	}
	if !isNil(o.NotLang) {
		toSerialize["not_lang"] = o.NotLang
	}
	if !isNil(o.Countries) {
		toSerialize["countries"] = o.Countries
	}
	if !isNil(o.NotCountries) {
		toSerialize["not_countries"] = o.NotCountries
	}
	if !isNil(o.Sources) {
		toSerialize["sources"] = o.Sources
	}
	if !isNil(o.PredefinedSources) {
		toSerialize["predefined_sources"] = o.PredefinedSources
	}
	if !isNil(o.NotSources) {
		toSerialize["not_sources"] = o.NotSources
	}
	if !isNil(o.RankedOnly) {
		toSerialize["ranked_only"] = o.RankedOnly
	}
	if !isNil(o.IsHeadline) {
		toSerialize["is_headline"] = o.IsHeadline
	}
	if !isNil(o.IsPaidContent) {
		toSerialize["is_paid_content"] = o.IsPaidContent
	}
	if !isNil(o.ParentUrl) {
		toSerialize["parent_url"] = o.ParentUrl
	}
	if !isNil(o.Theme) {
		toSerialize["theme"] = o.Theme
	}
	if !isNil(o.AllLinks) {
		toSerialize["all_links"] = o.AllLinks
	}
	if !isNil(o.AllDomainLinks) {
		toSerialize["all_domain_links"] = o.AllDomainLinks
	}
	if !isNil(o.WordCountMin) {
		toSerialize["word_count_min"] = o.WordCountMin
	}
	if !isNil(o.WordCountMax) {
		toSerialize["word_count_max"] = o.WordCountMax
	}
	if !isNil(o.Page) {
		toSerialize["page"] = o.Page
	}
	if !isNil(o.PageSize) {
		toSerialize["page_size"] = o.PageSize
	}
	if !isNil(o.ClusteringEnabled) {
		toSerialize["clustering_enabled"] = o.ClusteringEnabled
	}
	if !isNil(o.ClusteringThreshold) {
		toSerialize["clustering_threshold"] = o.ClusteringThreshold
	}
	if !isNil(o.ClusteringVariable) {
		toSerialize["clustering_variable"] = o.ClusteringVariable
	}
	if !isNil(o.IncludeNlpData) {
		toSerialize["include_nlp_data"] = o.IncludeNlpData
	}
	if !isNil(o.HasNlp) {
		toSerialize["has_nlp"] = o.HasNlp
	}
	if !isNil(o.ORGEntityName) {
		toSerialize["ORG_entity_name"] = o.ORGEntityName
	}
	if !isNil(o.PEREntityName) {
		toSerialize["PER_entity_name"] = o.PEREntityName
	}
	if !isNil(o.LOCEntityName) {
		toSerialize["LOC_entity_name"] = o.LOCEntityName
	}
	if !isNil(o.MISCEntityName) {
		toSerialize["MISC_entity_name"] = o.MISCEntityName
	}
	if !isNil(o.TitleSentimentMin) {
		toSerialize["title_sentiment_min"] = o.TitleSentimentMin
	}
	if !isNil(o.TitleSentimentMax) {
		toSerialize["title_sentiment_max"] = o.TitleSentimentMax
	}
	if !isNil(o.ContentSentimentMin) {
		toSerialize["content_sentiment_min"] = o.ContentSentimentMin
	}
	if !isNil(o.ContentSentimentMax) {
		toSerialize["content_sentiment_max"] = o.ContentSentimentMax
	}
	return json.Marshal(toSerialize)
}

type NullableLatestHeadlinesRequest struct {
	value *LatestHeadlinesRequest
	isSet bool
}

func (v NullableLatestHeadlinesRequest) Get() *LatestHeadlinesRequest {
	return v.value
}

func (v *NullableLatestHeadlinesRequest) Set(val *LatestHeadlinesRequest) {
	v.value = val
	v.isSet = true
}

func (v NullableLatestHeadlinesRequest) IsSet() bool {
	return v.isSet
}

func (v *NullableLatestHeadlinesRequest) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableLatestHeadlinesRequest(val *LatestHeadlinesRequest) *NullableLatestHeadlinesRequest {
	return &NullableLatestHeadlinesRequest{value: val, isSet: true}
}

func (v NullableLatestHeadlinesRequest) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableLatestHeadlinesRequest) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


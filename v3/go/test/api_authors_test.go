/*
NewsCatcher-V3 Production API

Testing AuthorsApiService

*/

// Code generated by Konfig (https://konfigthis.com);

package newscatcherapi

import (
    "testing"
    // "github.com/stretchr/testify/assert"
    // "github.com/stretchr/testify/require"
    // newscatcherapi "github.com/konfig-dev/newscatcher-sdks/v3/go"
)

func Test_newscatcherapi_AuthorsApiService(t *testing.T) {

    // configuration := newscatcherapi.NewConfiguration()
    // configuration.SetHost("http://127.0.0.1:4010")
    // configuration.SetApiKey("X_API_TOKEN")
       client := newscatcherapi.NewAPIClient(configuration)

    t.Run("Test AuthorsApiService Get", func(t *testing.T) {
        /* TODO: ENG-1367 Fix parameter values for Go SDK generated tests
        request := client.AuthorsApi.Get(
            "authorName_example",
        )
        request.Sources("sources_example")
        request.PredefinedSources("predefinedSources_example")
        request.NotSources("notSources_example")
        request.Lang("lang_example")
        request.NotLang("notLang_example")
        request.Countries("countries_example")
        request.NotCountries("notCountries_example")
        request.From(from)
        request.To(to)
        request.PublishedDatePrecision("publishedDatePrecision_example")
        request.ByParseDate(false)
        request.SortBy(""relevancy"")
        request.RankedOnly("rankedOnly_example")
        request.FromRank(56)
        request.ToRank(56)
        request.IsHeadline(true)
        request.IsPaidContent(true)
        request.ParentUrl("parentUrl_example")
        request.AllLinks("allLinks_example")
        request.AllDomainLinks("allDomainLinks_example")
        request.WordCountMin(56)
        request.WordCountMax(56)
        request.Page(1)
        request.PageSize(100)
        request.IncludeNlpData(true)
        request.HasNlp(true)
        request.Theme("theme_example")
        request.NerName("nerName_example")
        request.TitleSentimentMin(8.14)
        request.TitleSentimentMax(8.14)
        request.ContentSentimentMin(8.14)
        request.ContentSentimentMax(8.14)
        
        resp, httpRes, err := request.Execute()

        require.Nil(t, err)
        require.NotNil(t, resp)
        assert.Equal(t, 200, httpRes.StatusCode)
        */
    })

    t.Run("Test AuthorsApiService Post", func(t *testing.T) {
        /* TODO: ENG-1367 Fix parameter values for Go SDK generated tests
        from := *newscatcherapi.NewFrom()
        to := *newscatcherapi.NewTo()
        
        authorSearchRequest := *newscatcherapi.NewAuthorSearchRequest(
            "null",
        )
        authorSearchRequest.SetSources("null")
        authorSearchRequest.SetPredefinedSources("null")
        authorSearchRequest.SetNotSources("null")
        authorSearchRequest.SetLang("null")
        authorSearchRequest.SetNotLang("null")
        authorSearchRequest.SetCountries("null")
        authorSearchRequest.SetNotCountries("null")
        authorSearchRequest.SetFrom(from)
        authorSearchRequest.SetTo(to)
        authorSearchRequest.SetPublishedDatePrecision("null")
        authorSearchRequest.SetByParseDate(false)
        authorSearchRequest.SetSortBy("relevancy")
        authorSearchRequest.SetRankedOnly("null")
        authorSearchRequest.SetFromRank(null)
        authorSearchRequest.SetToRank(null)
        authorSearchRequest.SetIsHeadline(null)
        authorSearchRequest.SetIsPaidContent(null)
        authorSearchRequest.SetParentUrl("null")
        authorSearchRequest.SetAllLinks("null")
        authorSearchRequest.SetAllDomainLinks("null")
        authorSearchRequest.SetWordCountMin(null)
        authorSearchRequest.SetWordCountMax(null)
        authorSearchRequest.SetPage(1)
        authorSearchRequest.SetPageSize(100)
        authorSearchRequest.SetIncludeNlpData(null)
        authorSearchRequest.SetHasNlp(null)
        authorSearchRequest.SetTheme("null")
        authorSearchRequest.SetNerName("null")
        authorSearchRequest.SetTitleSentimentMin(null)
        authorSearchRequest.SetTitleSentimentMax(null)
        authorSearchRequest.SetContentSentimentMin(null)
        authorSearchRequest.SetContentSentimentMax(null)
        
        request := client.AuthorsApi.Post(
            authorSearchRequest,
        )
        
        resp, httpRes, err := request.Execute()

        require.Nil(t, err)
        require.NotNil(t, resp)
        assert.Equal(t, 200, httpRes.StatusCode)
        */
    })

}
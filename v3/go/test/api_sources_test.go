/*
NewsCatcher-V3 Production API

Testing SourcesApiService

*/

// Code generated by Konfig (https://konfigthis.com);

package newscatcherapi

import (
    "testing"
    // "github.com/stretchr/testify/assert"
    // "github.com/stretchr/testify/require"
    // newscatcherapi "github.com/konfig-dev/newscatcher-sdks/v3/go"
)

func Test_newscatcherapi_SourcesApiService(t *testing.T) {

    // configuration := newscatcherapi.NewConfiguration()
    // configuration.SetHost("http://127.0.0.1:4010")
    // configuration.SetApiKey("X_API_TOKEN")
       client := newscatcherapi.NewAPIClient(configuration)

    t.Run("Test SourcesApiService Get", func(t *testing.T) {
        /* TODO: ENG-1367 Fix parameter values for Go SDK generated tests
        request := client.SourcesApi.Get(
        )
        request.Lang("lang_example")
        request.Countries("countries_example")
        
        resp, httpRes, err := request.Execute()

        require.Nil(t, err)
        require.NotNil(t, resp)
        assert.Equal(t, 200, httpRes.StatusCode)
        */
    })

    t.Run("Test SourcesApiService Post", func(t *testing.T) {
        /* TODO: ENG-1367 Fix parameter values for Go SDK generated tests
        
        sourcesRequest := *newscatcherapi.NewSourcesRequest()
        sourcesRequest.SetLang("null")
        sourcesRequest.SetCountries("null")
        
        request := client.SourcesApi.Post(
            sourcesRequest,
        )
        
        resp, httpRes, err := request.Execute()

        require.Nil(t, err)
        require.NotNil(t, resp)
        assert.Equal(t, 200, httpRes.StatusCode)
        */
    })

}
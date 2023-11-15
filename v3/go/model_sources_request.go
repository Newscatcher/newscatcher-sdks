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

// SourcesRequest struct for SourcesRequest
type SourcesRequest struct {
	Lang *string `json:"lang,omitempty"`
	Countries *string `json:"countries,omitempty"`
}

// NewSourcesRequest instantiates a new SourcesRequest object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewSourcesRequest() *SourcesRequest {
	this := SourcesRequest{}
	return &this
}

// NewSourcesRequestWithDefaults instantiates a new SourcesRequest object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewSourcesRequestWithDefaults() *SourcesRequest {
	this := SourcesRequest{}
	return &this
}

// GetLang returns the Lang field value if set, zero value otherwise.
func (o *SourcesRequest) GetLang() string {
	if o == nil || isNil(o.Lang) {
		var ret string
		return ret
	}
	return *o.Lang
}

// GetLangOk returns a tuple with the Lang field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SourcesRequest) GetLangOk() (*string, bool) {
	if o == nil || isNil(o.Lang) {
    return nil, false
	}
	return o.Lang, true
}

// HasLang returns a boolean if a field has been set.
func (o *SourcesRequest) HasLang() bool {
	if o != nil && !isNil(o.Lang) {
		return true
	}

	return false
}

// SetLang gets a reference to the given string and assigns it to the Lang field.
func (o *SourcesRequest) SetLang(v string) {
	o.Lang = &v
}

// GetCountries returns the Countries field value if set, zero value otherwise.
func (o *SourcesRequest) GetCountries() string {
	if o == nil || isNil(o.Countries) {
		var ret string
		return ret
	}
	return *o.Countries
}

// GetCountriesOk returns a tuple with the Countries field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SourcesRequest) GetCountriesOk() (*string, bool) {
	if o == nil || isNil(o.Countries) {
    return nil, false
	}
	return o.Countries, true
}

// HasCountries returns a boolean if a field has been set.
func (o *SourcesRequest) HasCountries() bool {
	if o != nil && !isNil(o.Countries) {
		return true
	}

	return false
}

// SetCountries gets a reference to the given string and assigns it to the Countries field.
func (o *SourcesRequest) SetCountries(v string) {
	o.Countries = &v
}

func (o SourcesRequest) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Lang) {
		toSerialize["lang"] = o.Lang
	}
	if !isNil(o.Countries) {
		toSerialize["countries"] = o.Countries
	}
	return json.Marshal(toSerialize)
}

type NullableSourcesRequest struct {
	value *SourcesRequest
	isSet bool
}

func (v NullableSourcesRequest) Get() *SourcesRequest {
	return v.value
}

func (v *NullableSourcesRequest) Set(val *SourcesRequest) {
	v.value = val
	v.isSet = true
}

func (v NullableSourcesRequest) IsSet() bool {
	return v.isSet
}

func (v *NullableSourcesRequest) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSourcesRequest(val *SourcesRequest) *NullableSourcesRequest {
	return &NullableSourcesRequest{value: val, isSet: true}
}

func (v NullableSourcesRequest) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSourcesRequest) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}



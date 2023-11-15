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

// ValidationError struct for ValidationError
type ValidationError struct {
	Loc []LocationPropertyInner `json:"loc"`
	Msg string `json:"msg"`
	Type string `json:"type"`
}

// NewValidationError instantiates a new ValidationError object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewValidationError(loc []LocationPropertyInner, msg string, type_ string) *ValidationError {
	this := ValidationError{}
	this.Loc = loc
	this.Msg = msg
	this.Type = type_
	return &this
}

// NewValidationErrorWithDefaults instantiates a new ValidationError object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewValidationErrorWithDefaults() *ValidationError {
	this := ValidationError{}
	return &this
}

// GetLoc returns the Loc field value
func (o *ValidationError) GetLoc() []LocationPropertyInner {
	if o == nil {
		var ret []LocationPropertyInner
		return ret
	}

	return o.Loc
}

// GetLocOk returns a tuple with the Loc field value
// and a boolean to check if the value has been set.
func (o *ValidationError) GetLocOk() ([]LocationPropertyInner, bool) {
	if o == nil {
    return nil, false
	}
	return o.Loc, true
}

// SetLoc sets field value
func (o *ValidationError) SetLoc(v []LocationPropertyInner) {
	o.Loc = v
}

// GetMsg returns the Msg field value
func (o *ValidationError) GetMsg() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Msg
}

// GetMsgOk returns a tuple with the Msg field value
// and a boolean to check if the value has been set.
func (o *ValidationError) GetMsgOk() (*string, bool) {
	if o == nil {
    return nil, false
	}
	return &o.Msg, true
}

// SetMsg sets field value
func (o *ValidationError) SetMsg(v string) {
	o.Msg = v
}

// GetType returns the Type field value
func (o *ValidationError) GetType() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Type
}

// GetTypeOk returns a tuple with the Type field value
// and a boolean to check if the value has been set.
func (o *ValidationError) GetTypeOk() (*string, bool) {
	if o == nil {
    return nil, false
	}
	return &o.Type, true
}

// SetType sets field value
func (o *ValidationError) SetType(v string) {
	o.Type = v
}

func (o ValidationError) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if true {
		toSerialize["loc"] = o.Loc
	}
	if true {
		toSerialize["msg"] = o.Msg
	}
	if true {
		toSerialize["type"] = o.Type
	}
	return json.Marshal(toSerialize)
}

type NullableValidationError struct {
	value *ValidationError
	isSet bool
}

func (v NullableValidationError) Get() *ValidationError {
	return v.value
}

func (v *NullableValidationError) Set(val *ValidationError) {
	v.value = val
	v.isSet = true
}

func (v NullableValidationError) IsSet() bool {
	return v.isSet
}

func (v *NullableValidationError) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableValidationError(val *ValidationError) *NullableValidationError {
	return &NullableValidationError{value: val, isSet: true}
}

func (v NullableValidationError) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableValidationError) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}



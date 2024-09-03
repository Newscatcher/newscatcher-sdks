/*
 * NewsCatcher-V3 Production API
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>
 *
 * The version of the OpenAPI document: 3.2.16
 * Contact: maksym@newscatcherapi.com
 *
 * NOTE: This class is auto generated by Konfig (https://konfigthis.com).
 * Do not edit the class manually.
 */


package com.konfigthis.newscatcherapi.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;
import org.apache.commons.lang3.StringUtils;

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Set;

import com.konfigthis.newscatcherapi.client.JSON;

/**
 * SubscriptionResponse DTO class.
 */
@ApiModel(description = "SubscriptionResponse DTO class.")@javax.annotation.Generated(value = "Generated by https://konfigthis.com")
public class SubscriptionResponse {
  public static final String SERIALIZED_NAME_ACTIVE = "active";
  @SerializedName(SERIALIZED_NAME_ACTIVE)
  private Boolean active;

  public static final String SERIALIZED_NAME_CALLS_PER_SECONDS = "calls_per_seconds";
  @SerializedName(SERIALIZED_NAME_CALLS_PER_SECONDS)
  private Integer callsPerSeconds;

  public static final String SERIALIZED_NAME_PLAN_NAME = "plan_name";
  @SerializedName(SERIALIZED_NAME_PLAN_NAME)
  private String planName;

  public static final String SERIALIZED_NAME_USAGE_ASSIGNED_CALLS = "usage_assigned_calls";
  @SerializedName(SERIALIZED_NAME_USAGE_ASSIGNED_CALLS)
  private Integer usageAssignedCalls;

  public static final String SERIALIZED_NAME_USAGE_REMAINING_CALLS = "usage_remaining_calls";
  @SerializedName(SERIALIZED_NAME_USAGE_REMAINING_CALLS)
  private Integer usageRemainingCalls;

  public static final String SERIALIZED_NAME_HISTORICAL_DAYS = "historical_days";
  @SerializedName(SERIALIZED_NAME_HISTORICAL_DAYS)
  private Integer historicalDays;

  public SubscriptionResponse() {
  }

  public SubscriptionResponse active(Boolean active) {
    
    
    
    
    this.active = active;
    return this;
  }

   /**
   * Get active
   * @return active
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public Boolean getActive() {
    return active;
  }


  public void setActive(Boolean active) {
    
    
    
    this.active = active;
  }


  public SubscriptionResponse callsPerSeconds(Integer callsPerSeconds) {
    
    
    
    
    this.callsPerSeconds = callsPerSeconds;
    return this;
  }

   /**
   * Get callsPerSeconds
   * @return callsPerSeconds
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getCallsPerSeconds() {
    return callsPerSeconds;
  }


  public void setCallsPerSeconds(Integer callsPerSeconds) {
    
    
    
    this.callsPerSeconds = callsPerSeconds;
  }


  public SubscriptionResponse planName(String planName) {
    
    
    
    
    this.planName = planName;
    return this;
  }

   /**
   * Get planName
   * @return planName
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public String getPlanName() {
    return planName;
  }


  public void setPlanName(String planName) {
    
    
    
    this.planName = planName;
  }


  public SubscriptionResponse usageAssignedCalls(Integer usageAssignedCalls) {
    
    
    
    
    this.usageAssignedCalls = usageAssignedCalls;
    return this;
  }

   /**
   * Get usageAssignedCalls
   * @return usageAssignedCalls
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getUsageAssignedCalls() {
    return usageAssignedCalls;
  }


  public void setUsageAssignedCalls(Integer usageAssignedCalls) {
    
    
    
    this.usageAssignedCalls = usageAssignedCalls;
  }


  public SubscriptionResponse usageRemainingCalls(Integer usageRemainingCalls) {
    
    
    
    
    this.usageRemainingCalls = usageRemainingCalls;
    return this;
  }

   /**
   * Get usageRemainingCalls
   * @return usageRemainingCalls
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getUsageRemainingCalls() {
    return usageRemainingCalls;
  }


  public void setUsageRemainingCalls(Integer usageRemainingCalls) {
    
    
    
    this.usageRemainingCalls = usageRemainingCalls;
  }


  public SubscriptionResponse historicalDays(Integer historicalDays) {
    
    
    
    
    this.historicalDays = historicalDays;
    return this;
  }

   /**
   * Get historicalDays
   * @return historicalDays
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getHistoricalDays() {
    return historicalDays;
  }


  public void setHistoricalDays(Integer historicalDays) {
    
    
    
    this.historicalDays = historicalDays;
  }

  /**
   * A container for additional, undeclared properties.
   * This is a holder for any undeclared properties as specified with
   * the 'additionalProperties' keyword in the OAS document.
   */
  private Map<String, Object> additionalProperties;

  /**
   * Set the additional (undeclared) property with the specified name and value.
   * If the property does not already exist, create it otherwise replace it.
   *
   * @param key name of the property
   * @param value value of the property
   * @return the SubscriptionResponse instance itself
   */
  public SubscriptionResponse putAdditionalProperty(String key, Object value) {
    if (this.additionalProperties == null) {
        this.additionalProperties = new HashMap<String, Object>();
    }
    this.additionalProperties.put(key, value);
    return this;
  }

  /**
   * Return the additional (undeclared) property.
   *
   * @return a map of objects
   */
  public Map<String, Object> getAdditionalProperties() {
    return additionalProperties;
  }

  /**
   * Return the additional (undeclared) property with the specified name.
   *
   * @param key name of the property
   * @return an object
   */
  public Object getAdditionalProperty(String key) {
    if (this.additionalProperties == null) {
        return null;
    }
    return this.additionalProperties.get(key);
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SubscriptionResponse subscriptionResponse = (SubscriptionResponse) o;
    return Objects.equals(this.active, subscriptionResponse.active) &&
        Objects.equals(this.callsPerSeconds, subscriptionResponse.callsPerSeconds) &&
        Objects.equals(this.planName, subscriptionResponse.planName) &&
        Objects.equals(this.usageAssignedCalls, subscriptionResponse.usageAssignedCalls) &&
        Objects.equals(this.usageRemainingCalls, subscriptionResponse.usageRemainingCalls) &&
        Objects.equals(this.historicalDays, subscriptionResponse.historicalDays)&&
        Objects.equals(this.additionalProperties, subscriptionResponse.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(active, callsPerSeconds, planName, usageAssignedCalls, usageRemainingCalls, historicalDays, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SubscriptionResponse {\n");
    sb.append("    active: ").append(toIndentedString(active)).append("\n");
    sb.append("    callsPerSeconds: ").append(toIndentedString(callsPerSeconds)).append("\n");
    sb.append("    planName: ").append(toIndentedString(planName)).append("\n");
    sb.append("    usageAssignedCalls: ").append(toIndentedString(usageAssignedCalls)).append("\n");
    sb.append("    usageRemainingCalls: ").append(toIndentedString(usageRemainingCalls)).append("\n");
    sb.append("    historicalDays: ").append(toIndentedString(historicalDays)).append("\n");
    sb.append("    additionalProperties: ").append(toIndentedString(additionalProperties)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public static HashSet<String> openapiFields;
  public static HashSet<String> openapiRequiredFields;

  static {
    // a set of all properties/fields (JSON key names)
    openapiFields = new HashSet<String>();
    openapiFields.add("active");
    openapiFields.add("calls_per_seconds");
    openapiFields.add("plan_name");
    openapiFields.add("usage_assigned_calls");
    openapiFields.add("usage_remaining_calls");
    openapiFields.add("historical_days");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("active");
    openapiRequiredFields.add("plan_name");
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to SubscriptionResponse
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!SubscriptionResponse.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in SubscriptionResponse is not found in the empty JSON string", SubscriptionResponse.openapiRequiredFields.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : SubscriptionResponse.openapiRequiredFields) {
        if (jsonObj.get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonObj.toString()));
        }
      }
      if (!jsonObj.get("plan_name").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `plan_name` to be a primitive type in the JSON string but got `%s`", jsonObj.get("plan_name").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!SubscriptionResponse.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'SubscriptionResponse' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<SubscriptionResponse> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(SubscriptionResponse.class));

       return (TypeAdapter<T>) new TypeAdapter<SubscriptionResponse>() {
           @Override
           public void write(JsonWriter out, SubscriptionResponse value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             obj.remove("additionalProperties");
             // serialize additonal properties
             if (value.getAdditionalProperties() != null) {
               for (Map.Entry<String, Object> entry : value.getAdditionalProperties().entrySet()) {
                 if (entry.getValue() instanceof String)
                   obj.addProperty(entry.getKey(), (String) entry.getValue());
                 else if (entry.getValue() instanceof Number)
                   obj.addProperty(entry.getKey(), (Number) entry.getValue());
                 else if (entry.getValue() instanceof Boolean)
                   obj.addProperty(entry.getKey(), (Boolean) entry.getValue());
                 else if (entry.getValue() instanceof Character)
                   obj.addProperty(entry.getKey(), (Character) entry.getValue());
                 else if (entry.getValue() == null) {
                   obj.addProperty(entry.getKey(), (String) null);
                 } else {
                   obj.add(entry.getKey(), gson.toJsonTree(entry.getValue()).getAsJsonObject());
                 }
               }
             }
             elementAdapter.write(out, obj);
           }

           @Override
           public SubscriptionResponse read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             // store additional fields in the deserialized instance
             SubscriptionResponse instance = thisAdapter.fromJsonTree(jsonObj);
             for (Map.Entry<String, JsonElement> entry : jsonObj.entrySet()) {
               if (!openapiFields.contains(entry.getKey())) {
                 if (entry.getValue().isJsonPrimitive()) { // primitive type
                   if (entry.getValue().getAsJsonPrimitive().isString())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsString());
                   else if (entry.getValue().getAsJsonPrimitive().isNumber())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsNumber());
                   else if (entry.getValue().getAsJsonPrimitive().isBoolean())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsBoolean());
                   else
                     throw new IllegalArgumentException(String.format("The field `%s` has unknown primitive type. Value: %s", entry.getKey(), entry.getValue().toString()));
                 } else if (entry.getValue().isJsonArray()) {
                     instance.putAdditionalProperty(entry.getKey(), gson.fromJson(entry.getValue(), List.class));
                 } else { // JSON object
                     instance.putAdditionalProperty(entry.getKey(), gson.fromJson(entry.getValue(), HashMap.class));
                 }
               }
             }
             return instance;
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of SubscriptionResponse given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of SubscriptionResponse
  * @throws IOException if the JSON string is invalid with respect to SubscriptionResponse
  */
  public static SubscriptionResponse fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, SubscriptionResponse.class);
  }

 /**
  * Convert an instance of SubscriptionResponse to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}


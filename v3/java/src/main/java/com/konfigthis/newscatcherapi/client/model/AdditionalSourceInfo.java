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
 * AdditionalSourceInfo DTO class.
 */
@ApiModel(description = "AdditionalSourceInfo DTO class.")@javax.annotation.Generated(value = "Generated by https://konfigthis.com")
public class AdditionalSourceInfo {
  public static final String SERIALIZED_NAME_NB_ARTICLES_FOR7D = "nb_articles_for_7d";
  @SerializedName(SERIALIZED_NAME_NB_ARTICLES_FOR7D)
  private Integer nbArticlesFor7d;

  public static final String SERIALIZED_NAME_COUNTRY = "country";
  @SerializedName(SERIALIZED_NAME_COUNTRY)
  private String country;

  public static final String SERIALIZED_NAME_RANK = "rank";
  @SerializedName(SERIALIZED_NAME_RANK)
  private Integer rank;

  public static final String SERIALIZED_NAME_IS_NEWS_DOMAIN = "is_news_domain";
  @SerializedName(SERIALIZED_NAME_IS_NEWS_DOMAIN)
  private Boolean isNewsDomain;

  public static final String SERIALIZED_NAME_NEWS_DOMAIN_TYPE = "news_domain_type";
  @SerializedName(SERIALIZED_NAME_NEWS_DOMAIN_TYPE)
  private String newsDomainType;

  public static final String SERIALIZED_NAME_NEWS_TYPE = "news_type";
  @SerializedName(SERIALIZED_NAME_NEWS_TYPE)
  private String newsType;

  public AdditionalSourceInfo() {
  }

  public AdditionalSourceInfo nbArticlesFor7d(Integer nbArticlesFor7d) {
    
    
    
    
    this.nbArticlesFor7d = nbArticlesFor7d;
    return this;
  }

   /**
   * Get nbArticlesFor7d
   * @return nbArticlesFor7d
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getNbArticlesFor7d() {
    return nbArticlesFor7d;
  }


  public void setNbArticlesFor7d(Integer nbArticlesFor7d) {
    
    
    
    this.nbArticlesFor7d = nbArticlesFor7d;
  }


  public AdditionalSourceInfo country(String country) {
    
    
    
    
    this.country = country;
    return this;
  }

   /**
   * Get country
   * @return country
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getCountry() {
    return country;
  }


  public void setCountry(String country) {
    
    
    
    this.country = country;
  }


  public AdditionalSourceInfo rank(Integer rank) {
    
    
    
    
    this.rank = rank;
    return this;
  }

   /**
   * Get rank
   * @return rank
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getRank() {
    return rank;
  }


  public void setRank(Integer rank) {
    
    
    
    this.rank = rank;
  }


  public AdditionalSourceInfo isNewsDomain(Boolean isNewsDomain) {
    
    
    
    
    this.isNewsDomain = isNewsDomain;
    return this;
  }

   /**
   * Get isNewsDomain
   * @return isNewsDomain
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsNewsDomain() {
    return isNewsDomain;
  }


  public void setIsNewsDomain(Boolean isNewsDomain) {
    
    
    
    this.isNewsDomain = isNewsDomain;
  }


  public AdditionalSourceInfo newsDomainType(String newsDomainType) {
    
    
    
    
    this.newsDomainType = newsDomainType;
    return this;
  }

   /**
   * Get newsDomainType
   * @return newsDomainType
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getNewsDomainType() {
    return newsDomainType;
  }


  public void setNewsDomainType(String newsDomainType) {
    
    
    
    this.newsDomainType = newsDomainType;
  }


  public AdditionalSourceInfo newsType(String newsType) {
    
    
    
    
    this.newsType = newsType;
    return this;
  }

   /**
   * Get newsType
   * @return newsType
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getNewsType() {
    return newsType;
  }


  public void setNewsType(String newsType) {
    
    
    
    this.newsType = newsType;
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
   * @return the AdditionalSourceInfo instance itself
   */
  public AdditionalSourceInfo putAdditionalProperty(String key, Object value) {
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
    AdditionalSourceInfo additionalSourceInfo = (AdditionalSourceInfo) o;
    return Objects.equals(this.nbArticlesFor7d, additionalSourceInfo.nbArticlesFor7d) &&
        Objects.equals(this.country, additionalSourceInfo.country) &&
        Objects.equals(this.rank, additionalSourceInfo.rank) &&
        Objects.equals(this.isNewsDomain, additionalSourceInfo.isNewsDomain) &&
        Objects.equals(this.newsDomainType, additionalSourceInfo.newsDomainType) &&
        Objects.equals(this.newsType, additionalSourceInfo.newsType)&&
        Objects.equals(this.additionalProperties, additionalSourceInfo.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(nbArticlesFor7d, country, rank, isNewsDomain, newsDomainType, newsType, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AdditionalSourceInfo {\n");
    sb.append("    nbArticlesFor7d: ").append(toIndentedString(nbArticlesFor7d)).append("\n");
    sb.append("    country: ").append(toIndentedString(country)).append("\n");
    sb.append("    rank: ").append(toIndentedString(rank)).append("\n");
    sb.append("    isNewsDomain: ").append(toIndentedString(isNewsDomain)).append("\n");
    sb.append("    newsDomainType: ").append(toIndentedString(newsDomainType)).append("\n");
    sb.append("    newsType: ").append(toIndentedString(newsType)).append("\n");
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
    openapiFields.add("nb_articles_for_7d");
    openapiFields.add("country");
    openapiFields.add("rank");
    openapiFields.add("is_news_domain");
    openapiFields.add("news_domain_type");
    openapiFields.add("news_type");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to AdditionalSourceInfo
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!AdditionalSourceInfo.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in AdditionalSourceInfo is not found in the empty JSON string", AdditionalSourceInfo.openapiRequiredFields.toString()));
        }
      }
      if ((jsonObj.get("country") != null && !jsonObj.get("country").isJsonNull()) && !jsonObj.get("country").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `country` to be a primitive type in the JSON string but got `%s`", jsonObj.get("country").toString()));
      }
      if ((jsonObj.get("news_domain_type") != null && !jsonObj.get("news_domain_type").isJsonNull()) && !jsonObj.get("news_domain_type").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `news_domain_type` to be a primitive type in the JSON string but got `%s`", jsonObj.get("news_domain_type").toString()));
      }
      if ((jsonObj.get("news_type") != null && !jsonObj.get("news_type").isJsonNull()) && !jsonObj.get("news_type").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `news_type` to be a primitive type in the JSON string but got `%s`", jsonObj.get("news_type").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!AdditionalSourceInfo.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'AdditionalSourceInfo' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<AdditionalSourceInfo> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(AdditionalSourceInfo.class));

       return (TypeAdapter<T>) new TypeAdapter<AdditionalSourceInfo>() {
           @Override
           public void write(JsonWriter out, AdditionalSourceInfo value) throws IOException {
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
           public AdditionalSourceInfo read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             // store additional fields in the deserialized instance
             AdditionalSourceInfo instance = thisAdapter.fromJsonTree(jsonObj);
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
  * Create an instance of AdditionalSourceInfo given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of AdditionalSourceInfo
  * @throws IOException if the JSON string is invalid with respect to AdditionalSourceInfo
  */
  public static AdditionalSourceInfo fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, AdditionalSourceInfo.class);
  }

 /**
  * Convert an instance of AdditionalSourceInfo to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}


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
import com.konfigthis.newscatcherapi.client.model.Cluster1;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

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
 * SearchResponse DTO class.
 */
@ApiModel(description = "SearchResponse DTO class.")@javax.annotation.Generated(value = "Generated by https://konfigthis.com")
public class CSearchResponse3 {
  public static final String SERIALIZED_NAME_STATUS = "status";
  @SerializedName(SERIALIZED_NAME_STATUS)
  private String status = "ok";

  public static final String SERIALIZED_NAME_TOTAL_HITS = "total_hits";
  @SerializedName(SERIALIZED_NAME_TOTAL_HITS)
  private Integer totalHits;

  public static final String SERIALIZED_NAME_PAGE = "page";
  @SerializedName(SERIALIZED_NAME_PAGE)
  private Integer page;

  public static final String SERIALIZED_NAME_TOTAL_PAGES = "total_pages";
  @SerializedName(SERIALIZED_NAME_TOTAL_PAGES)
  private Integer totalPages;

  public static final String SERIALIZED_NAME_PAGE_SIZE = "page_size";
  @SerializedName(SERIALIZED_NAME_PAGE_SIZE)
  private Integer pageSize;

  public static final String SERIALIZED_NAME_ARTICLES = "articles";
  @SerializedName(SERIALIZED_NAME_ARTICLES)
  private List<Object> articles = null;

  public static final String SERIALIZED_NAME_USER_INPUT = "user_input";
  @SerializedName(SERIALIZED_NAME_USER_INPUT)
  private Object userInput;

  public static final String SERIALIZED_NAME_CLUSTERS_COUNT = "clusters_count";
  @SerializedName(SERIALIZED_NAME_CLUSTERS_COUNT)
  private Integer clustersCount;

  public static final String SERIALIZED_NAME_CLUSTERS = "clusters";
  @SerializedName(SERIALIZED_NAME_CLUSTERS)
  private List<Cluster1> clusters = null;

  public CSearchResponse3() {
  }

  public CSearchResponse3 status(String status) {
    
    
    
    
    this.status = status;
    return this;
  }

   /**
   * Get status
   * @return status
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "ok", value = "")

  public String getStatus() {
    return status;
  }


  public void setStatus(String status) {
    
    
    
    this.status = status;
  }


  public CSearchResponse3 totalHits(Integer totalHits) {
    
    
    
    
    this.totalHits = totalHits;
    return this;
  }

   /**
   * Get totalHits
   * @return totalHits
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public Integer getTotalHits() {
    return totalHits;
  }


  public void setTotalHits(Integer totalHits) {
    
    
    
    this.totalHits = totalHits;
  }


  public CSearchResponse3 page(Integer page) {
    
    
    
    
    this.page = page;
    return this;
  }

   /**
   * Get page
   * @return page
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public Integer getPage() {
    return page;
  }


  public void setPage(Integer page) {
    
    
    
    this.page = page;
  }


  public CSearchResponse3 totalPages(Integer totalPages) {
    
    
    
    
    this.totalPages = totalPages;
    return this;
  }

   /**
   * Get totalPages
   * @return totalPages
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public Integer getTotalPages() {
    return totalPages;
  }


  public void setTotalPages(Integer totalPages) {
    
    
    
    this.totalPages = totalPages;
  }


  public CSearchResponse3 pageSize(Integer pageSize) {
    
    
    
    
    this.pageSize = pageSize;
    return this;
  }

   /**
   * Get pageSize
   * @return pageSize
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public Integer getPageSize() {
    return pageSize;
  }


  public void setPageSize(Integer pageSize) {
    
    
    
    this.pageSize = pageSize;
  }


  public CSearchResponse3 articles(List<Object> articles) {
    
    
    
    
    this.articles = articles;
    return this;
  }

  public CSearchResponse3 addArticlesItem(Object articlesItem) {
    if (this.articles == null) {
      this.articles = new ArrayList<>();
    }
    this.articles.add(articlesItem);
    return this;
  }

   /**
   * Get articles
   * @return articles
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<Object> getArticles() {
    return articles;
  }


  public void setArticles(List<Object> articles) {
    
    
    
    this.articles = articles;
  }


  public CSearchResponse3 userInput(Object userInput) {
    
    
    
    
    this.userInput = userInput;
    return this;
  }

   /**
   * Get userInput
   * @return userInput
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public Object getUserInput() {
    return userInput;
  }


  public void setUserInput(Object userInput) {
    
    
    
    this.userInput = userInput;
  }


  public CSearchResponse3 clustersCount(Integer clustersCount) {
    
    
    
    
    this.clustersCount = clustersCount;
    return this;
  }

   /**
   * Get clustersCount
   * @return clustersCount
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getClustersCount() {
    return clustersCount;
  }


  public void setClustersCount(Integer clustersCount) {
    
    
    
    this.clustersCount = clustersCount;
  }


  public CSearchResponse3 clusters(List<Cluster1> clusters) {
    
    
    
    
    this.clusters = clusters;
    return this;
  }

  public CSearchResponse3 addClustersItem(Cluster1 clustersItem) {
    if (this.clusters == null) {
      this.clusters = new ArrayList<>();
    }
    this.clusters.add(clustersItem);
    return this;
  }

   /**
   * Get clusters
   * @return clusters
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<Cluster1> getClusters() {
    return clusters;
  }


  public void setClusters(List<Cluster1> clusters) {
    
    
    
    this.clusters = clusters;
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
   * @return the CSearchResponse3 instance itself
   */
  public CSearchResponse3 putAdditionalProperty(String key, Object value) {
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
    CSearchResponse3 csearchResponse3 = (CSearchResponse3) o;
    return Objects.equals(this.status, csearchResponse3.status) &&
        Objects.equals(this.totalHits, csearchResponse3.totalHits) &&
        Objects.equals(this.page, csearchResponse3.page) &&
        Objects.equals(this.totalPages, csearchResponse3.totalPages) &&
        Objects.equals(this.pageSize, csearchResponse3.pageSize) &&
        Objects.equals(this.articles, csearchResponse3.articles) &&
        Objects.equals(this.userInput, csearchResponse3.userInput) &&
        Objects.equals(this.clustersCount, csearchResponse3.clustersCount) &&
        Objects.equals(this.clusters, csearchResponse3.clusters)&&
        Objects.equals(this.additionalProperties, csearchResponse3.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(status, totalHits, page, totalPages, pageSize, articles, userInput, clustersCount, clusters, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CSearchResponse3 {\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    totalHits: ").append(toIndentedString(totalHits)).append("\n");
    sb.append("    page: ").append(toIndentedString(page)).append("\n");
    sb.append("    totalPages: ").append(toIndentedString(totalPages)).append("\n");
    sb.append("    pageSize: ").append(toIndentedString(pageSize)).append("\n");
    sb.append("    articles: ").append(toIndentedString(articles)).append("\n");
    sb.append("    userInput: ").append(toIndentedString(userInput)).append("\n");
    sb.append("    clustersCount: ").append(toIndentedString(clustersCount)).append("\n");
    sb.append("    clusters: ").append(toIndentedString(clusters)).append("\n");
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
    openapiFields.add("status");
    openapiFields.add("total_hits");
    openapiFields.add("page");
    openapiFields.add("total_pages");
    openapiFields.add("page_size");
    openapiFields.add("articles");
    openapiFields.add("user_input");
    openapiFields.add("clusters_count");
    openapiFields.add("clusters");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("total_hits");
    openapiRequiredFields.add("page");
    openapiRequiredFields.add("total_pages");
    openapiRequiredFields.add("page_size");
    openapiRequiredFields.add("user_input");
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to CSearchResponse3
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!CSearchResponse3.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in CSearchResponse3 is not found in the empty JSON string", CSearchResponse3.openapiRequiredFields.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : CSearchResponse3.openapiRequiredFields) {
        if (jsonObj.get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonObj.toString()));
        }
      }
      if ((jsonObj.get("status") != null && !jsonObj.get("status").isJsonNull()) && !jsonObj.get("status").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `status` to be a primitive type in the JSON string but got `%s`", jsonObj.get("status").toString()));
      }
      // ensure the optional json data is an array if present
      if (jsonObj.get("articles") != null && !jsonObj.get("articles").isJsonArray()) {
        throw new IllegalArgumentException(String.format("Expected the field `articles` to be an array in the JSON string but got `%s`", jsonObj.get("articles").toString()));
      }
      if (jsonObj.get("clusters") != null && !jsonObj.get("clusters").isJsonNull()) {
        JsonArray jsonArrayclusters = jsonObj.getAsJsonArray("clusters");
        if (jsonArrayclusters != null) {
          // ensure the json data is an array
          if (!jsonObj.get("clusters").isJsonArray()) {
            throw new IllegalArgumentException(String.format("Expected the field `clusters` to be an array in the JSON string but got `%s`", jsonObj.get("clusters").toString()));
          }

          // validate the optional field `clusters` (array)
          for (int i = 0; i < jsonArrayclusters.size(); i++) {
            Cluster1.validateJsonObject(jsonArrayclusters.get(i).getAsJsonObject());
          };
        }
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!CSearchResponse3.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'CSearchResponse3' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<CSearchResponse3> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(CSearchResponse3.class));

       return (TypeAdapter<T>) new TypeAdapter<CSearchResponse3>() {
           @Override
           public void write(JsonWriter out, CSearchResponse3 value) throws IOException {
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
                 else {
                   obj.add(entry.getKey(), gson.toJsonTree(entry.getValue()).getAsJsonObject());
                 }
               }
             }
             elementAdapter.write(out, obj);
           }

           @Override
           public CSearchResponse3 read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             // store additional fields in the deserialized instance
             CSearchResponse3 instance = thisAdapter.fromJsonTree(jsonObj);
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
  * Create an instance of CSearchResponse3 given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of CSearchResponse3
  * @throws IOException if the JSON string is invalid with respect to CSearchResponse3
  */
  public static CSearchResponse3 fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, CSearchResponse3.class);
  }

 /**
  * Convert an instance of CSearchResponse3 to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}


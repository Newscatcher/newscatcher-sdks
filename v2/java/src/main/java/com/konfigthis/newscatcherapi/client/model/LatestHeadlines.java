/*
 * NewsCatcher News API V2
 * NewsCatcher is a data-as-a-service startup that has one main goal: to build the largest database of structured news articles published online. In other words, we're like Google for the news part of the web, which you can access as a source of data.  Some useful links: - [How NewsCatcher Works](https://docs.newscatcherapi.com/knowledge-base/how-newscatcher-works) - [GitHub for the Python SDK](https://github.com/NewscatcherAPI/newscatcherapi-sdk-python) 
 *
 * The version of the OpenAPI document: 1.0.1
 * Contact: team@newscatcherapi.com
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

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Set;

import com.konfigthis.newscatcherapi.client.JSON;

/**
 * LatestHeadlines
 */
@javax.annotation.Generated(value = "Generated by https://konfigthis.com")
public class LatestHeadlines {
  public static final String SERIALIZED_NAME_WHEN = "when";
  @SerializedName(SERIALIZED_NAME_WHEN)
  private String when;

  /**
   * The language you want to search in.
   */
  @JsonAdapter(LangEnum.Adapter.class)
  public enum LangEnum {
    AF("af"),
    
    AR("ar"),
    
    BG("bg"),
    
    BN("bn"),
    
    CA("ca"),
    
    CN("cn"),
    
    CS("cs"),
    
    CY("cy"),
    
    DA("da"),
    
    DE("de"),
    
    EL("el"),
    
    EN("en"),
    
    ES("es"),
    
    ET("et"),
    
    FA("fa"),
    
    FI("fi"),
    
    FR("fr"),
    
    GU("gu"),
    
    HE("he"),
    
    HI("hi"),
    
    HR("hr"),
    
    HU("hu"),
    
    ID("id"),
    
    IT("it"),
    
    JA("ja"),
    
    KN("kn"),
    
    KO("ko"),
    
    LT("lt"),
    
    LV("lv"),
    
    MK("mk"),
    
    ML("ml"),
    
    MR("mr"),
    
    NE("ne"),
    
    NL("nl"),
    
    FALSE("false"),
    
    PA("pa"),
    
    PL("pl"),
    
    PT("pt"),
    
    RO("ro"),
    
    RU("ru"),
    
    SK("sk"),
    
    SL("sl"),
    
    SO("so"),
    
    SQ("sq"),
    
    SV("sv"),
    
    SW("sw"),
    
    TA("ta"),
    
    TE("te"),
    
    TH("th"),
    
    TL("tl"),
    
    TR("tr"),
    
    TW("tw"),
    
    UK("uk"),
    
    UR("ur"),
    
    VI("vi");

    private String value;

    LangEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static LangEnum fromValue(String value) {
      for (LangEnum b : LangEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }

    public static class Adapter extends TypeAdapter<LangEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final LangEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public LangEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return LangEnum.fromValue(value);
      }
    }
  }

  public static final String SERIALIZED_NAME_LANG = "lang";
  @SerializedName(SERIALIZED_NAME_LANG)
  private LangEnum lang;

  public static final String SERIALIZED_NAME_COUNTRIES = "countries";
  @SerializedName(SERIALIZED_NAME_COUNTRIES)
  private String countries;

  public static final String SERIALIZED_NAME_NOT_COUNTRIES = "not_countries";
  @SerializedName(SERIALIZED_NAME_NOT_COUNTRIES)
  private String notCountries;

  /**
   * Gets or Sets topic
   */
  @JsonAdapter(TopicEnum.Adapter.class)
  public enum TopicEnum {
    NEWS("news"),
    
    SPORT("sport"),
    
    TECH("tech"),
    
    WORLD("world"),
    
    FINANCE("finance"),
    
    POLITICS("politics"),
    
    BUSINESS("business"),
    
    ECONOMICS("economics"),
    
    ENTERTAINMENT("entertainment"),
    
    BEAUTY("beauty"),
    
    TRAVEL("travel"),
    
    MUSIC("music"),
    
    FOOD("food"),
    
    SCIENCE("science"),
    
    GAMING("gaming");

    private String value;

    TopicEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static TopicEnum fromValue(String value) {
      for (TopicEnum b : TopicEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }

    public static class Adapter extends TypeAdapter<TopicEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final TopicEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public TopicEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return TopicEnum.fromValue(value);
      }
    }
  }

  public static final String SERIALIZED_NAME_TOPIC = "topic";
  @SerializedName(SERIALIZED_NAME_TOPIC)
  private TopicEnum topic;

  public static final String SERIALIZED_NAME_SOURCES = "sources";
  @SerializedName(SERIALIZED_NAME_SOURCES)
  private String sources;

  public static final String SERIALIZED_NAME_NOT_SOURCES = "not_sources";
  @SerializedName(SERIALIZED_NAME_NOT_SOURCES)
  private String notSources;

  public static final String SERIALIZED_NAME_RANKED_ONLY = "ranked_only";
  @SerializedName(SERIALIZED_NAME_RANKED_ONLY)
  private Boolean rankedOnly;

  public static final String SERIALIZED_NAME_PAGE_SIZE = "page_size";
  @SerializedName(SERIALIZED_NAME_PAGE_SIZE)
  private Integer pageSize;

  public static final String SERIALIZED_NAME_PAGE = "page";
  @SerializedName(SERIALIZED_NAME_PAGE)
  private Integer page;

  public LatestHeadlines() {
  }

  public LatestHeadlines when(String when) {
    
    this.when = when;
    return this;
  }

   /**
   * The time period you want to get the headlines for. Accpeted format: - &#x60;7d&#x60; -&gt; Daily form, last 7 days time period - &#x60;6h&#x60; -&gt; Hourly form, last six hours 
   * @return when
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "12h", value = "The time period you want to get the headlines for. Accpeted format: - `7d` -> Daily form, last 7 days time period - `6h` -> Hourly form, last six hours ")

  public String getWhen() {
    return when;
  }


  public void setWhen(String when) {
    this.when = when;
  }


  public LatestHeadlines lang(LangEnum lang) {
    
    this.lang = lang;
    return this;
  }

   /**
   * The language you want to search in.
   * @return lang
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "en", value = "The language you want to search in.")

  public LangEnum getLang() {
    return lang;
  }


  public void setLang(LangEnum lang) {
    this.lang = lang;
  }


  public LatestHeadlines countries(String countries) {
    
    this.countries = countries;
    return this;
  }

   /**
   * Get countries
   * @return countries
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "US,CA", value = "")

  public String getCountries() {
    return countries;
  }


  public void setCountries(String countries) {
    this.countries = countries;
  }


  public LatestHeadlines notCountries(String notCountries) {
    
    this.notCountries = notCountries;
    return this;
  }

   /**
   * Get notCountries
   * @return notCountries
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getNotCountries() {
    return notCountries;
  }


  public void setNotCountries(String notCountries) {
    this.notCountries = notCountries;
  }


  public LatestHeadlines topic(TopicEnum topic) {
    
    this.topic = topic;
    return this;
  }

   /**
   * Get topic
   * @return topic
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "business", value = "")

  public TopicEnum getTopic() {
    return topic;
  }


  public void setTopic(TopicEnum topic) {
    this.topic = topic;
  }


  public LatestHeadlines sources(String sources) {
    
    this.sources = sources;
    return this;
  }

   /**
   * Get sources
   * @return sources
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "nytimes.com,theguardian.com", value = "")

  public String getSources() {
    return sources;
  }


  public void setSources(String sources) {
    this.sources = sources;
  }


  public LatestHeadlines notSources(String notSources) {
    
    this.notSources = notSources;
    return this;
  }

   /**
   * Get notSources
   * @return notSources
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "wsj.com", value = "")

  public String getNotSources() {
    return notSources;
  }


  public void setNotSources(String notSources) {
    this.notSources = notSources;
  }


  public LatestHeadlines rankedOnly(Boolean rankedOnly) {
    
    this.rankedOnly = rankedOnly;
    return this;
  }

   /**
   * Get rankedOnly
   * @return rankedOnly
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "true", value = "")

  public Boolean getRankedOnly() {
    return rankedOnly;
  }


  public void setRankedOnly(Boolean rankedOnly) {
    this.rankedOnly = rankedOnly;
  }


  public LatestHeadlines pageSize(Integer pageSize) {
    
    this.pageSize = pageSize;
    return this;
  }

   /**
   * Get pageSize
   * minimum: 1
   * maximum: 100
   * @return pageSize
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "100", value = "")

  public Integer getPageSize() {
    return pageSize;
  }


  public void setPageSize(Integer pageSize) {
    this.pageSize = pageSize;
  }


  public LatestHeadlines page(Integer page) {
    
    this.page = page;
    return this;
  }

   /**
   * Get page
   * minimum: 1
   * @return page
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "1", value = "")

  public Integer getPage() {
    return page;
  }


  public void setPage(Integer page) {
    this.page = page;
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
   * @return the LatestHeadlines instance itself
   */
  public LatestHeadlines putAdditionalProperty(String key, Object value) {
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
    LatestHeadlines latestHeadlines = (LatestHeadlines) o;
    return Objects.equals(this.when, latestHeadlines.when) &&
        Objects.equals(this.lang, latestHeadlines.lang) &&
        Objects.equals(this.countries, latestHeadlines.countries) &&
        Objects.equals(this.notCountries, latestHeadlines.notCountries) &&
        Objects.equals(this.topic, latestHeadlines.topic) &&
        Objects.equals(this.sources, latestHeadlines.sources) &&
        Objects.equals(this.notSources, latestHeadlines.notSources) &&
        Objects.equals(this.rankedOnly, latestHeadlines.rankedOnly) &&
        Objects.equals(this.pageSize, latestHeadlines.pageSize) &&
        Objects.equals(this.page, latestHeadlines.page)&&
        Objects.equals(this.additionalProperties, latestHeadlines.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(when, lang, countries, notCountries, topic, sources, notSources, rankedOnly, pageSize, page, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LatestHeadlines {\n");
    sb.append("    when: ").append(toIndentedString(when)).append("\n");
    sb.append("    lang: ").append(toIndentedString(lang)).append("\n");
    sb.append("    countries: ").append(toIndentedString(countries)).append("\n");
    sb.append("    notCountries: ").append(toIndentedString(notCountries)).append("\n");
    sb.append("    topic: ").append(toIndentedString(topic)).append("\n");
    sb.append("    sources: ").append(toIndentedString(sources)).append("\n");
    sb.append("    notSources: ").append(toIndentedString(notSources)).append("\n");
    sb.append("    rankedOnly: ").append(toIndentedString(rankedOnly)).append("\n");
    sb.append("    pageSize: ").append(toIndentedString(pageSize)).append("\n");
    sb.append("    page: ").append(toIndentedString(page)).append("\n");
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
    openapiFields.add("when");
    openapiFields.add("lang");
    openapiFields.add("countries");
    openapiFields.add("not_countries");
    openapiFields.add("topic");
    openapiFields.add("sources");
    openapiFields.add("not_sources");
    openapiFields.add("ranked_only");
    openapiFields.add("page_size");
    openapiFields.add("page");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to LatestHeadlines
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!LatestHeadlines.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in LatestHeadlines is not found in the empty JSON string", LatestHeadlines.openapiRequiredFields.toString()));
        }
      }
      if ((jsonObj.get("when") != null && !jsonObj.get("when").isJsonNull()) && !jsonObj.get("when").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `when` to be a primitive type in the JSON string but got `%s`", jsonObj.get("when").toString()));
      }
      if ((jsonObj.get("lang") != null && !jsonObj.get("lang").isJsonNull()) && !jsonObj.get("lang").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `lang` to be a primitive type in the JSON string but got `%s`", jsonObj.get("lang").toString()));
      }
      if ((jsonObj.get("countries") != null && !jsonObj.get("countries").isJsonNull()) && !jsonObj.get("countries").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `countries` to be a primitive type in the JSON string but got `%s`", jsonObj.get("countries").toString()));
      }
      if ((jsonObj.get("not_countries") != null && !jsonObj.get("not_countries").isJsonNull()) && !jsonObj.get("not_countries").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `not_countries` to be a primitive type in the JSON string but got `%s`", jsonObj.get("not_countries").toString()));
      }
      if ((jsonObj.get("topic") != null && !jsonObj.get("topic").isJsonNull()) && !jsonObj.get("topic").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `topic` to be a primitive type in the JSON string but got `%s`", jsonObj.get("topic").toString()));
      }
      if ((jsonObj.get("sources") != null && !jsonObj.get("sources").isJsonNull()) && !jsonObj.get("sources").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `sources` to be a primitive type in the JSON string but got `%s`", jsonObj.get("sources").toString()));
      }
      if ((jsonObj.get("not_sources") != null && !jsonObj.get("not_sources").isJsonNull()) && !jsonObj.get("not_sources").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `not_sources` to be a primitive type in the JSON string but got `%s`", jsonObj.get("not_sources").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!LatestHeadlines.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'LatestHeadlines' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<LatestHeadlines> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(LatestHeadlines.class));

       return (TypeAdapter<T>) new TypeAdapter<LatestHeadlines>() {
           @Override
           public void write(JsonWriter out, LatestHeadlines value) throws IOException {
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
           public LatestHeadlines read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             // store additional fields in the deserialized instance
             LatestHeadlines instance = thisAdapter.fromJsonTree(jsonObj);
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
  * Create an instance of LatestHeadlines given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of LatestHeadlines
  * @throws IOException if the JSON string is invalid with respect to LatestHeadlines
  */
  public static LatestHeadlines fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, LatestHeadlines.class);
  }

 /**
  * Convert an instance of LatestHeadlines to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

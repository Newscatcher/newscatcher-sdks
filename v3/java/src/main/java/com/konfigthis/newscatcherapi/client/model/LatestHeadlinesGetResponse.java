/*
 * NewsCatcher-V3 Production API
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a> <br> <p style=\"color: red\"><b><em> This is a Testing Phase API. Please use it for testing purposes only. </em></b></p> <br>
 *
 * The version of the OpenAPI document: Beta-3.0.0
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
import com.konfigthis.newscatcherapi.client.model.AllDomainLinksProperty;
import com.konfigthis.newscatcherapi.client.model.AllLinksProperty;
import com.konfigthis.newscatcherapi.client.model.AuthorsProperty;
import com.konfigthis.newscatcherapi.client.model.Cluster;
import com.konfigthis.newscatcherapi.client.model.ClusteringSearchResponse;
import com.konfigthis.newscatcherapi.client.model.DtoResponsesLatestHeadlinesResponseArticleResult;
import com.konfigthis.newscatcherapi.client.model.FailedLatestHeadlinesResponse;
import com.konfigthis.newscatcherapi.client.model.JournalistsProperty;
import com.konfigthis.newscatcherapi.client.model.LatestHeadlinesResponse;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import javax.ws.rs.core.GenericType;

import java.io.IOException;
import java.lang.reflect.Type;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.HashMap;
import java.util.Map;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapter;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;
import com.google.gson.JsonPrimitive;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonSerializationContext;
import com.google.gson.JsonSerializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;

import com.konfigthis.newscatcherapi.client.JSON;
@javax.annotation.Generated(value = "Generated by https://konfigthis.com")
public class LatestHeadlinesGetResponse extends AbstractOpenApiSchema {
    private static final Logger log = Logger.getLogger(LatestHeadlinesGetResponse.class.getName());

    public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
        @SuppressWarnings("unchecked")
        @Override
        public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
            if (!LatestHeadlinesGetResponse.class.isAssignableFrom(type.getRawType())) {
                return null; // this class only serializes 'LatestHeadlinesGetResponse' and its subtypes
            }
            final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
            final TypeAdapter<ClusteringSearchResponse> adapterClusteringSearchResponse = gson.getDelegateAdapter(this, TypeToken.get(ClusteringSearchResponse.class));
            final TypeAdapter<FailedLatestHeadlinesResponse> adapterFailedLatestHeadlinesResponse = gson.getDelegateAdapter(this, TypeToken.get(FailedLatestHeadlinesResponse.class));
            final TypeAdapter<LatestHeadlinesResponse> adapterLatestHeadlinesResponse = gson.getDelegateAdapter(this, TypeToken.get(LatestHeadlinesResponse.class));

            return (TypeAdapter<T>) new TypeAdapter<LatestHeadlinesGetResponse>() {
                @Override
                public void write(JsonWriter out, LatestHeadlinesGetResponse value) throws IOException {
                    if (value == null || value.getActualInstance() == null) {
                        elementAdapter.write(out, null);
                        return;
                    }

                    // check if the actual instance is of the type `ClusteringSearchResponse`
                    if (value.getActualInstance() instanceof ClusteringSearchResponse) {
                        JsonObject obj = adapterClusteringSearchResponse.toJsonTree((ClusteringSearchResponse)value.getActualInstance()).getAsJsonObject();
                        elementAdapter.write(out, obj);
                        return;
                    }

                    // check if the actual instance is of the type `FailedLatestHeadlinesResponse`
                    if (value.getActualInstance() instanceof FailedLatestHeadlinesResponse) {
                        JsonObject obj = adapterFailedLatestHeadlinesResponse.toJsonTree((FailedLatestHeadlinesResponse)value.getActualInstance()).getAsJsonObject();
                        elementAdapter.write(out, obj);
                        return;
                    }

                    // check if the actual instance is of the type `LatestHeadlinesResponse`
                    if (value.getActualInstance() instanceof LatestHeadlinesResponse) {
                        JsonObject obj = adapterLatestHeadlinesResponse.toJsonTree((LatestHeadlinesResponse)value.getActualInstance()).getAsJsonObject();
                        elementAdapter.write(out, obj);
                        return;
                    }

                    throw new IOException("Failed to serialize as the type doesn't match anyOf schemas: ClusteringSearchResponse, FailedLatestHeadlinesResponse, LatestHeadlinesResponse");
                }

                @Override
                public LatestHeadlinesGetResponse read(JsonReader in) throws IOException {
                    Object deserialized = null;
                    JsonObject jsonObject = elementAdapter.read(in).getAsJsonObject();

                    // deserialize ClusteringSearchResponse
                    try {
                        // validate the JSON object to see if any exception is thrown
                        ClusteringSearchResponse.validateJsonObject(jsonObject);
                        log.log(Level.FINER, "Input data matches schema 'ClusteringSearchResponse'");
                        LatestHeadlinesGetResponse ret = new LatestHeadlinesGetResponse();
                        ret.setActualInstance(adapterClusteringSearchResponse.fromJsonTree(jsonObject));
                        return ret;
                    } catch (Exception e) {
                        // deserialization failed, continue
                        log.log(Level.FINER, "Input data does not match schema 'ClusteringSearchResponse'", e);
                    }

                    // deserialize FailedLatestHeadlinesResponse
                    try {
                        // validate the JSON object to see if any exception is thrown
                        FailedLatestHeadlinesResponse.validateJsonObject(jsonObject);
                        log.log(Level.FINER, "Input data matches schema 'FailedLatestHeadlinesResponse'");
                        LatestHeadlinesGetResponse ret = new LatestHeadlinesGetResponse();
                        ret.setActualInstance(adapterFailedLatestHeadlinesResponse.fromJsonTree(jsonObject));
                        return ret;
                    } catch (Exception e) {
                        // deserialization failed, continue
                        log.log(Level.FINER, "Input data does not match schema 'FailedLatestHeadlinesResponse'", e);
                    }

                    // deserialize LatestHeadlinesResponse
                    try {
                        // validate the JSON object to see if any exception is thrown
                        LatestHeadlinesResponse.validateJsonObject(jsonObject);
                        log.log(Level.FINER, "Input data matches schema 'LatestHeadlinesResponse'");
                        LatestHeadlinesGetResponse ret = new LatestHeadlinesGetResponse();
                        ret.setActualInstance(adapterLatestHeadlinesResponse.fromJsonTree(jsonObject));
                        return ret;
                    } catch (Exception e) {
                        // deserialization failed, continue
                        log.log(Level.FINER, "Input data does not match schema 'LatestHeadlinesResponse'", e);
                    }


                    throw new IOException(String.format("Failed deserialization for LatestHeadlinesGetResponse: no class matched. JSON: %s", jsonObject.toString()));
                }
            }.nullSafe();
        }
    }

    // store a list of schema names defined in anyOf
    public static final Map<String, GenericType> schemas = new HashMap<String, GenericType>();

    public LatestHeadlinesGetResponse() {
        super("anyOf", Boolean.FALSE);
    }

    public LatestHeadlinesGetResponse(ClusteringSearchResponse o) {
        super("anyOf", Boolean.FALSE);
        setActualInstance(o);
    }

    public LatestHeadlinesGetResponse(FailedLatestHeadlinesResponse o) {
        super("anyOf", Boolean.FALSE);
        setActualInstance(o);
    }

    public LatestHeadlinesGetResponse(LatestHeadlinesResponse o) {
        super("anyOf", Boolean.FALSE);
        setActualInstance(o);
    }

    static {
        schemas.put("ClusteringSearchResponse", new GenericType<ClusteringSearchResponse>() {
        });
        schemas.put("FailedLatestHeadlinesResponse", new GenericType<FailedLatestHeadlinesResponse>() {
        });
        schemas.put("LatestHeadlinesResponse", new GenericType<LatestHeadlinesResponse>() {
        });
    }

    @Override
    public Map<String, GenericType> getSchemas() {
        return LatestHeadlinesGetResponse.schemas;
    }

    /**
     * Set the instance that matches the anyOf child schema, check
     * the instance parameter is valid against the anyOf child schemas:
     * ClusteringSearchResponse, FailedLatestHeadlinesResponse, LatestHeadlinesResponse
     *
     * It could be an instance of the 'anyOf' schemas.
     * The anyOf child schemas may themselves be a composed schema (allOf, anyOf, anyOf).
     */
    @Override
    public void setActualInstance(Object instance) {
        if (instance instanceof ClusteringSearchResponse) {
            super.setActualInstance(instance);
            return;
        }

        if (instance instanceof FailedLatestHeadlinesResponse) {
            super.setActualInstance(instance);
            return;
        }

        if (instance instanceof LatestHeadlinesResponse) {
            super.setActualInstance(instance);
            return;
        }

        throw new RuntimeException("Invalid instance type. Must be ClusteringSearchResponse, FailedLatestHeadlinesResponse, LatestHeadlinesResponse");
    }

    /**
     * Get the actual instance, which can be the following:
     * ClusteringSearchResponse, FailedLatestHeadlinesResponse, LatestHeadlinesResponse
     *
     * @return The actual instance (ClusteringSearchResponse, FailedLatestHeadlinesResponse, LatestHeadlinesResponse)
     */
    @Override
    public Object getActualInstance() {
        return super.getActualInstance();
    }

    /**
     * Get the actual instance of `ClusteringSearchResponse`. If the actual instance is not `ClusteringSearchResponse`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `ClusteringSearchResponse`
     * @throws ClassCastException if the instance is not `ClusteringSearchResponse`
     */
    public ClusteringSearchResponse getClusteringSearchResponse() throws ClassCastException {
        return (ClusteringSearchResponse)super.getActualInstance();
    }

    /**
     * Get the actual instance of `FailedLatestHeadlinesResponse`. If the actual instance is not `FailedLatestHeadlinesResponse`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `FailedLatestHeadlinesResponse`
     * @throws ClassCastException if the instance is not `FailedLatestHeadlinesResponse`
     */
    public FailedLatestHeadlinesResponse getFailedLatestHeadlinesResponse() throws ClassCastException {
        return (FailedLatestHeadlinesResponse)super.getActualInstance();
    }

    /**
     * Get the actual instance of `LatestHeadlinesResponse`. If the actual instance is not `LatestHeadlinesResponse`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `LatestHeadlinesResponse`
     * @throws ClassCastException if the instance is not `LatestHeadlinesResponse`
     */
    public LatestHeadlinesResponse getLatestHeadlinesResponse() throws ClassCastException {
        return (LatestHeadlinesResponse)super.getActualInstance();
    }


 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to LatestHeadlinesGetResponse
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
    // validate anyOf schemas one by one
    int validCount = 0;
    // validate the json string with ClusteringSearchResponse
    try {
      ClusteringSearchResponse.validateJsonObject(jsonObj);
      return; // return earlier as at least one schema is valid with respect to the Json object
      //validCount++;
    } catch (Exception e) {
      // continue to the next one
    }
    // validate the json string with FailedLatestHeadlinesResponse
    try {
      FailedLatestHeadlinesResponse.validateJsonObject(jsonObj);
      return; // return earlier as at least one schema is valid with respect to the Json object
      //validCount++;
    } catch (Exception e) {
      // continue to the next one
    }
    // validate the json string with LatestHeadlinesResponse
    try {
      LatestHeadlinesResponse.validateJsonObject(jsonObj);
      return; // return earlier as at least one schema is valid with respect to the Json object
      //validCount++;
    } catch (Exception e) {
      // continue to the next one
    }
    if (validCount == 0) {
      throw new IOException(String.format("The JSON string is invalid for LatestHeadlinesGetResponse with anyOf schemas: ClusteringSearchResponse, FailedLatestHeadlinesResponse, LatestHeadlinesResponse. JSON: %s", jsonObj.toString()));
    }
  }

 /**
  * Create an instance of LatestHeadlinesGetResponse given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of LatestHeadlinesGetResponse
  * @throws IOException if the JSON string is invalid with respect to LatestHeadlinesGetResponse
  */
  public static LatestHeadlinesGetResponse fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, LatestHeadlinesGetResponse.class);
  }

 /**
  * Convert an instance of LatestHeadlinesGetResponse to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

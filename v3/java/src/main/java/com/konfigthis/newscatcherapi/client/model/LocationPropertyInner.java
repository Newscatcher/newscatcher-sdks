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
public class LocationPropertyInner extends AbstractOpenApiSchema {
    private static final Logger log = Logger.getLogger(LocationPropertyInner.class.getName());

    public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
        @SuppressWarnings("unchecked")
        @Override
        public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
            if (!LocationPropertyInner.class.isAssignableFrom(type.getRawType())) {
                return null; // this class only serializes 'LocationPropertyInner' and its subtypes
            }
            final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
            final TypeAdapter<Integer> adapterInteger = gson.getDelegateAdapter(this, TypeToken.get(Integer.class));
            final TypeAdapter<String> adapterString = gson.getDelegateAdapter(this, TypeToken.get(String.class));

            return (TypeAdapter<T>) new TypeAdapter<LocationPropertyInner>() {
                @Override
                public void write(JsonWriter out, LocationPropertyInner value) throws IOException {
                    if (value == null || value.getActualInstance() == null) {
                        elementAdapter.write(out, null);
                        return;
                    }

                    // check if the actual instance is of the type `Integer`
                    if (value.getActualInstance() instanceof Integer) {
                        JsonObject obj = adapterInteger.toJsonTree((Integer)value.getActualInstance()).getAsJsonObject();
                        elementAdapter.write(out, obj);
                        return;
                    }

                    // check if the actual instance is of the type `String`
                    if (value.getActualInstance() instanceof String) {
                        JsonObject obj = adapterString.toJsonTree((String)value.getActualInstance()).getAsJsonObject();
                        elementAdapter.write(out, obj);
                        return;
                    }

                    throw new IOException("Failed to serialize as the type doesn't match anyOf schemas: Integer, String");
                }

                @Override
                public LocationPropertyInner read(JsonReader in) throws IOException {
                    Object deserialized = null;
                    JsonObject jsonObject = elementAdapter.read(in).getAsJsonObject();

                    // deserialize Integer
                    try {
                        // validate the JSON object to see if any exception is thrown
                        Integer.validateJsonObject(jsonObject);
                        log.log(Level.FINER, "Input data matches schema 'Integer'");
                        LocationPropertyInner ret = new LocationPropertyInner();
                        ret.setActualInstance(adapterInteger.fromJsonTree(jsonObject));
                        return ret;
                    } catch (Exception e) {
                        // deserialization failed, continue
                        log.log(Level.FINER, "Input data does not match schema 'Integer'", e);
                    }

                    // deserialize String
                    try {
                        // validate the JSON object to see if any exception is thrown
                        String.validateJsonObject(jsonObject);
                        log.log(Level.FINER, "Input data matches schema 'String'");
                        LocationPropertyInner ret = new LocationPropertyInner();
                        ret.setActualInstance(adapterString.fromJsonTree(jsonObject));
                        return ret;
                    } catch (Exception e) {
                        // deserialization failed, continue
                        log.log(Level.FINER, "Input data does not match schema 'String'", e);
                    }


                    throw new IOException(String.format("Failed deserialization for LocationPropertyInner: no class matched. JSON: %s", jsonObject.toString()));
                }
            }.nullSafe();
        }
    }

    // store a list of schema names defined in anyOf
    public static final Map<String, GenericType> schemas = new HashMap<String, GenericType>();

    public LocationPropertyInner() {
        super("anyOf", Boolean.FALSE);
    }

    public LocationPropertyInner(Integer o) {
        super("anyOf", Boolean.FALSE);
        setActualInstance(o);
    }

    public LocationPropertyInner(String o) {
        super("anyOf", Boolean.FALSE);
        setActualInstance(o);
    }

    static {
        schemas.put("Integer", new GenericType<Integer>() {
        });
        schemas.put("String", new GenericType<String>() {
        });
    }

    @Override
    public Map<String, GenericType> getSchemas() {
        return LocationPropertyInner.schemas;
    }

    /**
     * Set the instance that matches the anyOf child schema, check
     * the instance parameter is valid against the anyOf child schemas:
     * Integer, String
     *
     * It could be an instance of the 'anyOf' schemas.
     * The anyOf child schemas may themselves be a composed schema (allOf, anyOf, anyOf).
     */
    @Override
    public void setActualInstance(Object instance) {
        if (instance instanceof Integer) {
            super.setActualInstance(instance);
            return;
        }

        if (instance instanceof String) {
            super.setActualInstance(instance);
            return;
        }

        throw new RuntimeException("Invalid instance type. Must be Integer, String");
    }

    /**
     * Get the actual instance, which can be the following:
     * Integer, String
     *
     * @return The actual instance (Integer, String)
     */
    @Override
    public Object getActualInstance() {
        return super.getActualInstance();
    }

    /**
     * Get the actual instance of `Integer`. If the actual instance is not `Integer`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `Integer`
     * @throws ClassCastException if the instance is not `Integer`
     */
    public Integer getInteger() throws ClassCastException {
        return (Integer)super.getActualInstance();
    }

    /**
     * Get the actual instance of `String`. If the actual instance is not `String`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `String`
     * @throws ClassCastException if the instance is not `String`
     */
    public String getString() throws ClassCastException {
        return (String)super.getActualInstance();
    }


 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to LocationPropertyInner
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
    // validate anyOf schemas one by one
    int validCount = 0;
    // validate the json string with Integer
    try {
      Integer.validateJsonObject(jsonObj);
      return; // return earlier as at least one schema is valid with respect to the Json object
      //validCount++;
    } catch (Exception e) {
      // continue to the next one
    }
    // validate the json string with String
    try {
      String.validateJsonObject(jsonObj);
      return; // return earlier as at least one schema is valid with respect to the Json object
      //validCount++;
    } catch (Exception e) {
      // continue to the next one
    }
    if (validCount == 0) {
      throw new IOException(String.format("The JSON string is invalid for LocationPropertyInner with anyOf schemas: Integer, String. JSON: %s", jsonObj.toString()));
    }
  }

 /**
  * Create an instance of LocationPropertyInner given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of LocationPropertyInner
  * @throws IOException if the JSON string is invalid with respect to LocationPropertyInner
  */
  public static LocationPropertyInner fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, LocationPropertyInner.class);
  }

 /**
  * Convert an instance of LocationPropertyInner to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}


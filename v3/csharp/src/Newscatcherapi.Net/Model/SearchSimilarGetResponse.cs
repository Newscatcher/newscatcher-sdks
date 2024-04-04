/*
 * NewsCatcher-V3 Production API
 *
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>
 *
 * The version of the OpenAPI document: 3.2.16
 * Contact: maksym@newscatcherapi.com
 * Generated by: https://konfigthis.com
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Newscatcherapi.Net.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Newscatcherapi.Net.Model
{
    /// <summary>
    /// SearchSimilarGetResponse
    /// </summary>
    [JsonConverter(typeof(SearchSimilarGetResponseJsonConverter))]
    [DataContract(Name = "SearchSimilarGetResponse")]
    public partial class SearchSimilarGetResponse : AbstractOpenAPISchema, IEquatable<SearchSimilarGetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSimilarGetResponse" /> class
        /// with the <see cref="DtoResponsesMoreLikeThisResponseSearchResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DtoResponsesMoreLikeThisResponseSearchResponse.</param>
        public SearchSimilarGetResponse(DtoResponsesMoreLikeThisResponseSearchResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSimilarGetResponse" /> class
        /// with the <see cref="DtoResponsesMoreLikeThisResponseFailedSearchResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DtoResponsesMoreLikeThisResponseFailedSearchResponse.</param>
        public SearchSimilarGetResponse(DtoResponsesMoreLikeThisResponseFailedSearchResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(DtoResponsesMoreLikeThisResponseFailedSearchResponse))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DtoResponsesMoreLikeThisResponseSearchResponse))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: DtoResponsesMoreLikeThisResponseFailedSearchResponse, DtoResponsesMoreLikeThisResponseSearchResponse");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `DtoResponsesMoreLikeThisResponseSearchResponse`. If the actual instance is not `DtoResponsesMoreLikeThisResponseSearchResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DtoResponsesMoreLikeThisResponseSearchResponse</returns>
        public DtoResponsesMoreLikeThisResponseSearchResponse GetDtoResponsesMoreLikeThisResponseSearchResponse()
        {
            return (DtoResponsesMoreLikeThisResponseSearchResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DtoResponsesMoreLikeThisResponseFailedSearchResponse`. If the actual instance is not `DtoResponsesMoreLikeThisResponseFailedSearchResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DtoResponsesMoreLikeThisResponseFailedSearchResponse</returns>
        public DtoResponsesMoreLikeThisResponseFailedSearchResponse GetDtoResponsesMoreLikeThisResponseFailedSearchResponse()
        {
            return (DtoResponsesMoreLikeThisResponseFailedSearchResponse)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchSimilarGetResponse {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, SearchSimilarGetResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of SearchSimilarGetResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of SearchSimilarGetResponse</returns>
        public static SearchSimilarGetResponse FromJson(string jsonString)
        {
            SearchSimilarGetResponse newSearchSimilarGetResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newSearchSimilarGetResponse;
            }

            try
            {
                newSearchSimilarGetResponse = new SearchSimilarGetResponse(JsonConvert.DeserializeObject<DtoResponsesMoreLikeThisResponseFailedSearchResponse>(jsonString, SearchSimilarGetResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newSearchSimilarGetResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DtoResponsesMoreLikeThisResponseFailedSearchResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newSearchSimilarGetResponse = new SearchSimilarGetResponse(JsonConvert.DeserializeObject<DtoResponsesMoreLikeThisResponseSearchResponse>(jsonString, SearchSimilarGetResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newSearchSimilarGetResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DtoResponsesMoreLikeThisResponseSearchResponse: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchSimilarGetResponse);
        }

        /// <summary>
        /// Returns true if SearchSimilarGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchSimilarGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchSimilarGetResponse input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for SearchSimilarGetResponse
    /// </summary>
    public class SearchSimilarGetResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(SearchSimilarGetResponse).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return SearchSimilarGetResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }
}

/*
 * NewsCatcher-V3 Production API
 *
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a> <br> <p style=\"color: red\"><b><em> This is a Testing Phase API. Please use it for testing purposes only. </em></b></p> <br>
 *
 * The version of the OpenAPI document: Beta-3.0.0
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
    /// AuthorsGetResponse
    /// </summary>
    [JsonConverter(typeof(AuthorsGetResponseJsonConverter))]
    [DataContract(Name = "AuthorsGetResponse")]
    public partial class AuthorsGetResponse : AbstractOpenAPISchema, IEquatable<AuthorsGetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorsGetResponse" /> class
        /// with the <see cref="DtoResponsesAuthorSearchResponseSearchResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DtoResponsesAuthorSearchResponseSearchResponse.</param>
        public AuthorsGetResponse(DtoResponsesAuthorSearchResponseSearchResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorsGetResponse" /> class
        /// with the <see cref="DtoResponsesAuthorSearchResponseFailedSearchResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DtoResponsesAuthorSearchResponseFailedSearchResponse.</param>
        public AuthorsGetResponse(DtoResponsesAuthorSearchResponseFailedSearchResponse actualInstance)
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
                if (value.GetType() == typeof(DtoResponsesAuthorSearchResponseFailedSearchResponse))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DtoResponsesAuthorSearchResponseSearchResponse))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: DtoResponsesAuthorSearchResponseFailedSearchResponse, DtoResponsesAuthorSearchResponseSearchResponse");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `DtoResponsesAuthorSearchResponseSearchResponse`. If the actual instance is not `DtoResponsesAuthorSearchResponseSearchResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DtoResponsesAuthorSearchResponseSearchResponse</returns>
        public DtoResponsesAuthorSearchResponseSearchResponse GetDtoResponsesAuthorSearchResponseSearchResponse()
        {
            return (DtoResponsesAuthorSearchResponseSearchResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DtoResponsesAuthorSearchResponseFailedSearchResponse`. If the actual instance is not `DtoResponsesAuthorSearchResponseFailedSearchResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DtoResponsesAuthorSearchResponseFailedSearchResponse</returns>
        public DtoResponsesAuthorSearchResponseFailedSearchResponse GetDtoResponsesAuthorSearchResponseFailedSearchResponse()
        {
            return (DtoResponsesAuthorSearchResponseFailedSearchResponse)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorsGetResponse {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AuthorsGetResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AuthorsGetResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AuthorsGetResponse</returns>
        public static AuthorsGetResponse FromJson(string jsonString)
        {
            AuthorsGetResponse newAuthorsGetResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAuthorsGetResponse;
            }

            try
            {
                newAuthorsGetResponse = new AuthorsGetResponse(JsonConvert.DeserializeObject<DtoResponsesAuthorSearchResponseFailedSearchResponse>(jsonString, AuthorsGetResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAuthorsGetResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DtoResponsesAuthorSearchResponseFailedSearchResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newAuthorsGetResponse = new AuthorsGetResponse(JsonConvert.DeserializeObject<DtoResponsesAuthorSearchResponseSearchResponse>(jsonString, AuthorsGetResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAuthorsGetResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DtoResponsesAuthorSearchResponseSearchResponse: {1}", jsonString, exception.ToString()));
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
            return this.Equals(input as AuthorsGetResponse);
        }

        /// <summary>
        /// Returns true if AuthorsGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorsGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorsGetResponse input)
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
    /// Custom JSON converter for AuthorsGetResponse
    /// </summary>
    public class AuthorsGetResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AuthorsGetResponse).GetMethod("ToJson").Invoke(value, null)));
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
                return AuthorsGetResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
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

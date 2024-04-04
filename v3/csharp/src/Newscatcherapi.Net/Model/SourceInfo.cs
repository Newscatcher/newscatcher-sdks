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

namespace Newscatcherapi.Net.Model
{
    /// <summary>
    /// SourceInfo
    /// </summary>
    [DataContract(Name = "SourceInfo")]
    public partial class SourceInfo : IEquatable<SourceInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SourceInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceInfo" /> class.
        /// </summary>
        /// <param name="nameSource">nameSource.</param>
        /// <param name="domainUrl">domainUrl (required).</param>
        /// <param name="logo">logo.</param>
        /// <param name="additionalInfo">additionalInfo.</param>
        public SourceInfo(string nameSource = default(string), string domainUrl = default(string), string logo = default(string), AdditionalSourceInfo additionalInfo = default(AdditionalSourceInfo))
        {
            // to ensure "domainUrl" is required (not null)
            if (domainUrl == null)
            {
                throw new ArgumentNullException("domainUrl is a required property for SourceInfo and cannot be null");
            }
            this.DomainUrl = domainUrl;
            this.NameSource = nameSource;
            this.Logo = logo;
            this.AdditionalInfo = additionalInfo;
        }

        /// <summary>
        /// Gets or Sets NameSource
        /// </summary>
        [DataMember(Name = "name_source", EmitDefaultValue = false)]
        public string NameSource { get; set; }

        /// <summary>
        /// Gets or Sets DomainUrl
        /// </summary>
        [DataMember(Name = "domain_url", IsRequired = true, EmitDefaultValue = true)]
        public string DomainUrl { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalInfo
        /// </summary>
        [DataMember(Name = "additional_info", EmitDefaultValue = false)]
        public AdditionalSourceInfo AdditionalInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SourceInfo {\n");
            sb.Append("  NameSource: ").Append(NameSource).Append("\n");
            sb.Append("  DomainUrl: ").Append(DomainUrl).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SourceInfo);
        }

        /// <summary>
        /// Returns true if SourceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NameSource == input.NameSource ||
                    (this.NameSource != null &&
                    this.NameSource.Equals(input.NameSource))
                ) && 
                (
                    this.DomainUrl == input.DomainUrl ||
                    (this.DomainUrl != null &&
                    this.DomainUrl.Equals(input.DomainUrl))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.AdditionalInfo == input.AdditionalInfo ||
                    (this.AdditionalInfo != null &&
                    this.AdditionalInfo.Equals(input.AdditionalInfo))
                );
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
                if (this.NameSource != null)
                {
                    hashCode = (hashCode * 59) + this.NameSource.GetHashCode();
                }
                if (this.DomainUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DomainUrl.GetHashCode();
                }
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
                }
                if (this.AdditionalInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalInfo.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

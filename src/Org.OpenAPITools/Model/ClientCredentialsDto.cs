/*
 * Earthpoints API
 *
 * Earthpoints API description
 *
 * The version of the OpenAPI document: 0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ClientCredentialsDto
    /// </summary>
    [DataContract(Name = "ClientCredentialsDto")]
    public partial class ClientCredentialsDto : IEquatable<ClientCredentialsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCredentialsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientCredentialsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCredentialsDto" /> class.
        /// </summary>
        /// <param name="clientId">clientId (required).</param>
        /// <param name="clientSecret">clientSecret (required).</param>
        public ClientCredentialsDto(string clientId = default(string), string clientSecret = default(string))
        {
            // to ensure "clientId" is required (not null)
            if (clientId == null) {
                throw new ArgumentNullException("clientId is a required property for ClientCredentialsDto and cannot be null");
            }
            this.ClientId = clientId;
            // to ensure "clientSecret" is required (not null)
            if (clientSecret == null) {
                throw new ArgumentNullException("clientSecret is a required property for ClientCredentialsDto and cannot be null");
            }
            this.ClientSecret = clientSecret;
        }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name = "client_id", IsRequired = true, EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        [DataMember(Name = "client_secret", IsRequired = true, EmitDefaultValue = false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientCredentialsDto {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
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
            return this.Equals(input as ClientCredentialsDto);
        }

        /// <summary>
        /// Returns true if ClientCredentialsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientCredentialsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientCredentialsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
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
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.ClientSecret != null)
                {
                    hashCode = (hashCode * 59) + this.ClientSecret.GetHashCode();
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

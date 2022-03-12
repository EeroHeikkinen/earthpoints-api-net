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
    /// CreateUserDto
    /// </summary>
    [DataContract(Name = "CreateUserDto")]
    public partial class CreateUserDto : IEquatable<CreateUserDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUserDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserDto" /> class.
        /// </summary>
        /// <param name="userid">userid (required).</param>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="email">email (required).</param>
        /// <param name="emails">emails (required).</param>
        /// <param name="timezone">timezone (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        public CreateUserDto(string userid = default(string), string firstName = default(string), string email = default(string), List<string> emails = default(List<string>), string timezone = default(string), DateTime createdAt = default(DateTime))
        {
            // to ensure "userid" is required (not null)
            if (userid == null) {
                throw new ArgumentNullException("userid is a required property for CreateUserDto and cannot be null");
            }
            this.Userid = userid;
            // to ensure "firstName" is required (not null)
            if (firstName == null) {
                throw new ArgumentNullException("firstName is a required property for CreateUserDto and cannot be null");
            }
            this.FirstName = firstName;
            // to ensure "email" is required (not null)
            if (email == null) {
                throw new ArgumentNullException("email is a required property for CreateUserDto and cannot be null");
            }
            this.Email = email;
            // to ensure "emails" is required (not null)
            if (emails == null) {
                throw new ArgumentNullException("emails is a required property for CreateUserDto and cannot be null");
            }
            this.Emails = emails;
            // to ensure "timezone" is required (not null)
            if (timezone == null) {
                throw new ArgumentNullException("timezone is a required property for CreateUserDto and cannot be null");
            }
            this.Timezone = timezone;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or Sets Userid
        /// </summary>
        [DataMember(Name = "userid", IsRequired = true, EmitDefaultValue = false)]
        public string Userid { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name = "emails", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name = "timezone", IsRequired = true, EmitDefaultValue = false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateUserDto {\n");
            sb.Append("  Userid: ").Append(Userid).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as CreateUserDto);
        }

        /// <summary>
        /// Returns true if CreateUserDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUserDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Userid == input.Userid ||
                    (this.Userid != null &&
                    this.Userid.Equals(input.Userid))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Userid != null)
                {
                    hashCode = (hashCode * 59) + this.Userid.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Emails != null)
                {
                    hashCode = (hashCode * 59) + this.Emails.GetHashCode();
                }
                if (this.Timezone != null)
                {
                    hashCode = (hashCode * 59) + this.Timezone.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
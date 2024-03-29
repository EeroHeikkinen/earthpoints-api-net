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
    /// CreatePlatformConnectionDto
    /// </summary>
    [DataContract(Name = "CreatePlatformConnectionDto")]
    public partial class CreatePlatformConnectionDto : IEquatable<CreatePlatformConnectionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlatformConnectionDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePlatformConnectionDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlatformConnectionDto" /> class.
        /// </summary>
        /// <param name="userid">userid.</param>
        /// <param name="profileId">profileId (required).</param>
        /// <param name="platform">platform (required).</param>
        /// <param name="emails">emails.</param>
        /// <param name="authToken">authToken.</param>
        /// <param name="tokenSecret">tokenSecret.</param>
        /// <param name="authExpiration">authExpiration.</param>
        public CreatePlatformConnectionDto(string userid = default(string), string profileId = default(string), string platform = default(string), List<string> emails = default(List<string>), string authToken = default(string), string tokenSecret = default(string), DateTime authExpiration = default(DateTime))
        {
            // to ensure "profileId" is required (not null)
            if (profileId == null) {
                throw new ArgumentNullException("profileId is a required property for CreatePlatformConnectionDto and cannot be null");
            }
            this.ProfileId = profileId;
            // to ensure "platform" is required (not null)
            if (platform == null) {
                throw new ArgumentNullException("platform is a required property for CreatePlatformConnectionDto and cannot be null");
            }
            this.Platform = platform;
            this.Userid = userid;
            this.Emails = emails;
            this.AuthToken = authToken;
            this.TokenSecret = tokenSecret;
            this.AuthExpiration = authExpiration;
        }

        /// <summary>
        /// Gets or Sets Userid
        /// </summary>
        [DataMember(Name = "userid", EmitDefaultValue = false)]
        public string Userid { get; set; }

        /// <summary>
        /// Gets or Sets ProfileId
        /// </summary>
        [DataMember(Name = "profile_id", IsRequired = true, EmitDefaultValue = false)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = false)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name = "emails", EmitDefaultValue = false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Gets or Sets AuthToken
        /// </summary>
        [DataMember(Name = "auth_token", EmitDefaultValue = false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// Gets or Sets TokenSecret
        /// </summary>
        [DataMember(Name = "token_secret", EmitDefaultValue = false)]
        public string TokenSecret { get; set; }

        /// <summary>
        /// Gets or Sets AuthExpiration
        /// </summary>
        [DataMember(Name = "auth_expiration", EmitDefaultValue = false)]
        public DateTime AuthExpiration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreatePlatformConnectionDto {\n");
            sb.Append("  Userid: ").Append(Userid).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
            sb.Append("  TokenSecret: ").Append(TokenSecret).Append("\n");
            sb.Append("  AuthExpiration: ").Append(AuthExpiration).Append("\n");
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
            return this.Equals(input as CreatePlatformConnectionDto);
        }

        /// <summary>
        /// Returns true if CreatePlatformConnectionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePlatformConnectionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePlatformConnectionDto input)
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
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.AuthToken == input.AuthToken ||
                    (this.AuthToken != null &&
                    this.AuthToken.Equals(input.AuthToken))
                ) && 
                (
                    this.TokenSecret == input.TokenSecret ||
                    (this.TokenSecret != null &&
                    this.TokenSecret.Equals(input.TokenSecret))
                ) && 
                (
                    this.AuthExpiration == input.AuthExpiration ||
                    (this.AuthExpiration != null &&
                    this.AuthExpiration.Equals(input.AuthExpiration))
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
                if (this.ProfileId != null)
                {
                    hashCode = (hashCode * 59) + this.ProfileId.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.Emails != null)
                {
                    hashCode = (hashCode * 59) + this.Emails.GetHashCode();
                }
                if (this.AuthToken != null)
                {
                    hashCode = (hashCode * 59) + this.AuthToken.GetHashCode();
                }
                if (this.TokenSecret != null)
                {
                    hashCode = (hashCode * 59) + this.TokenSecret.GetHashCode();
                }
                if (this.AuthExpiration != null)
                {
                    hashCode = (hashCode * 59) + this.AuthExpiration.GetHashCode();
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

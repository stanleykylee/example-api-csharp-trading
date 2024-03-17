/* 
 * Tradovate API
 *
 * # Getting Started With the Tradovate API The Tradovate API is a robust web interface that clients can utilize to bring our Trading services to their own applications and  extensions. There are a number of supported operations that a client can perform by accessing the REST API. Essentially any functionality that is available on the Tradovate Trader application is also exposed via the API. For the comprehensive JavaScript guide to using our API, please go [here](https://github.com/tradovate/example-api-js/).  ## Place and Modify Orders The Tradovate REST API makes it easy to place and modify orders from code. Any type of order supported by the Tradovate Trader application is also able to be placed via the REST API. For interactive examples see the [Orders](#tag/Orders) section.  ## Query Positions, Contracts, Maturities and More From the Tradovate REST API we can get data about positions, contracts, products, prices, currencies, maturities, and more. Any data that you could view by browsing Tradovate Trader is queryable from the API. For interactive examples see the [ContractLibrary](#tag/ContractLibrary) section.  ## Query Account Data Using our `/account/_*` operations allow you to do things like find an account by its ID, get a snapshot of an account's current cash balance, and access account trading permissions. For interactive examples see the [Accounting](#tag/Accounting) section.  ## Manage Risk We can use all of the risk management features available on Tradovate Trader from the API. This includes setting position limits and creating, deleting, and modifying risk-parameters. For live examples, see the [Risk](#tag/Risks) section.  ## Access Alert and Live Chat Functions You can use the REST API to generate alerts which can be seen from the Tradovate Trader application. You can use all of the Chat functionality from from  the REST API. This includes opening and closing the chat context, querying and posting chat message items, and even allowing us to mark a chat item as 'read'. For more examples see the [Alerts](#tag/Alerts) and [Chat](#tag/Chat) sections.  ## How Do I Use the Tradovate REST API? In order to access the features of the Tradovate REST API you'll need to sign up for a [Tradovate Trader](https://trader.tradovate.com/welcome) account. You must meet some other requirements as well: - You need a LIVE account with more than $1000 in equity. - You need a subscription to API Access. - You'll need to generate an API Key.  Then you simply need to acquire an access token using your API Key, as described in the [Access](#tag/Access) section. 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Tradovate.Services.Client.SwaggerDateConverter;
namespace Tradovate.Services.Model
{
    /// <summary>
    /// TradingPermission
    /// </summary>
    [DataContract]
        public partial class TradingPermission :  IEquatable<TradingPermission>, IValidatableObject
    {
        /// <summary>
        /// Accepted, Approved, Declined, Requested, Revoked
        /// </summary>
        /// <value>Accepted, Approved, Declined, Requested, Revoked</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Accepted for value: Accepted
            /// </summary>
            [EnumMember(Value = "Accepted")]
            Accepted = 1,
            /// <summary>
            /// Enum Approved for value: Approved
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved = 2,
            /// <summary>
            /// Enum Declined for value: Declined
            /// </summary>
            [EnumMember(Value = "Declined")]
            Declined = 3,
            /// <summary>
            /// Enum Requested for value: Requested
            /// </summary>
            [EnumMember(Value = "Requested")]
            Requested = 4,
            /// <summary>
            /// Enum Revoked for value: Revoked
            /// </summary>
            [EnumMember(Value = "Revoked")]
            Revoked = 5        }
        /// <summary>
        /// Accepted, Approved, Declined, Requested, Revoked
        /// </summary>
        /// <value>Accepted, Approved, Declined, Requested, Revoked</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TradingPermission" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="accountId">accountId (required).</param>
        /// <param name="accountHolderContact">accountHolderContact (required).</param>
        /// <param name="accountHolderEmail">accountHolderEmail (required).</param>
        /// <param name="ctaContact">ctaContact (required).</param>
        /// <param name="ctaEmail">ctaEmail (required).</param>
        /// <param name="status">Accepted, Approved, Declined, Requested, Revoked (required).</param>
        /// <param name="updated">updated.</param>
        /// <param name="approvedById">approvedById.</param>
        public TradingPermission(long? id = default(long?), long? userId = default(long?), long? accountId = default(long?), string accountHolderContact = default(string), string accountHolderEmail = default(string), string ctaContact = default(string), string ctaEmail = default(string), StatusEnum status = default(StatusEnum), DateTime? updated = default(DateTime?), long? approvedById = default(long?))
        {
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for TradingPermission and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for TradingPermission and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            // to ensure "accountHolderContact" is required (not null)
            if (accountHolderContact == null)
            {
                throw new InvalidDataException("accountHolderContact is a required property for TradingPermission and cannot be null");
            }
            else
            {
                this.AccountHolderContact = accountHolderContact;
            }
            // to ensure "accountHolderEmail" is required (not null)
            if (accountHolderEmail == null)
            {
                throw new InvalidDataException("accountHolderEmail is a required property for TradingPermission and cannot be null");
            }
            else
            {
                this.AccountHolderEmail = accountHolderEmail;
            }
            // to ensure "ctaContact" is required (not null)
            if (ctaContact == null)
            {
                throw new InvalidDataException("ctaContact is a required property for TradingPermission and cannot be null");
            }
            else
            {
                this.CtaContact = ctaContact;
            }
            // to ensure "ctaEmail" is required (not null)
            if (ctaEmail == null)
            {
                throw new InvalidDataException("ctaEmail is a required property for TradingPermission and cannot be null");
            }
            else
            {
                this.CtaEmail = ctaEmail;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for TradingPermission and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.Id = id;
            this.Updated = updated;
            this.ApprovedById = approvedById;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets AccountHolderContact
        /// </summary>
        [DataMember(Name="accountHolderContact", EmitDefaultValue=false)]
        public string AccountHolderContact { get; set; }

        /// <summary>
        /// Gets or Sets AccountHolderEmail
        /// </summary>
        [DataMember(Name="accountHolderEmail", EmitDefaultValue=false)]
        public string AccountHolderEmail { get; set; }

        /// <summary>
        /// Gets or Sets CtaContact
        /// </summary>
        [DataMember(Name="ctaContact", EmitDefaultValue=false)]
        public string CtaContact { get; set; }

        /// <summary>
        /// Gets or Sets CtaEmail
        /// </summary>
        [DataMember(Name="ctaEmail", EmitDefaultValue=false)]
        public string CtaEmail { get; set; }


        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Gets or Sets ApprovedById
        /// </summary>
        [DataMember(Name="approvedById", EmitDefaultValue=false)]
        public long? ApprovedById { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TradingPermission {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountHolderContact: ").Append(AccountHolderContact).Append("\n");
            sb.Append("  AccountHolderEmail: ").Append(AccountHolderEmail).Append("\n");
            sb.Append("  CtaContact: ").Append(CtaContact).Append("\n");
            sb.Append("  CtaEmail: ").Append(CtaEmail).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  ApprovedById: ").Append(ApprovedById).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TradingPermission);
        }

        /// <summary>
        /// Returns true if TradingPermission instances are equal
        /// </summary>
        /// <param name="input">Instance of TradingPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradingPermission input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AccountHolderContact == input.AccountHolderContact ||
                    (this.AccountHolderContact != null &&
                    this.AccountHolderContact.Equals(input.AccountHolderContact))
                ) && 
                (
                    this.AccountHolderEmail == input.AccountHolderEmail ||
                    (this.AccountHolderEmail != null &&
                    this.AccountHolderEmail.Equals(input.AccountHolderEmail))
                ) && 
                (
                    this.CtaContact == input.CtaContact ||
                    (this.CtaContact != null &&
                    this.CtaContact.Equals(input.CtaContact))
                ) && 
                (
                    this.CtaEmail == input.CtaEmail ||
                    (this.CtaEmail != null &&
                    this.CtaEmail.Equals(input.CtaEmail))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.ApprovedById == input.ApprovedById ||
                    (this.ApprovedById != null &&
                    this.ApprovedById.Equals(input.ApprovedById))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AccountHolderContact != null)
                    hashCode = hashCode * 59 + this.AccountHolderContact.GetHashCode();
                if (this.AccountHolderEmail != null)
                    hashCode = hashCode * 59 + this.AccountHolderEmail.GetHashCode();
                if (this.CtaContact != null)
                    hashCode = hashCode * 59 + this.CtaContact.GetHashCode();
                if (this.CtaEmail != null)
                    hashCode = hashCode * 59 + this.CtaEmail.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.ApprovedById != null)
                    hashCode = hashCode * 59 + this.ApprovedById.GetHashCode();
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
}

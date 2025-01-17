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
    /// Alert
    /// </summary>
    [DataContract]
        public partial class Alert :  IEquatable<Alert>, IValidatableObject
    {
        /// <summary>
        /// Active, Expired, Failed, Inactive, TriggeredOut
        /// </summary>
        /// <value>Active, Expired, Failed, Inactive, TriggeredOut</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 1,
            /// <summary>
            /// Enum Expired for value: Expired
            /// </summary>
            [EnumMember(Value = "Expired")]
            Expired = 2,
            /// <summary>
            /// Enum Failed for value: Failed
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed = 3,
            /// <summary>
            /// Enum Inactive for value: Inactive
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive = 4,
            /// <summary>
            /// Enum TriggeredOut for value: TriggeredOut
            /// </summary>
            [EnumMember(Value = "TriggeredOut")]
            TriggeredOut = 5        }
        /// <summary>
        /// Active, Expired, Failed, Inactive, TriggeredOut
        /// </summary>
        /// <value>Active, Expired, Failed, Inactive, TriggeredOut</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Alert" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="status">Active, Expired, Failed, Inactive, TriggeredOut (required).</param>
        /// <param name="expression">expression (required).</param>
        /// <param name="validUntil">validUntil.</param>
        /// <param name="triggerLimits">triggerLimits.</param>
        /// <param name="triggeredCounter">triggeredCounter.</param>
        /// <param name="failure">failure.</param>
        /// <param name="message">message.</param>
        public Alert(long? id = default(long?), DateTime? timestamp = default(DateTime?), long? userId = default(long?), StatusEnum status = default(StatusEnum), string expression = default(string), DateTime? validUntil = default(DateTime?), int? triggerLimits = default(int?), int? triggeredCounter = default(int?), string failure = default(string), string message = default(string))
        {
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for Alert and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for Alert and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for Alert and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "expression" is required (not null)
            if (expression == null)
            {
                throw new InvalidDataException("expression is a required property for Alert and cannot be null");
            }
            else
            {
                this.Expression = expression;
            }
            this.Id = id;
            this.ValidUntil = validUntil;
            this.TriggerLimits = triggerLimits;
            this.TriggeredCounter = triggeredCounter;
            this.Failure = failure;
            this.Message = message;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public long? UserId { get; set; }


        /// <summary>
        /// Gets or Sets Expression
        /// </summary>
        [DataMember(Name="expression", EmitDefaultValue=false)]
        public string Expression { get; set; }

        /// <summary>
        /// Gets or Sets ValidUntil
        /// </summary>
        [DataMember(Name="validUntil", EmitDefaultValue=false)]
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// Gets or Sets TriggerLimits
        /// </summary>
        [DataMember(Name="triggerLimits", EmitDefaultValue=false)]
        public int? TriggerLimits { get; set; }

        /// <summary>
        /// Gets or Sets TriggeredCounter
        /// </summary>
        [DataMember(Name="triggeredCounter", EmitDefaultValue=false)]
        public int? TriggeredCounter { get; set; }

        /// <summary>
        /// Gets or Sets Failure
        /// </summary>
        [DataMember(Name="failure", EmitDefaultValue=false)]
        public string Failure { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Alert {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
            sb.Append("  TriggerLimits: ").Append(TriggerLimits).Append("\n");
            sb.Append("  TriggeredCounter: ").Append(TriggeredCounter).Append("\n");
            sb.Append("  Failure: ").Append(Failure).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as Alert);
        }

        /// <summary>
        /// Returns true if Alert instances are equal
        /// </summary>
        /// <param name="input">Instance of Alert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Alert input)
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
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Expression == input.Expression ||
                    (this.Expression != null &&
                    this.Expression.Equals(input.Expression))
                ) && 
                (
                    this.ValidUntil == input.ValidUntil ||
                    (this.ValidUntil != null &&
                    this.ValidUntil.Equals(input.ValidUntil))
                ) && 
                (
                    this.TriggerLimits == input.TriggerLimits ||
                    (this.TriggerLimits != null &&
                    this.TriggerLimits.Equals(input.TriggerLimits))
                ) && 
                (
                    this.TriggeredCounter == input.TriggeredCounter ||
                    (this.TriggeredCounter != null &&
                    this.TriggeredCounter.Equals(input.TriggeredCounter))
                ) && 
                (
                    this.Failure == input.Failure ||
                    (this.Failure != null &&
                    this.Failure.Equals(input.Failure))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Expression != null)
                    hashCode = hashCode * 59 + this.Expression.GetHashCode();
                if (this.ValidUntil != null)
                    hashCode = hashCode * 59 + this.ValidUntil.GetHashCode();
                if (this.TriggerLimits != null)
                    hashCode = hashCode * 59 + this.TriggerLimits.GetHashCode();
                if (this.TriggeredCounter != null)
                    hashCode = hashCode * 59 + this.TriggeredCounter.GetHashCode();
                if (this.Failure != null)
                    hashCode = hashCode * 59 + this.Failure.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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

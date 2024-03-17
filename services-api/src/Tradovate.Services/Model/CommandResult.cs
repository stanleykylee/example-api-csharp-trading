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
    /// CommandResult
    /// </summary>
    [DataContract]
        public partial class CommandResult :  IEquatable<CommandResult>, IValidatableObject
    {
        /// <summary>
        /// AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported
        /// </summary>
        /// <value>AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FailureReasonEnum
        {
            /// <summary>
            /// Enum AccountClosed for value: AccountClosed
            /// </summary>
            [EnumMember(Value = "AccountClosed")]
            AccountClosed = 1,
            /// <summary>
            /// Enum AdvancedTrailingStopUnsupported for value: AdvancedTrailingStopUnsupported
            /// </summary>
            [EnumMember(Value = "AdvancedTrailingStopUnsupported")]
            AdvancedTrailingStopUnsupported = 2,
            /// <summary>
            /// Enum AnotherCommandPending for value: AnotherCommandPending
            /// </summary>
            [EnumMember(Value = "AnotherCommandPending")]
            AnotherCommandPending = 3,
            /// <summary>
            /// Enum BackMonthProhibited for value: BackMonthProhibited
            /// </summary>
            [EnumMember(Value = "BackMonthProhibited")]
            BackMonthProhibited = 4,
            /// <summary>
            /// Enum ExecutionProviderNotConfigured for value: ExecutionProviderNotConfigured
            /// </summary>
            [EnumMember(Value = "ExecutionProviderNotConfigured")]
            ExecutionProviderNotConfigured = 5,
            /// <summary>
            /// Enum ExecutionProviderUnavailable for value: ExecutionProviderUnavailable
            /// </summary>
            [EnumMember(Value = "ExecutionProviderUnavailable")]
            ExecutionProviderUnavailable = 6,
            /// <summary>
            /// Enum InvalidContract for value: InvalidContract
            /// </summary>
            [EnumMember(Value = "InvalidContract")]
            InvalidContract = 7,
            /// <summary>
            /// Enum InvalidPrice for value: InvalidPrice
            /// </summary>
            [EnumMember(Value = "InvalidPrice")]
            InvalidPrice = 8,
            /// <summary>
            /// Enum LiquidationOnly for value: LiquidationOnly
            /// </summary>
            [EnumMember(Value = "LiquidationOnly")]
            LiquidationOnly = 9,
            /// <summary>
            /// Enum LiquidationOnlyBeforeExpiration for value: LiquidationOnlyBeforeExpiration
            /// </summary>
            [EnumMember(Value = "LiquidationOnlyBeforeExpiration")]
            LiquidationOnlyBeforeExpiration = 10,
            /// <summary>
            /// Enum MaxOrderQtyIsNotSpecified for value: MaxOrderQtyIsNotSpecified
            /// </summary>
            [EnumMember(Value = "MaxOrderQtyIsNotSpecified")]
            MaxOrderQtyIsNotSpecified = 11,
            /// <summary>
            /// Enum MaxOrderQtyLimitReached for value: MaxOrderQtyLimitReached
            /// </summary>
            [EnumMember(Value = "MaxOrderQtyLimitReached")]
            MaxOrderQtyLimitReached = 12,
            /// <summary>
            /// Enum MaxPosLimitMisconfigured for value: MaxPosLimitMisconfigured
            /// </summary>
            [EnumMember(Value = "MaxPosLimitMisconfigured")]
            MaxPosLimitMisconfigured = 13,
            /// <summary>
            /// Enum MaxPosLimitReached for value: MaxPosLimitReached
            /// </summary>
            [EnumMember(Value = "MaxPosLimitReached")]
            MaxPosLimitReached = 14,
            /// <summary>
            /// Enum MaxTotalPosLimitReached for value: MaxTotalPosLimitReached
            /// </summary>
            [EnumMember(Value = "MaxTotalPosLimitReached")]
            MaxTotalPosLimitReached = 15,
            /// <summary>
            /// Enum MultipleAccountPlanRequired for value: MultipleAccountPlanRequired
            /// </summary>
            [EnumMember(Value = "MultipleAccountPlanRequired")]
            MultipleAccountPlanRequired = 16,
            /// <summary>
            /// Enum NoQuote for value: NoQuote
            /// </summary>
            [EnumMember(Value = "NoQuote")]
            NoQuote = 17,
            /// <summary>
            /// Enum NotEnoughLiquidity for value: NotEnoughLiquidity
            /// </summary>
            [EnumMember(Value = "NotEnoughLiquidity")]
            NotEnoughLiquidity = 18,
            /// <summary>
            /// Enum OtherExecutionRelated for value: OtherExecutionRelated
            /// </summary>
            [EnumMember(Value = "OtherExecutionRelated")]
            OtherExecutionRelated = 19,
            /// <summary>
            /// Enum ParentRejected for value: ParentRejected
            /// </summary>
            [EnumMember(Value = "ParentRejected")]
            ParentRejected = 20,
            /// <summary>
            /// Enum RiskCheckTimeout for value: RiskCheckTimeout
            /// </summary>
            [EnumMember(Value = "RiskCheckTimeout")]
            RiskCheckTimeout = 21,
            /// <summary>
            /// Enum SessionClosed for value: SessionClosed
            /// </summary>
            [EnumMember(Value = "SessionClosed")]
            SessionClosed = 22,
            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 23,
            /// <summary>
            /// Enum TooLate for value: TooLate
            /// </summary>
            [EnumMember(Value = "TooLate")]
            TooLate = 24,
            /// <summary>
            /// Enum TradingLocked for value: TradingLocked
            /// </summary>
            [EnumMember(Value = "TradingLocked")]
            TradingLocked = 25,
            /// <summary>
            /// Enum TrailingStopNonOrderQtyModify for value: TrailingStopNonOrderQtyModify
            /// </summary>
            [EnumMember(Value = "TrailingStopNonOrderQtyModify")]
            TrailingStopNonOrderQtyModify = 26,
            /// <summary>
            /// Enum Unauthorized for value: Unauthorized
            /// </summary>
            [EnumMember(Value = "Unauthorized")]
            Unauthorized = 27,
            /// <summary>
            /// Enum UnknownReason for value: UnknownReason
            /// </summary>
            [EnumMember(Value = "UnknownReason")]
            UnknownReason = 28,
            /// <summary>
            /// Enum Unsupported for value: Unsupported
            /// </summary>
            [EnumMember(Value = "Unsupported")]
            Unsupported = 29        }
        /// <summary>
        /// AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported
        /// </summary>
        /// <value>AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReasonEnum? FailureReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommandResult" /> class.
        /// </summary>
        /// <param name="failureReason">AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported.</param>
        /// <param name="failureText">failureText.</param>
        /// <param name="commandId">commandId.</param>
        public CommandResult(FailureReasonEnum? failureReason = default(FailureReasonEnum?), string failureText = default(string), long? commandId = default(long?))
        {
            this.FailureReason = failureReason;
            this.FailureText = failureText;
            this.CommandId = commandId;
        }
        

        /// <summary>
        /// Gets or Sets FailureText
        /// </summary>
        [DataMember(Name="failureText", EmitDefaultValue=false)]
        public string FailureText { get; set; }

        /// <summary>
        /// Gets or Sets CommandId
        /// </summary>
        [DataMember(Name="commandId", EmitDefaultValue=false)]
        public long? CommandId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommandResult {\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  FailureText: ").Append(FailureText).Append("\n");
            sb.Append("  CommandId: ").Append(CommandId).Append("\n");
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
            return this.Equals(input as CommandResult);
        }

        /// <summary>
        /// Returns true if CommandResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CommandResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommandResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FailureReason == input.FailureReason ||
                    (this.FailureReason != null &&
                    this.FailureReason.Equals(input.FailureReason))
                ) && 
                (
                    this.FailureText == input.FailureText ||
                    (this.FailureText != null &&
                    this.FailureText.Equals(input.FailureText))
                ) && 
                (
                    this.CommandId == input.CommandId ||
                    (this.CommandId != null &&
                    this.CommandId.Equals(input.CommandId))
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
                if (this.FailureReason != null)
                    hashCode = hashCode * 59 + this.FailureReason.GetHashCode();
                if (this.FailureText != null)
                    hashCode = hashCode * 59 + this.FailureText.GetHashCode();
                if (this.CommandId != null)
                    hashCode = hashCode * 59 + this.CommandId.GetHashCode();
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

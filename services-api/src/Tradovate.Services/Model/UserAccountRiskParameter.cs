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
    /// UserAccountRiskParameter
    /// </summary>
    [DataContract]
        public partial class UserAccountRiskParameter :  IEquatable<UserAccountRiskParameter>, IValidatableObject
    {
        /// <summary>
        /// CommonStock, Continuous, Cryptocurrency, Futures, MarketInternals, Options, Spread
        /// </summary>
        /// <value>CommonStock, Continuous, Cryptocurrency, Futures, MarketInternals, Options, Spread</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ProductTypeEnum
        {
            /// <summary>
            /// Enum CommonStock for value: CommonStock
            /// </summary>
            [EnumMember(Value = "CommonStock")]
            CommonStock = 1,
            /// <summary>
            /// Enum Continuous for value: Continuous
            /// </summary>
            [EnumMember(Value = "Continuous")]
            Continuous = 2,
            /// <summary>
            /// Enum Cryptocurrency for value: Cryptocurrency
            /// </summary>
            [EnumMember(Value = "Cryptocurrency")]
            Cryptocurrency = 3,
            /// <summary>
            /// Enum Futures for value: Futures
            /// </summary>
            [EnumMember(Value = "Futures")]
            Futures = 4,
            /// <summary>
            /// Enum MarketInternals for value: MarketInternals
            /// </summary>
            [EnumMember(Value = "MarketInternals")]
            MarketInternals = 5,
            /// <summary>
            /// Enum Options for value: Options
            /// </summary>
            [EnumMember(Value = "Options")]
            Options = 6,
            /// <summary>
            /// Enum Spread for value: Spread
            /// </summary>
            [EnumMember(Value = "Spread")]
            Spread = 7        }
        /// <summary>
        /// CommonStock, Continuous, Cryptocurrency, Futures, MarketInternals, Options, Spread
        /// </summary>
        /// <value>CommonStock, Continuous, Cryptocurrency, Futures, MarketInternals, Options, Spread</value>
        [DataMember(Name="productType", EmitDefaultValue=false)]
        public ProductTypeEnum? ProductType { get; set; }
        /// <summary>
        /// Inactive, Locked, ReadyForContracts, ReadyToTrade, Verified
        /// </summary>
        /// <value>Inactive, Locked, ReadyForContracts, ReadyToTrade, Verified</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ProductVerificationStatusEnum
        {
            /// <summary>
            /// Enum Inactive for value: Inactive
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive = 1,
            /// <summary>
            /// Enum Locked for value: Locked
            /// </summary>
            [EnumMember(Value = "Locked")]
            Locked = 2,
            /// <summary>
            /// Enum ReadyForContracts for value: ReadyForContracts
            /// </summary>
            [EnumMember(Value = "ReadyForContracts")]
            ReadyForContracts = 3,
            /// <summary>
            /// Enum ReadyToTrade for value: ReadyToTrade
            /// </summary>
            [EnumMember(Value = "ReadyToTrade")]
            ReadyToTrade = 4,
            /// <summary>
            /// Enum Verified for value: Verified
            /// </summary>
            [EnumMember(Value = "Verified")]
            Verified = 5        }
        /// <summary>
        /// Inactive, Locked, ReadyForContracts, ReadyToTrade, Verified
        /// </summary>
        /// <value>Inactive, Locked, ReadyForContracts, ReadyToTrade, Verified</value>
        [DataMember(Name="productVerificationStatus", EmitDefaultValue=false)]
        public ProductVerificationStatusEnum? ProductVerificationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountRiskParameter" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contractId">contractId.</param>
        /// <param name="productId">productId.</param>
        /// <param name="exchangeId">exchangeId.</param>
        /// <param name="productType">CommonStock, Continuous, Cryptocurrency, Futures, MarketInternals, Options, Spread.</param>
        /// <param name="riskDiscountContractGroupId">riskDiscountContractGroupId.</param>
        /// <param name="productVerificationStatus">Inactive, Locked, ReadyForContracts, ReadyToTrade, Verified.</param>
        /// <param name="contractGroupId">contractGroupId.</param>
        /// <param name="maxOpeningOrderQty">maxOpeningOrderQty.</param>
        /// <param name="maxClosingOrderQty">maxClosingOrderQty.</param>
        /// <param name="maxBackMonth">maxBackMonth.</param>
        /// <param name="preExpirationDays">preExpirationDays.</param>
        /// <param name="marginPercentage">marginPercentage.</param>
        /// <param name="marginDollarValue">marginDollarValue.</param>
        /// <param name="hardLimit">hardLimit.</param>
        /// <param name="userAccountPositionLimitId">userAccountPositionLimitId (required).</param>
        public UserAccountRiskParameter(long? id = default(long?), long? contractId = default(long?), long? productId = default(long?), long? exchangeId = default(long?), ProductTypeEnum? productType = default(ProductTypeEnum?), long? riskDiscountContractGroupId = default(long?), ProductVerificationStatusEnum? productVerificationStatus = default(ProductVerificationStatusEnum?), long? contractGroupId = default(long?), int? maxOpeningOrderQty = default(int?), int? maxClosingOrderQty = default(int?), int? maxBackMonth = default(int?), int? preExpirationDays = default(int?), double? marginPercentage = default(double?), double? marginDollarValue = default(double?), bool? hardLimit = default(bool?), long? userAccountPositionLimitId = default(long?))
        {
            // to ensure "userAccountPositionLimitId" is required (not null)
            if (userAccountPositionLimitId == null)
            {
                throw new InvalidDataException("userAccountPositionLimitId is a required property for UserAccountRiskParameter and cannot be null");
            }
            else
            {
                this.UserAccountPositionLimitId = userAccountPositionLimitId;
            }
            this.Id = id;
            this.ContractId = contractId;
            this.ProductId = productId;
            this.ExchangeId = exchangeId;
            this.ProductType = productType;
            this.RiskDiscountContractGroupId = riskDiscountContractGroupId;
            this.ProductVerificationStatus = productVerificationStatus;
            this.ContractGroupId = contractGroupId;
            this.MaxOpeningOrderQty = maxOpeningOrderQty;
            this.MaxClosingOrderQty = maxClosingOrderQty;
            this.MaxBackMonth = maxBackMonth;
            this.PreExpirationDays = preExpirationDays;
            this.MarginPercentage = marginPercentage;
            this.MarginDollarValue = marginDollarValue;
            this.HardLimit = hardLimit;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ContractId
        /// </summary>
        [DataMember(Name="contractId", EmitDefaultValue=false)]
        public long? ContractId { get; set; }

        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeId
        /// </summary>
        [DataMember(Name="exchangeId", EmitDefaultValue=false)]
        public long? ExchangeId { get; set; }


        /// <summary>
        /// Gets or Sets RiskDiscountContractGroupId
        /// </summary>
        [DataMember(Name="riskDiscountContractGroupId", EmitDefaultValue=false)]
        public long? RiskDiscountContractGroupId { get; set; }


        /// <summary>
        /// Gets or Sets ContractGroupId
        /// </summary>
        [DataMember(Name="contractGroupId", EmitDefaultValue=false)]
        public long? ContractGroupId { get; set; }

        /// <summary>
        /// Gets or Sets MaxOpeningOrderQty
        /// </summary>
        [DataMember(Name="maxOpeningOrderQty", EmitDefaultValue=false)]
        public int? MaxOpeningOrderQty { get; set; }

        /// <summary>
        /// Gets or Sets MaxClosingOrderQty
        /// </summary>
        [DataMember(Name="maxClosingOrderQty", EmitDefaultValue=false)]
        public int? MaxClosingOrderQty { get; set; }

        /// <summary>
        /// Gets or Sets MaxBackMonth
        /// </summary>
        [DataMember(Name="maxBackMonth", EmitDefaultValue=false)]
        public int? MaxBackMonth { get; set; }

        /// <summary>
        /// Gets or Sets PreExpirationDays
        /// </summary>
        [DataMember(Name="preExpirationDays", EmitDefaultValue=false)]
        public int? PreExpirationDays { get; set; }

        /// <summary>
        /// Gets or Sets MarginPercentage
        /// </summary>
        [DataMember(Name="marginPercentage", EmitDefaultValue=false)]
        public double? MarginPercentage { get; set; }

        /// <summary>
        /// Gets or Sets MarginDollarValue
        /// </summary>
        [DataMember(Name="marginDollarValue", EmitDefaultValue=false)]
        public double? MarginDollarValue { get; set; }

        /// <summary>
        /// Gets or Sets HardLimit
        /// </summary>
        [DataMember(Name="hardLimit", EmitDefaultValue=false)]
        public bool? HardLimit { get; set; }

        /// <summary>
        /// Gets or Sets UserAccountPositionLimitId
        /// </summary>
        [DataMember(Name="userAccountPositionLimitId", EmitDefaultValue=false)]
        public long? UserAccountPositionLimitId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAccountRiskParameter {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ExchangeId: ").Append(ExchangeId).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  RiskDiscountContractGroupId: ").Append(RiskDiscountContractGroupId).Append("\n");
            sb.Append("  ProductVerificationStatus: ").Append(ProductVerificationStatus).Append("\n");
            sb.Append("  ContractGroupId: ").Append(ContractGroupId).Append("\n");
            sb.Append("  MaxOpeningOrderQty: ").Append(MaxOpeningOrderQty).Append("\n");
            sb.Append("  MaxClosingOrderQty: ").Append(MaxClosingOrderQty).Append("\n");
            sb.Append("  MaxBackMonth: ").Append(MaxBackMonth).Append("\n");
            sb.Append("  PreExpirationDays: ").Append(PreExpirationDays).Append("\n");
            sb.Append("  MarginPercentage: ").Append(MarginPercentage).Append("\n");
            sb.Append("  MarginDollarValue: ").Append(MarginDollarValue).Append("\n");
            sb.Append("  HardLimit: ").Append(HardLimit).Append("\n");
            sb.Append("  UserAccountPositionLimitId: ").Append(UserAccountPositionLimitId).Append("\n");
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
            return this.Equals(input as UserAccountRiskParameter);
        }

        /// <summary>
        /// Returns true if UserAccountRiskParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAccountRiskParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAccountRiskParameter input)
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
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.ExchangeId == input.ExchangeId ||
                    (this.ExchangeId != null &&
                    this.ExchangeId.Equals(input.ExchangeId))
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    (this.ProductType != null &&
                    this.ProductType.Equals(input.ProductType))
                ) && 
                (
                    this.RiskDiscountContractGroupId == input.RiskDiscountContractGroupId ||
                    (this.RiskDiscountContractGroupId != null &&
                    this.RiskDiscountContractGroupId.Equals(input.RiskDiscountContractGroupId))
                ) && 
                (
                    this.ProductVerificationStatus == input.ProductVerificationStatus ||
                    (this.ProductVerificationStatus != null &&
                    this.ProductVerificationStatus.Equals(input.ProductVerificationStatus))
                ) && 
                (
                    this.ContractGroupId == input.ContractGroupId ||
                    (this.ContractGroupId != null &&
                    this.ContractGroupId.Equals(input.ContractGroupId))
                ) && 
                (
                    this.MaxOpeningOrderQty == input.MaxOpeningOrderQty ||
                    (this.MaxOpeningOrderQty != null &&
                    this.MaxOpeningOrderQty.Equals(input.MaxOpeningOrderQty))
                ) && 
                (
                    this.MaxClosingOrderQty == input.MaxClosingOrderQty ||
                    (this.MaxClosingOrderQty != null &&
                    this.MaxClosingOrderQty.Equals(input.MaxClosingOrderQty))
                ) && 
                (
                    this.MaxBackMonth == input.MaxBackMonth ||
                    (this.MaxBackMonth != null &&
                    this.MaxBackMonth.Equals(input.MaxBackMonth))
                ) && 
                (
                    this.PreExpirationDays == input.PreExpirationDays ||
                    (this.PreExpirationDays != null &&
                    this.PreExpirationDays.Equals(input.PreExpirationDays))
                ) && 
                (
                    this.MarginPercentage == input.MarginPercentage ||
                    (this.MarginPercentage != null &&
                    this.MarginPercentage.Equals(input.MarginPercentage))
                ) && 
                (
                    this.MarginDollarValue == input.MarginDollarValue ||
                    (this.MarginDollarValue != null &&
                    this.MarginDollarValue.Equals(input.MarginDollarValue))
                ) && 
                (
                    this.HardLimit == input.HardLimit ||
                    (this.HardLimit != null &&
                    this.HardLimit.Equals(input.HardLimit))
                ) && 
                (
                    this.UserAccountPositionLimitId == input.UserAccountPositionLimitId ||
                    (this.UserAccountPositionLimitId != null &&
                    this.UserAccountPositionLimitId.Equals(input.UserAccountPositionLimitId))
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
                if (this.ContractId != null)
                    hashCode = hashCode * 59 + this.ContractId.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ExchangeId != null)
                    hashCode = hashCode * 59 + this.ExchangeId.GetHashCode();
                if (this.ProductType != null)
                    hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.RiskDiscountContractGroupId != null)
                    hashCode = hashCode * 59 + this.RiskDiscountContractGroupId.GetHashCode();
                if (this.ProductVerificationStatus != null)
                    hashCode = hashCode * 59 + this.ProductVerificationStatus.GetHashCode();
                if (this.ContractGroupId != null)
                    hashCode = hashCode * 59 + this.ContractGroupId.GetHashCode();
                if (this.MaxOpeningOrderQty != null)
                    hashCode = hashCode * 59 + this.MaxOpeningOrderQty.GetHashCode();
                if (this.MaxClosingOrderQty != null)
                    hashCode = hashCode * 59 + this.MaxClosingOrderQty.GetHashCode();
                if (this.MaxBackMonth != null)
                    hashCode = hashCode * 59 + this.MaxBackMonth.GetHashCode();
                if (this.PreExpirationDays != null)
                    hashCode = hashCode * 59 + this.PreExpirationDays.GetHashCode();
                if (this.MarginPercentage != null)
                    hashCode = hashCode * 59 + this.MarginPercentage.GetHashCode();
                if (this.MarginDollarValue != null)
                    hashCode = hashCode * 59 + this.MarginDollarValue.GetHashCode();
                if (this.HardLimit != null)
                    hashCode = hashCode * 59 + this.HardLimit.GetHashCode();
                if (this.UserAccountPositionLimitId != null)
                    hashCode = hashCode * 59 + this.UserAccountPositionLimitId.GetHashCode();
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

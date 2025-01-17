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
    /// CashBalanceLog
    /// </summary>
    [DataContract]
        public partial class CashBalanceLog :  IEquatable<CashBalanceLog>, IValidatableObject
    {
        /// <summary>
        /// AccountClosureFee, AddUserFee, AutomaticReconciliation, BrokerageFee, CancelledPairedTrade, CashSettlement, ClearingFee, Commission, Courtesy, Debit, DepositFee, DeskFee, DormantFee, EntitlementSubscription, Escheatment, ExchangeFee, FundTransaction, FundTransactionFee, GoodwillCredit, IPFee, InactivityFee, LiquidationFee, LiquidationFee2, ManualAdjustment, MarketDataSubscription, NewSession, NfaFee, NsfCheckFee, OptionsTrade, OrderRoutingFee, PROMO, RithmicFee, SeatLeasePayment, StopPaymentFee, ThirdPartyFee, TradePaired, TradovateSubscription
        /// </summary>
        /// <value>AccountClosureFee, AddUserFee, AutomaticReconciliation, BrokerageFee, CancelledPairedTrade, CashSettlement, ClearingFee, Commission, Courtesy, Debit, DepositFee, DeskFee, DormantFee, EntitlementSubscription, Escheatment, ExchangeFee, FundTransaction, FundTransactionFee, GoodwillCredit, IPFee, InactivityFee, LiquidationFee, LiquidationFee2, ManualAdjustment, MarketDataSubscription, NewSession, NfaFee, NsfCheckFee, OptionsTrade, OrderRoutingFee, PROMO, RithmicFee, SeatLeasePayment, StopPaymentFee, ThirdPartyFee, TradePaired, TradovateSubscription</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum CashChangeTypeEnum
        {
            /// <summary>
            /// Enum AccountClosureFee for value: AccountClosureFee
            /// </summary>
            [EnumMember(Value = "AccountClosureFee")]
            AccountClosureFee = 1,
            /// <summary>
            /// Enum AddUserFee for value: AddUserFee
            /// </summary>
            [EnumMember(Value = "AddUserFee")]
            AddUserFee = 2,
            /// <summary>
            /// Enum AutomaticReconciliation for value: AutomaticReconciliation
            /// </summary>
            [EnumMember(Value = "AutomaticReconciliation")]
            AutomaticReconciliation = 3,
            /// <summary>
            /// Enum BrokerageFee for value: BrokerageFee
            /// </summary>
            [EnumMember(Value = "BrokerageFee")]
            BrokerageFee = 4,
            /// <summary>
            /// Enum CancelledPairedTrade for value: CancelledPairedTrade
            /// </summary>
            [EnumMember(Value = "CancelledPairedTrade")]
            CancelledPairedTrade = 5,
            /// <summary>
            /// Enum CashSettlement for value: CashSettlement
            /// </summary>
            [EnumMember(Value = "CashSettlement")]
            CashSettlement = 6,
            /// <summary>
            /// Enum ClearingFee for value: ClearingFee
            /// </summary>
            [EnumMember(Value = "ClearingFee")]
            ClearingFee = 7,
            /// <summary>
            /// Enum Commission for value: Commission
            /// </summary>
            [EnumMember(Value = "Commission")]
            Commission = 8,
            /// <summary>
            /// Enum Courtesy for value: Courtesy
            /// </summary>
            [EnumMember(Value = "Courtesy")]
            Courtesy = 9,
            /// <summary>
            /// Enum Debit for value: Debit
            /// </summary>
            [EnumMember(Value = "Debit")]
            Debit = 10,
            /// <summary>
            /// Enum DepositFee for value: DepositFee
            /// </summary>
            [EnumMember(Value = "DepositFee")]
            DepositFee = 11,
            /// <summary>
            /// Enum DeskFee for value: DeskFee
            /// </summary>
            [EnumMember(Value = "DeskFee")]
            DeskFee = 12,
            /// <summary>
            /// Enum DormantFee for value: DormantFee
            /// </summary>
            [EnumMember(Value = "DormantFee")]
            DormantFee = 13,
            /// <summary>
            /// Enum EntitlementSubscription for value: EntitlementSubscription
            /// </summary>
            [EnumMember(Value = "EntitlementSubscription")]
            EntitlementSubscription = 14,
            /// <summary>
            /// Enum Escheatment for value: Escheatment
            /// </summary>
            [EnumMember(Value = "Escheatment")]
            Escheatment = 15,
            /// <summary>
            /// Enum ExchangeFee for value: ExchangeFee
            /// </summary>
            [EnumMember(Value = "ExchangeFee")]
            ExchangeFee = 16,
            /// <summary>
            /// Enum FundTransaction for value: FundTransaction
            /// </summary>
            [EnumMember(Value = "FundTransaction")]
            FundTransaction = 17,
            /// <summary>
            /// Enum FundTransactionFee for value: FundTransactionFee
            /// </summary>
            [EnumMember(Value = "FundTransactionFee")]
            FundTransactionFee = 18,
            /// <summary>
            /// Enum GoodwillCredit for value: GoodwillCredit
            /// </summary>
            [EnumMember(Value = "GoodwillCredit")]
            GoodwillCredit = 19,
            /// <summary>
            /// Enum IPFee for value: IPFee
            /// </summary>
            [EnumMember(Value = "IPFee")]
            IPFee = 20,
            /// <summary>
            /// Enum InactivityFee for value: InactivityFee
            /// </summary>
            [EnumMember(Value = "InactivityFee")]
            InactivityFee = 21,
            /// <summary>
            /// Enum LiquidationFee for value: LiquidationFee
            /// </summary>
            [EnumMember(Value = "LiquidationFee")]
            LiquidationFee = 22,
            /// <summary>
            /// Enum LiquidationFee2 for value: LiquidationFee2
            /// </summary>
            [EnumMember(Value = "LiquidationFee2")]
            LiquidationFee2 = 23,
            /// <summary>
            /// Enum ManualAdjustment for value: ManualAdjustment
            /// </summary>
            [EnumMember(Value = "ManualAdjustment")]
            ManualAdjustment = 24,
            /// <summary>
            /// Enum MarketDataSubscription for value: MarketDataSubscription
            /// </summary>
            [EnumMember(Value = "MarketDataSubscription")]
            MarketDataSubscription = 25,
            /// <summary>
            /// Enum NewSession for value: NewSession
            /// </summary>
            [EnumMember(Value = "NewSession")]
            NewSession = 26,
            /// <summary>
            /// Enum NfaFee for value: NfaFee
            /// </summary>
            [EnumMember(Value = "NfaFee")]
            NfaFee = 27,
            /// <summary>
            /// Enum NsfCheckFee for value: NsfCheckFee
            /// </summary>
            [EnumMember(Value = "NsfCheckFee")]
            NsfCheckFee = 28,
            /// <summary>
            /// Enum OptionsTrade for value: OptionsTrade
            /// </summary>
            [EnumMember(Value = "OptionsTrade")]
            OptionsTrade = 29,
            /// <summary>
            /// Enum OrderRoutingFee for value: OrderRoutingFee
            /// </summary>
            [EnumMember(Value = "OrderRoutingFee")]
            OrderRoutingFee = 30,
            /// <summary>
            /// Enum PROMO for value: PROMO
            /// </summary>
            [EnumMember(Value = "PROMO")]
            PROMO = 31,
            /// <summary>
            /// Enum RithmicFee for value: RithmicFee
            /// </summary>
            [EnumMember(Value = "RithmicFee")]
            RithmicFee = 32,
            /// <summary>
            /// Enum SeatLeasePayment for value: SeatLeasePayment
            /// </summary>
            [EnumMember(Value = "SeatLeasePayment")]
            SeatLeasePayment = 33,
            /// <summary>
            /// Enum StopPaymentFee for value: StopPaymentFee
            /// </summary>
            [EnumMember(Value = "StopPaymentFee")]
            StopPaymentFee = 34,
            /// <summary>
            /// Enum ThirdPartyFee for value: ThirdPartyFee
            /// </summary>
            [EnumMember(Value = "ThirdPartyFee")]
            ThirdPartyFee = 35,
            /// <summary>
            /// Enum TradePaired for value: TradePaired
            /// </summary>
            [EnumMember(Value = "TradePaired")]
            TradePaired = 36,
            /// <summary>
            /// Enum TradovateSubscription for value: TradovateSubscription
            /// </summary>
            [EnumMember(Value = "TradovateSubscription")]
            TradovateSubscription = 37        }
        /// <summary>
        /// AccountClosureFee, AddUserFee, AutomaticReconciliation, BrokerageFee, CancelledPairedTrade, CashSettlement, ClearingFee, Commission, Courtesy, Debit, DepositFee, DeskFee, DormantFee, EntitlementSubscription, Escheatment, ExchangeFee, FundTransaction, FundTransactionFee, GoodwillCredit, IPFee, InactivityFee, LiquidationFee, LiquidationFee2, ManualAdjustment, MarketDataSubscription, NewSession, NfaFee, NsfCheckFee, OptionsTrade, OrderRoutingFee, PROMO, RithmicFee, SeatLeasePayment, StopPaymentFee, ThirdPartyFee, TradePaired, TradovateSubscription
        /// </summary>
        /// <value>AccountClosureFee, AddUserFee, AutomaticReconciliation, BrokerageFee, CancelledPairedTrade, CashSettlement, ClearingFee, Commission, Courtesy, Debit, DepositFee, DeskFee, DormantFee, EntitlementSubscription, Escheatment, ExchangeFee, FundTransaction, FundTransactionFee, GoodwillCredit, IPFee, InactivityFee, LiquidationFee, LiquidationFee2, ManualAdjustment, MarketDataSubscription, NewSession, NfaFee, NsfCheckFee, OptionsTrade, OrderRoutingFee, PROMO, RithmicFee, SeatLeasePayment, StopPaymentFee, ThirdPartyFee, TradePaired, TradovateSubscription</value>
        [DataMember(Name="cashChangeType", EmitDefaultValue=false)]
        public CashChangeTypeEnum CashChangeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CashBalanceLog" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="accountId">accountId (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="tradeDate">tradeDate (required).</param>
        /// <param name="currencyId">currencyId (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="realizedPnL">realizedPnL.</param>
        /// <param name="weekRealizedPnL">weekRealizedPnL.</param>
        /// <param name="cashChangeType">AccountClosureFee, AddUserFee, AutomaticReconciliation, BrokerageFee, CancelledPairedTrade, CashSettlement, ClearingFee, Commission, Courtesy, Debit, DepositFee, DeskFee, DormantFee, EntitlementSubscription, Escheatment, ExchangeFee, FundTransaction, FundTransactionFee, GoodwillCredit, IPFee, InactivityFee, LiquidationFee, LiquidationFee2, ManualAdjustment, MarketDataSubscription, NewSession, NfaFee, NsfCheckFee, OptionsTrade, OrderRoutingFee, PROMO, RithmicFee, SeatLeasePayment, StopPaymentFee, ThirdPartyFee, TradePaired, TradovateSubscription (required).</param>
        /// <param name="fillPairId">fillPairId.</param>
        /// <param name="fillId">fillId.</param>
        /// <param name="fundTransactionId">fundTransactionId.</param>
        /// <param name="comment">comment.</param>
        /// <param name="delta">delta (required).</param>
        /// <param name="senderId">senderId.</param>
        public CashBalanceLog(long? id = default(long?), long? accountId = default(long?), DateTime? timestamp = default(DateTime?), TradeDate tradeDate = default(TradeDate), long? currencyId = default(long?), double? amount = default(double?), double? realizedPnL = default(double?), double? weekRealizedPnL = default(double?), CashChangeTypeEnum cashChangeType = default(CashChangeTypeEnum), long? fillPairId = default(long?), long? fillId = default(long?), long? fundTransactionId = default(long?), string comment = default(string), double? delta = default(double?), long? senderId = default(long?))
        {
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for CashBalanceLog and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for CashBalanceLog and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "tradeDate" is required (not null)
            if (tradeDate == null)
            {
                throw new InvalidDataException("tradeDate is a required property for CashBalanceLog and cannot be null");
            }
            else
            {
                this.TradeDate = tradeDate;
            }
            // to ensure "currencyId" is required (not null)
            if (currencyId == null)
            {
                throw new InvalidDataException("currencyId is a required property for CashBalanceLog and cannot be null");
            }
            else
            {
                this.CurrencyId = currencyId;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for CashBalanceLog and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "cashChangeType" is required (not null)
            if (cashChangeType == null)
            {
                throw new InvalidDataException("cashChangeType is a required property for CashBalanceLog and cannot be null");
            }
            else
            {
                this.CashChangeType = cashChangeType;
            }
            // to ensure "delta" is required (not null)
            if (delta == null)
            {
                throw new InvalidDataException("delta is a required property for CashBalanceLog and cannot be null");
            }
            else
            {
                this.Delta = delta;
            }
            this.Id = id;
            this.RealizedPnL = realizedPnL;
            this.WeekRealizedPnL = weekRealizedPnL;
            this.FillPairId = fillPairId;
            this.FillId = fillId;
            this.FundTransactionId = fundTransactionId;
            this.Comment = comment;
            this.SenderId = senderId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets TradeDate
        /// </summary>
        [DataMember(Name="tradeDate", EmitDefaultValue=false)]
        public TradeDate TradeDate { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name="currencyId", EmitDefaultValue=false)]
        public long? CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or Sets RealizedPnL
        /// </summary>
        [DataMember(Name="realizedPnL", EmitDefaultValue=false)]
        public double? RealizedPnL { get; set; }

        /// <summary>
        /// Gets or Sets WeekRealizedPnL
        /// </summary>
        [DataMember(Name="weekRealizedPnL", EmitDefaultValue=false)]
        public double? WeekRealizedPnL { get; set; }


        /// <summary>
        /// Gets or Sets FillPairId
        /// </summary>
        [DataMember(Name="fillPairId", EmitDefaultValue=false)]
        public long? FillPairId { get; set; }

        /// <summary>
        /// Gets or Sets FillId
        /// </summary>
        [DataMember(Name="fillId", EmitDefaultValue=false)]
        public long? FillId { get; set; }

        /// <summary>
        /// Gets or Sets FundTransactionId
        /// </summary>
        [DataMember(Name="fundTransactionId", EmitDefaultValue=false)]
        public long? FundTransactionId { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Delta
        /// </summary>
        [DataMember(Name="delta", EmitDefaultValue=false)]
        public double? Delta { get; set; }

        /// <summary>
        /// Gets or Sets SenderId
        /// </summary>
        [DataMember(Name="senderId", EmitDefaultValue=false)]
        public long? SenderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CashBalanceLog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TradeDate: ").Append(TradeDate).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  RealizedPnL: ").Append(RealizedPnL).Append("\n");
            sb.Append("  WeekRealizedPnL: ").Append(WeekRealizedPnL).Append("\n");
            sb.Append("  CashChangeType: ").Append(CashChangeType).Append("\n");
            sb.Append("  FillPairId: ").Append(FillPairId).Append("\n");
            sb.Append("  FillId: ").Append(FillId).Append("\n");
            sb.Append("  FundTransactionId: ").Append(FundTransactionId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Delta: ").Append(Delta).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
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
            return this.Equals(input as CashBalanceLog);
        }

        /// <summary>
        /// Returns true if CashBalanceLog instances are equal
        /// </summary>
        /// <param name="input">Instance of CashBalanceLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashBalanceLog input)
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
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.TradeDate == input.TradeDate ||
                    (this.TradeDate != null &&
                    this.TradeDate.Equals(input.TradeDate))
                ) && 
                (
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.RealizedPnL == input.RealizedPnL ||
                    (this.RealizedPnL != null &&
                    this.RealizedPnL.Equals(input.RealizedPnL))
                ) && 
                (
                    this.WeekRealizedPnL == input.WeekRealizedPnL ||
                    (this.WeekRealizedPnL != null &&
                    this.WeekRealizedPnL.Equals(input.WeekRealizedPnL))
                ) && 
                (
                    this.CashChangeType == input.CashChangeType ||
                    (this.CashChangeType != null &&
                    this.CashChangeType.Equals(input.CashChangeType))
                ) && 
                (
                    this.FillPairId == input.FillPairId ||
                    (this.FillPairId != null &&
                    this.FillPairId.Equals(input.FillPairId))
                ) && 
                (
                    this.FillId == input.FillId ||
                    (this.FillId != null &&
                    this.FillId.Equals(input.FillId))
                ) && 
                (
                    this.FundTransactionId == input.FundTransactionId ||
                    (this.FundTransactionId != null &&
                    this.FundTransactionId.Equals(input.FundTransactionId))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Delta == input.Delta ||
                    (this.Delta != null &&
                    this.Delta.Equals(input.Delta))
                ) && 
                (
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.TradeDate != null)
                    hashCode = hashCode * 59 + this.TradeDate.GetHashCode();
                if (this.CurrencyId != null)
                    hashCode = hashCode * 59 + this.CurrencyId.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.RealizedPnL != null)
                    hashCode = hashCode * 59 + this.RealizedPnL.GetHashCode();
                if (this.WeekRealizedPnL != null)
                    hashCode = hashCode * 59 + this.WeekRealizedPnL.GetHashCode();
                if (this.CashChangeType != null)
                    hashCode = hashCode * 59 + this.CashChangeType.GetHashCode();
                if (this.FillPairId != null)
                    hashCode = hashCode * 59 + this.FillPairId.GetHashCode();
                if (this.FillId != null)
                    hashCode = hashCode * 59 + this.FillId.GetHashCode();
                if (this.FundTransactionId != null)
                    hashCode = hashCode * 59 + this.FundTransactionId.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Delta != null)
                    hashCode = hashCode * 59 + this.Delta.GetHashCode();
                if (this.SenderId != null)
                    hashCode = hashCode * 59 + this.SenderId.GetHashCode();
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

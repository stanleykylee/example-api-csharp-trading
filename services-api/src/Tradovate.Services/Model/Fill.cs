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
    /// Fill
    /// </summary>
    [DataContract]
        public partial class Fill :  IEquatable<Fill>, IValidatableObject
    {
        /// <summary>
        /// Buy, Sell
        /// </summary>
        /// <value>Buy, Sell</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ActionEnum
        {
            /// <summary>
            /// Enum Buy for value: Buy
            /// </summary>
            [EnumMember(Value = "Buy")]
            Buy = 1,
            /// <summary>
            /// Enum Sell for value: Sell
            /// </summary>
            [EnumMember(Value = "Sell")]
            Sell = 2        }
        /// <summary>
        /// Buy, Sell
        /// </summary>
        /// <value>Buy, Sell</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Fill" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="orderId">orderId (required).</param>
        /// <param name="contractId">contractId (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="tradeDate">tradeDate (required).</param>
        /// <param name="action">Buy, Sell (required).</param>
        /// <param name="qty">qty (required).</param>
        /// <param name="price">price (required).</param>
        /// <param name="active">active (required).</param>
        /// <param name="finallyPaired">finallyPaired (required).</param>
        public Fill(long? id = default(long?), long? orderId = default(long?), long? contractId = default(long?), DateTime? timestamp = default(DateTime?), TradeDate tradeDate = default(TradeDate), ActionEnum action = default(ActionEnum), int? qty = default(int?), double? price = default(double?), bool? active = default(bool?), int? finallyPaired = default(int?))
        {
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new InvalidDataException("orderId is a required property for Fill and cannot be null");
            }
            else
            {
                this.OrderId = orderId;
            }
            // to ensure "contractId" is required (not null)
            if (contractId == null)
            {
                throw new InvalidDataException("contractId is a required property for Fill and cannot be null");
            }
            else
            {
                this.ContractId = contractId;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for Fill and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "tradeDate" is required (not null)
            if (tradeDate == null)
            {
                throw new InvalidDataException("tradeDate is a required property for Fill and cannot be null");
            }
            else
            {
                this.TradeDate = tradeDate;
            }
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new InvalidDataException("action is a required property for Fill and cannot be null");
            }
            else
            {
                this.Action = action;
            }
            // to ensure "qty" is required (not null)
            if (qty == null)
            {
                throw new InvalidDataException("qty is a required property for Fill and cannot be null");
            }
            else
            {
                this.Qty = qty;
            }
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for Fill and cannot be null");
            }
            else
            {
                this.Price = price;
            }
            // to ensure "active" is required (not null)
            if (active == null)
            {
                throw new InvalidDataException("active is a required property for Fill and cannot be null");
            }
            else
            {
                this.Active = active;
            }
            // to ensure "finallyPaired" is required (not null)
            if (finallyPaired == null)
            {
                throw new InvalidDataException("finallyPaired is a required property for Fill and cannot be null");
            }
            else
            {
                this.FinallyPaired = finallyPaired;
            }
            this.Id = id;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// Gets or Sets ContractId
        /// </summary>
        [DataMember(Name="contractId", EmitDefaultValue=false)]
        public long? ContractId { get; set; }

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
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="qty", EmitDefaultValue=false)]
        public int? Qty { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets FinallyPaired
        /// </summary>
        [DataMember(Name="finallyPaired", EmitDefaultValue=false)]
        public int? FinallyPaired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Fill {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TradeDate: ").Append(TradeDate).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  FinallyPaired: ").Append(FinallyPaired).Append("\n");
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
            return this.Equals(input as Fill);
        }

        /// <summary>
        /// Returns true if Fill instances are equal
        /// </summary>
        /// <param name="input">Instance of Fill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Fill input)
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
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
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
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.FinallyPaired == input.FinallyPaired ||
                    (this.FinallyPaired != null &&
                    this.FinallyPaired.Equals(input.FinallyPaired))
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
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.ContractId != null)
                    hashCode = hashCode * 59 + this.ContractId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.TradeDate != null)
                    hashCode = hashCode * 59 + this.TradeDate.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.FinallyPaired != null)
                    hashCode = hashCode * 59 + this.FinallyPaired.GetHashCode();
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

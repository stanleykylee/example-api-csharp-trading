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
    /// OrderVersion
    /// </summary>
    [DataContract]
        public partial class OrderVersion :  IEquatable<OrderVersion>, IValidatableObject
    {
        /// <summary>
        /// Limit, MIT, Market, QTS, Stop, StopLimit, TrailingStop, TrailingStopLimit
        /// </summary>
        /// <value>Limit, MIT, Market, QTS, Stop, StopLimit, TrailingStop, TrailingStopLimit</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OrderTypeEnum
        {
            /// <summary>
            /// Enum Limit for value: Limit
            /// </summary>
            [EnumMember(Value = "Limit")]
            Limit = 1,
            /// <summary>
            /// Enum MIT for value: MIT
            /// </summary>
            [EnumMember(Value = "MIT")]
            MIT = 2,
            /// <summary>
            /// Enum Market for value: Market
            /// </summary>
            [EnumMember(Value = "Market")]
            Market = 3,
            /// <summary>
            /// Enum QTS for value: QTS
            /// </summary>
            [EnumMember(Value = "QTS")]
            QTS = 4,
            /// <summary>
            /// Enum Stop for value: Stop
            /// </summary>
            [EnumMember(Value = "Stop")]
            Stop = 5,
            /// <summary>
            /// Enum StopLimit for value: StopLimit
            /// </summary>
            [EnumMember(Value = "StopLimit")]
            StopLimit = 6,
            /// <summary>
            /// Enum TrailingStop for value: TrailingStop
            /// </summary>
            [EnumMember(Value = "TrailingStop")]
            TrailingStop = 7,
            /// <summary>
            /// Enum TrailingStopLimit for value: TrailingStopLimit
            /// </summary>
            [EnumMember(Value = "TrailingStopLimit")]
            TrailingStopLimit = 8        }
        /// <summary>
        /// Limit, MIT, Market, QTS, Stop, StopLimit, TrailingStop, TrailingStopLimit
        /// </summary>
        /// <value>Limit, MIT, Market, QTS, Stop, StopLimit, TrailingStop, TrailingStopLimit</value>
        [DataMember(Name="orderType", EmitDefaultValue=false)]
        public OrderTypeEnum OrderType { get; set; }
        /// <summary>
        /// Day, FOK, GTC, GTD, IOC
        /// </summary>
        /// <value>Day, FOK, GTC, GTD, IOC</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TimeInForceEnum
        {
            /// <summary>
            /// Enum Day for value: Day
            /// </summary>
            [EnumMember(Value = "Day")]
            Day = 1,
            /// <summary>
            /// Enum FOK for value: FOK
            /// </summary>
            [EnumMember(Value = "FOK")]
            FOK = 2,
            /// <summary>
            /// Enum GTC for value: GTC
            /// </summary>
            [EnumMember(Value = "GTC")]
            GTC = 3,
            /// <summary>
            /// Enum GTD for value: GTD
            /// </summary>
            [EnumMember(Value = "GTD")]
            GTD = 4,
            /// <summary>
            /// Enum IOC for value: IOC
            /// </summary>
            [EnumMember(Value = "IOC")]
            IOC = 5        }
        /// <summary>
        /// Day, FOK, GTC, GTD, IOC
        /// </summary>
        /// <value>Day, FOK, GTC, GTD, IOC</value>
        [DataMember(Name="timeInForce", EmitDefaultValue=false)]
        public TimeInForceEnum? TimeInForce { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderVersion" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="orderId">orderId (required).</param>
        /// <param name="orderQty">orderQty (required).</param>
        /// <param name="orderType">Limit, MIT, Market, QTS, Stop, StopLimit, TrailingStop, TrailingStopLimit (required).</param>
        /// <param name="price">price.</param>
        /// <param name="stopPrice">stopPrice.</param>
        /// <param name="maxShow">maxShow.</param>
        /// <param name="pegDifference">pegDifference.</param>
        /// <param name="timeInForce">Day, FOK, GTC, GTD, IOC.</param>
        /// <param name="expireTime">expireTime.</param>
        /// <param name="text">text.</param>
        public OrderVersion(long? id = default(long?), long? orderId = default(long?), int? orderQty = default(int?), OrderTypeEnum orderType = default(OrderTypeEnum), double? price = default(double?), double? stopPrice = default(double?), int? maxShow = default(int?), double? pegDifference = default(double?), TimeInForceEnum? timeInForce = default(TimeInForceEnum?), DateTime? expireTime = default(DateTime?), string text = default(string))
        {
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new InvalidDataException("orderId is a required property for OrderVersion and cannot be null");
            }
            else
            {
                this.OrderId = orderId;
            }
            // to ensure "orderQty" is required (not null)
            if (orderQty == null)
            {
                throw new InvalidDataException("orderQty is a required property for OrderVersion and cannot be null");
            }
            else
            {
                this.OrderQty = orderQty;
            }
            // to ensure "orderType" is required (not null)
            if (orderType == null)
            {
                throw new InvalidDataException("orderType is a required property for OrderVersion and cannot be null");
            }
            else
            {
                this.OrderType = orderType;
            }
            this.Id = id;
            this.Price = price;
            this.StopPrice = stopPrice;
            this.MaxShow = maxShow;
            this.PegDifference = pegDifference;
            this.TimeInForce = timeInForce;
            this.ExpireTime = expireTime;
            this.Text = text;
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
        /// Gets or Sets OrderQty
        /// </summary>
        [DataMember(Name="orderQty", EmitDefaultValue=false)]
        public int? OrderQty { get; set; }


        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or Sets StopPrice
        /// </summary>
        [DataMember(Name="stopPrice", EmitDefaultValue=false)]
        public double? StopPrice { get; set; }

        /// <summary>
        /// Gets or Sets MaxShow
        /// </summary>
        [DataMember(Name="maxShow", EmitDefaultValue=false)]
        public int? MaxShow { get; set; }

        /// <summary>
        /// Gets or Sets PegDifference
        /// </summary>
        [DataMember(Name="pegDifference", EmitDefaultValue=false)]
        public double? PegDifference { get; set; }


        /// <summary>
        /// Gets or Sets ExpireTime
        /// </summary>
        [DataMember(Name="expireTime", EmitDefaultValue=false)]
        public DateTime? ExpireTime { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderVersion {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderQty: ").Append(OrderQty).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  StopPrice: ").Append(StopPrice).Append("\n");
            sb.Append("  MaxShow: ").Append(MaxShow).Append("\n");
            sb.Append("  PegDifference: ").Append(PegDifference).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  ExpireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as OrderVersion);
        }

        /// <summary>
        /// Returns true if OrderVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderVersion input)
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
                    this.OrderQty == input.OrderQty ||
                    (this.OrderQty != null &&
                    this.OrderQty.Equals(input.OrderQty))
                ) && 
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.StopPrice == input.StopPrice ||
                    (this.StopPrice != null &&
                    this.StopPrice.Equals(input.StopPrice))
                ) && 
                (
                    this.MaxShow == input.MaxShow ||
                    (this.MaxShow != null &&
                    this.MaxShow.Equals(input.MaxShow))
                ) && 
                (
                    this.PegDifference == input.PegDifference ||
                    (this.PegDifference != null &&
                    this.PegDifference.Equals(input.PegDifference))
                ) && 
                (
                    this.TimeInForce == input.TimeInForce ||
                    (this.TimeInForce != null &&
                    this.TimeInForce.Equals(input.TimeInForce))
                ) && 
                (
                    this.ExpireTime == input.ExpireTime ||
                    (this.ExpireTime != null &&
                    this.ExpireTime.Equals(input.ExpireTime))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.OrderQty != null)
                    hashCode = hashCode * 59 + this.OrderQty.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.StopPrice != null)
                    hashCode = hashCode * 59 + this.StopPrice.GetHashCode();
                if (this.MaxShow != null)
                    hashCode = hashCode * 59 + this.MaxShow.GetHashCode();
                if (this.PegDifference != null)
                    hashCode = hashCode * 59 + this.PegDifference.GetHashCode();
                if (this.TimeInForce != null)
                    hashCode = hashCode * 59 + this.TimeInForce.GetHashCode();
                if (this.ExpireTime != null)
                    hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
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

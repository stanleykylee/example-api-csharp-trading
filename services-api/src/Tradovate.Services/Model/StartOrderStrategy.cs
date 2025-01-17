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
    /// StartOrderStrategy
    /// </summary>
    [DataContract]
        public partial class StartOrderStrategy :  IEquatable<StartOrderStrategy>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="StartOrderStrategy" /> class.
        /// </summary>
        /// <param name="accountId">accountId.</param>
        /// <param name="accountSpec">accountSpec.</param>
        /// <param name="symbol">symbol (required).</param>
        /// <param name="orderStrategyTypeId">orderStrategyTypeId (required).</param>
        /// <param name="action">Buy, Sell (required).</param>
        /// <param name="@params">@params.</param>
        /// <param name="uuid">uuid.</param>
        /// <param name="customTag50">customTag50.</param>
        public StartOrderStrategy(long? accountId = default(long?), string accountSpec = default(string), string symbol = default(string), long? orderStrategyTypeId = default(long?), ActionEnum action = default(ActionEnum), string @params = default(string), string uuid = default(string), string customTag50 = default(string))
        {
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new InvalidDataException("symbol is a required property for StartOrderStrategy and cannot be null");
            }
            else
            {
                this.Symbol = symbol;
            }
            // to ensure "orderStrategyTypeId" is required (not null)
            if (orderStrategyTypeId == null)
            {
                throw new InvalidDataException("orderStrategyTypeId is a required property for StartOrderStrategy and cannot be null");
            }
            else
            {
                this.OrderStrategyTypeId = orderStrategyTypeId;
            }
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new InvalidDataException("action is a required property for StartOrderStrategy and cannot be null");
            }
            else
            {
                this.Action = action;
            }
            this.AccountId = accountId;
            this.AccountSpec = accountSpec;
            this._Params = @params;
            this.Uuid = uuid;
            this.CustomTag50 = customTag50;
        }
        
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets AccountSpec
        /// </summary>
        [DataMember(Name="accountSpec", EmitDefaultValue=false)]
        public string AccountSpec { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets OrderStrategyTypeId
        /// </summary>
        [DataMember(Name="orderStrategyTypeId", EmitDefaultValue=false)]
        public long? OrderStrategyTypeId { get; set; }


        /// <summary>
        /// Gets or Sets _Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public string _Params { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets CustomTag50
        /// </summary>
        [DataMember(Name="customTag50", EmitDefaultValue=false)]
        public string CustomTag50 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartOrderStrategy {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountSpec: ").Append(AccountSpec).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  OrderStrategyTypeId: ").Append(OrderStrategyTypeId).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  _Params: ").Append(_Params).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  CustomTag50: ").Append(CustomTag50).Append("\n");
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
            return this.Equals(input as StartOrderStrategy);
        }

        /// <summary>
        /// Returns true if StartOrderStrategy instances are equal
        /// </summary>
        /// <param name="input">Instance of StartOrderStrategy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartOrderStrategy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AccountSpec == input.AccountSpec ||
                    (this.AccountSpec != null &&
                    this.AccountSpec.Equals(input.AccountSpec))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.OrderStrategyTypeId == input.OrderStrategyTypeId ||
                    (this.OrderStrategyTypeId != null &&
                    this.OrderStrategyTypeId.Equals(input.OrderStrategyTypeId))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this._Params == input._Params ||
                    (this._Params != null &&
                    this._Params.Equals(input._Params))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.CustomTag50 == input.CustomTag50 ||
                    (this.CustomTag50 != null &&
                    this.CustomTag50.Equals(input.CustomTag50))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AccountSpec != null)
                    hashCode = hashCode * 59 + this.AccountSpec.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.OrderStrategyTypeId != null)
                    hashCode = hashCode * 59 + this.OrderStrategyTypeId.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this._Params != null)
                    hashCode = hashCode * 59 + this._Params.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.CustomTag50 != null)
                    hashCode = hashCode * 59 + this.CustomTag50.GetHashCode();
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

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
    /// ModifyOrderStrategy
    /// </summary>
    [DataContract]
        public partial class ModifyOrderStrategy :  IEquatable<ModifyOrderStrategy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyOrderStrategy" /> class.
        /// </summary>
        /// <param name="orderStrategyId">orderStrategyId (required).</param>
        /// <param name="command">command (required).</param>
        /// <param name="customTag50">customTag50.</param>
        public ModifyOrderStrategy(long? orderStrategyId = default(long?), string command = default(string), string customTag50 = default(string))
        {
            // to ensure "orderStrategyId" is required (not null)
            if (orderStrategyId == null)
            {
                throw new InvalidDataException("orderStrategyId is a required property for ModifyOrderStrategy and cannot be null");
            }
            else
            {
                this.OrderStrategyId = orderStrategyId;
            }
            // to ensure "command" is required (not null)
            if (command == null)
            {
                throw new InvalidDataException("command is a required property for ModifyOrderStrategy and cannot be null");
            }
            else
            {
                this.Command = command;
            }
            this.CustomTag50 = customTag50;
        }
        
        /// <summary>
        /// Gets or Sets OrderStrategyId
        /// </summary>
        [DataMember(Name="orderStrategyId", EmitDefaultValue=false)]
        public long? OrderStrategyId { get; set; }

        /// <summary>
        /// Gets or Sets Command
        /// </summary>
        [DataMember(Name="command", EmitDefaultValue=false)]
        public string Command { get; set; }

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
            sb.Append("class ModifyOrderStrategy {\n");
            sb.Append("  OrderStrategyId: ").Append(OrderStrategyId).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
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
            return this.Equals(input as ModifyOrderStrategy);
        }

        /// <summary>
        /// Returns true if ModifyOrderStrategy instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyOrderStrategy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyOrderStrategy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderStrategyId == input.OrderStrategyId ||
                    (this.OrderStrategyId != null &&
                    this.OrderStrategyId.Equals(input.OrderStrategyId))
                ) && 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
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
                if (this.OrderStrategyId != null)
                    hashCode = hashCode * 59 + this.OrderStrategyId.GetHashCode();
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
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

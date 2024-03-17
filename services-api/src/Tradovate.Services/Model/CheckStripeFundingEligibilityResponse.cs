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
    /// CheckStripeFundingEligibilityResponse
    /// </summary>
    [DataContract]
        public partial class CheckStripeFundingEligibilityResponse :  IEquatable<CheckStripeFundingEligibilityResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckStripeFundingEligibilityResponse" /> class.
        /// </summary>
        /// <param name="errorText">Non-empty if the request failed.</param>
        /// <param name="minimumAmount">minimumAmount.</param>
        /// <param name="maximumAmount">maximumAmount.</param>
        public CheckStripeFundingEligibilityResponse(string errorText = default(string), double? minimumAmount = default(double?), double? maximumAmount = default(double?))
        {
            this.ErrorText = errorText;
            this.MinimumAmount = minimumAmount;
            this.MaximumAmount = maximumAmount;
        }
        
        /// <summary>
        /// Non-empty if the request failed
        /// </summary>
        /// <value>Non-empty if the request failed</value>
        [DataMember(Name="errorText", EmitDefaultValue=false)]
        public string ErrorText { get; set; }

        /// <summary>
        /// Gets or Sets MinimumAmount
        /// </summary>
        [DataMember(Name="minimumAmount", EmitDefaultValue=false)]
        public double? MinimumAmount { get; set; }

        /// <summary>
        /// Gets or Sets MaximumAmount
        /// </summary>
        [DataMember(Name="maximumAmount", EmitDefaultValue=false)]
        public double? MaximumAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckStripeFundingEligibilityResponse {\n");
            sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
            sb.Append("  MinimumAmount: ").Append(MinimumAmount).Append("\n");
            sb.Append("  MaximumAmount: ").Append(MaximumAmount).Append("\n");
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
            return this.Equals(input as CheckStripeFundingEligibilityResponse);
        }

        /// <summary>
        /// Returns true if CheckStripeFundingEligibilityResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckStripeFundingEligibilityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckStripeFundingEligibilityResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorText == input.ErrorText ||
                    (this.ErrorText != null &&
                    this.ErrorText.Equals(input.ErrorText))
                ) && 
                (
                    this.MinimumAmount == input.MinimumAmount ||
                    (this.MinimumAmount != null &&
                    this.MinimumAmount.Equals(input.MinimumAmount))
                ) && 
                (
                    this.MaximumAmount == input.MaximumAmount ||
                    (this.MaximumAmount != null &&
                    this.MaximumAmount.Equals(input.MaximumAmount))
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
                if (this.ErrorText != null)
                    hashCode = hashCode * 59 + this.ErrorText.GetHashCode();
                if (this.MinimumAmount != null)
                    hashCode = hashCode * 59 + this.MinimumAmount.GetHashCode();
                if (this.MaximumAmount != null)
                    hashCode = hashCode * 59 + this.MaximumAmount.GetHashCode();
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

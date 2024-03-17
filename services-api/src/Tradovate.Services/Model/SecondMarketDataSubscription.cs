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
    /// SecondMarketDataSubscription
    /// </summary>
    [DataContract]
        public partial class SecondMarketDataSubscription :  IEquatable<SecondMarketDataSubscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondMarketDataSubscription" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="year">year (required).</param>
        /// <param name="month">month (required).</param>
        /// <param name="cancelledRenewal">cancelledRenewal.</param>
        /// <param name="cancellationTimestamp">cancellationTimestamp.</param>
        public SecondMarketDataSubscription(long? id = default(long?), long? userId = default(long?), DateTime? timestamp = default(DateTime?), int? year = default(int?), int? month = default(int?), bool? cancelledRenewal = default(bool?), DateTime? cancellationTimestamp = default(DateTime?))
        {
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for SecondMarketDataSubscription and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for SecondMarketDataSubscription and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "year" is required (not null)
            if (year == null)
            {
                throw new InvalidDataException("year is a required property for SecondMarketDataSubscription and cannot be null");
            }
            else
            {
                this.Year = year;
            }
            // to ensure "month" is required (not null)
            if (month == null)
            {
                throw new InvalidDataException("month is a required property for SecondMarketDataSubscription and cannot be null");
            }
            else
            {
                this.Month = month;
            }
            this.Id = id;
            this.CancelledRenewal = cancelledRenewal;
            this.CancellationTimestamp = cancellationTimestamp;
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
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public int? Month { get; set; }

        /// <summary>
        /// Gets or Sets CancelledRenewal
        /// </summary>
        [DataMember(Name="cancelledRenewal", EmitDefaultValue=false)]
        public bool? CancelledRenewal { get; set; }

        /// <summary>
        /// Gets or Sets CancellationTimestamp
        /// </summary>
        [DataMember(Name="cancellationTimestamp", EmitDefaultValue=false)]
        public DateTime? CancellationTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecondMarketDataSubscription {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  CancelledRenewal: ").Append(CancelledRenewal).Append("\n");
            sb.Append("  CancellationTimestamp: ").Append(CancellationTimestamp).Append("\n");
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
            return this.Equals(input as SecondMarketDataSubscription);
        }

        /// <summary>
        /// Returns true if SecondMarketDataSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of SecondMarketDataSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecondMarketDataSubscription input)
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
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Month == input.Month ||
                    (this.Month != null &&
                    this.Month.Equals(input.Month))
                ) && 
                (
                    this.CancelledRenewal == input.CancelledRenewal ||
                    (this.CancelledRenewal != null &&
                    this.CancelledRenewal.Equals(input.CancelledRenewal))
                ) && 
                (
                    this.CancellationTimestamp == input.CancellationTimestamp ||
                    (this.CancellationTimestamp != null &&
                    this.CancellationTimestamp.Equals(input.CancellationTimestamp))
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
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Month != null)
                    hashCode = hashCode * 59 + this.Month.GetHashCode();
                if (this.CancelledRenewal != null)
                    hashCode = hashCode * 59 + this.CancelledRenewal.GetHashCode();
                if (this.CancellationTimestamp != null)
                    hashCode = hashCode * 59 + this.CancellationTimestamp.GetHashCode();
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

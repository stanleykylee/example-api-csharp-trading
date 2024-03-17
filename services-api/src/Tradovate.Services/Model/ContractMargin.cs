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
    /// ContractMargin
    /// </summary>
    [DataContract]
        public partial class ContractMargin :  IEquatable<ContractMargin>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractMargin" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="initialMargin">initialMargin (required).</param>
        /// <param name="maintenanceMargin">maintenanceMargin (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        public ContractMargin(long? id = default(long?), double? initialMargin = default(double?), double? maintenanceMargin = default(double?), DateTime? timestamp = default(DateTime?))
        {
            // to ensure "initialMargin" is required (not null)
            if (initialMargin == null)
            {
                throw new InvalidDataException("initialMargin is a required property for ContractMargin and cannot be null");
            }
            else
            {
                this.InitialMargin = initialMargin;
            }
            // to ensure "maintenanceMargin" is required (not null)
            if (maintenanceMargin == null)
            {
                throw new InvalidDataException("maintenanceMargin is a required property for ContractMargin and cannot be null");
            }
            else
            {
                this.MaintenanceMargin = maintenanceMargin;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for ContractMargin and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            this.Id = id;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets InitialMargin
        /// </summary>
        [DataMember(Name="initialMargin", EmitDefaultValue=false)]
        public double? InitialMargin { get; set; }

        /// <summary>
        /// Gets or Sets MaintenanceMargin
        /// </summary>
        [DataMember(Name="maintenanceMargin", EmitDefaultValue=false)]
        public double? MaintenanceMargin { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractMargin {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InitialMargin: ").Append(InitialMargin).Append("\n");
            sb.Append("  MaintenanceMargin: ").Append(MaintenanceMargin).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as ContractMargin);
        }

        /// <summary>
        /// Returns true if ContractMargin instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractMargin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractMargin input)
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
                    this.InitialMargin == input.InitialMargin ||
                    (this.InitialMargin != null &&
                    this.InitialMargin.Equals(input.InitialMargin))
                ) && 
                (
                    this.MaintenanceMargin == input.MaintenanceMargin ||
                    (this.MaintenanceMargin != null &&
                    this.MaintenanceMargin.Equals(input.MaintenanceMargin))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.InitialMargin != null)
                    hashCode = hashCode * 59 + this.InitialMargin.GetHashCode();
                if (this.MaintenanceMargin != null)
                    hashCode = hashCode * 59 + this.MaintenanceMargin.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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

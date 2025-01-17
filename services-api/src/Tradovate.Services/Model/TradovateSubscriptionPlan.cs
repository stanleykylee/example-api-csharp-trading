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
    /// TradovateSubscriptionPlan
    /// </summary>
    [DataContract]
        public partial class TradovateSubscriptionPlan :  IEquatable<TradovateSubscriptionPlan>, IValidatableObject
    {
        /// <summary>
        /// Lifetime, Month, Quarter, Week, Year
        /// </summary>
        /// <value>Lifetime, Month, Quarter, Week, Year</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DurationUnitsEnum
        {
            /// <summary>
            /// Enum Lifetime for value: Lifetime
            /// </summary>
            [EnumMember(Value = "Lifetime")]
            Lifetime = 1,
            /// <summary>
            /// Enum Month for value: Month
            /// </summary>
            [EnumMember(Value = "Month")]
            Month = 2,
            /// <summary>
            /// Enum Quarter for value: Quarter
            /// </summary>
            [EnumMember(Value = "Quarter")]
            Quarter = 3,
            /// <summary>
            /// Enum Week for value: Week
            /// </summary>
            [EnumMember(Value = "Week")]
            Week = 4,
            /// <summary>
            /// Enum Year for value: Year
            /// </summary>
            [EnumMember(Value = "Year")]
            Year = 5        }
        /// <summary>
        /// Lifetime, Month, Quarter, Week, Year
        /// </summary>
        /// <value>Lifetime, Month, Quarter, Week, Year</value>
        [DataMember(Name="durationUnits", EmitDefaultValue=false)]
        public DurationUnitsEnum DurationUnits { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TradovateSubscriptionPlan" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name (required).</param>
        /// <param name="title">title (required).</param>
        /// <param name="price">price (required).</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="discontinuedDate">discontinuedDate.</param>
        /// <param name="category">category (required).</param>
        /// <param name="trial">trial (required).</param>
        /// <param name="duration">duration (required).</param>
        /// <param name="durationUnits">Lifetime, Month, Quarter, Week, Year (required).</param>
        /// <param name="riskCategoryId">riskCategoryId.</param>
        /// <param name="multipleAccounts">multipleAccounts.</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="replaySessions">replaySessions.</param>
        /// <param name="footnote">footnote.</param>
        /// <param name="simOnly">simOnly.</param>
        public TradovateSubscriptionPlan(long? id = default(long?), string name = default(string), string title = default(string), double? price = default(double?), TradeDate startDate = default(TradeDate), TradeDate discontinuedDate = default(TradeDate), string category = default(string), bool? trial = default(bool?), int? duration = default(int?), DurationUnitsEnum durationUnits = default(DurationUnitsEnum), long? riskCategoryId = default(long?), bool? multipleAccounts = default(bool?), long? organizationId = default(long?), int? replaySessions = default(int?), string footnote = default(string), bool? simOnly = default(bool?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for TradovateSubscriptionPlan and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for TradovateSubscriptionPlan and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for TradovateSubscriptionPlan and cannot be null");
            }
            else
            {
                this.Price = price;
            }
            // to ensure "category" is required (not null)
            if (category == null)
            {
                throw new InvalidDataException("category is a required property for TradovateSubscriptionPlan and cannot be null");
            }
            else
            {
                this.Category = category;
            }
            // to ensure "trial" is required (not null)
            if (trial == null)
            {
                throw new InvalidDataException("trial is a required property for TradovateSubscriptionPlan and cannot be null");
            }
            else
            {
                this.Trial = trial;
            }
            // to ensure "duration" is required (not null)
            if (duration == null)
            {
                throw new InvalidDataException("duration is a required property for TradovateSubscriptionPlan and cannot be null");
            }
            else
            {
                this.Duration = duration;
            }
            // to ensure "durationUnits" is required (not null)
            if (durationUnits == null)
            {
                throw new InvalidDataException("durationUnits is a required property for TradovateSubscriptionPlan and cannot be null");
            }
            else
            {
                this.DurationUnits = durationUnits;
            }
            this.Id = id;
            this.StartDate = startDate;
            this.DiscontinuedDate = discontinuedDate;
            this.RiskCategoryId = riskCategoryId;
            this.MultipleAccounts = multipleAccounts;
            this.OrganizationId = organizationId;
            this.ReplaySessions = replaySessions;
            this.Footnote = footnote;
            this.SimOnly = simOnly;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public TradeDate StartDate { get; set; }

        /// <summary>
        /// Gets or Sets DiscontinuedDate
        /// </summary>
        [DataMember(Name="discontinuedDate", EmitDefaultValue=false)]
        public TradeDate DiscontinuedDate { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Trial
        /// </summary>
        [DataMember(Name="trial", EmitDefaultValue=false)]
        public bool? Trial { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }


        /// <summary>
        /// Gets or Sets RiskCategoryId
        /// </summary>
        [DataMember(Name="riskCategoryId", EmitDefaultValue=false)]
        public long? RiskCategoryId { get; set; }

        /// <summary>
        /// Gets or Sets MultipleAccounts
        /// </summary>
        [DataMember(Name="multipleAccounts", EmitDefaultValue=false)]
        public bool? MultipleAccounts { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets ReplaySessions
        /// </summary>
        [DataMember(Name="replaySessions", EmitDefaultValue=false)]
        public int? ReplaySessions { get; set; }

        /// <summary>
        /// Gets or Sets Footnote
        /// </summary>
        [DataMember(Name="footnote", EmitDefaultValue=false)]
        public string Footnote { get; set; }

        /// <summary>
        /// Gets or Sets SimOnly
        /// </summary>
        [DataMember(Name="simOnly", EmitDefaultValue=false)]
        public bool? SimOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TradovateSubscriptionPlan {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  DiscontinuedDate: ").Append(DiscontinuedDate).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Trial: ").Append(Trial).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  DurationUnits: ").Append(DurationUnits).Append("\n");
            sb.Append("  RiskCategoryId: ").Append(RiskCategoryId).Append("\n");
            sb.Append("  MultipleAccounts: ").Append(MultipleAccounts).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ReplaySessions: ").Append(ReplaySessions).Append("\n");
            sb.Append("  Footnote: ").Append(Footnote).Append("\n");
            sb.Append("  SimOnly: ").Append(SimOnly).Append("\n");
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
            return this.Equals(input as TradovateSubscriptionPlan);
        }

        /// <summary>
        /// Returns true if TradovateSubscriptionPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of TradovateSubscriptionPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradovateSubscriptionPlan input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.DiscontinuedDate == input.DiscontinuedDate ||
                    (this.DiscontinuedDate != null &&
                    this.DiscontinuedDate.Equals(input.DiscontinuedDate))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Trial == input.Trial ||
                    (this.Trial != null &&
                    this.Trial.Equals(input.Trial))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.DurationUnits == input.DurationUnits ||
                    (this.DurationUnits != null &&
                    this.DurationUnits.Equals(input.DurationUnits))
                ) && 
                (
                    this.RiskCategoryId == input.RiskCategoryId ||
                    (this.RiskCategoryId != null &&
                    this.RiskCategoryId.Equals(input.RiskCategoryId))
                ) && 
                (
                    this.MultipleAccounts == input.MultipleAccounts ||
                    (this.MultipleAccounts != null &&
                    this.MultipleAccounts.Equals(input.MultipleAccounts))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.ReplaySessions == input.ReplaySessions ||
                    (this.ReplaySessions != null &&
                    this.ReplaySessions.Equals(input.ReplaySessions))
                ) && 
                (
                    this.Footnote == input.Footnote ||
                    (this.Footnote != null &&
                    this.Footnote.Equals(input.Footnote))
                ) && 
                (
                    this.SimOnly == input.SimOnly ||
                    (this.SimOnly != null &&
                    this.SimOnly.Equals(input.SimOnly))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.DiscontinuedDate != null)
                    hashCode = hashCode * 59 + this.DiscontinuedDate.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Trial != null)
                    hashCode = hashCode * 59 + this.Trial.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.DurationUnits != null)
                    hashCode = hashCode * 59 + this.DurationUnits.GetHashCode();
                if (this.RiskCategoryId != null)
                    hashCode = hashCode * 59 + this.RiskCategoryId.GetHashCode();
                if (this.MultipleAccounts != null)
                    hashCode = hashCode * 59 + this.MultipleAccounts.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.ReplaySessions != null)
                    hashCode = hashCode * 59 + this.ReplaySessions.GetHashCode();
                if (this.Footnote != null)
                    hashCode = hashCode * 59 + this.Footnote.GetHashCode();
                if (this.SimOnly != null)
                    hashCode = hashCode * 59 + this.SimOnly.GetHashCode();
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

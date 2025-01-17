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
    /// UserAccountAutoLiq
    /// </summary>
    [DataContract]
        public partial class UserAccountAutoLiq :  IEquatable<UserAccountAutoLiq>, IValidatableObject
    {
        /// <summary>
        /// EOD, RealTime
        /// </summary>
        /// <value>EOD, RealTime</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TrailingMaxDrawdownModeEnum
        {
            /// <summary>
            /// Enum EOD for value: EOD
            /// </summary>
            [EnumMember(Value = "EOD")]
            EOD = 1,
            /// <summary>
            /// Enum RealTime for value: RealTime
            /// </summary>
            [EnumMember(Value = "RealTime")]
            RealTime = 2        }
        /// <summary>
        /// EOD, RealTime
        /// </summary>
        /// <value>EOD, RealTime</value>
        [DataMember(Name="trailingMaxDrawdownMode", EmitDefaultValue=false)]
        public TrailingMaxDrawdownModeEnum? TrailingMaxDrawdownMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountAutoLiq" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="changesLocked">Changes Locked.</param>
        /// <param name="marginPercentageAlert">Margin % for an Alert.</param>
        /// <param name="dailyLossPercentageAlert">Daily Loss % for an Alert.</param>
        /// <param name="dailyLossAlert">$ Daily Loss for an Alert.</param>
        /// <param name="marginPercentageLiqOnly">Margin % for an Liq Only.</param>
        /// <param name="dailyLossPercentageLiqOnly">Daily Loss % for an Liq Only.</param>
        /// <param name="dailyLossLiqOnly">$ Daily Loss for an Liq Only.</param>
        /// <param name="marginPercentageAutoLiq">Margin % for an Auto-Liq.</param>
        /// <param name="dailyLossPercentageAutoLiq">Daily Loss % for an AutoLiq.</param>
        /// <param name="dailyLossAutoLiq">$ Daily Loss for an Auto-Liq.</param>
        /// <param name="weeklyLossAutoLiq">$ Weekly Loss for an Auto-Liq.</param>
        /// <param name="flattenTimestamp">Flatten &amp;amp; Cancel.</param>
        /// <param name="trailingMaxDrawdown">$ Trailing Max Drawdown.</param>
        /// <param name="trailingMaxDrawdownLimit">$ Trailing Max Drawdown Limit.</param>
        /// <param name="trailingMaxDrawdownMode">EOD, RealTime.</param>
        /// <param name="dailyProfitAutoLiq">$ Daily Profit for an Auto-Liq.</param>
        /// <param name="weeklyProfitAutoLiq">$ Weekly Profit for an Auto-Liq.</param>
        /// <param name="doNotUnlock">Do not automatically unlock account if triggered.</param>
        public UserAccountAutoLiq(long? id = default(long?), bool? changesLocked = default(bool?), double? marginPercentageAlert = default(double?), double? dailyLossPercentageAlert = default(double?), double? dailyLossAlert = default(double?), double? marginPercentageLiqOnly = default(double?), double? dailyLossPercentageLiqOnly = default(double?), double? dailyLossLiqOnly = default(double?), double? marginPercentageAutoLiq = default(double?), double? dailyLossPercentageAutoLiq = default(double?), double? dailyLossAutoLiq = default(double?), double? weeklyLossAutoLiq = default(double?), DateTime? flattenTimestamp = default(DateTime?), double? trailingMaxDrawdown = default(double?), double? trailingMaxDrawdownLimit = default(double?), TrailingMaxDrawdownModeEnum? trailingMaxDrawdownMode = default(TrailingMaxDrawdownModeEnum?), double? dailyProfitAutoLiq = default(double?), double? weeklyProfitAutoLiq = default(double?), bool? doNotUnlock = default(bool?))
        {
            this.Id = id;
            this.ChangesLocked = changesLocked;
            this.MarginPercentageAlert = marginPercentageAlert;
            this.DailyLossPercentageAlert = dailyLossPercentageAlert;
            this.DailyLossAlert = dailyLossAlert;
            this.MarginPercentageLiqOnly = marginPercentageLiqOnly;
            this.DailyLossPercentageLiqOnly = dailyLossPercentageLiqOnly;
            this.DailyLossLiqOnly = dailyLossLiqOnly;
            this.MarginPercentageAutoLiq = marginPercentageAutoLiq;
            this.DailyLossPercentageAutoLiq = dailyLossPercentageAutoLiq;
            this.DailyLossAutoLiq = dailyLossAutoLiq;
            this.WeeklyLossAutoLiq = weeklyLossAutoLiq;
            this.FlattenTimestamp = flattenTimestamp;
            this.TrailingMaxDrawdown = trailingMaxDrawdown;
            this.TrailingMaxDrawdownLimit = trailingMaxDrawdownLimit;
            this.TrailingMaxDrawdownMode = trailingMaxDrawdownMode;
            this.DailyProfitAutoLiq = dailyProfitAutoLiq;
            this.WeeklyProfitAutoLiq = weeklyProfitAutoLiq;
            this.DoNotUnlock = doNotUnlock;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Changes Locked
        /// </summary>
        /// <value>Changes Locked</value>
        [DataMember(Name="changesLocked", EmitDefaultValue=false)]
        public bool? ChangesLocked { get; set; }

        /// <summary>
        /// Margin % for an Alert
        /// </summary>
        /// <value>Margin % for an Alert</value>
        [DataMember(Name="marginPercentageAlert", EmitDefaultValue=false)]
        public double? MarginPercentageAlert { get; set; }

        /// <summary>
        /// Daily Loss % for an Alert
        /// </summary>
        /// <value>Daily Loss % for an Alert</value>
        [DataMember(Name="dailyLossPercentageAlert", EmitDefaultValue=false)]
        public double? DailyLossPercentageAlert { get; set; }

        /// <summary>
        /// $ Daily Loss for an Alert
        /// </summary>
        /// <value>$ Daily Loss for an Alert</value>
        [DataMember(Name="dailyLossAlert", EmitDefaultValue=false)]
        public double? DailyLossAlert { get; set; }

        /// <summary>
        /// Margin % for an Liq Only
        /// </summary>
        /// <value>Margin % for an Liq Only</value>
        [DataMember(Name="marginPercentageLiqOnly", EmitDefaultValue=false)]
        public double? MarginPercentageLiqOnly { get; set; }

        /// <summary>
        /// Daily Loss % for an Liq Only
        /// </summary>
        /// <value>Daily Loss % for an Liq Only</value>
        [DataMember(Name="dailyLossPercentageLiqOnly", EmitDefaultValue=false)]
        public double? DailyLossPercentageLiqOnly { get; set; }

        /// <summary>
        /// $ Daily Loss for an Liq Only
        /// </summary>
        /// <value>$ Daily Loss for an Liq Only</value>
        [DataMember(Name="dailyLossLiqOnly", EmitDefaultValue=false)]
        public double? DailyLossLiqOnly { get; set; }

        /// <summary>
        /// Margin % for an Auto-Liq
        /// </summary>
        /// <value>Margin % for an Auto-Liq</value>
        [DataMember(Name="marginPercentageAutoLiq", EmitDefaultValue=false)]
        public double? MarginPercentageAutoLiq { get; set; }

        /// <summary>
        /// Daily Loss % for an AutoLiq
        /// </summary>
        /// <value>Daily Loss % for an AutoLiq</value>
        [DataMember(Name="dailyLossPercentageAutoLiq", EmitDefaultValue=false)]
        public double? DailyLossPercentageAutoLiq { get; set; }

        /// <summary>
        /// $ Daily Loss for an Auto-Liq
        /// </summary>
        /// <value>$ Daily Loss for an Auto-Liq</value>
        [DataMember(Name="dailyLossAutoLiq", EmitDefaultValue=false)]
        public double? DailyLossAutoLiq { get; set; }

        /// <summary>
        /// $ Weekly Loss for an Auto-Liq
        /// </summary>
        /// <value>$ Weekly Loss for an Auto-Liq</value>
        [DataMember(Name="weeklyLossAutoLiq", EmitDefaultValue=false)]
        public double? WeeklyLossAutoLiq { get; set; }

        /// <summary>
        /// Flatten &amp;amp; Cancel
        /// </summary>
        /// <value>Flatten &amp;amp; Cancel</value>
        [DataMember(Name="flattenTimestamp", EmitDefaultValue=false)]
        public DateTime? FlattenTimestamp { get; set; }

        /// <summary>
        /// $ Trailing Max Drawdown
        /// </summary>
        /// <value>$ Trailing Max Drawdown</value>
        [DataMember(Name="trailingMaxDrawdown", EmitDefaultValue=false)]
        public double? TrailingMaxDrawdown { get; set; }

        /// <summary>
        /// $ Trailing Max Drawdown Limit
        /// </summary>
        /// <value>$ Trailing Max Drawdown Limit</value>
        [DataMember(Name="trailingMaxDrawdownLimit", EmitDefaultValue=false)]
        public double? TrailingMaxDrawdownLimit { get; set; }


        /// <summary>
        /// $ Daily Profit for an Auto-Liq
        /// </summary>
        /// <value>$ Daily Profit for an Auto-Liq</value>
        [DataMember(Name="dailyProfitAutoLiq", EmitDefaultValue=false)]
        public double? DailyProfitAutoLiq { get; set; }

        /// <summary>
        /// $ Weekly Profit for an Auto-Liq
        /// </summary>
        /// <value>$ Weekly Profit for an Auto-Liq</value>
        [DataMember(Name="weeklyProfitAutoLiq", EmitDefaultValue=false)]
        public double? WeeklyProfitAutoLiq { get; set; }

        /// <summary>
        /// Do not automatically unlock account if triggered
        /// </summary>
        /// <value>Do not automatically unlock account if triggered</value>
        [DataMember(Name="doNotUnlock", EmitDefaultValue=false)]
        public bool? DoNotUnlock { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAccountAutoLiq {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ChangesLocked: ").Append(ChangesLocked).Append("\n");
            sb.Append("  MarginPercentageAlert: ").Append(MarginPercentageAlert).Append("\n");
            sb.Append("  DailyLossPercentageAlert: ").Append(DailyLossPercentageAlert).Append("\n");
            sb.Append("  DailyLossAlert: ").Append(DailyLossAlert).Append("\n");
            sb.Append("  MarginPercentageLiqOnly: ").Append(MarginPercentageLiqOnly).Append("\n");
            sb.Append("  DailyLossPercentageLiqOnly: ").Append(DailyLossPercentageLiqOnly).Append("\n");
            sb.Append("  DailyLossLiqOnly: ").Append(DailyLossLiqOnly).Append("\n");
            sb.Append("  MarginPercentageAutoLiq: ").Append(MarginPercentageAutoLiq).Append("\n");
            sb.Append("  DailyLossPercentageAutoLiq: ").Append(DailyLossPercentageAutoLiq).Append("\n");
            sb.Append("  DailyLossAutoLiq: ").Append(DailyLossAutoLiq).Append("\n");
            sb.Append("  WeeklyLossAutoLiq: ").Append(WeeklyLossAutoLiq).Append("\n");
            sb.Append("  FlattenTimestamp: ").Append(FlattenTimestamp).Append("\n");
            sb.Append("  TrailingMaxDrawdown: ").Append(TrailingMaxDrawdown).Append("\n");
            sb.Append("  TrailingMaxDrawdownLimit: ").Append(TrailingMaxDrawdownLimit).Append("\n");
            sb.Append("  TrailingMaxDrawdownMode: ").Append(TrailingMaxDrawdownMode).Append("\n");
            sb.Append("  DailyProfitAutoLiq: ").Append(DailyProfitAutoLiq).Append("\n");
            sb.Append("  WeeklyProfitAutoLiq: ").Append(WeeklyProfitAutoLiq).Append("\n");
            sb.Append("  DoNotUnlock: ").Append(DoNotUnlock).Append("\n");
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
            return this.Equals(input as UserAccountAutoLiq);
        }

        /// <summary>
        /// Returns true if UserAccountAutoLiq instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAccountAutoLiq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAccountAutoLiq input)
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
                    this.ChangesLocked == input.ChangesLocked ||
                    (this.ChangesLocked != null &&
                    this.ChangesLocked.Equals(input.ChangesLocked))
                ) && 
                (
                    this.MarginPercentageAlert == input.MarginPercentageAlert ||
                    (this.MarginPercentageAlert != null &&
                    this.MarginPercentageAlert.Equals(input.MarginPercentageAlert))
                ) && 
                (
                    this.DailyLossPercentageAlert == input.DailyLossPercentageAlert ||
                    (this.DailyLossPercentageAlert != null &&
                    this.DailyLossPercentageAlert.Equals(input.DailyLossPercentageAlert))
                ) && 
                (
                    this.DailyLossAlert == input.DailyLossAlert ||
                    (this.DailyLossAlert != null &&
                    this.DailyLossAlert.Equals(input.DailyLossAlert))
                ) && 
                (
                    this.MarginPercentageLiqOnly == input.MarginPercentageLiqOnly ||
                    (this.MarginPercentageLiqOnly != null &&
                    this.MarginPercentageLiqOnly.Equals(input.MarginPercentageLiqOnly))
                ) && 
                (
                    this.DailyLossPercentageLiqOnly == input.DailyLossPercentageLiqOnly ||
                    (this.DailyLossPercentageLiqOnly != null &&
                    this.DailyLossPercentageLiqOnly.Equals(input.DailyLossPercentageLiqOnly))
                ) && 
                (
                    this.DailyLossLiqOnly == input.DailyLossLiqOnly ||
                    (this.DailyLossLiqOnly != null &&
                    this.DailyLossLiqOnly.Equals(input.DailyLossLiqOnly))
                ) && 
                (
                    this.MarginPercentageAutoLiq == input.MarginPercentageAutoLiq ||
                    (this.MarginPercentageAutoLiq != null &&
                    this.MarginPercentageAutoLiq.Equals(input.MarginPercentageAutoLiq))
                ) && 
                (
                    this.DailyLossPercentageAutoLiq == input.DailyLossPercentageAutoLiq ||
                    (this.DailyLossPercentageAutoLiq != null &&
                    this.DailyLossPercentageAutoLiq.Equals(input.DailyLossPercentageAutoLiq))
                ) && 
                (
                    this.DailyLossAutoLiq == input.DailyLossAutoLiq ||
                    (this.DailyLossAutoLiq != null &&
                    this.DailyLossAutoLiq.Equals(input.DailyLossAutoLiq))
                ) && 
                (
                    this.WeeklyLossAutoLiq == input.WeeklyLossAutoLiq ||
                    (this.WeeklyLossAutoLiq != null &&
                    this.WeeklyLossAutoLiq.Equals(input.WeeklyLossAutoLiq))
                ) && 
                (
                    this.FlattenTimestamp == input.FlattenTimestamp ||
                    (this.FlattenTimestamp != null &&
                    this.FlattenTimestamp.Equals(input.FlattenTimestamp))
                ) && 
                (
                    this.TrailingMaxDrawdown == input.TrailingMaxDrawdown ||
                    (this.TrailingMaxDrawdown != null &&
                    this.TrailingMaxDrawdown.Equals(input.TrailingMaxDrawdown))
                ) && 
                (
                    this.TrailingMaxDrawdownLimit == input.TrailingMaxDrawdownLimit ||
                    (this.TrailingMaxDrawdownLimit != null &&
                    this.TrailingMaxDrawdownLimit.Equals(input.TrailingMaxDrawdownLimit))
                ) && 
                (
                    this.TrailingMaxDrawdownMode == input.TrailingMaxDrawdownMode ||
                    (this.TrailingMaxDrawdownMode != null &&
                    this.TrailingMaxDrawdownMode.Equals(input.TrailingMaxDrawdownMode))
                ) && 
                (
                    this.DailyProfitAutoLiq == input.DailyProfitAutoLiq ||
                    (this.DailyProfitAutoLiq != null &&
                    this.DailyProfitAutoLiq.Equals(input.DailyProfitAutoLiq))
                ) && 
                (
                    this.WeeklyProfitAutoLiq == input.WeeklyProfitAutoLiq ||
                    (this.WeeklyProfitAutoLiq != null &&
                    this.WeeklyProfitAutoLiq.Equals(input.WeeklyProfitAutoLiq))
                ) && 
                (
                    this.DoNotUnlock == input.DoNotUnlock ||
                    (this.DoNotUnlock != null &&
                    this.DoNotUnlock.Equals(input.DoNotUnlock))
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
                if (this.ChangesLocked != null)
                    hashCode = hashCode * 59 + this.ChangesLocked.GetHashCode();
                if (this.MarginPercentageAlert != null)
                    hashCode = hashCode * 59 + this.MarginPercentageAlert.GetHashCode();
                if (this.DailyLossPercentageAlert != null)
                    hashCode = hashCode * 59 + this.DailyLossPercentageAlert.GetHashCode();
                if (this.DailyLossAlert != null)
                    hashCode = hashCode * 59 + this.DailyLossAlert.GetHashCode();
                if (this.MarginPercentageLiqOnly != null)
                    hashCode = hashCode * 59 + this.MarginPercentageLiqOnly.GetHashCode();
                if (this.DailyLossPercentageLiqOnly != null)
                    hashCode = hashCode * 59 + this.DailyLossPercentageLiqOnly.GetHashCode();
                if (this.DailyLossLiqOnly != null)
                    hashCode = hashCode * 59 + this.DailyLossLiqOnly.GetHashCode();
                if (this.MarginPercentageAutoLiq != null)
                    hashCode = hashCode * 59 + this.MarginPercentageAutoLiq.GetHashCode();
                if (this.DailyLossPercentageAutoLiq != null)
                    hashCode = hashCode * 59 + this.DailyLossPercentageAutoLiq.GetHashCode();
                if (this.DailyLossAutoLiq != null)
                    hashCode = hashCode * 59 + this.DailyLossAutoLiq.GetHashCode();
                if (this.WeeklyLossAutoLiq != null)
                    hashCode = hashCode * 59 + this.WeeklyLossAutoLiq.GetHashCode();
                if (this.FlattenTimestamp != null)
                    hashCode = hashCode * 59 + this.FlattenTimestamp.GetHashCode();
                if (this.TrailingMaxDrawdown != null)
                    hashCode = hashCode * 59 + this.TrailingMaxDrawdown.GetHashCode();
                if (this.TrailingMaxDrawdownLimit != null)
                    hashCode = hashCode * 59 + this.TrailingMaxDrawdownLimit.GetHashCode();
                if (this.TrailingMaxDrawdownMode != null)
                    hashCode = hashCode * 59 + this.TrailingMaxDrawdownMode.GetHashCode();
                if (this.DailyProfitAutoLiq != null)
                    hashCode = hashCode * 59 + this.DailyProfitAutoLiq.GetHashCode();
                if (this.WeeklyProfitAutoLiq != null)
                    hashCode = hashCode * 59 + this.WeeklyProfitAutoLiq.GetHashCode();
                if (this.DoNotUnlock != null)
                    hashCode = hashCode * 59 + this.DoNotUnlock.GetHashCode();
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

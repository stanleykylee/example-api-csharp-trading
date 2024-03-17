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
    /// SyncMessage
    /// </summary>
    [DataContract]
        public partial class SyncMessage :  IEquatable<SyncMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncMessage" /> class.
        /// </summary>
        /// <param name="users">users (required).</param>
        /// <param name="accounts">accounts.</param>
        /// <param name="accountRiskStatuses">accountRiskStatuses.</param>
        /// <param name="marginSnapshots">marginSnapshots.</param>
        /// <param name="userAccountAutoLiqs">userAccountAutoLiqs.</param>
        /// <param name="cashBalances">cashBalances.</param>
        /// <param name="currencies">currencies.</param>
        /// <param name="positions">positions.</param>
        /// <param name="fillPairs">fillPairs.</param>
        /// <param name="orders">orders.</param>
        /// <param name="contracts">contracts.</param>
        /// <param name="contractMaturities">contractMaturities.</param>
        /// <param name="products">products.</param>
        /// <param name="exchanges">exchanges.</param>
        /// <param name="spreadDefinitions">spreadDefinitions.</param>
        /// <param name="commands">commands.</param>
        /// <param name="commandReports">commandReports.</param>
        /// <param name="executionReports">executionReports.</param>
        /// <param name="orderVersions">orderVersions.</param>
        /// <param name="fills">fills.</param>
        /// <param name="orderStrategies">orderStrategies.</param>
        /// <param name="orderStrategyLinks">orderStrategyLinks.</param>
        /// <param name="userProperties">userProperties.</param>
        /// <param name="properties">properties.</param>
        /// <param name="userPlugins">userPlugins.</param>
        /// <param name="contractGroups">contractGroups (required).</param>
        /// <param name="orderStrategyTypes">orderStrategyTypes.</param>
        public SyncMessage(List<User> users = default(List<User>), List<Account> accounts = default(List<Account>), List<AccountRiskStatus> accountRiskStatuses = default(List<AccountRiskStatus>), List<MarginSnapshot> marginSnapshots = default(List<MarginSnapshot>), List<UserAccountAutoLiq> userAccountAutoLiqs = default(List<UserAccountAutoLiq>), List<CashBalance> cashBalances = default(List<CashBalance>), List<Currency> currencies = default(List<Currency>), List<Position> positions = default(List<Position>), List<FillPair> fillPairs = default(List<FillPair>), List<Order> orders = default(List<Order>), List<Contract> contracts = default(List<Contract>), List<ContractMaturity> contractMaturities = default(List<ContractMaturity>), List<Product> products = default(List<Product>), List<Exchange> exchanges = default(List<Exchange>), List<SpreadDefinition> spreadDefinitions = default(List<SpreadDefinition>), List<Command> commands = default(List<Command>), List<CommandReport> commandReports = default(List<CommandReport>), List<ExecutionReport> executionReports = default(List<ExecutionReport>), List<OrderVersion> orderVersions = default(List<OrderVersion>), List<Fill> fills = default(List<Fill>), List<OrderStrategy> orderStrategies = default(List<OrderStrategy>), List<OrderStrategyLink> orderStrategyLinks = default(List<OrderStrategyLink>), List<UserProperty> userProperties = default(List<UserProperty>), List<Property> properties = default(List<Property>), List<UserPlugin> userPlugins = default(List<UserPlugin>), List<ContractGroup> contractGroups = default(List<ContractGroup>), List<OrderStrategyType> orderStrategyTypes = default(List<OrderStrategyType>))
        {
            // to ensure "users" is required (not null)
            if (users == null)
            {
                throw new InvalidDataException("users is a required property for SyncMessage and cannot be null");
            }
            else
            {
                this.Users = users;
            }
            // to ensure "contractGroups" is required (not null)
            if (contractGroups == null)
            {
                throw new InvalidDataException("contractGroups is a required property for SyncMessage and cannot be null");
            }
            else
            {
                this.ContractGroups = contractGroups;
            }
            this.Accounts = accounts;
            this.AccountRiskStatuses = accountRiskStatuses;
            this.MarginSnapshots = marginSnapshots;
            this.UserAccountAutoLiqs = userAccountAutoLiqs;
            this.CashBalances = cashBalances;
            this.Currencies = currencies;
            this.Positions = positions;
            this.FillPairs = fillPairs;
            this.Orders = orders;
            this.Contracts = contracts;
            this.ContractMaturities = contractMaturities;
            this.Products = products;
            this.Exchanges = exchanges;
            this.SpreadDefinitions = spreadDefinitions;
            this.Commands = commands;
            this.CommandReports = commandReports;
            this.ExecutionReports = executionReports;
            this.OrderVersions = orderVersions;
            this.Fills = fills;
            this.OrderStrategies = orderStrategies;
            this.OrderStrategyLinks = orderStrategyLinks;
            this.UserProperties = userProperties;
            this.Properties = properties;
            this.UserPlugins = userPlugins;
            this.OrderStrategyTypes = orderStrategyTypes;
        }
        
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<User> Users { get; set; }

        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<Account> Accounts { get; set; }

        /// <summary>
        /// Gets or Sets AccountRiskStatuses
        /// </summary>
        [DataMember(Name="accountRiskStatuses", EmitDefaultValue=false)]
        public List<AccountRiskStatus> AccountRiskStatuses { get; set; }

        /// <summary>
        /// Gets or Sets MarginSnapshots
        /// </summary>
        [DataMember(Name="marginSnapshots", EmitDefaultValue=false)]
        public List<MarginSnapshot> MarginSnapshots { get; set; }

        /// <summary>
        /// Gets or Sets UserAccountAutoLiqs
        /// </summary>
        [DataMember(Name="userAccountAutoLiqs", EmitDefaultValue=false)]
        public List<UserAccountAutoLiq> UserAccountAutoLiqs { get; set; }

        /// <summary>
        /// Gets or Sets CashBalances
        /// </summary>
        [DataMember(Name="cashBalances", EmitDefaultValue=false)]
        public List<CashBalance> CashBalances { get; set; }

        /// <summary>
        /// Gets or Sets Currencies
        /// </summary>
        [DataMember(Name="currencies", EmitDefaultValue=false)]
        public List<Currency> Currencies { get; set; }

        /// <summary>
        /// Gets or Sets Positions
        /// </summary>
        [DataMember(Name="positions", EmitDefaultValue=false)]
        public List<Position> Positions { get; set; }

        /// <summary>
        /// Gets or Sets FillPairs
        /// </summary>
        [DataMember(Name="fillPairs", EmitDefaultValue=false)]
        public List<FillPair> FillPairs { get; set; }

        /// <summary>
        /// Gets or Sets Orders
        /// </summary>
        [DataMember(Name="orders", EmitDefaultValue=false)]
        public List<Order> Orders { get; set; }

        /// <summary>
        /// Gets or Sets Contracts
        /// </summary>
        [DataMember(Name="contracts", EmitDefaultValue=false)]
        public List<Contract> Contracts { get; set; }

        /// <summary>
        /// Gets or Sets ContractMaturities
        /// </summary>
        [DataMember(Name="contractMaturities", EmitDefaultValue=false)]
        public List<ContractMaturity> ContractMaturities { get; set; }

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name="products", EmitDefaultValue=false)]
        public List<Product> Products { get; set; }

        /// <summary>
        /// Gets or Sets Exchanges
        /// </summary>
        [DataMember(Name="exchanges", EmitDefaultValue=false)]
        public List<Exchange> Exchanges { get; set; }

        /// <summary>
        /// Gets or Sets SpreadDefinitions
        /// </summary>
        [DataMember(Name="spreadDefinitions", EmitDefaultValue=false)]
        public List<SpreadDefinition> SpreadDefinitions { get; set; }

        /// <summary>
        /// Gets or Sets Commands
        /// </summary>
        [DataMember(Name="commands", EmitDefaultValue=false)]
        public List<Command> Commands { get; set; }

        /// <summary>
        /// Gets or Sets CommandReports
        /// </summary>
        [DataMember(Name="commandReports", EmitDefaultValue=false)]
        public List<CommandReport> CommandReports { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionReports
        /// </summary>
        [DataMember(Name="executionReports", EmitDefaultValue=false)]
        public List<ExecutionReport> ExecutionReports { get; set; }

        /// <summary>
        /// Gets or Sets OrderVersions
        /// </summary>
        [DataMember(Name="orderVersions", EmitDefaultValue=false)]
        public List<OrderVersion> OrderVersions { get; set; }

        /// <summary>
        /// Gets or Sets Fills
        /// </summary>
        [DataMember(Name="fills", EmitDefaultValue=false)]
        public List<Fill> Fills { get; set; }

        /// <summary>
        /// Gets or Sets OrderStrategies
        /// </summary>
        [DataMember(Name="orderStrategies", EmitDefaultValue=false)]
        public List<OrderStrategy> OrderStrategies { get; set; }

        /// <summary>
        /// Gets or Sets OrderStrategyLinks
        /// </summary>
        [DataMember(Name="orderStrategyLinks", EmitDefaultValue=false)]
        public List<OrderStrategyLink> OrderStrategyLinks { get; set; }

        /// <summary>
        /// Gets or Sets UserProperties
        /// </summary>
        [DataMember(Name="userProperties", EmitDefaultValue=false)]
        public List<UserProperty> UserProperties { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<Property> Properties { get; set; }

        /// <summary>
        /// Gets or Sets UserPlugins
        /// </summary>
        [DataMember(Name="userPlugins", EmitDefaultValue=false)]
        public List<UserPlugin> UserPlugins { get; set; }

        /// <summary>
        /// Gets or Sets ContractGroups
        /// </summary>
        [DataMember(Name="contractGroups", EmitDefaultValue=false)]
        public List<ContractGroup> ContractGroups { get; set; }

        /// <summary>
        /// Gets or Sets OrderStrategyTypes
        /// </summary>
        [DataMember(Name="orderStrategyTypes", EmitDefaultValue=false)]
        public List<OrderStrategyType> OrderStrategyTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SyncMessage {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  AccountRiskStatuses: ").Append(AccountRiskStatuses).Append("\n");
            sb.Append("  MarginSnapshots: ").Append(MarginSnapshots).Append("\n");
            sb.Append("  UserAccountAutoLiqs: ").Append(UserAccountAutoLiqs).Append("\n");
            sb.Append("  CashBalances: ").Append(CashBalances).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
            sb.Append("  Positions: ").Append(Positions).Append("\n");
            sb.Append("  FillPairs: ").Append(FillPairs).Append("\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
            sb.Append("  Contracts: ").Append(Contracts).Append("\n");
            sb.Append("  ContractMaturities: ").Append(ContractMaturities).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  Exchanges: ").Append(Exchanges).Append("\n");
            sb.Append("  SpreadDefinitions: ").Append(SpreadDefinitions).Append("\n");
            sb.Append("  Commands: ").Append(Commands).Append("\n");
            sb.Append("  CommandReports: ").Append(CommandReports).Append("\n");
            sb.Append("  ExecutionReports: ").Append(ExecutionReports).Append("\n");
            sb.Append("  OrderVersions: ").Append(OrderVersions).Append("\n");
            sb.Append("  Fills: ").Append(Fills).Append("\n");
            sb.Append("  OrderStrategies: ").Append(OrderStrategies).Append("\n");
            sb.Append("  OrderStrategyLinks: ").Append(OrderStrategyLinks).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  UserPlugins: ").Append(UserPlugins).Append("\n");
            sb.Append("  ContractGroups: ").Append(ContractGroups).Append("\n");
            sb.Append("  OrderStrategyTypes: ").Append(OrderStrategyTypes).Append("\n");
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
            return this.Equals(input as SyncMessage);
        }

        /// <summary>
        /// Returns true if SyncMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of SyncMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyncMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.SequenceEqual(input.Users)
                ) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.AccountRiskStatuses == input.AccountRiskStatuses ||
                    this.AccountRiskStatuses != null &&
                    input.AccountRiskStatuses != null &&
                    this.AccountRiskStatuses.SequenceEqual(input.AccountRiskStatuses)
                ) && 
                (
                    this.MarginSnapshots == input.MarginSnapshots ||
                    this.MarginSnapshots != null &&
                    input.MarginSnapshots != null &&
                    this.MarginSnapshots.SequenceEqual(input.MarginSnapshots)
                ) && 
                (
                    this.UserAccountAutoLiqs == input.UserAccountAutoLiqs ||
                    this.UserAccountAutoLiqs != null &&
                    input.UserAccountAutoLiqs != null &&
                    this.UserAccountAutoLiqs.SequenceEqual(input.UserAccountAutoLiqs)
                ) && 
                (
                    this.CashBalances == input.CashBalances ||
                    this.CashBalances != null &&
                    input.CashBalances != null &&
                    this.CashBalances.SequenceEqual(input.CashBalances)
                ) && 
                (
                    this.Currencies == input.Currencies ||
                    this.Currencies != null &&
                    input.Currencies != null &&
                    this.Currencies.SequenceEqual(input.Currencies)
                ) && 
                (
                    this.Positions == input.Positions ||
                    this.Positions != null &&
                    input.Positions != null &&
                    this.Positions.SequenceEqual(input.Positions)
                ) && 
                (
                    this.FillPairs == input.FillPairs ||
                    this.FillPairs != null &&
                    input.FillPairs != null &&
                    this.FillPairs.SequenceEqual(input.FillPairs)
                ) && 
                (
                    this.Orders == input.Orders ||
                    this.Orders != null &&
                    input.Orders != null &&
                    this.Orders.SequenceEqual(input.Orders)
                ) && 
                (
                    this.Contracts == input.Contracts ||
                    this.Contracts != null &&
                    input.Contracts != null &&
                    this.Contracts.SequenceEqual(input.Contracts)
                ) && 
                (
                    this.ContractMaturities == input.ContractMaturities ||
                    this.ContractMaturities != null &&
                    input.ContractMaturities != null &&
                    this.ContractMaturities.SequenceEqual(input.ContractMaturities)
                ) && 
                (
                    this.Products == input.Products ||
                    this.Products != null &&
                    input.Products != null &&
                    this.Products.SequenceEqual(input.Products)
                ) && 
                (
                    this.Exchanges == input.Exchanges ||
                    this.Exchanges != null &&
                    input.Exchanges != null &&
                    this.Exchanges.SequenceEqual(input.Exchanges)
                ) && 
                (
                    this.SpreadDefinitions == input.SpreadDefinitions ||
                    this.SpreadDefinitions != null &&
                    input.SpreadDefinitions != null &&
                    this.SpreadDefinitions.SequenceEqual(input.SpreadDefinitions)
                ) && 
                (
                    this.Commands == input.Commands ||
                    this.Commands != null &&
                    input.Commands != null &&
                    this.Commands.SequenceEqual(input.Commands)
                ) && 
                (
                    this.CommandReports == input.CommandReports ||
                    this.CommandReports != null &&
                    input.CommandReports != null &&
                    this.CommandReports.SequenceEqual(input.CommandReports)
                ) && 
                (
                    this.ExecutionReports == input.ExecutionReports ||
                    this.ExecutionReports != null &&
                    input.ExecutionReports != null &&
                    this.ExecutionReports.SequenceEqual(input.ExecutionReports)
                ) && 
                (
                    this.OrderVersions == input.OrderVersions ||
                    this.OrderVersions != null &&
                    input.OrderVersions != null &&
                    this.OrderVersions.SequenceEqual(input.OrderVersions)
                ) && 
                (
                    this.Fills == input.Fills ||
                    this.Fills != null &&
                    input.Fills != null &&
                    this.Fills.SequenceEqual(input.Fills)
                ) && 
                (
                    this.OrderStrategies == input.OrderStrategies ||
                    this.OrderStrategies != null &&
                    input.OrderStrategies != null &&
                    this.OrderStrategies.SequenceEqual(input.OrderStrategies)
                ) && 
                (
                    this.OrderStrategyLinks == input.OrderStrategyLinks ||
                    this.OrderStrategyLinks != null &&
                    input.OrderStrategyLinks != null &&
                    this.OrderStrategyLinks.SequenceEqual(input.OrderStrategyLinks)
                ) && 
                (
                    this.UserProperties == input.UserProperties ||
                    this.UserProperties != null &&
                    input.UserProperties != null &&
                    this.UserProperties.SequenceEqual(input.UserProperties)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.UserPlugins == input.UserPlugins ||
                    this.UserPlugins != null &&
                    input.UserPlugins != null &&
                    this.UserPlugins.SequenceEqual(input.UserPlugins)
                ) && 
                (
                    this.ContractGroups == input.ContractGroups ||
                    this.ContractGroups != null &&
                    input.ContractGroups != null &&
                    this.ContractGroups.SequenceEqual(input.ContractGroups)
                ) && 
                (
                    this.OrderStrategyTypes == input.OrderStrategyTypes ||
                    this.OrderStrategyTypes != null &&
                    input.OrderStrategyTypes != null &&
                    this.OrderStrategyTypes.SequenceEqual(input.OrderStrategyTypes)
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
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                if (this.AccountRiskStatuses != null)
                    hashCode = hashCode * 59 + this.AccountRiskStatuses.GetHashCode();
                if (this.MarginSnapshots != null)
                    hashCode = hashCode * 59 + this.MarginSnapshots.GetHashCode();
                if (this.UserAccountAutoLiqs != null)
                    hashCode = hashCode * 59 + this.UserAccountAutoLiqs.GetHashCode();
                if (this.CashBalances != null)
                    hashCode = hashCode * 59 + this.CashBalances.GetHashCode();
                if (this.Currencies != null)
                    hashCode = hashCode * 59 + this.Currencies.GetHashCode();
                if (this.Positions != null)
                    hashCode = hashCode * 59 + this.Positions.GetHashCode();
                if (this.FillPairs != null)
                    hashCode = hashCode * 59 + this.FillPairs.GetHashCode();
                if (this.Orders != null)
                    hashCode = hashCode * 59 + this.Orders.GetHashCode();
                if (this.Contracts != null)
                    hashCode = hashCode * 59 + this.Contracts.GetHashCode();
                if (this.ContractMaturities != null)
                    hashCode = hashCode * 59 + this.ContractMaturities.GetHashCode();
                if (this.Products != null)
                    hashCode = hashCode * 59 + this.Products.GetHashCode();
                if (this.Exchanges != null)
                    hashCode = hashCode * 59 + this.Exchanges.GetHashCode();
                if (this.SpreadDefinitions != null)
                    hashCode = hashCode * 59 + this.SpreadDefinitions.GetHashCode();
                if (this.Commands != null)
                    hashCode = hashCode * 59 + this.Commands.GetHashCode();
                if (this.CommandReports != null)
                    hashCode = hashCode * 59 + this.CommandReports.GetHashCode();
                if (this.ExecutionReports != null)
                    hashCode = hashCode * 59 + this.ExecutionReports.GetHashCode();
                if (this.OrderVersions != null)
                    hashCode = hashCode * 59 + this.OrderVersions.GetHashCode();
                if (this.Fills != null)
                    hashCode = hashCode * 59 + this.Fills.GetHashCode();
                if (this.OrderStrategies != null)
                    hashCode = hashCode * 59 + this.OrderStrategies.GetHashCode();
                if (this.OrderStrategyLinks != null)
                    hashCode = hashCode * 59 + this.OrderStrategyLinks.GetHashCode();
                if (this.UserProperties != null)
                    hashCode = hashCode * 59 + this.UserProperties.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.UserPlugins != null)
                    hashCode = hashCode * 59 + this.UserPlugins.GetHashCode();
                if (this.ContractGroups != null)
                    hashCode = hashCode * 59 + this.ContractGroups.GetHashCode();
                if (this.OrderStrategyTypes != null)
                    hashCode = hashCode * 59 + this.OrderStrategyTypes.GetHashCode();
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

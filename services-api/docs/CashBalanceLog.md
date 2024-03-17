# Tradovate.Services.Model.CashBalanceLog
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** |  | [optional] 
**AccountId** | **long?** |  | 
**Timestamp** | **DateTime?** |  | 
**TradeDate** | [**TradeDate**](TradeDate.md) |  | 
**CurrencyId** | **long?** |  | 
**Amount** | **double?** |  | 
**RealizedPnL** | **double?** |  | [optional] 
**WeekRealizedPnL** | **double?** |  | [optional] 
**CashChangeType** | **string** | AccountClosureFee, AddUserFee, AutomaticReconciliation, BrokerageFee, CancelledPairedTrade, CashSettlement, ClearingFee, Commission, Courtesy, Debit, DepositFee, DeskFee, DormantFee, EntitlementSubscription, Escheatment, ExchangeFee, FundTransaction, FundTransactionFee, GoodwillCredit, IPFee, InactivityFee, LiquidationFee, LiquidationFee2, ManualAdjustment, MarketDataSubscription, NewSession, NfaFee, NsfCheckFee, OptionsTrade, OrderRoutingFee, PROMO, RithmicFee, SeatLeasePayment, StopPaymentFee, ThirdPartyFee, TradePaired, TradovateSubscription | 
**FillPairId** | **long?** |  | [optional] 
**FillId** | **long?** |  | [optional] 
**FundTransactionId** | **long?** |  | [optional] 
**Comment** | **string** |  | [optional] 
**Delta** | **double?** |  | 
**SenderId** | **long?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


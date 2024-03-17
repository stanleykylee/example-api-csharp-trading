# Tradovate.Services.Api.PricesApi

All URIs are relative to *https://demo.tradovateapi.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeSpeed**](PricesApi.md#changespeed) | **POST** /replay/changespeed | 
[**CheckReplaySession**](PricesApi.md#checkreplaysession) | **POST** /replay/checkreplaysession | 
[**InitializeClock**](PricesApi.md#initializeclock) | **POST** /replay/initializeclock | 

<a name="changespeed"></a>
# **ChangeSpeed**
> SimpleResponse ChangeSpeed (ChangeSpeed body)



### Change the playback speed of a Market Replay session.

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ChangeSpeedExample
    {
        public void main()
        {

            var apiInstance = new PricesApi();
            var body = new ChangeSpeed(); // ChangeSpeed | 

            try
            {
                SimpleResponse result = apiInstance.ChangeSpeed(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.ChangeSpeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ChangeSpeed**](ChangeSpeed.md)|  | 

### Return type

[**SimpleResponse**](SimpleResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="checkreplaysession"></a>
# **CheckReplaySession**
> CheckReplaySessionResponse CheckReplaySession (CheckReplaySession body)



### Before beginning a Market Replay session, call this endpoint to check that the given timeframe is valid within the scope of the user's entitlements. You should use this endpoint from a WebSocket hooked up to the Market Replay URL.  ```js  const URL = 'wss://replay.tradovateapi.com/v1/websocket'  const myMarketReplaySocket = new WebSocket(URL)  //simple WebSocket authorization procedure myMarketReplaySocket.onopen = function() {     myMarketReplaySocket.send(`authorize\\n0\\n\\n${accessToken}`) })  //JSON string for midnight April 30th 2018 const startTimestamp = new Date('2018-04-30').toJSON() myMarketReplaySocket.send(`replay/checkreplaysession\\n1\\n\\n${JSON.stringify({startTimestamp})}`)  //listen for response myMarketReplaySocket.addEventListener('message', msg => {     const datas = JSON.parse(msg.data.slice(1)) //chop off leading 'frame' char     //datas looks like this [{s: 200, i: 1, d: { checkStatus: 'OK' } }]     if(datas) {         datas.forEach(({i, d}) => {             if(i && i === 1)  { //id of our sent message is 1, response's `i` field will be 1.                 console.log(d) //=> { checkStatus: 'OK' }                 //if the status is OK we can send the initializeClock message             }         })     }  }  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CheckReplaySessionExample
    {
        public void main()
        {

            var apiInstance = new PricesApi();
            var body = new CheckReplaySession(); // CheckReplaySession | 

            try
            {
                CheckReplaySessionResponse result = apiInstance.CheckReplaySession(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.CheckReplaySession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CheckReplaySession**](CheckReplaySession.md)|  | 

### Return type

[**CheckReplaySessionResponse**](CheckReplaySessionResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="initializeclock"></a>
# **InitializeClock**
> SimpleResponse InitializeClock (InitializeClock body)



### Set the inital date and time for a market replay session. Using a WebSocket connected to the Tradovate Market Replay URL, we can start a Market Replay Session which will simulate a given timeframe as if it were happening live. Each replay session creates a new replay account which gets discarded at the end of the replay session. ```js  const URL = 'wss://replay.tradovateapi.com/v1/websocket'  const myMarketReplaySocket = new WebSocket(URL)  //simple WebSocket authorization procedure myMarketReplaySocket.onOpen = function onOpen() {     myMarketReplaySocket.send(`authorize\\n0\\n\\n${accessToken}`) })  const requestBody = {     startTimestamp: new Date('2018-04-30').toJSON(),     speed: 100, //100%, range is from 0-400%     initialBalance: 50000 //account balance for replay session }  myMarketReplaySocket.send(`replay/initializeclock\\n1\\n\\n${JSON.stringify(requestBody)}`)  myMarketReplaySocket.addEventListener('message', msg => {     const datas = JSON.parse(msg.data.slice(1))     if(datas) {         datas.forEach(({i, d}) => {             if(i && i === 1) { //sent id is 1, response id will be 1                 console.log(d) //=> { ok: true }             }         })     } })  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class InitializeClockExample
    {
        public void main()
        {

            var apiInstance = new PricesApi();
            var body = new InitializeClock(); // InitializeClock | 

            try
            {
                SimpleResponse result = apiInstance.InitializeClock(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.InitializeClock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InitializeClock**](InitializeClock.md)|  | 

### Return type

[**SimpleResponse**](SimpleResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

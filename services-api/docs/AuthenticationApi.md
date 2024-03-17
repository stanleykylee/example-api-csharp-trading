# Tradovate.Services.Api.AuthenticationApi

All URIs are relative to *https://demo.tradovateapi.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccessTokenRequest**](AuthenticationApi.md#accesstokenrequest) | **POST** /auth/accesstokenrequest | 
[**Me**](AuthenticationApi.md#me) | **GET** /auth/me | 
[**OAuthToken**](AuthenticationApi.md#oauthtoken) | **POST** /auth/oauthtoken | 
[**RenewAccessToken**](AuthenticationApi.md#renewaccesstoken) | **GET** /auth/renewaccesstoken | 

<a name="accesstokenrequest"></a>
# **AccessTokenRequest**
> AccessTokenResponse AccessTokenRequest (AccessTokenRequest body)



#### Request an access token using your user credentials and API Key.   See the [Access](/#tag/Access) section for more details. For a comprehensive guide on how to acquire and use an access token in the JavaScript language, see out [JavaScript tutorial](https://github.com/tradovate/example-api-js) repository. For usage examples using the C# language, see the [C# example](https://github.com/tradovate/example-api-csharp-trading) repository.  ### Acquiring an Access Token  ```js const URL = 'https://live.tradovateapi.com/v1'  const credentials = {     name:       \"Your credentials here\",     password:   \"Your credentials here\",     appId:      \"Sample App\",     appVersion: \"1.0\",     cid:        0,     sec:        \"Your API secret here\" }  async function getAccessToken() {     let response = await fetch(URL + '/auth/accessTokenRequest', {         method: 'POST',         headers: {             'Content-Type': 'application/json'         }     })     let result = await response.json()     return result // { accessToken, mdAccessToken, userId, ... } }  //...  async function main() {     const { accessToken, mdAccessToken, userId } = await getAccessToken()      //use access token } ```  ### Using an Access Token  ```js //use the Authorization: Bearer schema in API POST and GET requests  //simple /account/list endpoint requires no body or query async function getAccounts() {     let response = await fetch(URL + '/account/list', {         method: 'GET',         headers: {             'Content-Type': 'application/json',             Authorization: `Bearer ${accessToken}` //Access Token use in HTTP requests         }     })     let result = await response.json()     return result }  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AccessTokenRequestExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var body = new AccessTokenRequest(); // AccessTokenRequest | 

            try
            {
                AccessTokenResponse result = apiInstance.AccessTokenRequest(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AccessTokenRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccessTokenRequest**](AccessTokenRequest.md)|  | 

### Return type

[**AccessTokenResponse**](AccessTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="me"></a>
# **Me**
> OAuthMeResponse Me ()



### Shows Basic user data for the calling user.

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MeExample
    {
        public void main()
        {

            var apiInstance = new AuthenticationApi();

            try
            {
                OAuthMeResponse result = apiInstance.Me();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Me: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OAuthMeResponse**](OAuthMeResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="oauthtoken"></a>
# **OAuthToken**
> OAuthTokenResponse OAuthToken (OAuthToken body)



### Used to exchange your OAuth code for an access token. Using the OAuth authorization delegation flow, we can send a request to verify that our users are who they say they are. For more information on using OAuth with the Tradovate API see our [OAuth JavaScript tutorial](https://github.com/tradovate/example-api-oauth).

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OAuthTokenExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var body = new OAuthToken(); // OAuthToken | 

            try
            {
                OAuthTokenResponse result = apiInstance.OAuthToken(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.OAuthToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OAuthToken**](OAuthToken.md)|  | 

### Return type

[**OAuthTokenResponse**](OAuthTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renewaccesstoken"></a>
# **RenewAccessToken**
> AccessTokenResponse RenewAccessToken ()



### Request a renewal for an existing access token.

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class RenewAccessTokenExample
    {
        public void main()
        {

            var apiInstance = new AuthenticationApi();

            try
            {
                AccessTokenResponse result = apiInstance.RenewAccessToken();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.RenewAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AccessTokenResponse**](AccessTokenResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

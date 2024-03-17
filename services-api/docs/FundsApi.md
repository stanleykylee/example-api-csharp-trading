# Tradovate.Services.Api.FundsApi

All URIs are relative to *https://demo.tradovateapi.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckStripeFundingEligibility**](FundsApi.md#checkstripefundingeligibility) | **POST** /fundTransaction/checkstripefundingeligibility | 

<a name="checkstripefundingeligibility"></a>
# **CheckStripeFundingEligibility**
> CheckStripeFundingEligibilityResponse CheckStripeFundingEligibility (CheckStripeFundingEligibility body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CheckStripeFundingEligibilityExample
    {
        public void main()
        {

            var apiInstance = new FundsApi();
            var body = new CheckStripeFundingEligibility(); // CheckStripeFundingEligibility | 

            try
            {
                CheckStripeFundingEligibilityResponse result = apiInstance.CheckStripeFundingEligibility(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundsApi.CheckStripeFundingEligibility: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CheckStripeFundingEligibility**](CheckStripeFundingEligibility.md)|  | 

### Return type

[**CheckStripeFundingEligibilityResponse**](CheckStripeFundingEligibilityResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

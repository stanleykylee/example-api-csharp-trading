/* 
 * 
 * Tradovate API, Samples. 
 * AccessTokenRequest
 *
*/

using System.Diagnostics;
using System.Net;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate
{
    class Authentication
    {
        public static AccessTokenResponse GetAccessToken(string basePath, string username, string password, string cid, string secret)
        {
            var apiInstance = new AuthenticationApi(basePath);
            var body = new AccessTokenRequest(name: username, password: password, appId: "SampleApp", appVersion: "0.0.1", cid: cid, sec: secret);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            AccessTokenResponse result = apiInstance.AccessTokenRequest(body);
            Debug.WriteLine(result);
            return result;
        }
    }
}
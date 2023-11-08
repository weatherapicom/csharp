# IO.Swagger.Api.APIsApi

All URIs are relative to *https://api.weatherapi.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Astronomy**](APIsApi.md#astronomy) | **GET** /astronomy.json | Astronomy API
[**ForecastWeather**](APIsApi.md#forecastweather) | **GET** /forecast.json | Forecast API
[**FutureWeather**](APIsApi.md#futureweather) | **GET** /future.json | Future API
[**HistoryWeather**](APIsApi.md#historyweather) | **GET** /history.json | History API
[**IpLookup**](APIsApi.md#iplookup) | **GET** /ip.json | IP Lookup API
[**MarineWeather**](APIsApi.md#marineweather) | **GET** /marine.json | Marine Weather API
[**RealtimeWeather**](APIsApi.md#realtimeweather) | **GET** /current.json | Realtime API
[**SearchAutocompleteWeather**](APIsApi.md#searchautocompleteweather) | **GET** /search.json | Search/Autocomplete API
[**TimeZone**](APIsApi.md#timezone) | **GET** /timezone.json | Time Zone API


<a name="astronomy"></a>
# **Astronomy**
> Object Astronomy (string q, DateTime? dt)

Astronomy API

Return Location and Astronomy Object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AstronomyExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new APIsApi();
            var q = q_example;  // string | Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more.
            var dt = 2013-10-20;  // DateTime? | Date on or after 1st Jan, 2015 in yyyy-MM-dd format

            try
            {
                // Astronomy API
                Object result = apiInstance.Astronomy(q, dt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.Astronomy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more. | 
 **dt** | **DateTime?**| Date on or after 1st Jan, 2015 in yyyy-MM-dd format | 

### Return type

**Object**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forecastweather"></a>
# **ForecastWeather**
> Object ForecastWeather (string q, int? days, DateTime? dt = null, int? unixdt = null, int? hour = null, string lang = null, string alerts = null, string aqi = null, int? tp = null)

Forecast API

Forecast weather API method returns, depending upon your price plan level, upto next 14 day weather forecast and weather alert as json or xml. The data is returned as a Forecast Object.<br /><br />Forecast object contains astronomy data, day weather forecast and hourly interval weather information for a given city.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ForecastWeatherExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new APIsApi();
            var q = q_example;  // string | Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more.
            var days = 56;  // int? | Number of days of weather forecast. Value ranges from 1 to 14
            var dt = 2013-10-20;  // DateTime? | Date should be between today and next 14 day in yyyy-MM-dd format. e.g. '2015-01-01' (optional) 
            var unixdt = 56;  // int? | Please either pass 'dt' or 'unixdt' and not both in same request. unixdt should be between today and next 14 day in Unix format. e.g. 1490227200 (optional) 
            var hour = 56;  // int? | Must be in 24 hour. For example 5 pm should be hour=17, 6 am as hour=6 (optional) 
            var lang = lang_example;  // string | Returns 'condition:text' field in API in the desired language.<br /> Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to check 'lang-code'. (optional) 
            var alerts = alerts_example;  // string | Enable/Disable alerts in forecast API output. Example, alerts=yes or alerts=no. (optional) 
            var aqi = aqi_example;  // string | Enable/Disable Air Quality data in forecast API output. Example, aqi=yes or aqi=no. (optional) 
            var tp = 56;  // int? | Get 15 min interval or 24 hour average data for Forecast and History API. Available for Enterprise clients only. E.g:- tp=15 (optional) 

            try
            {
                // Forecast API
                Object result = apiInstance.ForecastWeather(q, days, dt, unixdt, hour, lang, alerts, aqi, tp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.ForecastWeather: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more. | 
 **days** | **int?**| Number of days of weather forecast. Value ranges from 1 to 14 | 
 **dt** | **DateTime?**| Date should be between today and next 14 day in yyyy-MM-dd format. e.g. &#39;2015-01-01&#39; | [optional] 
 **unixdt** | **int?**| Please either pass &#39;dt&#39; or &#39;unixdt&#39; and not both in same request. unixdt should be between today and next 14 day in Unix format. e.g. 1490227200 | [optional] 
 **hour** | **int?**| Must be in 24 hour. For example 5 pm should be hour&#x3D;17, 6 am as hour&#x3D;6 | [optional] 
 **lang** | **string**| Returns &#39;condition:text&#39; field in API in the desired language.&lt;br /&gt; Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to check &#39;lang-code&#39;. | [optional] 
 **alerts** | **string**| Enable/Disable alerts in forecast API output. Example, alerts&#x3D;yes or alerts&#x3D;no. | [optional] 
 **aqi** | **string**| Enable/Disable Air Quality data in forecast API output. Example, aqi&#x3D;yes or aqi&#x3D;no. | [optional] 
 **tp** | **int?**| Get 15 min interval or 24 hour average data for Forecast and History API. Available for Enterprise clients only. E.g:- tp&#x3D;15 | [optional] 

### Return type

**Object**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="futureweather"></a>
# **FutureWeather**
> Object FutureWeather (string q, DateTime? dt = null, string lang = null)

Future API

Future weather API method returns weather in a 3 hourly interval in future for a date between 14 days and 365 days from today in the future.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FutureWeatherExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new APIsApi();
            var q = q_example;  // string | Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more.
            var dt = 2013-10-20;  // DateTime? | Date should be between 14 days and 300 days from today in the future in yyyy-MM-dd format (i.e. dt=2023-01-01) (optional) 
            var lang = lang_example;  // string | Returns 'condition:text' field in API in the desired language.<br /> Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to check 'lang-code'. (optional) 

            try
            {
                // Future API
                Object result = apiInstance.FutureWeather(q, dt, lang);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.FutureWeather: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more. | 
 **dt** | **DateTime?**| Date should be between 14 days and 300 days from today in the future in yyyy-MM-dd format (i.e. dt&#x3D;2023-01-01) | [optional] 
 **lang** | **string**| Returns &#39;condition:text&#39; field in API in the desired language.&lt;br /&gt; Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to check &#39;lang-code&#39;. | [optional] 

### Return type

**Object**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="historyweather"></a>
# **HistoryWeather**
> Object HistoryWeather (string q, DateTime? dt, int? unixdt = null, DateTime? endDt = null, int? unixendDt = null, int? hour = null, string lang = null)

History API

History weather API method returns historical weather for a date on or after 1st Jan, 2010 as json. The data is returned as a Forecast Object.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HistoryWeatherExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new APIsApi();
            var q = q_example;  // string | Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more.
            var dt = 2013-10-20;  // DateTime? | Date on or after 1st Jan, 2015 in yyyy-MM-dd format
            var unixdt = 56;  // int? | Please either pass 'dt' or 'unixdt' and not both in same request.<br />unixdt should be on or after 1st Jan, 2015 in Unix format (optional) 
            var endDt = 2013-10-20;  // DateTime? | Date on or after 1st Jan, 2015 in yyyy-MM-dd format<br />'end_dt' should be greater than 'dt' parameter and difference should not be more than 30 days between the two dates. (optional) 
            var unixendDt = 56;  // int? | Date on or after 1st Jan, 2015 in Unix Timestamp format<br />unixend_dt has same restriction as 'end_dt' parameter. Please either pass 'end_dt' or 'unixend_dt' and not both in same request. e.g. unixend_dt=1490227200 (optional) 
            var hour = 56;  // int? | Must be in 24 hour. For example 5 pm should be hour=17, 6 am as hour=6 (optional) 
            var lang = lang_example;  // string | Returns 'condition:text' field in API in the desired language.<br /> Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to check 'lang-code'. (optional) 

            try
            {
                // History API
                Object result = apiInstance.HistoryWeather(q, dt, unixdt, endDt, unixendDt, hour, lang);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.HistoryWeather: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more. | 
 **dt** | **DateTime?**| Date on or after 1st Jan, 2015 in yyyy-MM-dd format | 
 **unixdt** | **int?**| Please either pass &#39;dt&#39; or &#39;unixdt&#39; and not both in same request.&lt;br /&gt;unixdt should be on or after 1st Jan, 2015 in Unix format | [optional] 
 **endDt** | **DateTime?**| Date on or after 1st Jan, 2015 in yyyy-MM-dd format&lt;br /&gt;&#39;end_dt&#39; should be greater than &#39;dt&#39; parameter and difference should not be more than 30 days between the two dates. | [optional] 
 **unixendDt** | **int?**| Date on or after 1st Jan, 2015 in Unix Timestamp format&lt;br /&gt;unixend_dt has same restriction as &#39;end_dt&#39; parameter. Please either pass &#39;end_dt&#39; or &#39;unixend_dt&#39; and not both in same request. e.g. unixend_dt&#x3D;1490227200 | [optional] 
 **hour** | **int?**| Must be in 24 hour. For example 5 pm should be hour&#x3D;17, 6 am as hour&#x3D;6 | [optional] 
 **lang** | **string**| Returns &#39;condition:text&#39; field in API in the desired language.&lt;br /&gt; Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to check &#39;lang-code&#39;. | [optional] 

### Return type

**Object**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iplookup"></a>
# **IpLookup**
> Ip IpLookup (string q)

IP Lookup API

IP Lookup API method allows a user to get up to date information for an IP address.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IpLookupExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new APIsApi();
            var q = q_example;  // string | Pass IP address.

            try
            {
                // IP Lookup API
                Ip result = apiInstance.IpLookup(q);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.IpLookup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Pass IP address. | 

### Return type

[**Ip**](Ip.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="marineweather"></a>
# **MarineWeather**
> Object MarineWeather (string q, int? days, DateTime? dt = null, int? unixdt = null, int? hour = null, string lang = null)

Marine Weather API

Marine weather API method returns upto next 7 day (depending upon your price plan level) marine and sailing weather forecast and tide data (depending upon your price plan level) as json or xml. The data is returned as a Marine Object.<br /><br />Marine object, depending upon your price plan level, contains astronomy data, day weather forecast and hourly interval weather information and tide data for a given sea/ocean point.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MarineWeatherExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new APIsApi();
            var q = q_example;  // string | Pass Latitude/Longitude (decimal degree) which is on a sea/ocean. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more.
            var days = 56;  // int? | Number of days of weather forecast. Value ranges from 1 to 7
            var dt = 2013-10-20;  // DateTime? | Date should be between today and next 7 day in yyyy-MM-dd format. e.g. '2023-05-20' (optional) 
            var unixdt = 56;  // int? | Please either pass 'dt' or 'unixdt' and not both in same request. unixdt should be between today and next 7 day in Unix format. e.g. 1490227200 (optional) 
            var hour = 56;  // int? | Must be in 24 hour. For example 5 pm should be hour=17, 6 am as hour=6 (optional) 
            var lang = lang_example;  // string | Returns 'condition:text' field in API in the desired language.<br /> Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to check 'lang-code'. (optional) 

            try
            {
                // Marine Weather API
                Object result = apiInstance.MarineWeather(q, days, dt, unixdt, hour, lang);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.MarineWeather: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Pass Latitude/Longitude (decimal degree) which is on a sea/ocean. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more. | 
 **days** | **int?**| Number of days of weather forecast. Value ranges from 1 to 7 | 
 **dt** | **DateTime?**| Date should be between today and next 7 day in yyyy-MM-dd format. e.g. &#39;2023-05-20&#39; | [optional] 
 **unixdt** | **int?**| Please either pass &#39;dt&#39; or &#39;unixdt&#39; and not both in same request. unixdt should be between today and next 7 day in Unix format. e.g. 1490227200 | [optional] 
 **hour** | **int?**| Must be in 24 hour. For example 5 pm should be hour&#x3D;17, 6 am as hour&#x3D;6 | [optional] 
 **lang** | **string**| Returns &#39;condition:text&#39; field in API in the desired language.&lt;br /&gt; Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to check &#39;lang-code&#39;. | [optional] 

### Return type

**Object**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="realtimeweather"></a>
# **RealtimeWeather**
> Object RealtimeWeather (string q, string lang = null)

Realtime API

Current weather or realtime weather API method allows a user to get up to date current weather information in json and xml. The data is returned as a Current Object.<br /><br />Current object contains current or realtime weather information for a given city.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RealtimeWeatherExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new APIsApi();
            var q = q_example;  // string | Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more.
            var lang = lang_example;  // string | Returns 'condition:text' field in API in the desired language.<br /> Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to check 'lang-code'. (optional) 

            try
            {
                // Realtime API
                Object result = apiInstance.RealtimeWeather(q, lang);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.RealtimeWeather: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more. | 
 **lang** | **string**| Returns &#39;condition:text&#39; field in API in the desired language.&lt;br /&gt; Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to check &#39;lang-code&#39;. | [optional] 

### Return type

**Object**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchautocompleteweather"></a>
# **SearchAutocompleteWeather**
> ArrayOfSearch SearchAutocompleteWeather (string q)

Search/Autocomplete API

WeatherAPI.com Search or Autocomplete API returns matching cities and towns as an array of Location object.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchAutocompleteWeatherExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new APIsApi();
            var q = q_example;  // string | Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more.

            try
            {
                // Search/Autocomplete API
                ArrayOfSearch result = apiInstance.SearchAutocompleteWeather(q);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.SearchAutocompleteWeather: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more. | 

### Return type

[**ArrayOfSearch**](ArrayOfSearch.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timezone"></a>
# **TimeZone**
> Location TimeZone (string q)

Time Zone API

Return Location Object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeZoneExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new APIsApi();
            var q = q_example;  // string | Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more.

            try
            {
                // Time Zone API
                Location result = apiInstance.TimeZone(q);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.TimeZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more. | 

### Return type

[**Location**](Location.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


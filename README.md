[![Ceasefire Now](https://badge.techforpalestine.org/default)](https://techforpalestine.org/learn-more)

# The C# library for the Weather API

# Introduction 
WeatherAPI.com provides access to weather and geo data via a JSON/XML restful API. It allows developers to create desktop, web and mobile applications using this data very easy. 

We provide following data through our API:     
- Real-time weather
- 14 day weather forecast
- Historical Weather
- Marine Weather and Tide Data
- Future Weather (Upto 365 days ahead)
- Daily and hourly intervals
- 15 min interval (Enterprise only)
- Astronomy
- Time zone
- Location data
- Sports
- Search or Autocomplete API
- Weather Alerts
- Air Quality Data
- Bulk Request

# Getting Started    
You need to [signup](https://www.weatherapi.com/signup.aspx) and then you can find your API key under [your account](https://www.weatherapi.com/login.aspx), and start using API right away!  

Try our weather API by using interactive [API Explorer](https://www.weatherapi.com/api-explorer.aspx).  

We also have SDK for popular framework/languages available on [Github](https://github.com/weatherapicom/) for quick integrations.  

If you find any features missing or have any suggestions, please [contact us](https://www.weatherapi.com/contact.aspx).    

# Authentication    
API access to the data is protected by an API key. If at anytime, you find the API key has become vulnerable, please regenerate the key using Regenerate button next to the API key.    

Authentication to the WeatherAPI.com API is provided by passing your API key as request parameter through an API .      

##  key parameter  
key=YOUR API KEY

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.ApiKey.Add("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("key", "Bearer");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.weatherapi.com/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*APIsApi* | [**Astronomy**](docs/APIsApi.md#astronomy) | **GET** /astronomy.json | Astronomy API
*APIsApi* | [**ForecastWeather**](docs/APIsApi.md#forecastweather) | **GET** /forecast.json | Forecast API
*APIsApi* | [**FutureWeather**](docs/APIsApi.md#futureweather) | **GET** /future.json | Future API
*APIsApi* | [**HistoryWeather**](docs/APIsApi.md#historyweather) | **GET** /history.json | History API
*APIsApi* | [**IpLookup**](docs/APIsApi.md#iplookup) | **GET** /ip.json | IP Lookup API
*APIsApi* | [**MarineWeather**](docs/APIsApi.md#marineweather) | **GET** /marine.json | Marine Weather API
*APIsApi* | [**RealtimeWeather**](docs/APIsApi.md#realtimeweather) | **GET** /current.json | Realtime API
*APIsApi* | [**SearchAutocompleteWeather**](docs/APIsApi.md#searchautocompleteweather) | **GET** /search.json | Search/Autocomplete API
*APIsApi* | [**TimeZone**](docs/APIsApi.md#timezone) | **GET** /timezone.json | Time Zone API


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Alerts](docs/Alerts.md)
 - [Model.AlertsAlert](docs/AlertsAlert.md)
 - [Model.ArrayOfSearch](docs/ArrayOfSearch.md)
 - [Model.Astronomy](docs/Astronomy.md)
 - [Model.AstronomyAstro](docs/AstronomyAstro.md)
 - [Model.Current](docs/Current.md)
 - [Model.CurrentAirQuality](docs/CurrentAirQuality.md)
 - [Model.CurrentCondition](docs/CurrentCondition.md)
 - [Model.Error400](docs/Error400.md)
 - [Model.Error401](docs/Error401.md)
 - [Model.Error403](docs/Error403.md)
 - [Model.Forecast](docs/Forecast.md)
 - [Model.ForecastAstro](docs/ForecastAstro.md)
 - [Model.ForecastCondition](docs/ForecastCondition.md)
 - [Model.ForecastDay](docs/ForecastDay.md)
 - [Model.ForecastDayCondition](docs/ForecastDayCondition.md)
 - [Model.ForecastForecastday](docs/ForecastForecastday.md)
 - [Model.ForecastHour](docs/ForecastHour.md)
 - [Model.Ip](docs/Ip.md)
 - [Model.Location](docs/Location.md)
 - [Model.Marine](docs/Marine.md)
 - [Model.MarineForecastday](docs/MarineForecastday.md)
 - [Model.MarineHour](docs/MarineHour.md)
 - [Model.Search](docs/Search.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKeyAuth"></a>
### ApiKeyAuth

- **Type**: API key
- **API key parameter name**: key
- **Location**: URL query string


/* 
 * Weather API
 *
 * # Introduction WeatherAPI.com provides access to weather and geo data via a JSON/XML restful API. It allows developers to create desktop, web and mobile applications using this data very easy. We provide following data through our API:     - Real-time weather - 14 day weather forecast - Historical Weather - Marine Weather and Tide Data - Future Weather (Upto 365 days ahead) - Daily and hourly intervals - 15 min interval (Enterprise only) - Astronomy - Time zone - Location data - Sports - Search or Autocomplete API - Weather Alerts - Air Quality Data - Bulk Request  # Getting Started    You need to [signup](https://www.weatherapi.com/signup.aspx) and then you can find your API key under [your account](https://www.weatherapi.com/login.aspx), and start using API right away!  Try our weather API by using interactive [API Explorer](https://www.weatherapi.com/api-explorer.aspx).  We also have SDK for popular framework/languages available on [Github](https://github.com/weatherapicom/) for quick integrations.  If you find any features missing or have any suggestions, please [contact us](https://www.weatherapi.com/contact.aspx).    # Authentication    API access to the data is protected by an API key. If at anytime, you find the API key has become vulnerable, please regenerate the key using Regenerate button next to the API key.    Authentication to the WeatherAPI.com API is provided by passing your API key as request parameter through an API .      ##  key parameter  key=YOUR API KEY  
 *
 * OpenAPI spec version: 1.0.2
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ForecastDay
    /// </summary>
    [DataContract]
    public partial class ForecastDay :  IEquatable<ForecastDay>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastDay" /> class.
        /// </summary>
        /// <param name="maxtempC">maxtempC.</param>
        /// <param name="maxtempF">maxtempF.</param>
        /// <param name="mintempC">mintempC.</param>
        /// <param name="mintempF">mintempF.</param>
        /// <param name="avgtempC">avgtempC.</param>
        /// <param name="avgtempF">avgtempF.</param>
        /// <param name="maxwindMph">maxwindMph.</param>
        /// <param name="maxwindKph">maxwindKph.</param>
        /// <param name="totalprecipMm">totalprecipMm.</param>
        /// <param name="totalprecipIn">totalprecipIn.</param>
        /// <param name="avgvisKm">avgvisKm.</param>
        /// <param name="avgvisMiles">avgvisMiles.</param>
        /// <param name="avghumidity">avghumidity.</param>
        /// <param name="dailyWillItRain">dailyWillItRain.</param>
        /// <param name="dailyChanceOfRain">dailyChanceOfRain.</param>
        /// <param name="dailyWillItSnow">dailyWillItSnow.</param>
        /// <param name="dailyChanceOfSnow">dailyChanceOfSnow.</param>
        /// <param name="condition">condition.</param>
        /// <param name="uv">uv.</param>
        public ForecastDay(decimal? maxtempC = default(decimal?), decimal? maxtempF = default(decimal?), decimal? mintempC = default(decimal?), decimal? mintempF = default(decimal?), decimal? avgtempC = default(decimal?), decimal? avgtempF = default(decimal?), decimal? maxwindMph = default(decimal?), decimal? maxwindKph = default(decimal?), decimal? totalprecipMm = default(decimal?), decimal? totalprecipIn = default(decimal?), decimal? avgvisKm = default(decimal?), decimal? avgvisMiles = default(decimal?), decimal? avghumidity = default(decimal?), int? dailyWillItRain = default(int?), decimal? dailyChanceOfRain = default(decimal?), int? dailyWillItSnow = default(int?), decimal? dailyChanceOfSnow = default(decimal?), ForecastDayCondition condition = default(ForecastDayCondition), int? uv = default(int?))
        {
            this.MaxtempC = maxtempC;
            this.MaxtempF = maxtempF;
            this.MintempC = mintempC;
            this.MintempF = mintempF;
            this.AvgtempC = avgtempC;
            this.AvgtempF = avgtempF;
            this.MaxwindMph = maxwindMph;
            this.MaxwindKph = maxwindKph;
            this.TotalprecipMm = totalprecipMm;
            this.TotalprecipIn = totalprecipIn;
            this.AvgvisKm = avgvisKm;
            this.AvgvisMiles = avgvisMiles;
            this.Avghumidity = avghumidity;
            this.DailyWillItRain = dailyWillItRain;
            this.DailyChanceOfRain = dailyChanceOfRain;
            this.DailyWillItSnow = dailyWillItSnow;
            this.DailyChanceOfSnow = dailyChanceOfSnow;
            this.Condition = condition;
            this.Uv = uv;
        }
        
        /// <summary>
        /// Gets or Sets MaxtempC
        /// </summary>
        [DataMember(Name="maxtemp_c", EmitDefaultValue=false)]
        public decimal? MaxtempC { get; set; }

        /// <summary>
        /// Gets or Sets MaxtempF
        /// </summary>
        [DataMember(Name="maxtemp_f", EmitDefaultValue=false)]
        public decimal? MaxtempF { get; set; }

        /// <summary>
        /// Gets or Sets MintempC
        /// </summary>
        [DataMember(Name="mintemp_c", EmitDefaultValue=false)]
        public decimal? MintempC { get; set; }

        /// <summary>
        /// Gets or Sets MintempF
        /// </summary>
        [DataMember(Name="mintemp_f", EmitDefaultValue=false)]
        public decimal? MintempF { get; set; }

        /// <summary>
        /// Gets or Sets AvgtempC
        /// </summary>
        [DataMember(Name="avgtemp_c", EmitDefaultValue=false)]
        public decimal? AvgtempC { get; set; }

        /// <summary>
        /// Gets or Sets AvgtempF
        /// </summary>
        [DataMember(Name="avgtemp_f", EmitDefaultValue=false)]
        public decimal? AvgtempF { get; set; }

        /// <summary>
        /// Gets or Sets MaxwindMph
        /// </summary>
        [DataMember(Name="maxwind_mph", EmitDefaultValue=false)]
        public decimal? MaxwindMph { get; set; }

        /// <summary>
        /// Gets or Sets MaxwindKph
        /// </summary>
        [DataMember(Name="maxwind_kph", EmitDefaultValue=false)]
        public decimal? MaxwindKph { get; set; }

        /// <summary>
        /// Gets or Sets TotalprecipMm
        /// </summary>
        [DataMember(Name="totalprecip_mm", EmitDefaultValue=false)]
        public decimal? TotalprecipMm { get; set; }

        /// <summary>
        /// Gets or Sets TotalprecipIn
        /// </summary>
        [DataMember(Name="totalprecip_in", EmitDefaultValue=false)]
        public decimal? TotalprecipIn { get; set; }

        /// <summary>
        /// Gets or Sets AvgvisKm
        /// </summary>
        [DataMember(Name="avgvis_km", EmitDefaultValue=false)]
        public decimal? AvgvisKm { get; set; }

        /// <summary>
        /// Gets or Sets AvgvisMiles
        /// </summary>
        [DataMember(Name="avgvis_miles", EmitDefaultValue=false)]
        public decimal? AvgvisMiles { get; set; }

        /// <summary>
        /// Gets or Sets Avghumidity
        /// </summary>
        [DataMember(Name="avghumidity", EmitDefaultValue=false)]
        public decimal? Avghumidity { get; set; }

        /// <summary>
        /// Gets or Sets DailyWillItRain
        /// </summary>
        [DataMember(Name="daily_will_it_rain", EmitDefaultValue=false)]
        public int? DailyWillItRain { get; set; }

        /// <summary>
        /// Gets or Sets DailyChanceOfRain
        /// </summary>
        [DataMember(Name="daily_chance_of_rain", EmitDefaultValue=false)]
        public decimal? DailyChanceOfRain { get; set; }

        /// <summary>
        /// Gets or Sets DailyWillItSnow
        /// </summary>
        [DataMember(Name="daily_will_it_snow", EmitDefaultValue=false)]
        public int? DailyWillItSnow { get; set; }

        /// <summary>
        /// Gets or Sets DailyChanceOfSnow
        /// </summary>
        [DataMember(Name="daily_chance_of_snow", EmitDefaultValue=false)]
        public decimal? DailyChanceOfSnow { get; set; }

        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [DataMember(Name="condition", EmitDefaultValue=false)]
        public ForecastDayCondition Condition { get; set; }

        /// <summary>
        /// Gets or Sets Uv
        /// </summary>
        [DataMember(Name="uv", EmitDefaultValue=false)]
        public int? Uv { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastDay {\n");
            sb.Append("  MaxtempC: ").Append(MaxtempC).Append("\n");
            sb.Append("  MaxtempF: ").Append(MaxtempF).Append("\n");
            sb.Append("  MintempC: ").Append(MintempC).Append("\n");
            sb.Append("  MintempF: ").Append(MintempF).Append("\n");
            sb.Append("  AvgtempC: ").Append(AvgtempC).Append("\n");
            sb.Append("  AvgtempF: ").Append(AvgtempF).Append("\n");
            sb.Append("  MaxwindMph: ").Append(MaxwindMph).Append("\n");
            sb.Append("  MaxwindKph: ").Append(MaxwindKph).Append("\n");
            sb.Append("  TotalprecipMm: ").Append(TotalprecipMm).Append("\n");
            sb.Append("  TotalprecipIn: ").Append(TotalprecipIn).Append("\n");
            sb.Append("  AvgvisKm: ").Append(AvgvisKm).Append("\n");
            sb.Append("  AvgvisMiles: ").Append(AvgvisMiles).Append("\n");
            sb.Append("  Avghumidity: ").Append(Avghumidity).Append("\n");
            sb.Append("  DailyWillItRain: ").Append(DailyWillItRain).Append("\n");
            sb.Append("  DailyChanceOfRain: ").Append(DailyChanceOfRain).Append("\n");
            sb.Append("  DailyWillItSnow: ").Append(DailyWillItSnow).Append("\n");
            sb.Append("  DailyChanceOfSnow: ").Append(DailyChanceOfSnow).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  Uv: ").Append(Uv).Append("\n");
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
            return this.Equals(input as ForecastDay);
        }

        /// <summary>
        /// Returns true if ForecastDay instances are equal
        /// </summary>
        /// <param name="input">Instance of ForecastDay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastDay input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxtempC == input.MaxtempC ||
                    (this.MaxtempC != null &&
                    this.MaxtempC.Equals(input.MaxtempC))
                ) && 
                (
                    this.MaxtempF == input.MaxtempF ||
                    (this.MaxtempF != null &&
                    this.MaxtempF.Equals(input.MaxtempF))
                ) && 
                (
                    this.MintempC == input.MintempC ||
                    (this.MintempC != null &&
                    this.MintempC.Equals(input.MintempC))
                ) && 
                (
                    this.MintempF == input.MintempF ||
                    (this.MintempF != null &&
                    this.MintempF.Equals(input.MintempF))
                ) && 
                (
                    this.AvgtempC == input.AvgtempC ||
                    (this.AvgtempC != null &&
                    this.AvgtempC.Equals(input.AvgtempC))
                ) && 
                (
                    this.AvgtempF == input.AvgtempF ||
                    (this.AvgtempF != null &&
                    this.AvgtempF.Equals(input.AvgtempF))
                ) && 
                (
                    this.MaxwindMph == input.MaxwindMph ||
                    (this.MaxwindMph != null &&
                    this.MaxwindMph.Equals(input.MaxwindMph))
                ) && 
                (
                    this.MaxwindKph == input.MaxwindKph ||
                    (this.MaxwindKph != null &&
                    this.MaxwindKph.Equals(input.MaxwindKph))
                ) && 
                (
                    this.TotalprecipMm == input.TotalprecipMm ||
                    (this.TotalprecipMm != null &&
                    this.TotalprecipMm.Equals(input.TotalprecipMm))
                ) && 
                (
                    this.TotalprecipIn == input.TotalprecipIn ||
                    (this.TotalprecipIn != null &&
                    this.TotalprecipIn.Equals(input.TotalprecipIn))
                ) && 
                (
                    this.AvgvisKm == input.AvgvisKm ||
                    (this.AvgvisKm != null &&
                    this.AvgvisKm.Equals(input.AvgvisKm))
                ) && 
                (
                    this.AvgvisMiles == input.AvgvisMiles ||
                    (this.AvgvisMiles != null &&
                    this.AvgvisMiles.Equals(input.AvgvisMiles))
                ) && 
                (
                    this.Avghumidity == input.Avghumidity ||
                    (this.Avghumidity != null &&
                    this.Avghumidity.Equals(input.Avghumidity))
                ) && 
                (
                    this.DailyWillItRain == input.DailyWillItRain ||
                    (this.DailyWillItRain != null &&
                    this.DailyWillItRain.Equals(input.DailyWillItRain))
                ) && 
                (
                    this.DailyChanceOfRain == input.DailyChanceOfRain ||
                    (this.DailyChanceOfRain != null &&
                    this.DailyChanceOfRain.Equals(input.DailyChanceOfRain))
                ) && 
                (
                    this.DailyWillItSnow == input.DailyWillItSnow ||
                    (this.DailyWillItSnow != null &&
                    this.DailyWillItSnow.Equals(input.DailyWillItSnow))
                ) && 
                (
                    this.DailyChanceOfSnow == input.DailyChanceOfSnow ||
                    (this.DailyChanceOfSnow != null &&
                    this.DailyChanceOfSnow.Equals(input.DailyChanceOfSnow))
                ) && 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.Uv == input.Uv ||
                    (this.Uv != null &&
                    this.Uv.Equals(input.Uv))
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
                if (this.MaxtempC != null)
                    hashCode = hashCode * 59 + this.MaxtempC.GetHashCode();
                if (this.MaxtempF != null)
                    hashCode = hashCode * 59 + this.MaxtempF.GetHashCode();
                if (this.MintempC != null)
                    hashCode = hashCode * 59 + this.MintempC.GetHashCode();
                if (this.MintempF != null)
                    hashCode = hashCode * 59 + this.MintempF.GetHashCode();
                if (this.AvgtempC != null)
                    hashCode = hashCode * 59 + this.AvgtempC.GetHashCode();
                if (this.AvgtempF != null)
                    hashCode = hashCode * 59 + this.AvgtempF.GetHashCode();
                if (this.MaxwindMph != null)
                    hashCode = hashCode * 59 + this.MaxwindMph.GetHashCode();
                if (this.MaxwindKph != null)
                    hashCode = hashCode * 59 + this.MaxwindKph.GetHashCode();
                if (this.TotalprecipMm != null)
                    hashCode = hashCode * 59 + this.TotalprecipMm.GetHashCode();
                if (this.TotalprecipIn != null)
                    hashCode = hashCode * 59 + this.TotalprecipIn.GetHashCode();
                if (this.AvgvisKm != null)
                    hashCode = hashCode * 59 + this.AvgvisKm.GetHashCode();
                if (this.AvgvisMiles != null)
                    hashCode = hashCode * 59 + this.AvgvisMiles.GetHashCode();
                if (this.Avghumidity != null)
                    hashCode = hashCode * 59 + this.Avghumidity.GetHashCode();
                if (this.DailyWillItRain != null)
                    hashCode = hashCode * 59 + this.DailyWillItRain.GetHashCode();
                if (this.DailyChanceOfRain != null)
                    hashCode = hashCode * 59 + this.DailyChanceOfRain.GetHashCode();
                if (this.DailyWillItSnow != null)
                    hashCode = hashCode * 59 + this.DailyWillItSnow.GetHashCode();
                if (this.DailyChanceOfSnow != null)
                    hashCode = hashCode * 59 + this.DailyChanceOfSnow.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.Uv != null)
                    hashCode = hashCode * 59 + this.Uv.GetHashCode();
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

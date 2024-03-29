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
    /// ForecastForecastday
    /// </summary>
    [DataContract]
    public partial class ForecastForecastday :  IEquatable<ForecastForecastday>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastForecastday" /> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="dateEpoch">dateEpoch.</param>
        /// <param name="day">day.</param>
        /// <param name="astro">astro.</param>
        /// <param name="hour">hour.</param>
        public ForecastForecastday(DateTime? date = default(DateTime?), int? dateEpoch = default(int?), ForecastDay day = default(ForecastDay), ForecastAstro astro = default(ForecastAstro), List<ForecastHour> hour = default(List<ForecastHour>))
        {
            this.Date = date;
            this.DateEpoch = dateEpoch;
            this.Day = day;
            this.Astro = astro;
            this.Hour = hour;
        }
        
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets DateEpoch
        /// </summary>
        [DataMember(Name="date_epoch", EmitDefaultValue=false)]
        public int? DateEpoch { get; set; }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name="day", EmitDefaultValue=false)]
        public ForecastDay Day { get; set; }

        /// <summary>
        /// Gets or Sets Astro
        /// </summary>
        [DataMember(Name="astro", EmitDefaultValue=false)]
        public ForecastAstro Astro { get; set; }

        /// <summary>
        /// Gets or Sets Hour
        /// </summary>
        [DataMember(Name="hour", EmitDefaultValue=false)]
        public List<ForecastHour> Hour { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastForecastday {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DateEpoch: ").Append(DateEpoch).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  Astro: ").Append(Astro).Append("\n");
            sb.Append("  Hour: ").Append(Hour).Append("\n");
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
            return this.Equals(input as ForecastForecastday);
        }

        /// <summary>
        /// Returns true if ForecastForecastday instances are equal
        /// </summary>
        /// <param name="input">Instance of ForecastForecastday to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastForecastday input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.DateEpoch == input.DateEpoch ||
                    (this.DateEpoch != null &&
                    this.DateEpoch.Equals(input.DateEpoch))
                ) && 
                (
                    this.Day == input.Day ||
                    (this.Day != null &&
                    this.Day.Equals(input.Day))
                ) && 
                (
                    this.Astro == input.Astro ||
                    (this.Astro != null &&
                    this.Astro.Equals(input.Astro))
                ) && 
                (
                    this.Hour == input.Hour ||
                    this.Hour != null &&
                    this.Hour.SequenceEqual(input.Hour)
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.DateEpoch != null)
                    hashCode = hashCode * 59 + this.DateEpoch.GetHashCode();
                if (this.Day != null)
                    hashCode = hashCode * 59 + this.Day.GetHashCode();
                if (this.Astro != null)
                    hashCode = hashCode * 59 + this.Astro.GetHashCode();
                if (this.Hour != null)
                    hashCode = hashCode * 59 + this.Hour.GetHashCode();
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

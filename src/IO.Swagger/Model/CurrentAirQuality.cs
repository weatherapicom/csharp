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
    /// CurrentAirQuality
    /// </summary>
    [DataContract]
    public partial class CurrentAirQuality :  IEquatable<CurrentAirQuality>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentAirQuality" /> class.
        /// </summary>
        /// <param name="co">co.</param>
        /// <param name="no2">no2.</param>
        /// <param name="o3">o3.</param>
        /// <param name="so2">so2.</param>
        /// <param name="pm25">pm25.</param>
        /// <param name="pm10">pm10.</param>
        /// <param name="usEpaIndex">usEpaIndex.</param>
        /// <param name="gbDefraIndex">gbDefraIndex.</param>
        public CurrentAirQuality(decimal? co = default(decimal?), decimal? no2 = default(decimal?), decimal? o3 = default(decimal?), decimal? so2 = default(decimal?), decimal? pm25 = default(decimal?), decimal? pm10 = default(decimal?), int? usEpaIndex = default(int?), int? gbDefraIndex = default(int?))
        {
            this.Co = co;
            this.No2 = no2;
            this.O3 = o3;
            this.So2 = so2;
            this.Pm25 = pm25;
            this.Pm10 = pm10;
            this.UsEpaIndex = usEpaIndex;
            this.GbDefraIndex = gbDefraIndex;
        }
        
        /// <summary>
        /// Gets or Sets Co
        /// </summary>
        [DataMember(Name="co", EmitDefaultValue=false)]
        public decimal? Co { get; set; }

        /// <summary>
        /// Gets or Sets No2
        /// </summary>
        [DataMember(Name="no2", EmitDefaultValue=false)]
        public decimal? No2 { get; set; }

        /// <summary>
        /// Gets or Sets O3
        /// </summary>
        [DataMember(Name="o3", EmitDefaultValue=false)]
        public decimal? O3 { get; set; }

        /// <summary>
        /// Gets or Sets So2
        /// </summary>
        [DataMember(Name="so2", EmitDefaultValue=false)]
        public decimal? So2 { get; set; }

        /// <summary>
        /// Gets or Sets Pm25
        /// </summary>
        [DataMember(Name="pm2_5", EmitDefaultValue=false)]
        public decimal? Pm25 { get; set; }

        /// <summary>
        /// Gets or Sets Pm10
        /// </summary>
        [DataMember(Name="pm10", EmitDefaultValue=false)]
        public decimal? Pm10 { get; set; }

        /// <summary>
        /// Gets or Sets UsEpaIndex
        /// </summary>
        [DataMember(Name="us-epa-index", EmitDefaultValue=false)]
        public int? UsEpaIndex { get; set; }

        /// <summary>
        /// Gets or Sets GbDefraIndex
        /// </summary>
        [DataMember(Name="gb-defra-index", EmitDefaultValue=false)]
        public int? GbDefraIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrentAirQuality {\n");
            sb.Append("  Co: ").Append(Co).Append("\n");
            sb.Append("  No2: ").Append(No2).Append("\n");
            sb.Append("  O3: ").Append(O3).Append("\n");
            sb.Append("  So2: ").Append(So2).Append("\n");
            sb.Append("  Pm25: ").Append(Pm25).Append("\n");
            sb.Append("  Pm10: ").Append(Pm10).Append("\n");
            sb.Append("  UsEpaIndex: ").Append(UsEpaIndex).Append("\n");
            sb.Append("  GbDefraIndex: ").Append(GbDefraIndex).Append("\n");
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
            return this.Equals(input as CurrentAirQuality);
        }

        /// <summary>
        /// Returns true if CurrentAirQuality instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrentAirQuality to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentAirQuality input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Co == input.Co ||
                    (this.Co != null &&
                    this.Co.Equals(input.Co))
                ) && 
                (
                    this.No2 == input.No2 ||
                    (this.No2 != null &&
                    this.No2.Equals(input.No2))
                ) && 
                (
                    this.O3 == input.O3 ||
                    (this.O3 != null &&
                    this.O3.Equals(input.O3))
                ) && 
                (
                    this.So2 == input.So2 ||
                    (this.So2 != null &&
                    this.So2.Equals(input.So2))
                ) && 
                (
                    this.Pm25 == input.Pm25 ||
                    (this.Pm25 != null &&
                    this.Pm25.Equals(input.Pm25))
                ) && 
                (
                    this.Pm10 == input.Pm10 ||
                    (this.Pm10 != null &&
                    this.Pm10.Equals(input.Pm10))
                ) && 
                (
                    this.UsEpaIndex == input.UsEpaIndex ||
                    (this.UsEpaIndex != null &&
                    this.UsEpaIndex.Equals(input.UsEpaIndex))
                ) && 
                (
                    this.GbDefraIndex == input.GbDefraIndex ||
                    (this.GbDefraIndex != null &&
                    this.GbDefraIndex.Equals(input.GbDefraIndex))
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
                if (this.Co != null)
                    hashCode = hashCode * 59 + this.Co.GetHashCode();
                if (this.No2 != null)
                    hashCode = hashCode * 59 + this.No2.GetHashCode();
                if (this.O3 != null)
                    hashCode = hashCode * 59 + this.O3.GetHashCode();
                if (this.So2 != null)
                    hashCode = hashCode * 59 + this.So2.GetHashCode();
                if (this.Pm25 != null)
                    hashCode = hashCode * 59 + this.Pm25.GetHashCode();
                if (this.Pm10 != null)
                    hashCode = hashCode * 59 + this.Pm10.GetHashCode();
                if (this.UsEpaIndex != null)
                    hashCode = hashCode * 59 + this.UsEpaIndex.GetHashCode();
                if (this.GbDefraIndex != null)
                    hashCode = hashCode * 59 + this.GbDefraIndex.GetHashCode();
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

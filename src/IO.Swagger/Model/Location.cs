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
    /// Location
    /// </summary>
    [DataContract]
    public partial class Location :  IEquatable<Location>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="region">region.</param>
        /// <param name="country">country.</param>
        /// <param name="lat">lat.</param>
        /// <param name="lon">lon.</param>
        /// <param name="tzId">tzId.</param>
        /// <param name="localtimeEpoch">localtimeEpoch.</param>
        /// <param name="localtime">localtime.</param>
        public Location(string name = default(string), string region = default(string), string country = default(string), decimal? lat = default(decimal?), decimal? lon = default(decimal?), string tzId = default(string), int? localtimeEpoch = default(int?), string localtime = default(string))
        {
            this.Name = name;
            this.Region = region;
            this.Country = country;
            this.Lat = lat;
            this.Lon = lon;
            this.TzId = tzId;
            this.LocaltimeEpoch = localtimeEpoch;
            this.Localtime = localtime;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Lat
        /// </summary>
        [DataMember(Name="lat", EmitDefaultValue=false)]
        public decimal? Lat { get; set; }

        /// <summary>
        /// Gets or Sets Lon
        /// </summary>
        [DataMember(Name="lon", EmitDefaultValue=false)]
        public decimal? Lon { get; set; }

        /// <summary>
        /// Gets or Sets TzId
        /// </summary>
        [DataMember(Name="tz_id", EmitDefaultValue=false)]
        public string TzId { get; set; }

        /// <summary>
        /// Gets or Sets LocaltimeEpoch
        /// </summary>
        [DataMember(Name="localtime_epoch", EmitDefaultValue=false)]
        public int? LocaltimeEpoch { get; set; }

        /// <summary>
        /// Gets or Sets Localtime
        /// </summary>
        [DataMember(Name="localtime", EmitDefaultValue=false)]
        public string Localtime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Location {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lon: ").Append(Lon).Append("\n");
            sb.Append("  TzId: ").Append(TzId).Append("\n");
            sb.Append("  LocaltimeEpoch: ").Append(LocaltimeEpoch).Append("\n");
            sb.Append("  Localtime: ").Append(Localtime).Append("\n");
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
            return this.Equals(input as Location);
        }

        /// <summary>
        /// Returns true if Location instances are equal
        /// </summary>
        /// <param name="input">Instance of Location to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Location input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Lat == input.Lat ||
                    (this.Lat != null &&
                    this.Lat.Equals(input.Lat))
                ) && 
                (
                    this.Lon == input.Lon ||
                    (this.Lon != null &&
                    this.Lon.Equals(input.Lon))
                ) && 
                (
                    this.TzId == input.TzId ||
                    (this.TzId != null &&
                    this.TzId.Equals(input.TzId))
                ) && 
                (
                    this.LocaltimeEpoch == input.LocaltimeEpoch ||
                    (this.LocaltimeEpoch != null &&
                    this.LocaltimeEpoch.Equals(input.LocaltimeEpoch))
                ) && 
                (
                    this.Localtime == input.Localtime ||
                    (this.Localtime != null &&
                    this.Localtime.Equals(input.Localtime))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Lat != null)
                    hashCode = hashCode * 59 + this.Lat.GetHashCode();
                if (this.Lon != null)
                    hashCode = hashCode * 59 + this.Lon.GetHashCode();
                if (this.TzId != null)
                    hashCode = hashCode * 59 + this.TzId.GetHashCode();
                if (this.LocaltimeEpoch != null)
                    hashCode = hashCode * 59 + this.LocaltimeEpoch.GetHashCode();
                if (this.Localtime != null)
                    hashCode = hashCode * 59 + this.Localtime.GetHashCode();
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

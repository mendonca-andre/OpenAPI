// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeatherForecast.cs" company="(AM)=>">
// Andre Mendonca
// 3/7/2020
// </copyright>
// <summary>
//   The weather forecast.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OpenAPI.Models
{
    using System;

    /// <summary>
    /// The weather forecast.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the temperature c.
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// The temperature f.
        /// </summary>
        public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);

        /// <summary>
        /// Gets or sets the summary.
        /// </summary>
        public string Summary { get; set; }
    }
}

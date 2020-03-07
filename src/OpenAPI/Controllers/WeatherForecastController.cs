// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeatherForecastController.cs" company="Andre Mendonca">
//   Andre Mendonca
//   3/7/2020
// </copyright>
// <summary>
//   The weather forecast controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OpenAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;

    using OpenAPI.Models;

    /// <summary>
    /// The weather forecast controller.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        /// <summary>
        /// The summaries.
        /// </summary>
        private static readonly string[] Summaries =
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

        /// <summary>
        /// The get.
        /// </summary>
        /// <returns>
        /// The <see>
        ///     <cref>IEnumerable</cref>
        /// </see>
        /// .
        /// </returns>
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

using DiGi.Core.Classes;
using DiGi.Weather.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Weather.Classes
{
    /// <summary>
    /// Represents a weather container of <see cref="WeatherRecord"/> elements.
    /// </summary>
    public class Weather : Weather<WeatherRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Weather"/> class.
        /// </summary>
        public Weather() 
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Weather"/> class with a collection of weather records.
        /// </summary>
        /// <param name="weatherRecords">The collection of weather records to initialize with.</param>
        public Weather(IEnumerable<WeatherRecord> weatherRecords)
            : base(weatherRecords)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Weather"/> class by copying another instance.
        /// </summary>
        /// <param name="weather">The weather instance to copy.</param>
        public Weather(Weather weather)
            :base(weather)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Weather"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing weather data.</param>
        public Weather(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }


    /// <summary>
    /// Provides a base abstract class for weather data containers.
    /// </summary>
    /// <typeparam name="TWeatherRecord">The type of the weather record.</typeparam>
    public abstract class Weather<TWeatherRecord> : SerializableObject, IWeatherSerializableObject, IEnumerable<TWeatherRecord> where TWeatherRecord : IWeatherRecord
    {
        [JsonIgnore]
        private readonly Dictionary<DateTime, TWeatherRecord> weatherRecords = [];

        /// <summary>
        /// Returns an enumerator that iterates through the weather records.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        public IEnumerator<TWeatherRecord> GetEnumerator()
        {
            return weatherRecords?.Values.GetEnumerator() ?? Enumerable.Empty<TWeatherRecord>().GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the weather records.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Weather{TWeatherRecord}"/> class.
        /// </summary>
        public Weather()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Weather{TWeatherRecord}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the weather data.</param>
        public Weather(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Weather{TWeatherRecord}"/> class by copying another instance.
        /// </summary>
        /// <param name="weather">The weather instance to copy.</param>
        public Weather(Weather<TWeatherRecord> weather)
            :base(weather)
        {
            if(weather is not null)
            {
                WeatherRecords = weather.WeatherRecords;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Weather{TWeatherRecord}"/> class with a collection of weather records.
        /// </summary>
        /// <param name="weatherRecords">The collection of weather records.</param>
        public Weather(IEnumerable<TWeatherRecord> weatherRecords)
            : base()
        {
            WeatherRecords = weatherRecords?.ToList();
        }

        /// <summary>
        /// Gets or sets the list of weather records.
        /// </summary>
        [JsonInclude, JsonPropertyName("WeatherRecords")]
        public IList<TWeatherRecord>? WeatherRecords
        {
            get
            {
                return weatherRecords?.Values.ToList() ?? [];
            }

            set
            {
                weatherRecords.Clear();

                if (value is null)
                {
                    return;
                }

                foreach(TWeatherRecord weatherRecord in value)
                {
                    if (weatherRecord is null)
                    {
                        continue;
                    }

                    if (!weatherRecords.ContainsKey(weatherRecord.DateTime))
                    {
                        weatherRecords.Add(weatherRecord.DateTime, weatherRecord);
                    }
                }

            }
        }
    }
}

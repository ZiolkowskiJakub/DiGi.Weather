using System;

namespace DiGi.Weather.Interfaces
{
    /// <summary>
    /// Defines the interface for a weather record.
    /// </summary>
    public interface IWeatherRecord : IWeatherSerializableObject
    {
        /// <summary>
        /// Gets the date and time of the record.
        /// </summary>
        DateTime DateTime { get; }
    }
}

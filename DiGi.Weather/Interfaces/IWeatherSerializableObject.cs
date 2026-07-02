using DiGi.Core.Interfaces;

namespace DiGi.Weather.Interfaces
{
    /// <summary>
    /// Defines the interface for serializable weather objects.
    /// </summary>
    public interface IWeatherSerializableObject : IWeatherObject, ISerializableObject
    {
    }
}
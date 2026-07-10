#### [DiGi\.Weather](DiGi.Weather.Overview.md 'DiGi\.Weather\.Overview')

## DiGi\.Weather\.Interfaces Namespace
### Interfaces

<a name='DiGi.Weather.Interfaces.IWeatherObject'></a>

## IWeatherObject Interface

Defines the base interface for all weather\-related objects\.

```csharp
public interface IWeatherObject : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Weather&lt;TWeatherRecord&gt;](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_ 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>')  
↳ [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')  
↳ [IWeatherRecord](DiGi.Weather.Interfaces.md#DiGi.Weather.Interfaces.IWeatherRecord 'DiGi\.Weather\.Interfaces\.IWeatherRecord')  
↳ [IWeatherSerializableObject](DiGi.Weather.Interfaces.md#DiGi.Weather.Interfaces.IWeatherSerializableObject 'DiGi\.Weather\.Interfaces\.IWeatherSerializableObject')

Implements [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Weather.Interfaces.IWeatherRecord'></a>

## IWeatherRecord Interface

Defines the interface for a weather record\.

```csharp
public interface IWeatherRecord : DiGi.Weather.Interfaces.IWeatherSerializableObject, DiGi.Weather.Interfaces.IWeatherObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')

Implements [IWeatherSerializableObject](DiGi.Weather.Interfaces.md#DiGi.Weather.Interfaces.IWeatherSerializableObject 'DiGi\.Weather\.Interfaces\.IWeatherSerializableObject'), [IWeatherObject](DiGi.Weather.Interfaces.md#DiGi.Weather.Interfaces.IWeatherObject 'DiGi\.Weather\.Interfaces\.IWeatherObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Properties

<a name='DiGi.Weather.Interfaces.IWeatherRecord.DateTime'></a>

## IWeatherRecord\.DateTime Property

Gets the date and time of the record\.

```csharp
System.DateTime DateTime { get; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.Weather.Interfaces.IWeatherSerializableObject'></a>

## IWeatherSerializableObject Interface

Defines the interface for serializable weather objects\.

```csharp
public interface IWeatherSerializableObject : DiGi.Weather.Interfaces.IWeatherObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [Weather&lt;TWeatherRecord&gt;](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_ 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>')  
↳ [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')  
↳ [IWeatherRecord](DiGi.Weather.Interfaces.md#DiGi.Weather.Interfaces.IWeatherRecord 'DiGi\.Weather\.Interfaces\.IWeatherRecord')

Implements [IWeatherObject](DiGi.Weather.Interfaces.md#DiGi.Weather.Interfaces.IWeatherObject 'DiGi\.Weather\.Interfaces\.IWeatherObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
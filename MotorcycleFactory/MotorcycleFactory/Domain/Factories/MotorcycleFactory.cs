using MotorcycleFactory.Domain.Models.Motorcycles;
using MotorcycleFactory.Domain.Models.Motorcycles.Engines;

namespace MotorcycleFactory.Domain.Factories;
public static class MotorcycleFactory
{
    /* Private fields region */
    private static readonly Dictionary<string, Func<int?, Color?, Motorcycle>> _map = new()
    {
        ["R3"] = (year, color) => CreateYamaha("R3", year, color),
        ["MT-03"] = (year, color) => CreateYamaha("MT-03", year, color),

        ["Ninja 300"] = (year, color) => CreateKawasaki("Ninja 300", year, color),
        ["Z300"] = (year, color) => CreateKawasaki("Z300", year, color),

        ["CBR 250RR"] = (year, color) => CreateHonda("CBR 250RR", year, color),
        ["CB 300F"] = (year, color) => CreateHonda("CB 300F", year, color)
    };

    /* Public methods region */
    public static Motorcycle Create(string model, int? year = null, Color? color = null)
    {
        if (!_map.TryGetValue(model, out var factoryFunc))
            throw new ArgumentException($"Model '{model}' not found.");

        return factoryFunc(year, color);
    }

    
    /* Private methods region */
    private static Motorcycle CreateKawasaki(string model, int? year, Color? color)
    {
        var validYear = model switch
        {
            "Ninja 300" => year > 2012 && year <= 2026 ? year : 2012,
            "Z300" => year > 2015 && year <= 2018 ? year : 2015,
            _ => throw new ArgumentException($"Unknown model: {model}")
        };

        var bike = new KawasakiMotorcycle(model, validYear, color ?? Color.Green);

        bike.Engine = CreateKawasakiEngine(model);

        return bike;
    }

    private static Engine CreateKawasakiEngine(string model)
    {
        return model switch
        {
            "Ninja 300" or "Z300" => new Engine
            {
                Cylinders = 2,
                EngineType = EngineType.ICE,
                CylinderCapacity = 296.0f,
                HorsePower = 39.0f,
                Torque = 2.8f,
                TransmissionSpeeds = 6
            },

            _ => throw new ArgumentException($"No engine spec for {model}")
        };
    }

    private static Motorcycle CreateYamaha(string model, int? year, Color? color)
    {
        var bike = new YamahaMotorcycle(model, year, color);

        bike.Engine = model switch
        {
            "R3" or "MT-03" => new Engine
            {
                Cylinders = 2,
                EngineType = EngineType.ICE,
                CylinderCapacity = 321.0f,
                HorsePower = 42.0f,
                Torque = 3.0f,
                TransmissionSpeeds = 6
            },

            _ => throw new ArgumentException($"No engine spec for {model}")
        };

        return bike;
    }

    private static Motorcycle CreateHonda(string model, int? year, Color? color)
    {
        var bike = new HondaMotorcycle(model, year, color);

        bike.Engine = model switch
        {
            "CBR 250RR" => new Engine
            {
                Cylinders = 2,
                EngineType = EngineType.ICE,
                CylinderCapacity = 249.0f,
                HorsePower = 41.0f,
                Torque = 2.5f,
                TransmissionSpeeds = 6
            },

            "CB 300F" => new Engine
            {
                Cylinders = 1,
                EngineType = EngineType.ICE,
                CylinderCapacity = 293.0f,
                HorsePower = 24.0f,
                Torque = 2.6f,
                TransmissionSpeeds = 6
            },

            _ => throw new ArgumentException($"No engine spec for {model}")
        };

        return bike;
    }
}
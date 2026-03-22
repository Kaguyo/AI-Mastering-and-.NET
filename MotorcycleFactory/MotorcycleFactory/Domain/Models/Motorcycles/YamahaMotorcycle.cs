using MotorcycleFactory.Domain.Models.Motorcycles;
using MotorcycleFactory.Domain.Models.Motorcycles.Engines;

namespace MotorcycleFactory.Domain.Models.Motorcycles;
public class YamahaMotorcycle : Motorcycle
{
    public YamahaMotorcycle(string model, int? year, Color? color)
        : base(model, "Yamaha", year, color){}
}
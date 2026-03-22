using MotorcycleFactory.Domain.Models.Motorcycles;
using MotorcycleFactory.Domain.Models.Motorcycles.Engines;

namespace MotorcycleFactory.Domain.Models.Motorcycles;
public class HondaMotorcycle : Motorcycle
{
    public HondaMotorcycle(string model, int? year, Color? color)
        : base(model, "Honda", year, color){}
}
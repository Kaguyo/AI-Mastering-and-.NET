using MotorcycleFactory.Domain.Models.Motorcycles;

namespace MotorcycleFactory.Domain.Models.Motorcycles;
public class KawasakiMotorcycle : Motorcycle
{
    public KawasakiMotorcycle(string model, int? year, Color? color)
        : base(model, "Kawasaki", year, color){}
}
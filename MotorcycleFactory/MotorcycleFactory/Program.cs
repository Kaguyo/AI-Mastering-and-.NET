using MotorcycleFactory.Domain.Models.Motorcycles;

namespace MotorcycleFactory;

class Program
{
    static void Main(string[] args)
    {
        List<Motorcycle> motorcycles = new List<Motorcycle>();
       
        SeedData(motorcycles);
        
        Console.ReadKey();
    }

    public static void SeedData(List<Motorcycle> motorcycles)
    {
        motorcycles.Add(Domain.Factories.MotorcycleFactory.Create("Ninja 300", 2025, Color.Black));
        motorcycles.Add(Domain.Factories.MotorcycleFactory.Create("R3", 2023, Color.Red));
        motorcycles.Add(Domain.Factories.MotorcycleFactory.Create("MT-03", 2025));
        motorcycles.Add(Domain.Factories.MotorcycleFactory.Create("Z300", 2020));

        foreach (var motorcycle in motorcycles)
        {
            Console.WriteLine(motorcycle);
            Console.WriteLine("------------");
        }
    }
}

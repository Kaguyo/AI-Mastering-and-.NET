using MotorcycleFactory.Interfaces;
using MotorcycleFactory.Models;

namespace MotorcycleFactory;

class Program
{
    static void Main(string[] args)
    {
        List<IMotorcycle> motorcycles = new List<IMotorcycle>();
       
        
        SeedData(motorcycles);

        foreach (var motorcycle in motorcycles)
        {
            Console.WriteLine(motorcycle);
            Console.WriteLine("------------");
        }
        
        Console.ReadKey();
    }

    public static void SeedData(List<IMotorcycle> motorcycles)
    {
        motorcycles.Add(new MotorcycleBase { Model = "R3", Make = "Yamaha", Year = 2025 });
        motorcycles.Add(new MotorcycleBase { Model = "MT-03", Make = "Yamaha", Year = 2025, Color = "Black" });
        motorcycles.Add(new MotorcycleBase { Model = "CBR 250RR", Make = "Honda", Year = 2025, Color = "Red" });
        motorcycles.Add(new MotorcycleBase { Model = "CB 300F", Make = "Honda", Year = 2025, Color = "Black" });
        motorcycles.Add(new MotorcycleBase { Model = "Ninja 300", Make = "Kawasaki", Year = 2025, Color = "Green" });
        motorcycles.Add(new MotorcycleBase { Model = "Z300", Make = "Kawasaki", Year = 2015 });
    }
}

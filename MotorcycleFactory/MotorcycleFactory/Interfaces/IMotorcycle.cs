using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleFactory.Interfaces
{
    internal interface IMotorcycle
    {
        string Model { get; set; }
        string Make { get; set; }
        int? Year { get; set; }
        string? Color { get; set; }
    }
}

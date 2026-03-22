using MotorcycleFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleFactory.Models
{
    public class MotorcycleBase : IMotorcycle
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int? Year { get; set; }
        public string? Color { get; set; }

        public override string ToString()
        {
            return sanitizeData();
        }

        private string sanitizeData()
        {
            string sanitizedData = string.Empty;
            if (String.IsNullOrEmpty(Model) || String.IsNullOrEmpty(Make))
                return sanitizedData;
            
            sanitizedData = $"Model: {Model}\nMake: {Make}";
            sanitizedData += Year != null ? $"\nYear: {Year}": null;
            sanitizedData += Color != null ? $"\nColor: {Color}": null;
            
            return sanitizedData;
        }
    }
}

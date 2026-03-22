using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleFactory.Domain.Models.Motorcycles;
public enum Color
{
    Red,
    Green,
    Blue,
    Yellow,
    Orange,
    Black,
    Gray,
    Purple,
    Pink,
    Brown,
    Cyan
}
public class Motorcycle(string model, string make, int? year, Color? color)
{
    public string Model { get; set; } = model;
    public string Make { get; set; } = make;
    public int? Year { get; set; } = year;
    public Color? Color { get; set; } = color;
    public Engines.Engine Engine { get; set; }

    public override string ToString()
    {
        return sanitizeData();
    }

    private string sanitizeData()
    {
        string sanitizedData = string.Empty;
        if (string.IsNullOrEmpty(Model) || string.IsNullOrEmpty(Make))
            return sanitizedData;

        sanitizedData = $"Model: {Model}\nMake: {Make}";
        sanitizedData += Year != null ? $"\nYear: {Year}": null;
        sanitizedData += Color != null ? $"\nColor: {Color}": null;
        sanitizedData += $"\n{Engine}";

        return sanitizedData;
    }
}


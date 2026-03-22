using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleFactory.Domain.Models.Motorcycles.Engines
{
    public enum EngineType
    {
        ICE,
        HEV,
        PHEV,
        MHEV,
        BEV
    }
    public class Engine
    {
        public int? Cylinders { get; set; }
        public float? CylinderCapacity { get; set; }
        public int? Watts { get; set; }
        public float HorsePower { get; set; }
        public float Torque { get; set; }
        public int TransmissionSpeeds { get; set; }
        public EngineType EngineType { get; set; }

        public override string ToString()
        {
            return sanitizeData();
        }
        private string sanitizeData()
        {
            string sanitizedData = string.Empty;

            sanitizedData = CylinderCapacity != null ? $"CC: {getCylinderCapacity()}\n" : null;
            sanitizedData += $"HP: {getHorsePower()}" +
                             $"\nTorque: {getTorque()} kgf.m" +
                             $"\nTransmissions: {TransmissionSpeeds}" +
                             $"\nEngine Type: {EngineType}";

            return sanitizedData;
        }

        private string getHorsePower()
        {
            return this.HorsePower.ToString("F1");
        }
        private string getTorque()
        {
            return this.Torque.ToString("F1");
        }
        private string getCylinderCapacity()
        {
            return this.CylinderCapacity?.ToString("F1") ?? string.Empty;
        }
    }

}

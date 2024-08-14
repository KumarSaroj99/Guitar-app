using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class Guitar
    {
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; } // e.g., Acoustic, Electric
        public string Wood { get; set; } // e.g., Maple, Mahogany
        public decimal Price { get; set; }

        public Guitar(string serialNumber, string model, string manufacturer, string type, string wood, decimal price)
        {
            SerialNumber = serialNumber;
            Model = model;
            Manufacturer = manufacturer;
            Type = type;
            Wood = wood;
            Price = price;
        }

        public override string ToString()
        {
            return $"Serial Number: {SerialNumber}\n" +
                $" Model: {Model}\n" +
                $" Manufacturer: {Manufacturer}\n" +
                $" Type: {Type}, Wood: {Wood}\n" +
                $" Price: {Price:C}\n" +
                $"";
        }
    }
}


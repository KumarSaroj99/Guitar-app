using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(Guitar guitar)
        {
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            return guitars.Find(g => g.SerialNumber.Equals(serialNumber, StringComparison.OrdinalIgnoreCase));
        }

        public List<Guitar> SearchGuitars(string model = null, string manufacturer = null, string type = null, string wood = null)
        {
            var results = new List<Guitar>();

            foreach (var guitar in guitars)
            {
                if ((!string.IsNullOrEmpty(model) && !guitar.Model.Equals(model, StringComparison.OrdinalIgnoreCase)) ||
                    (!string.IsNullOrEmpty(manufacturer) && !guitar.Manufacturer.Equals(manufacturer, StringComparison.OrdinalIgnoreCase)) ||
                    (!string.IsNullOrEmpty(type) && !guitar.Type.Equals(type, StringComparison.OrdinalIgnoreCase)) ||
                    (!string.IsNullOrEmpty(wood) && !guitar.Wood.Equals(wood, StringComparison.OrdinalIgnoreCase)))
                {
                    continue;
                }
                results.Add(guitar);
            }

            return results;
        }

        public List<Guitar> GetAllGuitars()
        {
            return new List<Guitar>(guitars);
        }
    }
}

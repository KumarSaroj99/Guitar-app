using GuitarApp.Models;

namespace GuitarApp
{
    internal class Program
    {
        static Inventory inventory = new Inventory();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Guitar Inventory Management");
                Console.WriteLine("1. Add Guitar");
                Console.WriteLine("2. Search Guitar");
                Console.WriteLine("3. View All Guitars");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddGuitar();
                        break;
                    case "2":
                        SearchGuitar();
                        break;
                    case "3":
                        ViewAllGuitars();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AddGuitar()
        {
            Console.Write("Enter Serial Number: ");
            string serialNumber = Console.ReadLine();
            Console.Write("Enter Model: ");
            string model = Console.ReadLine();
            Console.Write("Enter Manufacturer: ");
            string manufacturer = Console.ReadLine();
            Console.Write("Enter Type (Acoustic/Electric): ");
            string type = Console.ReadLine();
            Console.Write("Enter Wood Type: ");
            string wood = Console.ReadLine();
            Console.Write("Enter Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Guitar guitar = new Guitar(serialNumber, model, manufacturer, type, wood, price);
            inventory.AddGuitar(guitar);
            Console.WriteLine("Guitar added successfully! Press any key to continue...");
            Console.ReadKey();
        }

        static void SearchGuitar()
        {
            Console.Write("Enter Model to Search (leave blank to skip): ");
            string model = Console.ReadLine();
            Console.Write("Enter Manufacturer to Search (leave blank to skip): ");
            string manufacturer = Console.ReadLine();
            Console.Write("Enter Type to Search (leave blank to skip): ");
            string type = Console.ReadLine();
            Console.Write("Enter Wood Type to Search (leave blank to skip): ");
            string wood = Console.ReadLine();

            var results = inventory.SearchGuitars(model, manufacturer, type, wood);

            if (results.Count == 0)
            {
                Console.WriteLine("No guitars found.");
            }
            else
            {
                Console.WriteLine("Guitars found:");
                foreach (var guitar in results)
                {
                    Console.WriteLine(guitar);

                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void ViewAllGuitars()
        {
            var guitars = inventory.GetAllGuitars();
            if (guitars.Count == 0)
            {
                Console.WriteLine("No guitars in inventory.");
            }
            else
            {
                Console.WriteLine("All Guitars in Inventory:");
                foreach (var guitar in guitars)
                {
                    Console.WriteLine(guitar);
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

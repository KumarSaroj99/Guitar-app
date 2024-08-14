using GuitarApp.Models;

namespace GuitarApp
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            ViewController viewController = new ViewController(new Inventory());
            viewController.StartView();
        }
    }
}

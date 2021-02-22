using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop
{
    public class Products
    {
        public Products()
        {
        }

        public Products(int id, string name, string manufecturer, double price)
        {
            Id = id;
            Name = name;
            Price = price;
            Manufacturer = manufecturer;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Manufacturer { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID:{Id} Name:{Name} Price:{Price} Manufecturer: {Manufacturer} ");
        }

        public void Display(int i)
        {
            Console.WriteLine($"{i}. Name:{Name} Manufecturer:{Manufacturer} Price:{Price}");
        }
    }
}

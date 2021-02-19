using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop
{
    public class User
    {
        public User(string name, string phoneNumber, string email)
        {
            name = Name;
            phoneNumber = PhoneNumber;
            email = Email;
        }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void GetUser()
        {
            Console.WriteLine("Please, enter your name");
            Name = Console.ReadLine();
            Console.WriteLine("Please, enter your phone number");
            PhoneNumber = Console.ReadLine();
            Console.WriteLine("Please, enter your Email");
            Email = Console.ReadLine();
            if (Name != null && PhoneNumber != null && Email != null)
            {
                Console.WriteLine($"Hello {Name}, Welcome!");
            }
            else
            {
                Console.WriteLine("Sorry, not all required fields are filled");
            }
        }
    }
}

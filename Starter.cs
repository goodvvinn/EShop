using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop
{
   public class Starter
    {
        public Starter()
        {
            Run();
        }

        public static User GetUser()
        {
            User user = new User();
            while (true)
            {
                Console.WriteLine("****Welcome to EStore****");
                Console.WriteLine();
                Console.WriteLine("*******Please, enter your name*******");
                user.Name = Console.ReadLine();
                Console.WriteLine("Please, enter your phone number");
                user.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Please, enter your Email");
                user.Email = Console.ReadLine();
                Console.WriteLine("Please, enter the amount of money you want to spend");
                user.Money = double.Parse(Console.ReadLine());
                if (user.Name != string.Empty && user.PhoneNumber != string.Empty && user.Email != string.Empty && user.Money > 0)
                {
                    Console.WriteLine($"Hello {user.Name}, Welcome! For today we have: ");
                    return user;
                }
                else
                {
                    Console.WriteLine("Sorry, not all required fields are filled");
                    Console.WriteLine("Do yoy want to continue? (Y/N)");
                    string answer = Console.ReadLine();
                    if (answer == "N")
                    {
                        break;
                    }

                    Console.WriteLine();
                }
            }

            return user;
        }

        public void Run()
        {
            string answer = "Yes";

            Items shop = new Items();
            do
            {
                User user = new User();
                user = GetUser();
                if (user.Name != "NoName")
                {
                    // shopping
                    shop.Display();
                }

                Cart cart = new Cart();

                string userAnswer = "Y";
                while (userAnswer == "Y")
                {
                    int purchase;

                    Console.WriteLine("Chose the number of item you want to buy?");
                    string input = Console.ReadLine();
                    bool result = int.TryParse(input, out purchase);
                    if (result == true && purchase < shop.Devices.Length)
                    {
                        int n = 1;
                        Console.WriteLine("How many items you want to buy?");
                        n = Convert.ToInt32(Console.ReadLine());
                        cart.Add(shop.Devices[purchase], n);
                        Console.WriteLine("You have add {0} to cart", input);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, threr is no such item in our price, try again");
                    }

                    Console.WriteLine("Do you want to continue shopping? (Y/N)");
                    userAnswer = Console.ReadLine();
                }

                cart.Display();
                double totalPrice = cart.GetTotalPrice();
                Console.WriteLine($"Total price is {totalPrice} UAH");
                user.Pay(totalPrice);

                Console.WriteLine("Do you want to continue? (Y/N)");
                answer = Console.ReadLine();
            }
            while (answer == "Y");
         }
    }
}

using System;

namespace EShop
{
    public class User
    {
        public User()
        {
            Name = "NoName";
        }

        public User(string name, string phoneNumber, string email, double money)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Money = money;
        }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public double Money { get; set; }

        public void Pay(double total)
        {
            if (total > Money)
            {
                Console.WriteLine("Not enough money");
            }
            else
            {
                double balance = Money - total;
                Console.WriteLine($"Thank you for the visit, your card balance is: {balance} UAH");
            }
        }
    }
}

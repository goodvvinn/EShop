using System;

namespace EShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User consumer = new User(
                "Alex",
                "066-361-87-93",
                "goodvvinn@gmail.com");
            consumer.GetUser();
        }
    }
}

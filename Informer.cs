using System;

namespace EShop
{
    public class Informer
    {
            public int Message { get; set; }

            public bool SendInfo()
            {
                Console.WriteLine($"You have bought");
                return true;
            }
    }
}

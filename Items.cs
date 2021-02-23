using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop
{
    public class Items
    {
        public Items()
        {
            Devices = new Products[]
            {
                new Products(1,  "P5S", "ASUS", 1000),
                new Products(2,  "Hyper Memory",  "Corsair", 800),
                new Products(3,  "CoreI3",  "Intel",  1500),
                new Products(4, "SSDNow",  "Transcend", 700)
            };
        }

        public Products[] Devices { get; set; }
        public void Display()
        {
            int index = 1;
            foreach (var item in Devices)
            {
                item.Display(index);
                index++;
            }
        }
    }
}

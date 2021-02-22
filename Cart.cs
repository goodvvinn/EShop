using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop
{
    public class Cart
{
        public Cart()
        {
            Lgoods = new List<Goods>();
        }

        public List<Goods> Lgoods { get; set; }
        public void Add(Products prod, int n)
        {
            bool flag = false;
            foreach (var item in Lgoods)
            {
                if (item.Product.Id == prod.Id)
                {
                    item.Number += n;
                    item.TotalPrice = item.Product.Price * n;
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                Goods g = new Goods(prod, n);
                Lgoods.Add(g);
            }
        }

        public void Display()
        {
            Console.WriteLine("Your items list:");
            foreach (var item in Lgoods)
            {
                Console.WriteLine($"{item.Product.Name}, {item.TotalPrice} UAH, {item.Number} pc.");
            }
        }

        public void Update(int index, int num)
        {
            Lgoods[index].Number += num;
            Lgoods[index].TotalPrice = Lgoods[index].Product.Price * num;
        }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var item in Lgoods)
            {
                total += item.TotalPrice;
            }

            return total;
        }
    }
}

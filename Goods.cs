using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop
{
    public class Goods
    {
            public Goods(Products p, int n)
            {
            Product = p;
            Number = n;
            TotalPrice = p.Price * n;
            }

            public Products Product { get; set; }
            public int Number { get; set; }
            public double TotalPrice { get; set; }
    }
}

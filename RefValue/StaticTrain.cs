using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValue
{
    public static class Product
    {
        public static int AllProCount;
        public static void Show() { Console.WriteLine(AllProCount); }

    }
    class Vendor
    {
        public static void BuyPro(int val)
        {
            Product.AllProCount += val;
        }
        public static void SellPro(int val)
        {
            Product.AllProCount -= val;
        }
    }

    class Customer
    {
        public static void BuyPro(int val)
        {
            Product.AllProCount -= val;
        }
    }
}

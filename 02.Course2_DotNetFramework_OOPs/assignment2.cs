using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pname;

            int price;
            int quantity;
            int total;
            int dis;
            int final;

            Console.WriteLine("Product Name : ");
            pname = Console.ReadLine();

            Console.WriteLine("Unit Price : ");
            price = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantity: ");
            quantity = int.Parse(Console.ReadLine());

            total = (price * quantity);

            if (quantity < 10)
            {
                dis = 0;
                final = total - dis;
            }
            else if (quantity > 10 && quantity <= 20)
            {
                dis = total / 10;
                final = total - dis;
            }

            else if (quantity > 20 && quantity <= 30)
            {
                dis = (total / 10) * 2;
                final = total - dis;
            }
            else
            {
                dis = (total / 10) * 3;
                final = total - dis;

            }

            Console.WriteLine("Total Amount :" + total);
            Console.WriteLine("Discount Amount :" + dis);
            Console.WriteLine("Final Amount :" + final);

            Console.ReadLine();

        }
    }
}
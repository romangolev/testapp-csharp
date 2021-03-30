using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //int discount = Convert.ToInt32(Console.ReadLine());
            int discount = 13;

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);


            //your code goes here

            for (int i = 0; i < 6; i++)
            {
                string[] names = coffee.Keys.ToArray();
                int[] prices = coffee.Values.ToArray();
                double newprice = prices[i]*(1-discount*0.01);
                Console.Write(names[i]);
                Console.Write(": ");
                Console.WriteLine(Math.Round(newprice,0 ,MidpointRounding.ToPositiveInfinity));
            }

        }
    }
}
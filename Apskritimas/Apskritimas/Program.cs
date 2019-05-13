using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apskritimas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rng = new Random();
            int kiekis = rng.Next(100);
            int x = 1;
            int y = 5;
            int R = 10;
            int[] xai = new int[kiekis];
            int[] yai = new int[kiekis];
            for (int i = 0; i < kiekis; i++)
            {
                xai[i] = rng.Next(-20, 20);
                yai[i] = rng.Next(-20, 20);
            }

            int kiekisPagalSalyga = 0;
            for (int i = 0; i < kiekis; i++)
            {
                var d = Math.Sqrt(Math.Pow((x - xai[i]), 2) + Math.Pow((y - yai[i]), 2));
                if (d < R)
                {
                    kiekisPagalSalyga++;
                }
            }
            Console.WriteLine("Patenkanciu i apskritima kiekis: " + kiekisPagalSalyga);
        }
    }
}
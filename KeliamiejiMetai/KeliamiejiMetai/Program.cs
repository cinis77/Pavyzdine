using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeliamiejiMetai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i < DateTime.Today.Year; i++)
            {
                if (i % 100 == 0)
                {
                    if (i % 400 == 0)
                    {
                        Console.WriteLine("Keliamieji metai " + i);
                    }
                }
                else if (i % 4 == 0)
                {
                    Console.WriteLine("Keliamieji metai " + i);
                }
            }
        }
    }
}
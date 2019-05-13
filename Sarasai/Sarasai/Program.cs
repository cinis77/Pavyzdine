using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> sarasas = new List<int>();
            string ats = null;
            do
            {
                Console.WriteLine("Iveskite skaiciu");
                int sk = Convert.ToInt32(Console.ReadLine());
                sarasas.Add(sk);
                Console.WriteLine("Jei norite testi iveskite t");
                ats = Console.ReadLine();
            } while (ats == "t");

            Console.WriteLine("Suma: " + sarasas.Sum());
            Console.WriteLine("Vidurkis: " + sarasas.Average());
            Console.WriteLine("Didziausias skaicius: " + sarasas.Max());
            Console.WriteLine("Maziausias skaicius: " + sarasas.Min());
            Console.WriteLine("Pirmas skaicius: " + sarasas.First());
            Console.WriteLine("Paskutinis skaicius: " + sarasas.Last());
        }
    }
}
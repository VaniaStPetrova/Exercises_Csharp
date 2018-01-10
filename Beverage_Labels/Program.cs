using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int EnergyContent100ml = int.Parse(Console.ReadLine());
            int SugarContent100ml = int.Parse(Console.ReadLine());

            double EnergyKcal = volume * EnergyContent100ml/100.0;
            double SugarG = volume * SugarContent100ml/100.0;

            Console.WriteLine("{0}ml {1}: ", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", EnergyKcal, SugarG);
        }
    }
}

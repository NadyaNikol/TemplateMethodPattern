using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ManCalculation manCalculation = new ManCalculation();
            WomanCalculation womanCalculation = new WomanCalculation();
            ChildrenCalculation childrenCalculation = new ChildrenCalculation();

            Random rnd = new Random();
            int resMan = manCalculation.Game(rnd.Next(10), rnd.Next(20));
            int resWoman = womanCalculation.Game(rnd.Next(10), rnd.Next(20));
            int resChild = childrenCalculation.Game(rnd.Next(10), rnd.Next(20));

            Console.WriteLine("Результат биатлона:");
            Console.WriteLine($" - мужчины {resMan}");
            Console.WriteLine($" - женщины {resWoman}");
            Console.WriteLine($" - дети {resChild}");


        }
    }
}

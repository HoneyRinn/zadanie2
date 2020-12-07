using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triug
{
    class Program
    {

        static void Main(string[] args)
        {
            zad2 trg1 = new zad2(7, 7, 7);
            zad2 trg2 = new zad2(7, 6, 3);
            zad2 trg3 = new zad2(5, 5, 3);
            zad2 trg4 = new zad2(4, 5, 3);
            zad2 trg5 = new zad2(8, 8, 8);
            zad2 trg6 = new zad2(9, 53, 2);

            Console.WriteLine("Равносторонние треугольники : \n");
            foreach (string trg in zad2.equalTrgs)
            {
                Console.WriteLine(trg + "\n");
            }
            Console.WriteLine();

            Console.WriteLine("Равнобедренные треугольники : \n");
            foreach (string trg in zad2.esoscleTrgs)
            {
                Console.WriteLine(trg + "\n");
            }
            Console.WriteLine();

            Console.WriteLine("Прямоугольные треугольники : \n");
            foreach (string trg in zad2.rectangleTrgs)
            {
                Console.WriteLine(trg + "\n");
            }
            Console.WriteLine();

            Console.WriteLine("Произвольные треугольники : \n");
            foreach (string trg in zad2.randomTrgs)
            {
                Console.WriteLine(trg + "\n");
            }
            Console.WriteLine();

            Console.WriteLine("Треугольники, которые нельзя построить : \n");
            foreach (string trg in zad2.notTrgs)
            {
                Console.WriteLine(trg + "\n");
            }
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}

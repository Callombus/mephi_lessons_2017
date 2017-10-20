using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Tests
    {
        static void Main(string[] args)
        {
            Integration intgr = new Integration();
            double e = 0.01;


            if (Math.Abs(intgr.Rectangle(1, 1, 5, 1000)) - 0.2566 > e)
                Console.WriteLine("Неверное значение для функции 1");
            else Console.WriteLine("Верное значение для функции 1");
            if (Math.Abs(intgr.Trapezia(1, 1, 5, 1000)) - 0.2566 > e)
                Console.WriteLine("Неверное значение для функции 1");
            else Console.WriteLine("Верное значение для функции 1");
            if (Math.Abs(intgr.Simpson(1, 1, 5, 1000)) - 0.2566 > e)
                Console.WriteLine("Неверное значение для функции 1");
            else Console.WriteLine("Верное значение для функции 1");


            if (Math.Abs(intgr.Rectangle(2, 1, 5, 1000)) - 1.8004 > e)
                Console.WriteLine("Неверное значение для функции 2");
            else Console.WriteLine("Верное значение для функции 2");
            if (Math.Abs(intgr.Trapezia(2, 1, 5, 1000)) - 1.8004 > e)
                Console.WriteLine("Неверное значение для функции 2");
            else Console.WriteLine("Верное значение для функции 2");
            if (Math.Abs(intgr.Simpson(2, 1, 5, 1000)) - 1.8004 > e)
                Console.WriteLine("Неверное значение для функции 2");
            else Console.WriteLine("Верное значение для функции 2");


            if (Math.Abs(intgr.Rectangle(3, 1, 5, 1000)) - 160 > e)
            Console.WriteLine("Неверное значение для функции 3");
            else Console.WriteLine("Верное значение для функции 3");
            if (Math.Abs(intgr.Trapezia(3, 1, 5, 1000)) - 160 > e)
                Console.WriteLine("Неверное значение для функции 3");
            else Console.WriteLine("Верное значение для функции 3");
            if (Math.Abs(intgr.Trapezia(3, 1, 5, 1000)) - 160 > e)
                Console.WriteLine("Неверное значение для функции 3");
            else Console.WriteLine("Верное значение для функции 3");


            if (Math.Abs(intgr.Rectangle(4, 1, 5, 1000)) - 29.33 > e)
                Console.WriteLine("Неверное значение для функции 4");
            else Console.WriteLine("Верное значение для функции 4");
            if (Math.Abs(intgr.Trapezia(4, 1, 5, 1000)) - 29.33 > e)
                Console.WriteLine("Неверное значение для функции 4");
            else Console.WriteLine("Верное значение для функции 4");
            if (Math.Abs(intgr.Simpson(4, 1, 5, 1000)) - 29.33 > e)
                Console.WriteLine("Неверное значение для функции 4");
            else Console.WriteLine("Верное значение для функции 4");


            if (Math.Abs(intgr.Rectangle(5, 1, 5, 1000)) - 197.33 > e)
                Console.WriteLine("Неверное значение для функции 5");
            else Console.WriteLine("Верное значение для функции 5");
            if (Math.Abs(intgr.Trapezia(5, 1, 5, 1000)) - 197.33 > e)
                Console.WriteLine("Неверное значение для функции 5");
            else Console.WriteLine("Верное значение для функции 5");
            if (Math.Abs(intgr.Trapezia(5, 1, 5, 1000)) - 197.33 > e)
                Console.WriteLine("Неверное значение для функции 5");
            else Console.WriteLine("Верное значение для функции 5");

            Console.ReadLine();

        }
    }
}

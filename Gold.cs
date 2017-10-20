using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SharedProject1
{
    public class Gold
    {

        double function(double x, int i)
        {
            switch (i)
            {
                case 1: return Math.Pow(x + 1, 3) - x;
                case 2: return Math.Pow(x + 2, 3) - 5* Math.Pow(x, 3);
                case 3: return Math.Pow(x, 4) - 10* Math.Pow(x, 2);
                case 4: return Math.Pow(x, 2) - Math.Pow(x, 3);
                case 5: return Math.Pow(x + 1, 5) - x;
                case 6: return Math.Sin(x);
                case 7: return Math.Cos(x);
                case 8: return Math.Sin(x + Math.PI);
                case 9: return Math.Pow(x, 3) - Math.Sin(x);
                case 10: return Math.Sin(x) * Math.Cos(x);
                default: return x;
            }



        }

        // метод деления отрезка пополам

        public double FMin(double a, double b, double e, double d, int i)
        {

            {
                while ((b - a) / 2 >= e)
                {
                    double x1 = (a + b - d) / 2;
                    double x2 = (a + b + d) / 2;

                    if (function(x1, i) > function(x2, i))
                    {
                        a = x1;
                    }
                    else
                    {
                        b = x2;
                    }
                }
                return (a + b) / 2;
            }
        }

       public double FMax(double a, double b, double e, double d, int i)
        {

            {
                while ((b - a) / 2 >= e)
                {
                    double x1 = (a + b - d) / 2;
                    double x2 = (a + b + d) / 2;

                    if (function(x1, i) < function(x2, i))
                    {
                        a = x1;
                    }
                    else
                    {
                        b = x2;
                    }
                }
                return (a + b) / 2;
            }
        }


        // метод золотого сечения

        public double GoldSMin(double a, double b, double e, int i)
        {
            double Phi = (1 + Math.Sqrt(5)) / 2;

            double x1 = b - (b - a) / Phi;

            double x2 = a + (b - a) / Phi;

            while ((b - a) / 2 >= e)
            {
                if (function(x1, i) > function(x2, i))
                {
                    a = x1;
                    x1 = x2;
                    x2 = b - (x1 - a);
                }
                else
                {
                    b = x2;
                    x2 = x1;
                    x1 = a + (b - x2);
                }
            }

            return (a + b) / 2;
        }

        public double GoldSMax(double a, double b, double e, int i)
        {
            double Phi = (1 + Math.Sqrt(5)) / 2;

            double x1 = b - (b - a) / Phi;

            double x2 = a + (b - a) / Phi;

            while ((b - a) / 2 >= e)
            {
                if (function(x1, i) < function(x2, i))
                {
                    a = x1;
                    x1 = x2;
                    x2 = b - (x1 - a);
                }
                else
                {
                    b = x2;
                    x2 = x1;
                    x1 = a + (b - x2);
                }
            }

            return (a + b) / 2;
        }

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Integration
    {
 
     public double function(double x, int k)
        {
             switch (k)
            {
             case 1: return Math.Sin(x);
             case 2: return Math.Cos(x);
             case 3: return Math.Pow(x, 3) + 1;
             case 4: return Math.Pow(x, 2) - Math.Pow(x, 1);
             case 5: return Math.Pow(x, 3) + Math.Pow(x, 2);
             

             default:
                 return x;
                    }
 
 
     }
 
     public double Rectangle(int k, double a, double b, int n)
    {

            double h = (b - a) / n;
            double sum = 0;
            int i;
            for (i = 0; i <= n; i++)
            {
             sum += function(a + h * (i + 0.5), k);
             }

        
                return sum * h;
            }
 
     public double Trapezia(int k, double a, double b, int n)
    {
            double h = (b - a) / n;
            double sum = 0;
            double x;
            int i;
            for (i = 1; i <= n; i++)
                        {
                x = a + i * h;
                sum += function(x, k);
                        }
            return h * (sum + (function(a, k) + function(b, k))/2);
            }
 
     public double Simpson(int k, double a, double b, int n)
    {
            double h = (b - a) / n;
            double sum = 0;
            double x;
                for (x = a; x <= b - 2 * h; x += 2 * h)
        {
            sum += 2 * function(x + 2 * h, k) +
             +4 * function(x + h, k);
                    }
                return h / 3 * (sum + function(a, k) - function(b, k));
            }
 }
}

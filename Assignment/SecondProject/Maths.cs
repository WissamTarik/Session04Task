using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.SecondProject
{
    internal static class Maths
    {
        public static double Add(double x,double y)
        {
            return x + y;
        }
        public static double Subtract(double x,double y)
        {
            return x - y;
        }
       public static double Multiply(double x,double y)
        {
            return x * y;
        }
    public static double Divide(double x,double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Can't divide by zero");
                return 0;
            }
            return x / y;
        }
    }
}

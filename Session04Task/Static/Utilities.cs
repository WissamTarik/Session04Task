using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04Task.Static
{

    //Static class [Helper class]:Can't create an object from it so it can't contain
    //attributes
    internal  static class Utilities
    {
        //public int X { get; set; }
        //public int Y { get; set; }
        private static double pi;

        //public Utilities()
        //{
        //    pi = 3.14;
        //}
         static Utilities()//IT called  only with the first use of class
        {
            pi = 3.14;  
        }
        //Static method:Class member method
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }
        public static double PI
        {
            get
            {
                return pi;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04Task.Abstraction
{
    
    //abstract class:is a partial class not fully implemented class
    //concrete class is fully implemented class
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        //Abstract method:Is like virtual method but without implementation
        public abstract double getArea();

        //Abstract property:Is like virtual property but without implementation
        public abstract double Perimeter { get;  }
        public void Print()
        {
            Console.WriteLine("Hello world!");
        }
    }
}

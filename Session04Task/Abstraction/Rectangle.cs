using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04Task.Abstraction
{
    //Concrete class :Is fully implemented class
    internal class Rectangle:Shape
    {
        public override double Perimeter { get => (Dim01 + Dim02) *2; }
        public override double getArea()
        {
            return Dim02*Dim01;
        }
        public new void Print()
        {
            Console.WriteLine("Rectangle!");
        }
    }
}

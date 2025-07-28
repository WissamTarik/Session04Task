using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04Task.Abstraction
{
    internal class Square : Shape
    {
        public override double Perimeter { get { return Dim01 * 4; } }

        public override double getArea()
        {
            return Dim02 * Dim01;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04Task.Sealed
{
    internal class TypeA
    {
        public virtual int A { get; set; }
        public virtual void MyFunc()
        {
            Console.WriteLine("My fun from type A");
        }
    }
}

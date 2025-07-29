using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04Task.Sealed
{
    internal class TypeB:TypeA
    {
        public int B { get; set; }
        public sealed override void MyFunc()
        {
            base.MyFunc();
        }
        public sealed override int A { get => base.A; set => base.A = value; }
    }
}

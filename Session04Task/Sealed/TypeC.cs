using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04Task.Sealed
{
  
    //Sealed prevent inheritance from a specific class
    internal  sealed class TypeC:TypeB
    {
        public int C { get; set; }
        
    }
}

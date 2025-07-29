using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.FirstProject
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds) :this(seconds)
        {
            Hours = hours; 
            Minutes=minutes;
        }
        public Duration(int seconds)
        {
            Seconds = seconds;
        }
      
    }
}

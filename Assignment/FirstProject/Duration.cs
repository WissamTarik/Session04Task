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
        public override string ToString()
        {

            if (Hours == 0 && Minutes == 0)
            {
                Hours = (Seconds / 3600);
                Minutes = (Seconds % 3600) / 60;
                Seconds = Seconds % 60;
            }
            if (Hours == 0)
            {
                return $"Minutes :{Minutes}, Seconds :{Seconds} ";
            }

            return $" Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds} ";
        }

        public static Duration operator +(Duration left, Duration right)
        {

            return new Duration(left.Hours + right.Hours, left.Minutes + right.Minutes, left.Seconds + right.Seconds);
        }
        public static Duration operator +(Duration left, int right)
        {
            int TotalSeconds = left.Hours * 3600 + left.Minutes * 60 + left.Seconds + right;
            int hours = TotalSeconds / 3600;
            int minutes= (TotalSeconds % 3600) / 60;
            int seconds = TotalSeconds % 60; 

            return new Duration(hours, minutes, seconds);
        }
        public static Duration operator +(int left, Duration right)
        {
            return  right + left;
        }
        public static Duration operator -(Duration left,Duration right)
        {
            int totalSecondsLeft = left.Hours * 3600 + left.Minutes * 60 + left.Seconds;
            int totalRightTotal = right.Hours * 3600 + left.Minutes * 60 + left.Seconds;
            int difference=totalSecondsLeft-totalRightTotal;
            if (totalSecondsLeft < totalRightTotal)
            {
                difference = 0;
                Console.WriteLine("Left hand side is smaller than right hand side");
            }
            int HoursTotal = difference/3600;
            int MinutesTotal = (difference%3600)/60;
            int SecondsTotal = difference%60;
          
            return new Duration(HoursTotal, MinutesTotal, SecondsTotal);
        }
       public static Duration operator ++(Duration duration)
        {
            int total = duration.Minutes * 60 + duration.Hours * 3600 + duration.Seconds;
            total += 60;
            int TotalHours = total / 3600;
            int TotalMinutes = (total % 3600) / 60;
            int TotalSeconds = total % 60;

            return new Duration(TotalHours, TotalMinutes, TotalSeconds);
        
        }
       public static Duration operator --(Duration duration)
        {
            int total = duration.Minutes * 60 + duration.Hours * 3600 + duration.Seconds;
            total -= 60;
            if (total<0)
            {
                total = 0;
            }

            int TotalHours = total / 3600;
            int TotalMinutes = (total % 3600) / 60;
            int TotalSeconds = total % 60;
            
            return new Duration(TotalHours, TotalMinutes, TotalSeconds);
        }
        public static bool operator >(Duration left, Duration right) {

            int LeftTotal = left.Hours * 3600 + left.Minutes * 60 + left.Seconds;
            int RightTotal = right.Hours * 3600 + right.Minutes * 60 + right.Seconds;
            return LeftTotal > RightTotal;
        }
        public static bool operator <(Duration left, Duration right) {

            int LeftTotal = left.Hours * 3600 + left.Minutes * 60 + left.Seconds;
            int RightTotal = right.Hours * 3600 + right.Minutes * 60 + right.Seconds;
            return LeftTotal < RightTotal;
        }
    }
}

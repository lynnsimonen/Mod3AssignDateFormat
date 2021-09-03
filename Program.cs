using System.Text.RegularExpressions;
using System;

namespace Mod3AssignDateFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Module 3 - Assignment
            DateTime today = DateTime.Now;
            //DateTime Date = new DateTime(2019, 1, 22);
            Console.WriteLine("");
            
            Console.WriteLine($"1. {today:MMMM} {today:dd}, {today:yyyy}");
            Console.WriteLine($"2. {today:yyyy}.{today:MM}.{today:dd}");
            Console.WriteLine($"3. Day {today:dd} of {today:MMMM}, {today:yyyy}");
            Console.WriteLine($"4. Year: {today:yyyy}, Month: {today:MM}, Day: {today:dd}");
            Console.WriteLine($"5. {today,10:dddd}");
            Console.WriteLine($"6. {today,5:hh}:{today:mm} {today:tt} {today,17:dddd}");
            Console.WriteLine($"7. h:{today:hh}, m:{today:mm}, s:{today:ss}");
            Console.WriteLine($"8. {today:yyyy}.{today:MM}.{today:dd}.{today:hh}.{today:mm}.{today:ss}");
            Console.WriteLine("");
           
            var pi = Math.PI;
            Console.WriteLine("");
            Console.WriteLine($"1. {pi:C}");
            Console.WriteLine($"2. {pi,12:f3}");
            Console.WriteLine("");
        }
    }
}

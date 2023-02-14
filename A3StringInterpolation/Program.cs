
using System.Globalization;
using System.Threading.Channels;

namespace StringInterpolation
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             *Display the following using string interpolation:
             *From today’s date
             */
            var now = DateTime.Now;
            var dOD = DateTime.Now.DayOfWeek;
            //var dOD = DateTime.Now.DayOfWeek;
            //1._January 22, 2019 (right aligned in a 40 character field)
            Console.WriteLine($"{now:MMMM dd, yyyy}");
            //2._2019.01.22
            Console.WriteLine($"{now:yyyy.M.d}");
            //3._Day 22 of January, 2019
            Console.WriteLine($"{now:\"Day\" dd \"of\" MM, yyyy}");
            //4._Year: 2019, Month: 01, Day: 22
            Console.WriteLine($"{now:\"Year:\" yyyy, \"Month:\" MM, \"Day:\" dd}");
            //5._            Tuesday (10 spaces total, right aligned)
            Console.WriteLine($"{' ',10}{now:dddd}");
            Console.WriteLine("{0,10}", $"{now:dddd}");
            Console.WriteLine($"{dOD,10}");
            //6._     11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
            Console.WriteLine("{0,10} {1,10}", $"{now:t}", $"{now:dddd}");
            //7._h:11, m:01, s:27
            Console.WriteLine($"{now:\"h:\"hh, \"m:\"mm, \"s:\"ss}");
            //8._2019.01.22.11.01.27
            Console.WriteLine($"{now:yyyy.MM.dd.hh.mm.ss}");
            
            /*
             * If you have PI (3.1415) - use var pi = Math.PI;
             */
            var pi = Math.PI;
            //1. Output as currency
            Console.WriteLine($"{pi:C}");
            //2. Output as right-aligned (10 spaces), number with 3 decimal places
            Console.WriteLine($"{pi,10:C3}");
            
        }

    }
}
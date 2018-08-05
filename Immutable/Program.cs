using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            CalendarDay[] cd = new CalendarDay[7];
            cd[0] = new CalendarDay(1, 1, "meeting");
            cd[1] = new CalendarDay(2, 1, "tests");
            cd[2] = new CalendarDay(3, 1, "review");

            Calendar baseCal = new Calendar(cd);

            System.Console.WriteLine("Original");
            baseCal.Print();

            Calendar personalCal = baseCal.UpdateCalendar(new CalendarDay(1, 1, "urgent flight"));
            System.Console.WriteLine("Updated = new (Immutable)");
            personalCal.Print();
            System.Console.WriteLine("Original is still alive");

            baseCal.Print();
            System.Console.Read();
        }
    }
}

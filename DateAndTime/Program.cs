using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
          static Calendar calendar = CultureInfo.InvariantCulture.Calendar;
        static void Main(string[] args)
        {
            //TimeSpan timeSpan = new TimeSpan(60, 100, 14);

            //Console.WriteLine(timeSpan.Days + " days");
            //Console.WriteLine(timeSpan.Hours + " hours");
            //Console.WriteLine(timeSpan.Minutes + " minutes");
            //Console.WriteLine(timeSpan.Seconds + " seconds");

            //Console.WriteLine(timeSpan.Ticks + " ticks");

            //Console.WriteLine(timeSpan.TotalDays + " Total days") ;
            //Console.WriteLine(timeSpan.TotalHours + " Total hours");
            //Console.WriteLine(timeSpan.TotalMinutes + " Total minutes");
            //Console.WriteLine(timeSpan.TotalSeconds + " Total seconds");
            //Console.WriteLine(timeSpan.TotalMilliseconds + " Total miliseconds");

            //var start = DateTimeOffset.UtcNow;
            //var end = start.AddSeconds(45);

            //TimeSpan difference = end - start;

            //Console.WriteLine(difference.Minutes);
            //Console.WriteLine(difference.TotalMinutes);

            //*** Getting the week number ***

            //var start =new  DateTimeOffset(2007, 12, 31, 0, 0, 0, TimeSpan.Zero);

            //var week = calendar.GetWeekOfYear(start.DateTime, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            //Console.WriteLine(week);

            //*** Extending a date ***

            var contractDate = new DateTimeOffset(2019, 7, 1, 0, 0, 0, TimeSpan.Zero);
            Console.WriteLine(contractDate);

            contractDate = contractDate.AddMonths(6).AddTicks(-1); //Use AddTicks(-1) to make it until 23.59 the day before
            Console.WriteLine(contractDate);

        }
    }
}

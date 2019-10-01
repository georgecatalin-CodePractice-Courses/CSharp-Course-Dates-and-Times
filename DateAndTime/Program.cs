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
        static void Main(string[] args)
        {
            //var dateNow = DateTime.Now;

            //TimeZoneInfo sydneyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");

            //var sydneyTimeNow = TimeZoneInfo.ConvertTime(dateNow, sydneyTimeZone);

            //Console.WriteLine(dateNow);
            //Console.WriteLine(sydneyTimeNow);

            //    Console.WriteLine(DateTime.Now);
            //    Console.WriteLine(DateTimeOffset.Now);


            //var time = DateTimeOffset.Now;

            //foreach (var item in TimeZoneInfo.GetSystemTimeZones())
            //{
            //    if (item.GetUtcOffset(time)==time.Offset)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //var date = "9/10/2019 10:00:00 PM";

            //var parsedDate = DateTime.ParseExact(date, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

            //Console.WriteLine(parsedDate);

            //var date = "2019-07-01 10:00:00 PM +02:00";

            //var parsedDate = DateTime.Parse(date, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

            //Console.WriteLine(parsedDate);

            var date = "9/10/2019 10:00:00 PM";

            var parsedDate = DateTime.ParseExact(date, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

            //var formattedDate = parsedDate.ToString("yyyy-MMM-dd");
            var formattedDate = parsedDate.ToString("s");

            Console.WriteLine(formattedDate);


        }
    }
}

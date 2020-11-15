using System;

namespace Dates_and_times_in_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;

            TimeZoneInfo sydneyTimeZone =
                TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");

        }
    }
}

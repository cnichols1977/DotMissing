using System;

namespace DotMissing.Date
{
    public static class DateTimeExtensions
    {
        public static DateTime EndOfDay(this DateTime dt)
        {
            return dt.Date.AddDays(1).AddTicks(-1);
        }

        public static DateTime StartOfDay(this DateTime dt)
        {
            return dt.Date;
        }

        public static DateTime FirstDayOfMonthDate(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, 1).StartOfDay();
        }

        public static DateTime FirstDayOfYearDate(this DateTime dt)
        {
            return new DateTime(dt.Year, 1, 1).StartOfDay();
        }

        public static DateTime LastDayOfMonthDate(this DateTime dt)
        {
            return dt.FirstDayOfMonthDate().AddMonths(1).AddTicks(-1).Date;
        }

        public static DateTime LastDayOfYearDate(this DateTime dt)
        {
            return dt.FirstDayOfYearDate().AddYears(1).AddTicks(-1);
        }

        public static int LastDayOfMonth(this DateTime dt)
        {
            return dt.LastDayOfMonthDate().Day;
        }

        public static Boolean IsLastDayOfMonth(this DateTime dt)
        {
            return dt.Date.Equals(dt.LastDayOfMonthDate());
        }

        public static Boolean IsWeekday(this DateTime dt)
        {
            DayOfWeek dow = dt.Date.DayOfWeek;
            return !(dow == DayOfWeek.Saturday || dow == DayOfWeek.Sunday);
        }

        public static Boolean IsWeekend(this DateTime dt)
        {
            return !dt.IsWeekday();
        }

    }
}

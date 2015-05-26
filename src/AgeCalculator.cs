using System;

namespace AgeCalculator 
{
    public static class Age
    {
        /// <summary>
        /// Calculate Current Age
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <param name="yearFormat"></param>
        /// <param name="monthFormat"></param>
        /// <param name="dayFormat"></param>
        /// <returns>Return year, month and day e.g. '30year 5month 10day' </returns>
        public static string Calculate(DateTime dateOfBirth, string yearFormat, string monthFormat, string dayFormat)
        {
            var startDate = DateTime.Now;
            TimeSpan ts = startDate - dateOfBirth;
            var age = DateTime.MinValue.AddDays(ts.Days);
            var year = age.Year - 1;
            var month = age.Month - 1;
            var day = age.Day - 1;
            if (year < 1 && month < 1)
                return (string.Format("{0}{1}", day, dayFormat));
            if (year < 1 && month > 1)
                return (string.Format("{0}{2} {1}{3}", month, day, monthFormat, dayFormat));
            return
                string.Format("{0}{3} {1}{4} {2}{5}", year, month, day, yearFormat, monthFormat, dayFormat);
        }
        /// <summary>
        /// Calculate Current Age. 
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <param name="currentDate"></param>
        /// <param name="yearFormat"></param>
        /// <param name="monthFormat"></param>
        /// <param name="dayFormat"></param>
        /// <returns>Return year, month and day e.g. '30year 5month 10day'</returns>
        public static string Calculate(DateTime dateOfBirth, DateTime currentDate, string yearFormat, string monthFormat, string dayFormat)
        {
            var startDate = DateTime.Now;
            TimeSpan ts = startDate - dateOfBirth;
            var age = DateTime.MinValue.AddDays(ts.Days);
            var year = age.Year - 1;
            var month = age.Month - 1;
            var day = age.Day - 1;
            if (year < 1 && month < 1)
                return (string.Format("{0}{1}", day, dayFormat));
            if (year < 1 && month > 1)
                return (string.Format("{0}{2} {1}{3}", month, day, monthFormat, dayFormat));
            return
                (string.Format("{0}{3} {1}{4} {2}{5}", age.Year - 1, age.Month - 1, age.Day - 1, yearFormat,
                    monthFormat, dayFormat));
        }
        /// <summary>
        /// Calculate Current Age. 
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <param name="currentDate"></param>
        /// <param name="yearFormat"></param>
        /// <param name="monthFormat"></param>
        /// <returns>Return year and month only. e.g. '30year 5month'</returns>
        public static string Calculate(DateTime dateOfBirth, DateTime currentDate, string yearFormat, string monthFormat)
        {
            var startDate = DateTime.Now;
            TimeSpan ts = startDate - dateOfBirth;
            var age = DateTime.MinValue.AddDays(ts.Days);
            var year = age.Year - 1;
            var month = age.Month - 1;
            if (year < 1 && month < 1)
                return null;
            if (year < 1 && month > 1)
                return null;
            return string.Format("{0}{2} {1}{3}", year, month, yearFormat, monthFormat);
        }
        /// <summary>
        /// Calculate Current Age
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <param name="currentDate"></param>
        /// <param name="yearFormat"></param>
        /// <returns>Return year and month only. e.g. '30year 5month'</returns>
        public static string Calculate(DateTime dateOfBirth, DateTime currentDate, string yearFormat)
        {
            var startDate = DateTime.Now;
            TimeSpan ts = startDate - dateOfBirth;
            var age = DateTime.MinValue.AddDays(ts.Days);
            var year = age.Year - 1;
            return year < 1 ? null : string.Format("{0}{1}", year, yearFormat);
        }
    }
}

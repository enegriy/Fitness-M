using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    public static class TimeHelper
    {
        /// <summary>
        /// Время показать в сокращенном формате
        /// </summary>
        public static string ToShortTime(this TimeSpan ts)
        {
            return string.Format("{0}:{1}",ts.Hours.ToString("D2"), ts.Minutes.ToString("D2"));
        }

        /// <summary>
        /// Собрать дату из строки вида 00:00
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static TimeSpan CompileDate(string time)
        {
            try
            {
                var index = time.IndexOf(":");
                var hour_str = time.Substring(0, index);
                var min_str = time.Substring(index + 1, (time.Length - index) - 1);

                if (string.IsNullOrEmpty(hour_str))
                    hour_str = "0";

                if (string.IsNullOrEmpty(min_str))
                    min_str = "0";

                int hour = int.Parse(hour_str);
                int min = int.Parse(min_str);

                if ((hour < 0 || hour > 23) || (min < 0 || min > 59))
                {
                    throw new BussinesException("Некорректно введено время записи!");
                }
                return new TimeSpan(hour, min, 0);
            }
            catch (Exception ex)
            {
                throw new BussinesException(ex.Message, ex);
            }
        }
    }
}

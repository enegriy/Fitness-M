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
    }
}

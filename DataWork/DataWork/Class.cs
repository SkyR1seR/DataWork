using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWork
{
    public class Class
    {
        public DateTime vcherashnee(DateTime a)
        {
            return a.AddDays(-1);
        }
        public DateTime zavtrashnee(DateTime a)
        {
            return a.AddDays(+1);
        }
        public bool visokosnoe(DateTime a)
        {
            return DateTime.IsLeapYear(a.Year);
        }
        public int daysLeft(DateTime a)
        {
            return DateTime.DaysInMonth(a.Year, a.Month) - a.Day;
        }
    }
}

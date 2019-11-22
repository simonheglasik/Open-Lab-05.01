using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            string a = "";
            int thousand = year;
            year = year / 100;
            if (year == 0)
                return "1st century";
            if ((thousand - 1) / 100 == year - 1)
            {
                year = year - 1;          
            }
            if (year % 10 == 0)
            {
                if (year != 10)
                {
                    a = year + 1 + "st";
                    return a = a + " century";
                }
            }
            if ((year - 1) % 10 == 0)
            {
                if (year != 11)
                {
                    a = year + 1 + "nd";
                    return a = a + " century";
                }
            }
            if ((year - 2) % 10 == 0)
            {
                if (year != 12)
                {
                    a = year + 1 + "rd";
                    return a = a + " century";
                }
            }
            else
            {
                a = year + 1 + "th";
            }
            return a = a + " century"; 
        }
    }
}

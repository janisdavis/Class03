using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class Date
    {
        private int _day;
        private int _month;
        private int _year;
        public Date(int day, int month, int year)
            {
            _day = day;
            _month = month;
            _year = year;
            }
        public void DisplayDate()
        {
            Console.WriteLine($"{_month}/{_day}/{_year}");
        }
    }
}

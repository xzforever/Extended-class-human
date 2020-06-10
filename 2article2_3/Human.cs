using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2article2_3
{
    class Human
    {
        private string Name;
        private string Surname;
        private int YearOfBirth;
        private int MonthOfBirth;
        private int DayOfBirth;
        public Human(string name, string surname, int yearOfBirth, int monthOfBirth, int dayOfBirth)
        {
            SetYear(yearOfBirth);
            SetMonth(monthOfBirth);
            SetDay(dayOfBirth);
        }
        public int GetYear()
        {
            return YearOfBirth;
        }
        public int GetMonth()
        {
            return MonthOfBirth;
        }
        public int GetDay()
        {
            return DayOfBirth;
        }
        public void SetYear(int yearOfBirth)
        {
            if (yearOfBirth < 1900) yearOfBirth = 1900;
            else if (yearOfBirth > 2020) yearOfBirth = 2020;
            else YearOfBirth = yearOfBirth;
        }
        public void SetMonth(int monthOfBirth)
        {
            if (monthOfBirth < 1) monthOfBirth = 1;
            else if (monthOfBirth > 12) monthOfBirth = 12;
            else MonthOfBirth = monthOfBirth;
        }
        public void SetDay(int dayOfBirth)
        {
            if (dayOfBirth < 1) dayOfBirth = 1;
            else if (dayOfBirth > 31) dayOfBirth = 31;
            else DayOfBirth = dayOfBirth;
        }
        public void SetFullName(string fullName, string name, string surname)
        {
            fullName = name + surname;
            Name = name;
            Surname = surname;
        }
        public void SetAge(int age, int yearOfBirth)
        {
            age = 2020 - yearOfBirth;
            YearOfBirth = yearOfBirth;
        }


    }
}

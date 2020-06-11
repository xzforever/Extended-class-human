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
        private string _name;
        private string _surname;
        private int _yearOfBirth;
        private int _monthOfBirth;
        private int _dayOfBirth;
        public Human(string name, string surname, int yearOfBirth, int monthOfBirth, int dayOfBirth)
        {
            _yearOfBirth = yearOfBirth;
        }
        public int YearOfBirth
        {
            get
            {
                return _yearOfBirth;
            }
            set
            {
                if (value < 1900) _yearOfBirth = 1900;
                else if (value > 2020) _yearOfBirth = 2020;
                else _yearOfBirth = value;
            }
        }
        public int MonthOfBirth
        {

            get
            {
                return _monthOfBirth;
            }
            set
            {
                if (value < 1) _monthOfBirth = 1;
                else if (value > 12) _monthOfBirth = 12;
                else _monthOfBirth = value;
            }
        }
        public int DayOfBirth
        {
            get
            {
                return _dayOfBirth;
            }
            set
            {
                if (value < 1) _dayOfBirth = 1;
                else if (value > 31) _dayOfBirth = 31;
                else _dayOfBirth = value;
            }
        }
        public void  SetFullName(string fullName, string name, string surname)
        {
            fullName = name + surname;
            _name = name;
            _surname = surname;
        }
        public Human(string fullName)
        {
            FullName = fullName;
        }
        public string FullName { get; private set; }
        public void SetAge(int age, int yearOfBirth)
        {
            age = 2020 - yearOfBirth;
        }
        public Human(int age)
        {
            Age = age;
        }
        public int Age { get; private set; }


    }
}

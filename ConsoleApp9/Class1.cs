using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        private char gender;
        public char Gender
        {
            get { return gender; }
            set { if (value == 'М' | value == 'Ж') gender = value; }
        }
        public Person() { }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + DateOfBirth + " " + gender;
        }
        public void Read()
        {
            Console.WriteLine("Введите имя: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            LastName = Console.ReadLine();
            Console.WriteLine("Введите дату рождения (гггг-мм-дд): ");
            DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите пол(М/Ж): ");
            gender = char.Parse(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {FirstName} Фамилия: {LastName} Возраст: {Age(DateOfBirth)} Пол: {gender}");
        }
        public int Age(DateTime BDay)
        {
            int age = DateTime.Now.Year - BDay.Year;
            if (DateTime.Now.Day < BDay.Day)
            {
                if (DateTime.Now.Month < BDay.Month)
                {
                    age--;
                }
            }
            return age;
        }
    }
}


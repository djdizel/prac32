using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac32
{
    class Teacher:Person
    {
        /// <summary>
        /// поля
        /// </summary>
        string name;
        string surname;
        DateTime birthday;
        string faculty;
        int year;
        string jobtitle;
        /// <summary>
        /// инкапсуляция
        /// </summary>
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public int Year { get => year; set => year = value; }
        public string Jobtitle { get => jobtitle; set => jobtitle = value; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="birthday"></param>
        /// <param name="faculty"></param>
        public Teacher(string name, string surname, DateTime birthday, string faculty, int year,string jobtitle)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Faculty = faculty;
            Year = year;
            Jobtitle = jobtitle;
        }
        /// <summary>
        /// Метод 1
        /// </summary>
        public override void Info()
        {
            Console.WriteLine($"Преподаватель: {Name} {Surname}\nДата рождения: {Birthday}\nФакультет: {Faculty}\nДолжность: {Jobtitle}\nСтаж: {Year}");
        }
        /// <summary>
        /// Метод 2
        /// </summary>
        /// <returns></returns>
        public override int Age()
        {
            return DateTime.Now.Year - Birthday.Year;
        }

        public static Teacher Enter()
        {
            Console.Clear();
            Console.WriteLine("Введите имя учителя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию учителя");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения учителя");
            DateTime birthday = DateTime.Now;
            Console.WriteLine("Введите факультет");
            string faculty = Console.ReadLine();
            Console.WriteLine("Введите курс");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите должнлость");
            return new Teacher(name, surname, birthday, faculty, year,jobtitle);
        }
    }
}

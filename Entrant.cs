using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace prac32
{
    class Entrant : Person
    {
        /// <summary>
        /// поля
        /// </summary>
        string name;
        string surname;
        DateTime birthday;
        string faculty;
        /// <summary>
        /// инкапсуляция
        /// </summary>
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="birthday"></param>
        /// <param name="faculty"></param>
        public Entrant(string name, string surname, DateTime birthday, string faculty)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Faculty = faculty;
        }
        /// <summary>
        /// Метод 1
        /// </summary>
        public override void Info()
        {
            Console.WriteLine($"Абитуриент: {Name} {Surname}\nДата рождения: {Birthday}\nФакультет: {Faculty}");
        }
        /// <summary>
        /// Метод 2
        /// </summary>
        /// <returns></returns>
        public override int Age()
        {
            return DateTime.Now.Year - Birthday.Year;
        }

        public static Entrant Enter()
        {
            Console.Clear();
            Console.WriteLine("Введите имя абитуриента");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию абитуриента");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения абитуриента");
            DateTime birthday = DateTime.Now;
            Console.WriteLine("Введите факультет");
            string faculty = Console.ReadLine();
            return new Entrant(name, surname, birthday, faculty);
        }
    }
}

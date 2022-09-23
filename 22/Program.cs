using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _22
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Ex1();
        }
        public struct Student
        {
            public string Name;
            public string Surname;
            public int Identifier;
            public char Categoryofalcoholism;
            public double AmountOfAlcohol;

        }
        public static void Ex1()
        {
            Student[] array = new Student[5];
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите имя студента: ");
                array[i].Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию студента: ");
                array[i].Surname = Console.ReadLine();
                Console.WriteLine("Введите идентификационный номер студента:");
                array[i].Identifier = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите категорию алкоголизма:");
                array[i].Categoryofalcoholism = char.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество выпитого алкоголя:");
                var amount = Double.Parse(Console.ReadLine());
                array[i].AmountOfAlcohol = amount;
                sum += amount;
            }
            Console.WriteLine("Общее количество алкоголя: {0}", sum);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Процент выпитого алкоголя у студента {0} {0}: {1}%", array[i].Surname, array[i].Name, 100 * array[i].AmountOfAlcohol / sum);
            }
            Console.ReadKey();
        }
        public static void Ex2()
        {
            Console.WriteLine("Выведите на экран информацию о каждом типе данных в виде: Тип данных – максимальное значение – минимальное значение");
            Console.WriteLine("Тип данных sbute 127- максимальное значение -128- минимальное значение");
            Console.WriteLine("Тип данных bute 255- максимальное значение 0- минимальное значение");
            Console.WriteLine("Тип данных short 32767- максимальное значение -32768- минимальное значение");
            Console.WriteLine("Тип данных ushort 65535- максимальное значение 0- минимальное значение");
            Console.WriteLine("Тип данных int 2147483648- максимальное значение -2147483648- минимальное значение");
            Console.WriteLine("Тип данных uint 4294967295- максимальное значение 0- минимальное значение");
            Console.WriteLine("Тип данных long 9223372036854775808- максимальное значение -9223372036854775808- минимальное значение");
            Console.WriteLine("Тип данных ulong 18446744073709551615- максимальное значение 0- минимальное значение");
            Console.WriteLine("Тип данных bool true- максимальное значение false- минимальное значение");
            Console.WriteLine("Тип данных float ±3.4*10^38- максимальное значение ±1.5*10^-45- минимальное значение");
            Console.WriteLine("Тип данных double ±3.4*10^38- максимальное значение ±1.5*10^-45- минимальное значение");
            Console.WriteLine("Тип данных decimal ±7.9*10^28- максимальное значение ±1.0*10^-28- минимальное значение");
            Console.WriteLine("Тип данных char 126- максимальное значение -128- минимальное значение");
            Console.ReadKey();
        }
        public static void Ex3() 
        {
            Console.WriteLine("Напишите программу, в которой принимаются данные пользователя в виде имени, города, возраста и PIN-кода. Далее сохраните все значение в соответствующей переменной, а затем распечатайте всю информацию в правильном формате.");
            Console.Write("Введите имя:");
            string name= Console.ReadLine();
            Console.Write("Введите название города: ");
            string town = Console.ReadLine();
            Console.Write("Введите возраст:");
            int age=int.Parse(Console.ReadLine());
            Console.Write("Введите пинкод:");
            int pin= int.Parse(Console.ReadLine());
            Console.WriteLine("Имя:{0}\nГород:{0}\nВозраст:{0}\nПинкод:{0}", name, town, age, pin);
            Console.ReadKey();


        }
        public static void Ex4()
        {
            Console.WriteLine("Напишите программу, которая преобразует имя в инициалы.");
            Console.Write("Введите фамилию и имя через пробел: ");
            string[] ini = Console.ReadLine().Replace(".", "").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string LastName = ini.Length > 1 ? ini[0] : "";
            string Name = ini.Length > 1 ? ini[1] : "";
            Console.WriteLine("Результат - {0}. {1}.", LastName.FirstOrDefault(), Name.FirstOrDefault());
            Console.ReadKey();
           
        }
        public static void Ex5()
        {
            Console.WriteLine("Определить, сколько бутылок виски,чтобы экономия с покупки покрыла затраты на отпуск");
            Console.Write("Введите цену на одну бутылку виски:");
            int normPrise = int.Parse(Console.ReadLine());
            Console.Write("Введите скидку в DytyFree в процентах:");
            int salePrise = int.Parse(Console.ReadLine());
            double econ = normPrise*salePrise/100;
            Console.Write("Введите стоимость отпуска:");
            int holidayPrise = int.Parse(Console.ReadLine());
            double bot = Math.Round(holidayPrise / econ);
            Console.WriteLine("Нужно купить {0} бутылок виски, чтобы экономия от покупки покрыла затраты на отпуск", bot);
            Console.ReadKey();

        }
        public static void Ex6()
        {
            Console.WriteLine("Введите скорость таракана в км/ч:");
            double v= double.Parse(Console.ReadLine());
            double ans=Math.Round((v*27.8));
            Console.WriteLine("Скорость таракана в см/с:{0}",ans);
            Console.ReadKey();
        }
        public static void Ex7()
        {
            string str;
            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            char[] massiv = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    massiv[i] = Char.ToLower(str[i]);
                }
                else
                {
                    massiv[i] = Char.ToUpper(str[i]);
                }
            }
            Console.WriteLine(new String(massiv));
            Console.ReadKey();
        }
    }
}

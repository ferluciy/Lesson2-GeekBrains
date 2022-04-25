using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GBcool;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Classes.LogoLesson("2");
                Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.Green);
                Classes.PrintCenter("█                       ГЛАВНОЕ МЕНЮ                       █", ConsoleColor.Green);
                Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.Green);
                Console.WriteLine("");
                Classes.PrintLeft("Задача 1: Минимальное из трех чисел", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 2: Подсчет количества цифр числа", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 3: Подсчитать сумму всех нечетных положительных чисел", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 4: Проверка логина и пароля", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 5: Индекс массы тела", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 6: Подсчет количества «хороших» чисел", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 7: Рекурсивный метод", false, ConsoleColor.White);
                Classes.PrintLeft("-----------------------------------------------------", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 8: Выход", false, ConsoleColor.White);
                Console.WriteLine("");
                Classes.PrintLeft("Какую задачу ты хочешь выполнить: ", true, ConsoleColor.Yellow);

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Task1();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 2:
                        Task2();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 3:
                        Task3();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 4:
                        Task4();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 5:
                        Task5();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 6:
                        Task6();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 7:
                        Task7();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 8:                        
                        return;
                }
            }
        }

        static void Task1() //Минимальное из трех чисел 

        {
            Classes.LogoLesson("2");            
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█                Минимальное из трех чисел                 █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Console.WriteLine("");
            Classes.PrintLeft("Введи первое число: ", true, ConsoleColor.White);
            int a = int.Parse(Console.ReadLine());
            Classes.PrintLeft("Введи второе число: ", true, ConsoleColor.White);
            int b = int.Parse(Console.ReadLine());
            Classes.PrintLeft("Введи третье число: ", true, ConsoleColor.White);
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int mindig = a < b ? a : b;
            mindig = mindig < c ? mindig : c;
            Classes.PrintLeft("Минимальное число: " + mindig, false, ConsoleColor.Yellow);
        }
        static void Task2() // Подсчет количества цифр числа 
        {
            Classes.LogoLesson("2");            
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█              Подсчет количества цифр числа               █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Console.WriteLine("");
            Classes.PrintLeft("Введи число: ", true, ConsoleColor.White);
            int summ = Classes.NumberCount(int.Parse(Console.ReadLine()));
            Classes.PrintLeft("Количество цифр числа: " + summ, false, ConsoleColor.Yellow);
        }
        static void Task3() //Подсчитать сумму всех нечетных положительных чисел
        {
            Classes.LogoLesson("2");
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█    Подсчитать сумму всех нечетных положительных чисел    █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Classes.PrintCenter("<= Для остановки просто введи 0 =>", ConsoleColor.White);
            Console.WriteLine("");
            int number, summ = 0;
            do
            {
                Classes.PrintLeft("Введи число: ", true, ConsoleColor.White);
                number = int.Parse(Console.ReadLine());
                if (number > 0) summ = (number % 2 != 0) ? number + summ : summ;

            } while (number != 0);
            Classes.PrintLeft("Cумма нечетных положительных чисел: " + summ, false, ConsoleColor.Yellow);
        }
        static void Task4() //Проверка логина и пароля
        {            
            string user_login = "root", user_password = "GeekBrains";
            string login, password;
            int count_enter=0;
            do
            {
                Classes.LogoLesson("2");
                Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
                Classes.PrintCenter("█                 Проверка логина и пароля                 █", ConsoleColor.White);
                Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
                Console.WriteLine("");                
                count_enter++;
                Classes.PrintCenter(string.Format($"<========= Попытка {count_enter} из 3 =========>"), ConsoleColor.White);
                Classes.PrintLeft("Введи логин: ", true, ConsoleColor.White);
                login = Console.ReadLine();
                Classes.PrintLeft("Введи пароль: ", true, ConsoleColor.White);
                password = Console.ReadLine();
                Console.WriteLine("");
                if (login == user_login && password == user_password)
                {
                    Classes.PrintLeft("Вход выполнен!", false, ConsoleColor.Green);
                    break;
                } else
                {
                    Classes.PrintLeft("Комбинация логина и пароля неверна!", false, ConsoleColor.Red);
                    if (count_enter >= 3) break;
                }
                Console.WriteLine("");
                Classes.PrintLeft("Для продолжения нажми любую кнопку...", false, ConsoleColor.Yellow);
                Console.ReadKey();

            } while ((login != user_login || password != user_password) && count_enter <= 3);

            if ((login != user_login || password != user_password) && count_enter >= 3)
            {
                Console.WriteLine("");
                Classes.PrintCenter("▄▀▀ ▄▀▄ ██▄██ █▀▀ . ▄▀▀▄ █░░░█ █▀▀ █▀▄", ConsoleColor.DarkRed);
                Classes.PrintCenter("█░█ █▄█ █░▀░█ █▀▀ . █░░█ ░█░█░ █▀▀ █▀▄", ConsoleColor.DarkRed);
                Classes.PrintCenter("░▀▀ ▀░▀ ▀░░░▀ ▀▀▀ . ░▀▀░ ░░▀░░ ▀▀▀ ▀░▀", ConsoleColor.DarkRed);

                Console.WriteLine("");
                Classes.PrintCenter("!!! ВХОД ЗАБЛОКИРОВАН НАВСЕГДА !!!", ConsoleColor.Red);
            } 

        }
        static void Task5() //Индекс массы тела
        {
            Classes.LogoLesson("2");
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█                    Индекс массы тела                     █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Console.WriteLine("");
            Classes.PrintLeft("Введи свой вес, кг: ", true, ConsoleColor.White);
            double m = double.Parse(Console.ReadLine());
            Classes.PrintLeft("Введи свой рост, см: ", true, ConsoleColor.White);
            double h = double.Parse(Console.ReadLine());
            double index = Math.Round(Classes.IndexMassa(m, h),1);
            Classes.PrintLeft(String.Format($"Ваш индекс массы тела: {index}"), false, ConsoleColor.Yellow);
            if (index >= 18.5 && index <= 24) Classes.PrintLeft("Вы в идеальной форме", false, ConsoleColor.Green);
            else if (index < 18.5) Classes.PrintLeft(String.Format("Недостаточная масса тела. Вам нужно набрать {0:F1} кг", ((18.5 * (Math.Pow(h / 100, 2))) - m)), false, ConsoleColor.Yellow);
            else Classes.PrintLeft(String.Format("ЖИРОБАСИНА!!! Вам нужно сбросить {0:F1} кг", m - (24 * (Math.Pow(h / 100, 2)))), false, ConsoleColor.Red);
        }
        static void Task6() // Количество «хороших» чисел в 1 000 000 000
        {
            Classes.LogoLesson("2");
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█        Количество «хороших» чисел в 1 000 000 000        █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Console.WriteLine("");
            DateTime start = DateTime.Now;
            Classes.PrintLeft("Начинаем рассчет. Время начала: " + start, false, ConsoleColor.Yellow);
            Console.WriteLine("");
            int countgoodnubmer=0, maxnumber=1_000_000_000;            
            double progress;
            Classes.PrintLeft("Прогресс: 0%", true, ConsoleColor.Yellow);
            for (int i = 1; i <= maxnumber; i++) if ((i % Classes.NumberSumm(i) == 0))
                {                    
                    countgoodnubmer++;
                    progress = ((double) i / maxnumber)*100;
                   if ( progress % 1 == 0 && i > 1)
                  {                       
                       Classes.PrintLeft(String.Format("Прогресс: {0:F0}%",progress), true, ConsoleColor.Yellow);
                  }
                }
            Classes.PrintLeft("Прогресс: 100%", true, ConsoleColor.Green);
            Console.WriteLine("");
            Classes.PrintLeft("В 1 000 000 000 всего «хороших» чисел: "+ countgoodnubmer, false, ConsoleColor.Green);
            Console.WriteLine("");
            Classes.PrintLeft("Проверка завершена: " + DateTime.Now, false, ConsoleColor.Yellow);
            Console.WriteLine("");
            Classes.PrintLeft("Общее время выполнения " + (DateTime.Now - start), false, ConsoleColor.Green);
        }
        static void Task7() //Рекурсивный метод
        {
            Classes.LogoLesson("2");
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█                    Рекурсивный метод                     █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Console.WriteLine("");
            Classes.PrintLeft("Введи первое число: ", true, ConsoleColor.White);
            int a = int.Parse(Console.ReadLine());
            Classes.PrintLeft("Введи второе число: ", true, ConsoleColor.White);
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Classes.PrintLeft("Выводим все числа пока a < b: ", false, ConsoleColor.Yellow);
            Classes.RecursiaOne(a,b);
            Console.WriteLine("");
            Classes.PrintLeft("Сумма всех чисел от a до b (включительно): "+ Classes.RecursiaTwo(a, b), false, ConsoleColor.Yellow);
            Classes.PrintLeft("Сумма всех чисел от a до b (не включительно): " + Classes.RecursiaTwo(a, b-1), false, ConsoleColor.Yellow);

        }
    }
}

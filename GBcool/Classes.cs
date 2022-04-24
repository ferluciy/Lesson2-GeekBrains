using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBcool
{
    public class Classes
    {
        public static void Print(string s, int x, int y, ConsoleColor foregroundcolor) //вывод текста по координатам
        {
            if (x != 0 || y != 0) Console.SetCursorPosition(x, y);
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(s);
        }
        public static void PrintCenter(string s, ConsoleColor foregroundcolor) //вывод текста по центру строки
        {
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(s);
        }
        public static void PrintLeft(string s, bool InLine, ConsoleColor foregroundcolor) //вывод текста по левому краю с отступом
        {
            Console.SetCursorPosition(20, Console.CursorTop);
            Console.ForegroundColor = foregroundcolor;
            if (InLine) Console.Write(s); else Console.WriteLine(s);
        }
        public static void Pause(string s) //пауза
        {
            if (s != "") Console.WriteLine(s);
            Console.ReadKey();
            Console.WriteLine(""); //делаем отступ
        }
        
        public static int NumberSumm(int n) //сумма цифр числа
        {
            int s = 0;
            while (n != 0)
            {
                s = s + n % 10;
                n = n / 10;
            }
            return s;
        }
        public static int NumberCount(int n) //количество цифр в числе
        {
            int s = 0;
            int h = 0;
            while (n != 0)
            {
                s = s + n % 10;
                n = n / 10;
                h++;
            }
            return h;
        }
        public static double IndexMassa(double m, double h) //подсчет индекса массы тела
        {
           return (m / Math.Pow(h/100,2));
        }
        public static void LogoLesson (string s) //шапка программы
        {
            Console.WindowHeight = 45;
            Console.WindowWidth = 130;
            Console.Clear();
            Console.WriteLine("");
            Classes.PrintCenter("██░└┐░░░░░░░░░░░░░░░░░┌┘░██", ConsoleColor.Green);
            Classes.PrintCenter("██░░└┐░░░░░░░░░░░░░░░┌┘░░██", ConsoleColor.Green);
            Classes.PrintCenter("██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██", ConsoleColor.Green);
            Classes.PrintCenter("██▌░│██████▌░░░▐██████│░▐██", ConsoleColor.Green);
            Classes.PrintCenter("███░│▐███▀▀░░▄░░▀▀███▌│░███", ConsoleColor.Green);
            Classes.PrintCenter("██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██", ConsoleColor.Green);
            Classes.PrintCenter("██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██", ConsoleColor.Green);
            Classes.PrintCenter("████▄─┘██▌░░░░░░░▐██└─▄████", ConsoleColor.Green);
            Classes.PrintCenter("█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████", ConsoleColor.Green);
            Classes.PrintCenter("████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████", ConsoleColor.Green);
            Classes.PrintCenter("█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████", ConsoleColor.Green);
            Classes.PrintCenter("", ConsoleColor.DarkYellow);
            Classes.PrintCenter("▄▀▀ █▀▀ █▀▀ █░█ █▀▄ █▀▄ ▄▀▄ ▀█▀ █▄░█ ▄▀▀", ConsoleColor.Red);
            Classes.PrintCenter("█░█ █▀▀ █▀▀ █▀▄ █▀▄ █▀▄ █▄█ ░█░ █▀██ ░▀▄", ConsoleColor.Red);
            Classes.PrintCenter("░▀▀ ▀▀▀ ▀▀▀ ▀░▀ ▀▀░ ▀░▀ ▀░▀ ▀▀▀ ▀░░▀ ▀▀░", ConsoleColor.Red);
            Classes.PrintCenter("____LESSON_" + s + "____________by_Моисеев_Игорь", ConsoleColor.Red);
            Console.WriteLine(""); 
        }
        public static void RecursiaOne (int a, int b)
        {
            if (a < b)
            {
                PrintLeft(a.ToString(), false, ConsoleColor.White);
                a++;                
                RecursiaOne(a,b);
            }            
        }//вывод чисел пока a<b
        public static int RecursiaTwo(int a, int b)
        {
            if (a > b) return 0;            
            else
            {
                a++;
                return a - 1 + RecursiaTwo(a, b);
            }
        }//рекурсивный метод, который считает сумму чисел от a до b включительно.

    }
}

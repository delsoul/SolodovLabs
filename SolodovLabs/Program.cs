using System;
using System.IO;
using System.Linq;

namespace SolodovLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Лабораторная работа 1

            //L1 l1 = new L1();
            //l1.PrintHello();

            #endregion

            #region Лабораторная работа 2

            //L2 l2 = new L2();
            //l2.Discriminant();

            #endregion

            #region Лабораторная работа 3

            //L3 l3 = new L3();
            //l3.Calculator();

            #endregion

            #region Лабораторная работа 3.1

            //L3_1 l3_1 = new L3_1();
            //l3_1.Factorial();

            #endregion

            #region Лабораторная работа 4

            //L4 l4 = new L4();
            //l4.doWhile();

            #endregion

            #region Лабораторная работа 4.1

            //L4_1 l4_1 = new L4_1();
            //l4_1.newFunc();

            #endregion

            #region Лабораторная работа 5

            //L5 l5 = new L5();
            //l5.ZeroEx();

            #endregion

            #region Лабораторная работа 6

            //L6 l6 = new L6();
            //l6.StreamText();

            #endregion

            #region Лабораторная работа 7

            //L7 l7 = new L7();
            //int mass1Size = l7.SetFirst();
            //int mass2Size = l7.SetSecond();
            //int[] mass1 = new int[mass1Size];
            //int[] mass2 = new int[mass2Size];
            //Console.WriteLine();
            //Console.WriteLine("Введите данные для первого массива: ");
            //for (int i = 0; i < mass1Size; i++)
            //{
            //    mass1[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //Console.WriteLine("Введите данные для второго массива: ");
            //for (int i = 0; i < mass2Size; i++)
            //{
            //    mass2[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //Console.WriteLine("Максимальный элемент первого массива:" + mass1.Max());
            //Console.WriteLine();
            //Console.WriteLine("Максимальный элемент второго массива:" + mass2.Max());
            //Console.WriteLine();
            //Console.WriteLine("Минимальный элемент первого массива:" + mass1.Min());
            //Console.WriteLine();
            //Console.WriteLine("Минимальный элемент второго массива:" + mass2.Min());

            #endregion
        }
    }

    public class L1
    {
        public void PrintHello()
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("Солодов Дмитрий Игоревич, гр. 23180");
            Console.ReadKey();
        }
    }

    public class L2
    {
        public void Discriminant()
        {
            First:
            Console.WriteLine();
            Console.WriteLine("Введите значение переменной а:");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a == 0d)
            {
                Console.WriteLine("Переменная не может равняться нулю.");
                goto First;
            }

            Second:
            Console.WriteLine();
            Console.WriteLine("Введите значение переменной b:");
            double b = Convert.ToDouble(Console.ReadLine());

            if (b == 0d)
            {
                Console.WriteLine("Переменная не может равняться нулю.");
                goto Second;
            }

            Third:

            Console.WriteLine("Введите значение переменной c:");
            double c = Convert.ToDouble(Console.ReadLine());

            if (c == 0d)
            {
                Console.WriteLine("Переменная не может равняться нулю.");
                goto Third;
            }

            double D = Math.Pow(b, 2) - 4 * a * c;

            double x1, x2;

            if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x1);
            }
            else if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                Console.WriteLine("Нет корней.");
            }

            Console.ReadKey();
        }
    }

    public class L3
    {
        public void Calculator()
        {
            Start:
            Console.WriteLine();
            Console.WriteLine("Введите значение первой переменной:");
            Console.WriteLine();
            double a = Convert.ToDouble(Console.ReadLine());
            if (a == 0d)
            {
                Console.WriteLine();
                Console.WriteLine("Переменная не может быть равна нулю!");
                goto Start;
            }

            Delay:
            Console.WriteLine();
            Console.WriteLine("Выберите желаемое действие, где:");
            Console.WriteLine();
            Console.WriteLine("1 - возводить в указанную степень");
            Console.WriteLine();
            Console.WriteLine("2 - вычислять квадратный корень");
            Console.WriteLine();
            Console.WriteLine("3 - вычислять проценты");
            Console.WriteLine();
            int delay = Convert.ToInt32(Console.ReadLine());

            switch (delay)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Введите желаемую степень:");
                    int s = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Результат: " + Math.Pow(a, s));
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Результат: " + Math.Sqrt(a));
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Введите значение второй переменной:");
                    Console.WriteLine();
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Результат: " + a%b); // какие проценты вычислять надо :/

                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Указанного действия не обнаружено.");
                    goto Delay;
            }

            Console.ReadKey();
        }
    }

    public class L3_1
    {
        public void Factorial()
        {
            int f = 1;
            Console.WriteLine();
            Console.WriteLine("Введите значение х:");
            Console.WriteLine();
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 2; i <= x; i++)
            {
                f *= i;
            }
            Console.WriteLine("Факториал равен " + f);

            Console.ReadKey();
        }
    }

    public class L4
    {
        public void doWhile()
        {
            double a, b, c, q, y1, y2;
            Console.WriteLine("Введите начальную точку");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конечную точку");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите допустимую погрешность q");
            q = Convert.ToDouble(Console.ReadLine());

            // изначальная версия

            //while (Math.Abs(b + a) > q)
            //{
            //    Console.WriteLine("a = {0}", a);
            //    Console.WriteLine("b = {0}", b);
            //    c = (a + b) / 2;
            //    y1 = Math.Pow((c - q), 2);
            //    y2 = Math.Pow((c + q), 2);
            //    if (y2 < y1)
            //    {
            //        a = c;
            //    }
            //    else if (y2 > y1)
            //    {
            //        b = c;
            //    }
            //    else if (y2 == y1)
            //    {
            //        a = c - q;
            //        b = c + q;
            //    }
            //}

            do
            {
                Console.WriteLine("a = {0}", a);
                Console.WriteLine("b = {0}", b);
                c = (a + b) / 2;
                y1 = Math.Pow((c - q), 2);
                y2 = Math.Pow((c + q), 2);
                if (y2 < y1)
                {
                    a = c;
                }
                else if (y2 > y1)
                {
                    b = c;
                }
                else if (y2 == y1)
                {
                    a = c - q;
                    b = c + q;
                }
            }
            while (Math.Abs(b + a) > q);

            Console.WriteLine("Минимум функции у = х^2 находится в точке " + (a + b) / 2);
            Console.ReadKey();
        }
    }

    public class L4_1
    {
        public void newFunc()
        {
            double a, b, c, q, y1, y2;
            Console.WriteLine("Введите начальную точку");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конечную точку");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите допустимую погрешность q");
            q = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("a = {0}", a);
                Console.WriteLine("b = {0}", b);
                c = (a + b) / 2;
                y1 = 2 * Math.Pow((c - q), 3);
                y2 = 2 * Math.Pow((c + q), 3);
                if (y2 < y1)
                {
                    a = c;
                }
                else if (y2 > y1)
                {
                    b = c;
                }
                else if (y2 == y1)
                {
                    a = c - q;
                    b = c + q;
                }
            }
            while (Math.Abs(b + a) > q);

            Console.WriteLine("Минимум функции у = 2 * х^3 находится в точке " + (a + b) / 2);
            Console.ReadKey();
        }
    }

    public class L5
    {
        public void ZeroEx()
        {
            string buf;
            double u, i, r;
            try
            {
                Console.WriteLine("Введите напряжение: ");
                buf = Console.ReadLine();
                u = double.Parse(buf);
                Console.WriteLine("Введите сопротивление: ");
                buf = Console.ReadLine();
                r = double.Parse(buf);
                i = u / r;
                Console.WriteLine("Сила тока: " + i + " Ампер");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Неверный формат ввода - " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Деление на ноль - " + ex.Message);
            }
            catch
            {
                Console.WriteLine("Неопознанное исключение");
            }

            Console.ReadKey();
        }
    }

    public class L6
    {
        public void StreamText()
        {
            var dir = Environment.CurrentDirectory;
            StreamReader streamReader = new StreamReader(dir + "lab6.txt");
            var q = 1;

            // не знаю как работать с этим на mac :'\
        }
    }

    public class L7
    {
        public int SetFirst()
        {
            Console.WriteLine();
            Console.WriteLine("Введите размер первого массива: ");
            Console.WriteLine();
            int mass1Size = int.Parse(Console.ReadLine());
            return mass1Size;
        }

        public int SetSecond()
        {
            Console.WriteLine();
            Console.WriteLine("Введите размер второго массива: ");
            Console.WriteLine();
            int mass2Size = int.Parse(Console.ReadLine());
            return mass2Size;
        }
    }
}
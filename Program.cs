using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Task 1

                Console.WriteLine("Здравствуйте!");
                Console.WriteLine("Сколько раз необходимо вывести слово Информатика?");
                while (true)
                {
                    Console.Write("Введите количество раз: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine($"{i}. Информатика");
                    }
                }*/

                //Task 2

                /*int a = 0;
                int n = 0;
                Console.WriteLine("Здравствуйте!");
                Console.Write("Введите диапазон чисел \nОт ");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.Write("До ");
                int s = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nЧисла, кратные 25: \n\n");
                for (int i = d; i <= s; i++)
                {
                    if (i % 25 == 0 && i != 0)
                    {
                        Console.Write($"{i}; \t");
                        ++a;
                        n += i;
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine($"Количество чисел: {a}");
                Console.WriteLine($"Сумма чисел: {n}");
                Console.ReadKey();*/

                /*Task 3

                Console.WriteLine("При y = -5x^2 + 2x + 1 получается: \n");
                for (int x = -5; x <= 5; x++)
                {
                    double y = -5 * Math.Pow(x, 2) + 2 * x + 1;
                    Console.WriteLine($"\t{x} \t{y}");
                    x++; ;
                }
                Console.ReadKey();*/

                /*Task 4

                int a = 20;
                int b = 0;
                Console.WriteLine("Трёхзначные числа, сумма цифр которых равна 20: ");
                for(int i = 100; i <= 999; i++)
                {
                    if ((i / 100) + ((i / 10) % 10) + (i % 10) == a)
                    {
                        Console.Write($"\t{i}; \t");
                        b++;
                    }
                }
                Console.WriteLine($"\nКоличество чисел: {b}");
                Console.ReadKey();*/

                /*Task 5

                Console.WriteLine("Здравствуйте!");
                while(true)
                {
                    double prcnt = 7;
                    Console.Write("Введите сумму вклада: ");
                    double vklad = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите количество месяцев: ");
                    double month = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Итоговая сумма вклада за {month} месяц(-ев) равна: {(vklad * month * prcnt) / 100:f2}\n");
                }*/

                //Task 6

                /*double prcnt = 0.1;
                double price = 100;
                double seven_mouth = 0;
                for(int i= 2; i <= 10; i++)
                {
                    price += price * prcnt;
                    Console.WriteLine($"{i} месяц - {price:f2} рублей.\n");
                    if (i == 7)
                    {
                        seven_mouth = 1000 * price;
                    }
                }
                Console.WriteLine($"Стоимость 1000 акций в 7 месяц - {seven_mouth:f2} рублей.");
                Console.ReadKey();*/

                //Task 7

                /*for(int i=0;i<4;i++)
                {
                    for(int j = 0; j < 6; j++)
                    {
                        Console.Write("5   ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();*/

                //Task 8

                /*int a = 0;
                while (a < 5)
                {

                    int b = 0;
                    do
                    {
                        Console.Write("#");
                        b++;
                    }
                    while (b < 15);
                    Console.WriteLine();
                    a++;
                }
                Console.ReadKey();*/
            }
            catch
            {
                Console.Write("Вы где-то ошиблись...");
                Console.ReadKey();
            }
        }
    }
}

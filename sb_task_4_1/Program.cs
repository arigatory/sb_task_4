using System;
using System.Globalization;
using System.Linq;

namespace sb_task_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10


            int[] income = new int[12];
            int[] outcome = new int[12];
            int[] profit = new int[12];

            Random random = new Random();
            Console.WriteLine("Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.");
            for (int i = 0; i < 12; i++)
            {
                income[i] = random.Next(7, 13) * 10_000;
                outcome[i] = random.Next(6, 12) * 10_000;
                profit[i] = income[i] - outcome[i];
                Console.WriteLine($"{i + 1,5} {income[i],20:### ###}{outcome[i],19:### ###}{profit[i],23:### ###;;0}");
            }

            int[] temp = (int[]) profit.Clone();
            int numberOfTopMinimum = 3;
            int[] mins = new int[numberOfTopMinimum];

            for (int i = 0; i < mins.Length; i++)
            {
                mins[i] = temp.Min();                
                temp = temp.Except(new int[] { mins[i] }).ToArray();
            }
            Console.Write("\nХудшая прибыль в месяцах:");
            for (int i = 0; i < profit.Length; i++)
            {
                for (int j = 0; j < mins.Length; j++)
                {
                    if (profit[i] == mins[j])
                    {
                        Console.Write($" {i+1},");
                    }
                }
            }
            Console.Write("\b \n");
            Console.WriteLine($"Месяцев с положительной прибылью: {profit.Where(i => i>0).Count()}");

            Console.ReadKey();
        }
    }
}

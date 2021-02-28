using System;

namespace sb_task_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // * Задание 2
            // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //                                                              
            //                                                              
            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1


            int rows = 9;
            int k = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int space = 1; space <= rows - i; space++)
                    Console.Write("  ");

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        k = 1;
                    else
                        k = k * (i - j + 1) / j;

                    Console.Write($"{k}   ");
                }
                Console.WriteLine();
            }
        }
    }
}

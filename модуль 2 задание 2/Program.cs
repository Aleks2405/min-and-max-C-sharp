using System;
/*Задание 2
Дан двумерный массив размерностью 5×5, заполненный
случайными числами из диапазона от –100 до 100.
Определить сумму элементов массива, расположенных
между минимальным и максимальным элементами.*/
namespace модуль_2_задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] arr = new int[5, 5];
            int max = 0;  // иожно и первый элемент но привык 0
            int min = 0;
            int sum = 0;
            int i_test = 0;
            int j_test = 0;
            int i_test1 = 0, j_test1 = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                    Console.Write($" {arr[i, j]} ");
                    if (arr[i, j] > max)            // не нравится но других методой нет((( 
                    {
                        max = arr[i, j];
                    }
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine($"max = {max}, min = {min}");

            Console.WriteLine();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1);j++)
                {
                    if (arr[i, j] == min)
                    {
                        i_test1 = i;
                        j_test1 = j;
                        Console.WriteLine($"min = {i},{j}");
                    }
                    if (arr[i, j] == max)
                    {
                        i_test = i;
                        j_test = j;
                        Console.WriteLine($"max = {i},{j}");

                    }
                    if (i_test < i_test1)  // подумать над данной строчкой алгоритм не правильный 
                    {
                        int temp = 0;
                        temp = arr[i_test,j_test];
                        arr[i_test, j_test] = arr[i_test1, j_test1];
                        arr[i_test1, j_test1] = temp;

                    }
                }
                             
            }
            for (int i = i_test1; i <= i_test;i++ )
            {
                for (int j = j_test1; j <=j_test; j++)
                {
                    Console.Write($" {arr[i, j]} ");
                    sum += arr[i,j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Summa = {sum}");

            

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++) {

            //        for (; min < max; arr[i,j]++)
            //            sum += arr[i,j];
            //        Console.WriteLine($" sum = {sum}");
            //    }

            //    }
            //Console.WriteLine($" sum = {sum}");
        }

    }
}

/*Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
void Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
            Console.Write(String.Format("{0,5}", array[i, j]));// вывод значений с отступом
        }
        Console.WriteLine();
    }
}

void NewStringArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxIndex = j;
            //int max = array[i, j];
            for (int k = j; k < array.GetLength(1); k++)
            {
                if (array[i, maxIndex] < array[i, k])
                {
                    maxIndex = k;
                }
            }
            int temp = array[i, j];
            array[i, j] = array[i, maxIndex];
            array[i, maxIndex] = temp;
        }
    }
    Console.WriteLine();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,5}", array[i, j]));
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк M в двумерном массиве:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов N в двумерном массиве:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

Console.WriteLine($"\nСгенерирован следующий двумерный массив чисел:");
Array(array);
Console.Write($"\nНовый массив: ");
NewStringArray(array);



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
            array[i, j] = new Random().Next(-20, 21);
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
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк M в двумерном массиве:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов N в двумерном массиве:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

Console.WriteLine($"\nСгенерирован следующий двумерный массив чисел:");
Array(array);
Console.Write($"\nНовый упорядоченный массив: ");
NewStringArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(String.Format("{0,5}", array[i, j]));
    }
    Console.WriteLine();
}

/*Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.
*/
void Array(int[,] array) //заполнение массива
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

void MinSummaElement(int[,] array)
{
    int sumMin = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        Console.WriteLine($"Сумма элементов в строке {i + 1} (с индексом [{i}]) массива равна {sum}");

        if (i == 0)
        {
            sumMin = sum;
        }
        else if (sum < sumMin)
        {
            sumMin = sum;
            index = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма элементов, равная {sumMin}, находится в строке {index + 1} (с индексом [{index}]) массива.");
}

Console.Write("Введите количество строк M в двумерном массиве:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов N в двумерном массиве:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

Console.WriteLine($"\nСгенерирован следующий двумерный массив чисел:");
Array(array);
Console.WriteLine();
MinSummaElement(array);
Console.WriteLine();
/*Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void Array(int[,,] array)
{
    int[] oneLineArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];//перевод в одномерный массив
    int number;
    for (int i = 0; i < oneLineArray.GetLength(0); i++)//заполняем массив случайными числами
    {
        oneLineArray[i] = new Random().Next(10, 100);
        number = oneLineArray[i];
        if (i >= 1)   
        {
            for (int j = 0; j < i; j++)
            {
                while (oneLineArray[i] == oneLineArray[j])//проверяем числа на совпадение
                {
                    oneLineArray[i] = new Random().Next(10, 100);
                    j = 0;
                    number = oneLineArray[i];
                }
                number = oneLineArray[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = oneLineArray[count];
                count++;
            }
        }
    }
}

void WriteArray(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("\t" + array[i, j, k] + $" ({i}, {j}, {k})");
            }
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк M в трехмерном массиве:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов N в трехмерном массиве:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество страниц Р в трехмерном массиве:  ");
int p = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[m, n, p];

Console.WriteLine($"\nСгенерирован следующий трехмерный массив неповторяющихся чисел:");
Array(array);
Console.WriteLine();
WriteArray(array);
Console.WriteLine();

/*
Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
void Array(int[,] array) //заполнение массива
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}
void WriteArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]/10==0)
            {
                Console.Write(String.Format("{0,5}", $"0{array[i, j]}"));
            }
            else
            {
                 Console.Write(String.Format("{0,5}", array[i, j]));
            }
           
        }
        Console.WriteLine();
    }
}


Console.Write("Введите число размерности квадратного двумерного массива:  ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, m];
Console.WriteLine($"\nСгенерирован следующий двумерный массив чисел:");
Array(array);
WriteArray(array);



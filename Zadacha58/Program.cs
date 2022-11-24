/*Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
Результатом умножения матриц Am×n и Bn×k будет матрица Cm×k такая,
что элемент матрицы C, стоящий в i-той строке и j-том столбце (cij),
равен сумме произведений элементов i-той строки матрицы A
на соответствующие элементы j-того столбца матрицы B:
cij = ai1 · b1j + ai2 · b2j + ... + ain · bnj

Замечание.Две матрицы можно перемножить между собой тогда и только тогда,
когда количество столбцов первой матрицы равно количеству строк второй матрицы.
*/
void MatrixOne(int[,] matrixOne) //заполнение первой матрицы
{
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            matrixOne[i, j] = new Random().Next(-10, 11);
            Console.Write(String.Format("{0,5}", matrixOne[i, j]));// вывод значений с отступом
        }
        Console.WriteLine();
    }
}

void MatrixTwo(int[,] matrixTwo) //заполнение второй матрицы
{
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            matrixTwo[i, j] = new Random().Next(-10, 11);
            Console.Write(String.Format("{0,5}", matrixTwo[i, j]));// вывод значений с отступом
        }
        Console.WriteLine();
    }
}

int[,] ProductMatrices(int[,] matrixOne, int[,] matrixTwo)
//void ProductMatrices(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] resultMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];

    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
         for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
           int sum = 0;
            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {            
                sum = sum + (matrixOne[i, k] * matrixTwo[k, j]);              
            }
            resultMatrix[i, j] = sum;
        }
    }
/*
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,5}", resultMatrix[i, j]));// вывод значений с отступом
        }
        Console.WriteLine();
    }*/
   return resultMatrix;
}

Console.Write("Введите количество строк M1 в первой матрице:  ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов N1 в первой матрице:  ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество строк M2 во второй матрице:  ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов N2 во второй матрице:  ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 != m2)
{
    Console.WriteLine("\nКоличество столбцов первой матрицы N1 должно быть равно количеству строк М2 второй матрицы.");
    Console.WriteLine("Введите равнозначные значения N1 и M2:");
    n1 = Convert.ToInt32(Console.ReadLine());
    m2 = Convert.ToInt32(Console.ReadLine());
}
int[,] matrixOne = new int[m1, n1];
int[,] matrixTwo = new int[m2, n2];
Console.WriteLine($"\nПервая матрица:");
MatrixOne(matrixOne);

Console.WriteLine($"\nВторая матрица:");
MatrixTwo(matrixTwo);
//Console.WriteLine();

Console.WriteLine($"\nРезультат произведения двух матриц:");
ProductMatrices(matrixOne, matrixTwo);
//Console.WriteLine();


int[,] resultMatrix = ProductMatrices(matrixOne, matrixTwo);
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        Console.Write(String.Format("{0,5}", resultMatrix[i, j]));
    }
    Console.WriteLine();
}
Console.WriteLine();

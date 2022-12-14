// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.NextDouble() + rnd.Next(leftRange, rightRange);
        }
    }
    return array;
}

void PrintArr(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 1)}  ");

        }
        Console.WriteLine();
    }
}


int m = EnterNumber("Insert m:  ");
int n = EnterNumber("Insert n:  ");
double[,] matrix = CreateRandomArray(m, n, -10, 10);
PrintArr(matrix);

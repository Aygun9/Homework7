//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце..


int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}


int m = EnterNumber("Insert m:  ");
int n = EnterNumber("Insert n:  ");
int[,] matrix = CreateRandomArray(m, n, 1, 10);
PrintArr(matrix);

double sum = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
   sum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sum += matrix[j, i];
    }
    double average=sum/matrix.GetLength(0);
    Console.WriteLine(Math.Round(average,1) + " ; ");
}







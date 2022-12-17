//Задача 50. Напишите программу, которая на вход принимает значение этого элемента в двумерном массиве, 
//и возвращает позицию этого элемента или же указание, что такого элемента нет.

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


void FindElement(int[,] matrix, int N)    // N-element of array
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (N == matrix[i, j])
            {
                Console.WriteLine($"{N} => {i},{j}");
            }
            else
            {
                Console.WriteLine($"{N} => element not found in array  ");
            }
        }

    }
}


int[,] matrix = CreateRandomArray(3, 4, 1, 10);
PrintArr(matrix);
Console.WriteLine();
int N = EnterNumber("Insert element of array");
FindElement(matrix,N);

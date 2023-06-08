// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка

void input_matrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);  //[-10;10]
}

void print_matrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}



int[,] table = new int[4, 4];
input_matrix(table);
print_matrix(table);
//TransponMatrix(ref table);
Console.WriteLine();

SumInLines(table);

void SumInLines(int[,] matrix)
{
    Console.Write("\nСуммы элементов в каждой строке: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }

        Console.Write($"{sum} \t ");
    }
}

//int[] numbers = new int[SumInLines()];

int minSum(int[] numbers)
{
    int min = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] <= min)
        {
            min = numbers[i];
        }
    }
    return min;
}


Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {minSum}");
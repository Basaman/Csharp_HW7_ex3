//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите кол-во столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.Clear();

double[,] array = GetArray(rows, columns, 0, 10);
double[] ColumnsSumValueArray = GetColumnsSumValueArray(array);
double[] AvarageColumnValue = GetAvarageColumnValue(ColumnsSumValueArray);

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", AvarageColumnValue)}");

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[] GetColumnsSumValueArray(double[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[j] = result[j] + matrix[i, j];
        }
    }
    return result;
}

double[] GetAvarageColumnValue(double[] ColumnsSumValueArray)
{
    double[] result = new double[ColumnsSumValueArray.Length];
    {
        for (int i = 0; i < ColumnsSumValueArray.Length; i++)
        {
            result[i] = ColumnsSumValueArray[i] / rows;
            result[i] = Math.Round(result[i], 2);
        }
    }
    return result;
}

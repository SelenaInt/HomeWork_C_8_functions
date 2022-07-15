// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите одно число, определяющее количество строк и столбцов матрицы");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = rows;

int [,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
    {
    matrix[i, j] = new Random().Next(0, 100);
    Console.Write($"{matrix[i, j]}\t");
    }
   
  Console.WriteLine();
}

Console.Write($"Среднее арифметическое каждого столбца: ");

for (int i = 0; i < matrix.GetLength(0); i++)
{
  double arithmeticMeanOfNumbers = 0;
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    arithmeticMeanOfNumbers += matrix[j, i];
  }
  arithmeticMeanOfNumbers = Math.Round(arithmeticMeanOfNumbers / matrix.GetLength(1), 1);
  Console.Write($"{arithmeticMeanOfNumbers},; ");
}
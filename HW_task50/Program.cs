// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите число определяющее количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число определяющее количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Котрое будем искать");
int findNumber = Convert.ToInt32(Console.ReadLine());
int foundNumber = 0;

int [,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
    {
    matrix[i, j] = new Random().Next(-100, 100);
    Console.Write($"{matrix[i, j]}\t");
    if (j == findNumber) foundNumber = findNumber;
    }
    
  Console.WriteLine();
}
if (foundNumber == findNumber) Console.WriteLine($"Элемент {findNumber} присутствует");
else Console.WriteLine($"Элемент {findNumber} НЕ присутствует");


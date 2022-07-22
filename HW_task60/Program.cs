// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.WriteLine("Введите размерность 1 (количество строк массивов): ");
int deep1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность 2 (количество строк внутри массива): ");
int deep2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность 3 (количество столбцов): ");
int deep3 = Convert.ToInt32(Console.ReadLine());

int[,,] threeDeepArray = new int[deep1, deep2, deep3];

for (int i = 0; i < threeDeepArray.GetLength(0); i++)
{
    for (int j = 0; j < threeDeepArray.GetLength(1); j++)
    {
        for (int k = 0; k < threeDeepArray.GetLength(2); k++)
        {
            threeDeepArray[i, j, k] = new Random().Next(10, 100);          // создали 3 D массив
            Console.Write($"{threeDeepArray[i, j, k]} ({i},{j},{k}) \t"); // вывели на печать
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

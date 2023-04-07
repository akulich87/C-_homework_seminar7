// Задайте двумерный массив размером m x n, 
// заполненный случайными вещественными числами

// m=3, n=4

// 0,5   7   -2  -0,2
//  1  -3,3   8  -9,9
//  8   7,8 -7,1   9

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[num1,num2];

for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    array [i,j] = new Random().Next(-100,100);
    array [i,j] = array [i,j]/10;
    Console.Write(array[i,j]+" "); 
  }
  Console.WriteLine();
}

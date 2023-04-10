// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите строку элемента:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите столбец элемента:");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [4,4]; 

for (int i = 0; i < array.GetLength(0); i++) 
{
  for (int j = 0; j < array.GetLength(1); j++) 
  {
    array[i,j] = new Random().Next(1,10); 
    Console.Write(array[i,j]+" "); 
  }
  Console.WriteLine(); 
}

Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++) 
{
  for (int j = 0; j < array.GetLength(1); j++) 
  {
    int num = a + b;
    if(num == array[i,j])
    {
      Console.WriteLine($"{num} -> такое число присутствует в массиве");
    }
    else 
    {
      Console.WriteLine($"{num} -> такого числа в массиве нет");
    }
  }
  Console.WriteLine();
}

// for (int i = 0; i < array.GetLength(0); i++) 
// {
//   for (int j = 0; j < array.GetLength(1); j++) 
//   {
//     int num = a+b;
//     if(num == array[i,j])
//     {
//       Console.WriteLine($"{num} -> такое число присутствует в массиве");
//     }
//     else 
//     {
//       Console.WriteLine($"{num} ->такого числа в массиве нет");
//     }
//   }
//   Console.WriteLine();
// }
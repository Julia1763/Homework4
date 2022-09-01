/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */ 

Console.WriteLine("Введите число строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[] sum = new int[row];
int[,] matrix = new int[row, columns];

int[,] Matrix = CreateArray(matrix);

PrintArray(Matrix);
Console.WriteLine("");
SumOfRows(Matrix);
MinOfRows(Matrix);



void PrintArray(int[,] matr)
{

 for (int i = 0; i < matr.GetLength(0); i++)
 {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write(matr[i, j] + " ");
    }
    Console.WriteLine("");
 }

}

int[,] CreateArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
 {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = new Random().Next(0, 10);
    }  
}
return matr;
}

int[] SumOfRows (int[,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++) 
{ 
   for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum[i] += matr[i, j];
          
    }
 Console.Write($"Сумма {i+1} строки = {sum[i]}" + "; ");
}
return sum;
}

int MinOfRows (int[,] matr)
{
    int Min = sum[0];
for (int i = 0; i < matr.GetLength(0); i++) 
{   
  if (Min >= sum[i])
  {
    Min = sum[i];
  }
}
return Min;
}
Console.WriteLine($"Сумма минимальной строки равна {MinOfRows(Matrix)}");

/*int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}*/


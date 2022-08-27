/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
m = 1, n =7 -> такого числа в массиве нет */ 

Console.WriteLine("Введите число строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число, которое необходимо найти: ");
int element = int.Parse(Console.ReadLine());
Console.WriteLine();


int[,] matrix = new int[row, columns];

int[,] Matrix = CreateArray(matrix, 0, 100);
PrintArray(Matrix);
Console.WriteLine();
check(Matrix);




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

int[,] CreateArray(int[,] matr, int min, int max)
{
  for (int i = 0; i < matr.GetLength(0); i++)
 {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = new Random().Next(min, max+1);
    }  
}
return matr;
}

void check(int[,] matr)
{   
for (int i = 0; i < matr.GetLength(0); i++)
 {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
       if (matr[i, j] == element)
       {
         Console.WriteLine($"{i}, {j}");
       }
       else
       {
        Console.WriteLine("Введенного элемента в массиве нет");
        break;
       }
    }
}
}  



/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. */ 

Console.WriteLine("Введите число строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = int.Parse(Console.ReadLine());
double[,] matrix = new double[row, columns];

double[,] Matrix = CreateArray(matrix);

PrintArray(Matrix);


void PrintArray(double[,] matr)
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

double[,] CreateArray(double[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
 {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = new Random().Next(-10, 10);
    }  
}
return matr;
}


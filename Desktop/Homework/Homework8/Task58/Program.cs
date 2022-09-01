/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/ 

Console.WriteLine("Введите число строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("");

int[,] matrix1 = new int[row, columns];

int[,] Matrix1 = CreateArray(matrix1);
Console.WriteLine("Вывод первой матрицы");
PrintArray(Matrix1);
Console.WriteLine("");

int[,] matrix2 = new int[row, columns];

int[,] Matrix2 = CreateArray(matrix2);
Console.WriteLine("Вывод второй матрицы");
PrintArray(Matrix2);
Console.WriteLine("");

int[,] matrix3 = new int[row, columns];
MatrixProduct(Matrix1, Matrix2, matrix3);
Console.WriteLine("Вывод результирующей матрицы");
PrintArray(matrix3);


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

void MatrixProduct(int[,] matr1, int[,] matr2, int[,] matr3)
{
    for (int i = 0; i < matr3.GetLength(0); i++)
 {
    for (int j = 0; j < matr3.GetLength(1); j++)
    {
       
    int sum = 0; 
      for (int k = 0; k < matr1.GetLength(1); k++)
      {
        sum += matr1[i, k]*matr2[k, j];
      }
      matr3 [i,j] = sum;
    }
 }
}

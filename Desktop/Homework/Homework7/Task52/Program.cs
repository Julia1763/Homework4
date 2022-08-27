/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */ 

Console.WriteLine("Введите число строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[] sum = new int[columns];
double[] Avarage = new double[columns];

Console.WriteLine();


int[,] matrix = new int[row, columns];

int[,] Matrix = CreateArray(matrix, 0, 100);
PrintArray(Matrix);
Console.WriteLine();
SA(Matrix);
Console.WriteLine();






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

double[] SA (int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    
{ 
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        sum[j] += matr[i, j];
        Avarage[j] = sum[j] / row;
         
    }
 Console.Write(Avarage[j] + "; ");
}
return Avarage;
}

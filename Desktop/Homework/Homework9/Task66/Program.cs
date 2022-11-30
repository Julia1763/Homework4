/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */ 

int SumOfMN (int M, int N)
{
   if (M == N) {
      return M;
    } else if(M < N) {
      return M + SumOfMN(M+1, N);
    } else {
      return N + SumOfMN(M, N+1);
    }
}
Console.WriteLine("Введите первое число: ");
int Fnumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int Snumber = int.Parse(Console.ReadLine());
Console.WriteLine(SumOfMN(Fnumber, Snumber));
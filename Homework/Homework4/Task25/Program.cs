/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. */

Console.WriteLine("Введите число: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int numB = int.Parse(Console.ReadLine());

int RaisedToThePower(int A, int B)
{
    int result=1;
    for (int i = 1; i <=B; i++)
    {
      result*=A;
    }
    return result;
}

if (numB>0)
{
  Console.WriteLine(RaisedToThePower(numA, numB));
}
else
{
  Console.WriteLine("Степень числа введена некорректно");  
}

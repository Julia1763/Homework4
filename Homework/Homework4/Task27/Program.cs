/* Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе. */

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int SumOfDigit(int N)
{
    int sum = 0;
    while (N>0)
    {
      sum+=N%10;
      N/=10;
    }
    return sum;
}

Console.WriteLine(SumOfDigit(number));

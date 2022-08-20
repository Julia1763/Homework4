/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] RandArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
       for (int i = 0; i < size; i++)
     {
      arr[i] = new Random().Next(minValue, maxValue+1);
     }
return arr;
}
Console.WriteLine("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());

  int[] array = RandArray(size,100, 999);
Console.WriteLine(String.Join(", ", array));

int check(int[] array)
{
    int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2==0)
    {
        count++;
    }
}
return count;
}

Console.WriteLine($"Количество четных чисел в массиве равно {check(array)}");



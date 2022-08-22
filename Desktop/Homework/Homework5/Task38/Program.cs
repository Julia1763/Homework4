/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */ 

double[] RandArray(int size)
{
    double[] arr = new double[size];
       for (int i = 0; i < size; i++)
     {
      arr[i] = new Random().Next(-10,101);
     }
return arr;
}
Console.WriteLine("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());

double[] array = RandArray(size);
Console.WriteLine($"Исходный массив: {String.Join(", ", array)}");

double Min = 0;
double Max = 0;
for (int i = 0; i < array.Length; i++)
{
  if (Min >= array[i])
  {
    Min = array[i];
  }
  if (Max < array[i])
  {
    Max = array[i];
  }
}
Console.WriteLine($"Максимальное значение = {Max}");
Console.WriteLine($"Минимальное значение = {Min}");
double result = Max - Min;
Console.WriteLine($"Разность между максимальным и минимальным значением = {result}");
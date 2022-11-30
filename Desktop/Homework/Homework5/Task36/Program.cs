/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] RandArray(int size)
{
    int[] arr = new int[size];
       for (int i = 0; i < size; i++)
     {
      arr[i] = new Random().Next();
     }
return arr;
}
Console.WriteLine("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());

  int[] array = RandArray(size);
Console.WriteLine(String.Join(", ", array));

int SumOdd = 0;
for (int i = 0; i < array.Length; i++)
{
  if (i % 2 == 1)
  {
    SumOdd+=array[i];
  }
    
}

Console.WriteLine(SumOdd);
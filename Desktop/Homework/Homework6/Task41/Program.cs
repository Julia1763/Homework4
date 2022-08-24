/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int[] UserArray(int size)
{
    
    int[] arr = new int[size];
       for (int i = 0; i < size; i++)
     {
      Console.WriteLine($"Введите число под номером {i}");
      arr[i] = int.Parse(Console.ReadLine());
      
     }
     return arr;

}

Console.WriteLine("Введите длину массива: ");
    int size = int.Parse(Console.ReadLine());

int[] array = UserArray(size);
Console.WriteLine("Вывод чисел, заданных пользователем: ");
Console.WriteLine(String.Join(", ", array));

int SumPos = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] > 0)
  {
    SumPos+=array[i];
  }
   
}
if (SumPos > 0)
{
   Console.WriteLine($"Сумма положительных чисел равна: {SumPos}"); 
}
else
{
    Console.WriteLine("Положительные числа отсутствуют!"); 
}

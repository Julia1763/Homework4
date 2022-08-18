/* Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран. */
Console.WriteLine("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начало диапазона чисел: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конец диапазона чисел: ");
int numB = int.Parse(Console.ReadLine());


void RandArray()
{
    if (N>0)
    {
        int []arr = new int[N];
       for (int i = 0; i < N; i++)
{
    arr[i] = new Random().Next(numA,numB);
}
Console.Write($"[{String.Join(", ", arr)}]");
    }

else
{
   Console.Write("Количество элементов массива не может быть отрицательным или равным 0.");
}
}

RandArray();
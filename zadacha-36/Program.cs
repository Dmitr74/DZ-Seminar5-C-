// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();

int[] FillArrayWithRandomNumbers(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(10, 99);
        }
        return arr;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine($"[{string.Join(", ", array)}]");

int Sum = 0;

for (int i = 1; i < array.Length; i+=2)
{
    if (array[i] >= 10 && array[i] <= 99)
    {
        Sum = Sum + array[i];
    }
                
}
Console.Write($"Сумма чисел нечётных индексов массива: {Sum}");
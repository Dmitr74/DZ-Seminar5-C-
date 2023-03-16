// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int Entry(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double[] ArrRandom(int lenght)
{
    double[] arr = new double[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() + new Random().Next(0, 100), 1);
    }
    return arr;
}

double MinMaxNumber(double[] array)
{
    double min = array[0], max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return Math.Round(max - min, 1);
}

int lenght = Entry("Введите длину массива: ");
double[] arr = ArrRandom(lenght);
Console.WriteLine($"[{string.Join("; ", arr)}]");

Console.WriteLine($" Разница максимального и минимального числа массива: {MinMaxNumber(arr)}");

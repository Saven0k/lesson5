// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
double[] GetArray(int size)
{
    double[] res = new double[size];
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * (1000 - 100);
        if (i == size - 1) Console.Write($"{Math.Round(res[i], 2)}");
        else Console.Write($"{Math.Round(res[i], 2)} , ");
    }
    Console.Write("]");
    return res;
}
Console.WriteLine("                 ");
double DifferenceNumbersInArray(double[] arra)
{
    double min = arra[0];
    double max = 0;
    double result = 0;
    for (int g = 0; g < arra.Length; g++)
    {
        if (min > arra[g]) min = arra[g];
        else max = arra[g];
    }
    result = (Math.Round(max, 2)) - (Math.Round(min, 2));
    Console.Write($" -> {Math.Round(result, 2)} ");
    return result;
}
double[] array = GetArray(4);
DifferenceNumbersInArray(array);
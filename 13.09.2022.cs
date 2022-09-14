// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        if (i == size - 1) Console.Write($"{res[i]}");
        else Console.Write($"{res[i]} , ");
    }
    Console.Write("]");
    return res;
}
int result = 0;
int OddNumbers(int[] arra)
{
    for (int i = 0; i < arra.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += arra[i];
        }
    }
    Console.Write($" ->  {result}");
    return result;
}


Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int[] array = GetArray(a, -10, 10);
OddNumbers(array);
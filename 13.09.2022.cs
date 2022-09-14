// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        if (i == size - 1) Console.Write($"{res[i]}");
        else Console.Write($"{res[i]} , ");
    }
    Console.Write("]");
    return res;
}
Console.WriteLine("   ");
int[] GetMultiplication(int[] array2)
{
    int[] end = new int[5];
    int array2Lnegh = 0;
    if (array2.Length%2 == 0) array2Lnegh = array2.Length / 2;
    else array2Lnegh = array2.Length / 2 + 1;
    end = new int[array2Lnegh];
    for (int i = 0; i < array2Lnegh; i++)
    {
        if (i == array2Lnegh - 1) end[i] = array2[i];
        else end[i] = array2[i] * array2[array2.Length - i - 1];
    }
    return end;
}
void PrintArray(int[] array3)
{
    for (int i = 0; i < array3.Length; i++) Console.Write($" {array3[i]} ");
}
int[] array = GetArray(11, 1, 9);
int[] array_2 = GetMultiplication(array);
Console.Write("  -> ");
PrintArray(array_2);
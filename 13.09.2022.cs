// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        if (i == size-1) Console.Write($"{res[i]}");
        else Console.Write($"{res[i]} , ");
    } 
    Console.Write("]");
    return res;
}

int[] array = GetArray(5, -9, 9);
Console.WriteLine("   ");
for (int i = 0; i < array.Length;i++) array[i] *= -1;
Console.Write('[');
// foreach(int el in array)
// {
//     if (array[el] == array[-1]) Console.Write($"{el}");
// else Console.Write($"{el} ,");
// }
for(int g= 0;g<array.Length;g++)
{
    if (g == array.Length-1) Console.Write($"{array[g]}");
    else Console.Write($"{array[g]} , ");
}
Console.WriteLine(']');
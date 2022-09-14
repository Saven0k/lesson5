//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        if (i == size-1) Console.Write($"{res[i]}");
        else Console.Write($"{res[i]} , ");
    } 
    Console.Write("]");
    return res;
}
int count = 0;
int CountEvenNumbers(int[] arra)
{
    foreach(int i in arra){
        if (i % 2 == 0) count ++;
        else count += 0;
    }
    Console.Write($" -> {count}");
    return count;
}
int[] array = GetArray(6, 100 , 1000);
CountEvenNumbers(array);

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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
int result = 0;
void Find_value(int[] arra )
{
    foreach (int i in arra)
    {
        if (i>10 && i<100) 
        {
            count++;
        } 
        else result += 0;
    }
    Console.Write($"-> {count}");
}
int [] array = GetArray(123 , 1 , 123);
Find_value(array);
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
int mbhaving = 0;
int count = 0;
void Find_value(int[] arra , int value)
{
    foreach (int i in arra)
    {
        if (i==value) 
        {
            count++;
            mbhaving += 1;
        } 
        else {}
    }
        if (mbhaving > 0) 
        { 
            if (count == 2 || count == 3 || count == 4)
            {
                Console.Write($" < - {value}  -> да , {count} раза");
            }
            else
            {
                Console.Write($" < - {value}  -> да , {count} раз");
            }
        
        }     
        else Console.Write($" {value} -> нет");
}
Console.Write("Введите число: ");
int nnvalue = int.Parse(Console.ReadLine());
int[] array = GetArray(10 , -2, 3);
Find_value(array , nnvalue);